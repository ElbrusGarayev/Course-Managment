Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class StudentSemFee
    Inherits System.Web.UI.Page

    Protected Sub Bshow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bshow.Click
        Dim constr As String = "Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True"
        Dim cmdstr As String = "select sregno,sname,fdate,sem,sfee from fees"
        Dim con As New SqlConnection(constr)
        Dim cmd As New SqlCommand(cmdstr, con)
        con.Open()
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If (dr.HasRows()) Then
            dg.DataSource = dr
            dg.DataBind()
            con.Close()
        Else
            MsgBox("No data found")
            con.Close()
        End If
    End Sub
End Class
