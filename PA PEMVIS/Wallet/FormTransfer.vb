Public Class FormTransfer

    Dim saldo As Double = 500000

    Private Sub FormTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblSaldo.Text = "Saldo Saat Ini : Rp" & saldo.ToString("N0")

        cmbWallet.Items.Add("GoPay")
        cmbWallet.Items.Add("DANA")
        cmbWallet.Items.Add("OVO")
        cmbWallet.Items.Add("ShopeePay")
        cmbWallet.Items.Add("LinkAja")
        cmbWallet.Items.Add("iSaku")

        dgvTransfer.ColumnCount = 6

        dgvTransfer.Columns(0).Name = "Tanggal"
        dgvTransfer.Columns(1).Name = "E-Wallet"
        dgvTransfer.Columns(2).Name = "Nama"
        dgvTransfer.Columns(3).Name = "Nominal"
        dgvTransfer.Columns(4).Name = "Admin"
        dgvTransfer.Columns(5).Name = "Catatan"

    End Sub

    Private Sub btn10K_Click(sender As Object, e As EventArgs) Handles btn10K.Click

        txtNominal.Text = "10000"

    End Sub

    Private Sub btn50K_Click(sender As Object, e As EventArgs) Handles btn50K.Click

        txtNominal.Text = "50000"

    End Sub

    Private Sub btn100K_Click(sender As Object, e As EventArgs) Handles btn100K.Click

        txtNominal.Text = "100000"

    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click

        If cmbWallet.Text = "" Or
           txtNama.Text = "" Or
           txtNomor.Text = "" Or
           txtNominal.Text = "" Then

            MessageBox.Show("Data transfer belum lengkap!",
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

        Dim adminFee As Double = 1000

        Dim totalTransfer As Double

        totalTransfer = nominal + adminFee

        If totalTransfer > saldo Then

            MessageBox.Show("Saldo tidak mencukupi!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

            Exit Sub

        End If

        saldo -= totalTransfer

        lblSaldo.Text =
            "Saldo Saat Ini : Rp" &
            saldo.ToString("N0")

        dgvTransfer.Rows.Add(
            DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
            cmbWallet.Text,
            txtNama.Text,
            "Rp" & nominal.ToString("N0"),
            "Rp" & adminFee.ToString("N0"),
            txtCatatan.Text
        )

        MessageBox.Show(
            "TRANSFER BERHASIL!" & vbCrLf & vbCrLf &
            "Tujuan : " & txtNama.Text & vbCrLf &
            "E-Wallet : " & cmbWallet.Text & vbCrLf &
            "Nominal : Rp" & nominal.ToString("N0") & vbCrLf &
            "Biaya Admin : Rp" & adminFee.ToString("N0") & vbCrLf &
            "Sisa Saldo : Rp" & saldo.ToString("N0"),
            "Informasi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

        txtNama.Clear()
        txtNomor.Clear()
        txtNominal.Clear()
        txtCatatan.Clear()

        cmbWallet.SelectedIndex = -1

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click

        FormTopUp.Show()
        Me.Hide()

    End Sub

End Class