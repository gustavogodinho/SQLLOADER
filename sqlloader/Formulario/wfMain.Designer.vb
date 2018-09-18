<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wfMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTnsNames = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbIntoTable = New System.Windows.Forms.ComboBox()
        Me.cmbDataBase = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtTnsNames = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtError = New System.Windows.Forms.TextBox()
        Me.txtDelimitador = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnInfile = New System.Windows.Forms.Button()
        Me.txtInfile = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridTabela = New System.Windows.Forms.DataGridView()
        Me.clbArquivos = New System.Windows.Forms.CheckedListBox()
        Me.ofdTNSNAMES = New System.Windows.Forms.OpenFileDialog()
        Me.fbdDiretorio = New System.Windows.Forms.FolderBrowserDialog()
        Me.CheckBoxAll = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SpoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogDeErroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBoxBoton = New System.Windows.Forms.GroupBox()
        Me.btnCarrega = New System.Windows.Forms.Button()
        Me.bsCargaTables = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtRows = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBoxParametro = New System.Windows.Forms.GroupBox()
        Me.rdFieldsTerminated = New System.Windows.Forms.RadioButton()
        Me.rbPOSITION = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridTabela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBoxBoton.SuspendLayout()
        CType(Me.bsCargaTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxParametro.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTnsNames)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbIntoTable)
        Me.GroupBox1.Controls.Add(Me.cmbDataBase)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.txtTnsNames)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnTnsNames
        '
        Me.btnTnsNames.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTnsNames.Location = New System.Drawing.Point(421, 17)
        Me.btnTnsNames.Name = "btnTnsNames"
        Me.btnTnsNames.Size = New System.Drawing.Size(29, 23)
        Me.btnTnsNames.TabIndex = 15
        Me.btnTnsNames.Text = "....."
        Me.btnTnsNames.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(236, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "INTO TABLE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "DATABASE:"
        '
        'cmbIntoTable
        '
        Me.cmbIntoTable.FormattingEnabled = True
        Me.cmbIntoTable.Location = New System.Drawing.Point(312, 80)
        Me.cmbIntoTable.Name = "cmbIntoTable"
        Me.cmbIntoTable.Size = New System.Drawing.Size(186, 23)
        Me.cmbIntoTable.TabIndex = 4
        '
        'cmbDataBase
        '
        Me.cmbDataBase.FormattingEnabled = True
        Me.cmbDataBase.Location = New System.Drawing.Point(83, 79)
        Me.cmbDataBase.Name = "cmbDataBase"
        Me.cmbDataBase.Size = New System.Drawing.Size(140, 23)
        Me.cmbDataBase.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PASSWORD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "USER:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TNSNAMES:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(284, 49)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(116, 23)
        Me.txtPassword.TabIndex = 2
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(83, 48)
        Me.txtUser.MaxLength = 20
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(116, 23)
        Me.txtUser.TabIndex = 1
        '
        'txtTnsNames
        '
        Me.txtTnsNames.Location = New System.Drawing.Point(83, 18)
        Me.txtTnsNames.Name = "txtTnsNames"
        Me.txtTnsNames.Size = New System.Drawing.Size(332, 23)
        Me.txtTnsNames.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ERRORS:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(197, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "FIELDS TERMINATED BY:"
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(104, 22)
        Me.txtError.MaxLength = 6
        Me.txtError.Name = "txtError"
        Me.txtError.Size = New System.Drawing.Size(71, 23)
        Me.txtError.TabIndex = 5
        '
        'txtDelimitador
        '
        Me.txtDelimitador.Location = New System.Drawing.Point(334, 56)
        Me.txtDelimitador.MaxLength = 1
        Me.txtDelimitador.Name = "txtDelimitador"
        Me.txtDelimitador.Size = New System.Drawing.Size(37, 23)
        Me.txtDelimitador.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnInfile)
        Me.GroupBox2.Controls.Add(Me.txtInfile)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(524, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(477, 72)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnInfile
        '
        Me.btnInfile.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfile.Location = New System.Drawing.Point(436, 31)
        Me.btnInfile.Name = "btnInfile"
        Me.btnInfile.Size = New System.Drawing.Size(28, 23)
        Me.btnInfile.TabIndex = 16
        Me.btnInfile.Text = "....."
        Me.btnInfile.UseVisualStyleBackColor = True
        '
        'txtInfile
        '
        Me.txtInfile.Location = New System.Drawing.Point(56, 32)
        Me.txtInfile.Name = "txtInfile"
        Me.txtInfile.Size = New System.Drawing.Size(374, 23)
        Me.txtInfile.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "INFILE:"
        '
        'DataGridTabela
        '
        Me.DataGridTabela.AllowUserToAddRows = False
        Me.DataGridTabela.AllowUserToDeleteRows = False
        Me.DataGridTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTabela.Location = New System.Drawing.Point(14, 276)
        Me.DataGridTabela.Name = "DataGridTabela"
        Me.DataGridTabela.ReadOnly = True
        Me.DataGridTabela.Size = New System.Drawing.Size(504, 171)
        Me.DataGridTabela.TabIndex = 2
        '
        'clbArquivos
        '
        Me.clbArquivos.FormattingEnabled = True
        Me.clbArquivos.Location = New System.Drawing.Point(524, 124)
        Me.clbArquivos.Name = "clbArquivos"
        Me.clbArquivos.Size = New System.Drawing.Size(477, 292)
        Me.clbArquivos.TabIndex = 8
        '
        'ofdTNSNAMES
        '
        Me.ofdTNSNAMES.FileName = "OpenFileDialog1"
        '
        'CheckBoxAll
        '
        Me.CheckBoxAll.AutoSize = True
        Me.CheckBoxAll.Location = New System.Drawing.Point(524, 99)
        Me.CheckBoxAll.Name = "CheckBoxAll"
        Me.CheckBoxAll.Size = New System.Drawing.Size(41, 19)
        Me.CheckBoxAll.TabIndex = 4
        Me.CheckBoxAll.Text = "All"
        Me.CheckBoxAll.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpoolToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1018, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SpoolToolStripMenuItem
        '
        Me.SpoolToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogDeErroToolStripMenuItem})
        Me.SpoolToolStripMenuItem.Name = "SpoolToolStripMenuItem"
        Me.SpoolToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.SpoolToolStripMenuItem.Text = "Log"
        '
        'LogDeErroToolStripMenuItem
        '
        Me.LogDeErroToolStripMenuItem.Name = "LogDeErroToolStripMenuItem"
        Me.LogDeErroToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.LogDeErroToolStripMenuItem.Text = "Log de Erro"
        '
        'GroupBoxBoton
        '
        Me.GroupBoxBoton.Controls.Add(Me.btnCarrega)
        Me.GroupBoxBoton.Location = New System.Drawing.Point(14, 450)
        Me.GroupBoxBoton.Name = "GroupBoxBoton"
        Me.GroupBoxBoton.Size = New System.Drawing.Size(987, 60)
        Me.GroupBoxBoton.TabIndex = 6
        Me.GroupBoxBoton.TabStop = False
        '
        'btnCarrega
        '
        Me.btnCarrega.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarrega.Location = New System.Drawing.Point(421, 22)
        Me.btnCarrega.Name = "btnCarrega"
        Me.btnCarrega.Size = New System.Drawing.Size(120, 30)
        Me.btnCarrega.TabIndex = 0
        Me.btnCarrega.Text = "Load"
        Me.btnCarrega.UseVisualStyleBackColor = True
        '
        'txtRows
        '
        Me.txtRows.Location = New System.Drawing.Point(104, 56)
        Me.txtRows.MaxLength = 6
        Me.txtRows.Name = "txtRows"
        Me.txtRows.Size = New System.Drawing.Size(71, 23)
        Me.txtRows.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "ROWS COMMIT:"
        '
        'GroupBoxParametro
        '
        Me.GroupBoxParametro.Controls.Add(Me.rdFieldsTerminated)
        Me.GroupBoxParametro.Controls.Add(Me.rbPOSITION)
        Me.GroupBoxParametro.Controls.Add(Me.Label9)
        Me.GroupBoxParametro.Controls.Add(Me.txtRows)
        Me.GroupBoxParametro.Controls.Add(Me.txtDelimitador)
        Me.GroupBoxParametro.Controls.Add(Me.txtError)
        Me.GroupBoxParametro.Controls.Add(Me.Label4)
        Me.GroupBoxParametro.Controls.Add(Me.Label6)
        Me.GroupBoxParametro.Location = New System.Drawing.Point(14, 148)
        Me.GroupBoxParametro.Name = "GroupBoxParametro"
        Me.GroupBoxParametro.Size = New System.Drawing.Size(504, 122)
        Me.GroupBoxParametro.TabIndex = 9
        Me.GroupBoxParametro.TabStop = False
        '
        'rdFieldsTerminated
        '
        Me.rdFieldsTerminated.AutoSize = True
        Me.rdFieldsTerminated.Location = New System.Drawing.Point(302, 23)
        Me.rdFieldsTerminated.Name = "rdFieldsTerminated"
        Me.rdFieldsTerminated.Size = New System.Drawing.Size(134, 19)
        Me.rdFieldsTerminated.TabIndex = 19
        Me.rdFieldsTerminated.TabStop = True
        Me.rdFieldsTerminated.Text = "FIELDS TERMINATED:"
        Me.rdFieldsTerminated.UseVisualStyleBackColor = True
        '
        'rbPOSITION
        '
        Me.rbPOSITION.AutoSize = True
        Me.rbPOSITION.Location = New System.Drawing.Point(197, 23)
        Me.rbPOSITION.Name = "rbPOSITION"
        Me.rbPOSITION.Size = New System.Drawing.Size(81, 19)
        Me.rbPOSITION.TabIndex = 18
        Me.rbPOSITION.TabStop = True
        Me.rbPOSITION.Text = "POSITION:"
        Me.rbPOSITION.UseVisualStyleBackColor = True
        '
        'wfMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 520)
        Me.Controls.Add(Me.GroupBoxParametro)
        Me.Controls.Add(Me.GroupBoxBoton)
        Me.Controls.Add(Me.CheckBoxAll)
        Me.Controls.Add(Me.clbArquivos)
        Me.Controls.Add(Me.DataGridTabela)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "wfMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loader"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridTabela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBoxBoton.ResumeLayout(False)
        CType(Me.bsCargaTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxParametro.ResumeLayout(False)
        Me.GroupBoxParametro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtError As System.Windows.Forms.TextBox
    Friend WithEvents txtDelimitador As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtTnsNames As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInfile As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbIntoTable As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDataBase As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridTabela As System.Windows.Forms.DataGridView
    Friend WithEvents clbArquivos As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnTnsNames As System.Windows.Forms.Button
    Friend WithEvents btnInfile As System.Windows.Forms.Button
    Friend WithEvents ofdTNSNAMES As System.Windows.Forms.OpenFileDialog
    Friend WithEvents fbdDiretorio As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents CheckBoxAll As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SpoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBoxBoton As System.Windows.Forms.GroupBox
    Friend WithEvents btnCarrega As System.Windows.Forms.Button
    Friend WithEvents bsCargaTables As System.Windows.Forms.BindingSource
    Friend WithEvents LogDeErroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRows As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxParametro As System.Windows.Forms.GroupBox
    Friend WithEvents rdFieldsTerminated As System.Windows.Forms.RadioButton
    Friend WithEvents rbPOSITION As System.Windows.Forms.RadioButton

End Class
