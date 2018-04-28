Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet
    Dim workbook As Excel.Workbook
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim UpdateFile As String = Application.StartupPath & "\updatefile.updatemdp"

        If System.IO.File.Exists(UpdateFile) = True Then
            Dim objreader As New System.IO.StreamReader(UpdateFile)
            Dim NewUpdate As String = Format(Date.Today, "yyyy")
            NewUpdate = objreader.ReadToEnd
            If NewUpdate < Val(Format(Date.Today, "yyyy")) Then
                MsgBox("Software is not Compatible to the Updated PC.", MsgBoxStyle.Exclamation, "Cash Voucher - OutDated")
                End
            End If
            objreader.Close()
        Else
            MsgBox("updatefile.updatemdp is missing.", MsgBoxStyle.Exclamation, "File missing")
            End

        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Dim Numholder As String = ""
        Dim Numholder As Integer = 0
        Dim fileName As String = Application.StartupPath & "\history\Cash Voucher -" & Format(Date.Now, "dd-yyyy hh-mm-ss") & ".xlsx"
        workbook = APP.Workbooks.Open(Application.StartupPath & "\res\Cash Voucher.xlsx")
        worksheet = workbook.Worksheets("Cash Voucher")
        'TextBox1.Text = worksheet.Cells(9, 4).value
        Numholder = My.Settings.Series + 1
        'MsgBox(Numholder)
        My.Settings.Series = My.Settings.Series + 1
        My.Settings.Save()

        If Numholder >= 1000 Then
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
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start(Application.StartupPath & "\res\Cash Voucher.xlsx")
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        frmSetting.Show()
        frmSetting.Focus()
    End Sub
End Class
