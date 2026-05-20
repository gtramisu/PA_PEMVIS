Public Class FormRegister

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPassword.PasswordChar = "●"
        txtConfirm.PasswordChar = "●"

        ProgressBar1.Value = 0
        lblStatus.Text = ""

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged

        If chkShow.Checked Then

            txtPassword.PasswordChar = ""
            txtConfirm.PasswordChar = ""

        Else

            txtPassword.PasswordChar = "●"
            txtConfirm.PasswordChar = "●"

        End If

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        Dim panjang As Integer = txtPassword.TextLength

        If panjang = 0 Then

            ProgressBar1.Value = 0
            lblStatus.Text = ""

        ElseIf panjang <= 4 Then

            ProgressBar1.Value = 25
            lblStatus.Text = "Lemah"
            lblStatus.ForeColor = Color.Red

        ElseIf panjang <= 7 Then

            ProgressBar1.Value = 60
            lblStatus.Text = "Sedang"
            lblStatus.ForeColor = Color.Orange

        Else

            ProgressBar1.Value = 100
            lblStatus.Text = "Kuat"
            lblStatus.ForeColor = Color.Lime

        End If

    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click

        If txtUsername.Text = "" Or
           txtPassword.Text = "" Or
           txtConfirm.Text = "" Or
           txtNohp.Text = "" Then

            MessageBox.Show("Data belum lengkap!",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Exit Sub

        End If

        If txtPassword.Text <> txtConfirm.Text Then

            MessageBox.Show("Password tidak sama!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

            Exit Sub

        End If

        If chkSetuju.Checked = False Then

            MessageBox.Show("Anda harus menyetujui syarat & ketentuan!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Exit Sub

        End If

        MessageBox.Show("Register berhasil!",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirm.Clear()
        txtNohp.Clear()

        ProgressBar1.Value = 0
        lblStatus.Text = ""

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        FormLogin.Show()
        Me.Hide()

    End Sub

    Private Sub btnDaftar_MouseHover(sender As Object, e As EventArgs) Handles btnDaftar.MouseHover

        btnDaftar.BackColor = Color.RoyalBlue

    End Sub

    Private Sub btnDaftar_MouseLeave(sender As Object, e As EventArgs) Handles btnDaftar.MouseLeave

        btnDaftar.BackColor = Color.DodgerBlue

    End Sub

    Private Sub btnBack_MouseHover(sender As Object, e As EventArgs) Handles btnBack.MouseHover

        btnBack.BackColor = Color.MediumPurple

    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave

        btnBack.BackColor = Color.BlueViolet

    End Sub

End Class