Public Class FormTopUp

    Dim saldo As Double = 0

    Private Sub FormTopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblSaldo.Text = "Saldo Saat Ini : Rp0"

        cmbMetode.Items.Add("GoPay")
        cmbMetode.Items.Add("DANA")
        cmbMetode.Items.Add("OVO")
        cmbMetode.Items.Add("ShopeePay")
        cmbMetode.Items.Add("LinkAja")
        cmbMetode.Items.Add("iSaku")
        cmbMetode.Items.Add("TapCash BNI")
        cmbMetode.Items.Add("QRIS")
        cmbMetode.Items.Add("Virtual Account")
        cmbMetode.Items.Add("Alfamart / Indomaret")

        dgvRiwayat.ColumnCount = 5

        dgvRiwayat.Columns(0).Name = "Tanggal"
        dgvRiwayat.Columns(1).Name = "Metode"
        dgvRiwayat.Columns(2).Name = "Nominal"
        dgvRiwayat.Columns(3).Name = "Admin"
        dgvRiwayat.Columns(4).Name = "Catatan"

    End Sub

    Private Sub btn50K_Click(sender As Object, e As EventArgs) Handles btn50K.Click

        txtNominal.Text = "50000"

    End Sub

    Private Sub btn100K_Click(sender As Object, e As EventArgs) Handles btn100K.Click

        txtNominal.Text = "100000"

    End Sub

    Private Sub btn200K_Click(sender As Object, e As EventArgs) Handles btn200K.Click

        txtNominal.Text = "200000"

    End Sub

    Private Sub btnTopUp_Click(sender As Object, e As EventArgs) Handles btnTopUp.Click

        If cmbMetode.Text = "" Then

            MessageBox.Show("Pilih metode pembayaran terlebih dahulu!",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Exit Sub

        End If

        If txtNominal.Text = "" Then

            MessageBox.Show("Nominal top up belum diisi!",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Exit Sub

        End If

        Dim nominal As Double

        nominal = Val(txtNominal.Text)

        If nominal <= 0 Then

            MessageBox.Show("Nominal tidak valid!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

            Exit Sub

        End If

        Dim adminFee As Double = 0
        Dim totalBayar As Double = 0

        If cmbMetode.Text = "GoPay" Then

            adminFee = 1000

        ElseIf cmbMetode.Text = "DANA" Then

            adminFee = 1000

        ElseIf cmbMetode.Text = "OVO" Then

            adminFee = 1500

        ElseIf cmbMetode.Text = "ShopeePay" Then

            adminFee = 1000

        ElseIf cmbMetode.Text = "LinkAja" Then

            adminFee = 2000

        ElseIf cmbMetode.Text = "iSaku" Then

            adminFee = 2000

        ElseIf cmbMetode.Text = "TapCash BNI" Then

            adminFee = 2500

        ElseIf cmbMetode.Text = "QRIS" Then

            adminFee = 500

        ElseIf cmbMetode.Text = "Virtual Account" Then

            adminFee = 3000

        ElseIf cmbMetode.Text = "Alfamart / Indomaret" Then

            adminFee = 3500

        End If

        totalBayar = nominal + adminFee

        saldo += nominal

        lblSaldo.Text =
            "Saldo Saat Ini : Rp" &
            saldo.ToString("N0")

        dgvRiwayat.Rows.Add(
            DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
            cmbMetode.Text,
            "Rp" & nominal.ToString("N0"),
            "Rp" & adminFee.ToString("N0"),
            txtCatatan.Text
        )

        MessageBox.Show(
            "TOP UP BERHASIL!" & vbCrLf & vbCrLf &
            "Metode : " & cmbMetode.Text & vbCrLf &
            "Nominal : Rp" & nominal.ToString("N0") & vbCrLf &
            "Biaya Admin : Rp" & adminFee.ToString("N0") & vbCrLf &
            "Total Bayar : Rp" & totalBayar.ToString("N0"),
            "Informasi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

        FormTransfer.Show()
        Me.Hide()

        txtNominal.Clear()
        txtCatatan.Clear()
        cmbMetode.SelectedIndex = -1

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click

        FormLogin.Show()
        Me.Hide()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class