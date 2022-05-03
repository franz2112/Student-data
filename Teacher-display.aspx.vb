Imports MySql.Data.MysqlClient
Imports System.Data
Imports System.Web.UI
Public Class Teacher_display
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
        Dim conn As MySqlConnection = Nothing
        conn = New MySqlConnection(connstring)
        conn.Open()
        Dim query As String = "Select * from teacher"
        Dim da As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        da.fill(ds, "teacher")
        GridView1.DataSource = ds
        GridView1.DataBind()
        conn.close()
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Teacher_id__delete.Text = GridView1.SelectedRow.Cells(1).Text
        Teacher_name_delete.Text = GridView1.SelectedRow.Cells(2).Text
        Department_delete.Text = GridView1.SelectedRow.Cells(3).Text
    End Sub

    Protected Sub Teacher_delete_button_Click(sender As Object, e As EventArgs) Handles Teacher_delete_button.Click
        If (Teacher_id__delete.Text = "" Or Teacher_name_delete.Text = "" Or Department_delete.Text = "") Then
            MsgBox("Nothing to delete, please select a record from teacher!", MsgBoxStyle.Information, "Message")
        Else
            Dim ask As MsgBoxResult = MsgBox(Teacher_id__delete.Text + "Do you want to delete this teacher?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
                Dim conn As MySqlConnection = Nothing
                conn = New MySqlConnection(connstring)
                conn.Open()
                Dim cmd As MySqlCommand
                Dim query As String = "Delete from teacher where teacherID = '" + Teacher_id__delete.Text + "'"
                MsgBox("Delete from teacher where teacherID = " + Teacher_id__delete.Text)
                Dim da As New MySqlDataAdapter()
                cmd = New MySqlCommand(query, conn)
                da.DeleteCommand = New MySqlCommand(query, conn)
                da.DeleteCommand.ExecuteNonQuery()
                MsgBox(Teacher_id__delete.Text + " has been deleted!!!", MsgBoxStyle.Information, "Teacher")
                Teacher_id__delete.Text = ""
                Teacher_name_delete.Text = ""
                Department_delete.Text = ""

                cmd.Dispose()
                conn.Close()
            End If
        End If
    End Sub

    Protected Sub Teacher_cancel_button_Click(sender As Object, e As EventArgs) Handles Teacher_cancel_button.Click
        Response.Redirect("Main-menu.aspx")
    End Sub

    Protected Sub Teacher_update_button_Click(sender As Object, e As EventArgs) Handles Teacher_update_button.Click
        If (Teacher_id__delete.Text = "" Or Teacher_name_delete.Text = "" Or Department_delete.Text = "") Then
            MsgBox("Nothing to update, please select a record from teacher!", MsgBoxStyle.Information, "Message")
        Else
            Dim ask As MsgBoxResult = MsgBox(Teacher_id__delete.Text + "Do you want to update this teacher?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
                Dim conn As MySqlConnection = Nothing
                conn = New MySqlConnection(connstring)
                conn.Open()
                Dim cmd As MySqlCommand
                Dim query As String = "Update teacher set teacherName ='" + Teacher_name_delete.Text + "', Department = '" + Department_delete.Text + "' where teacherId  = '" + Teacher_id__delete.Text + "'"
                Dim da As New MySqlDataAdapter()
                cmd = New MySqlCommand(query, conn)
                da.UpdateCommand = New MySqlCommand(query, conn)
                da.UpdateCommand.ExecuteNonQuery()
                MsgBox(Teacher_id__delete.Text + "has been updated!!!", MsgBoxStyle.Information, "teacher")
                Teacher_id__delete.Text = ""
                Teacher_name_delete.Text = ""
                Department_delete.Text = ""
                cmd.Dispose()
                conn.Close()
            End If
        End If
    End Sub
End Class