Imports System.Data.SqlClient
Imports System.Data

Partial Class _Default
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True")
    Dim com As SqlCommand
    Dim qry As String
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            lregno.Items.Clear()
            qry = "select sregno from stureg"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "stureg")
            i = ds.Tables("stureg").Rows.Count
            Dim j As Integer
            For j = 0 To i - 1
                lregno.Items.Add(ds.Tables("stureg").Rows(j)(0))
            Next

            cid.Items.Clear()
            qry = "select cid from course"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "course")
            i = ds.Tables("course").Rows.Count
            For j = 0 To i - 1
                cid.Items.Add(ds.Tables("course").Rows(j)(0))
            Next


            rdate.Text = Date.Today

            Dim p As String
            qry = "select sregno from stureg"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "stureg")
            i = ds.Tables("stureg").Rows.Count
            'p = ds.Tables("stureg").Rows(i - 1)(0)
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
            sregno.Text = "R" + p

            sname.Text = ""
            gmale.Checked = False
            gfemale.Checked = True
            sdob.Text = ""
            fname.Text = ""
            foccup.Text = ""
            spreaddr.Text = ""
            speraddr.Text = ""
            sphno.Text = ""
            'cid.Text = ""
            cname.Text = ""
            cdept.Text = ""
            cdur.Text = ""
            ccat.Text = ""

        End If
    End Sub

    Protected Sub Bclear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bclear.Click
        rdate.Text = Date.Today

        Dim p As String
        qry = "select sregno from stureg"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "stureg")
        i = ds.Tables("stureg").Rows.Count
        p = ds.Tables("stureg").Rows(i - 1)(0)
        p = Mid(p, 2)
        p = Val(p) + 1
        If Len(p) = 1 Then
            p = "000" + p
        ElseIf Len(p) = 2 Then
            p = "00" + p
        ElseIf Len(p) = 3 Then
            p = "0" + p
        End If
        sregno.Text = "R" + p

        sname.Text = ""
        gmale.Checked = False
        gfemale.Checked = True
        sdob.Text = ""
        fname.Text = ""
        foccup.Text = ""
        spreaddr.Text = ""
        speraddr.Text = ""
        sphno.Text = ""
        'cid.Text = ""
        cname.Text = ""
        cdept.Text = ""
        cdur.Text = ""
        ccat.Text = ""

        lregno.Items.Clear()
        qry = "select sregno from stureg"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "stureg")
        i = ds.Tables("stureg").Rows.Count
        Dim j As Integer
        For j = 0 To i - 1
            lregno.Items.Add(ds.Tables("stureg").Rows(j)(0))
        Next

    End Sub

    Protected Sub Bsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bsave.Click

        If rdate.Text = "" Or sregno.Text = "" Or sname.Text = "" Or sdob.Text = "" Or fname.Text = "" Or foccup.Text = "" Or spreaddr.Text = "" Or speraddr.Text = "" Or sphno.Text = "" Or cid.Text = "" Or cname.Text = "" Or cdept.Text = "" Or cdur.Text = "" Or ccat.Text = "" Then
            MsgBox("Please Enter All Values Then Save", MsgBoxStyle.Information)
        ElseIf gmale.Checked = False And gfemale.Checked = False Then
            MsgBox("Please Select Any Gender(Male/Female)", MsgBoxStyle.Information)
        ElseIf gmale.Checked = True Then
            qry = "insert into stureg values('" + rdate.Text + "','" + sregno.Text + "','" + sname.Text + "','" + gmale.Text + "','" + sdob.Text + "','" + fname.Text + "','" + foccup.Text + "','" + spreaddr.Text + "','" + speraddr.Text + "','" + sphno.Text + "','" + cid.Text + "','" + cname.Text + "','" + cdept.Text + "','" + cdur.Text + "','" + ccat.Text + "')"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Added")
        ElseIf gfemale.Checked = True Then
            qry = "insert into stureg values('" + rdate.Text + "','" + sregno.Text + "','" + sname.Text + "','" + gfemale.Text + "','" + sdob.Text + "','" + fname.Text + "','" + foccup.Text + "','" + spreaddr.Text + "','" + speraddr.Text + "','" + sphno.Text + "','" + cid.Text + "','" + cname.Text + "','" + cdept.Text + "','" + cdur.Text + "','" + ccat.Text + "')"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Added")
        End If

        Dim p As String
        qry = "select sregno from stureg"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "stureg")
        i = ds.Tables("stureg").Rows.Count
        p = ds.Tables("stureg").Rows(i - 1)(0)
        p = Mid(p, 2)
        p = Val(p) + 1
        If Len(p) = 1 Then
            p = "000" + p
        ElseIf Len(p) = 2 Then
            p = "00" + p
        ElseIf Len(p) = 3 Then
            p = "0" + p
        End If
        sregno.Text = "R" + p

        sname.Text = ""
        gmale.Checked = False
        gfemale.Checked = True
        sdob.Text = ""
        fname.Text = ""
        foccup.Text = ""
        spreaddr.Text = ""
        speraddr.Text = ""
        sphno.Text = ""
        'cid.Text = ""
        cname.Text = ""
        cdept.Text = ""
        cdur.Text = ""
        ccat.Text = ""

        lregno.Items.Clear()
        qry = "select sregno from stureg"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "stureg")
        i = ds.Tables("stureg").Rows.Count
        Dim j As Integer
        For j = 0 To i - 1
            lregno.Items.Add(ds.Tables("stureg").Rows(j)(0))
        Next

    End Sub

    Protected Sub Bedit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bedit.Click

        If rdate.Text = "" Or sregno.Text = "" Or sname.Text = "" Or sdob.Text = "" Or fname.Text = "" Or foccup.Text = "" Or spreaddr.Text = "" Or speraddr.Text = "" Or sphno.Text = "" Or cid.Text = "" Or cname.Text = "" Or cdept.Text = "" Or cdur.Text = "" Or ccat.Text = "" Then
            MsgBox("Please Select Any One RegNo from the List then Edit", MsgBoxStyle.Information)
        ElseIf gmale.Checked = False And gfemale.Checked = False Then
            MsgBox("Please Select Any Gender(Male/Female)", MsgBoxStyle.Information)
        ElseIf gmale.Checked = True Then
            qry = "update stureg set rdate='" + rdate.Text + "',sname='" + sname.Text + "',sgender='" + gmale.Text + "',sdob='" + sdob.Text + "',fname='" + fname.Text + "',foccup='" + foccup.Text + "',spreaddr='" + spreaddr.Text + "',speraddr='" + speraddr.Text + "',sphno='" + sphno.Text + "',cid='" + cid.Text + "',cname='" + cname.Text + "',cdept='" + cdept.Text + "',cdur='" + cdur.Text + "',ccat='" + ccat.Text + "' where sregno='" + sregno.Text + "'"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Edited")
        ElseIf gfemale.Checked = True Then
            qry = "update stureg set rdate='" + rdate.Text + "',sname='" + sname.Text + "',sgender='" + gfemale.Text + "',sdob='" + sdob.Text + "',fname='" + fname.Text + "',foccup='" + foccup.Text + "',spreaddr='" + spreaddr.Text + "',speraddr='" + speraddr.Text + "',sphno='" + sphno.Text + "',cid='" + cid.Text + "',cname='" + cname.Text + "',cdept='" + cdept.Text + "',cdur='" + cdur.Text + "',ccat='" + ccat.Text + "' where sregno='" + sregno.Text + "'"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Edited")
        End If

        Dim p As String
        qry = "select sregno from stureg"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "stureg")
        i = ds.Tables("stureg").Rows.Count
        p = ds.Tables("stureg").Rows(i - 1)(0)
        p = Mid(p, 2)
        p = Val(p) + 1
        If Len(p) = 1 Then
            p = "000" + p
        ElseIf Len(p) = 2 Then
            p = "00" + p
        ElseIf Len(p) = 3 Then
            p = "0" + p
        End If
        sregno.Text = "R" + p

        sname.Text = ""
        gmale.Checked = False
        gfemale.Checked = True
        sdob.Text = ""
        fname.Text = ""
        foccup.Text = ""
        spreaddr.Text = ""
        speraddr.Text = ""
        sphno.Text = ""
        'cid.Text = ""
        cname.Text = ""
        cdept.Text = ""
        cdur.Text = ""
        ccat.Text = ""

        lregno.Items.Clear()
        qry = "select sregno from stureg"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "stureg")
        i = ds.Tables("stureg").Rows.Count
        Dim j As Integer
        For j = 0 To i - 1
            lregno.Items.Add(ds.Tables("stureg").Rows(j)(0))
        Next

    End Sub

    Protected Sub Bdelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bdelete.Click

        If rdate.Text = "" Or sregno.Text = "" Or sname.Text = "" Or sdob.Text = "" Or fname.Text = "" Or foccup.Text = "" Or spreaddr.Text = "" Or speraddr.Text = "" Or sphno.Text = "" Or cid.Text = "" Or cname.Text = "" Or cdept.Text = "" Or cdur.Text = "" Or ccat.Text = "" Then
            MsgBox("Please Select Any One RegNo from the List then Edit", MsgBoxStyle.Information)
        Else
            qry = "delete from stureg where sregno='" + sregno.Text + "'"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Deleted")

        End If

        Dim p As String
        qry = "select sregno from stureg"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "stureg")
        i = ds.Tables("stureg").Rows.Count
        p = ds.Tables("stureg").Rows(i - 1)(0)
        p = Mid(p, 2)
        p = Val(p) + 1
        If Len(p) = 1 Then
            p = "000" + p
        ElseIf Len(p) = 2 Then
            p = "00" + p
        ElseIf Len(p) = 3 Then
            p = "0" + p
        End If
        sregno.Text = "R" + p

        sname.Text = ""
        gmale.Checked = False
        gfemale.Checked = True
        sdob.Text = ""
        fname.Text = ""
        foccup.Text = ""
        spreaddr.Text = ""
        speraddr.Text = ""
        sphno.Text = ""
        'cid.Text = ""
        cname.Text = ""
        cdept.Text = ""
        cdur.Text = ""
        ccat.Text = ""

        lregno.Items.Clear()
        qry = "select sregno from stureg"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "stureg")
        i = ds.Tables("stureg").Rows.Count
        Dim j As Integer
        For j = 0 To i - 1
            lregno.Items.Add(ds.Tables("stureg").Rows(j)(0))
        Next

    End Sub

   
    Protected Sub Bexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Response.Redirect("Main.aspx")
    End Sub

    Protected Sub cid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cid.SelectedIndexChanged
        Try

            qry = "select cname,cdur,cdept,ccat from course where cid='" + cid.SelectedItem.Text + "'"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "course")
            cname.Text = ds.Tables("course").Rows(0)(0)
            cdur.Text = ds.Tables("course").Rows(0)(1)
            cdept.Text = ds.Tables("course").Rows(0)(2)
            ccat.Text = ds.Tables("course").Rows(0)(3)

        Catch ex As Exception

            MsgBox("Sqlconnection error")

        End Try
    End Sub

    Protected Sub lregno_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lregno.SelectedIndexChanged
        Try
            Dim s As String
            qry = "select sregno,sname,sgender,sdob,fname,foccup,spreaddr,speraddr,sphno,cid from stureg where sregno='" + lregno.SelectedItem.Text + "'"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "stureg")
            sregno.Text = ds.Tables("stureg").Rows(0)(0)
            sname.Text = ds.Tables("stureg").Rows(0)(1)
            s = ds.Tables("stureg").Rows(0)(2)
            If s = "Male" Then
                gmale.Checked = True
                gfemale.Checked = False
            ElseIf s = "Female" Then
                gfemale.Checked = True
                gmale.Checked = False
            End If

            sdob.Text = ds.Tables("stureg").Rows(0)(3)
            fname.Text = ds.Tables("stureg").Rows(0)(4)
            foccup.Text = ds.Tables("stureg").Rows(0)(5)
            spreaddr.Text = ds.Tables("stureg").Rows(0)(6)
            speraddr.Text = ds.Tables("stureg").Rows(0)(7)
            sphno.Text = ds.Tables("stureg").Rows(0)(8)
            cid.Text = ds.Tables("stureg").Rows(0)(9)

            qry = "select cname,cdur,cdept,ccat from stureg where cid='" + cid.Text + "'"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "stureg")
            cname.Text = ds.Tables("stureg").Rows(0)(0)
            cdur.Text = ds.Tables("stureg").Rows(0)(1)
            cdept.Text = ds.Tables("stureg").Rows(0)(2)
            ccat.Text = ds.Tables("stureg").Rows(0)(3)

        Catch ex As Exception

            MsgBox("Sqlconnection Error")

        End Try
    End Sub
End Class
