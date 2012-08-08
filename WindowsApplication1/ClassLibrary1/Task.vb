Public Class Task
    Public Enum Priority
        Important = 0
        VeryHigh = 1
        High = 2
        Normal = 3
        Low = 4
        VeryLow = 5
    End Enum
    Public Enum Type
        Waiting = 0
        Working = 1
        Walking = 2
    End Enum
    Public ReadOnly TaskType As Integer
    Public ReadOnly TaskPriority As Integer
    Public Sub New()

    End Sub
End Class
