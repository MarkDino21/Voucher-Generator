Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmGenerator
    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet
    Dim workbook As Excel.Workbook
    Dim filename As String

    Private Sub frmCheckV_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Load Suppliers to the comboBox
        Dim totalRow As Integer
        Dim startedRow As Integer

        ComboBox1.Items.Clear()
        workbook = APP.Workbooks.Open(Application.StartupPath & "\res\Suppliers.xlsx")
        worksheet = workbook.Worksheets(1)
        totalRow = APP.ActiveWorkbook.Sheets(1).Range("a1").Currentregion.Rows.Count

        For startedRow = 3 To totalRow
            ComboBox1.Items.Add(worksheet.Cells(startedRow, 1).text)
        Next
        workbook.Close()

        'generate date and series
        txtDate.Text = Date.Today
        Generate_Series()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        filename = Application.StartupPath & "\history\" & Form1.cv & " " & Form1.vType & txtNum.Text & "-" & Format(Date.Now, "mm-dd-yyyy hh-mm-ss") & ".xlsx"
        'Select Type of Voucher to open
        If Form1.vType = "Cash" Then
            workbook = APP.Workbooks.Open(Application.StartupPath & "\res\Cash Voucher.xlsx")
            worksheet = workbook.Worksheets("Cash Voucher")

            worksheet.Cells(4, 9).value = txtNum.Text
            worksheet.Cells(5, 9).value = txtDate.Text
            worksheet.Cells(4, 2).value = ComboBox1.Text
        ElseIf Form1.vType = "Check" Then
            workbook = APP.Workbooks.Open(Application.StartupPath & "\res\Check Voucher.xlsx")
            worksheet = workbook.Worksheets("Sheet1")

            worksheet.Cells(2, 10).value = txtNum.Text
            worksheet.Cells(3, 10).value = txtDate.Text
            worksheet.Cells(1, 4).value = ComboBox1.Text
        End If
        'Save a new copy of workbook then open
        workbook.SaveAs(filename)
        workbook.Close()
        Process.Start(filename)
        'Save settings then close the form
        My.Settings.Save()
        Close()
    End Sub
    Public Sub Generate_Series()
        Dim series As Integer
        'Generate series for Cash Voucher
        If Form1.cv = "RMMC" And Form1.vType = "Cash" Then
            My.Settings.Series += 1
            series = My.Settings.Series
            If My.Settings.Series >= 1000 Then
                txtNum.Text = "0000" & series
            ElseIf My.Settings.Series >= 10000 Then
                txtNum.Text = "000" & series
            ElseIf My.Settings.Series >= 100000 Then
                txtNum.Text = "00" & series
            ElseIf My.Settings.Series >= 100000 Then
                txtNum.Text = "0" & series
            ElseIf My.Settings.Series >= 100000 Then
                txtNum.Text = series
            End If
            BackgroundImage = My.Resources.cash_voucher_rm
        ElseIf Form1.cv = "RDC" And Form1.vType = "Cash" Then
            My.Settings.Series2 += 1
            series = My.Settings.Series2
            If My.Settings.Series2 >= 1000 Then
                txtNum.Text = "0000" & series
            ElseIf My.Settings.Series2 >= 10000 Then
                txtNum.Text = "000" & series
            ElseIf My.Settings.Series2 >= 100000 Then
                txtNum.Text = "00" & series
            ElseIf My.Settings.Series2 >= 100000 Then
                txtNum.Text = "0" & series
            ElseIf My.Settings.Series2 >= 100000 Then
                txtNum.Text = series
            End If
            BackgroundImage = My.Resources.cash_voucher_realty

            'Generate series for Check Voucher
        ElseIf Form1.cv = "RMMC" And Form1.vType = "Check" Then
            My.Settings.CheckSeries += 1
            series = My.Settings.CheckSeries
            If My.Settings.CheckSeries >= 1000 Then
                txtNum.Text = "0000" & series
            ElseIf My.Settings.CheckSeries >= 10000 Then
                txtNum.Text = "000" & series
            ElseIf My.Settings.CheckSeries >= 100000 Then
                txtNum.Text = "00" & series
            ElseIf My.Settings.CheckSeries >= 100000 Then
                txtNum.Text = "0" & series
            ElseIf My.Settings.CheckSeries >= 100000 Then
                txtNum.Text = series
            End If
            BackgroundImage = My.Resources.cash_voucher_rm
        ElseIf Form1.cv = "RDC" And Form1.vType = "Check" Then
            My.Settings.CheckSeries2 += 1
            series = My.Settings.CheckSeries2
            If My.Settings.CheckSeries2 >= 1000 Then
                txtNum.Text = "0000" & series
            ElseIf My.Settings.CheckSeries2 >= 10000 Then
                txtNum.Text = "000" & series
            ElseIf My.Settings.CheckSeries2 >= 100000 Then
                txtNum.Text = "00" & series
            ElseIf My.Settings.CheckSeries2 >= 100000 Then
                txtNum.Text = "0" & series
            ElseIf My.Settings.CheckSeries2 >= 100000 Then
                txtNum.Text = series
            End If
            BackgroundImage = My.Resources.cash_voucher_realty
        End If
    End Sub

End Class