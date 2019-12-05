<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim Wk1Label As System.Windows.Forms.Label
        Dim Wk2Label As System.Windows.Forms.Label
        Dim Wk3Label As System.Windows.Forms.Label
        Dim Wk4Label As System.Windows.Forms.Label
        Dim Wk5Label As System.Windows.Forms.Label
        Dim Wk6Label As System.Windows.Forms.Label
        Dim Wk7Label As System.Windows.Forms.Label
        Dim Wk8Label As System.Windows.Forms.Label
        Dim Wk9Label As System.Windows.Forms.Label
        Dim Wk10Label As System.Windows.Forms.Label
        Dim AttsumLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.StudentDataSet = New WindowsApp1.studentDataSet()
        Me.Sheet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sheet1TableAdapter = New WindowsApp1.studentDataSetTableAdapters.Sheet1TableAdapter()
        Me.TableAdapterManager = New WindowsApp1.studentDataSetTableAdapters.TableAdapterManager()
        Me.Sheet1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Sheet1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Wk1TextBox = New System.Windows.Forms.TextBox()
        Me.Wk2TextBox = New System.Windows.Forms.TextBox()
        Me.Wk3TextBox = New System.Windows.Forms.TextBox()
        Me.Wk4TextBox = New System.Windows.Forms.TextBox()
        Me.Wk5TextBox = New System.Windows.Forms.TextBox()
        Me.Wk6TextBox = New System.Windows.Forms.TextBox()
        Me.Wk7TextBox = New System.Windows.Forms.TextBox()
        Me.Wk8TextBox = New System.Windows.Forms.TextBox()
        Me.Wk9TextBox = New System.Windows.Forms.TextBox()
        Me.Wk10TextBox = New System.Windows.Forms.TextBox()
        Me.AttsumTextBox = New System.Windows.Forms.TextBox()
        Me.Sheet1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btngrades = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Wk1Label = New System.Windows.Forms.Label()
        Wk2Label = New System.Windows.Forms.Label()
        Wk3Label = New System.Windows.Forms.Label()
        Wk4Label = New System.Windows.Forms.Label()
        Wk5Label = New System.Windows.Forms.Label()
        Wk6Label = New System.Windows.Forms.Label()
        Wk7Label = New System.Windows.Forms.Label()
        Wk8Label = New System.Windows.Forms.Label()
        Wk9Label = New System.Windows.Forms.Label()
        Wk10Label = New System.Windows.Forms.Label()
        AttsumLabel = New System.Windows.Forms.Label()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sheet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sheet1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sheet1BindingNavigator.SuspendLayout()
        CType(Me.Sheet1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(16, 74)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(16, 100)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'Wk1Label
        '
        Wk1Label.AutoSize = True
        Wk1Label.Location = New System.Drawing.Point(16, 126)
        Wk1Label.Name = "Wk1Label"
        Wk1Label.Size = New System.Drawing.Size(30, 13)
        Wk1Label.TabIndex = 5
        Wk1Label.Text = "wk1:"
        '
        'Wk2Label
        '
        Wk2Label.AutoSize = True
        Wk2Label.Location = New System.Drawing.Point(16, 152)
        Wk2Label.Name = "Wk2Label"
        Wk2Label.Size = New System.Drawing.Size(30, 13)
        Wk2Label.TabIndex = 7
        Wk2Label.Text = "wk2:"
        '
        'Wk3Label
        '
        Wk3Label.AutoSize = True
        Wk3Label.Location = New System.Drawing.Point(16, 178)
        Wk3Label.Name = "Wk3Label"
        Wk3Label.Size = New System.Drawing.Size(30, 13)
        Wk3Label.TabIndex = 9
        Wk3Label.Text = "wk3:"
        '
        'Wk4Label
        '
        Wk4Label.AutoSize = True
        Wk4Label.Location = New System.Drawing.Point(16, 204)
        Wk4Label.Name = "Wk4Label"
        Wk4Label.Size = New System.Drawing.Size(30, 13)
        Wk4Label.TabIndex = 11
        Wk4Label.Text = "wk4:"
        '
        'Wk5Label
        '
        Wk5Label.AutoSize = True
        Wk5Label.Location = New System.Drawing.Point(16, 230)
        Wk5Label.Name = "Wk5Label"
        Wk5Label.Size = New System.Drawing.Size(30, 13)
        Wk5Label.TabIndex = 13
        Wk5Label.Text = "wk5:"
        '
        'Wk6Label
        '
        Wk6Label.AutoSize = True
        Wk6Label.Location = New System.Drawing.Point(16, 256)
        Wk6Label.Name = "Wk6Label"
        Wk6Label.Size = New System.Drawing.Size(30, 13)
        Wk6Label.TabIndex = 15
        Wk6Label.Text = "wk6:"
        '
        'Wk7Label
        '
        Wk7Label.AutoSize = True
        Wk7Label.Location = New System.Drawing.Point(16, 282)
        Wk7Label.Name = "Wk7Label"
        Wk7Label.Size = New System.Drawing.Size(30, 13)
        Wk7Label.TabIndex = 17
        Wk7Label.Text = "wk7:"
        '
        'Wk8Label
        '
        Wk8Label.AutoSize = True
        Wk8Label.Location = New System.Drawing.Point(16, 308)
        Wk8Label.Name = "Wk8Label"
        Wk8Label.Size = New System.Drawing.Size(30, 13)
        Wk8Label.TabIndex = 19
        Wk8Label.Text = "wk8:"
        '
        'Wk9Label
        '
        Wk9Label.AutoSize = True
        Wk9Label.Location = New System.Drawing.Point(16, 334)
        Wk9Label.Name = "Wk9Label"
        Wk9Label.Size = New System.Drawing.Size(30, 13)
        Wk9Label.TabIndex = 21
        Wk9Label.Text = "wk9:"
        '
        'Wk10Label
        '
        Wk10Label.AutoSize = True
        Wk10Label.Location = New System.Drawing.Point(16, 360)
        Wk10Label.Name = "Wk10Label"
        Wk10Label.Size = New System.Drawing.Size(36, 13)
        Wk10Label.TabIndex = 23
        Wk10Label.Text = "wk10:"
        '
        'AttsumLabel
        '
        AttsumLabel.AutoSize = True
        AttsumLabel.Location = New System.Drawing.Point(16, 386)
        AttsumLabel.Name = "AttsumLabel"
        AttsumLabel.Size = New System.Drawing.Size(42, 13)
        AttsumLabel.TabIndex = 25
        AttsumLabel.Text = "Attsum:"
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "studentDataSet"
        Me.StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sheet1BindingSource
        '
        Me.Sheet1BindingSource.DataMember = "Sheet1"
        Me.Sheet1BindingSource.DataSource = Me.StudentDataSet
        '
        'Sheet1TableAdapter
        '
        Me.Sheet1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Sheet1TableAdapter = Me.Sheet1TableAdapter
        Me.TableAdapterManager.Sheet2TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.studentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sheet1BindingNavigator
        '
        Me.Sheet1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Sheet1BindingNavigator.BindingSource = Me.Sheet1BindingSource
        Me.Sheet1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Sheet1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Sheet1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Sheet1BindingNavigatorSaveItem})
        Me.Sheet1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Sheet1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Sheet1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Sheet1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Sheet1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Sheet1BindingNavigator.Name = "Sheet1BindingNavigator"
        Me.Sheet1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Sheet1BindingNavigator.Size = New System.Drawing.Size(1370, 25)
        Me.Sheet1BindingNavigator.TabIndex = 0
        Me.Sheet1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
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
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Sheet1BindingNavigatorSaveItem
        '
        Me.Sheet1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Sheet1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Sheet1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Sheet1BindingNavigatorSaveItem.Name = "Sheet1BindingNavigatorSaveItem"
        Me.Sheet1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Sheet1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(64, 71)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(117, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(64, 97)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(117, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'Wk1TextBox
        '
        Me.Wk1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "wk1", True))
        Me.Wk1TextBox.Location = New System.Drawing.Point(64, 123)
        Me.Wk1TextBox.Name = "Wk1TextBox"
        Me.Wk1TextBox.Size = New System.Drawing.Size(117, 20)
        Me.Wk1TextBox.TabIndex = 6
        '
        'Wk2TextBox
        '
        Me.Wk2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "wk2", True))
        Me.Wk2TextBox.Location = New System.Drawing.Point(64, 149)
        Me.Wk2TextBox.Name = "Wk2TextBox"
        Me.Wk2TextBox.Size = New System.Drawing.Size(117, 20)
        Me.Wk2TextBox.TabIndex = 8
        '
        'Wk3TextBox
        '
        Me.Wk3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "wk3", True))
        Me.Wk3TextBox.Location = New System.Drawing.Point(64, 175)
        Me.Wk3TextBox.Name = "Wk3TextBox"
        Me.Wk3TextBox.Size = New System.Drawing.Size(117, 20)
        Me.Wk3TextBox.TabIndex = 10
        '
        'Wk4TextBox
        '
        Me.Wk4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "wk4", True))
        Me.Wk4TextBox.Location = New System.Drawing.Point(64, 201)
        Me.Wk4TextBox.Name = "Wk4TextBox"
        Me.Wk4TextBox.Size = New System.Drawing.Size(117, 20)
        Me.Wk4TextBox.TabIndex = 12
        '
        'Wk5TextBox
        '
        Me.Wk5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "wk5", True))
        Me.Wk5TextBox.Location = New System.Drawing.Point(64, 227)
        Me.Wk5TextBox.Name = "Wk5TextBox"
        Me.Wk5TextBox.Size = New System.Drawing.Size(117, 20)
        Me.Wk5TextBox.TabIndex = 14
        '
        'Wk6TextBox
        '
        Me.Wk6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "wk6", True))
        Me.Wk6TextBox.Location = New System.Drawing.Point(64, 253)
        Me.Wk6TextBox.Name = "Wk6TextBox"
        Me.Wk6TextBox.Size = New System.Drawing.Size(117, 20)
        Me.Wk6TextBox.TabIndex = 16
        '
        'Wk7TextBox
        '
        Me.Wk7TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "wk7", True))
        Me.Wk7TextBox.Location = New System.Drawing.Point(64, 279)
        Me.Wk7TextBox.Name = "Wk7TextBox"
        Me.Wk7TextBox.Size = New System.Drawing.Size(117, 20)
        Me.Wk7TextBox.TabIndex = 18
        '
        'Wk8TextBox
        '
        Me.Wk8TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "wk8", True))
        Me.Wk8TextBox.Location = New System.Drawing.Point(64, 305)
        Me.Wk8TextBox.Name = "Wk8TextBox"
        Me.Wk8TextBox.Size = New System.Drawing.Size(117, 20)
        Me.Wk8TextBox.TabIndex = 20
        '
        'Wk9TextBox
        '
        Me.Wk9TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "wk9", True))
        Me.Wk9TextBox.Location = New System.Drawing.Point(64, 331)
        Me.Wk9TextBox.Name = "Wk9TextBox"
        Me.Wk9TextBox.Size = New System.Drawing.Size(117, 20)
        Me.Wk9TextBox.TabIndex = 22
        '
        'Wk10TextBox
        '
        Me.Wk10TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "wk10", True))
        Me.Wk10TextBox.Location = New System.Drawing.Point(64, 357)
        Me.Wk10TextBox.Name = "Wk10TextBox"
        Me.Wk10TextBox.Size = New System.Drawing.Size(117, 20)
        Me.Wk10TextBox.TabIndex = 24
        '
        'AttsumTextBox
        '
        Me.AttsumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Attsum", True))
        Me.AttsumTextBox.Location = New System.Drawing.Point(64, 383)
        Me.AttsumTextBox.Name = "AttsumTextBox"
        Me.AttsumTextBox.Size = New System.Drawing.Size(117, 20)
        Me.AttsumTextBox.TabIndex = 26
        '
        'Sheet1DataGridView
        '
        Me.Sheet1DataGridView.AutoGenerateColumns = False
        Me.Sheet1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sheet1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.Sheet1DataGridView.DataSource = Me.Sheet1BindingSource
        Me.Sheet1DataGridView.Location = New System.Drawing.Point(219, 71)
        Me.Sheet1DataGridView.Name = "Sheet1DataGridView"
        Me.Sheet1DataGridView.Size = New System.Drawing.Size(851, 529)
        Me.Sheet1DataGridView.TabIndex = 27
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "wk1"
        Me.DataGridViewTextBoxColumn3.HeaderText = "wk1"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "wk2"
        Me.DataGridViewTextBoxColumn4.HeaderText = "wk2"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "wk3"
        Me.DataGridViewTextBoxColumn5.HeaderText = "wk3"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "wk4"
        Me.DataGridViewTextBoxColumn6.HeaderText = "wk4"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "wk5"
        Me.DataGridViewTextBoxColumn7.HeaderText = "wk5"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "wk6"
        Me.DataGridViewTextBoxColumn8.HeaderText = "wk6"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "wk7"
        Me.DataGridViewTextBoxColumn9.HeaderText = "wk7"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "wk8"
        Me.DataGridViewTextBoxColumn10.HeaderText = "wk8"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "wk9"
        Me.DataGridViewTextBoxColumn11.HeaderText = "wk9"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "wk10"
        Me.DataGridViewTextBoxColumn12.HeaderText = "wk10"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Attsum"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Attsum"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(403, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(608, 55)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "STUDENT ATTENDANCE"
        '
        'btngrades
        '
        Me.btngrades.Location = New System.Drawing.Point(37, 420)
        Me.btngrades.Name = "btngrades"
        Me.btngrades.Size = New System.Drawing.Size(144, 23)
        Me.btngrades.TabIndex = 29
        Me.btngrades.Text = "Access Grades Form"
        Me.btngrades.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(836, 606)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 30
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 659)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btngrades)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Sheet1DataGridView)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Wk1Label)
        Me.Controls.Add(Me.Wk1TextBox)
        Me.Controls.Add(Wk2Label)
        Me.Controls.Add(Me.Wk2TextBox)
        Me.Controls.Add(Wk3Label)
        Me.Controls.Add(Me.Wk3TextBox)
        Me.Controls.Add(Wk4Label)
        Me.Controls.Add(Me.Wk4TextBox)
        Me.Controls.Add(Wk5Label)
        Me.Controls.Add(Me.Wk5TextBox)
        Me.Controls.Add(Wk6Label)
        Me.Controls.Add(Me.Wk6TextBox)
        Me.Controls.Add(Wk7Label)
        Me.Controls.Add(Me.Wk7TextBox)
        Me.Controls.Add(Wk8Label)
        Me.Controls.Add(Me.Wk8TextBox)
        Me.Controls.Add(Wk9Label)
        Me.Controls.Add(Me.Wk9TextBox)
        Me.Controls.Add(Wk10Label)
        Me.Controls.Add(Me.Wk10TextBox)
        Me.Controls.Add(AttsumLabel)
        Me.Controls.Add(Me.AttsumTextBox)
        Me.Controls.Add(Me.Sheet1BindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sheet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sheet1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sheet1BindingNavigator.ResumeLayout(False)
        Me.Sheet1BindingNavigator.PerformLayout()
        CType(Me.Sheet1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentDataSet As studentDataSet
    Friend WithEvents Sheet1BindingSource As BindingSource
    Friend WithEvents Sheet1TableAdapter As studentDataSetTableAdapters.Sheet1TableAdapter
    Friend WithEvents TableAdapterManager As studentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sheet1BindingNavigator As BindingNavigator
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
    Friend WithEvents Sheet1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Wk1TextBox As TextBox
    Friend WithEvents Wk2TextBox As TextBox
    Friend WithEvents Wk3TextBox As TextBox
    Friend WithEvents Wk4TextBox As TextBox
    Friend WithEvents Wk5TextBox As TextBox
    Friend WithEvents Wk6TextBox As TextBox
    Friend WithEvents Wk7TextBox As TextBox
    Friend WithEvents Wk8TextBox As TextBox
    Friend WithEvents Wk9TextBox As TextBox
    Friend WithEvents Wk10TextBox As TextBox
    Friend WithEvents AttsumTextBox As TextBox
    Friend WithEvents Sheet1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btngrades As Button
    Friend WithEvents btnexit As Button
End Class
