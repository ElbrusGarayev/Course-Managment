Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class PaySlipNew
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True")
    Dim com As SqlCommand
    Dim qry As String
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer

    Protected Sub Bclear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bclear.Click
        txtdate.Text = Date.Today
        'ddlsid.Text = ""
        txtsname.Text = ""
        txtbpay.Text = ""
        txtda.Text = ""

        txtpf.Text = ""
        txtlic.Text = ""
        txttrans.Text = ""

        txttotal.Text = ""
        txttotearn.Text = ""
        txtnet.Text = ""
    End Sub

    Protected Sub Bsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bsave.Click
        If txtdate.Text = "" Or ddlsid.Text = "" Or txtsname.Text = "" Or txtbpay.Text = "" Or txtda.Text = "" Or txtpf.Text = "" Or txtlic.Text = "" Or txttrans.Text = "" Or txtnet.Text = "" Then
            MsgBox("Please Enter All Values Then Save", MsgBoxStyle.Information)
        Else
            qry = "insert into payslip values('" + txtdate.Text + "','" + ddlsid.Text + "','" + txtsname.Text + "','" + txtbpay.Text + "','" + txtda.Text + "','" + "','" + txtpf.Text + "','" + txtlic.Text + "','" + txttrans.Text + "','" + "','" + txtnet.Text + "')"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Saved")

            txtdate.Text = Date.Today
            'ddlsid.Text = ""
            txtsname.Text = ""
            txtbpay.Text = ""
            txtda.Text = ""

            txtpf.Text = ""
            txtlic.Text = ""
            txttrans.Text = ""

            txttotal.Text = ""
            txttotearn.Text = ""
            txtnet.Text = ""

        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtdate.Text = Date.Today
            'ddlsid.Text = ""
            txtsname.Text = ""
            txtbpay.Text = ""
            txtda.Text = ""

            txtpf.Text = ""
            txtlic.Text = ""
            txttrans.Text = ""

            txttotal.Text = ""
            txttotearn.Text = ""
            txtnet.Text = ""

            ddlsid.Items.Clear()
            qry = "select eid from staff"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "staff")
            i = ds.Tables("staff").Rows.Count
            Dim j As Integer
            For j = 0 To i - 1
                ddlsid.Items.Add(ds.Tables("staff").Rows(j)(0))
            Next
        End If
    End Sub

    Protected Sub ddlsid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlsid.SelectedIndexChanged
        qry = "select ename from staff where eid='" + ddlsid.SelectedItem.Text + "'"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "staff")
        txtsname.Text = ds.Tables("staff").Rows(0)(0)
    End Sub

    Protected Sub Btotearn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btotearn.Click
        txttotearn.Text = Val(txtbpay.Text) + Val(txtda.Text)
    End Sub

    Protected Sub Btotal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btotal.Click
        txttotal.Text = Val(txtpf.Text) + Val(txtlic.Text) + Val(txttrans.Text)
    End Sub

    Protected Sub Bnet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bnet.Click
        txtnet.Text = Val(txttotearn.Text) - Val(txttotal.Text)
    End Sub

    Protected Sub Bexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Response.Redirect("Main.aspx")
    End Sub
End Class
