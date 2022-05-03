Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlException
Imports System.Data
Public Class Student_add
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub StudSubmit_Click(sender As Object, e As EventArgs) Handles StudSubmit.Click
        Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
        Dim con As MySqlConnection = Nothing
        con = New MySqlConnection(connstring)
        Dim cmd As New MySqlCommand
        con.Open()
        cmd = New MySqlCommand("INSERT INTO student values (' " & StudentIDCode.Text & " ', ' " & StudNameCode.Text & " ', ' " & YearCode.Text & " ')", con)
        If (StudentIDCode.Text = "" Or StudNameCode.Text = "" Or YearCode.Text = "") Then
            MsgBox("Please Fill-up all the information")
        Else
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Data stored Successfully", MsgBoxStyle.Information, "Success")
        End If

    End Sub

    Protected Sub StudCancel_Click(sender As Object, e As EventArgs) Handles StudCancel.Click
        Response.Redirect("Main-menu.aspx")
    End Sub
End Class