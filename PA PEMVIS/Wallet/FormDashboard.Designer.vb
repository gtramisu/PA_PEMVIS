<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnTopUp = New System.Windows.Forms.Button()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvRiwayat = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTtlTopup = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblTtlTransfer = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTtlTransaksi = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.SystemColors.Control
        Me.pnlSidebar.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_2_pemvis3
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnTopUp)
        Me.pnlSidebar.Controls.Add(Me.btnTransfer)
        Me.pnlSidebar.Controls.Add(Me.Label4)
        Me.pnlSidebar.Controls.Add(Me.lblSaldo)
        Me.pnlSidebar.Location = New System.Drawing.Point(34, 120)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(257, 352)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogout.Location = New System.Drawing.Point(15, 102)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(226, 35)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "⌫ Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnTopUp
        '
        Me.btnTopUp.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnTopUp.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTopUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTopUp.Location = New System.Drawing.Point(15, 20)
        Me.btnTopUp.Name = "btnTopUp"
        Me.btnTopUp.Size = New System.Drawing.Size(226, 35)
        Me.btnTopUp.TabIndex = 2
        Me.btnTopUp.Text = "✙ Top Up Saldo"
        Me.btnTopUp.UseVisualStyleBackColor = False
        '
        'btnTransfer
        '
        Me.btnTransfer.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnTransfer.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.Location = New System.Drawing.Point(15, 61)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(226, 35)
        Me.btnTransfer.TabIndex = 3
        Me.btnTransfer.Text = "⌯⌲ Transfer Saldo"
        Me.btnTransfer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label1.Location = New System.Drawing.Point(326, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(513, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DashboardFlowPay E-Wallet"
        '
        'dgvRiwayat
        '
        Me.dgvRiwayat.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRiwayat.Location = New System.Drawing.Point(327, 373)
        Me.dgvRiwayat.Name = "dgvRiwayat"
        Me.dgvRiwayat.RowHeadersWidth = 51
        Me.dgvRiwayat.RowTemplate.Height = 24
        Me.dgvRiwayat.Size = New System.Drawing.Size(561, 196)
        Me.dgvRiwayat.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(322, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Riwayat Terakhir"
        '
        'lblJam
        '
        Me.lblJam.AutoSize = True
        Me.lblJam.BackColor = System.Drawing.Color.Transparent
        Me.lblJam.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJam.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblJam.Location = New System.Drawing.Point(38, 546)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(59, 23)
        Me.lblJam.TabIndex = 6
        Me.lblJam.Text = "Waktu"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSaldo.Location = New System.Drawing.Point(11, 316)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(52, 23)
        Me.lblSaldo.TabIndex = 43
        Me.lblSaldo.Text = "Saldo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(337, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 23)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Selamat datang kembali,"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUsername.Location = New System.Drawing.Point(531, 82)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(44, 23)
        Me.lblUsername.TabIndex = 45
        Me.lblUsername.Text = "User"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Wallet.My.Resources.Resources.logo3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(34, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 73)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_2_pemvis4
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(327, 235)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 107)
        Me.Panel1.TabIndex = 48
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(279, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(266, 35)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "➤ Transfer Saldo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(7, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(266, 35)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "✚ Top Up Saldo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(3, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 25)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Menu Cepat"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_saldo_anda
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(327, 129)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(169, 100)
        Me.Panel2.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(1, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 25)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Saldo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(3, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Saldo Anda"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_2_pemvis5
        Me.Panel3.Controls.Add(Me.lblTtlTopup)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(502, 129)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(98, 100)
        Me.Panel3.TabIndex = 50
        '
        'lblTtlTopup
        '
        Me.lblTtlTopup.AutoSize = True
        Me.lblTtlTopup.BackColor = System.Drawing.Color.Transparent
        Me.lblTtlTopup.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTtlTopup.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTtlTopup.Location = New System.Drawing.Point(-1, 61)
        Me.lblTtlTopup.Name = "lblTtlTopup"
        Me.lblTtlTopup.Size = New System.Drawing.Size(52, 23)
        Me.lblTtlTopup.TabIndex = 52
        Me.lblTtlTopup.Text = "Saldo"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Wallet.My.Resources.Resources.tup1
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox3.TabIndex = 53
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(3, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 12)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Top Up"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Wallet.My.Resources.Resources.trnsks
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_2_pemvis7
        Me.Panel4.Controls.Add(Me.lblTtlTransfer)
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Location = New System.Drawing.Point(606, 129)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(98, 100)
        Me.Panel4.TabIndex = 51
        '
        'lblTtlTransfer
        '
        Me.lblTtlTransfer.AutoSize = True
        Me.lblTtlTransfer.BackColor = System.Drawing.Color.Transparent
        Me.lblTtlTransfer.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTtlTransfer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTtlTransfer.Location = New System.Drawing.Point(-1, 61)
        Me.lblTtlTransfer.Name = "lblTtlTransfer"
        Me.lblTtlTransfer.Size = New System.Drawing.Size(52, 23)
        Me.lblTtlTransfer.TabIndex = 54
        Me.lblTtlTransfer.Text = "Saldo"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.Wallet.My.Resources.Resources.tf
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox4.TabIndex = 53
        Me.PictureBox4.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(1, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 12)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total Transfer"
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_2_pemvis6
        Me.Panel5.Controls.Add(Me.lblTtlTransaksi)
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Location = New System.Drawing.Point(710, 129)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(98, 100)
        Me.Panel5.TabIndex = 51
        '
        'lblTtlTransaksi
        '
        Me.lblTtlTransaksi.AutoSize = True
        Me.lblTtlTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.lblTtlTransaksi.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTtlTransaksi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTtlTransaksi.Location = New System.Drawing.Point(-1, 61)
        Me.lblTtlTransaksi.Name = "lblTtlTransaksi"
        Me.lblTtlTransaksi.Size = New System.Drawing.Size(52, 23)
        Me.lblTtlTransaksi.TabIndex = 55
        Me.lblTtlTransaksi.Text = "Saldo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(3, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 12)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Total Transaksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label4.Location = New System.Drawing.Point(75, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 23)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Saldo Anda"
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_dashboard
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(916, 593)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblJam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvRiwayat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormDashboard"
        Me.Text = "FormDashboard"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTopUp As Button
    Friend WithEvents btnTransfer As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents dgvRiwayat As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblTtlTopup As Label
    Friend WithEvents lblTtlTransfer As Label
    Friend WithEvents lblTtlTransaksi As Label
    Friend WithEvents Label4 As Label
End Class
