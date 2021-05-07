Public Class Form1
    'Cantidad de reinas
    Dim numeroDeReinas As Integer
    Dim solucionActual As New List(Of Integer)
    Dim soluciones As New List(Of List(Of Integer))

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x = 0 To numeroDeReinas
            solucionActual.Add(0)
        Next
    End Sub

    ''' <summary>
    ''' Metodo que permite saber si una posicion es segura o no.
    ''' </summary>
    ''' <param name="filaDePrueba">Fila a probar.</param>
    ''' <param name="columnaDePrueba">Columna a probar.</param>
    ''' <returns>True si es segura. | False si no es segura.</returns>
    Private Function PosicionEsSegura(filaDePrueba As Integer, columnaDePrueba As Integer) As Boolean
        If filaDePrueba = 0 Then
            Return True
        End If

        For fila = 0 To filaDePrueba
            ' Verifica en vertical
            If columnaDePrueba = solucionActual(fila) Then
                Return False
            End If

            ' Verifica en diagonal
            If Math.Abs(filaDePrueba - fila) = Math.Abs(columnaDePrueba - solucionActual(fila)) Then
                Return False
            End If
        Next

        'No se ha encontrado otras reinas que ataquen a la actual
        Return True
    End Function

    ''' <summary>
    ''' Metodo recursivo que pone una reina en una fila especifica.
    ''' Empezamos en la fila 0 y cada fila se ira agregando en la recursion.
    ''' </summary>
    ''' <param name="fila">Fila actual.</param>
    Private Sub ColocarReina(fila As Integer)
        For columna = 0 To numeroDeReinas
            If Not PosicionEsSegura(fila, columna) Then
                Continue For
            Else
                solucionActual(fila) = columna

                'Si es la ultima fila agregamos una copia de la lista de soluciones
                'actuales a la lista de soluciones
                If fila = numeroDeReinas - 1 Then
                    soluciones.AddRange(solucionActual)
                Else
                    'Si no estamos en la ultima fila, seguimos la recursividad.
                    ColocarReina(fila + 1)
                End If
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        numeroDeReinas = Convert.ToInt32(TextBox1.Text)
        ColocarReina(0)
        ListBox1.Items.Add("Resultados para " + Str(numeroDeReinas) + " Reinas:")
        ListBox1.Items.Add(Str(soluciones.Count) + " soluciones encontradas")
        For Each solucion In soluciones
            ListBox1.Items.Add(solucion)
        Next
    End Sub
End Class