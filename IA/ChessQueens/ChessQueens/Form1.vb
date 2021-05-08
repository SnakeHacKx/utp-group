Public Class Form1
    Dim queens As New NQueens

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        queens.NumeroDeReinas = Convert.ToInt32(TextBox1.Text)

        For x = 0 To queens.NumeroDeReinas
            queens.solucionActual.Add(0)
        Next

        queens.ColocarReina(0)
        ListBox1.Items.Add("Resultados para " + Str(queens.NumeroDeReinas) + " Reinas:")
        ListBox1.Items.Add(Str(queens.soluciones.Count) + " soluciones encontradas")

        'Dim aux As String = ""

        'For Each solucion In soluciones
        '    For Each sol In solucion
        '        aux += Str(sol)
        '    Next
        '    ListBox1.Items.Add(aux)
        '    aux = ""
        'Next

        'For Each solucion In soluciones
        '    For Each sol In solucion
        '        TextBox2.Text &= Str(sol)
        '    Next
        '    TextBox2.Text &= vbNewLine
        'Next

        'For i = 0 To soluciones.Count - 1
        '    Dim a As String = ""
        '    For x = 0 To numeroDeReinas - 1
        '        a &= " " & soluciones(i).Item(x).ToString
        '    Next
        '    ListBox1.Items.Add(a)

        'Next
    End Sub
End Class