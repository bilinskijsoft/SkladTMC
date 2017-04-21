Imports System.ComponentModel

Public Class frmPodrazdelenia
    Private Sub frmPodrazdelenia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.Подразделения". При необходимости она может быть перемещена или удалена.
        Me.ПодразделенияTableAdapter.Fill(Me.DbDataSet.Подразделения)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmPodrazdelenia_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Validate()
        Me.ПодразделенияBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
    End Sub
End Class