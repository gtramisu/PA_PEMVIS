Public Class FormDashboard

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' tampil saldo
        lblSaldo.Text = "Rp " & saldo.ToString("N0")


        ' setting datagridview
        dgvRiwayat.ColumnCount = 4

        dgvRiwayat.Columns(0).Name = "Tanggal"
        dgvRiwayat.Columns(1).Name = "Jenis"
        dgvRiwayat.Columns(2).Name = "Nominal"
        dgvRiwayat.Columns(3).Name = "Status"

    End Sub

    ' TIMER JAM



    ' BUTTON TOP UP

    Private Sub btnTopup_Click(sender As Object, e As EventArgs) Handles btnTopUp.Click

        FormTopup.Show()
        Me.Hide()

    End Sub

    ' BUTTON TRANSFER

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click

        FormTransfer.Show()
        Me.Hide()

    End Sub

    ' BUTTON LOGOUT

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim hasil As DialogResult

        hasil = MessageBox.Show(
            "Yakin ingin logout?",
            "Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then

            FormLogin.Show()
            Me.Hide()

        End If

    End Sub

    ' BUTTON PROFIL

    Private Sub btnProfil_Click(sender As Object, e As EventArgs)

        MessageBox.Show(
            "Nama User : User" & vbCrLf &
            "Saldo : Rp " & saldo.ToString("N0"),
            "Profil Saya"
        )

    End Sub

    ' UPDATE SALDO SAAT FORM AKTIF

    Private Sub FormDashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        lblSaldo.Text = "Rp " & saldo.ToString("N0")

    End Sub

End Class