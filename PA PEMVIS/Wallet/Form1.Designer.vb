<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selamat Datang (˶ᵔᗜᵔ˶)ﾉﾞ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "👤Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "🔒︎Password"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.MediumPurple
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.Window
        Me.txtUsername.Location = New System.Drawing.Point(26, 136)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(426, 27)
        Me.txtUsername.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.MediumPurple
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Location = New System.Drawing.Point(26, 209)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(426, 27)
        Me.txtPassword.TabIndex = 7
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(26, 286)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(432, 40)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "➜] LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.MediumPurple
        Me.btnRegister.Location = New System.Drawing.Point(193, 382)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(140, 34)
        Me.btnRegister.TabIndex = 9
        Me.btnRegister.Text = "Daftar Sekarang"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.BackColor = System.Drawing.Color.Transparent
        Me.chkShow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShow.Location = New System.Drawing.Point(31, 243)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(140, 24)
        Me.chkShow.TabIndex = 10
        Me.chkShow.Text = "Show Password"
        Me.chkShow.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.Transparent
        Me.pnlSidebar.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_2_pemvis1
        Me.pnlSidebar.Controls.Add(Me.Label6)
        Me.pnlSidebar.Controls.Add(Me.Label5)
        Me.pnlSidebar.Controls.Add(Me.Label2)
        Me.pnlSidebar.Controls.Add(Me.Label10)
        Me.pnlSidebar.Controls.Add(Me.Label3)
        Me.pnlSidebar.Controls.Add(Me.txtUsername)
        Me.pnlSidebar.Controls.Add(Me.Label4)
        Me.pnlSidebar.Controls.Add(Me.Label1)
        Me.pnlSidebar.Controls.Add(Me.btnRegister)
        Me.pnlSidebar.Controls.Add(Me.btnLogin)
        Me.pnlSidebar.Controls.Add(Me.chkShow)
        Me.pnlSidebar.Controls.Add(Me.txtPassword)
        Me.pnlSidebar.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSidebar.ForeColor = System.Drawing.Color.Transparent
        Me.pnlSidebar.Location = New System.Drawing.Point(374, 38)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(485, 429)
        Me.pnlSidebar.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 387)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Belum punya akun?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(360, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "──────────────── atau ──────────────────"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Silahkan masuk ke akun FlowPay Anda"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label10.Location = New System.Drawing.Point(33, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 19)
        Me.Label10.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label23.Location = New System.Drawing.Point(91, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 27)
        Me.Label23.TabIndex = 67
        Me.Label23.Text = "E-WALLET"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(29, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 41)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Kelola Keuangan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label8.Location = New System.Drawing.Point(29, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 41)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Lebih Mudah"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(29, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(266, 41)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "dengan FlowPay !"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(32, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(263, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Topup, transfer, dan kelola saldo Anda"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(32, 226)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(173, 20)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "dengan aman dan cepat."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(44, 447)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(209, 20)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Aman, cepat, dan terpercaya"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(44, 467)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(324, 20)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Data Anda terlindungi dengan enskripsi terbaik."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(2, 447)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 38)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "⛨"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_pemvis
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(880, 500)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.pnlSidebar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login E-Wallet"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents chkShow As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
