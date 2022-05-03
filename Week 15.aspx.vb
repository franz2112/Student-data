Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Web.UI
Public Class Week_15
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
        Dim conn As MySqlConnection = Nothing
        conn = New MySqlConnection(connstring)
        conn.Open()
        Dim query As String = "SELECT c.CustomerID, c.CustomerName, o.OrderID, p.ProductID, 
        d.OrderedQuantity as Quantity, p.ProductDescription as Description, p.ProductStandardPrice as UnitPrice,
        (d.OrderedQuantity*p.ProductStandardPrice) as Subtotal
        from solmayor.customer_t c  
        INNER JOIN solmayor.order_t o on c.CustomerID = o.CustomerID 
        INNER JOIN solmayor.orderline_t d on o.OrderID = d.OrderID 
        INNER JOIN solmayor.product_t p on p.ProductID = d.ProductID
        order by c.CustomerName"
        Dim da As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        da.Fill(ds, "customer_t")
        GridView1.DataSource = ds
        GridView1.DataBind()
        conn.Close()
        GridView1.FooterRow.Cells(7).Text = "Overall Total: "
        Dim colsum As Decimal
        For Each R As GridViewRow In GridView1.Rows
            colsum += R.Cells(8).Text
        Next
        GridView1.FooterRow.Cells(8).Text = Format(Val(colsum), "0.00")
    End Sub

    Protected Sub OnSelectedIndexChange(sender As Object, e As EventArgs)
        GetProductsByCustomer(DropDownList1.SelectedItem.Text)
    End Sub


    Private Sub GetProductsByCustomer(CustomerName As String)
        Dim connstring As String = "server=localhost;user id=root;database=Solmayor;allowuservariables=True"
        Dim conn As MySqlConnection = Nothing
        conn = New MySqlConnection(connString)
        conn.Open()
        Dim query As String = "SELECT c.CustomerID, c.CustomerName, o.OrderID, p.ProductID, 
            d.OrderedQuantity as Quantity, p.ProductDescription as Description, p.ProductStandardPrice as UnitPrice,
            (d.OrderedQuantity*p.ProductStandardPrice) as Subtotal
            from solmayor.customer_t c 
            INNER JOIN solmayor.order_t o on c.CustomerID = o.CustomerID 
            inner join solmayor.orderline_t d on o.OrderID = d.OrderID
            inner join solmayor.product_t p on p.ProductID = d.ProductID
            where c.CustomerName = '" + CustomerName + "' order by c. CustomerName;"
        Dim da As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        da.Fill(ds, "customer_t")
        GridView1.DataSource = ds
        GridView1.DataBind()
        conn.Close()
        GridView1.FooterRow.Cells(7).Text = "Overall Total: "
        Dim colsum As Decimal
        For Each R As GridViewRow In GridView1.Rows
            colsum += R.Cells(8).Text
        Next
        GridView1.FooterRow.Cells(8).Text = Format(Val(colsum), "0.00")
    End Sub

End Class