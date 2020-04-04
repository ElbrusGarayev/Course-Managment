Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class StudentFees
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True")
    Dim com As SqlCommand
    Dim qry As String
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Dim p As String
    Protected Sub Bclear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bclear.Click
        txtdate.Text = Date.Today
        'ddlregno.Text = ""
        txtsname.Text = ""
        'ddlsem.Text = ""
        txtfees.Text = ""
    End Sub

    Protected Sub Bexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Response.Redirect("Main.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtdate.Text = Date.Today
            'ddlregno.Text = ""
            txtsname.Text = ""
            'ddlsem.Text = ""
            txtfees.Text = ""
            ddlsem.Items.Add("Sem I")
            ddlsem.Items.Add("Sem II")
            ddlsem.Items.Add("Sem III")
            ddlsem.Items.Add("Sem IV")
            ddlsem.Items.Add("Sem V")
            ddlsem.Items.Add("Sem VI")

            ddlregno.Items.Clear()
            qry = "select sregno from stureg"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "stureg")
            i = ds.Tables("stureg").Rows.Count
            Dim j As Integer
            For j = 0 To i - 1
                ddlregno.Items.Add(ds.Tables("stureg").Rows(j)(0))
            Next
        End If
    End Sub

    Protected Sub Bsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bsave.Click
        If txtdate.Text = "" Or ddlregno.Text = "" Or txtsname.Text = "" Or ddlsem.Text = "" Or txtfees.Text = "" Then
            MsgBox("Please Enter All Values Then Save", MsgBoxStyle.Information)
        Else
            qry = "insert into fees values('" + txtdate.Text + "','" + ddlregno.Text + "','" + txtsname.Text + "','" + ddlsem.Text + "','" + txtfees.Text + "')"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Added")
            txtdate.Text = Date.Today
            'ddlregno.Text = ""
            txtsname.Text = ""
            'ddlsem.Text = ""
            txtfees.Text = ""
        End If
    End Sub

    Protected Sub ddlregno_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlregno.SelectedIndexChanged
        qry = "select sname from stureg where sregno='" + ddlregno.SelectedItem.Text + "'"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "stureg")
        txtsname.Text = ds.Tables("stureg").Rows(0)(0)
    End Sub

    Protected Sub ddlsem_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlsem.SelectedIndexChanged

    End Sub
End Class
