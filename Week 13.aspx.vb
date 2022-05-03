Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Web.UI
Public Class Week_13
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
        Dim conn As MySqlConnection = Nothing
        conn = New MySqlConnection(connstring)
        conn.Open()
        Dim query As String = "Select * from items"
        Dim da As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        da.Fill(ds, "items")
        GridView1.DataSource = ds
        GridView1.DataBind()
        conn.close()
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Item_text.Text = GridView1.SelectedRow.Cells(1).Text
        Desc_text.Text = GridView1.SelectedRow.Cells(2).Text
        Unit_text.Text = GridView1.SelectedRow.Cells(3).Text
        Quan_text.Text = GridView1.SelectedRow.Cells(4).Text
        Button3Update.Enabled = True
        Button2Delete.Enabled = True
        Button1Add.Text = "Add"
        Item_text.Enabled = False
    End Sub

    Protected Sub Button1Add_Click(sender As Object, e As EventArgs) Handles Button1Add.Click
        If (Button1Add.Text = "Add") Then
            Button1Add.Text = "Save"
            Button2Delete.Enabled = False
            Button3Update.Enabled = False
            Item_text.Enabled = True
            clearFields()
        Else
            If (Item_text.Text = "" Or Desc_text.Text = "" Or Unit_text.Text = "" Or Quan_text.Text = "") Then
                MsgBox("Nothing to add, please fill up all fields!", MsgBoxStyle.Information, "Message")
            Else
                Dim ask As MsgBoxResult = MsgBox(Item_text.Text + " Do you want to add this items?", MsgBoxStyle.YesNo)
                If ask = MsgBoxResult.Yes Then
                    Button1Add.Text = "Add"
                    Button2Delete.Enabled = True
                    Button3Update.Enabled = True
                    Item_text.Enabled = False

                    Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
                    Dim con As MySqlConnection = Nothing
                    con = New MySqlConnection(connstring)
                    Dim cmd As New MySqlCommand
                    con.Open()
                    cmd = New MySqlCommand("INSERT INTO items values ('" & Item_text.Text & "' , '" & Desc_text.Text & "','" & Unit_text.Text & "','" & Quan_text.Text & "')", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Data stored Successully", MsgBoxStyle.Information, "Success")
                    clearFields()
                End If
            End If
        End If
    End Sub

    Protected Sub Button3Update_Click(sender As Object, e As EventArgs) Handles Button3Update.Click
        If (Item_text.Text = "" Or Desc_text.Text = "" Or Unit_text.Text = "" Or Quan_text.Text = "") Then
            MsgBox("Nothing to update, please select a record from items!", MsgBoxStyle.Information, "Message")
        Else
            Dim ask As MsgBoxResult = MsgBox(Item_text.Text + " Do you want to update this items?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
                Dim conn As MySqlConnection = Nothing
                conn = New MySqlConnection(connstring)
                conn.Open()
                Dim cmd As MySqlCommand
                Dim query As String = "Update items set Description ='" + Desc_text.Text + "', UnitPrice = '" + Unit_text.Text + "', Quantity = '" + Quan_text.Text + "' where ItemNumber  = '" + Item_text.Text + "'"
                Dim da As New MySqlDataAdapter()
                cmd = New MySqlCommand(query, conn)
                da.UpdateCommand = New MySqlCommand(query, conn)
                da.UpdateCommand.ExecuteNonQuery()
                MsgBox(Item_text.Text + "has been updated!!!", MsgBoxStyle.Information, "items")
                Item_text.Text = ""
                Desc_text.Text = ""
                Unit_text.Text = ""
                Quan_text.Text = ""
                cmd.Dispose()
                conn.Close()
                clearFields()
            End If
        End If
    End Sub

    Protected Sub Button2Delete_Click(sender As Object, e As EventArgs) Handles Button2Delete.Click
        If (Item_text.Text = "" Or Desc_text.Text = "" Or Unit_text.Text = "" Or Quan_text.Text = "") Then
            MsgBox("Nothing to delete, please select a record from items!", MsgBoxStyle.Information, "Message")
        Else
            Dim ask As MsgBoxResult = MsgBox(Item_text.Text + " Do you want to delete this Item?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
                Dim conn As MySqlConnection = Nothing
                conn = New MySqlConnection(connstring)
                conn.Open()
                Dim cmd As MySqlCommand
                Dim query As String = "Delete from items where ItemNumber = '" + Item_text.Text + "'"
                MsgBox("Delete from items where ItemNumber = " + Item_text.Text)
                Dim da As New MySqlDataAdapter()
                cmd = New MySqlCommand(query, conn)
                da.DeleteCommand = New MySqlCommand(query, conn)
                da.DeleteCommand.ExecuteNonQuery()
                MsgBox(Item_text.Text + " has been deleted!!!")
                Item_text.Text = ""
                Desc_text.Text = ""
                Unit_text.Text = ""
                Quan_text.Text = ""

                cmd.Dispose()
                conn.Close()
                clearFields()
            End If
        End If
    End Sub

    Protected Sub Button4clear_Click(sender As Object, e As EventArgs) Handles Button4clear.Click
        Response.Redirect("Week 13.aspx")
    End Sub

    Sub clearFields()
        Item_text.Text = ""
        Desc_text.Text = ""
        Unit_text.Text = ""
        Quan_text.Text = ""
    End Sub

End Class