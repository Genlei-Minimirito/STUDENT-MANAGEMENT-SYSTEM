Imports MySql.Data
Imports MySql.Data.MySqlClient
Module modConnection
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Public Sub DBConnect()
        Try
            With con
                .ConnectionString = ("server=localhost; user id= root; password= ;database= smsdatabase")
            End With
        Catch ex As Exception
            MsgBox("Unable to connect. Please contact the system administrator!", vbExclamation)
            con.Close()

        End Try
    End Sub
End Module
