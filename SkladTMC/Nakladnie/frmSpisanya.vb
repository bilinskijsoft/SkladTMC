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
End Class