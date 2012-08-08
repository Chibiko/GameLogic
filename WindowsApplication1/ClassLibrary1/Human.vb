Public NotInheritable Class Human
#Region "Блок обьявления параметров. Желательно ничего не трогать."
    Private _tirecoef As Integer = 1
    Private _id As Integer
    Private Shared _lastid As Integer = -2
    Public Property ID As Integer
        Get
            Return _id
        End Get
        Private Set(value As Integer)
            _id = value
        End Set
    End Property
    Private _health As Integer = 100
    Public Property Health As Integer
        Get
            Return _health
        End Get
        Private Set(ByVal value As Integer)
            _health = value
        End Set
    End Property
    Public ReadOnly InvList As List(Of InvItem)
    Private _cash As Integer
    Public Property Cash
        Get
            Return _cash
        End Get
        Private Set(value)
            _cash = value
        End Set
    End Property
    Public TaskList As List(Of Task)
    Private _hunger As Integer = 0
    Public Property Hunger As Integer
        Get
            Return _hunger
        End Get
        Private Set(ByVal value As Integer)
            _hunger = value
        End Set
    End Property
    Private _state As Integer = 0
    Public Enum States As Integer
        NotDecl = -2
        Died = -1
        Living = 0
        FeelVeryBad = 1
        Tired = 2
        BonesBroken = 3
        Poisoned = 4
    End Enum
    Public Property State
        Get
            Return _state
        End Get
        Private Set(ByVal value)
            _state = value
        End Set
    End Property
    Private _poisons
    Private _tirelevel As Integer
    Public Property TireLevel As Integer
        Get
            Return _tirelevel
        End Get
        Private Set(ByVal value As Integer)
            _tirelevel = value * _tirecoef
            If _tirelevel > 75 Then State = States.Tired 'проверка состояния усталости (если больше 75% то значит устал)
            If _tirelevel <= 75 Then State = States.Living
        End Set
    End Property
    Private _name As String
    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property
    Private _strength As Integer
    Public ReadOnly Property Strength
        Get
            Return _strength
        End Get
    End Property
#End Region

#Region "Блок конструктора."
    Public Sub New(ByVal name As String)
        _lastid += 1 'не трогать
        _id = _lastid 'не трогать
        _name = name 'имя человека - задается при описании new
        _strength = 15 'меняем на необходимую базовую силу
        _state = States.Living 'не трогать иначе он умрет!
    End Sub
    Public Shared Operator =(ByVal obj1 As Human, ByVal obj2 As Human) ' переопределение равно
        Return obj1.ID = obj2.ID
    End Operator
    Public Shared Operator <>(ByVal obj1 As Human, ByVal obj2 As Human) 'переопределение неравно
        Return obj1.ID <> obj2.ID
    End Operator
#End Region

#Region "Функциональный блок. Редактировать только алгоритмы."
    Public Sub Hit(ByVal target As Human) 'отвечает за нанесение тяжких телесных повреждений
        If TireLevel < 80 Then 'проверка на усталость. если меньше 80% то атака возможна
            Dim dmg As Integer = Int(Me.Strength - Me.TireLevel / 2 - State * 2) 'рассчет урона
            Dim def As Integer = Int(Rnd() * 100 / 25) 'рассчет вероятности крит. удара
            If def > 2 Then
                dmg += Me.Strength * 1.5 - State * 4 'собсно рассчет доп. урона
                If def = 3 Then target.State = States.BonesBroken 'при некоторой вероятности можно кому нибудь что нибудь сломать.
                If def = 4 Then target.State = States.Poisoned 'ну или отравить o_O (ударом?!)
            End If
            target.GotDmg(dmg) 'передача урона обьекту
            Me.TireLevel += 5 'ну и чуть чуть усталости в придачу
        End If
    End Sub
    Private Sub GotDmg(ByVal damage As Integer)
        Me.Health -= Math.Abs(damage * Int((TireLevel + State + 8) / 8)) 'абс чтоб не воскресали блин!
        Select Case Me.Health 'если уровень здоровья становится не особо хорошим человек может себя чувствовать не совсем хорошо (а в некоторых случаях он чувствует себя трупом)
            Case Is <= 0 : Me.State = States.Died
            Case Is <= 20 : Me.State = States.FeelVeryBad
        End Select
    End Sub
    Public Sub Sleep(ByVal time As Integer) 'сон. происходит восстановление сил и небольшое восстановление здоровья
        Me.TireLevel -= time / Me.Health
        Me.Health += Int(time / 1000)
        If Me.TireLevel < 0 Then Me.TireLevel = 1
        If Me.Health > 100 Then Me.Health = 100
        _tirecoef -= (time - 60 * 7) / time
    End Sub
    Private Sub Die(HumanList As List(Of Human)) 'сдохни! не юзается однако может понадобиться
        For i = 0 To _lastid
            If HumanList.Item(i).State = Human.States.Died Then
                For j = i To _lastid
                    HumanList.Item(j).ID = j
                Next
            End If
        Next
    End Sub
    Public Sub Use(InvItemID As Integer) 'использование предметов из инвентаря.
        Select Case Me.InvList(InvItemID).Type
            Case InvItem.ItemType.Food
                Dim food As Food
                food = Me.InvList(InvItemID)
                Me.Hunger -= food.Energy * 5
            Case InvItem.ItemType.Medkit
                Dim kit As MedKit
                kit = Me.InvList(InvItemID)
                Me.Health -= kit.Cure
        End Select
    End Sub
    Public Sub Tick() 'вот эту процедурку необходимо вызывать раз в 1 цикл
        If TaskList.Count > 0 Then
            Select Case TaskList.First.TaskType
                Case Task.Type.Waiting
                    TireLevel += 2
                    Hunger += 4
                Case Task.Type.Walking
                    TireLevel += 6
                    Hunger += 7
                Case Task.Type.Working
                    TireLevel += 9
                    Hunger += 14
                    Cash += 100
            End Select
        End If
    End Sub
#End Region
End Class
