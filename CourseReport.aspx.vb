Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class CourseReport
    Inherits System.Web.UI.Page

    Protected Sub BShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BShow.Click
        Dim constr As String = "Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True"
        Dim cmdstr As String = "select cid,cname,cdur,cdept,ccat from course"
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
