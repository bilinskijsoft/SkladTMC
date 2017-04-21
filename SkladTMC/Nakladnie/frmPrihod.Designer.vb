<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrihod
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
        Dim ПоставщикLabel As System.Windows.Forms.Label
        Dim ПодразделениеLabel As System.Windows.Forms.Label
        Dim МОЛLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrihod))
        Me.DbDataSet = New Sklad_TMC.dbDataSet()
        Me.ПриходТМЦBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПриходТМЦTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ПриходТМЦTableAdapter()
        Me.TableAdapterManager = New Sklad_TMC.dbDataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ПриходТМЦBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ПриходТМЦBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me._ДокументаTextBox = New System.Windows.Forms.TextBox()
        Me.ДатаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ПоставщикTextBox = New System.Windows.Forms.TextBox()
        Me.ПодразделениеTextBox = New System.Windows.Forms.TextBox()
        Me.МОЛTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.МОЛBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.МОЛTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.МОЛTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ПодразделенияBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПодразделенияTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ПодразделенияTableAdapter()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ПоставщикиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПоставщикиTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ПоставщикиTableAdapter()
        Me.ЧтоПиришлоBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЧтоПиришлоTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ЧтоПиришлоTableAdapter()
        Me.ЧтоПиришлоDataGridView = New System.Windows.Forms.DataGridView()
        Me.ДокументаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ИнвентарныйНомерDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ЦенаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        _ДокументаLabel = New System.Windows.Forms.Label()
        ДатаLabel = New System.Windows.Forms.Label()
        ПоставщикLabel = New System.Windows.Forms.Label()
        ПодразделениеLabel = New System.Windows.Forms.Label()
        МОЛLabel = New System.Windows.Forms.Label()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПриходТМЦBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПриходТМЦBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ПриходТМЦBindingNavigator.SuspendLayout()
        CType(Me.МОЛBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПодразделенияBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПоставщикиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЧтоПиришлоBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЧтоПиришлоDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_ДокументаLabel
        '
        _ДокументаLabel.AutoSize = True
        _ДокументаLabel.Location = New System.Drawing.Point(12, 40)
        _ДокументаLabel.Name = "_ДокументаLabel"
        _ДокументаLabel.Size = New System.Drawing.Size(78, 13)
        _ДокументаLabel.TabIndex = 1
        _ДокументаLabel.Text = "№Документа:"
        '
        'ДатаLabel
        '
        ДатаLabel.AutoSize = True
        ДатаLabel.Location = New System.Drawing.Point(12, 67)
        ДатаLabel.Name = "ДатаLabel"
        ДатаLabel.Size = New System.Drawing.Size(36, 13)
        ДатаLabel.TabIndex = 3
        ДатаLabel.Text = "Дата:"
        '
        'ПоставщикLabel
        '
        ПоставщикLabel.AutoSize = True
        ПоставщикLabel.Location = New System.Drawing.Point(12, 92)
        ПоставщикLabel.Name = "ПоставщикLabel"
        ПоставщикLabel.Size = New System.Drawing.Size(68, 13)
        ПоставщикLabel.TabIndex = 5
        ПоставщикLabel.Text = "Поставщик:"
        '
        'ПодразделениеLabel
        '
        ПодразделениеLabel.AutoSize = True
        ПодразделениеLabel.Location = New System.Drawing.Point(12, 119)
        ПодразделениеLabel.Name = "ПодразделениеLabel"
        ПодразделениеLabel.Size = New System.Drawing.Size(90, 13)
        ПодразделениеLabel.TabIndex = 7
        ПодразделениеLabel.Text = "Подразделение:"
        '
        'МОЛLabel
        '
        МОЛLabel.AutoSize = True
        МОЛLabel.Location = New System.Drawing.Point(13, 145)
        МОЛLabel.Name = "МОЛLabel"
        МОЛLabel.Size = New System.Drawing.Size(35, 13)
        МОЛLabel.TabIndex = 9
        МОЛLabel.Text = "МОЛ:"
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПриходТМЦBindingSource
        '
        Me.ПриходТМЦBindingSource.DataMember = "ПриходТМЦ"
        Me.ПриходТМЦBindingSource.DataSource = Me.DbDataSet
        '
        'ПриходТМЦTableAdapter
        '
        Me.ПриходТМЦTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ПриходТМЦTableAdapter = Me.ПриходТМЦTableAdapter
        Me.TableAdapterManager.СписаниеТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПеремещаетсяTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПереоцениваетсяTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПиришлоTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоСписываетсяTableAdapter = Nothing
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
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
        'ПриходТМЦBindingNavigatorSaveItem
        '
        Me.ПриходТМЦBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ПриходТМЦBindingNavigatorSaveItem.Image = CType(resources.GetObject("ПриходТМЦBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ПриходТМЦBindingNavigatorSaveItem.Name = "ПриходТМЦBindingNavigatorSaveItem"
        Me.ПриходТМЦBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ПриходТМЦBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ПриходТМЦBindingNavigator
        '
        Me.ПриходТМЦBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ПриходТМЦBindingNavigator.BindingSource = Me.ПриходТМЦBindingSource
        Me.ПриходТМЦBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ПриходТМЦBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ПриходТМЦBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ПриходТМЦBindingNavigatorSaveItem})
        Me.ПриходТМЦBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ПриходТМЦBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ПриходТМЦBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ПриходТМЦBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ПриходТМЦBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ПриходТМЦBindingNavigator.Name = "ПриходТМЦBindingNavigator"
        Me.ПриходТМЦBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ПриходТМЦBindingNavigator.Size = New System.Drawing.Size(368, 25)
        Me.ПриходТМЦBindingNavigator.TabIndex = 0
        Me.ПриходТМЦBindingNavigator.Text = "BindingNavigator1"
        '
        '_ДокументаTextBox
        '
        Me._ДокументаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПриходТМЦBindingSource, "№Документа", True))
        Me._ДокументаTextBox.Enabled = False
        Me._ДокументаTextBox.Location = New System.Drawing.Point(108, 37)
        Me._ДокументаTextBox.Name = "_ДокументаTextBox"
        Me._ДокументаTextBox.Size = New System.Drawing.Size(246, 20)
        Me._ДокументаTextBox.TabIndex = 2
        '
        'ДатаDateTimePicker
        '
        Me.ДатаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ПриходТМЦBindingSource, "Дата", True))
        Me.ДатаDateTimePicker.Location = New System.Drawing.Point(108, 63)
        Me.ДатаDateTimePicker.Name = "ДатаDateTimePicker"
        Me.ДатаDateTimePicker.Size = New System.Drawing.Size(246, 20)
        Me.ДатаDateTimePicker.TabIndex = 4
        '
        'ПоставщикTextBox
        '
        Me.ПоставщикTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПриходТМЦBindingSource, "Поставщик", True))
        Me.ПоставщикTextBox.Location = New System.Drawing.Point(437, 85)
        Me.ПоставщикTextBox.Name = "ПоставщикTextBox"
        Me.ПоставщикTextBox.Size = New System.Drawing.Size(28, 20)
        Me.ПоставщикTextBox.TabIndex = 6
        '
        'ПодразделениеTextBox
        '
        Me.ПодразделениеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПриходТМЦBindingSource, "Подразделение", True))
        Me.ПодразделениеTextBox.Location = New System.Drawing.Point(437, 111)
        Me.ПодразделениеTextBox.Name = "ПодразделениеTextBox"
        Me.ПодразделениеTextBox.Size = New System.Drawing.Size(28, 20)
        Me.ПодразделениеTextBox.TabIndex = 8
        '
        'МОЛTextBox
        '
        Me.МОЛTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПриходТМЦBindingSource, "МОЛ", True))
        Me.МОЛTextBox.Location = New System.Drawing.Point(437, 137)
        Me.МОЛTextBox.Name = "МОЛTextBox"
        Me.МОЛTextBox.Size = New System.Drawing.Size(28, 20)
        Me.МОЛTextBox.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ПриходТМЦBindingSource, "МОЛ", True))
        Me.ComboBox1.DataSource = Me.МОЛBindingSource
        Me.ComboBox1.DisplayMember = "ФИОМОЛ"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(107, 142)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(247, 21)
        Me.ComboBox1.TabIndex = 11
        Me.ComboBox1.ValueMember = "КодМОЛ"
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
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ПриходТМЦBindingSource, "Подразделение", True))
        Me.ComboBox2.DataSource = Me.ПодразделенияBindingSource
        Me.ComboBox2.DisplayMember = "Нимаенование"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(108, 116)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(246, 21)
        Me.ComboBox2.TabIndex = 12
        Me.ComboBox2.ValueMember = "КодПодразделения"
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
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ПриходТМЦBindingSource, "Поставщик", True))
        Me.ComboBox3.DataSource = Me.ПоставщикиBindingSource
        Me.ComboBox3.DisplayMember = "Наименование"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(108, 89)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(246, 21)
        Me.ComboBox3.TabIndex = 13
        Me.ComboBox3.ValueMember = "КодПоставщика"
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
        'ЧтоПиришлоBindingSource
        '
        Me.ЧтоПиришлоBindingSource.DataMember = "ПриходТМЦ_ЧтоПиришло"
        Me.ЧтоПиришлоBindingSource.DataSource = Me.ПриходТМЦBindingSource
        '
        'ЧтоПиришлоTableAdapter
        '
        Me.ЧтоПиришлоTableAdapter.ClearBeforeFill = True
        '
        'ЧтоПиришлоDataGridView
        '
        Me.ЧтоПиришлоDataGridView.AutoGenerateColumns = False
        Me.ЧтоПиришлоDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ЧтоПиришлоDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ДокументаDataGridViewTextBoxColumn, Me.ИнвентарныйНомерDataGridViewTextBoxColumn, Me.ЦенаDataGridViewTextBoxColumn})
        Me.ЧтоПиришлоDataGridView.DataSource = Me.ЧтоПиришлоBindingSource
        Me.ЧтоПиришлоDataGridView.Location = New System.Drawing.Point(12, 169)
        Me.ЧтоПиришлоDataGridView.MultiSelect = False
        Me.ЧтоПиришлоDataGridView.Name = "ЧтоПиришлоDataGridView"
        Me.ЧтоПиришлоDataGridView.Size = New System.Drawing.Size(342, 220)
        Me.ЧтоПиришлоDataGridView.TabIndex = 14
        '
        'ДокументаDataGridViewTextBoxColumn
        '
        Me.ДокументаDataGridViewTextBoxColumn.DataPropertyName = "№Документа"
        Me.ДокументаDataGridViewTextBoxColumn.HeaderText = "№Документа"
        Me.ДокументаDataGridViewTextBoxColumn.Name = "ДокументаDataGridViewTextBoxColumn"
        Me.ДокументаDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ИнвентарныйНомерDataGridViewTextBoxColumn
        '
        Me.ИнвентарныйНомерDataGridViewTextBoxColumn.DataPropertyName = "ИнвентарныйНомер"
        Me.ИнвентарныйНомерDataGridViewTextBoxColumn.HeaderText = "ИнвентарныйНомер"
        Me.ИнвентарныйНомерDataGridViewTextBoxColumn.Name = "ИнвентарныйНомерDataGridViewTextBoxColumn"
        '
        'ЦенаDataGridViewTextBoxColumn
        '
        Me.ЦенаDataGridViewTextBoxColumn.DataPropertyName = "Цена"
        Me.ЦенаDataGridViewTextBoxColumn.HeaderText = "Цена"
        Me.ЦенаDataGridViewTextBoxColumn.Name = "ЦенаDataGridViewTextBoxColumn"
        '
        'frmPrihod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 397)
        Me.Controls.Add(Me.ЧтоПиришлоDataGridView)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(_ДокументаLabel)
        Me.Controls.Add(Me._ДокументаTextBox)
        Me.Controls.Add(ДатаLabel)
        Me.Controls.Add(Me.ДатаDateTimePicker)
        Me.Controls.Add(ПоставщикLabel)
        Me.Controls.Add(Me.ПоставщикTextBox)
        Me.Controls.Add(ПодразделениеLabel)
        Me.Controls.Add(Me.ПодразделениеTextBox)
        Me.Controls.Add(МОЛLabel)
        Me.Controls.Add(Me.МОЛTextBox)
        Me.Controls.Add(Me.ПриходТМЦBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrihod"
        Me.Text = "frmPrihod"
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПриходТМЦBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПриходТМЦBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ПриходТМЦBindingNavigator.ResumeLayout(False)
        Me.ПриходТМЦBindingNavigator.PerformLayout()
        CType(Me.МОЛBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПодразделенияBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПоставщикиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЧтоПиришлоBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЧтоПиришлоDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbDataSet As dbDataSet
    Friend WithEvents ПриходТМЦBindingSource As BindingSource
    Friend WithEvents ПриходТМЦTableAdapter As dbDataSetTableAdapters.ПриходТМЦTableAdapter
    Friend WithEvents TableAdapterManager As dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents ПриходТМЦBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ПриходТМЦBindingNavigator As BindingNavigator
    Friend WithEvents _ДокументаTextBox As TextBox
    Friend WithEvents ДатаDateTimePicker As DateTimePicker
    Friend WithEvents ПоставщикTextBox As TextBox
    Friend WithEvents ПодразделениеTextBox As TextBox
    Friend WithEvents МОЛTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents МОЛBindingSource As BindingSource
    Friend WithEvents МОЛTableAdapter As dbDataSetTableAdapters.МОЛTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ПодразделенияBindingSource As BindingSource
    Friend WithEvents ПодразделенияTableAdapter As dbDataSetTableAdapters.ПодразделенияTableAdapter
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ПоставщикиBindingSource As BindingSource
    Friend WithEvents ПоставщикиTableAdapter As dbDataSetTableAdapters.ПоставщикиTableAdapter
    Friend WithEvents ЧтоПиришлоBindingSource As BindingSource
    Friend WithEvents ЧтоПиришлоTableAdapter As dbDataSetTableAdapters.ЧтоПиришлоTableAdapter
    Friend WithEvents ЧтоПиришлоDataGridView As DataGridView
    Friend WithEvents ДокументаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ИнвентарныйНомерDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ЦенаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
