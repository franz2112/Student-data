Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlException
Imports System.Data
Public Class Subject_add
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub SubjectCode_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub SubjSubmit_Click(sender As Object, e As EventArgs) Handles SubjSubmit.Click

        Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
        Dim con As MySqlConnection = Nothing
        con = New MySqlConnection(connstring)
        Dim cmd As New MySqlCommand
        con.Open()
        cmd = New MySqlCommand("INSERT INTO subject values (' " & SubjectCode.Text & " ', ' " & DescriptionCode.Text & " ', ' " & UnitCode.Text & " ', ' " & TeacherCode.Text & " ', ' " & DayCode.Text & " ', ' " & TimeCode.Text & " ')", con)
        If (SubjectCode.Text = "" Or DescriptionCode.Text = "" Or UnitCode.Text = "" Or TeacherCode.Text = "" Or DayCode.Text = "" Or TimeCode.Text = "") Then
            MsgBox("Please Fill-up all the information")
        Else
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Data stored Successfully", MsgBoxStyle.Information, "Success")
        End If

    End Sub

    Protected Sub SubjCancel_Click(sender As Object, e As EventArgs) Handles SubjCancel.Click
        Response.Redirect("Main-menu.aspx")
    End Sub

End Class