Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Web.UI
Public Class Student_display
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
        Dim conn As MySqlConnection = Nothing
        conn = New MySqlConnection(connstring)
        conn.Open()
        Dim query As String = "Select * from student"
        Dim da As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        da.Fill(ds, "student")
        GridView1.DataSource = ds
        GridView1.DataBind()
        conn.close()
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Student_delete_id.Text = GridView1.SelectedRow.Cells(1).Text
        Student_name_delete.Text = GridView1.SelectedRow.Cells(2).Text
        Year_delete.Text = GridView1.SelectedRow.Cells(3).Text
    End Sub

    Protected Sub Student_delete_Click(sender As Object, e As EventArgs) Handles Student_delete.Click
        If (Student_delete_id.Text = "" Or Student_name_delete.Text = "" Or Year_delete.Text = "") Then
            MsgBox("Nothing to delete, please select a record from Student!", MsgBoxStyle.Information, "Message")
        Else
            Dim ask As MsgBoxResult = MsgBox(Student_delete_id.Text + "Do you want to delete this Student?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
                Dim conn As MySqlConnection = Nothing
                conn = New MySqlConnection(connstring)
                conn.Open()
                Dim cmd As MySqlCommand
                Dim query As String = "Delete from Student where StudentID = '" + Student_delete_id.Text + "'"
                MsgBox("Delete from Student where StudentID = " + Student_delete_id.Text)
                Dim da As New MySqlDataAdapter()
                cmd = New MySqlCommand(query, conn)
                da.DeleteCommand = New MySqlCommand(query, conn)
                da.DeleteCommand.ExecuteNonQuery()
                MsgBox(Student_delete_id.Text + " has been deleted!!!")
                Student_delete_id.Text = ""
                Student_name_delete.Text = ""
                Year_delete.Text = ""

                cmd.Dispose()
                conn.Close()
            End If
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Main-menu.aspx")
    End Sub

    Protected Sub studentUpdatebtn_Click(sender As Object, e As EventArgs) Handles StudentUpdatebtn.Click
        If (Student_delete_id.Text = "" Or Student_name_delete.Text = "" Or Year_delete.Text = "") Then
            MsgBox("Nothing to update, please select a record from student!", MsgBoxStyle.Information, "Message")
        Else
            Dim ask As MsgBoxResult = MsgBox(Student_delete_id.Text + "Do you want to update this student?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
                Dim conn As MySqlConnection = Nothing
                conn = New MySqlConnection(connstring)
                conn.Open()
                Dim cmd As MySqlCommand
                Dim query As String = "Update student set studentName ='" + Student_name_delete.Text + "', Year = '" + Year_delete.Text + "' where studentID  = '" + Student_delete_id.Text + "'"
                Dim da As New MySqlDataAdapter()
                cmd = New MySqlCommand(query, conn)
                da.UpdateCommand = New MySqlCommand(query, conn)
                da.UpdateCommand.ExecuteNonQuery()
                MsgBox(Student_delete_id.Text + "has been updated!!!", MsgBoxStyle.Information, "student")
                Student_delete_id.Text = ""
                Student_name_delete.Text = ""
                Year_delete.Text = ""
                cmd.Dispose()
                conn.Close()
            End If
        End If
    End Sub
End Class