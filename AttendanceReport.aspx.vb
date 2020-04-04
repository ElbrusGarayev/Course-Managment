Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class AttendanceReport
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Education;Integrated Security=True")
    Dim com As SqlCommand
    Dim qry As String
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Dim p As String
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'Dim frm As String = Convert.ToDateTime(FrmDateTxt.Text)
            'Dim tod As String = Convert.ToDateTime(ToDateTxt.Text)

            'qry = "select sregno, sname, sattend from attend where adate between Convert.ToDateTime('" + FrmDateTxt.Text + "') and Convert.ToDateTime('" + ToDateTxt.Text + "') "
            qry = "select sregno, sname, sattend from attend where adate between  ('" + FrmDateTxt.Text + "') and Convert.ToDateTime('" + ToDateTxt.Text + "') "
            'FeeDue,TCIssuedDate from tctable where TCIssuedDate between cdate('" + FrmDateTxt.Text + "') and cdate('" + ToDateTxt.Text + "') order by TCIssuedDate ", mycon);
            com = New SqlCommand(qry, con)
            Dim SqlDataAdapter1 As New SqlDataAdapter(com)
            Dim Dataset11 As New DataSet
            Dataset11.Clear()
            SqlDataAdapter1.Fill(Dataset11, "attend")

            If Dataset11.Tables("attend").Rows.Count = "0" Then
                NoDatelbl.Visible = True
                lblnotfound.Visible = True
                grdAttendance.Visible = False
                btnprntpreview.Visible = False
                Printbuttn.Visible = False
                lblnotfound.Text = "No Data Found In Between :"
                NoDatelbl.Text = ("" + FrmDateTxt.Text + " , " + ToDateTxt.Text + "")

            Else

                btnprntpreview.Visible = True
                Printbuttn.Visible = True
                grdAttendance.Visible = True
                grdAttendance.DataSource = Dataset11
                grdAttendance.DataBind()
            End If


        Catch ex As Exception
            MsgBox("Please check course & dept", MsgBoxStyle.Information)

        End Try
    End Sub

    Protected Sub btnprntpreview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnprntpreview.Click

    End Sub
End Class
