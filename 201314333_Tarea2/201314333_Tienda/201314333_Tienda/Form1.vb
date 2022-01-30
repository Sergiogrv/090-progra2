Public Class Form1

    Const preciosArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim PagoSinIVA As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoConIVA As Double = 0
    Dim Descuento As Double = 0
    Dim pagoFinal = 0



    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)
        'Aqui va el codigo relacionadoa los calculos de los pagos
        PagoSinIVA = (Val(txtArroz.Text) * preciosArroz) * (Val(txtFrijol.Text) * precioFrijol) * (Val(txtAzucar.Text) * precioAzucar)
        valorIVA = PagoSinIVA * IVA
        pagoConIVA = PagoSinIVA * valorIVA
        Descuento = pagoConIVA = 0.025
        pagoFinal = pagoConIVA - Descuento



        LblR1.Text = PagoSinIVA
        LblR2.Text = valorIVA
        LblR3.Text = pagoConIVA
        LblR4.Text = Descuento
        LblR5.Text = pagoFinal
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Aqui va el codigo relacionadoa a limpiar todas las variables

        'Aqui debe limpiar los texbox, los label de resultados y las variables de resultado
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'Aqui va el codigo que pregunta si queremos cerrar la app
    End Sub

    Private Sub txtArroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArroz.KeyPress
        'codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFrijol_TextChanged(sender As Object, e As EventArgs) Handles txtFrijol.TextChanged

    End Sub

    Private Sub txtAzucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAzucar.KeyPress
        'codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrijol.KeyPress
        'codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub sssd222(sender As Object, e As EventArgs) Handles txtArroz.TextChanged

    End Sub

    Private Sub bvvvvvttt5(sender As Object, e As EventArgs) Handles txtAzucar.TextChanged

    End Sub
End Class
