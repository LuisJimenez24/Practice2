Public Class Person
    Private _personId As Integer
    Private _name As String

    Public ReadOnly Property per As Integer
        Get
            Return _personId
        End Get
    End Property

    Public Property nm As String
        Set(name As String)
            Me._name = name

        End Set
        Get
            Return _name
        End Get
    End Property

    Public Sub New(ByVal prsnid As Integer)
        Me._name = prsnid
    End Sub

    Public Function insertPerson() As Integer


    End Function

    Public Function updatePerson() As Integer

    End Function

    Public Function deletePerson() As Integer

    End Function

    Public Sub readAll()

    End Sub

    Public Sub readPerson()

    End Sub
End Class
