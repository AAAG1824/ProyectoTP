Public Class RegistroProveedores
    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox1.Click

    End Sub


    Private Sub ProovedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProovedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MobicenDataSet)

    End Sub

    Private Sub ProovedoresBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProovedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MobicenDataSet)

    End Sub

    Private Sub RegistroProveedores_Load(sender As Object, e As EventArgs)
        'TODO: esta línea de código carga datos en la tabla 'MobicenDataSet.proovedores' Puede moverla o quitarla según sea necesario.
        Me.ProovedoresTableAdapter.Fill(Me.MobicenDataSet.proovedores)

    End Sub

    Private Sub ProovedoresBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProovedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MobicenDataSet)

    End Sub

    Private Sub RegistroProveedores_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MobicenDataSet.inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.MobicenDataSet.inventario)
        'TODO: esta línea de código carga datos en la tabla 'MobicenDataSet.proovedores' Puede moverla o quitarla según sea necesario.
        Me.ProovedoresTableAdapter.Fill(Me.MobicenDataSet.proovedores)



    End Sub

    Private Sub AgregarButtonRegistroProveedores_Click_1(sender As Object, e As EventArgs) Handles AgregarButtonRegistroProveedores.Click


        If NombreTextBox.Text <> "" And TextBox1.Text <> "" And TelefonoTextBox.Text <> "" And CorreoTextBox.Text <> "" And ComboBox1.SelectedIndex <> "" And IDProveedorTextBox.Text <> "" Then

                Me.ProovedoresTableAdapter.InsertProveedores(NombreTextBox.Text, TextBox1.Text, TelefonoTextBox.Text, CorreoTextBox.Text, ComboBox1.SelectedIndex, IDProveedorTextBox.Text)
                MsgBox("registro agregado correctamente")
                NombreTextBox.Text = ""
                TextBox1.Text = ""
                TelefonoTextBox.Text = ""
                CorreoTextBox.Text = ""
                IDProveedorTextBox.Text = ""
            Else
                MsgBox("Error al ingresar los datos")
                NombreTextBox.Text = ""
                TextBox1.Text = ""
                TelefonoTextBox.Text = ""
                CorreoTextBox.Text = ""
                IDProveedorTextBox.Text = ""
            End If


    End Sub
End Class