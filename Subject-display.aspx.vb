Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Web.UI
Public Class Subject_display
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
        Dim conn As MySqlConnection = Nothing
        conn = New MySqlConnection(connstring)
        conn.Open()
        Dim query As String = "Select * from Subject"
        Dim da As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        da.fill(ds, "Subject")
        GridView1.DataSource = ds
        GridView1.DataBind()
        conn.close()
    End Sub

    Protected Sub GridView1_SelectedIndexChanged1(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Subject_code.Text = GridView1.SelectedRow.Cells(1).Text
        Subject_description.Text = GridView1.SelectedRow.Cells(2).Text
        Subject_units.Text = GridView1.SelectedRow.Cells(3).Text
        Subject_teacher.Text = GridView1.SelectedRow.Cells(4).Text
        Subject_day.Text = GridView1.SelectedRow.Cells(5).Text
        Subject_time.Text = GridView1.SelectedRow.Cells(6).Text
    End Sub

    Private Sub Subject_delete_Click(sender As Object, e As EventArgs) Handles Subject_delete.Click
        If (Subject_code.Text = "" Or Subject_description.Text = "" Or Subject_units.Text = "" Or Subject_teacher.Text = "" Or Subject_day.Text = "" Or Subject_time.Text = "") Then
            MsgBox("nothing to delete, please select a record from subject!", MsgBoxStyle.Information, "Message")
        Else
            Dim ask As MsgBoxResult = MsgBox(Subject_code.Text + "Do you want to delete this subject?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
                Dim conn As MySqlConnection = Nothing
                conn = New MySqlConnection(connstring)
                conn.Open()
                Dim cmd As MySqlCommand
                Dim query As String = "Delete from subject where Subjectcode = '" + Subject_code.Text + "'"
                Dim da As New MySqlDataAdapter()
                cmd = New MySqlCommand(query, conn)
                da.DeleteCommand = New MySqlCommand(query, conn)
                da.DeleteCommand.ExecuteNonQuery()
                MsgBox(Subject_code.Text + " has been deleted!!!", MsgBoxStyle.Information, "Subject")
                Subject_code.Text = ""
                Subject_description.Text = ""
                Subject_units.Text = ""
                Subject_teacher.Text = ""
                Subject_day.Text = ""
                Subject_time.Text = ""

                cmd.Dispose()
                conn.Close()
            End If
        End If
    End Sub

    Private Sub Subject_cancel_Click(sender As Object, e As EventArgs) Handles Subject_cancel.Click
        Response.Redirect("Main-menu.aspx")
    End Sub

    Private Sub Subject_update_Click(sender As Object, e As EventArgs) Handles Subject_update.Click
        If (Subject_code.Text = "" Or Subject_description.Text = "" Or Subject_units.Text = "" Or Subject_teacher.Text = "" Or Subject_day.Text = "" Or Subject_time.Text = "") Then
            MsgBox("Nothing to update, please select a record from subject!", MsgBoxStyle.Information, "Message")
        Else
            Dim ask As MsgBoxResult = MsgBox(Subject_code.Text + "Do you want to update this subject?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
                Dim conn As MySqlConnection = Nothing
                conn = New MySqlConnection(connstring)
                conn.Open()
                Dim cmd As MySqlCommand
                Dim query As String = "Update subject set description ='" + Subject_description.Text + "', Teacher = '" + Subject_teacher.Text + "', Time = '" + Subject_time.Text + "', Day = '" + Subject_day.Text + "', units = '" + Subject_units.Text + "' where subjectcode  = '" + Subject_code.Text + "'"
                Dim da As New MySqlDataAdapter()
                cmd = New MySqlCommand(query, conn)
                da.UpdateCommand = New MySqlCommand(query, conn)
                da.UpdateCommand.ExecuteNonQuery()
                MsgBox(Subject_code.Text + "has been updated!!!", MsgBoxStyle.Information, "Subject")
                Subject_code.Text = ""
                Subject_description.Text = ""
                Subject_units.Text = ""
                Subject_teacher.Text = ""
                Subject_day.Text = ""
                Subject_time.Text = ""
                cmd.Dispose()
                conn.Close()
            End If
        End If
    End Sub
End Class