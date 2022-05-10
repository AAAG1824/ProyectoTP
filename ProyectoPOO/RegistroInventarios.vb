Public Class RegistroInventarios
    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox1.Click
        Me.Close()
        login.Close()
    End Sub

    Private Sub BunifuPictureBox3_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        MenuVentas.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        MenuInventario.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        MenuProveedores.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        MenuInventario.Show()
    End Sub

    Private Sub BunifuLabel1_Click(sender As Object, e As EventArgs) Handles BunifuLabel1.Click

    End Sub

    Private Sub BunifuLabel2_Click(sender As Object, e As EventArgs) Handles BunifuLabel2.Click

    End Sub

    Private Sub AgregarButtonRegistroProveedores_Click(sender As Object, e As EventArgs) Handles AgregarButtonRegistroProveedores.Click

    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click

    End Sub

    Private Sub BunifuLabel5_Click(sender As Object, e As EventArgs) Handles BunifuLabel5.Click

    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click

    End Sub

    Private Sub BunifuLabel7_Click(sender As Object, e As EventArgs) Handles BunifuLabel7.Click

    End Sub

    Private Sub BunifuLabel8_Click(sender As Object, e As EventArgs) Handles BunifuLabel8.Click

    End Sub
End Class
