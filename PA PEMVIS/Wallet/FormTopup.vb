Imports System.Security.Cryptography

Public Class FormTopup

    Private Sub FormTopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' tampil saldo
        lblSaldo.Text = "Rp " & saldo.ToString("N0")

        ' isi combobox pembayaran
        cmbPembayaran.Items.Add("Indomaret")
        cmbPembayaran.Items.Add("Alfamidi")

        ' setting datagridview
        dgvTopup.ColumnCount = 4

        dgvTopup.Columns(0).Name = "Tanggal"
        dgvTopup.Columns(1).Name = "Pembayaran"
        dgvTopup.Columns(2).Name = "Nominal"
        dgvTopup.Columns(3).Name = "Status"

    End Sub

    ' NOMINAL CEPAT

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        txtNominal.Text = "50000"
    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        txtNominal.Text = "100000"
    End Sub

    Private Sub btn200_Click(sender As Object, e As EventArgs) Handles btn200.Click
        txtNominal.Text = "200000"
    End Sub

    ' BUTTON TOP UP

    Private Sub btnTopup_Click(sender As Object, e As EventArgs) Handles btnTopUp.Click

        If cmbPembayaran.Text = "" Then
            MessageBox.Show("Pilih tempat pembayaran!")
            Exit Sub
        End If

        If txtNominal.Text = "" Then
            MessageBox.Show("Masukkan nominal!")
            Exit Sub
        End If

        Dim nominal As Integer
        nominal = Val(txtNominal.Text)

        If nominal < 10000 Then
            MessageBox.Show("Minimal top up Rp10.000")
            Exit Sub
        End If

        ' tambah saldo
        saldo += nominal

        ' update saldo
        lblSaldo.Text = "Rp " & saldo.ToString("N0")

        ' tambah riwayat
        dgvTopup.Rows.Add(
            Date.Now.ToString("dd/MM/yyyy HH:mm"),
            cmbPembayaran.Text,
            "Rp " & nominal.ToString("N0"),
            "Berhasil"
        )

        MessageBox.Show("Top Up berhasil!")

        ' clear
        txtNominal.Clear()
        cmbPembayaran.SelectedIndex = -1

    End Sub

    ' BUTTON BACK

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        FormDashboard.Show()
        Me.Hide()

    End Sub

    Private Sub txtNominal_TextChanged(sender As Object, e As EventArgs) Handles txtNominal.TextChanged

    End Sub

    Private Sub txtKode_TextChanged(sender As Object, e As EventArgs) Handles txtKode.TextChanged

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub
End Class