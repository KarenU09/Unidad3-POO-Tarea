Public Class RegistroAlumno

    Dim Alumno As New



    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click

        If TextNombre.Text = " " Then
            MsgBox("Debe agregar nombre")

        Else
            TextCodigo.Text = Alumno.generarCodigo(TextNombre.Text)

            'DatagridView.Raws.Add (TextFecha.Text, TextDeposito.Text)
        End If


    End Sub

    Private Sub BtnNombre_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        Alumno.datosAlumno(TextCodigo.Text, TextNombre.Text, TextApellido.Text, TextGenero.Text, TextDireccion.Text,
                           TextDUI.Text, TextCorreo.Text, TextEdad.Text)

        If Alumno.datosAceptados Then

            MsgBox("Datos de " & Alumno.nombreAlumno & " Registrados")
        End If
    End Sub

End Class

