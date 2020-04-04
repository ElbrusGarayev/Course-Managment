Imports System
Imports System.Data
Imports System.Data.SqlClient

Partial Class NewAttendReport
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True")
    Dim com As SqlCommand
    Dim qry As String
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Dim p As String
    Protected Sub Bview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bview.Click
        Try
            Dim i As String = InputBox("Enter Date:(MM/DATE/YYYY)", "Attendance", "MM/DATE/YYYY")
            'Dim i As String = "hello / world"
            Dim str() As String = Split(i, "/")
            If str(0) > 12 Or str(1) > 31 Or str(2) < 1000 Then
                MsgBox("Invalid date format")
            Else
                qry = "select adate,sregno,sname,sattend from attend where adate='" + i + "'"
                com = New SqlCommand(qry, con)
                adp = New SqlDataAdapter(com)
                'Dataset21.Clear()
                ds = New DataSet()
                adp.Fill(ds, "attend")
                If ds.Tables(0).Rows.Count <> 0 Then
                    dg.DataSource = ds.Tables(0)
                    dg.DataBind()
                Else
                    MsgBox("No record found with this date")
                End If
            End If



        Catch ex As Exception
            MsgBox("Wrong Date", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Protected Sub Bexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Response.Redirect("Main.aspx")
    End Sub
End Class
