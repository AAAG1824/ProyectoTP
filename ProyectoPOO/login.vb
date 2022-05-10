Imports Bunifu.UI.WinForms

Public Class login

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click

        If Me.EmpleadosTableAdapter.Login(Me.ProyectomobicenDataSet.empleados, TextBox1.Text) Then
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("Clave ingresada incorrecta")
        End If
    End Sub

    Private Sub BunifuCheckBox1_CheckedChanged(sender As Object, e As BunifuCheckBox.CheckedChangedEventArgs) Handles BunifuCheckBox1.CheckedChanged

        If e.CheckState = BunifuCheckBox.CheckStates.Checked Then

            TextBox1.PasswordChar = "*"

        ElseIf e.CheckState = BunifuCheckBox.CheckStates.Unchecked Then

            TextBox1.PasswordChar = ""

        End If

    End Sub

    Private Sub BunifuPictureBox3_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectomobicenDataSet.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ProyectomobicenDataSet.empleados)

    End Sub

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProyectomobicenDataSet)

    End Sub

    Private Sub BunifuPictureBox1_Click_1(sender As Object, e As EventArgs) Handles BunifuPictureBox1.Click
        Me.Close()
    End Sub


End Class