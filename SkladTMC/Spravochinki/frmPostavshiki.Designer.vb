<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPostavshiki
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DbDataSet = New Sklad_TMC.dbDataSet()
        Me.ПоставщикиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПоставщикиTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ПоставщикиTableAdapter()
        Me.TableAdapterManager = New Sklad_TMC.dbDataSetTableAdapters.TableAdapterManager()
        Me.ПоставщикиDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПоставщикиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПоставщикиDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПоставщикиBindingSource
        '
        Me.ПоставщикиBindingSource.DataMember = "Поставщики"
        Me.ПоставщикиBindingSource.DataSource = Me.DbDataSet
        '
        'ПоставщикиTableAdapter
        '
        Me.ПоставщикиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Sklad_TMC.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ВнутреннееПеремещениеТМЦTableAdapter = Nothing
        Me.TableAdapterManager.МОЛTableAdapter = Nothing
        Me.TableAdapterManager.ПереоценкаТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ПодразделенияTableAdapter = Nothing
        Me.TableAdapterManager.ПоставщикиTableAdapter = Me.ПоставщикиTableAdapter
        Me.TableAdapterManager.ПриходТМЦTableAdapter = Nothing
        Me.TableAdapterManager.СписаниеТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПеремещаетсяTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПереоцениваетсяTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПиришлоTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоСписываетсяTableAdapter = Nothing
        '
        'ПоставщикиDataGridView
        '
        Me.ПоставщикиDataGridView.AutoGenerateColumns = False
        Me.ПоставщикиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ПоставщикиDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ПоставщикиDataGridView.DataSource = Me.ПоставщикиBindingSource
        Me.ПоставщикиDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ПоставщикиDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ПоставщикиDataGridView.Name = "ПоставщикиDataGridView"
        Me.ПоставщикиDataGridView.Size = New System.Drawing.Size(499, 362)
        Me.ПоставщикиDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "КодПоставщика"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Код"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Наименование"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Найменування"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmPostavshiki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 362)
        Me.Controls.Add(Me.ПоставщикиDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPostavshiki"
        Me.Text = "Постачальники"
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПоставщикиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПоставщикиDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DbDataSet As dbDataSet
    Friend WithEvents ПоставщикиBindingSource As BindingSource
    Friend WithEvents ПоставщикиTableAdapter As dbDataSetTableAdapters.ПоставщикиTableAdapter
    Friend WithEvents TableAdapterManager As dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ПоставщикиDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
