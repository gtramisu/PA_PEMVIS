Public Class FormTransfer

    Private Sub FormTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' tampil saldo
        lblSaldo.Text = "Rp " & saldo.ToString("N0")

        ' setting datagridview
        dgvTransfer.ColumnCount = 4

        dgvTransfer.Columns(0).Name = "Tanggal"
        dgvTransfer.Columns(1).Name = "Penerima"
        dgvTransfer.Columns(2).Name = "Nominal"
        dgvTransfer.Columns(3).Name = "Status"

    End Sub

    ' NOMINAL CEPAT

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        txtNominalTransfer.Text = "10000"
    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        txtNominalTransfer.Text = "50000"
    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        txtNominalTransfer.Text = "100000"
    End Sub

    ' AUTO CEK PENERIMA

    Private Sub txtNoTujuan_TextChanged(sender As Object, e As EventArgs) Handles txtNoTujuan.TextChanged

        If txtNoTujuan.Text = "08123456789" Then

            txtNamaPenerima.Text = "Budi"

        ElseIf txtNoTujuan.Text = "082233445566" Then

            txtNamaPenerima.Text = "Siti"

        Else

            txtNamaPenerima.Clear()

        End If

    End Sub

    ' BUTTON TRANSFER

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click

        If txtNamaPenerima.Text = "" Then
            MessageBox.Show("Nomor tujuan tidak ditemukan!")
            Exit Sub
        End If

        If txtNominalTransfer.Text = "" Then
            MessageBox.Show("Masukkan nominal transfer!")
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MessageBox.Show("Masukkan password!")
            Exit Sub
        End If

        Dim nominal As Integer
        nominal = Val(txtNominalTransfer.Text)

        If nominal < 10000 Then
            MessageBox.Show("Minimal transfer Rp10.000")
            Exit Sub
        End If

        If nominal > saldo Then
            MessageBox.Show("Saldo tidak cukup!")
            Exit Sub
        End If

        ' kurangi saldo
        saldo -= nominal

        ' update saldo
        lblSaldo.Text = "Rp " & saldo.ToString("N0")

        ' tambah riwayat
        dgvTransfer.Rows.Add(
            Date.Now.ToString("dd/MM/yyyy HH:mm"),
            txtNamaPenerima.Text,
            "Rp " & nominal.ToString("N0"),
            "Berhasil"
        )

        MessageBox.Show("Transfer berhasil!")

        ' clear
        txtNoTujuan.Clear()
        txtNamaPenerima.Clear()
        txtNominalTransfer.Clear()
        txtCatatan.Clear()
        txtPassword.Clear()

    End Sub

    ' BUTTON BACK

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        FormDashboard.Show()
        Me.Hide()

    End Sub

    Private Sub txtNamaPenerima_TextChanged(sender As Object, e As EventArgs) Handles txtNamaPenerima.TextChanged

    End Sub
End Class