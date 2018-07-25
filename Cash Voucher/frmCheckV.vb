Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmCheckV
    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet
    Dim workbook As Excel.Workbook
    Public cv As String = "RMMC"
    Dim filename As String

    Private Sub frmCheckV_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    End Sub
End Class