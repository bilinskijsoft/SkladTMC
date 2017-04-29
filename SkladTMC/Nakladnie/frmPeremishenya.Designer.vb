<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeremishenya
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
        Dim ОткудаПодразделениеLabel As System.Windows.Forms.Label
        Dim ОткудаМОЛLabel As System.Windows.Forms.Label
        Dim КудаПодразделениеLabel As System.Windows.Forms.Label
        Dim КудаМОЛLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPeremishenya))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ВнутреннееПеремещениеТМЦBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbDataSet = New Sklad_TMC.dbDataSet()
        Me.ПодразделенияBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.МОЛBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ПодразделенияBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.МОЛBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ВнутреннееПеремещениеТМЦTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ВнутреннееПеремещениеТМЦTableAdapter()
        Me.TableAdapterManager = New Sklad_TMC.dbDataSetTableAdapters.TableAdapterManager()
        Me.ЧтоПеремещаетсяTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ЧтоПеремещаетсяTableAdapter()
        Me.ВнутреннееПеремещениеТМЦBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ВнутреннееПеремещениеТМЦBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me._ДокументаTextBox = New System.Windows.Forms.TextBox()
        Me.ДатаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ОткудаПодразделениеTextBox = New System.Windows.Forms.TextBox()
        Me.ОткудаМОЛTextBox = New System.Windows.Forms.TextBox()
        Me.КудаПодразделениеTextBox = New System.Windows.Forms.TextBox()
        Me.КудаМОЛTextBox = New System.Windows.Forms.TextBox()
        Me.ЧтоПеремещаетсяBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЧтоПеремещаетсяDataGridView = New System.Windows.Forms.DataGridView()
        Me.ПодразделенияTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ПодразделенияTableAdapter()
        Me.МОЛTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.МОЛTableAdapter()
        Me.ПереоценкаТМЦBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПереоценкаТМЦTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ПереоценкаТМЦTableAdapter()
        Me.ТМЦBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ТМЦTableAdapter = New Sklad_TMC.dbDataSetTableAdapters.ТМЦTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        _ДокументаLabel = New System.Windows.Forms.Label()
        ДатаLabel = New System.Windows.Forms.Label()
        ОткудаПодразделениеLabel = New System.Windows.Forms.Label()
        ОткудаМОЛLabel = New System.Windows.Forms.Label()
        КудаПодразделениеLabel = New System.Windows.Forms.Label()
        КудаМОЛLabel = New System.Windows.Forms.Label()
        CType(Me.ВнутреннееПеремещениеТМЦBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПодразделенияBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.МОЛBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПодразделенияBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.МОЛBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ВнутреннееПеремещениеТМЦBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.SuspendLayout()
        CType(Me.ЧтоПеремещаетсяBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЧтоПеремещаетсяDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПереоценкаТМЦBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ТМЦBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_ДокументаLabel
        '
        _ДокументаLabel.AutoSize = True
        _ДокументаLabel.Location = New System.Drawing.Point(12, 35)
        _ДокументаLabel.Name = "_ДокументаLabel"
        _ДокументаLabel.Size = New System.Drawing.Size(78, 13)
        _ДокументаLabel.TabIndex = 17
        _ДокументаLabel.Text = "№Документа:"
        '
        'ДатаLabel
        '
        ДатаLabel.AutoSize = True
        ДатаLabel.Location = New System.Drawing.Point(12, 64)
        ДатаLabel.Name = "ДатаLabel"
        ДатаLabel.Size = New System.Drawing.Size(36, 13)
        ДатаLabel.TabIndex = 19
        ДатаLabel.Text = "Дата:"
        '
        'ОткудаПодразделениеLabel
        '
        ОткудаПодразделениеLabel.AutoSize = True
        ОткудаПодразделениеLabel.Location = New System.Drawing.Point(12, 87)
        ОткудаПодразделениеLabel.Name = "ОткудаПодразделениеLabel"
        ОткудаПодразделениеLabel.Size = New System.Drawing.Size(129, 13)
        ОткудаПодразделениеLabel.TabIndex = 21
        ОткудаПодразделениеLabel.Text = "Откуда Подразделение:"
        '
        'ОткудаМОЛLabel
        '
        ОткудаМОЛLabel.AutoSize = True
        ОткудаМОЛLabel.Location = New System.Drawing.Point(12, 113)
        ОткудаМОЛLabel.Name = "ОткудаМОЛLabel"
        ОткудаМОЛLabel.Size = New System.Drawing.Size(74, 13)
        ОткудаМОЛLabel.TabIndex = 23
        ОткудаМОЛLabel.Text = "Откуда МОЛ:"
        '
        'КудаПодразделениеLabel
        '
        КудаПодразделениеLabel.AutoSize = True
        КудаПодразделениеLabel.Location = New System.Drawing.Point(12, 139)
        КудаПодразделениеLabel.Name = "КудаПодразделениеLabel"
        КудаПодразделениеLabel.Size = New System.Drawing.Size(117, 13)
        КудаПодразделениеLabel.TabIndex = 25
        КудаПодразделениеLabel.Text = "Куда Подразделение:"
        '
        'КудаМОЛLabel
        '
        КудаМОЛLabel.AutoSize = True
        КудаМОЛLabel.Location = New System.Drawing.Point(12, 165)
        КудаМОЛLabel.Name = "КудаМОЛLabel"
        КудаМОЛLabel.Size = New System.Drawing.Size(62, 13)
        КудаМОЛLabel.TabIndex = 27
        КудаМОЛLabel.Text = "Куда МОЛ:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ВнутреннееПеремещениеТМЦBindingSource, "ОткудаПодразделение", True))
        Me.ComboBox1.DataSource = Me.ПодразделенияBindingSource
        Me.ComboBox1.DisplayMember = "Нимаенование"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(147, 83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.ValueMember = "КодПодразделения"
        '
        'ВнутреннееПеремещениеТМЦBindingSource
        '
        Me.ВнутреннееПеремещениеТМЦBindingSource.DataMember = "ВнутреннееПеремещениеТМЦ"
        Me.ВнутреннееПеремещениеТМЦBindingSource.DataSource = Me.DbDataSet
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
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ВнутреннееПеремещениеТМЦBindingSource, "ОткудаМОЛ", True))
        Me.ComboBox2.DataSource = Me.МОЛBindingSource
        Me.ComboBox2.DisplayMember = "ФИОМОЛ"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(147, 109)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox2.TabIndex = 14
        Me.ComboBox2.ValueMember = "КодМОЛ"
        '
        'МОЛBindingSource
        '
        Me.МОЛBindingSource.DataMember = "МОЛ"
        Me.МОЛBindingSource.DataSource = Me.DbDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ВнутреннееПеремещениеТМЦBindingSource, "КудаПодразделение", True))
        Me.ComboBox3.DataSource = Me.ПодразделенияBindingSource1
        Me.ComboBox3.DisplayMember = "Нимаенование"
        Me.ComboBox3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(147, 136)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox3.TabIndex = 15
        Me.ComboBox3.ValueMember = "КодПодразделения"
        '
        'ПодразделенияBindingSource1
        '
        Me.ПодразделенияBindingSource1.DataMember = "Подразделения"
        Me.ПодразделенияBindingSource1.DataSource = Me.DbDataSet
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ВнутреннееПеремещениеТМЦBindingSource, "КудаМОЛ", True))
        Me.ComboBox4.DataSource = Me.МОЛBindingSource1
        Me.ComboBox4.DisplayMember = "ФИОМОЛ"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(147, 162)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox4.TabIndex = 16
        Me.ComboBox4.ValueMember = "КодМОЛ"
        '
        'МОЛBindingSource1
        '
        Me.МОЛBindingSource1.DataMember = "МОЛ"
        Me.МОЛBindingSource1.DataSource = Me.DbDataSet
        '
        'ВнутреннееПеремещениеТМЦTableAdapter
        '
        Me.ВнутреннееПеремещениеТМЦTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Sklad_TMC.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ВнутреннееПеремещениеТМЦTableAdapter = Me.ВнутреннееПеремещениеТМЦTableAdapter
        Me.TableAdapterManager.МОЛTableAdapter = Nothing
        Me.TableAdapterManager.ПереоценкаТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ПодразделенияTableAdapter = Nothing
        Me.TableAdapterManager.ПоставщикиTableAdapter = Nothing
        Me.TableAdapterManager.ПриходТМЦTableAdapter = Nothing
        Me.TableAdapterManager.СписаниеТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ТМЦTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПеремещаетсяTableAdapter = Me.ЧтоПеремещаетсяTableAdapter
        Me.TableAdapterManager.ЧтоПереоцениваетсяTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоПиришлоTableAdapter = Nothing
        Me.TableAdapterManager.ЧтоСписываетсяTableAdapter = Nothing
        '
        'ЧтоПеремещаетсяTableAdapter
        '
        Me.ЧтоПеремещаетсяTableAdapter.ClearBeforeFill = True
        '
        'ВнутреннееПеремещениеТМЦBindingNavigator
        '
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.BindingSource = Me.ВнутреннееПеремещениеТМЦBindingSource
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ВнутреннееПеремещениеТМЦBindingNavigatorSaveItem})
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.Name = "ВнутреннееПеремещениеТМЦBindingNavigator"
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.Size = New System.Drawing.Size(373, 25)
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.TabIndex = 17
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.Text = "BindingNavigator1"
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
        'ВнутреннееПеремещениеТМЦBindingNavigatorSaveItem
        '
        Me.ВнутреннееПеремещениеТМЦBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ВнутреннееПеремещениеТМЦBindingNavigatorSaveItem.Image = CType(resources.GetObject("ВнутреннееПеремещениеТМЦBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ВнутреннееПеремещениеТМЦBindingNavigatorSaveItem.Name = "ВнутреннееПеремещениеТМЦBindingNavigatorSaveItem"
        Me.ВнутреннееПеремещениеТМЦBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ВнутреннееПеремещениеТМЦBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        '_ДокументаTextBox
        '
        Me._ДокументаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВнутреннееПеремещениеТМЦBindingSource, "№Документа", True))
        Me._ДокументаTextBox.Location = New System.Drawing.Point(147, 32)
        Me._ДокументаTextBox.Name = "_ДокументаTextBox"
        Me._ДокументаTextBox.Size = New System.Drawing.Size(210, 20)
        Me._ДокументаTextBox.TabIndex = 18
        '
        'ДатаDateTimePicker
        '
        Me.ДатаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ВнутреннееПеремещениеТМЦBindingSource, "Дата", True))
        Me.ДатаDateTimePicker.Location = New System.Drawing.Point(147, 58)
        Me.ДатаDateTimePicker.Name = "ДатаDateTimePicker"
        Me.ДатаDateTimePicker.Size = New System.Drawing.Size(210, 20)
        Me.ДатаDateTimePicker.TabIndex = 20
        '
        'ОткудаПодразделениеTextBox
        '
        Me.ОткудаПодразделениеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВнутреннееПеремещениеТМЦBindingSource, "ОткудаПодразделение", True))
        Me.ОткудаПодразделениеTextBox.Location = New System.Drawing.Point(420, 84)
        Me.ОткудаПодразделениеTextBox.Name = "ОткудаПодразделениеTextBox"
        Me.ОткудаПодразделениеTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ОткудаПодразделениеTextBox.TabIndex = 22
        '
        'ОткудаМОЛTextBox
        '
        Me.ОткудаМОЛTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВнутреннееПеремещениеТМЦBindingSource, "ОткудаМОЛ", True))
        Me.ОткудаМОЛTextBox.Location = New System.Drawing.Point(420, 110)
        Me.ОткудаМОЛTextBox.Name = "ОткудаМОЛTextBox"
        Me.ОткудаМОЛTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ОткудаМОЛTextBox.TabIndex = 24
        '
        'КудаПодразделениеTextBox
        '
        Me.КудаПодразделениеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВнутреннееПеремещениеТМЦBindingSource, "КудаПодразделение", True))
        Me.КудаПодразделениеTextBox.Location = New System.Drawing.Point(420, 136)
        Me.КудаПодразделениеTextBox.Name = "КудаПодразделениеTextBox"
        Me.КудаПодразделениеTextBox.Size = New System.Drawing.Size(200, 20)
        Me.КудаПодразделениеTextBox.TabIndex = 26
        '
        'КудаМОЛTextBox
        '
        Me.КудаМОЛTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВнутреннееПеремещениеТМЦBindingSource, "КудаМОЛ", True))
        Me.КудаМОЛTextBox.Location = New System.Drawing.Point(420, 162)
        Me.КудаМОЛTextBox.Name = "КудаМОЛTextBox"
        Me.КудаМОЛTextBox.Size = New System.Drawing.Size(200, 20)
        Me.КудаМОЛTextBox.TabIndex = 28
        '
        'ЧтоПеремещаетсяBindingSource
        '
        Me.ЧтоПеремещаетсяBindingSource.DataMember = "ВнутреннееПеремещениеТМЦ_ЧтоПеремещается"
        Me.ЧтоПеремещаетсяBindingSource.DataSource = Me.ВнутреннееПеремещениеТМЦBindingSource
        '
        'ЧтоПеремещаетсяDataGridView
        '
        Me.ЧтоПеремещаетсяDataGridView.AutoGenerateColumns = False
        Me.ЧтоПеремещаетсяDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ЧтоПеремещаетсяDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ЧтоПеремещаетсяDataGridView.DataSource = Me.ЧтоПеремещаетсяBindingSource
        Me.ЧтоПеремещаетсяDataGridView.Location = New System.Drawing.Point(15, 189)
        Me.ЧтоПеремещаетсяDataGridView.Name = "ЧтоПеремещаетсяDataGridView"
        Me.ЧтоПеремещаетсяDataGridView.Size = New System.Drawing.Size(342, 220)
        Me.ЧтоПеремещаетсяDataGridView.TabIndex = 28
        '
        'ПодразделенияTableAdapter
        '
        Me.ПодразделенияTableAdapter.ClearBeforeFill = True
        '
        'МОЛTableAdapter
        '
        Me.МОЛTableAdapter.ClearBeforeFill = True
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
        'ТМЦBindingSource
        '
        Me.ТМЦBindingSource.DataMember = "ТМЦ"
        Me.ТМЦBindingSource.DataSource = Me.DbDataSet
        '
        'ТМЦTableAdapter
        '
        Me.ТМЦTableAdapter.ClearBeforeFill = True
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
        Me.DataGridViewTextBoxColumn2.DataSource = Me.ТМЦBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "ИнвентарныйНомер"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ИнвентарныйНомер"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "ИнвентарныйНомер"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ЦенаПеремещения"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ЦенаПеремещения"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmPeremishenya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 420)
        Me.Controls.Add(Me.ЧтоПеремещаетсяDataGridView)
        Me.Controls.Add(_ДокументаLabel)
        Me.Controls.Add(Me._ДокументаTextBox)
        Me.Controls.Add(ДатаLabel)
        Me.Controls.Add(Me.ДатаDateTimePicker)
        Me.Controls.Add(ОткудаПодразделениеLabel)
        Me.Controls.Add(Me.ОткудаПодразделениеTextBox)
        Me.Controls.Add(ОткудаМОЛLabel)
        Me.Controls.Add(Me.ОткудаМОЛTextBox)
        Me.Controls.Add(КудаПодразделениеLabel)
        Me.Controls.Add(Me.КудаПодразделениеTextBox)
        Me.Controls.Add(КудаМОЛLabel)
        Me.Controls.Add(Me.КудаМОЛTextBox)
        Me.Controls.Add(Me.ВнутреннееПеремещениеТМЦBindingNavigator)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPeremishenya"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPeremishenya"
        CType(Me.ВнутреннееПеремещениеТМЦBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПодразделенияBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.МОЛBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПодразделенияBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.МОЛBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ВнутреннееПеремещениеТМЦBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.ResumeLayout(False)
        Me.ВнутреннееПеремещениеТМЦBindingNavigator.PerformLayout()
        CType(Me.ЧтоПеремещаетсяBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЧтоПеремещаетсяDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПереоценкаТМЦBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ТМЦBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents DbDataSet As dbDataSet
    Friend WithEvents ВнутреннееПеремещениеТМЦBindingSource As BindingSource
    Friend WithEvents ВнутреннееПеремещениеТМЦTableAdapter As dbDataSetTableAdapters.ВнутреннееПеремещениеТМЦTableAdapter
    Friend WithEvents TableAdapterManager As dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ВнутреннееПеремещениеТМЦBindingNavigator As BindingNavigator
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
    Friend WithEvents ВнутреннееПеремещениеТМЦBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents _ДокументаTextBox As TextBox
    Friend WithEvents ДатаDateTimePicker As DateTimePicker
    Friend WithEvents ОткудаПодразделениеTextBox As TextBox
    Friend WithEvents ОткудаМОЛTextBox As TextBox
    Friend WithEvents КудаПодразделениеTextBox As TextBox
    Friend WithEvents КудаМОЛTextBox As TextBox
    Friend WithEvents ЧтоПеремещаетсяTableAdapter As dbDataSetTableAdapters.ЧтоПеремещаетсяTableAdapter
    Friend WithEvents ЧтоПеремещаетсяBindingSource As BindingSource
    Friend WithEvents ЧтоПеремещаетсяDataGridView As DataGridView
    Friend WithEvents ПодразделенияBindingSource As BindingSource
    Friend WithEvents ПодразделенияTableAdapter As dbDataSetTableAdapters.ПодразделенияTableAdapter
    Friend WithEvents МОЛBindingSource As BindingSource
    Friend WithEvents МОЛTableAdapter As dbDataSetTableAdapters.МОЛTableAdapter
    Friend WithEvents ПодразделенияBindingSource1 As BindingSource
    Friend WithEvents ПереоценкаТМЦBindingSource As BindingSource
    Friend WithEvents ПереоценкаТМЦTableAdapter As dbDataSetTableAdapters.ПереоценкаТМЦTableAdapter
    Friend WithEvents МОЛBindingSource1 As BindingSource
    Friend WithEvents ТМЦBindingSource As BindingSource
    Friend WithEvents ТМЦTableAdapter As dbDataSetTableAdapters.ТМЦTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
