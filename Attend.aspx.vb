Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class Attend
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True")
    Dim com As SqlCommand
    Dim qry As String
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Dim p As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.Text = Date.Today
        If Page.IsPostBack = False Then
            Regddl.Items.Clear()
            qry = "select sregno from stureg"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "stureg")
            i = ds.Tables("stureg").Rows.Count
            Dim j As Integer
            For j = 0 To i - 1
                Regddl.Items.Add(ds.Tables("stureg").Rows(j)(0))
            Next

            attendddl.Items.Add("Present")
            attendddl.Items.Add("Absent")


            'Regddl.Text = ""

            TextBox2.Text = ""
            'attendddl.Text = ""
        End If

    End Sub

    Protected Sub clear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bclear.Click
        TextBox1.Text = Date.Today
        'Regddl.Text = ""

        TextBox2.Text = ""
        'attendddl.Text = ""
    End Sub

    Protected Sub Bexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Response.Redirect("Main.aspx")
    End Sub

    Protected Sub Bsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bsave.Click
        If TextBox1.Text = " " Or Regddl.Text = " " Or TextBox2.Text = " " Or attendddl.Text = " " Then
            MsgBox("Please Enter All Values Then Save", MsgBoxStyle.Information)
        Else
            qry = "insert into attend values('" + TextBox1.Text + "','" + Regddl.Text + "','" + TextBox2.Text + "','" + attendddl.Text + "')"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()


            TextBox1.Text = Date.Today
            'Regddl.Text = ""


            TextBox2.Text = ""
            'attendddl.Text = ""
        End If
    End Sub

    Protected Sub Regddl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Regddl.SelectedIndexChanged
        qry = "select sname from stureg where sregno='" + Regddl.SelectedItem.Text + "'"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "stureg")
        TextBox2.Text = ds.Tables("stureg").Rows(0)(0)
    End Sub
End Class
