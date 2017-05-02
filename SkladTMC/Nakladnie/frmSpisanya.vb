Imports Microsoft.Office.Interop

Public Class frmSpisanya
    Private Sub СписаниеТМЦBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles СписаниеТМЦBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.СписаниеТМЦBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)

    End Sub

    Private Sub frmSpisanya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ТМЦ". При необходимости она может быть перемещена или удалена.
        Me.ТМЦTableAdapter.Fill(Me.DbDataSet.ТМЦ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ЧтоСписывается". При необходимости она может быть перемещена или удалена.
        Me.ЧтоСписываетсяTableAdapter.Fill(Me.DbDataSet.ЧтоСписывается)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.СписаниеТМЦ". При необходимости она может быть перемещена или удалена.
        Me.СписаниеТМЦTableAdapter.Fill(Me.DbDataSet.СписаниеТМЦ)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileSystem.FileCopy(Application.StartupPath & "/nakladnaya.xls", Application.StartupPath & "/nakladnaya_tmp.xls")
        createExcellApp(Application.StartupPath & "/nakladnaya_tmp.xls")
        writeCell("Накладна на приход " & _ДокументаTextBox.Text, 3, 3)
        writeCell(" № " & _ДокументаTextBox.Text, 3, 4)
        writeCell(" від " & ДатаDateTimePicker.Text, 3, 5)

        Dim i As Integer = 0
        For i = 0 To ЧтоСписываетсяDataGridView.RowCount - 2
            copyRow(9 + i)

            writeCell(Str(i + 1), 9 + i, 2)

            Dim TMCrows = ТМЦTableAdapter.GetData

            Dim j = 0

            For j = 0 To TMCrows.Count - 1
                If TMCrows.Item(j).Item(TMCrows.ИнвентарныйНомерColumn) = ЧтоСписываетсяDataGridView.Item(1, i).Value Then
                    writeCell(TMCrows.Item(j).Item(TMCrows.НаименованиеColumn).ToString, 9 + i, 3)
                    writeCell(TMCrows.Item(j).Item(TMCrows.ЕденицаУчетаColumn).ToString, 9 + i, 4)
                End If
            Next



            writeCell(ЧтоСписываетсяDataGridView.Item(2, i).Value.ToString, 9 + i, 5)

        Next
    End Sub

    Private app As Excel.Application
    Private wBook As Excel.Workbook
    Private wSheet As Excel.Worksheet
    Private range As Excel.Range

    Public Sub createExcellApp(path As String)
        app = CType(CreateObject("Excel.Application"), Excel.Application)
        app.Visible = True
        If path <> "" Then
            wBook = app.Workbooks.Open(path)
        Else
            wBook = app.Workbooks.Add
        End If
        wSheet = CType(wBook.ActiveSheet, Excel.Worksheet)
    End Sub

    Public Sub writeCell(text As String, row As Integer, col As Integer)
        wSheet.Cells(row, col).Value = text
    End Sub

    Public Sub destroyExcellApp()
        range = Nothing
        wSheet = Nothing
        wSheet = Nothing
        app.Quit()
        app = Nothing
    End Sub

    Public Sub copyRow(row As Integer)
        wSheet.Range("B" & row & ":G" & row).Copy(wSheet.Range("B" & row + 1 & ":G" & row + 1))
    End Sub
End Class