<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMOL
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DbDataSet = New Sklad_TMC.dbDataSet()
        Me.МОЛBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.МОЛTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.МОЛTableAdapter()
        Me.TableAdapterManager = New Sklad_TMC.dbDataSetTableAdapters.TableAdapterManager()
        Me.МОЛDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.МОЛBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.МОЛDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'МОЛBindingSource
        '
        Me.МОЛBindingSource.DataMember = "МОЛ"
        Me.МОЛBindingSource.DataSource = Me.DbDataSet
        '
        'МОЛTableAdapter
        '
        Me.МОЛTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Sklad_TMC.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ВнутреннееПеремещениеТМЦTableAdapter = Nothing
        Me.TableAdapterManager.МОЛTableAdapter = Me.МОЛTableAdapter
        Me.TableAdapterManager.ПереоценкаТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ПодразделенияTableAdapter = Nothing
        Me.TableAdapterManager.ПоставщикиTableAdapter = Nothing
        Me.TableAdapterManager.ПриходТМЦTableAdapter = Nothing
        Me.TableAdapterManager.СписаниеТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПеремещаетсяTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПереоцениваетсяTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПиришлоTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоСписываетсяTableAdapter = Nothing
        '
        'МОЛDataGridView
        '
        Me.МОЛDataGridView.AutoGenerateColumns = False
        Me.МОЛDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.МОЛDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.МОЛDataGridView.DataSource = Me.МОЛBindingSource
        Me.МОЛDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.МОЛDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.МОЛDataGridView.Name = "МОЛDataGridView"
        Me.МОЛDataGridView.Size = New System.Drawing.Size(397, 349)
        Me.МОЛDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "КодМОЛ"
        Me.DataGridViewTextBoxColumn1.HeaderText = "КодМОЛ"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ФИОМОЛ"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ФИОМОЛ"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmMOL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 349)
        Me.Controls.Add(Me.МОЛDataGridView)
        Me.Name = "frmMOL"
        Me.Text = "frmMOL"
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.МОЛBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.МОЛDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DbDataSet As dbDataSet
    Friend WithEvents МОЛBindingSource As BindingSource
    Friend WithEvents МОЛTableAdapter As dbDataSetTableAdapters.МОЛTableAdapter
    Friend WithEvents TableAdapterManager As dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents МОЛDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
