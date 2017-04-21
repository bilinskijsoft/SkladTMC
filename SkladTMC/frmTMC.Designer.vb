<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTMC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTMC))
        Dim ИнвентарныйНомерLabel As System.Windows.Forms.Label
        Dim НаименованиеLabel As System.Windows.Forms.Label
        Dim КатегорияLabel As System.Windows.Forms.Label
        Dim ЗаводскойНомерLabel As System.Windows.Forms.Label
        Dim НомерПаспортаLabel As System.Windows.Forms.Label
        Dim Кол_воLabel As System.Windows.Forms.Label
        Dim ТекущаяЦенаLabel As System.Windows.Forms.Label
        Dim ЕденицаУчетаLabel As System.Windows.Forms.Label
        Me.DbDataSet = New Sklad_TMC.dbDataSet()
        Me.ТМЦBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ТМЦTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ТМЦTableAdapter()
        Me.TableAdapterManager = New Sklad_TMC.dbDataSetTableAdapters.TableAdapterManager()
        Me.ТМЦBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ТМЦBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ИнвентарныйНомерTextBox = New System.Windows.Forms.TextBox()
        Me.НаименованиеTextBox = New System.Windows.Forms.TextBox()
        Me.КатегорияTextBox = New System.Windows.Forms.TextBox()
        Me.ЗаводскойНомерTextBox = New System.Windows.Forms.TextBox()
        Me.НомерПаспортаTextBox = New System.Windows.Forms.TextBox()
        Me.Кол_воTextBox = New System.Windows.Forms.TextBox()
        Me.ТекущаяЦенаTextBox = New System.Windows.Forms.TextBox()
        Me.ЕденицаУчетаTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ЧтоПиришлоBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЧтоПиришлоTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ЧтоПиришлоTableAdapter()
        Me.ЧтоПиришлоDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ЧтоПеремещаетсяBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЧтоПеремещаетсяTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ЧтоПеремещаетсяTableAdapter()
        Me.ЧтоПеремещаетсяDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ЧтоПереоцениваетсяBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЧтоПереоцениваетсяTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ЧтоПереоцениваетсяTableAdapter()
        Me.ЧтоПереоцениваетсяDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ЧтоСписываетсяBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЧтоСписываетсяTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ЧтоСписываетсяTableAdapter()
        Me.ЧтоСписываетсяDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ИнвентарныйНомерLabel = New System.Windows.Forms.Label()
        НаименованиеLabel = New System.Windows.Forms.Label()
        КатегорияLabel = New System.Windows.Forms.Label()
        ЗаводскойНомерLabel = New System.Windows.Forms.Label()
        НомерПаспортаLabel = New System.Windows.Forms.Label()
        Кол_воLabel = New System.Windows.Forms.Label()
        ТекущаяЦенаLabel = New System.Windows.Forms.Label()
        ЕденицаУчетаLabel = New System.Windows.Forms.Label()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ТМЦBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ТМЦBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ТМЦBindingNavigator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.ЧтоПиришлоBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЧтоПиришлоDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЧтоПеремещаетсяBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЧтоПеремещаетсяDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЧтоПереоцениваетсяBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЧтоПереоцениваетсяDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЧтоСписываетсяBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЧтоСписываетсяDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ТМЦBindingSource
        '
        Me.ТМЦBindingSource.DataMember = "ТМЦ"
        Me.ТМЦBindingSource.DataSource = Me.DbDataSet
        '
        'ТМЦTableAdapter
        '
        Me.ТМЦTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.СписаниеТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ТМЦTableAdapter = Me.ТМЦTableAdapter
        Me.TableAdapterManager.ЧтоПеремещаетсяTableAdapter = Me.ЧтоПеремещаетсяTableAdapter
        Me.TableAdapterManager.ЧтоПереоцениваетсяTableAdapter = Me.ЧтоПереоцениваетсяTableAdapter
        Me.TableAdapterManager.ЧтоПиришлоTableAdapter = Me.ЧтоПиришлоTableAdapter
        Me.TableAdapterManager.ЧтоСписываетсяTableAdapter = Me.ЧтоСписываетсяTableAdapter
        '
        'ТМЦBindingNavigator
        '
        Me.ТМЦBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ТМЦBindingNavigator.BindingSource = Me.ТМЦBindingSource
        Me.ТМЦBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ТМЦBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ТМЦBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ТМЦBindingNavigatorSaveItem})
        Me.ТМЦBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ТМЦBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ТМЦBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ТМЦBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ТМЦBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ТМЦBindingNavigator.Name = "ТМЦBindingNavigator"
        Me.ТМЦBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ТМЦBindingNavigator.Size = New System.Drawing.Size(634, 25)
        Me.ТМЦBindingNavigator.TabIndex = 0
        Me.ТМЦBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 15)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'ТМЦBindingNavigatorSaveItem
        '
        Me.ТМЦBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ТМЦBindingNavigatorSaveItem.Image = CType(resources.GetObject("ТМЦBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ТМЦBindingNavigatorSaveItem.Name = "ТМЦBindingNavigatorSaveItem"
        Me.ТМЦBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ТМЦBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ИнвентарныйНомерLabel
        '
        ИнвентарныйНомерLabel.AutoSize = True
        ИнвентарныйНомерLabel.Location = New System.Drawing.Point(12, 37)
        ИнвентарныйНомерLabel.Name = "ИнвентарныйНомерLabel"
        ИнвентарныйНомерLabel.Size = New System.Drawing.Size(116, 13)
        ИнвентарныйНомерLabel.TabIndex = 1
        ИнвентарныйНомерLabel.Text = "Инвентарный Номер:"
        '
        'ИнвентарныйНомерTextBox
        '
        Me.ИнвентарныйНомерTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТМЦBindingSource, "ИнвентарныйНомер", True))
        Me.ИнвентарныйНомерTextBox.Location = New System.Drawing.Point(134, 34)
        Me.ИнвентарныйНомерTextBox.Name = "ИнвентарныйНомерTextBox"
        Me.ИнвентарныйНомерTextBox.Size = New System.Drawing.Size(480, 20)
        Me.ИнвентарныйНомерTextBox.TabIndex = 2
        '
        'НаименованиеLabel
        '
        НаименованиеLabel.AutoSize = True
        НаименованиеLabel.Location = New System.Drawing.Point(12, 63)
        НаименованиеLabel.Name = "НаименованиеLabel"
        НаименованиеLabel.Size = New System.Drawing.Size(86, 13)
        НаименованиеLabel.TabIndex = 3
        НаименованиеLabel.Text = "Наименование:"
        '
        'НаименованиеTextBox
        '
        Me.НаименованиеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТМЦBindingSource, "Наименование", True))
        Me.НаименованиеTextBox.Location = New System.Drawing.Point(134, 60)
        Me.НаименованиеTextBox.Name = "НаименованиеTextBox"
        Me.НаименованиеTextBox.Size = New System.Drawing.Size(480, 20)
        Me.НаименованиеTextBox.TabIndex = 4
        '
        'КатегорияLabel
        '
        КатегорияLabel.AutoSize = True
        КатегорияLabel.Location = New System.Drawing.Point(12, 89)
        КатегорияLabel.Name = "КатегорияLabel"
        КатегорияLabel.Size = New System.Drawing.Size(63, 13)
        КатегорияLabel.TabIndex = 5
        КатегорияLabel.Text = "Категория:"
        '
        'КатегорияTextBox
        '
        Me.КатегорияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТМЦBindingSource, "Категория", True))
        Me.КатегорияTextBox.Location = New System.Drawing.Point(134, 86)
        Me.КатегорияTextBox.Name = "КатегорияTextBox"
        Me.КатегорияTextBox.Size = New System.Drawing.Size(480, 20)
        Me.КатегорияTextBox.TabIndex = 6
        '
        'ЗаводскойНомерLabel
        '
        ЗаводскойНомерLabel.AutoSize = True
        ЗаводскойНомерLabel.Location = New System.Drawing.Point(12, 115)
        ЗаводскойНомерLabel.Name = "ЗаводскойНомерLabel"
        ЗаводскойНомерLabel.Size = New System.Drawing.Size(102, 13)
        ЗаводскойНомерLabel.TabIndex = 7
        ЗаводскойНомерLabel.Text = "Заводской Номер:"
        '
        'ЗаводскойНомерTextBox
        '
        Me.ЗаводскойНомерTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТМЦBindingSource, "ЗаводскойНомер", True))
        Me.ЗаводскойНомерTextBox.Location = New System.Drawing.Point(134, 112)
        Me.ЗаводскойНомерTextBox.Name = "ЗаводскойНомерTextBox"
        Me.ЗаводскойНомерTextBox.Size = New System.Drawing.Size(480, 20)
        Me.ЗаводскойНомерTextBox.TabIndex = 8
        '
        'НомерПаспортаLabel
        '
        НомерПаспортаLabel.AutoSize = True
        НомерПаспортаLabel.Location = New System.Drawing.Point(12, 141)
        НомерПаспортаLabel.Name = "НомерПаспортаLabel"
        НомерПаспортаLabel.Size = New System.Drawing.Size(96, 13)
        НомерПаспортаLabel.TabIndex = 9
        НомерПаспортаLabel.Text = "Номер Паспорта:"
        '
        'НомерПаспортаTextBox
        '
        Me.НомерПаспортаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТМЦBindingSource, "НомерПаспорта", True))
        Me.НомерПаспортаTextBox.Location = New System.Drawing.Point(134, 138)
        Me.НомерПаспортаTextBox.Name = "НомерПаспортаTextBox"
        Me.НомерПаспортаTextBox.Size = New System.Drawing.Size(480, 20)
        Me.НомерПаспортаTextBox.TabIndex = 10
        '
        'Кол_воLabel
        '
        Кол_воLabel.AutoSize = True
        Кол_воLabel.Location = New System.Drawing.Point(12, 167)
        Кол_воLabel.Name = "Кол_воLabel"
        Кол_воLabel.Size = New System.Drawing.Size(44, 13)
        Кол_воLabel.TabIndex = 11
        Кол_воLabel.Text = "Кол-во:"
        '
        'Кол_воTextBox
        '
        Me.Кол_воTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТМЦBindingSource, "Кол-во", True))
        Me.Кол_воTextBox.Location = New System.Drawing.Point(134, 164)
        Me.Кол_воTextBox.Name = "Кол_воTextBox"
        Me.Кол_воTextBox.Size = New System.Drawing.Size(480, 20)
        Me.Кол_воTextBox.TabIndex = 12
        '
        'ТекущаяЦенаLabel
        '
        ТекущаяЦенаLabel.AutoSize = True
        ТекущаяЦенаLabel.Location = New System.Drawing.Point(12, 193)
        ТекущаяЦенаLabel.Name = "ТекущаяЦенаLabel"
        ТекущаяЦенаLabel.Size = New System.Drawing.Size(84, 13)
        ТекущаяЦенаLabel.TabIndex = 13
        ТекущаяЦенаLabel.Text = "Текущая Цена:"
        '
        'ТекущаяЦенаTextBox
        '
        Me.ТекущаяЦенаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТМЦBindingSource, "ТекущаяЦена", True))
        Me.ТекущаяЦенаTextBox.Location = New System.Drawing.Point(134, 190)
        Me.ТекущаяЦенаTextBox.Name = "ТекущаяЦенаTextBox"
        Me.ТекущаяЦенаTextBox.Size = New System.Drawing.Size(480, 20)
        Me.ТекущаяЦенаTextBox.TabIndex = 14
        '
        'ЕденицаУчетаLabel
        '
        ЕденицаУчетаLabel.AutoSize = True
        ЕденицаУчетаLabel.Location = New System.Drawing.Point(12, 219)
        ЕденицаУчетаLabel.Name = "ЕденицаУчетаLabel"
        ЕденицаУчетаLabel.Size = New System.Drawing.Size(86, 13)
        ЕденицаУчетаLabel.TabIndex = 15
        ЕденицаУчетаLabel.Text = "Еденица Учета:"
        '
        'ЕденицаУчетаTextBox
        '
        Me.ЕденицаУчетаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТМЦBindingSource, "ЕденицаУчета", True))
        Me.ЕденицаУчетаTextBox.Location = New System.Drawing.Point(134, 216)
        Me.ЕденицаУчетаTextBox.Name = "ЕденицаУчетаTextBox"
        Me.ЕденицаУчетаTextBox.Size = New System.Drawing.Size(480, 20)
        Me.ЕденицаУчетаTextBox.TabIndex = 16
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(15, 248)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(606, 211)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.ЧтоПиришлоDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(598, 185)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Приход"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.ЧтоПеремещаетсяDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(598, 185)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Переміщення"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.ЧтоПереоцениваетсяDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(598, 185)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Переоцінка"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.ЧтоСписываетсяDataGridView)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(598, 185)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Списання"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ЧтоПиришлоBindingSource
        '
        Me.ЧтоПиришлоBindingSource.DataMember = "ТМЦЧтоПиришло"
        Me.ЧтоПиришлоBindingSource.DataSource = Me.ТМЦBindingSource
        '
        'ЧтоПиришлоTableAdapter
        '
        Me.ЧтоПиришлоTableAdapter.ClearBeforeFill = True
        '
        'ЧтоПиришлоDataGridView
        '
        Me.ЧтоПиришлоDataGridView.AutoGenerateColumns = False
        Me.ЧтоПиришлоDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ЧтоПиришлоDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ЧтоПиришлоDataGridView.DataSource = Me.ЧтоПиришлоBindingSource
        Me.ЧтоПиришлоDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ЧтоПиришлоDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ЧтоПиришлоDataGridView.Name = "ЧтоПиришлоDataGridView"
        Me.ЧтоПиришлоDataGridView.Size = New System.Drawing.Size(592, 179)
        Me.ЧтоПиришлоDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "№Документа"
        Me.DataGridViewTextBoxColumn1.HeaderText = "№Документа"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ИнвентарныйНомер"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ИнвентарныйНомер"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Цена"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Цена"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'ЧтоПеремещаетсяBindingSource
        '
        Me.ЧтоПеремещаетсяBindingSource.DataMember = "ТМЦЧтоПеремещается"
        Me.ЧтоПеремещаетсяBindingSource.DataSource = Me.ТМЦBindingSource
        '
        'ЧтоПеремещаетсяTableAdapter
        '
        Me.ЧтоПеремещаетсяTableAdapter.ClearBeforeFill = True
        '
        'ЧтоПеремещаетсяDataGridView
        '
        Me.ЧтоПеремещаетсяDataGridView.AutoGenerateColumns = False
        Me.ЧтоПеремещаетсяDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ЧтоПеремещаетсяDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ЧтоПеремещаетсяDataGridView.DataSource = Me.ЧтоПеремещаетсяBindingSource
        Me.ЧтоПеремещаетсяDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ЧтоПеремещаетсяDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ЧтоПеремещаетсяDataGridView.Name = "ЧтоПеремещаетсяDataGridView"
        Me.ЧтоПеремещаетсяDataGridView.Size = New System.Drawing.Size(592, 179)
        Me.ЧтоПеремещаетсяDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "№Документа"
        Me.DataGridViewTextBoxColumn4.HeaderText = "№Документа"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ИнвентарныйНомер"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ИнвентарныйНомер"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ЦенаПеремещения"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ЦенаПеремещения"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'ЧтоПереоцениваетсяBindingSource
        '
        Me.ЧтоПереоцениваетсяBindingSource.DataMember = "ТМЦЧтоПереоценивается"
        Me.ЧтоПереоцениваетсяBindingSource.DataSource = Me.ТМЦBindingSource
        '
        'ЧтоПереоцениваетсяTableAdapter
        '
        Me.ЧтоПереоцениваетсяTableAdapter.ClearBeforeFill = True
        '
        'ЧтоПереоцениваетсяDataGridView
        '
        Me.ЧтоПереоцениваетсяDataGridView.AutoGenerateColumns = False
        Me.ЧтоПереоцениваетсяDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ЧтоПереоцениваетсяDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.ЧтоПереоцениваетсяDataGridView.DataSource = Me.ЧтоПереоцениваетсяBindingSource
        Me.ЧтоПереоцениваетсяDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.ЧтоПереоцениваетсяDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ЧтоПереоцениваетсяDataGridView.Name = "ЧтоПереоцениваетсяDataGridView"
        Me.ЧтоПереоцениваетсяDataGridView.Size = New System.Drawing.Size(575, 220)
        Me.ЧтоПереоцениваетсяDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "№Документа"
        Me.DataGridViewTextBoxColumn7.HeaderText = "№Документа"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ИнвентарныйНомер"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ИнвентарныйНомер"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "СтараяЦена"
        Me.DataGridViewTextBoxColumn9.HeaderText = "СтараяЦена"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "НоваяЦена"
        Me.DataGridViewTextBoxColumn10.HeaderText = "НоваяЦена"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'ЧтоСписываетсяBindingSource
        '
        Me.ЧтоСписываетсяBindingSource.DataMember = "ТМЦЧтоСписывается"
        Me.ЧтоСписываетсяBindingSource.DataSource = Me.ТМЦBindingSource
        '
        'ЧтоСписываетсяTableAdapter
        '
        Me.ЧтоСписываетсяTableAdapter.ClearBeforeFill = True
        '
        'ЧтоСписываетсяDataGridView
        '
        Me.ЧтоСписываетсяDataGridView.AutoGenerateColumns = False
        Me.ЧтоСписываетсяDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ЧтоСписываетсяDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.ЧтоСписываетсяDataGridView.DataSource = Me.ЧтоСписываетсяBindingSource
        Me.ЧтоСписываетсяDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ЧтоСписываетсяDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ЧтоСписываетсяDataGridView.Name = "ЧтоСписываетсяDataGridView"
        Me.ЧтоСписываетсяDataGridView.Size = New System.Drawing.Size(592, 179)
        Me.ЧтоСписываетсяDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "№Документа"
        Me.DataGridViewTextBoxColumn11.HeaderText = "№Документа"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ИнвентарныйНомер"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ИнвентарныйНомер"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ЦенаДоСписания"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ЦенаДоСписания"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'frmTMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 471)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(ИнвентарныйНомерLabel)
        Me.Controls.Add(Me.ИнвентарныйНомерTextBox)
        Me.Controls.Add(НаименованиеLabel)
        Me.Controls.Add(Me.НаименованиеTextBox)
        Me.Controls.Add(КатегорияLabel)
        Me.Controls.Add(Me.КатегорияTextBox)
        Me.Controls.Add(ЗаводскойНомерLabel)
        Me.Controls.Add(Me.ЗаводскойНомерTextBox)
        Me.Controls.Add(НомерПаспортаLabel)
        Me.Controls.Add(Me.НомерПаспортаTextBox)
        Me.Controls.Add(Кол_воLabel)
        Me.Controls.Add(Me.Кол_воTextBox)
        Me.Controls.Add(ТекущаяЦенаLabel)
        Me.Controls.Add(Me.ТекущаяЦенаTextBox)
        Me.Controls.Add(ЕденицаУчетаLabel)
        Me.Controls.Add(Me.ЕденицаУчетаTextBox)
        Me.Controls.Add(Me.ТМЦBindingNavigator)
        Me.Name = "frmTMC"
        Me.Text = "frmTMC"
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ТМЦBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ТМЦBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ТМЦBindingNavigator.ResumeLayout(False)
        Me.ТМЦBindingNavigator.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.ЧтоПиришлоBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЧтоПиришлоDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЧтоПеремещаетсяBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЧтоПеремещаетсяDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЧтоПереоцениваетсяBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЧтоПереоцениваетсяDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЧтоСписываетсяBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЧтоСписываетсяDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbDataSet As dbDataSet
    Friend WithEvents ТМЦBindingSource As BindingSource
    Friend WithEvents ТМЦTableAdapter As dbDataSetTableAdapters.ТМЦTableAdapter
    Friend WithEvents TableAdapterManager As dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ТМЦBindingNavigator As BindingNavigator
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
    Friend WithEvents ТМЦBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ИнвентарныйНомерTextBox As TextBox
    Friend WithEvents НаименованиеTextBox As TextBox
    Friend WithEvents КатегорияTextBox As TextBox
    Friend WithEvents ЗаводскойНомерTextBox As TextBox
    Friend WithEvents НомерПаспортаTextBox As TextBox
    Friend WithEvents Кол_воTextBox As TextBox
    Friend WithEvents ТекущаяЦенаTextBox As TextBox
    Friend WithEvents ЕденицаУчетаTextBox As TextBox
    Friend WithEvents ЧтоПиришлоTableAdapter As dbDataSetTableAdapters.ЧтоПиришлоTableAdapter
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ЧтоПиришлоBindingSource As BindingSource
    Friend WithEvents ЧтоПеремещаетсяTableAdapter As dbDataSetTableAdapters.ЧтоПеремещаетсяTableAdapter
    Friend WithEvents ЧтоПиришлоDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ЧтоПеремещаетсяBindingSource As BindingSource
    Friend WithEvents ЧтоПереоцениваетсяTableAdapter As dbDataSetTableAdapters.ЧтоПереоцениваетсяTableAdapter
    Friend WithEvents ЧтоПеремещаетсяDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ЧтоПереоцениваетсяBindingSource As BindingSource
    Friend WithEvents ЧтоСписываетсяTableAdapter As dbDataSetTableAdapters.ЧтоСписываетсяTableAdapter
    Friend WithEvents ЧтоПереоцениваетсяDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents ЧтоСписываетсяBindingSource As BindingSource
    Friend WithEvents ЧтоСписываетсяDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
End Class
