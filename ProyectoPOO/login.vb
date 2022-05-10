Imports Bunifu.UI.WinForms

Public Class login

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click

        If Me.EmpleadosTableAdapter.BuscarUC(Me.MobicenDataSet.empleados, TextBox1.Text) Then
            Me.Hide()
            Form1.Show()
        ElseIf TextBox1.Text = "" Then
            MsgBox("Por favor ingrese una clave")

        Else
            MsgBox("Clave no existente")
        End If

    End Sub

    Private Sub BunifuCheckBox1_CheckedChanged(sender As Object, e As BunifuCheckBox.CheckedChangedEventArgs) Handles BunifuCheckBox1.CheckedChanged

        If e.CheckState = BunifuCheckBox.CheckStates.Checked Then

            TextBox1.PasswordChar = "*"

        ElseIf e.CheckState = BunifuCheckBox.CheckStates.Unchecked Then

            TextBox1.PasswordChar = ""

        End If

    End Sub

    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub BunifuPictureBox3_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MobicenDataSet.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.MobicenDataSet.empleados)
        TextBox1.Text = ""

    End Sub

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MobicenDataSet)

    End Sub

End Class