<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransfer
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
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbWallet = New System.Windows.Forms.ComboBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNomor = New System.Windows.Forms.TextBox()
        Me.txtNominal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn100K = New System.Windows.Forms.Button()
        Me.btn10K = New System.Windows.Forms.Button()
        Me.btn50K = New System.Windows.Forms.Button()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCatatan = New System.Windows.Forms.TextBox()
        Me.dgvTransfer = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgvTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(16, 65)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(55, 23)
        Me.lblSaldo.TabIndex = 61
        Me.lblSaldo.Text = "Saldo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(225, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 23)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Pilih E-Wallet Tujuan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(-4, -13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(660, 73)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "TRANSFER SALDO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 728)
        Me.Panel1.TabIndex = 44
        '
        'cmbWallet
        '
        Me.cmbWallet.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cmbWallet.FormattingEnabled = True
        Me.cmbWallet.Location = New System.Drawing.Point(241, 132)
        Me.cmbWallet.Name = "cmbWallet"
        Me.cmbWallet.Size = New System.Drawing.Size(141, 24)
        Me.cmbWallet.TabIndex = 62
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(20, 197)
        Me.txtNama.Multiline = True
        Me.txtNama.Name = "txtNama"
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(250, 35)
        Me.txtNama.TabIndex = 63
        Me.txtNama.UseSystemPasswordChar = True
        '
        'txtNomor
        '
        Me.txtNomor.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomor.Location = New System.Drawing.Point(370, 197)
        Me.txtNomor.Multiline = True
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.ReadOnly = True
        Me.txtNomor.Size = New System.Drawing.Size(250, 35)
        Me.txtNomor.TabIndex = 64
        Me.txtNomor.UseSystemPasswordChar = True
        '
        'txtNominal
        '
        Me.txtNominal.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNominal.Location = New System.Drawing.Point(191, 360)
        Me.txtNominal.Multiline = True
        Me.txtNominal.Name = "txtNominal"
        Me.txtNominal.ReadOnly = True
        Me.txtNominal.Size = New System.Drawing.Size(250, 35)
        Me.txtNominal.TabIndex = 65
        Me.txtNominal.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 23)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Masukkan Nama Penerima"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(393, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 23)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Masukkan Nomor Tujuan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(230, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 23)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Pilih Nominal Cepat" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(227, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 23)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Masukkan Nominal" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn100K
        '
        Me.btn100K.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn100K.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn100K.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn100K.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn100K.Location = New System.Drawing.Point(413, 285)
        Me.btn100K.Name = "btn100K"
        Me.btn100K.Size = New System.Drawing.Size(100, 31)
        Me.btn100K.TabIndex = 73
        Me.btn100K.Text = "100.000"
        Me.btn100K.UseVisualStyleBackColor = False
        '
        'btn10K
        '
        Me.btn10K.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn10K.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10K.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn10K.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn10K.Location = New System.Drawing.Point(113, 285)
        Me.btn10K.Name = "btn10K"
        Me.btn10K.Size = New System.Drawing.Size(108, 31)
        Me.btn10K.TabIndex = 72
        Me.btn10K.Text = "10.000"
        Me.btn10K.UseVisualStyleBackColor = False
        '
        'btn50K
        '
        Me.btn50K.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn50K.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50K.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn50K.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn50K.Location = New System.Drawing.Point(258, 285)
        Me.btn50K.Name = "btn50K"
        Me.btn50K.Size = New System.Drawing.Size(113, 31)
        Me.btn50K.TabIndex = 71
        Me.btn50K.Text = "50.000"
        Me.btn50K.UseVisualStyleBackColor = False
        '
        'btnTransfer
        '
        Me.btnTransfer.BackColor = System.Drawing.Color.SteelBlue
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransfer.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTransfer.Location = New System.Drawing.Point(312, 484)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(250, 40)
        Me.btnTransfer.TabIndex = 77
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = False
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKembali.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnKembali.Location = New System.Drawing.Point(56, 484)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(250, 40)
        Me.btnKembali.TabIndex = 76
        Me.btnKembali.Text = "Back"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(274, 409)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 23)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Catatan"
        '
        'txtCatatan
        '
        Me.txtCatatan.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtCatatan.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatatan.Location = New System.Drawing.Point(56, 435)
        Me.txtCatatan.Multiline = True
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.ReadOnly = True
        Me.txtCatatan.Size = New System.Drawing.Size(506, 22)
        Me.txtCatatan.TabIndex = 74
        Me.txtCatatan.UseSystemPasswordChar = True
        '
        'dgvTransfer
        '
        Me.dgvTransfer.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.dgvTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransfer.Location = New System.Drawing.Point(65, 570)
        Me.dgvTransfer.Name = "dgvTransfer"
        Me.dgvTransfer.RowHeadersWidth = 51
        Me.dgvTransfer.RowTemplate.Height = 24
        Me.dgvTransfer.Size = New System.Drawing.Size(525, 146)
        Me.dgvTransfer.TabIndex = 79
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(246, 538)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 23)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Riwayat Transfer"
        '
        'FormTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(655, 728)
        Me.Controls.Add(Me.dgvTransfer)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCatatan)
        Me.Controls.Add(Me.btn100K)
        Me.Controls.Add(Me.btn10K)
        Me.Controls.Add(Me.btn50K)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNominal)
        Me.Controls.Add(Me.txtNomor)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.cmbWallet)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTransfer"
        CType(Me.dgvTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSaldo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbWallet As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents txtNominal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn100K As Button
    Friend WithEvents btn10K As Button
    Friend WithEvents btn50K As Button
    Friend WithEvents btnTransfer As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCatatan As TextBox
    Friend WithEvents dgvTransfer As DataGridView
    Friend WithEvents Label9 As Label
End Class
