Public Class RegistroAuto

    Dim Auto As New

    Private Sub GrpAuto_Enter(sender As Object, e As EventArgs) Handles GrpAuto.Enter

        If TextModelo.Text = " " Then
            MsgBox("Debe agregar MOdelo ")

        Else
            TextCodigo.Text = Auto.generarCodigo(TextModelo.Text)

        End If

    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click

        Auto.datosAlumno(TextCodigo.Text,
                           TextModelo.Text,
                           TextMarca.Text,
                           TextColor.Text,
                           TextMotor.Text,
                           TextPuertas.Text,
                           TextAño.Text,
                           TextMillaje.Text)

        DatosAuto.Rows.Add(TextCodigo.Text,
                              Auto.modeloAuto,
                              Auto.marcaAuto,
                              Auto.colorAuto,
                              Auto.motorAuto,
                              Auto.puertasAuto,
                              Auto.añoAuto,
                              Auto.millajeAuto)


        If Auto.datosAceptados Then

            MsgBox("Datos de " & Auto.nombreAlumno & " Registrados")
        End If

        TextCodigo.Text = ""
        TextModelo.Text = ""
        TextMarca.Text = ""
        TextColor.Text = ""
        TextMotor.Text = ""
        TextPuertas.Text = ""
        TextAño.Text = ""
        TextMillaje.Text = ""


    End Sub


End Class