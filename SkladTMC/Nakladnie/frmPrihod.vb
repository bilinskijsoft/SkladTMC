Public Class frmPrihod
    Private Sub frmPrihod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub
End Class