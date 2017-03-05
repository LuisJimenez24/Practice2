Imports System.Data.OleDb
Imports Practice2

Public Class DAOPerson

    Private personsList As Collection

    Public Function delete(p As Person) As Integer
        Return DBBroker.getInstance().change("DELETE FROM PERSONS  WHERE PersonID='" & p.per & "';")
    End Function

    Public Function insert(ByVal p As Person) As Integer
        Return DBBroker.getInstance().change("INSERT INTO PERSONS VALUES('" & p.per & "','" & p.name & "');")
    End Function

    Public Function update(ByVal p As Person) As Integer
        Return DBBroker.getInstance().change("UPDATE PERSONS SET PersonName='" & p.name & "' WHERE PersonID= '" & p.per & "';")
    End Function

    Public Function read(ByVal p As Person)
        Return DBBroker.getInstance().read("SELECT * FROM PERSONS WHERE PersonID='" & p.per & "';")
    End Function

    Public Function readAll()
        Return DBBroker.getInstance().read("SELECT * FROM PERSONS ORDER BY PersonID;")
    End Function

End Class
