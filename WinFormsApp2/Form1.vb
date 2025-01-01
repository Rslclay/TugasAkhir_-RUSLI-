Public Class Form1
    Private Sub btnhitung_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnhitung.Click
        Dim Bunga, Tabungan, JumlahTabungan As Decimal
        Dim Jangkawaktu As Integer
        Tabungan = txttabungan.Text
        Bunga = nmcbunga.Value / 100
        Jangkawaktu = nmcjangkawaktu.Value
        JumlahTabungan = Tabungan + (Bunga * Tabungan * Jangkawaktu) / 12 * 100
        lblhasil.Text = "Tabungan setelah : " & Jangkawaktu & "Bulan, sebesar Rp ." & JumlahTabungan
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub
End Class
