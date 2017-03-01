Imports System.Data.OleDb

Public Class DBBroker
    Public Shared DBPath As String = "C:\people.accdb"
    Private Shared ConnectionString As String = “Provider=Microsoft.ACE.OLEDB.12.0; Data Source=“
    Private Shared _Connection As OleDbConnection
    Private Shared _Instance As DBBroker
    Private Sub New()
        DBBroker._Connection = New OleDbConnection(ConnectionString & DBPath)
        DBBroker._Connection.Open()
    End Sub
    Public ReadOnly Property getInstance() As DBBroker
        Get
            If DBBroker._Instance Is Nothing Then
                Me._Instance = New DBBroker()
            End If
            Return Me._Instance
        End Get
    End Property

    Public Function read(ByVal sql As String) As OleDbDataReader
        Dim com As New OleDbCommand(sql, _Connection)
        Return com.ExecuteReader()
    End Function
    Public Function change(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, _Connection)
        Return com.ExecuteNonQuery()
    End Function
End Class
