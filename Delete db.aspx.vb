Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlException
Imports System.Data
Public Class Delete_db
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
        Dim conn As MySqlConnection = Nothing
        conn = New MySqlConnection(connstring)
        Dim cmd As New MySqlCommand
        conn.Open()
        Dim query As String = "Select * from subject"
        Dim da As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        da.Fill(ds, "subject")
        GridView1.DataSource = ds
        GridView1.DataBind()
        conn.Close()

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        subjcode.Text = GridView1.SelectedRow.Cells(1).Text
        Desc.Text = GridView1.SelectedRow.Cells(2).Text
        un.Text = GridView1.SelectedRow.Cells(3).Text
        teach.Text = GridView1.SelectedRow.Cells(4).Text
        dayy.Text = GridView1.SelectedRow.Cells(5).Text
        tim.Text = GridView1.SelectedRow.Cells(6).Text

    End Sub

    Protected Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If (subjcode.Text = "" Or Desc.Text = "" Or un.Text = "" Or teach.Text = "" Or dayy.Text = "" Or tim.Text = "") Then
            MsgBox("nothing to delete, please select a record from subject!", MsgBoxStyle.Information, "Message")
        Else
            Dim ask As MsgBoxResult = MsgBox(subjcode.Text + "Do you want to delete this subject?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
                Dim conn As MySqlConnection = Nothing
                conn = New MySqlConnection(connstring)
                conn.Open()
                Dim cmd As MySqlCommand
                Dim query As String = "Delete from subject where Subjectcode = '" + subjcode.Text + "'"
                Dim da As New MySqlDataAdapter()
                cmd = New MySqlCommand(query, conn)
                da.DeleteCommand = New MySqlCommand(query, conn)
                da.DeleteCommand.ExecuteNonQuery()
                MsgBox(subjcode.Text + " has been deleted!!!", MsgBoxStyle.Information, "Subject")
                subjcode.Text = ""
                Desc.Text = ""
                un.Text = ""
                teach.Text = ""
                dayy.Text = ""
                tim.Text = ""

                cmd.Dispose()
                conn.Close()
            End If
        End If
    End Sub

    Protected Sub subjcode_TextChanged(sender As Object, e As EventArgs) Handles subjcode.TextChanged

    End Sub

    Protected Sub updatebutton_Click(sender As Object, e As EventArgs) Handles updatebutton.Click
        If (subjcode.Text = "" Or Desc.Text = "" Or un.Text = "" Or teach.Text = "" Or dayy.Text = "" Or tim.Text = "") Then
            MsgBox("Nothing to update, please select a record from subject!", MsgBoxStyle.Information, "Message")
        Else
            Dim ask As MsgBoxResult = MsgBox(subjcode.Text + "Do you want to update this subject?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
                Dim conn As MySqlConnection = Nothing
                conn = New MySqlConnection(connstring)
                conn.Open()
                Dim cmd As MySqlCommand
                Dim query As String = "Update subject set description ='" + Desc.Text + "', Teacher = '" + teach.Text + "', Time = '" + tim.Text + "', Day = '" + dayy.Text + "', units = '" + un.Text + "' where subjectcode  = '" + subjcode.Text + "'"
                Dim da As New MySqlDataAdapter()
                cmd = New MySqlCommand(query, conn)
                da.UpdateCommand = New MySqlCommand(query, conn)
                da.UpdateCommand.ExecuteNonQuery()
                MsgBox(subjcode.Text + "has been updated!!!", MsgBoxStyle.Information, "Subject")
                subjcode.Text = ""
                Desc.Text = ""
                un.Text = ""
                teach.Text = ""
                dayy.Text = ""
                tim.Text = ""
                cmd.Dispose()
                conn.Close()
            End If
        End If
    End Sub
End Class