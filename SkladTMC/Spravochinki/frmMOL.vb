Imports System.ComponentModel

Public Class frmMOL
    Private Sub frmMOL_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Validate()
        Me.МОЛBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
    End Sub

    Private Sub frmMOL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.МОЛ". При необходимости она может быть перемещена или удалена.
        Me.МОЛTableAdapter.Fill(Me.DbDataSet.МОЛ)

    End Sub
End Class