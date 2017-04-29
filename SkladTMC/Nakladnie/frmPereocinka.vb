Public Class frmPereocinka
    Private Sub ПереоценкаТМЦBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ПереоценкаТМЦBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)

    End Sub

    Private Sub frmPereocinka_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ТМЦ". При необходимости она может быть перемещена или удалена.
        Me.ТМЦTableAdapter.Fill(Me.DbDataSet.ТМЦ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ЧтоПереоценивается". При необходимости она может быть перемещена или удалена.
        Me.ЧтоПереоцениваетсяTableAdapter.Fill(Me.DbDataSet.ЧтоПереоценивается)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ПереоценкаТМЦ". При необходимости она может быть перемещена или удалена.
        Me.ПереоценкаТМЦTableAdapter.Fill(Me.DbDataSet.ПереоценкаТМЦ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ЧтоПеремещается". При необходимости она может быть перемещена или удалена.
        Me.ПереоценкаТМЦTableAdapter.Fill(Me.DbDataSet.ПереоценкаТМЦ)

    End Sub

    Private Sub _ДокументаLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ПереоценкаТМЦBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ПереоценкаТМЦBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ПереоценкаТМЦBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)

    End Sub
End Class