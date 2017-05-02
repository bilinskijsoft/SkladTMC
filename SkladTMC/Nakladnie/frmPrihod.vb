Imports Microsoft.Office.Interop


Public Class frmPrihod
    Private Sub frmPrihod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ТМЦ". При необходимости она может быть перемещена или удалена.
        Me.ТМЦTableAdapter.Fill(Me.DbDataSet.ТМЦ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ЧтоПиришло". При необходимости она может быть перемещена или удалена.
        Me.ЧтоПиришлоTableAdapter.Fill(Me.DbDataSet.ЧтоПиришло)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
        Me.ПоставщикиTableAdapter.Fill(Me.DbDataSet.Поставщики)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.Подразделения". При необходимости она может быть перемещена или удалена.
        Me.ПодразделенияTableAdapter.Fill(Me.DbDataSet.Подразделения)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.МОЛ". При необходимости она может быть перемещена или удалена.
        Me.МОЛTableAdapter.Fill(Me.DbDataSet.МОЛ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ПриходТМЦ". При необходимости она может быть перемещена или удалена.
        Me.ПриходТМЦTableAdapter.Fill(Me.DbDataSet.ПриходТМЦ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ПриходТМЦ". При необходимости она может быть перемещена или удалена.
        Me.ПриходТМЦTableAdapter.Fill(Me.DbDataSet.ПриходТМЦ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ПриходТМЦ". При необходимости она может быть перемещена или удалена.
        Me.ПриходТМЦTableAdapter.Fill(Me.DbDataSet.ПриходТМЦ)

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If Not IsNothing(ComboBox3.SelectedValue) Then ПоставщикTextBox.Text = ComboBox3.SelectedValue.ToString
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If Not IsNothing(ComboBox2.SelectedValue) Then ПодразделениеTextBox.Text = ComboBox2.SelectedValue.ToString
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Not IsNothing(ComboBox1.SelectedValue) Then МОЛTextBox.Text = ComboBox1.SelectedValue.ToString
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
    End Sub

    Private Sub ПриходТМЦBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ПриходТМЦBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ПриходТМЦBindingSource.EndEdit()
        Me.ЧтоПиришлоBindingSource.EndEdit()
        Me.ЧтоПиришлоTableAdapter.Update(Me.DbDataSet)
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
    End Sub

    Private Sub ДатаDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles ДатаDateTimePicker.ValueChanged
        Dim currentPosition = ПриходТМЦBindingSource.Position
        Me.Validate()
        Me.ПриходТМЦBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
        Try
            frmPrihod_Load(Nothing, Nothing)
        Catch ex As Exception

        End Try
        ПриходТМЦBindingSource.Position = currentPosition
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileSystem.FileCopy(Application.StartupPath & "/nakladnaya.xls", Application.StartupPath & "/nakladnaya_tmp.xls")
        createExcellApp(Application.StartupPath & "/nakladnaya_tmp.xls")
        writeCell("Накладна на приход " & _ДокументаTextBox.Text, 3, 3)
        writeCell(" № " & _ДокументаTextBox.Text, 3, 4)
        writeCell(" від " & ДатаDateTimePicker.Text, 3, 5)
        writeCell(ComboBox3.Text, 5, 3)
        writeCell(ComboBox1.Text, 6, 3)

        Dim i As Integer = 0
        For i = 0 To ЧтоПиришлоDataGridView.RowCount - 2
            copyRow(9 + i)

            writeCell(Str(i + 1), 9 + i, 2)

            Dim TMCrows = ТМЦTableAdapter.GetData

            Dim j = 0

            For j = 0 To TMCrows.Count - 1
                If TMCrows.Item(j).Item(TMCrows.ИнвентарныйНомерColumn) = ЧтоПиришлоDataGridView.Item(1, i).Value Then
                    writeCell(TMCrows.Item(j).Item(TMCrows.НаименованиеColumn).ToString, 9 + i, 3)
                    writeCell(TMCrows.Item(j).Item(TMCrows.ЕденицаУчетаColumn).ToString, 9 + i, 4)
                End If
            Next



            writeCell(ЧтоПиришлоDataGridView.Item(2, i).Value.ToString, 9 + i, 5)

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