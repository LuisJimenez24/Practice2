Imports System.Data.OleDb

Public Class frmMain

    Private Sub addBttn_Click(sender As Object, e As EventArgs) Handles addBttn.Click
        Dim p As Person = New Person(txtID.Text)
        p.name = txtName.Text()
        Try
            If p.insertPerson Then
                Success()
            Else
                ErrInDB()
            End If
        Catch ex As Exception
            ErrInDB()
        End Try
        f5()
    End Sub

    Private Sub connBttn_Click(sender As Object, e As EventArgs) Handles connBttn.Click

        DBBroker.DBPath = txtDBpath.Text
        f5()

    End Sub

    Private Sub dbpathBttn_Click(sender As Object, e As EventArgs) Handles dbpathBttn.Click
        Dim dbpathDialog As New OpenFileDialog()
        If dbpathDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtDBpath.Text = dbpathDialog.FileName
        End If
    End Sub

    Private Sub f5()

        Dim p As Person = New Person
        Dim reader As OleDbDataReader = p.readAll()
        PeopleList.Items.Clear()
        txtID.Clear()
        txtName.Clear()

        Try
            While reader.Read()
                PeopleList.Items.Add(reader("PersonID"))
            End While

        Catch ex As Exception
            ErrInDB()
            PeopleList.Items.Clear()
        End Try

    End Sub

    Private Sub delBttn_Click(sender As Object, e As EventArgs) Handles delBttn.Click
        Dim p As Person = New Person(txtID.Text)
        p.name = txtName.Text()
        Try
            If p.deletePerson() Then
                Success()
            Else
                ErrInDB()
            End If

        Catch ex As Exception
            ErrInDB()
        End Try
        f5()
    End Sub

    Private Sub PeopleList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PeopleList.SelectedIndexChanged
        Dim p As Person = New Person(PeopleList.SelectedItem)
        Dim reader As OleDbDataReader = p.readPerson()


        Try
            While reader.Read
                txtID.Text = reader("PersonID")
                txtName.Text = reader("PersonName")
            End While
        Catch ex As Exception
            ErrInDB()
        End Try


    End Sub

    Private Sub clearBttn_Click(sender As Object, e As EventArgs) Handles clearBttn.Click
        f5()
    End Sub

    Private Sub modBttn_Click(sender As Object, e As EventArgs) Handles modBttn.Click
        Dim p As Person = New Person(txtID.Text)
        p.name = txtName.Text

        Try
            If p.updatePerson() Then
                Success()
            Else
                ErrInDB()
            End If

        Catch ex As Exception
            ErrInDB()
        End Try
    End Sub

    Private Sub ErrInDB()
        MsgBox("Error in the Database")
    End Sub

    Private Sub Success()
        MsgBox("Succesfull operation")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
