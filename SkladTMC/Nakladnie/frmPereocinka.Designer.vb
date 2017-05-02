<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPereocinka
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPereocinka))
        Me.DbDataSet = New Sklad_TMC.dbDataSet()
        Me.ПереоценкаТМЦBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПереоценкаТМЦTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ПереоценкаТМЦTableAdapter()
        Me.TableAdapterManager = New Sklad_TMC.dbDataSetTableAdapters.TableAdapterManager()
        Me.ТМЦTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ТМЦTableAdapter()
        Me.ЧтоПереоцениваетсяTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ЧтоПереоцениваетсяTableAdapter()
        Me.ПереоценкаТМЦBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ПереоценкаТМЦBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me._ДокументаTextBox = New System.Windows.Forms.TextBox()
        Me.ДатаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ЧтоПереоцениваетсяBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЧтоПереоцениваетсяDataGridView = New System.Windows.Forms.DataGridView()
        Me.ТМЦBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        _ДокументаLabel = New System.Windows.Forms.Label()
        ДатаLabel = New System.Windows.Forms.Label()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПереоценкаТМЦBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПереоценкаТМЦBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ПереоценкаТМЦBindingNavigator.SuspendLayout()
        CType(Me.ЧтоПереоцениваетсяBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЧтоПереоцениваетсяDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ТМЦBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_ДокументаLabel
        '
        _ДокументаLabel.AutoSize = True
        _ДокументаLabel.Location = New System.Drawing.Point(12, 39)
        _ДокументаLabel.Name = "_ДокументаLabel"
        _ДокументаLabel.Size = New System.Drawing.Size(81, 13)
        _ДокументаLabel.TabIndex = 1
        _ДокументаLabel.Text = "№ Документа:"
        '
        'ДатаLabel
        '
        ДатаLabel.AutoSize = True
        ДатаLabel.Location = New System.Drawing.Point(12, 66)
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
        'ПереоценкаТМЦBindingSource
        '
        Me.ПереоценкаТМЦBindingSource.DataMember = "ПереоценкаТМЦ"
        Me.ПереоценкаТМЦBindingSource.DataSource = Me.DbDataSet
        '
        'ПереоценкаТМЦTableAdapter
        '
        Me.ПереоценкаТМЦTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Sklad_TMC.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ВнутреннееПеремещениеТМЦTableAdapter = Nothing
        Me.TableAdapterManager.МОЛTableAdapter = Nothing
        Me.TableAdapterManager.ПереоценкаТМЦTableAdapter = Me.ПереоценкаТМЦTableAdapter
        Me.TableAdapterManager.ПодразделенияTableAdapter = Nothing
        Me.TableAdapterManager.ПоставщикиTableAdapter = Nothing
        Me.TableAdapterManager.ПриходТМЦTableAdapter = Nothing
        Me.TableAdapterManager.СписаниеТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ТМЦTableAdapter = Me.ТМЦTableAdapter
        Me.TableAdapterManager.ЧтоПеремещаетсяTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПереоцениваетсяTableAdapter = Me.ЧтоПереоцениваетсяTableAdapter
        Me.TableAdapterManager.ЧтоПиришлоTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоСписываетсяTableAdapter = Nothing
        '
        'ТМЦTableAdapter
        '
        Me.ТМЦTableAdapter.ClearBeforeFill = True
        '
        'ЧтоПереоцениваетсяTableAdapter
        '
        Me.ЧтоПереоцениваетсяTableAdapter.ClearBeforeFill = True
        '
        'ПереоценкаТМЦBindingNavigator
        '
        Me.ПереоценкаТМЦBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ПереоценкаТМЦBindingNavigator.BindingSource = Me.ПереоценкаТМЦBindingSource
        Me.ПереоценкаТМЦBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ПереоценкаТМЦBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ПереоценкаТМЦBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ПереоценкаТМЦBindingNavigatorSaveItem})
        Me.ПереоценкаТМЦBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ПереоценкаТМЦBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ПереоценкаТМЦBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ПереоценкаТМЦBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ПереоценкаТМЦBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ПереоценкаТМЦBindingNavigator.Name = "ПереоценкаТМЦBindingNavigator"
        Me.ПереоценкаТМЦBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ПереоценкаТМЦBindingNavigator.Size = New System.Drawing.Size(460, 25)
        Me.ПереоценкаТМЦBindingNavigator.TabIndex = 0
        Me.ПереоценкаТМЦBindingNavigator.Text = "BindingNavigator1"
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
        'ПереоценкаТМЦBindingNavigatorSaveItem
        '
        Me.ПереоценкаТМЦBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ПереоценкаТМЦBindingNavigatorSaveItem.Image = CType(resources.GetObject("ПереоценкаТМЦBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ПереоценкаТМЦBindingNavigatorSaveItem.Name = "ПереоценкаТМЦBindingNavigatorSaveItem"
        Me.ПереоценкаТМЦBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ПереоценкаТМЦBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        '_ДокументаTextBox
        '
        Me._ДокументаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПереоценкаТМЦBindingSource, "№Документа", True))
        Me._ДокументаTextBox.Location = New System.Drawing.Point(96, 36)
        Me._ДокументаTextBox.Name = "_ДокументаTextBox"
        Me._ДокументаTextBox.Size = New System.Drawing.Size(349, 20)
        Me._ДокументаTextBox.TabIndex = 2
        '
        'ДатаDateTimePicker
        '
        Me.ДатаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ПереоценкаТМЦBindingSource, "Дата", True))
        Me.ДатаDateTimePicker.Location = New System.Drawing.Point(96, 62)
        Me.ДатаDateTimePicker.Name = "ДатаDateTimePicker"
        Me.ДатаDateTimePicker.Size = New System.Drawing.Size(349, 20)
        Me.ДатаDateTimePicker.TabIndex = 4
        '
        'ЧтоПереоцениваетсяBindingSource
        '
        Me.ЧтоПереоцениваетсяBindingSource.DataMember = "ЧтоПереоценивается_ПереоценкаТМЦ"
        Me.ЧтоПереоцениваетсяBindingSource.DataSource = Me.ПереоценкаТМЦBindingSource
        '
        'ЧтоПереоцениваетсяDataGridView
        '
        Me.ЧтоПереоцениваетсяDataGridView.AutoGenerateColumns = False
        Me.ЧтоПереоцениваетсяDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ЧтоПереоцениваетсяDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ЧтоПереоцениваетсяDataGridView.DataSource = Me.ЧтоПереоцениваетсяBindingSource
        Me.ЧтоПереоцениваетсяDataGridView.Location = New System.Drawing.Point(15, 88)
        Me.ЧтоПереоцениваетсяDataGridView.Name = "ЧтоПереоцениваетсяDataGridView"
        Me.ЧтоПереоцениваетсяDataGridView.Size = New System.Drawing.Size(430, 220)
        Me.ЧтоПереоцениваетсяDataGridView.TabIndex = 5
        '
        'ТМЦBindingSource
        '
        Me.ТМЦBindingSource.DataMember = "ТМЦ"
        Me.ТМЦBindingSource.DataSource = Me.DbDataSet
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "СтараяЦена"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Стара ціна"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "НоваяЦена"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Нова ціна"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'frmPereocinka
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 318)
        Me.Controls.Add(Me.ЧтоПереоцениваетсяDataGridView)
        Me.Controls.Add(_ДокументаLabel)
        Me.Controls.Add(Me._ДокументаTextBox)
        Me.Controls.Add(ДатаLabel)
        Me.Controls.Add(Me.ДатаDateTimePicker)
        Me.Controls.Add(Me.ПереоценкаТМЦBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPereocinka"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Переоцінка"
        Me.TopMost = True
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПереоценкаТМЦBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПереоценкаТМЦBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ПереоценкаТМЦBindingNavigator.ResumeLayout(False)
        Me.ПереоценкаТМЦBindingNavigator.PerformLayout()
        CType(Me.ЧтоПереоцениваетсяBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЧтоПереоцениваетсяDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ТМЦBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbDataSet As dbDataSet
    Friend WithEvents ПереоценкаТМЦBindingSource As BindingSource
    Friend WithEvents ПереоценкаТМЦTableAdapter As dbDataSetTableAdapters.ПереоценкаТМЦTableAdapter
    Friend WithEvents TableAdapterManager As dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ПереоценкаТМЦBindingNavigator As BindingNavigator
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
    Friend WithEvents ПереоценкаТМЦBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ЧтоПереоцениваетсяTableAdapter As dbDataSetTableAdapters.ЧтоПереоцениваетсяTableAdapter
    Friend WithEvents _ДокументаTextBox As TextBox
    Friend WithEvents ДатаDateTimePicker As DateTimePicker
    Friend WithEvents ЧтоПереоцениваетсяBindingSource As BindingSource
    Friend WithEvents ЧтоПереоцениваетсяDataGridView As DataGridView
    Friend WithEvents ТМЦTableAdapter As dbDataSetTableAdapters.ТМЦTableAdapter
    Friend WithEvents ТМЦBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
