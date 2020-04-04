Imports System
Imports System.Data
Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True")
    Dim com As SqlCommand
    Dim qry As String
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Private Sub LabEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Page.IsPostBack = False Then
            txtdate.Text = Date.Today
            'ddlcrslist.Text = ""
            txtcname.Text = ""
            txtdeptname.Text = ""
            txtintime.Text = ""
            txtouttime.Text = ""

            ddlcrslist.Items.Clear()
            qry = "select cid from course"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "course")
            i = ds.Tables("course").Rows.Count
            Dim j As Integer
            For j = 0 To i - 1
                ddlcrslist.Items.Add(ds.Tables("course").Rows(j)(0))
            Next
        End If
        
    End Sub
    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Response.Redirect("Main.aspx")
    End Sub

    
    Protected Sub Bsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bsave.Click
        If txtdate.Text = "" Or ddlcrslist.Text = "" Or txtcname.Text = "" Or txtdeptname.Text = "" Or txtintime.Text = "" Or txtouttime.Text = "" Then
            MsgBox("Please Enter All Values Then Save", MsgBoxStyle.Information)
        Else
            qry = "insert into lab values('" + txtdate.Text + "','" + ddlcrslist.Text + "','" + txtcname.Text + "','" + txtdeptname.Text + "','" + txtintime.Text + "','" + txtouttime.Text + "')"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Added")

            txtdate.Text = Date.Today
            'ddlcrslist.Text = ""
            txtcname.Text = ""
            txtdeptname.Text = ""
            txtintime.Text = ""
            txtouttime.Text = ""
        End If
    End Sub

    Private Sub ddlcrslist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlcrslist.SelectedIndexChanged
        qry = "select cname,cdept from course where cid='" & ddlcrslist.SelectedItem.Text & "'"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "course")
        txtcname.Text = ds.Tables("course").Rows(0)(0)
        txtdeptname.Text = ds.Tables("course").Rows(0)(1)

    End Sub

    Protected Sub Bclear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bclear.Click
        'If txtdate.Text = "" Or ddlcrslist.Text = "" Or txtcname.Text = "" Or txtdeptname.Text = "" Or txtintime.Text = "" Or txtouttime.Text = "" Then
        '    MsgBox("Please Enter All Values Then Save", MsgBoxStyle.Information)
        'Else
        '    qry = "insert into lab values('" + txtdate.Text + "','" + ddlcrslist.Text + "','" + txtcname.Text + "','" + txtdeptname.Text + "','" + txtintime.Text + "','" + txtouttime.Text + "')"
        '    com = New SqlCommand(qry, con)
        '    con.Open()
        '    com.ExecuteScalar()
        '    con.Close()
        '    MsgBox("Successfully Cleared")

        txtdate.Text = Date.Today
        'ddlcrslist.Text = ""
        txtcname.Text = ""
        txtdeptname.Text = ""
        txtintime.Text = ""
        txtouttime.Text = ""
        'End If
    End Sub
End Class
