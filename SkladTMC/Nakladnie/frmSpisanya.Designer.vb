<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpisanya
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
        Dim _ДокументаLabel As System.Windows.Forms.Label
        Dim ДатаLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpisanya))
        Me.DbDataSet = New Sklad_TMC.dbDataSet()
        Me.СписаниеТМЦBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СписаниеТМЦTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.СписаниеТМЦTableAdapter()
        Me.TableAdapterManager = New Sklad_TMC.dbDataSetTableAdapters.TableAdapterManager()
        Me.ТМЦTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ТМЦTableAdapter()
        Me.ЧтоСписываетсяTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ЧтоСписываетсяTableAdapter()
        Me.СписаниеТМЦBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.СписаниеТМЦBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me._ДокументаTextBox = New System.Windows.Forms.TextBox()
        Me.ДатаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ЧтоСписываетсяBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЧтоСписываетсяDataGridView = New System.Windows.Forms.DataGridView()
        Me.ТМЦBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        _ДокументаLabel = New System.Windows.Forms.Label()
        ДатаLabel = New System.Windows.Forms.Label()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СписаниеТМЦBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СписаниеТМЦBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.СписаниеТМЦBindingNavigator.SuspendLayout()
        CType(Me.ЧтоСписываетсяBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЧтоСписываетсяDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ТМЦBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_ДокументаLabel
        '
        _ДокументаLabel.AutoSize = True
        _ДокументаLabel.Location = New System.Drawing.Point(12, 35)
        _ДокументаLabel.Name = "_ДокументаLabel"
        _ДокументаLabel.Size = New System.Drawing.Size(78, 13)
        _ДокументаLabel.TabIndex = 1
        _ДокументаLabel.Text = "№Документа:"
        '
        'ДатаLabel
        '
        ДатаLabel.AutoSize = True
        ДатаLabel.Location = New System.Drawing.Point(12, 62)
        ДатаLabel.Name = "ДатаLabel"
        ДатаLabel.Size = New System.Drawing.Size(36, 13)
        ДатаLabel.TabIndex = 3
        ДатаLabel.Text = "Дата:"
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'СписаниеТМЦBindingSource
        '
        Me.СписаниеТМЦBindingSource.DataMember = "СписаниеТМЦ"
        Me.СписаниеТМЦBindingSource.DataSource = Me.DbDataSet
        '
        'СписаниеТМЦTableAdapter
        '
        Me.СписаниеТМЦTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Sklad_TMC.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ВнутреннееПеремещениеТМЦTableAdapter = Nothing
        Me.TableAdapterManager.МОЛTableAdapter = Nothing
        Me.TableAdapterManager.ПереоценкаТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ПодразделенияTableAdapter = Nothing
        Me.TableAdapterManager.ПоставщикиTableAdapter = Nothing
        Me.TableAdapterManager.ПриходТМЦTableAdapter = Nothing
        Me.TableAdapterManager.СписаниеТМЦTableAdapter = Me.СписаниеТМЦTableAdapter
        Me.TableAdapterManager.ТМЦTableAdapter = Me.ТМЦTableAdapter
        Me.TableAdapterManager.ЧтоПеремещаетсяTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПереоцениваетсяTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПиришлоTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоСписываетсяTableAdapter = Me.ЧтоСписываетсяTableAdapter
        '
        'ТМЦTableAdapter
        '
        Me.ТМЦTableAdapter.ClearBeforeFill = True
        '
        'ЧтоСписываетсяTableAdapter
        '
        Me.ЧтоСписываетсяTableAdapter.ClearBeforeFill = True
        '
        'СписаниеТМЦBindingNavigator
        '
        Me.СписаниеТМЦBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.СписаниеТМЦBindingNavigator.BindingSource = Me.СписаниеТМЦBindingSource
        Me.СписаниеТМЦBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.СписаниеТМЦBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.СписаниеТМЦBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.СписаниеТМЦBindingNavigatorSaveItem})
        Me.СписаниеТМЦBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.СписаниеТМЦBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.СписаниеТМЦBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.СписаниеТМЦBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.СписаниеТМЦBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.СписаниеТМЦBindingNavigator.Name = "СписаниеТМЦBindingNavigator"
        Me.СписаниеТМЦBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.СписаниеТМЦBindingNavigator.Size = New System.Drawing.Size(379, 25)
        Me.СписаниеТМЦBindingNavigator.TabIndex = 0
        Me.СписаниеТМЦBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'СписаниеТМЦBindingNavigatorSaveItem
        '
        Me.СписаниеТМЦBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.СписаниеТМЦBindingNavigatorSaveItem.Image = CType(resources.GetObject("СписаниеТМЦBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.СписаниеТМЦBindingNavigatorSaveItem.Name = "СписаниеТМЦBindingNavigatorSaveItem"
        Me.СписаниеТМЦBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.СписаниеТМЦBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        '_ДокументаTextBox
        '
        Me._ДокументаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СписаниеТМЦBindingSource, "№Документа", True))
        Me._ДокументаTextBox.Location = New System.Drawing.Point(96, 32)
        Me._ДокументаTextBox.Name = "_ДокументаTextBox"
        Me._ДокументаTextBox.Size = New System.Drawing.Size(271, 20)
        Me._ДокументаTextBox.TabIndex = 2
        '
        'ДатаDateTimePicker
        '
        Me.ДатаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.СписаниеТМЦBindingSource, "Дата", True))
        Me.ДатаDateTimePicker.Location = New System.Drawing.Point(96, 58)
        Me.ДатаDateTimePicker.Name = "ДатаDateTimePicker"
        Me.ДатаDateTimePicker.Size = New System.Drawing.Size(271, 20)
        Me.ДатаDateTimePicker.TabIndex = 4
        '
        'ЧтоСписываетсяBindingSource
        '
        Me.ЧтоСписываетсяBindingSource.DataMember = "СписаниеТМЦЧтоСписывается"
        Me.ЧтоСписываетсяBindingSource.DataSource = Me.СписаниеТМЦBindingSource
        '
        'ЧтоСписываетсяDataGridView
        '
        Me.ЧтоСписываетсяDataGridView.AutoGenerateColumns = False
        Me.ЧтоСписываетсяDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ЧтоСписываетсяDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ЧтоСписываетсяDataGridView.DataSource = Me.ЧтоСписываетсяBindingSource
        Me.ЧтоСписываетсяDataGridView.Location = New System.Drawing.Point(15, 84)
        Me.ЧтоСписываетсяDataGridView.Name = "ЧтоСписываетсяDataGridView"
        Me.ЧтоСписываетсяDataGridView.Size = New System.Drawing.Size(352, 220)
        Me.ЧтоСписываетсяDataGridView.TabIndex = 5
        '
        'ТМЦBindingSource
        '
        Me.ТМЦBindingSource.DataMember = "ТМЦ"
        Me.ТМЦBindingSource.DataSource = Me.DbDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Накладна"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "№ Документа"
        Me.DataGridViewTextBoxColumn1.HeaderText = "№Документа"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ИнвентарныйНомер"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.ТМЦBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "ИнвентарныйНомер"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Інвентарний номер"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "ИнвентарныйНомер"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ЦенаДоСписания"
        Me.DataGridViewTextBoxColumn3.HeaderText = ""
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'frmSpisanya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 343)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ЧтоСписываетсяDataGridView)
        Me.Controls.Add(_ДокументаLabel)
        Me.Controls.Add(Me._ДокументаTextBox)
        Me.Controls.Add(ДатаLabel)
        Me.Controls.Add(Me.ДатаDateTimePicker)
        Me.Controls.Add(Me.СписаниеТМЦBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSpisanya"
        Me.Text = "Списання"
        Me.TopMost = True
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СписаниеТМЦBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СписаниеТМЦBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.СписаниеТМЦBindingNavigator.ResumeLayout(False)
        Me.СписаниеТМЦBindingNavigator.PerformLayout()
        CType(Me.ЧтоСписываетсяBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЧтоСписываетсяDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ТМЦBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbDataSet As dbDataSet
    Friend WithEvents СписаниеТМЦBindingSource As BindingSource
    Friend WithEvents СписаниеТМЦTableAdapter As dbDataSetTableAdapters.СписаниеТМЦTableAdapter
    Friend WithEvents TableAdapterManager As dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents СписаниеТМЦBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents СписаниеТМЦBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents _ДокументаTextBox As TextBox
    Friend WithEvents ДатаDateTimePicker As DateTimePicker
    Friend WithEvents ЧтоСписываетсяTableAdapter As dbDataSetTableAdapters.ЧтоСписываетсяTableAdapter
    Friend WithEvents ЧтоСписываетсяBindingSource As BindingSource
    Friend WithEvents ТМЦTableAdapter As dbDataSetTableAdapters.ТМЦTableAdapter
    Friend WithEvents ЧтоСписываетсяDataGridView As DataGridView
    Friend WithEvents ТМЦBindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
