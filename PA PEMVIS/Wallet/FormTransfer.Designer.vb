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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvTransfer = New System.Windows.Forms.DataGridView()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.txtNominalTransfer = New System.Windows.Forms.TextBox()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNamaPenerima = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNoTujuan = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCatatan = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblSaldoanda = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.dgvTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(56, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 25)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "setelah berhasil"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(240, 422)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 23)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "Nominal lain"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(228, 340)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 20)
        Me.Label16.TabIndex = 68
        Me.Label16.Text = "Pilih nominal cepat"
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.MidnightBlue
        Me.pnlSidebar.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_saldo_anda
        Me.pnlSidebar.Controls.Add(Me.Label6)
        Me.pnlSidebar.Controls.Add(Me.Label13)
        Me.pnlSidebar.Controls.Add(Me.Label11)
        Me.pnlSidebar.Controls.Add(Me.Label10)
        Me.pnlSidebar.Controls.Add(Me.Label9)
        Me.pnlSidebar.Controls.Add(Me.Label8)
        Me.pnlSidebar.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSidebar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.pnlSidebar.Location = New System.Drawing.Point(585, 147)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(372, 255)
        Me.pnlSidebar.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(32, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "3. Minimal transfer Rp10.000"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(32, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(287, 25)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "2. Transfer tidak dapat dibatalkan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label10.Location = New System.Drawing.Point(33, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 19)
        Me.Label10.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(32, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(323, 25)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "1. Pastikan nomor tujuan sudah benar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(12, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(270, 31)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "˗ˋˏ$ˎˊ˗ Informasi Transfer"
        '
        'dgvTransfer
        '
        Me.dgvTransfer.AllowUserToAddRows = False
        Me.dgvTransfer.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransfer.Location = New System.Drawing.Point(585, 478)
        Me.dgvTransfer.Name = "dgvTransfer"
        Me.dgvTransfer.RowHeadersWidth = 51
        Me.dgvTransfer.RowTemplate.Height = 24
        Me.dgvTransfer.Size = New System.Drawing.Size(372, 221)
        Me.dgvTransfer.TabIndex = 59
        '
        'btnTransfer
        '
        Me.btnTransfer.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransfer.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTransfer.Location = New System.Drawing.Point(321, 663)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(195, 36)
        Me.btnTransfer.TabIndex = 64
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(705, 452)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 25)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Riwayat Transfer"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Location = New System.Drawing.Point(76, 663)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(222, 36)
        Me.btnBack.TabIndex = 63
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btn100
        '
        Me.btn100.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn100.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn100.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn100.Location = New System.Drawing.Point(414, 371)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(91, 31)
        Me.btn100.TabIndex = 62
        Me.btn100.Text = "100.000"
        Me.btn100.UseVisualStyleBackColor = False
        '
        'txtNominalTransfer
        '
        Me.txtNominalTransfer.BackColor = System.Drawing.Color.MediumPurple
        Me.txtNominalTransfer.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNominalTransfer.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNominalTransfer.Location = New System.Drawing.Point(76, 452)
        Me.txtNominalTransfer.Multiline = True
        Me.txtNominalTransfer.Name = "txtNominalTransfer"
        Me.txtNominalTransfer.Size = New System.Drawing.Size(440, 33)
        Me.txtNominalTransfer.TabIndex = 57
        Me.txtNominalTransfer.UseSystemPasswordChar = True
        '
        'btn10
        '
        Me.btn10.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn10.Location = New System.Drawing.Point(87, 371)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(76, 31)
        Me.btn10.TabIndex = 60
        Me.btn10.Text = "10.000"
        Me.btn10.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(57, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 25)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "2. Masukkan Nominal"
        '
        'btn50
        '
        Me.btn50.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn50.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn50.Location = New System.Drawing.Point(257, 371)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(78, 31)
        Me.btn50.TabIndex = 58
        Me.btn50.Text = "50.000"
        Me.btn50.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(56, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 25)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "1. Informasi Penerima"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(186, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 53
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 718)
        Me.Panel1.TabIndex = 51
        '
        'txtNamaPenerima
        '
        Me.txtNamaPenerima.BackColor = System.Drawing.Color.MediumPurple
        Me.txtNamaPenerima.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPenerima.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNamaPenerima.Location = New System.Drawing.Point(76, 278)
        Me.txtNamaPenerima.Multiline = True
        Me.txtNamaPenerima.Name = "txtNamaPenerima"
        Me.txtNamaPenerima.Size = New System.Drawing.Size(429, 33)
        Me.txtNamaPenerima.TabIndex = 74
        Me.txtNamaPenerima.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(72, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 23)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Nama Penerima"
        '
        'txtNoTujuan
        '
        Me.txtNoTujuan.BackColor = System.Drawing.Color.MediumPurple
        Me.txtNoTujuan.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoTujuan.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNoTujuan.Location = New System.Drawing.Point(76, 206)
        Me.txtNoTujuan.Multiline = True
        Me.txtNoTujuan.Name = "txtNoTujuan"
        Me.txtNoTujuan.Size = New System.Drawing.Size(429, 33)
        Me.txtNoTujuan.TabIndex = 75
        Me.txtNoTujuan.UseSystemPasswordChar = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(228, 500)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(149, 23)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Catatan(Opsional)"
        '
        'txtCatatan
        '
        Me.txtCatatan.BackColor = System.Drawing.Color.MediumPurple
        Me.txtCatatan.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatatan.Location = New System.Drawing.Point(76, 537)
        Me.txtCatatan.Multiline = True
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.Size = New System.Drawing.Size(440, 33)
        Me.txtCatatan.TabIndex = 76
        Me.txtCatatan.UseSystemPasswordChar = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.MediumPurple
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Location = New System.Drawing.Point(76, 613)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(440, 33)
        Me.txtPassword.TabIndex = 79
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(57, 585)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(204, 25)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "3. Masukkan Password"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(72, 180)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 23)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "Nomor HP Tujuan"
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel4.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_saldo_anda
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Location = New System.Drawing.Point(-5, -1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(989, 122)
        Me.Panel4.TabIndex = 81
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Wallet.My.Resources.Resources.logo3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(25, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 88)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.lblSaldoanda)
        Me.Panel5.Controls.Add(Me.lblSaldo)
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel5.Location = New System.Drawing.Point(719, 29)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(231, 60)
        Me.Panel5.TabIndex = 50
        '
        'lblSaldoanda
        '
        Me.lblSaldoanda.AutoSize = True
        Me.lblSaldoanda.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldoanda.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoanda.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSaldoanda.Location = New System.Drawing.Point(11, 0)
        Me.lblSaldoanda.Name = "lblSaldoanda"
        Me.lblSaldoanda.Size = New System.Drawing.Size(109, 25)
        Me.lblSaldoanda.TabIndex = 43
        Me.lblSaldoanda.Text = "Saldo Anda"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSaldo.Location = New System.Drawing.Point(11, 24)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(17, 23)
        Me.lblSaldo.TabIndex = 42
        Me.lblSaldo.Text = "-"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(125, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 32)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Kirim saldo ke pengguna FlowPay lain"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label18.Location = New System.Drawing.Point(118, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(303, 45)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "TRANSFER SALDO"
        '
        'FormTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_dashboard
        Me.ClientSize = New System.Drawing.Size(984, 718)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCatatan)
        Me.Controls.Add(Me.txtNoTujuan)
        Me.Controls.Add(Me.txtNamaPenerima)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.dgvTransfer)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.txtNominalTransfer)
        Me.Controls.Add(Me.btn10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTransfer"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        CType(Me.dgvTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvTransfer As DataGridView
    Friend WithEvents btnTransfer As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents txtNominalTransfer As TextBox
    Friend WithEvents btn10 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btn100 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNamaPenerima As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNoTujuan As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCatatan As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblSaldoanda As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
End Class
