Public Class FormRegister

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPassword.PasswordChar = "*"
        txtConfirm.PasswordChar = "*"

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged

        If chkShow.Checked Then

            txtPassword.PasswordChar = ""
            txtConfirm.PasswordChar = ""

        Else

            txtPassword.PasswordChar = "*"
            txtConfirm.PasswordChar = "*"

        End If

    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click

        If txtUsername.Text = "" Or
           txtPassword.Text = "" Or
           txtConfirm.Text = "" Or
           cmbRole.Text = "" Then

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

        MessageBox.Show("Register berhasil!",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirm.Clear()
        cmbRole.SelectedIndex = -1

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

    Private Sub lblJam_Click(sender As Object, e As EventArgs) Handles lblJam.Click

    End Sub
End Class