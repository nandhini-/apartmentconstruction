<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer))
        Dim Apartnament_nameLabel As System.Windows.Forms.Label
        Dim Square_feetLabel As System.Windows.Forms.Label
        Dim PlaceLabel As System.Windows.Forms.Label
        Dim AreaLabel As System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Table2BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Table2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db2DataSet1 = New construction.db2DataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Table2TableAdapter = New construction.db2DataSetTableAdapters.Table2TableAdapter()
        Me.TableAdapterManager = New construction.db2DataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Table2BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Db1DataSet = New construction.db1DataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New construction.db1DataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager1 = New construction.db1DataSetTableAdapters.TableAdapterManager()
        Me.Apartnament_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Square_feetTextBox = New System.Windows.Forms.TextBox()
        Me.PlaceTextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Apartnament_nameLabel = New System.Windows.Forms.Label()
        Square_feetLabel = New System.Windows.Forms.Label()
        PlaceLabel = New System.Windows.Forms.Label()
        AreaLabel = New System.Windows.Forms.Label()
        CType(Me.Table2BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Table2BindingNavigator.SuspendLayout()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "FLAT TYPE"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(169, 210)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(125, 17)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "SINGLE BED ROOM"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(300, 210)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(130, 17)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "DOUBLE BED ROOM"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(134, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 33)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "COST"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Table2BindingNavigator
        '
        Me.Table2BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Table2BindingNavigator.BindingSource = Me.Table2BindingSource
        Me.Table2BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Table2BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Table2BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Table2BindingNavigatorSaveItem})
        Me.Table2BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Table2BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Table2BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Table2BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Table2BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Table2BindingNavigator.Name = "Table2BindingNavigator"
        Me.Table2BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Table2BindingNavigator.Size = New System.Drawing.Size(716, 25)
        Me.Table2BindingNavigator.TabIndex = 14
        Me.Table2BindingNavigator.Text = "BindingNavigator1"
        '
        'Table2BindingSource
        '
        Me.Table2BindingSource.DataMember = "Table2"
        Me.Table2BindingSource.DataSource = Me.Db2DataSet1
        '
        'Db2DataSet1
        '
        Me.Db2DataSet1.DataSetName = "db2DataSet"
        Me.Db2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(300, 253)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(131, 20)
        Me.TextBox2.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(501, 202)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 51)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Table2TableAdapter
        '
        Me.Table2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table2TableAdapter = Me.Table2TableAdapter
        Me.TableAdapterManager.UpdateOrder = construction.db2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'Table2BindingNavigatorSaveItem
        '
        Me.Table2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Table2BindingNavigatorSaveItem.Image = CType(resources.GetObject("Table2BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Table2BindingNavigatorSaveItem.Name = "Table2BindingNavigatorSaveItem"
        Me.Table2BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Table2BindingNavigatorSaveItem.Text = "Save Data"
        '
        'Db1DataSet
        '
        Me.Db1DataSet.DataSetName = "db1DataSet"
        Me.Db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Db1DataSet
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager1.UpdateOrder = construction.db1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Apartnament_nameLabel
        '
        Apartnament_nameLabel.AutoSize = True
        Apartnament_nameLabel.Location = New System.Drawing.Point(57, 46)
        Apartnament_nameLabel.Name = "Apartnament_nameLabel"
        Apartnament_nameLabel.Size = New System.Drawing.Size(98, 13)
        Apartnament_nameLabel.TabIndex = 22
        Apartnament_nameLabel.Text = "apartnament name:"
        '
        'Apartnament_nameTextBox
        '
        Me.Apartnament_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "apartnament name", True))
        Me.Apartnament_nameTextBox.Location = New System.Drawing.Point(161, 43)
        Me.Apartnament_nameTextBox.Name = "Apartnament_nameTextBox"
        Me.Apartnament_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Apartnament_nameTextBox.TabIndex = 23
        '
        'Square_feetLabel
        '
        Square_feetLabel.AutoSize = True
        Square_feetLabel.Location = New System.Drawing.Point(79, 87)
        Square_feetLabel.Name = "Square_feetLabel"
        Square_feetLabel.Size = New System.Drawing.Size(63, 13)
        Square_feetLabel.TabIndex = 23
        Square_feetLabel.Text = "square feet:"
        '
        'Square_feetTextBox
        '
        Me.Square_feetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "square feet", True))
        Me.Square_feetTextBox.Location = New System.Drawing.Point(161, 84)
        Me.Square_feetTextBox.Name = "Square_feetTextBox"
        Me.Square_feetTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Square_feetTextBox.TabIndex = 24
        '
        'PlaceLabel
        '
        PlaceLabel.AutoSize = True
        PlaceLabel.Location = New System.Drawing.Point(86, 133)
        PlaceLabel.Name = "PlaceLabel"
        PlaceLabel.Size = New System.Drawing.Size(36, 13)
        PlaceLabel.TabIndex = 24
        PlaceLabel.Text = "place:"
        '
        'PlaceTextBox
        '
        Me.PlaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "place", True))
        Me.PlaceTextBox.Location = New System.Drawing.Point(161, 126)
        Me.PlaceTextBox.Name = "PlaceTextBox"
        Me.PlaceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PlaceTextBox.TabIndex = 25
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Location = New System.Drawing.Point(86, 159)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(31, 13)
        AreaLabel.TabIndex = 25
        AreaLabel.Text = "area:"
        '
        'AreaTextBox
        '
        Me.AreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "area", True))
        Me.AreaTextBox.Location = New System.Drawing.Point(161, 159)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AreaTextBox.TabIndex = 26
        '
        'customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 304)
        Me.Controls.Add(AreaLabel)
        Me.Controls.Add(Me.AreaTextBox)
        Me.Controls.Add(PlaceLabel)
        Me.Controls.Add(Me.PlaceTextBox)
        Me.Controls.Add(Square_feetLabel)
        Me.Controls.Add(Me.Square_feetTextBox)
        Me.Controls.Add(Apartnament_nameLabel)
        Me.Controls.Add(Me.Apartnament_nameTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Table2BindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "customer"
        Me.Text = "customer"
        CType(Me.Table2BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Table2BindingNavigator.ResumeLayout(False)
        Me.Table2BindingNavigator.PerformLayout()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Db2DataSet1 As construction.db2DataSet
    Friend WithEvents Table2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table2TableAdapter As construction.db2DataSetTableAdapters.Table2TableAdapter
    Friend WithEvents TableAdapterManager As construction.db2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Table2BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Table2BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Db1DataSet As construction.db1DataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As construction.db1DataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager1 As construction.db1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Apartnament_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Square_feetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlaceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AreaTextBox As System.Windows.Forms.TextBox
End Class
