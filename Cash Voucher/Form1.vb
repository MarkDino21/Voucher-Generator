Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet
    Dim workbook As Excel.Workbook
    Public cv As String = "RMMC"
    Dim filename As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim UpdateFile As String = Application.StartupPath & "\updatefile.updatemdp"

        If System.IO.File.Exists(UpdateFile) = True Then
            Dim objreader As New System.IO.StreamReader(UpdateFile)
            Dim NewUpdate As String = Format(Date.Today, "yyyy")
            NewUpdate = objreader.ReadToEnd
            If NewUpdate < Val(Format(Date.Today, "yyyy")) Then
                MsgBox("Compatibility problem detected.", MsgBoxStyle.Exclamation, "Cash Voucher Update")
                End
            End If
            objreader.Close()
        Else
            MsgBox("updatefile.updatemdp is missing.", MsgBoxStyle.Exclamation, "File missing")
            End

        End If

        Label2_Click(sender, e)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Dim Numholder As String = ""
        Dim Numholder As Integer = 0
        If cv = "RMMC" Then
            Numholder = My.Settings.Series + 1
            filename = Application.StartupPath & "\history\RMMC CV -" & Numholder & "-" & Format(Date.Now, "mm-dd-yyyy hh-mm-ss") & ".xlsx"
            My.Settings.Series += 1
        ElseIf cv = "RDC" Then
            Numholder = My.Settings.Series2 + 1
            filename = Application.StartupPath & "\history\RDC CV -" & Numholder & "-" & Format(Date.Now, "mm-dd-yyyy hh-mm-ss") & ".xlsx"
            My.Settings.Series2 += 1
        End If

        workbook = APP.Workbooks.Open(Application.StartupPath & "\res\Cash Voucher.xlsx")
        worksheet = workbook.Worksheets("Cash Voucher")
        My.Settings.Save()



        If Numholder >= 100 Then
            worksheet.Cells(4, 9).value = "00000" & Numholder
        ElseIf Numholder >= 1000 Then
            worksheet.Cells(4, 9).value = "0000" & Numholder
        ElseIf Numholder >= 10000 Then
            worksheet.Cells(4, 9).value = "000" & Numholder
        ElseIf Numholder >= 100000 Then
            worksheet.Cells(4, 9).value = "00" & Numholder
        ElseIf Numholder >= 100000 Then
            worksheet.Cells(4, 9).value = "0" & Numholder
        ElseIf Numholder >= 100000 Then
            worksheet.Cells(4, 9).value = Numholder
        End If

        worksheet.Cells(5, 9).value = Date.Today

        'workbook.Save()
        workbook.SaveAs(fileName)
        workbook.Close()
        Process.Start(fileName)
        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start(Application.StartupPath & "\res\Cash Voucher.xlsx")
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSetting.Click
        frmSetting.Show()
        frmSetting.Focus()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblRMMC.Click
        sender.BackColor = Color.Blue
        cv = "RMMC"
        BackgroundImage = My.Resources.cash_voucher_rm
        lblRDC.BackColor = Color.Transparent
        Button3.ForeColor = Color.Blue
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblRDC.Click
        sender.BackColor = Color.Green
        cv = "RDC"
        BackgroundImage = My.Resources.cash_voucher_realty
        lblRMMC.BackColor = Color.Transparent
        Button3.ForeColor = Color.Green
    End Sub
End Class
