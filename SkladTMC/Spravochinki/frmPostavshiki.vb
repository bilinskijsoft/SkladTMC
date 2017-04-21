Imports System.ComponentModel

Public Class frmPostavshiki
    Private Sub frmPostavshiki_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Validate()
        Me.ПоставщикиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
    End Sub

    Private Sub frmPostavshiki_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
        Me.ПоставщикиTableAdapter.Fill(Me.DbDataSet.Поставщики)

    End Sub

End Class