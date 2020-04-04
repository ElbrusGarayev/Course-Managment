Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class Login

    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblmsg.Visible = False
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or tname.Text = "" Then
            MsgBox("Please Enter Password and Username then Login", MsgBoxStyle.Information)
        ElseIf TextBox1.Text = "codex" And tname.Text = "codex" Then
            Response.Redirect("Main.aspx")
            TextBox1.Text = ""
        Else
            MsgBox("Incorrect Password, please try again!", MsgBoxStyle.Information)
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class
