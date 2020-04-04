Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class StudentDetails
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True")
    Dim com As SqlCommand
    Dim qry As String
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ddlcname.Items.Clear()
            qry = "select cname from course"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "course")
            i = ds.Tables("course").Rows.Count
            Dim j As Integer
            For j = 0 To i - 1
                ddlcname.Items.Add(ds.Tables("course").Rows(j)(0))
            Next

            dname.Items.Clear()
            qry = "select cdept from course"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "course")
            i = ds.Tables("course").Rows.Count

            For j = 0 To i - 1
                dname.Items.Add(ds.Tables("course").Rows(j)(0))
            Next

        End If
    End Sub

    Protected Sub Bview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bview.Click
        Try
            qry = "select sregno, sname, sgender, sdob, fname, foccup, speraddr, sphno from stureg where cname='" + ddlcname.Text + "' and cdept='" + dname.Text + "'"
            com = New SqlCommand(qry, con)
            Dim SqlDataAdapter1 As New SqlDataAdapter(com)
            Dim Dataset11 As New DataSet
            Dataset11.Clear()
            SqlDataAdapter1.Fill(Dataset11, "stureg")
            dg.DataSource = Dataset11
            dg.DataBind()
        Catch ex As Exception
            MsgBox("Please check course & dept", MsgBoxStyle.Information)
        End Try
    End Sub
    Protected Sub Bexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Response.Redirect("Main.aspx")
    End Sub
End Class
