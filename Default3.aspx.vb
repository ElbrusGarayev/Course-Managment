Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class Default3
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True")
    Dim com As SqlCommand
    Dim qry As String
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer

    Protected Sub Bexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Response.Redirect("Main.aspx")
    End Sub

    Protected Sub Bdelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bdelete.Click
        If txtsid.Text = "" Or txtname.Text = "" Or txtdob.Text = "" Or txtpresent.Text = "" Or txtpermanent.Text = "" Or txtcno.Text = "" Or txtqual.Text = "" Or ddldept.Text = "" Or ddlcat.Text = "" Then
            MsgBox("Please Select Any One Staff ID from the List then Edit", MsgBoxStyle.Information)
        ElseIf rmale.Checked = False And rfemale.Checked = False Then
            MsgBox("Please Select Any One Staff ID from the List then Edit", MsgBoxStyle.Information)
        Else
            qry = "delete from staff where eid='" + txtsid.Text + "'"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Deleted")
        End If

        Dim p As String
        qry = "select eid from staff"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "staff")
        i = ds.Tables("staff").Rows.Count
        ' p = ds.Tables("staff").Rows(i - 1)(0)
        p = i - 0
        p = Mid(p, 2)
        p = Val(p) + 1
        If Len(p) = 1 Then
            p = "000" + p
        ElseIf Len(p) = 2 Then
            p = "00" + p
        ElseIf Len(p) = 3 Then
            p = "0" + p
        End If
        txtsid.Text = "S" + p

        txtname.Text = ""
        rfemale.Checked = True
        rmale.Checked = False
        txtdob.Text = ""
        txtpresent.Text = ""
        txtpermanent.Text = ""
        txtcno.Text = ""
        txtqual.Text = ""
        'ddldept.Text = ""
        'ddlcat.Text = ""

        lbval.Items.Clear()
        qry = "select eid from staff"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "staff")
        i = ds.Tables("staff").Rows.Count
        Dim j As Integer
        For j = 0 To i - 1
            lbval.Items.Add(ds.Tables("staff").Rows(j)(0))
        Next
    End Sub

    Protected Sub Bclear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bclear.Click
        Dim p As String
        qry = "select eid from staff"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "staff")
        i = ds.Tables("staff").Rows.Count
        'p = ds.Tables("staff").Rows(i - 1)(0)
        p = i - 0
        p = Mid(p, 2)
        p = Val(p) + 1
        If Len(p) = 1 Then
            p = "000" + p
        ElseIf Len(p) = 2 Then
            p = "00" + p
        ElseIf Len(p) = 3 Then
            p = "0" + p
        End If
        txtsid.Text = "S" + p

        txtname.Text = ""
        rfemale.Checked = True
        rmale.Checked = False
        txtdob.Text = ""
        txtpresent.Text = ""
        txtpermanent.Text = ""
        txtcno.Text = ""
        txtqual.Text = ""
        'ddldept.Text = ""
        'ddlcat.Text = ""

        lbval.Items.Clear()
        qry = "select eid from staff"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "staff")
        i = ds.Tables("staff").Rows.Count
        Dim j As Integer
        For j = 0 To i - 1
            lbval.Items.Add(ds.Tables("staff").Rows(j)(0))
        Next
    End Sub

    Protected Sub Bsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bsave.Click
        If txtsid.Text = "" Or txtname.Text = "" Or txtdob.Text = "" Or txtpresent.Text = "" Or txtpermanent.Text = "" Or txtcno.Text = "" Or txtqual.Text = "" Or ddldept.Text = "" Or ddlcat.Text = "" Then
            MsgBox("Please Enter All Values Then Save", MsgBoxStyle.Information)
        ElseIf rmale.Checked = False And rfemale.Checked = False Then
            MsgBox("Please Select Any One Gender(Male/Female)", MsgBoxStyle.Information)
        ElseIf rmale.Checked = True Then
            qry = "insert into staff values('" + txtsid.Text + "','" + txtname.Text + "','" + rmale.Text + "','" + txtdob.Text + "','" + txtpresent.Text + "','" + txtpermanent.Text + "','" + txtcno.Text + "','" + txtqual.Text + "','" + ddldept.Text + "','" + ddlcat.Text + "')"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Added")
        ElseIf rfemale.Checked = True Then
            qry = "insert into staff values('" + txtsid.Text + "','" + txtname.Text + "','" + rfemale.Text + "','" + txtdob.Text + "','" + txtpresent.Text + "','" + txtpermanent.Text + "','" + txtcno.Text + "','" + txtqual.Text + "','" + ddldept.Text + "','" + ddlcat.Text + "')"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Added")
        End If

        Dim p As String
        qry = "select eid from staff"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "staff")
        i = ds.Tables("staff").Rows.Count
        'p = ds.Tables("staff").Rows(i - 1)(0)
        p = i - 0
        p = Mid(p, 2)
        p = Val(p) + 1
        If Len(p) = 1 Then
            p = "000" + p
        ElseIf Len(p) = 2 Then
            p = "00" + p
        ElseIf Len(p) = 3 Then
            p = "0" + p
        End If
        txtsid.Text = "S" + p

        txtname.Text = ""
        rfemale.Checked = True
        rmale.Checked = False
        txtdob.Text = ""
        txtpresent.Text = ""
        txtpermanent.Text = ""
        txtcno.Text = ""
        txtqual.Text = ""
        'ddldept.Text = ""
        'ddlcat.Text = ""

        lbval.Items.Clear()
        qry = "select eid from staff"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "staff")
        i = ds.Tables("staff").Rows.Count
        Dim j As Integer
        For j = 0 To i - 1
            lbval.Items.Add(ds.Tables("staff").Rows(j)(0))
        Next
    End Sub

    Protected Sub lbval_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbval.SelectedIndexChanged
        Dim s As String
        qry = "select eid,ename,gender,dob,preaddr,peraddr,phno,qual,dept,cat from staff where eid='" + lbval.SelectedItem.Text + "'"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "staff")
        txtsid.Text = ds.Tables("staff").Rows(0)(0)
        txtname.Text = ds.Tables("staff").Rows(0)(1)
        s = ds.Tables("staff").Rows(0)(2)
        If s = "Male" Then
            rmale.Checked = True
            rfemale.Checked = False
        ElseIf s = "Female" Then
            rmale.Checked = False
            rfemale.Checked = True
        End If
        txtdob.Text = ds.Tables("staff").Rows(0)(3)
        txtpresent.Text = ds.Tables("staff").Rows(0)(4)
        txtpermanent.Text = ds.Tables("staff").Rows(0)(5)
        txtcno.Text = ds.Tables("staff").Rows(0)(6)
        txtqual.Text = ds.Tables("staff").Rows(0)(7)
        ddldept.Text = ds.Tables("staff").Rows(0)(8)
        ddlcat.Text = ds.Tables("staff").Rows(0)(9)

    End Sub

    Protected Sub Bedit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bedit.Click
        If txtsid.Text = "" Or txtname.Text = "" Or txtdob.Text = "" Or txtpresent.Text = "" Or txtpermanent.Text = "" Or txtcno.Text = "" Or txtqual.Text = "" Or ddldept.Text = "" Or ddlcat.Text = "" Then
            MsgBox("Please Select Any One Staff ID from the List then Edit", MsgBoxStyle.Information)
        ElseIf rmale.Checked = False And rfemale.Checked = False Then
            MsgBox("Please Select Any One Staff ID from the List then Edit", MsgBoxStyle.Information)
        ElseIf rmale.Checked = True Then
            qry = "update staff set ename='" + txtname.Text + "',gender='" + rmale.Text + "',dob='" + txtdob.Text + "',preaddr='" + txtpresent.Text + "',peraddr='" + txtpermanent.Text + "',phno='" + txtcno.Text + "',qual='" + txtqual.Text + "',dept='" + ddldept.Text + "',cat='" + ddlcat.Text + "' where eid='" + txtsid.Text + "'"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Edited")
        ElseIf rfemale.Checked = True Then
            qry = "update staff set ename='" + txtname.Text + "',gender='" + rfemale.Text + "',dob='" + txtdob.Text + "',preaddr='" + txtpresent.Text + "',peraddr='" + txtpermanent.Text + "',phno='" + txtcno.Text + "',qual='" + txtqual.Text + "',dept='" + ddldept.Text + "',cat='" + ddlcat.Text + "' where eid='" + txtsid.Text + "'"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Updated")
        End If

        Dim p As String
        qry = "select eid from staff"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "staff")
        i = ds.Tables("staff").Rows.Count
        ' p = ds.Tables("staff").Rows(i - 1)(0)
        p = i - 0
        p = Mid(p, 2)
        p = Val(p) + 1
        If Len(p) = 1 Then
            p = "000" + p
        ElseIf Len(p) = 2 Then
            p = "00" + p
        ElseIf Len(p) = 3 Then
            p = "0" + p
        End If
        txtsid.Text = "S" + p

        txtname.Text = ""
        rfemale.Checked = True
        rmale.Checked = False
        txtdob.Text = ""
        txtpresent.Text = ""
        txtpermanent.Text = ""
        txtcno.Text = ""
        txtqual.Text = ""
        'ddldept.Text = ""
        'ddlcat.Text = ""

        lbval.Items.Clear()
        qry = "select eid from staff"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "staff")
        i = ds.Tables("staff").Rows.Count
        Dim j As Integer
        For j = 0 To i - 1
            lbval.Items.Add(ds.Tables("staff").Rows(j)(0))
        Next
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ddlcat.Items.Add("Bachelor")
            ddlcat.Items.Add("Master")

            lbval.Items.Clear()
            qry = "select eid from staff"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "staff")
            i = ds.Tables("staff").Rows.Count
            Dim j As Integer
            For j = 0 To i - 1
                lbval.Items.Add(ds.Tables("staff").Rows(j)(0))
            Next

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


            Dim p As String
            qry = "select eid from staff"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "staff")
            i = ds.Tables("staff").Rows.Count
            '  p = ds.Tables("staff").Rows(i - 1)(0)
            p = i - 0
            p = Mid(p, 2)
            p = Val(p) + 1
            If Len(p) = 1 Then
                p = "000" + p
            ElseIf Len(p) = 2 Then
                p = "00" + p
            ElseIf Len(p) = 3 Then
                p = "0" + p
            End If
            txtsid.Text = "S" + p
        End If
    End Sub

    Protected Sub txtsid_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsid.TextChanged

    End Sub
End Class
