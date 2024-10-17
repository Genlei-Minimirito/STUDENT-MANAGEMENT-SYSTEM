Imports MySql.Data.MySqlClient
Public Class frmLogIn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUname.Text = "" Or txtPword.Text = "" Then
            MsgBox("Please fill required fields.", MsgBoxStyle.Exclamation, "Message Prompt")
            txtPword.Text = ""
            txtUname.Select()
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd = New MySqlCommand("Select * FROM tblLogIn WHERE Uname = @Uname and PWord = @Pword", con)
        End If
    End Sub

    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
    End Sub
End Class