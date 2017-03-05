Public Class Person
    Private _personId As String
    Private _name As String
    Private DAO As DAOPerson = New DAOPerson

    Public ReadOnly Property per As String
        Get
            Return _personId
        End Get
    End Property

    Public Property name As String
        Get
            Return _name
        End Get
        Set(ByVal nm As String)
            Me._name = nm
        End Set
    End Property

    Public Sub New(ByVal prsnid As String)
        Me._personId = prsnid
    End Sub

    Public Sub New()

    End Sub

    Public Function insertPerson() As Integer
        Return DAO.insert(Me)
    End Function

    Public Function updatePerson() As Integer
        Return DAO.update(Me)
    End Function

    Public Function deletePerson() As Integer
        Return DAO.delete(Me)
    End Function

    Public Function readPerson()
        Return DAO.read(Me)
    End Function

    Public Function readAll()
        Return DAO.readAll()
    End Function

End Class
