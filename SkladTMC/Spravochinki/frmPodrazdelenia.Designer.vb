<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPodrazdelenia
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
        Me.ПодразделенияBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПодразделенияTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ПодразделенияTableAdapter()
        Me.TableAdapterManager = New Sklad_TMC.dbDataSetTableAdapters.TableAdapterManager()
        Me.ПодразделенияDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПодразделенияBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПодразделенияDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПодразделенияBindingSource
        '
        Me.ПодразделенияBindingSource.DataMember = "Подразделения"
        Me.ПодразделенияBindingSource.DataSource = Me.DbDataSet
        '
        'ПодразделенияTableAdapter
        '
        Me.ПодразделенияTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Sklad_TMC.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ВнутреннееПеремещениеТМЦTableAdapter = Nothing
        Me.TableAdapterManager.МОЛTableAdapter = Nothing
        Me.TableAdapterManager.ПереоценкаТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ПодразделенияTableAdapter = Me.ПодразделенияTableAdapter
        Me.TableAdapterManager.ПоставщикиTableAdapter = Nothing
        Me.TableAdapterManager.ПриходТМЦTableAdapter = Nothing
        Me.TableAdapterManager.СписаниеТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПеремещаетсяTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПереоцениваетсяTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПиришлоTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоСписываетсяTableAdapter = Nothing
        '
        'ПодразделенияDataGridView
        '
        Me.ПодразделенияDataGridView.AutoGenerateColumns = False
        Me.ПодразделенияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ПодразделенияDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ПодразделенияDataGridView.DataSource = Me.ПодразделенияBindingSource
        Me.ПодразделенияDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ПодразделенияDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ПодразделенияDataGridView.Name = "ПодразделенияDataGridView"
        Me.ПодразделенияDataGridView.Size = New System.Drawing.Size(451, 375)
        Me.ПодразделенияDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "КодПодразделения"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Код"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Нимаенование"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Найменування"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmPodrazdelenia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 375)
        Me.Controls.Add(Me.ПодразделенияDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPodrazdelenia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Підрозділи"
        Me.TopMost = True
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПодразделенияBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПодразделенияDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DbDataSet As dbDataSet
    Friend WithEvents ПодразделенияBindingSource As BindingSource
    Friend WithEvents ПодразделенияTableAdapter As dbDataSetTableAdapters.ПодразделенияTableAdapter
    Friend WithEvents TableAdapterManager As dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ПодразделенияDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
