Public Class Form2
    'Objeto de la clase NQueens
    Dim queens As New NQueens
    'Variable de control que me permite saber si ya el boton de Generar Solucion ha sido pulsado
    Dim solucionMostrada As Boolean = False

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCerrarApp_Click(sender As Object, e As EventArgs) Handles BtnCerrarApp.Click
        Application.Exit()
    End Sub

    Private Sub BtnMinimizarApp_Click(sender As Object, e As EventArgs) Handles BtnMinimizarApp.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GenerarSolucion_Click(sender As Object, e As EventArgs) Handles BtnGenerarSolucion.Click

        If solucionMostrada Then
            queens.solucionActual.Clear()
            queens.soluciones.Clear()
            LbResultados.Items.Clear()
        End If

        queens.NumeroDeReinas = Convert.ToInt32(NudCantidadReinas.Text)

        For x = 0 To queens.NumeroDeReinas
            queens.solucionActual.Add(0)
        Next

        queens.ColocarReina(0)
        LbResultados.Items.Add("Resultados para " + Str(queens.NumeroDeReinas) + " Reinas:")
        LbResultados.Items.Add(Str(queens.soluciones.Count) + " soluciones encontradas")
        For i = 0 To queens.soluciones.Count - 1
            Dim a As String = ""
            For x = 0 To queens.NumeroDeReinas - 1
                a &= " " & queens.soluciones(i).Item(x).ToString
            Next
            LbResultados.Items.Add(a)
        Next

        solucionMostrada = True
    End Sub
End Class