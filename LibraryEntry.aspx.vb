Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class LibraryEntry
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True")
    Dim com As SqlCommand
    Dim qry As String
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Protected Sub Bclear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bclear.Click
        txtdate.Text = Date.Today
        'ddlregno.Text = ""
        ddlsname.Text = ""
        'ddlbname.Text = ""
        txtaname.Text = ""
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtdate.Text = Date.Today
            'ddlregno.Text = ""
            ddlsname.Text = ""
            'ddlbname.Text = ""
            txtaname.Text = ""

            ddlregno.Items.Clear()
            qry = "select sregno from stureg"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "stureg")
            i = ds.Tables("stureg").Rows.Count
            Dim j As Integer
            ddlregno.Items.Add(" ")
            For j = 0 To i - 1
                ddlregno.Items.Add(ds.Tables("stureg").Rows(j)(0))
            Next

            ddlbname.Items.Clear()
            qry = "select bname from library"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "library")
            i = ds.Tables("library").Rows.Count
            For j = 0 To i - 1
                ddlbname.Items.Add(ds.Tables("library").Rows(j)(0))
            Next
        End If
    End Sub

    Protected Sub ddlregno_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlregno.SelectedIndexChanged
        qry = "select sname from stureg where sregno='" + ddlregno.SelectedItem.Text + "'"
        con.Open()
        com = New SqlCommand(qry, con)
        ddlsname.Text = com.ExecuteScalar().ToString()
        con.Close()
    End Sub

    Protected Sub ddlbname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlbname.SelectedIndexChanged
        qry = "select aname from library where bname='" + ddlbname.SelectedItem.Text + "'"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "library")
        txtaname.Text = ds.Tables("library").Rows(0)(0)
    End Sub

    Protected Sub Bsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bsave.Click
        If txtdate.Text = "" Or ddlregno.Text = "" Or ddlsname.Text = "" Or ddlbname.Text = "" Or txtaname.Text = "" Then
            MsgBox("Please Enter All Values Then Save", MsgBoxStyle.Information)
        Else
            qry = "insert into libentry values('" + txtdate.Text + "','" + ddlregno.SelectedItem.Text + "','" + ddlsname.Text + "','" + ddlbname.SelectedItem.Text + "','" + txtaname.Text + "')"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Added")
            txtdate.Text = Date.Today
            'ddlregno.Text = ""
            ddlsname.Text = ""
            'ddlbname.Text = ""
            txtaname.Text = ""
        End If
    End Sub

    Protected Sub Bexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Response.Redirect("Main.aspx")
    End Sub
End Class
