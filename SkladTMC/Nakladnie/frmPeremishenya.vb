Public Class frmPeremishenya

    Private Sub frmPeremishenya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ЧтоПеремещается". При необходимости она может быть перемещена или удалена.
        Me.ЧтоПеремещаетсяTableAdapter.Fill(Me.DbDataSet.ЧтоПеремещается)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DbDataSet.ВнутреннееПеремещениеТМЦ". При необходимости она может быть перемещена или удалена.
        Me.ВнутреннееПеремещениеТМЦTableAdapter.Fill(Me.DbDataSet.ВнутреннееПеремещениеТМЦ)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Not IsNothing(ComboBox1.SelectedValue) Then ОткудаПодразделениеTextBox.Text = ComboBox1.SelectedValue.ToString
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If Not IsNothing(ComboBox2.SelectedValue) Then ОткудаМОЛTextBox.Text = ComboBox2.SelectedValue.ToString
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If Not IsNothing(ComboBox3.SelectedValue) Then КудаПодразделениеTextBox.Text = ComboBox3.SelectedValue.ToString
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If Not IsNothing(ComboBox4.SelectedValue) Then КудаМОЛTextBox.Text = ComboBox4.SelectedValue.ToString
    End Sub

    Private Sub ВнутреннееПеремещениеТМЦBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ВнутреннееПеремещениеТМЦBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ВнутреннееПеремещениеТМЦBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)

    End Sub
End Class