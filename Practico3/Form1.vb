Public Class Form1
    Private Sub LNya_Click(sender As Object, e As EventArgs) Handles LNya.Click

    End Sub

    Private Sub TDni_TextChanged(sender As Object, e As EventArgs) Handles TDni.TextChanged
        Dim input As String = TDni.Text

        ' Verificar si el texto contiene caracteres que no sean números
        For Each c As Char In input
            If Not Char.IsDigit(c) Then
                ' Si se encuentra un carácter no numérico, eliminarlo del TextBox
                TDni.Text = TDni.Text.Remove(TDni.Text.IndexOf(c), 1)
                TDni.SelectionStart = TDni.Text.Length ' Colocar el cursor al final del TextBox
                Exit For
            End If
        Next
    End Sub

    Private Sub TApellido_TextChanged(sender As Object, e As EventArgs) Handles TApellido.TextChanged
        Dim input As String = TApellido.Text

        ' Verificar si el texto contiene caracteres que no sean letras
        For Each c As Char In input
            If Not Char.IsLetter(c) Then
                ' Si se encuentra un carácter no alfabético, eliminarlo del TextBox
                TApellido.Text = TApellido.Text.Remove(TApellido.Text.IndexOf(c), 1)
                TApellido.SelectionStart = TApellido.Text.Length ' Colocar el cursor al final del TextBox
                Exit For
            End If
        Next
    End Sub

    Private Sub TNombre_TextChanged(sender As Object, e As EventArgs) Handles TNombre.TextChanged
        Dim input As String = TNombre.Text

        ' Verificar si el texto contiene caracteres que no sean letras
        For Each c As Char In input
            If Not Char.IsLetter(c) Then
                ' Si se encuentra un carácter no alfabético, eliminarlo del TextBox
                TNombre.Text = TNombre.Text.Remove(TNombre.Text.IndexOf(c), 1)
                TNombre.SelectionStart = TNombre.Text.Length ' Colocar el cursor al final del TextBox
                Exit For
            End If
        Next
    End Sub

    Private Sub TGuardar_Click(sender As Object, e As EventArgs) Handles TGuardar.Click
        Dim ask As MsgBoxResult ' Declarar la variable ask

        If String.IsNullOrWhiteSpace(TDni.Text) OrElse
       String.IsNullOrWhiteSpace(TNombre.Text) OrElse
       String.IsNullOrWhiteSpace(TApellido.Text) Then

            ' Mostrar mensaje de error si algún campo está incompleto
            MsgBox("Debe Completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            ' Concatenar apellido y nombre y asignar a LModificar.Text
            LModificar.Text = TNombre.Text & " " & TApellido.Text

            ' Mostrar mensaje de confirmación
            ask = MsgBox("Seguro que desea insertar un nuevo Cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Confirmar Insercion")
            If ask = MsgBoxResult.Yes Then

                MsgBox("Cliente insertado exitosamente", MsgBoxStyle.Information, "Éxito")
            End If
        End If
    End Sub

    Private Sub TEliminar_Click(sender As Object, e As EventArgs) Handles TEliminar.Click
        Dim ask As MsgBoxResult ' Declarar la variable ask

        ' Mostrar mensaje de advertencia para confirmar eliminación
        ask = MsgBox("Está a punto de eliminar el Cliente: " & TNombre.Text & " " & TApellido.Text, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Confirmar Eliminación")

        If ask = MsgBoxResult.Yes Then
            ' Limpiar los campos
            TDni.Clear()
            TNombre.Clear()
            TApellido.Clear()
            LModificar.Text = "Modificar"

            MsgBox("Cliente eliminado exitosamente", MsgBoxStyle.Information, "Éxito")
        End If
    End Sub

    Private Sub RBVaron_CheckedChanged(sender As Object, e As EventArgs) Handles RBVaron.CheckedChanged

        If RBVaron.Checked Then
            PictureBox1.BackgroundImage = My.Resources.varonIcon
        End If
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub RBMujer_CheckedChanged(sender As Object, e As EventArgs) Handles RBMujer.CheckedChanged
        If RBVaron.Checked Then
            PictureBox1.BackgroundImage = My.Resources.mujerIcon
        End If
    End Sub
End Class
