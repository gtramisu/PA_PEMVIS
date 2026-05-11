<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTopUp
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.btn100K = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCatatan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNominal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn50K = New System.Windows.Forms.Button()
        Me.btn200K = New System.Windows.Forms.Button()
        Me.cmbMetode = New System.Windows.Forms.ComboBox()
        Me.btnTopUp = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.dgvRiwayat = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(660, 73)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "TOP UP SALDO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(24, 88)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(55, 23)
        Me.lblSaldo.TabIndex = 42
        Me.lblSaldo.Text = "Saldo"
        '
        'btn100K
        '
        Me.btn100K.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn100K.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn100K.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn100K.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn100K.Location = New System.Drawing.Point(273, 248)
        Me.btn100K.Name = "btn100K"
        Me.btn100K.Size = New System.Drawing.Size(113, 31)
        Me.btn100K.TabIndex = 31
        Me.btn100K.Text = "100.000"
        Me.btn100K.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(236, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 23)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Pilih Nominal Cepat"
        '
        'txtCatatan
        '
        Me.txtCatatan.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtCatatan.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatatan.Location = New System.Drawing.Point(69, 397)
        Me.txtCatatan.Multiline = True
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.ReadOnly = True
        Me.txtCatatan.Size = New System.Drawing.Size(506, 38)
        Me.txtCatatan.TabIndex = 29
        Me.txtCatatan.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(236, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Metode Pembayaran"
        '
        'txtNominal
        '
        Me.txtNominal.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNominal.Location = New System.Drawing.Point(198, 320)
        Me.txtNominal.Multiline = True
        Me.txtNominal.Name = "txtNominal"
        Me.txtNominal.ReadOnly = True
        Me.txtNominal.Size = New System.Drawing.Size(250, 35)
        Me.txtNominal.TabIndex = 28
        Me.txtNominal.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(242, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 23)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Masukkan Nominal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(295, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Catatan"
        '
        'btn50K
        '
        Me.btn50K.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn50K.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50K.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn50K.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn50K.Location = New System.Drawing.Point(128, 248)
        Me.btn50K.Name = "btn50K"
        Me.btn50K.Size = New System.Drawing.Size(108, 31)
        Me.btn50K.TabIndex = 38
        Me.btn50K.Text = "50.000"
        Me.btn50K.UseVisualStyleBackColor = False
        '
        'btn200K
        '
        Me.btn200K.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn200K.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn200K.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200K.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn200K.Location = New System.Drawing.Point(428, 248)
        Me.btn200K.Name = "btn200K"
        Me.btn200K.Size = New System.Drawing.Size(100, 31)
        Me.btn200K.TabIndex = 39
        Me.btn200K.Text = "200.000"
        Me.btn200K.UseVisualStyleBackColor = False
        '
        'cmbMetode
        '
        Me.cmbMetode.FormattingEnabled = True
        Me.cmbMetode.Location = New System.Drawing.Point(218, 162)
        Me.cmbMetode.Name = "cmbMetode"
        Me.cmbMetode.Size = New System.Drawing.Size(214, 24)
        Me.cmbMetode.TabIndex = 38
        '
        'btnTopUp
        '
        Me.btnTopUp.BackColor = System.Drawing.Color.SteelBlue
        Me.btnTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTopUp.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTopUp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTopUp.Location = New System.Drawing.Point(325, 456)
        Me.btnTopUp.Name = "btnTopUp"
        Me.btnTopUp.Size = New System.Drawing.Size(250, 40)
        Me.btnTopUp.TabIndex = 41
        Me.btnTopUp.Text = "Top Up"
        Me.btnTopUp.UseVisualStyleBackColor = False
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKembali.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnKembali.Location = New System.Drawing.Point(69, 456)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(250, 40)
        Me.btnKembali.TabIndex = 40
        Me.btnKembali.Text = "Back"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(250, 523)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 23)
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
        'dgvRiwayat
        '
        Me.dgvRiwayat.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRiwayat.Location = New System.Drawing.Point(69, 571)
        Me.dgvRiwayat.Name = "dgvRiwayat"
        Me.dgvRiwayat.RowHeadersWidth = 51
        Me.dgvRiwayat.RowTemplate.Height = 24
        Me.dgvRiwayat.Size = New System.Drawing.Size(525, 146)
        Me.dgvRiwayat.TabIndex = 36
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 748)
        Me.Panel1.TabIndex = 20
        '
        'FormTopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(665, 748)
        Me.Controls.Add(Me.lblJam)
        Me.Controls.Add(Me.dgvRiwayat)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.btnTopUp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btn200K)
        Me.Controls.Add(Me.cmbMetode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCatatan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNominal)
        Me.Controls.Add(Me.btn50K)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn100K)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormTopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn100K As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCatatan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNominal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn200K As Button
    Friend WithEvents btn50K As Button
    Friend WithEvents cmbMetode As ComboBox
    Friend WithEvents btnTopUp As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents lblSaldo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents dgvRiwayat As DataGridView
    Friend WithEvents Panel1 As Panel
End Class
