﻿Public Class MenuRegistroProveedores
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
        Me.Close()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        MenuProveedores.Show()
        Me.Close()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        MenuInventario.Show()
    End Sub

    Private Sub BunifuLabel7_Click(sender As Object, e As EventArgs) Handles BunifuLabel7.Click

    End Sub

    Private Sub BunifuTextBox3_TextChanged(sender As Object, e As EventArgs) Handles BunifuTextBox3.TextChanged

    End Sub

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) Handles BunifuButton7.Click

    End Sub

    Private Sub BunifuLabel5_Click(sender As Object, e As EventArgs) Handles BunifuLabel5.Click

    End Sub
End Class