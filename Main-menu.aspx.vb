Public Class Main_menu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub DisBtnSt_Click(sender As Object, e As EventArgs) Handles DisBtnSt.Click
        Response.Redirect("Student-display.aspx")
    End Sub

    Protected Sub DisBtnSu_Click(sender As Object, e As EventArgs) Handles DisBtnSu.Click
        Response.Redirect("Subject-display.aspx")
    End Sub

    Protected Sub DisBtnTe_Click(sender As Object, e As EventArgs) Handles DisBtnTe.Click
        Response.Redirect("Teacher-display.aspx")
    End Sub

    Protected Sub AddBtnSt_Click(sender As Object, e As EventArgs) Handles AddBtnSt.Click
        Response.Redirect("Student-add.aspx")
    End Sub

    Protected Sub AddBtnSu_Click(sender As Object, e As EventArgs) Handles AddBtnSu.Click
        Response.Redirect("Subject-add.aspx")
    End Sub

    Protected Sub AddBtnTe_Click(sender As Object, e As EventArgs) Handles AddBtnTe.Click
        Response.Redirect("Teacher-add.aspx")
    End Sub
End Class