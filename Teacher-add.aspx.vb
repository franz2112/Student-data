Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlException
Imports System.Data
Public Class Teacher_add
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TeaSubmit_Click(sender As Object, e As EventArgs) Handles TeaSubmit.Click
        Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
        Dim con As MySqlConnection = Nothing
        con = New MySqlConnection(connstring)
        Dim cmd As New MySqlCommand
        con.Open()
        cmd = New MySqlCommand("INSERT INTO teacher values (' " & TeacherIDCode.Text & " ', ' " & TeacherNameCode.Text & " ', ' " & DepartmentCode.Text & " ')", con)
        If (TeacherIDCode.Text = "" Or TeacherNameCode.Text = "" Or DepartmentCode.Text = "") Then
            MsgBox("Please Fill-up all the information")
        Else
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Data stored Successfully", MsgBoxStyle.Information, "Success")
        End If

    End Sub

    Protected Sub TeaCancel_Click(sender As Object, e As EventArgs) Handles TeaCancel.Click
        Response.Redirect("Main-menu.aspx")
    End Sub
End Class