Public Class frmTMC
    Private Sub ТМЦBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ТМЦBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ТМЦBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)

    End Sub

    Private Sub frmTMC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ЧтоСписывается". При необходимости она может быть перемещена или удалена.
        Me.ЧтоСписываетсяTableAdapter.Fill(Me.DbDataSet.ЧтоСписывается)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ЧтоПереоценивается". При необходимости она может быть перемещена или удалена.
        Me.ЧтоПереоцениваетсяTableAdapter.Fill(Me.DbDataSet.ЧтоПереоценивается)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ЧтоПеремещается". При необходимости она может быть перемещена или удалена.
        Me.ЧтоПеремещаетсяTableAdapter.Fill(Me.DbDataSet.ЧтоПеремещается)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ЧтоПиришло". При необходимости она может быть перемещена или удалена.
        Me.ЧтоПиришлоTableAdapter.Fill(Me.DbDataSet.ЧтоПиришло)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ТМЦ". При необходимости она может быть перемещена или удалена.
        Me.ТМЦTableAdapter.Fill(Me.DbDataSet.ТМЦ)

    End Sub
End Class