Public Class HumanControl

    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавьте все инициализирующие действия после вызова InitializeComponent().

    End Sub
    Public Sub UpdateControl(Human As GameLogic.Human)
        HumanHealth.Value = Human.Health
        HumanTire.Value = Human.TireLevel
        HumanName.Text = Human.Name
        HumanID.Value = Human.ID
        Select Case Human.State
            Case GameLogic.Human.States.BonesBroken : HumanState.Text = "Есть перелом"
            Case GameLogic.Human.States.Died : HumanState.Text = "Мертв"
            Case GameLogic.Human.States.FeelVeryBad : HumanState.Text = "Ужасное самочувствие"
            Case GameLogic.Human.States.Living : HumanState.Text = "Живой"
            Case GameLogic.Human.States.Poisoned : HumanState.Text = "Отравлен или заболел"
            Case GameLogic.Human.States.Tired : HumanState.Text = "Устал (" + CStr(Human.TireLevel) + "%)"
        End Select
    End Sub
End Class
