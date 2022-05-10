Public Class MenuVentas
    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox1.Click
        Me.Close()
        login.Close()
    End Sub

    Private Sub BunifuPictureBox3_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MenuVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        MenuPersonas.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        MenuProveedores.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        MenuInventario.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuPanel1_Click(sender As Object, e As EventArgs) Handles BunifuPanel1.Click
        MenuCaja.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuLabel1_Click(sender As Object, e As EventArgs) Handles BunifuLabel1.Click
        MenuCaja.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuIconButton1_Click(sender As Object, e As EventArgs) Handles BunifuIconButton1.Click
        MenuCaja.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuPanel2_Click(sender As Object, e As EventArgs) Handles BunifuPanel2.Click

    End Sub

    Private Sub BunifuPanel4_Click(sender As Object, e As EventArgs) Handles BunifuPanel4.Click
        MenuFacturas.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuLabel3_Click(sender As Object, e As EventArgs) Handles BunifuLabel3.Click
        MenuFacturas.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuIconButton5_Click(sender As Object, e As EventArgs) Handles BunifuIconButton5.Click
        MenuFacturas.Show()
        Me.Hide()
    End Sub
End Class
