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

    Protected Sub Bsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bsave.Click
        If ddlcname.Text = " " Or TextBox1.Text = " " Or TextBox2.Text = " " Or TextBox3.Text = " " Then
            MsgBox("Please Enter All Values Then Save", MsgBoxStyle.Information)
        Else
            qry = "insert into library values('" + ddlcname.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')"

            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Successfully Added")

            ListBox1.Items.Clear()
            qry = "select bname from library"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "library")
            i = ds.Tables("library").Rows.Count
            Dim j As Integer
            For j = 0 To i - 1
                ListBox1.Items.Add(ds.Tables("library").Rows(j)(0))
            Next

            'DropDownList1.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""

        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
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

            'ListBox1.Items.Clear()
            qry = "select bname from library"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "library")
            i = ds.Tables("library").Rows.Count

            For j = 0 To i - 1
                ListBox1.Items.Add(ds.Tables("library").Rows(j)(0))
            Next
        End If
    End Sub

    Protected Sub Bclear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bclear.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        ListBox1.Items.Clear()
        qry = "select bname from library"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "library")
        i = ds.Tables("library").Rows.Count
        Dim j As Integer
        For j = 0 To i - 1
            ListBox1.Items.Add(ds.Tables("library").Rows(j)(0))
        Next
    End Sub

    Protected Sub Bdelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bdelete.Click
        If ddlcname.Text = " " Or TextBox1.Text = " " Or TextBox2.Text = " " Or TextBox3.Text = " " Then
            MsgBox("Please Select Any One Book name from the List then Edit", MsgBoxStyle.Information)
        Else
            qry = "delete from library where bname='" + ListBox1.Text + "'"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Deleted")

            ListBox1.Items.Clear()
            qry = "select bname from library"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "library")
            i = ds.Tables("library").Rows.Count
            Dim j As Integer
            For j = 0 To i - 1
                ListBox1.Items.Add(ds.Tables("library").Rows(j)(0))
            Next

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""

        End If
    End Sub

    Protected Sub Bedit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bedit.Click
        If ddlcname.Text = " " Or TextBox1.Text = " " Or TextBox2.Text = " " Or TextBox3.Text = " " Then
            MsgBox("Please Select Any One Book name from the List then Edit", MsgBoxStyle.Information)
        Else
            qry = "update library set cname='" + ddlcname.Text + "',aname='" + TextBox2.Text + "',bno='" + TextBox3.Text + "' where bname='" + ListBox1.Text + "'"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Updated")

            ListBox1.Items.Clear()
            qry = "select bname from library"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "library")
            i = ds.Tables("library").Rows.Count
            Dim j As Integer
            For j = 0 To i - 1
                ListBox1.Items.Add(ds.Tables("library").Rows(j)(0))
            Next

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""

        End If
    End Sub

    Protected Sub Bexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Response.Redirect("Main.aspx")
    End Sub

    Protected Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        qry = "select cname,bname,aname,bno from library where bname='" + ListBox1.SelectedItem.Text + "'"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "library")
        ddlcname.Text = ds.Tables("library").Rows(0)(0)
        TextBox1.Text = ds.Tables("library").Rows(0)(1)
        TextBox2.Text = ds.Tables("library").Rows(0)(2)
        TextBox3.Text = ds.Tables("library").Rows(0)(3)
    End Sub
End Class
