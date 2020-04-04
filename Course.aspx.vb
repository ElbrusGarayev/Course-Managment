Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class Course
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True")
    Dim com As SqlCommand
    Dim qry As String
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Dim p As String
    Protected Sub Bclear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bclear.Click
        txtcid.Text = ""
        'ddlcname.Text = ""
        'ddldur.Text = ""
        'txtdeptname.Text = ""
        'ddlcat.Text = ""
    End Sub

    Protected Sub BSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BSave.Click
        If txtcid.Text = "" Or ddlcname.Text = "" Or ddldur.Text = "" Or ddldept.Text = "" Or ddlcat.Text = "" Then
            MsgBox("Please Enter All Values Then Save", MsgBoxStyle.Information)
        Else
            qry = "insert into course values('" + txtcid.Text + "','" + ddlcname.SelectedItem.Text + "','" + ddldur.SelectedItem.Text + "','" + ddldept.Text + "','" + ddlcat.SelectedItem.Text + "')"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Added")
            txtcid.Text = ""
            'ddlcname.Text = ""
            'ddldur.Text = ""
            'txtdeptname.Text = ""
            'ddlcat.Text = ""

            lbval.Items.Clear()
            qry = "select cid from course"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "course")
            i = ds.Tables("course").Rows.Count
            Dim j As Integer
            For j = 0 To i - 1
                lbval.Items.Add(ds.Tables("course").Rows(j)(0))
            Next

        End If
    End Sub

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
            ddlcat.Items.Add("Bachelor")
            ddlcat.Items.Add("Master")
            txtcid.Text = ""
            'ddlcname.Text = ""
            'ddldur.Text = ""
            ddldept.Items.Clear()
            qry = "select dname from depts"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "depts")
            i = ds.Tables("depts").Rows.Count
            For j = 0 To i - 1
                ddldept.Items.Add(ds.Tables("depts").Rows(j)(0))
            Next
            'ddlcat.Text = ""

            ddldur.Items.Add("1 Year")
            ddldur.Items.Add("2 Years")
            ddldur.Items.Add("3 Years")
            ddldur.Items.Add("4 Years")
            ddldur.Items.Add("5 Years")

            lbval.Items.Clear()
            qry = "select cid from course"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "course")
            i = ds.Tables("course").Rows.Count

            For j = 0 To i - 1
                lbval.Items.Add(ds.Tables("course").Rows(j)(0))
            Next

        End If
        
    End Sub

    Protected Sub Bedit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bedit.Click
        If txtcid.Text = "" Or ddlcname.Text = "" Or ddldur.Text = "" Or ddldept.Text = "" Or ddlcat.Text = "" Then
            MsgBox("Please Select Any One Course ID Then Edit", MsgBoxStyle.Information)
        Else
            qry = "update course set cid='" + txtcid.Text + "',cname='" + ddlcname.SelectedItem.Text + "',cdur='" + ddldur.SelectedItem.Text + "',cdept='" + ddldept.Text + "',ccat='" + ddlcat.SelectedItem.Text + "' where cid='" + lbval.SelectedItem.Text + "'"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Updated")
            txtcid.Text = ""
            'ddlcname.Text = ""
            'ddldur.Text = ""
            'ddldept.Text = ""
            'ddlcat.Text = ""


            lbval.Items.Clear()
            qry = "select cid from course"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "course")
            i = ds.Tables("course").Rows.Count
            Dim j As Integer
            For j = 0 To i - 1
                lbval.Items.Add(ds.Tables("course").Rows(j)(0))
            Next

        End If
    End Sub

    Protected Sub Bdelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bdelete.Click
        If txtcid.Text = "" Or ddlcname.Text = "" Or ddldur.Text = "" Or ddldept.Text = "" Or ddlcat.Text = "" Then
            MsgBox("Please Select Any One Course ID Then Edit", MsgBoxStyle.Information)
        Else
            qry = "delete from course where cid='" + lbval.SelectedItem.Text + "'"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Deleted")
            txtcid.Text = ""
            'ddlcname.Text = ""
            'ddldur.Text = ""
            'txtdeptname.Text = ""
            'ddlcat.Text = ""


            lbval.Items.Clear()
            qry = "select cid from course"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "course")
            i = ds.Tables("course").Rows.Count
            Dim j As Integer
            For j = 0 To i - 1
                lbval.Items.Add(ds.Tables("course").Rows(j)(0))
            Next

        End If
    End Sub

    Protected Sub Bexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Response.Redirect("Main.aspx")
    End Sub

    Protected Sub lbval_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbval.SelectedIndexChanged
        qry = "select cid,cname,cdur,cdept,ccat from course where cid='" + lbval.SelectedItem.Text + "'"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "course")
        txtcid.Text = ds.Tables("course").Rows(0)(0)
        ddlcname.SelectedItem.Text = ds.Tables("course").Rows(0)(1)
        ddldur.SelectedItem.Text = ds.Tables("course").Rows(0)(2)
        ddldept.Text = ds.Tables("course").Rows(0)(3)
        ddlcat.SelectedItem.Text = ds.Tables("course").Rows(0)(4)
    End Sub
End Class
