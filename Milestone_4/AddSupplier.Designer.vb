<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSupplier))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AddSuppBtn = New System.Windows.Forms.Button()
        Me.SpecialityComboBox = New System.Windows.Forms.ComboBox()
        Me.suppEmailTextBox = New System.Windows.Forms.TextBox()
        Me.suppNumbTextBox = New System.Windows.Forms.TextBox()
        Me.suppNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Group4DataSet1 = New milestone2.group4DataSet()
        Me.TASupplier = New milestone2.group4DataSetTableAdapters.SupplierTableAdapter()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.Group4DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.AliceBlue
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(630, 581)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 65)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Clear All"
        Me.ToolTip1.SetToolTip(Me.Button3, "Click to clear all fields for new input")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.AliceBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(921, 581)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 65)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Back To Main Menu"
        Me.ToolTip1.SetToolTip(Me.Button1, "Click to go back to main  menu")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AddSuppBtn
        '
        Me.AddSuppBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.AddSuppBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSuppBtn.Location = New System.Drawing.Point(340, 581)
        Me.AddSuppBtn.Name = "AddSuppBtn"
        Me.AddSuppBtn.Size = New System.Drawing.Size(156, 65)
        Me.AddSuppBtn.TabIndex = 25
        Me.AddSuppBtn.Text = "Add New Supplier"
        Me.ToolTip1.SetToolTip(Me.AddSuppBtn, "Click to add new supplier")
        Me.AddSuppBtn.UseVisualStyleBackColor = False
        '
        'SpecialityComboBox
        '
        Me.SpecialityComboBox.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.SpecialityComboBox, "Choose supplier speciality(eg. catering, bakery etc.)")
        Me.SpecialityComboBox.Items.AddRange(New Object() {"Refrigeration" & Global.Microsoft.VisualBasic.ChrW(9), "Catering", "Butchery", "Bakery"})
        Me.SpecialityComboBox.Location = New System.Drawing.Point(532, 424)
        Me.SpecialityComboBox.Name = "SpecialityComboBox"
        Me.HelpProvider1.SetShowHelp(Me.SpecialityComboBox, True)
        Me.SpecialityComboBox.Size = New System.Drawing.Size(118, 21)
        Me.SpecialityComboBox.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.SpecialityComboBox, "Choose supplier speciality(eg. catering, bakery etc.)")
        '
        'suppEmailTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.suppEmailTextBox, "Enter supplier email address")
        Me.suppEmailTextBox.Location = New System.Drawing.Point(532, 351)
        Me.suppEmailTextBox.Name = "suppEmailTextBox"
        Me.HelpProvider1.SetShowHelp(Me.suppEmailTextBox, True)
        Me.suppEmailTextBox.Size = New System.Drawing.Size(267, 20)
        Me.suppEmailTextBox.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.suppEmailTextBox, "Enter supplier email address")
        '
        'suppNumbTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.suppNumbTextBox, "Enter new supplier contact number")
        Me.suppNumbTextBox.Location = New System.Drawing.Point(532, 261)
        Me.suppNumbTextBox.MaxLength = 10
        Me.suppNumbTextBox.Name = "suppNumbTextBox"
        Me.HelpProvider1.SetShowHelp(Me.suppNumbTextBox, True)
        Me.suppNumbTextBox.Size = New System.Drawing.Size(267, 20)
        Me.suppNumbTextBox.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.suppNumbTextBox, "Enter supplier contact number")
        '
        'suppNameTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.suppNameTextBox, "Enter new supplier name")
        Me.suppNameTextBox.Location = New System.Drawing.Point(532, 181)
        Me.suppNameTextBox.Name = "suppNameTextBox"
        Me.HelpProvider1.SetShowHelp(Me.suppNameTextBox, True)
        Me.suppNameTextBox.Size = New System.Drawing.Size(267, 20)
        Me.suppNameTextBox.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.suppNameTextBox, "Enter new supplier name")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(337, 427)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Supplier Speciality:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(337, 353)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Email Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(337, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Contact Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(337, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Supplier Name:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(-1, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(1240, 44)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Add New Supplier"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Group4DataSet1
        '
        Me.Group4DataSet1.DataSetName = "group4DataSet"
        Me.Group4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TASupplier
        '
        Me.TASupplier.ClearBeforeFill = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(805, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 29)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(805, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 29)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(656, 415)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 29)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(1017, 748)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 29)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(1038, 758)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 16)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Required Fields"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(364, 20)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Please Enter The Following Supplier Details:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(980, 261)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 184)
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'AddSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1236, 870)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AddSuppBtn)
        Me.Controls.Add(Me.SpecialityComboBox)
        Me.Controls.Add(Me.suppEmailTextBox)
        Me.Controls.Add(Me.suppNumbTextBox)
        Me.Controls.Add(Me.suppNameTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Name = "AddSupplier"
        Me.Text = "AddSupplier"
        CType(Me.Group4DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AddSuppBtn As System.Windows.Forms.Button
    Friend WithEvents SpecialityComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents suppEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents suppNumbTextBox As System.Windows.Forms.TextBox
    Friend WithEvents suppNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Group4DataSet1 As milestone2.group4DataSet
    Friend WithEvents TASupplier As milestone2.group4DataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
