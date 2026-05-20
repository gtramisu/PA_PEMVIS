<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStruk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStruk))
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNomor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblWallet = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNominal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCatatan = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblJudul.Location = New System.Drawing.Point(227, 58)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(344, 38)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "   TRANSFER BERHASIL   "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(48, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Penerima :"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.BackColor = System.Drawing.Color.Transparent
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNama.Location = New System.Drawing.Point(200, 152)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(17, 23)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(48, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nomor Tujuan :"
        '
        'lblNomor
        '
        Me.lblNomor.AutoSize = True
        Me.lblNomor.BackColor = System.Drawing.Color.Transparent
        Me.lblNomor.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNomor.Location = New System.Drawing.Point(201, 186)
        Me.lblNomor.Name = "lblNomor"
        Me.lblNomor.Size = New System.Drawing.Size(17, 23)
        Me.lblNomor.TabIndex = 4
        Me.lblNomor.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(49, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "E-Wallet :"
        '
        'lblWallet
        '
        Me.lblWallet.AutoSize = True
        Me.lblWallet.BackColor = System.Drawing.Color.Transparent
        Me.lblWallet.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWallet.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWallet.Location = New System.Drawing.Point(200, 215)
        Me.lblWallet.Name = "lblWallet"
        Me.lblWallet.Size = New System.Drawing.Size(17, 23)
        Me.lblWallet.TabIndex = 6
        Me.lblWallet.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(49, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nominal :"
        '
        'lblNominal
        '
        Me.lblNominal.AutoSize = True
        Me.lblNominal.BackColor = System.Drawing.Color.Transparent
        Me.lblNominal.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNominal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNominal.Location = New System.Drawing.Point(200, 250)
        Me.lblNominal.Name = "lblNominal"
        Me.lblNominal.Size = New System.Drawing.Size(17, 23)
        Me.lblNominal.TabIndex = 8
        Me.lblNominal.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(49, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Catatan :"
        '
        'lblCatatan
        '
        Me.lblCatatan.AutoSize = True
        Me.lblCatatan.BackColor = System.Drawing.Color.Transparent
        Me.lblCatatan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatatan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCatatan.Location = New System.Drawing.Point(200, 288)
        Me.lblCatatan.Name = "lblCatatan"
        Me.lblCatatan.Size = New System.Drawing.Size(17, 23)
        Me.lblCatatan.TabIndex = 10
        Me.lblCatatan.Text = "-"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrint.Location = New System.Drawing.Point(442, 393)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(233, 40)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBack.Location = New System.Drawing.Point(140, 393)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(233, 40)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(34, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(743, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "---------------------------------------------------------------------------------" &
    "------------------------------------------------------------------"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(34, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(743, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "---------------------------------------------------------------------------------" &
    "------------------------------------------------------------------"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Wallet.My.Resources.Resources.logo3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(381, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 49)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'FormStruk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Wallet.My.Resources.Resources.bg_dashboard
        Me.ClientSize = New System.Drawing.Size(800, 478)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblCatatan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNominal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblWallet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNomor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblJudul)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormStruk"
        Me.Text = "FormStruk"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNomor As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblWallet As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNominal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCatatan As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
