Public MustInherit Class InvItem
    Private _weight As Byte = 5
#Region "Default Properties"
    Protected _id As Integer
    Protected Shared _lastid As Integer = -2
    Public ReadOnly Property ID As Integer
        Get
            Return _id
        End Get
    End Property
    Protected _name As String
    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property
    Protected _type As Integer
    Public ReadOnly Property Type As Integer
        Get
            Return _type
        End Get
    End Property
#End Region
    Public ReadOnly Property Weight As Byte
        Get
            Return _weight
        End Get
    End Property
    Public Enum ItemType
        Food = 0
        Medkit = 1
    End Enum
End Class

Public Class MedKit : Inherits InvItem 'должен быть mustinherit!
    Private _cure As Byte = 30
    Public ReadOnly Property Cure
        Get
            Return _cure
        End Get
    End Property

    Public Sub New(ByVal name As String)
        _lastid += 1
        _id = _lastid
        _name = name
        _type = ItemType.Medkit
    End Sub
End Class

Public Class Food : Inherits InvItem
    Private _energy As Byte = 7
    Public ReadOnly Property Energy
        Get
            Return _energy
        End Get
    End Property

    Public Sub New(ByVal name As String)
        _lastid += 1
        _id = _lastid
        _name = name
        _type = ItemType.Food
    End Sub
End Class
