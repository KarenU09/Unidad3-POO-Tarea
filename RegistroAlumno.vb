Public Class RegistroAlumno

    Dim Alumno As New



    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click

        If TextNombre.Text = " " Then
            MsgBox("Debe agregar nombre")

        Else
            TextCodigo.Text = Alumno.generarCodigo(TextNombre.Text)



        End If


    End Sub

    Private Sub BtnNombre_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        Alumno.datosAlumno(TextCodigo.Text,
                           TextNombre.Text,
                           TextApellido.Text,
                           TextGenero.Text,
                           TextDireccion.Text,
                           TextDUI.Text,
                           TextCorreo.Text,
                           TextEdad.Text)


        DatosAlumnos.Rows.Add(TextCodigo.Text,
                              Alumno.nombreAlumno,
                              Alumno.apellidoAlumno,
                              Alumno.generoAlumno,
                              Alumno.direccionAlumno,
                              Alumno.DUIAlumno,
                              Alumno.correoAlumno,
                              Alumno.edadAlumno)


        If Alumno.datosAceptados Then

            MsgBox("Datos de " & Alumno.nombreAlumno & " Registrados")
        End If

        TextCodigo.Text = ""
        TextNombre.Text = ""
        TextApellido.Text = ""
        TextGenero.Text = ""
        TextDireccion.Text = ""
        TextDUI.Text = ""
        TextCorreo.Text = ""
        TextEdad.Text = ""


    End Sub

    Private Sub DatosAlumnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatosAlumnos.CellContentClick

    End Sub
End Class

