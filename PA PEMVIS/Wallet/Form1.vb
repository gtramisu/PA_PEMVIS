Public Class FormLogin

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPassword.PasswordChar = "*"

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged

        If chkShow.Checked Then

            txtPassword.PasswordChar = ""

        Else

            txtPassword.PasswordChar = "*"

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblJam.Text = DateTime.Now.ToString("HH:mm:ss")

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "" Or txtPassword.Text = "" Then

            MessageBox.Show("Username dan Password wajib diisi!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Exit Sub

        End If

        If txtUsername.Text = "admin" And txtPassword.Text = "123" Then

            MessageBox.Show("Login Berhasil!",
                            "Informasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            FormTopUp.Show()
            Me.Hide()

        Else

            MessageBox.Show("Username atau Password salah!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        FormTopUp.Show()
        Me.Hide()

    End Sub

    Private Sub btnRegister_MouseHover(sender As Object, e As EventArgs) Handles btnRegister.MouseHover

        btnRegister.BackColor = Color.SeaGreen

    End Sub

    Private Sub btnRegister_MouseLeave(sender As Object, e As EventArgs) Handles btnRegister.MouseLeave

        btnRegister.BackColor = Color.MediumSeaGreen

    End Sub

    Private Sub btnLogin_MouseHover(sender As Object, e As EventArgs) Handles btnLogin.MouseHover

        btnLogin.BackColor = Color.RoyalBlue

    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave

        btnLogin.BackColor = Color.DodgerBlue

    End Sub

End Class