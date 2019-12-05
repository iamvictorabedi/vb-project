<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim IDLabel As System.Windows.Forms.Label
        Dim NAMELabel As System.Windows.Forms.Label
        Dim A1Label As System.Windows.Forms.Label
        Dim A2Label As System.Windows.Forms.Label
        Dim Q1Label As System.Windows.Forms.Label
        Dim Q2Label As System.Windows.Forms.Label
        Dim MELabel As System.Windows.Forms.Label
        Dim FELabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Me.StudentDataSet = New WindowsApp1.studentDataSet()
        Me.Sheet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sheet2TableAdapter = New WindowsApp1.studentDataSetTableAdapters.Sheet2TableAdapter()
        Me.TableAdapterManager = New WindowsApp1.studentDataSetTableAdapters.TableAdapterManager()
        Me.Sheet2BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Sheet2BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NAMETextBox = New System.Windows.Forms.TextBox()
        Me.A1TextBox = New System.Windows.Forms.TextBox()
        Me.A2TextBox = New System.Windows.Forms.TextBox()
        Me.Q1TextBox = New System.Windows.Forms.TextBox()
        Me.Q2TextBox = New System.Windows.Forms.TextBox()
        Me.METextBox = New System.Windows.Forms.TextBox()
        Me.FETextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnattendance = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sheet2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        NAMELabel = New System.Windows.Forms.Label()
        A1Label = New System.Windows.Forms.Label()
        A2Label = New System.Windows.Forms.Label()
        Q1Label = New System.Windows.Forms.Label()
        Q2Label = New System.Windows.Forms.Label()
        MELabel = New System.Windows.Forms.Label()
        FELabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sheet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sheet2BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sheet2BindingNavigator.SuspendLayout()
        CType(Me.Sheet2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "studentDataSet"
        Me.StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sheet2BindingSource
        '
        Me.Sheet2BindingSource.DataMember = "Sheet2"
        Me.Sheet2BindingSource.DataSource = Me.StudentDataSet
        '
        'Sheet2TableAdapter
        '
        Me.Sheet2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Sheet1TableAdapter = Nothing
        Me.TableAdapterManager.Sheet2TableAdapter = Me.Sheet2TableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.studentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sheet2BindingNavigator
        '
        Me.Sheet2BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Sheet2BindingNavigator.BindingSource = Me.Sheet2BindingSource
        Me.Sheet2BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Sheet2BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Sheet2BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Sheet2BindingNavigatorSaveItem})
        Me.Sheet2BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Sheet2BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Sheet2BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Sheet2BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Sheet2BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Sheet2BindingNavigator.Name = "Sheet2BindingNavigator"
        Me.Sheet2BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Sheet2BindingNavigator.Size = New System.Drawing.Size(957, 25)
        Me.Sheet2BindingNavigator.TabIndex = 0
        Me.Sheet2BindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Sheet2BindingNavigatorSaveItem
        '
        Me.Sheet2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Sheet2BindingNavigatorSaveItem.Image = CType(resources.GetObject("Sheet2BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Sheet2BindingNavigatorSaveItem.Name = "Sheet2BindingNavigatorSaveItem"
        Me.Sheet2BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Sheet2BindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(23, 94)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet2BindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(70, 91)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'NAMELabel
        '
        NAMELabel.AutoSize = True
        NAMELabel.Location = New System.Drawing.Point(23, 120)
        NAMELabel.Name = "NAMELabel"
        NAMELabel.Size = New System.Drawing.Size(41, 13)
        NAMELabel.TabIndex = 3
        NAMELabel.Text = "NAME:"
        '
        'NAMETextBox
        '
        Me.NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet2BindingSource, "NAME", True))
        Me.NAMETextBox.Location = New System.Drawing.Point(70, 117)
        Me.NAMETextBox.Name = "NAMETextBox"
        Me.NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.NAMETextBox.TabIndex = 4
        '
        'A1Label
        '
        A1Label.AutoSize = True
        A1Label.Location = New System.Drawing.Point(23, 146)
        A1Label.Name = "A1Label"
        A1Label.Size = New System.Drawing.Size(23, 13)
        A1Label.TabIndex = 5
        A1Label.Text = "A1:"
        '
        'A1TextBox
        '
        Me.A1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet2BindingSource, "A1", True))
        Me.A1TextBox.Location = New System.Drawing.Point(70, 143)
        Me.A1TextBox.Name = "A1TextBox"
        Me.A1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.A1TextBox.TabIndex = 6
        '
        'A2Label
        '
        A2Label.AutoSize = True
        A2Label.Location = New System.Drawing.Point(23, 172)
        A2Label.Name = "A2Label"
        A2Label.Size = New System.Drawing.Size(23, 13)
        A2Label.TabIndex = 7
        A2Label.Text = "A2:"
        '
        'A2TextBox
        '
        Me.A2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet2BindingSource, "A2", True))
        Me.A2TextBox.Location = New System.Drawing.Point(70, 169)
        Me.A2TextBox.Name = "A2TextBox"
        Me.A2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.A2TextBox.TabIndex = 8
        '
        'Q1Label
        '
        Q1Label.AutoSize = True
        Q1Label.Location = New System.Drawing.Point(23, 198)
        Q1Label.Name = "Q1Label"
        Q1Label.Size = New System.Drawing.Size(24, 13)
        Q1Label.TabIndex = 9
        Q1Label.Text = "Q1:"
        '
        'Q1TextBox
        '
        Me.Q1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet2BindingSource, "Q1", True))
        Me.Q1TextBox.Location = New System.Drawing.Point(70, 195)
        Me.Q1TextBox.Name = "Q1TextBox"
        Me.Q1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Q1TextBox.TabIndex = 10
        '
        'Q2Label
        '
        Q2Label.AutoSize = True
        Q2Label.Location = New System.Drawing.Point(23, 224)
        Q2Label.Name = "Q2Label"
        Q2Label.Size = New System.Drawing.Size(24, 13)
        Q2Label.TabIndex = 11
        Q2Label.Text = "Q2:"
        '
        'Q2TextBox
        '
        Me.Q2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet2BindingSource, "Q2", True))
        Me.Q2TextBox.Location = New System.Drawing.Point(70, 221)
        Me.Q2TextBox.Name = "Q2TextBox"
        Me.Q2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Q2TextBox.TabIndex = 12
        '
        'MELabel
        '
        MELabel.AutoSize = True
        MELabel.Location = New System.Drawing.Point(23, 250)
        MELabel.Name = "MELabel"
        MELabel.Size = New System.Drawing.Size(26, 13)
        MELabel.TabIndex = 13
        MELabel.Text = "ME:"
        '
        'METextBox
        '
        Me.METextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet2BindingSource, "ME", True))
        Me.METextBox.Location = New System.Drawing.Point(70, 247)
        Me.METextBox.Name = "METextBox"
        Me.METextBox.Size = New System.Drawing.Size(100, 20)
        Me.METextBox.TabIndex = 14
        '
        'FELabel
        '
        FELabel.AutoSize = True
        FELabel.Location = New System.Drawing.Point(23, 276)
        FELabel.Name = "FELabel"
        FELabel.Size = New System.Drawing.Size(23, 13)
        FELabel.TabIndex = 15
        FELabel.Text = "FE:"
        '
        'FETextBox
        '
        Me.FETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet2BindingSource, "FE", True))
        Me.FETextBox.Location = New System.Drawing.Point(70, 273)
        Me.FETextBox.Name = "FETextBox"
        Me.FETextBox.Size = New System.Drawing.Size(100, 20)
        Me.FETextBox.TabIndex = 16
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(23, 302)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 17
        TotalLabel.Text = "Total:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet2BindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(70, 299)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 18
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(840, 594)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 19
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnattendance
        '
        Me.btnattendance.Location = New System.Drawing.Point(12, 348)
        Me.btnattendance.Name = "btnattendance"
        Me.btnattendance.Size = New System.Drawing.Size(158, 23)
        Me.btnattendance.TabIndex = 20
        Me.btnattendance.Text = "Access Attendance Form"
        Me.btnattendance.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(665, 55)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "STUDENT GRADE SYSTEM"
        '
        'Sheet2DataGridView
        '
        Me.Sheet2DataGridView.AutoGenerateColumns = False
        Me.Sheet2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sheet2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Sheet2DataGridView.DataSource = Me.Sheet2BindingSource
        Me.Sheet2DataGridView.Location = New System.Drawing.Point(225, 91)
        Me.Sheet2DataGridView.Name = "Sheet2DataGridView"
        Me.Sheet2DataGridView.Size = New System.Drawing.Size(724, 480)
        Me.Sheet2DataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "A1"
        Me.DataGridViewTextBoxColumn3.HeaderText = "A1"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "A2"
        Me.DataGridViewTextBoxColumn4.HeaderText = "A2"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Q1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Q1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Q2"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Q2"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ME"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ME"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FE"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FE"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 659)
        Me.Controls.Add(Me.Sheet2DataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnattendance)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NAMELabel)
        Me.Controls.Add(Me.NAMETextBox)
        Me.Controls.Add(A1Label)
        Me.Controls.Add(Me.A1TextBox)
        Me.Controls.Add(A2Label)
        Me.Controls.Add(Me.A2TextBox)
        Me.Controls.Add(Q1Label)
        Me.Controls.Add(Me.Q1TextBox)
        Me.Controls.Add(Q2Label)
        Me.Controls.Add(Me.Q2TextBox)
        Me.Controls.Add(MELabel)
        Me.Controls.Add(Me.METextBox)
        Me.Controls.Add(FELabel)
        Me.Controls.Add(Me.FETextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.Sheet2BindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sheet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sheet2BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sheet2BindingNavigator.ResumeLayout(False)
        Me.Sheet2BindingNavigator.PerformLayout()
        CType(Me.Sheet2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentDataSet As studentDataSet
    Friend WithEvents Sheet2BindingSource As BindingSource
    Friend WithEvents Sheet2TableAdapter As studentDataSetTableAdapters.Sheet2TableAdapter
    Friend WithEvents TableAdapterManager As studentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sheet2BindingNavigator As BindingNavigator
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
    Friend WithEvents Sheet2BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NAMETextBox As TextBox
    Friend WithEvents A1TextBox As TextBox
    Friend WithEvents A2TextBox As TextBox
    Friend WithEvents Q1TextBox As TextBox
    Friend WithEvents Q2TextBox As TextBox
    Friend WithEvents METextBox As TextBox
    Friend WithEvents FETextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents btnexit As Button
    Friend WithEvents btnattendance As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Sheet2DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
