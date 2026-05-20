<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTopup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTopup))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNominal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btn200 = New System.Windows.Forms.Button()
        Me.cmbPembayaran = New System.Windows.Forms.ComboBox()
        Me.btnTopUp = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.dgvTopup = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblSaldoanda = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvTopup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidebar.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(173, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 22
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
        'btn100
        '
        Me.btn100.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn100.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn100.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn100.Location = New System.Drawing.Point(231, 264)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(78, 31)
        Me.btn100.TabIndex = 31
        Me.btn100.Text = "100.000"
        Me.btn100.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(173, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "2. Masukkan Nominal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(151, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "1. Pilih Tempat Pembayaran"
        '
        'txtNominal
        '
        Me.txtNominal.BackColor = System.Drawing.Color.MediumPurple
        Me.txtNominal.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNominal.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNominal.Location = New System.Drawing.Point(110, 337)
        Me.txtNominal.Multiline = True
        Me.txtNominal.Name = "txtNominal"
        Me.txtNominal.Size = New System.Drawing.Size(325, 33)
        Me.txtNominal.TabIndex = 28
        Me.txtNominal.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(11, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 31)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "📋 Catatan"
        '
        'btn50
        '
        Me.btn50.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn50.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn50.Location = New System.Drawing.Point(123, 264)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(76, 31)
        Me.btn50.TabIndex = 38
        Me.btn50.Text = "50.000"
        Me.btn50.UseVisualStyleBackColor = False
        '
        'btn200
        '
        Me.btn200.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn200.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn200.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn200.Location = New System.Drawing.Point(335, 264)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(91, 31)
        Me.btn200.TabIndex = 39
        Me.btn200.Text = "200.000"
        Me.btn200.UseVisualStyleBackColor = False
        '
        'cmbPembayaran
        '
        Me.cmbPembayaran.BackColor = System.Drawing.Color.MediumPurple
        Me.cmbPembayaran.FormattingEnabled = True
        Me.cmbPembayaran.Location = New System.Drawing.Point(110, 163)
        Me.cmbPembayaran.Name = "cmbPembayaran"
        Me.cmbPembayaran.Size = New System.Drawing.Size(316, 24)
        Me.cmbPembayaran.TabIndex = 38
        '
        'btnTopUp
        '
        Me.btnTopUp.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTopUp.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTopUp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTopUp.Location = New System.Drawing.Point(290, 459)
        Me.btnTopUp.Name = "btnTopUp"
        Me.btnTopUp.Size = New System.Drawing.Size(145, 36)
        Me.btnTopUp.TabIndex = 41
        Me.btnTopUp.Text = "Top Up"
        Me.btnTopUp.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Location = New System.Drawing.Point(110, 459)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(145, 36)
        Me.btnBack.TabIndex = 40
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(214, 518)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 25)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Riwayat Top Up"
        '
        'lblJam
        '
        Me.lblJam.AutoSize = True
        Me.lblJam.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJam.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblJam.Location = New System.Drawing.Point(295, 720)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(60, 23)
        Me.lblJam.TabIndex = 20
        Me.lblJam.Text = "waktu"
        '
        'dgvTopup
        '
        Me.dgvTopup.AllowUserToAddRows = False
        Me.dgvTopup.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvTopup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTopup.Location = New System.Drawing.Point(49, 546)
        Me.dgvTopup.Name = "dgvTopup"
        Me.dgvTopup.RowHeadersWidth = 51
        Me.dgvTopup.RowTemplate.Height = 24
        Me.dgvTopup.Size = New System.Drawing.Size(466, 146)
        Me.dgvTopup.TabIndex = 36
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 706)
        Me.Panel1.TabIndex = 20
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.MidnightBlue
        Me.pnlSidebar.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_saldo_anda
        Me.pnlSidebar.Controls.Add(Me.Label15)
        Me.pnlSidebar.Controls.Add(Me.Label14)
        Me.pnlSidebar.Controls.Add(Me.Label13)
        Me.pnlSidebar.Controls.Add(Me.Label12)
        Me.pnlSidebar.Controls.Add(Me.Label11)
        Me.pnlSidebar.Controls.Add(Me.Label10)
        Me.pnlSidebar.Controls.Add(Me.Label9)
        Me.pnlSidebar.Controls.Add(Me.Label8)
        Me.pnlSidebar.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSidebar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.pnlSidebar.Location = New System.Drawing.Point(575, 130)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(372, 336)
        Me.pnlSidebar.TabIndex = 43
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label15.Location = New System.Drawing.Point(33, 289)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(356, 32)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "pembayaran berhasil"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label14.Location = New System.Drawing.Point(33, 266)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(356, 32)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Saldo akan otomatis bertambah setelah"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label13.Location = New System.Drawing.Point(13, 234)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(173, 25)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "3. Saldo Bertambah"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label12.Location = New System.Drawing.Point(33, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(303, 20)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Sampaikan ke kasir bahwa ingin top up Cash"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label11.Location = New System.Drawing.Point(13, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(204, 25)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "2. Lakukan Pembayaran"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label10.Location = New System.Drawing.Point(33, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(265, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Pilih Indomaret atau Alfamidi Terdekat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label9.Location = New System.Drawing.Point(13, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(236, 25)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "1. Pilih Tempat Pembayaran"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(12, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(266, 31)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "˗ˋˏ$ˎˊ˗ Informasi Top Up "
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
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_saldo_anda
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(575, 508)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 146)
        Me.Panel3.TabIndex = 45
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label18.Location = New System.Drawing.Point(13, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(356, 32)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "Simpan struk pembayaran Anda"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label19.Location = New System.Drawing.Point(13, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(356, 32)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Minimal top up Rp10.000"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(208, 226)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 20)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Pilih nominal cepat"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(226, 309)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 23)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Nominal lain"
        '
        'txtKode
        '
        Me.txtKode.BackColor = System.Drawing.Color.MediumPurple
        Me.txtKode.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKode.ForeColor = System.Drawing.SystemColors.Window
        Me.txtKode.Location = New System.Drawing.Point(110, 417)
        Me.txtKode.Multiline = True
        Me.txtKode.Name = "txtKode"
        Me.txtKode.ReadOnly = True
        Me.txtKode.Size = New System.Drawing.Size(325, 33)
        Me.txtKode.TabIndex = 48
        Me.txtKode.UseSystemPasswordChar = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(254, 389)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 23)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Kode"
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel4.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_saldo_anda
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Location = New System.Drawing.Point(-3, -2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(980, 113)
        Me.Panel4.TabIndex = 50
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label21.Location = New System.Drawing.Point(125, 57)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(187, 32)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "Isi Saldo FlowPay anda"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label22.Location = New System.Drawing.Point(118, 11)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(253, 45)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "TOP UP SALDO"
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
        'FormTopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(966, 706)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.lblJam)
        Me.Controls.Add(Me.dgvTopup)
        Me.Controls.Add(Me.btnTopUp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btn200)
        Me.Controls.Add(Me.cmbPembayaran)
        Me.Controls.Add(Me.txtNominal)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Name = "FormTopup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.dgvTopup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btn100 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNominal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn200 As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents cmbPembayaran As ComboBox
    Friend WithEvents btnTopUp As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblSaldo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents dgvTopup As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblSaldoanda As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
