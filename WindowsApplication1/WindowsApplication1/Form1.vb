Imports GameLogic 'ни с чем не сравнимая красота быдлокода

Public Class Form1
    Private HumanList As New List(Of Human)
    Private FNameList As New List(Of String)
    Private SNameList As New List(Of String)
    Private NullHuman As New Human("Nulled Human - not used in code!") 'яркий пример быдлокода.
    Private Person As Human
    Private Enemy As Human = NullHuman
    Private brk As Boolean

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FNameList.Add("Дмитрий")
        FNameList.Add("Алексей")
        FNameList.Add("Евгений")
        FNameList.Add("Джон")
        FNameList.Add("Алекс")
        FNameList.Add("Максим")
        FNameList.Add("Павел")
        SNameList.Add("Ленский")
        SNameList.Add("Гавриленко")
        SNameList.Add("Иванов")
        SNameList.Add("Петров")
        SNameList.Add("Сидоров")
        SNameList.Add("Мэйсон")
        SNameList.Add("Шепард")
        ListBox3.Items.Add("Sleep")
        ListBox3.Items.Add("Attack")
        ListBox3.Items.Add("Use")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex < 0 Then
            For i = 0 To ListBox2.Items.Count - 1
                If HumanList(i).State = Human.States.Died Then
                    HumanList.RemoveAt(i)
                Else
                    ListBox1.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
        Person = HumanList.Item(ListBox1.SelectedIndex)
        PersonControl.UpdateControl(Person)
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged ' очень яркий пример быдлокода
        If ListBox2.SelectedIndex < 0 Or Enemy.State = Human.States.Died Then
            For i = 0 To ListBox2.Items.Count - 1
                If HumanList(i).State = Human.States.Died Then
                    HumanList.RemoveAt(i)
                Else
                    ListBox2.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
        Enemy = HumanList.Item(ListBox2.SelectedIndex)
        EnemyControl.UpdateControl(Enemy)
    End Sub

    Private Sub EnemyUpdate()
        If ListBox2.SelectedIndex < 0 Or Enemy.State = Human.States.Died Then
            For i = 0 To ListBox2.Items.Count - 1
                If HumanList(i).State = Human.States.Died Then
                    HumanList.RemoveAt(i)
                Else
                    ListBox2.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
        Enemy = HumanList.Item(ListBox2.SelectedIndex)
        EnemyControl.UpdateControl(Enemy)
    End Sub

    Private Sub UpdateControls() ' по идее работает. но не всегда так как хотелось бы(
        'If ListBox2.SelectedIndex < 0 Or Enemy.State = Human.States.Died Then
        '    For i = 0 To ListBox2.Items.Count - 1
        '        If HumanList(i).State = Human.States.Died Then
        '            HumanList.RemoveAt(i)
        '        Else
        '            ListBox2.SelectedIndex = i
        '            Exit For
        '        End If
        '    Next
        'End If
        'Enemy = HumanList.Item(ListBox2.SelectedIndex)
        'EnemyControl.UpdateControl(Enemy)
        'If ListBox1.SelectedIndex < 0 Then
        '    For i = 0 To ListBox2.Items.Count - 1
        '        If HumanList(i).State = Human.States.Died Then
        '            HumanList.RemoveAt(i)
        '        Else
        '            ListBox1.SelectedIndex = i
        '            Exit For
        '        End If
        '    Next
        'End If
        'Person = HumanList.Item(ListBox1.SelectedIndex)
        'PersonControl.UpdateControl(Person)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case ListBox3.SelectedItem.ToString
            Case "Attack"
                If (Enemy.State <> Human.States.Died) Then
                    If Person <> Enemy Then
                        Person.Hit(Enemy)
                    Else
                        MsgBox("Error: Cant hit himself")
                    End If
                Else
                    EnemyUpdate()
                End If
            Case "Sleep"
                If Person.TireLevel > 25 Then
                    Person.Sleep(Val(InputBox("Time in mins to sleep")))
                End If
        End Select
        'UpdateControls()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim name As String = FNameList.Item(Int(Rnd() * FNameList.Count)) + " " + SNameList.Item(Int(Rnd() * SNameList.Count))
        HumanList.Add(New Human(name))
        ListBox1.Items.Add(name)
        ListBox2.Items.Add(name)
    End Sub
End Class
