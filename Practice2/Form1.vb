Public Class frmMain
    Dim pe As Person
    Private Sub addBttn_Click(sender As Object, e As EventArgs) Handles addBttn.Click

    End Sub
    Public Function instantiate() As Person
        Return New Person(txtBox1.Text)
    End Function
End Class
