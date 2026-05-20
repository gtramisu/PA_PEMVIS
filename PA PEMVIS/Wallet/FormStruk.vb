Imports System.Drawing.Printing

Public Class FormStruk
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fontJudul As New Font("Arial", 18, FontStyle.Bold)
        Dim fontIsi As New Font("Arial", 12)

        Dim y As Integer = 100

        e.Graphics.DrawString("BUKTI TRANSFER", fontJudul, Brushes.Black, 180, y)

        y += 50
        e.Graphics.DrawString("Nama Penerima : " & lblNama.Text, fontIsi, Brushes.Black, 100, y)

        y += 30
        e.Graphics.DrawString("Nomor Tujuan : " & lblNomor.Text, fontIsi, Brushes.Black, 100, y)

        y += 30
        e.Graphics.DrawString("E-Wallet : " & lblWallet.Text, fontIsi, Brushes.Black, 100, y)

        y += 30
        e.Graphics.DrawString("Nominal : Rp" & lblNominal.Text, fontIsi, Brushes.Black, 100, y)

        y += 30
        e.Graphics.DrawString("Catatan : " & lblCatatan.Text, fontIsi, Brushes.Black, 100, y)

        y += 30
        e.Graphics.DrawString("Tanggal : " & DateTime.Now.ToString(), fontIsi, Brushes.Black, 100, y)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        FormTransfer.Show()
        Me.Close()

    End Sub
End Class