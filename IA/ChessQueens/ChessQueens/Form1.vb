Public Class Form1
    Dim queens As New NQueens

    Dim juegoIniciado As Boolean = False

    'Cantidad de reinas
    Dim numeroDeReinas As Integer
    'Lista que contendra el valor de prueba actual
    Public solucionActual As New List(Of Integer)

    Public filasNoSeguras As New List(Of Integer)
    'Lista de listas de soluciones encontradas
    Public soluciones As New List(Of List(Of Integer))

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 7
            Dgv_tablero.Rows.Add()
            Dgv_tablero.Rows(i).HeaderCell.Value = (i + 1).ToString
            Dgv_tablero.Rows(i).Height = 75
            If i Mod 2 Then
                For j As Integer = 0 To 7
                    If j Mod 2 Then
                        Dgv_tablero.Item(j, i).Style.BackColor = Color.FromArgb(223, 229, 229)
                    Else
                        Dgv_tablero.Item(j, i).Style.BackColor = Color.FromArgb(57, 57, 57)
                    End If
                Next
            Else
                For j As Integer = 0 To 7
                    If j Mod 2 Then
                        Dgv_tablero.Item(j, i).Style.BackColor = Color.FromArgb(57, 57, 57)
                    Else
                        Dgv_tablero.Item(j, i).Style.BackColor = Color.FromArgb(223, 229, 229)
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If juegoIniciado Then
            Guna2GradientButton1.Text = "Iniciar"
            Guna2GradientButton1.Width = 139
            juegoIniciado = False
        Else
            Guna2GradientButton1.Text = "Terminar"
            Guna2GradientButton1.Width = 155
            juegoIniciado = True
        End If

        numeroDeReinas = Convert.ToInt32(NudCantidadReinas.Text)

        'For x = 0 To queens.NumeroDeReinas
        '    queens.solucionActual.Add(Nothing)
        'Next


        For x = 0 To numeroDeReinas
            solucionActual.Add(Nothing)
        Next




        'queens.ColocarReina(0)
        'LbResultados.Items.Add("Resultados para " + Str(queens.NumeroDeReinas) + " Reinas:")
        'LbResultados.Items.Add(Str(queens.soluciones.Count) + " soluciones encontradas")
        'For i = 0 To queens.soluciones.Count - 1
        '    Dim a As String = ""
        '    For x = 0 To queens.NumeroDeReinas - 1
        '        a &= " " & queens.soluciones(i).Item(x).ToString
        '    Next
        '    LbResultados.Items.Add(a)
        'Next
    End Sub

    Private Sub Guna2PictureBox10_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Metodo recursivo que pone una reina en una fila especifica.
    ''' Empezamos en la fila 0 y cada fila se ira agregando en la recursion.
    ''' </summary>
    ''' <param name="fila">Fila actual.</param>
    Public Sub ColocarReina(fila As Integer, columna As Integer)
        Dim temp As New List(Of Integer)

        If Not PosicionEsSegura(fila, columna) Then
            Return
        Else
            solucionActual(fila) = columna
            filasNoSeguras.Add(fila)
            MsgBox("Posición (" & fila & ", " & columna & ") SEGURA")
            PonerColoresAlTablero(columna, fila)
        End If
    End Sub

    ''' <summary>
    ''' Metodo que permite saber si una posicion es segura o no.
    ''' </summary>
    ''' <param name="filaDePrueba">Fila a probar.</param>
    ''' <param name="columnaDePrueba">Columna a probar.</param>
    ''' <returns>True: es segura. | False: no es segura.</returns>
    Private Function PosicionEsSegura(filaDePrueba As Integer, columnaDePrueba As Integer) As Boolean
        For fila = 0 To filaDePrueba
            If solucionActual(fila) <> Nothing Then

                ' Verifica en horizontal
                If filasNoSeguras.Contains(filaDePrueba) Then
                    MsgBox("Fila no segura para la posicion: (" & filaDePrueba & ", " & columnaDePrueba & ")")
                    Return False
                End If

                ' Verifica en vertical
                If columnaDePrueba = solucionActual(fila) Then
                    MsgBox("Columna no segura para la posicion: (" & filaDePrueba & ", " & columnaDePrueba & ")")
                    Return False
                End If

                ' Verifica en diagonal
                If Math.Abs(filaDePrueba - fila) = Math.Abs(columnaDePrueba - solucionActual(fila)) Then
                    MsgBox("Diagonal no segura para la posicion: (" & filaDePrueba & ", " & columnaDePrueba & ")")
                    Return False
                End If
            End If
        Next

        'No se ha encontrado otras reinas que ataquen a la actual
        Return True
    End Function

    Private Sub PonerColoresAlTablero(filaActual As Integer, columnaActual As Integer)
        Dgv_tablero.Item(filaActual, columnaActual).Style.BackColor = Color.FromArgb(53, 141, 219)
    End Sub

    'Private Sub Dgv_tablero_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgv_tablero.CellMouseClick
    '    ''POSICION en que se quiere agregar la reina
    '    Dim Posicion_Fila As Integer = Dgv_tablero.CurrentCell.RowIndex
    '    Dim Posicion_Columna As Integer = Dgv_tablero.CurrentCell.ColumnIndex
    '    If (queens.Validar_Posicion(Posicion_Fila, Posicion_Columna)) Then
    '        MsgBox("posicion valida")
    '        'PonerColoresAlTablero()
    '    End If
    'End Sub

    Private Sub Dgv_tablero_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_tablero.CellClick

        If juegoIniciado Then
            Dim fila As Integer = Dgv_tablero.CurrentCell.RowIndex
            Dim columna As Integer = Dgv_tablero.CurrentCell.ColumnIndex

            ColocarReina(fila, columna)

            'Aqui deberia mandar a hacer algo a la IA si y solo si quedan espacios disponibles
            'si no, termina el juego
        Else
            MsgBox("El juego no ha sido iniciado, favor elija la cantidadd de reinas y haga click en el boton de INICIAR")
        End If

    End Sub
End Class