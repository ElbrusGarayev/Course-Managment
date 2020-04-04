Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class Exam
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True")
    Dim com As SqlCommand
    Dim qry As String
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer

    Protected Sub Bclear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bclear.Click
        txtdate.Text = Date.Today
        'ddlfromreg.Text = ""
        'ddltoreg.Text = ""
        ddlhallno.Text = ""
        rfore.Checked = True
        rafter.Checked = False
        txttimings.Text = ""
        txtsheets.Text = ""

        ddlfromreg.Items.Clear()
        qry = "select sregno from stureg"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "stureg")
        i = ds.Tables("stureg").Rows.Count
        Dim j As Integer
        For j = 0 To i - 1
            ddlfromreg.Items.Add(ds.Tables("stureg").Rows(j)(0))
        Next

        ddltoreg.Items.Clear()
        qry = "select sregno from stureg"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "stureg")
        i = ds.Tables("stureg").Rows.Count

        For j = 0 To i - 1
            ddltoreg.Items.Add(ds.Tables("stureg").Rows(j)(0))
        Next
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtdate.Text = Date.Today
            'ddlfromreg.Text = ""
            'ddltoreg.Text = ""

            rfore.Checked = True
            rafter.Checked = False
            txttimings.Text = ""
            txtsheets.Text = ""

            ddlhallno.Items.Clear()
            qry = "select hallno from hall"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "hall")
            i = ds.Tables("hall").Rows.Count
            Dim k As Integer
            For k = 0 To i - 1
                ddlhallno.Items.Add(ds.Tables("hall").Rows(k)(0))
            Next

            ddlfromreg.Items.Clear()
            qry = "select sregno from stureg"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "stureg")
            i = ds.Tables("stureg").Rows.Count
            Dim j As Integer
            For j = 0 To i - 1
                ddlfromreg.Items.Add(ds.Tables("stureg").Rows(j)(0))
            Next

            ddltoreg.Items.Clear()
            qry = "select sregno from stureg"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "stureg")
            i = ds.Tables("stureg").Rows.Count

            For j = 0 To i - 1
                ddltoreg.Items.Add(ds.Tables("stureg").Rows(j)(0))
            Next
        End If
    End Sub

    Protected Sub Bsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bsave.Click
        If ddlfromreg.Text = "" Or ddltoreg.Text = "" Or ddlhallno.Text = "" Or txttimings.Text = "" Or txtsheets.Text = "" Then
            MsgBox("Please Enter All Values Then Save")
        ElseIf rfore.Checked = False And rafter.Checked = False Then
            MsgBox("Please Select Any One Option either Forenoon or Afternoon")
        ElseIf rfore.Checked = True Then
            rafter.Enabled = False
            qry = "insert into exam values('" + txtdate.Text + "','" + ddlfromreg.Text + "','" + ddltoreg.Text + "','" + ddlhallno.Text + "','" + rfore.Text + "','" + txttimings.Text + "','" + txtsheets.Text + "')"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Saved")
            txtdate.Text = Date.Today
            'ddlfromreg.Text = ""
            'ddltoreg.Text = ""
            'ddlhallno.Text = ""
            rfore.Checked = True
            rafter.Checked = False
            txttimings.Text = ""
            txtsheets.Text = ""
        ElseIf rafter.Checked = True Then
            rfore.Enabled = False
            qry = "insert into exam values('" + txtdate.Text + "','" + ddlfromreg.Text + "','" + ddltoreg.Text + "','" + ddlfromreg.Text + "','" + rafter.Text + "','" + txttimings.Text + "','" + txtsheets.Text + "')"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Saved")
            txtdate.Text = Date.Today
            'ddlfromreg.Text = ""
            'ddltoreg.Text = ""
            'ddlhallno.Text = ""
            rfore.Checked = True
            rafter.Checked = False
            txttimings.Text = ""
            txtsheets.Text = ""

        End If
    End Sub

    Protected Sub Bexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Response.Redirect("Main.aspx")
    End Sub

    Protected Sub Btime_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btime.Click
        If rfore.Checked = True Then
            txttimings.Text = "9:30 A.M - 12:30 P.M"
        ElseIf rafter.Checked = True Then
            txttimings.Text = "1:00 P.M - 3:00 P.M"
        End If
    End Sub

    Protected Sub Bsheets_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bsheets.Click
        Dim s, s1, sheets As String
        s = Mid(ddlfromreg.Text, 2)
        s1 = Mid(ddltoreg.Text, 2)
        sheets = (Val(s1) - Val(s)) + 1
        txtsheets.Text = Val(sheets) * 15
    End Sub
End Class
