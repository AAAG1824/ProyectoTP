Public Class RegistroClientes
    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox1.Click
        Me.Close()
        login.Close()
    End Sub

    Private Sub BunifuPictureBox3_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectomobicenDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ProyectomobicenDataSet.clientes)

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        MenuVentas.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        MenuPersonas.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        MenuProveedores.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        MenuInventario.Show()
    End Sub


    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click

        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then

            Me.ClientesTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            Me.ClientesTableAdapter.Fill(ProyectomobicenDataSet.clientes)
        Else
            MsgBox("Ingrese todos los datos")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        End If



    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProyectomobicenDataSet)

    End Sub

    Private Sub BunifuPictureBox2_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox2.Click
        Me.ClientesTableAdapter.Fill(ProyectomobicenDataSet.clientes)
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        Dim idUsuario As Integer = CInt(BunifuTextBox1.Text)
        Me.ClientesTableAdapter.DeleteClientes(idUsuario)
        MsgBox("Registro eliminado correctamente")
        Me.ClientesTableAdapter.Fill(ProyectomobicenDataSet.clientes)
    End Sub
End Class
