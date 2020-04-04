Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class Marks
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True")
    Dim com As SqlCommand
    Dim qry As String
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Protected Sub BClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BClear.Click
        'sregno.Text = ""
        txtstdname.Text = ""
        txtsem1.Text = ""
        txtsem2.Text = ""
        txtsem3.Text = ""
        txtsem4.Text = ""
        txtsem5.Text = ""
        txtsem6.Text = ""
        tot.Text = "0"

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            'DropDownList1.Text = ""
            txtstdname.Text = ""
            txtsem1.Text = ""
            txtsem2.Text = ""
            txtsem3.Text = ""
            txtsem4.Text = ""
            txtsem5.Text = ""
            txtsem6.Text = ""
            tot.Text = ""

        End If

    End Sub

    Protected Sub Bexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Response.Redirect("Main.aspx")
    End Sub

    Protected Sub Regddl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Regddl.SelectedIndexChanged
        qry = "select sname from stureg where sregno='" + Regddl.SelectedItem.Text + "'"
        com = New SqlCommand(qry, con)
        adp = New SqlDataAdapter(com)
        ds = New DataSet
        adp.Fill(ds, "stureg")
        txtstdname.Text = ds.Tables("stureg").Rows(0)(0)
    End Sub

    Protected Sub Bsearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bsearch.Click
        Dim s As String
        s = InputBox("Enter Student Reg No:")
        Try
            qry = "select sregno from marks where sregno='" + s + "'"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "marks")
            Regddl.Text = ds.Tables("marks").Rows(0)(0)

            qry = "select sname from marks where sregno='" + s + "'"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "marks")
            txtstdname.Text = ds.Tables("marks").Rows(0)(0)

            qry = "select sem1,sem2,sem3,sem4,sem5,sem6,tot from marks where sregno='" + s + "'"
            com = New SqlCommand(qry, con)
            adp = New SqlDataAdapter(com)
            ds = New DataSet
            adp.Fill(ds, "marks")
            txtsem1.Text = ds.Tables("marks").Rows(0)(0)
            txtsem2.Text = ds.Tables("marks").Rows(0)(1)
            txtsem3.Text = ds.Tables("marks").Rows(0)(2)
            txtsem4.Text = ds.Tables("marks").Rows(0)(3)
            txtsem5.Text = ds.Tables("marks").Rows(0)(4)
            txtsem6.Text = ds.Tables("marks").Rows(0)(5)
            tot.Text = ds.Tables("marks").Rows(0)(6)

        Catch ex As Exception
            MsgBox("Please Enter Correct Register No")
        End Try
    End Sub

    'Private Sub tot_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tot.Click

    'End Sub

    Protected Sub tot_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tot.TextChanged

    End Sub

    Protected Sub Bsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bsave.Click
        If Regddl.Text = "" Or txtstdname.Text = "" Or txtsem1.Text = "" Or txtsem2.Text = "" Or txtsem3.Text = "" Or txtsem4.Text = "" Or txtsem5.Text = "" Or txtsem6.Text = "" Or tot.Text = "" Then
            MsgBox("Please Enter All Values then Save", MsgBoxStyle.Information)
        Else

            qry = "insert into marks values('" + Regddl.Text + "','" + txtstdname.Text + "','" + txtsem1.Text + "','" + txtsem2.Text + "','" + txtsem3.Text + "','" + txtsem4.Text + "','" + txtsem5.Text + "','" + txtsem6.Text + "','" + tot.Text + "')"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Added")

            'Regddl.Text = ""
            txtstdname.Text = ""
            txtsem1.Text = ""
            txtsem2.Text = ""
            txtsem3.Text = ""
            txtsem4.Text = ""
            txtsem5.Text = ""
            txtsem6.Text = ""
            tot.Text = ""

        End If
    End Sub

    Protected Sub Btotal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btotal.Click
        If txtsem1.Text = "0" And txtsem2.Text = "0" And txtsem3.Text = "0" And txtsem4.Text = "0" And txtsem5.Text = "0" And txtsem6.Text = "0" Then
            MsgBox("Please Enter any Semester marks Orderly")
        ElseIf txtsem2.Text = "0" And txtsem3.Text = "0" And txtsem4.Text = "0" And txtsem5.Text = "0" And txtsem6.Text = "0" Then
            If Not txtsem1.Text = "0" Then
                tot.Text = Val(txtsem1.Text) / 1
            End If
        ElseIf txtsem3.Text = "0" And txtsem4.Text = "0" And txtsem5.Text = "0" And txtsem6.Text = "0" Then
            If Not txtsem1.Text = "0" And Not txtsem2.Text = "0" Then
                tot.Text = (Val(txtsem1.Text) + Val(txtsem2.Text)) / 2
            End If

        ElseIf txtsem4.Text = "0" And txtsem5.Text = "0" And txtsem6.Text = "0" Then

            If Not txtsem1.Text = "0" And Not txtsem2.Text = "0" And Not txtsem3.Text = "0" Then
                tot.Text = (Val(txtsem1.Text) + Val(txtsem2.Text) + Val(txtsem3.Text)) / 3
            End If

        ElseIf txtsem5.Text = "0" And txtsem6.Text = "0" Then

            If Not txtsem1.Text = "0" And Not txtsem2.Text = "0" And Not txtsem3.Text = "0" And Not txtsem4.Text = "0" Then
                tot.Text = (Val(txtsem1.Text) + Val(txtsem2.Text) + Val(txtsem3.Text) + Val(txtsem4.Text)) / 4
            End If

        ElseIf txtsem6.Text = "0" Then

            If Not txtsem1.Text = "0" And Not txtsem2.Text = "0" And Not txtsem3.Text = "0" And Not txtsem4.Text = "0" And Not txtsem5.Text = "0" Then
                tot.Text = (Val(txtsem1.Text) + Val(txtsem2.Text) + Val(txtsem3.Text) + Val(txtsem4.Text) + Val(txtsem5.Text)) / 5
            End If
        Else
            If Not txtsem1.Text = "0" And Not txtsem2.Text = "0" And Not txtsem3.Text = "0" And Not txtsem4.Text = "0" And Not txtsem5.Text = "0" And Not txtsem6.Text = "0" Then
                tot.Text = (Val(txtsem1.Text) + Val(txtsem2.Text) + Val(txtsem3.Text) + Val(txtsem4.Text) + Val(txtsem5.Text) + Val(txtsem6.Text)) / 6
            End If
        End If
    End Sub

    Protected Sub Bedit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bedit.Click
        If Regddl.Text = "" Or txtstdname.Text = "" Or txtsem1.Text = "" Or txtsem2.Text = "" Or txtsem3.Text = "" Or txtsem4.Text = "" Or txtsem5.Text = "" Or txtsem6.Text = "" Or tot.Text = "" Then
            MsgBox("Please Search Any One Students Marks then Edit", MsgBoxStyle.Information)
        Else
            qry = "update marks set sname='" + txtstdname.Text + "',sem1='" + txtsem1.Text + "',sem2='" + txtsem2.Text + "',sem3='" + txtsem3.Text + "',sem4='" + txtsem4.Text + "',sem5='" + txtsem5.Text + "',sem6='" + txtsem6.Text + "',tot='" + tot.Text + "' where sregno='" + Regddl.Text + "'"
            com = New SqlCommand(qry, con)
            con.Open()
            com.ExecuteScalar()
            con.Close()
            MsgBox("Successfully Updated")

            'Regddl.Text = ""
            txtstdname.Text = ""
            txtsem1.Text = ""
            txtsem2.Text = ""
            txtsem3.Text = ""
            txtsem4.Text = ""
            txtsem5.Text = ""
            txtsem6.Text = ""
            tot.Text = ""
        End If
    End Sub
End Class
