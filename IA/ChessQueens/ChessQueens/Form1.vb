Public Class Form1
    'Objeto de la clase NQueens
    Dim queens As New NQueens
    'Variable de control que me permite saber si el juego ha sido iniciado o no
    Dim juegoIniciado As Boolean = False
    'Cantidad de reinas
    Dim cantidadDeReinas As Integer
    'Lista que contendra el valor de prueba actual
    Public solucionActual As New List(Of Integer)
    'Lista que contendra las filas no seguras para una reina
    Public filasNoSeguras As New List(Of Integer)
    'Lista que contendra las columnas no seguras para una reina
    Public columnasNoSeguras As New List(Of Integer)
    'Lista que contendra las diagonales no seguras para una reina
    Public diagonalesNoSeguras As New List(Of List(Of Integer))
    'Lista de listas de soluciones encontradas
    Public soluciones As New List(Of List(Of Integer))

    ''' <summary>
    ''' Evento Load en el que se inicializan los colores del tablero.
    ''' </summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cantidadDeReinas = 8  'Por defecto, inicia con 8 reinas
        ColocarTablero()
    End Sub

    ''' <summary>
    ''' Coloca el tablero del tamano que se le indique.
    ''' </summary>
    Private Sub ColocarTablero()
        ' (SOLO SIRVE 8x8 POR EL MOMENTO)
        For i As Integer = 0 To cantidadDeReinas - 1
            Dgv_tablero.Rows.Add()
            Dgv_tablero.Rows(i).HeaderCell.Value = (i + 1).ToString
            Dgv_tablero.Rows(i).Height = 75
            If i Mod 2 Then
                For j As Integer = 0 To cantidadDeReinas - 1
                    If j Mod 2 Then
                        Dgv_tablero.Item(j, i).Style.BackColor = Color.FromArgb(223, 229, 229)
                    Else
                        Dgv_tablero.Item(j, i).Style.BackColor = Color.FromArgb(57, 57, 57)
                    End If
                Next
            Else
                For j As Integer = 0 To cantidadDeReinas - 1
                    If j Mod 2 Then
                        Dgv_tablero.Item(j, i).Style.BackColor = Color.FromArgb(57, 57, 57)
                    Else
                        Dgv_tablero.Item(j, i).Style.BackColor = Color.FromArgb(223, 229, 229)
                    End If
                Next
            End If
        Next
    End Sub

    ''' <summary>
    ''' Metodo recursivo que pone una reina en una fila especifica.
    ''' Empezamos en la fila 0 y cada fila se ira agregando en la recursion.
    ''' </summary>
    ''' <param name="fila">Fila actual.</param>
    Public Sub ColocarReina(ByRef fila As Integer, ByRef columna As Integer)
        Dim temp As New List(Of Integer)

        If Not PosicionEsSegura(fila, columna) Then
            Return
        Else
            solucionActual(columna) = fila
            filasNoSeguras.Add(fila)
            columnasNoSeguras.Add(columna)
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
    Private Function PosicionEsSegura(ByRef filaDePrueba As Integer, ByRef columnaDePrueba As Integer) As Boolean
        ' Verifica en horizontal
        For i As Integer = 0 To filasNoSeguras.Count - 1
            If filasNoSeguras(i) = filaDePrueba Then
                'MsgBox("Fila no segura para la posicion: (" & filaDePrueba & ", " & columnaDePrueba & ")")
                Return False
            End If
        Next

        ' Verifica en vertical
        If columnasNoSeguras.Contains(columnaDePrueba) Then
            'MsgBox("Columna no segura para la posicion: (" & filaDePrueba & ", " & columnaDePrueba & ")")
            Return False
        End If

        ' Verifica en diagonal
        For columna = 0 To cantidadDeReinas - 1
            If solucionActual.Item(columna) <> Nothing Then
                ' MsgBox("suma " & (Math.Abs(columna + solucionActual.Item(columna)) = Math.Abs(filaDePrueba + columnaDePrueba)).ToString & " resta " & (solucionActual.Item(columna) - columna = filaDePrueba - columnaDePrueba).ToString)
                If (Math.Abs(columna + solucionActual.Item(columna)) = Math.Abs(filaDePrueba + columnaDePrueba)) Or (solucionActual.Item(columna) - columna = filaDePrueba - columnaDePrueba) Then
                    'MsgBox("Diagonal no segura para la posicion: (" & filaDePrueba & ", " & columnaDePrueba & ")")
                    Return False
                End If
            End If
        Next

        'No se ha encontrado otras reinas que ataquen a la actual
        Return True
    End Function

    ''' <summary>
    ''' Metodo que colorea una celda del tablero, especificamente la que el usuario o la IA escoja.
    ''' </summary>
    Private Sub PonerColoresAlTablero(filaActual As Integer, columnaActual As Integer)
        Dgv_tablero.Item(filaActual, columnaActual).Style.BackColor = Color.FromArgb(53, 141, 219)
    End Sub

    ''' <summary>
    ''' Evento click de las celdas del tablero.
    ''' </summary>
    ''' <remarks>
    ''' Llama a colocar la reina por parte del usuario y la IA mediante los metodos
    ''' <c>ColocarReina</c> y <c>MovimientoIA</c>
    ''' </remarks>
    Private Sub Dgv_tablero_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_tablero.CellClick
        Dim cantidadDeVerificaciones As Integer = 0
        If juegoIniciado Then
            Dim fila As Integer = Dgv_tablero.CurrentCell.RowIndex
            Dim columna As Integer = Dgv_tablero.CurrentCell.ColumnIndex

            ColocarReina(fila, columna)
            'MsgBox("ahora viene la IA")
            MovimientoIA(fila, columna)
        Else
            MsgBox("El juego no ha sido iniciado, favor elija la cantidadd de reinas y haga click en el boton de INICIAR")
        End If

    End Sub

    ''' <summary>
    ''' Metodo que genera un movimiento de la IA en forma aleatoria que permite colocar 
    ''' una reina dentro de una casilla disponible
    ''' </summary>
    ''' <param name="fila">?</param>
    ''' <param name="columna">???</param>
    Sub MovimientoIA(ByRef fila As Integer, ByRef columna As Integer)
        Dim numeroAleatorio As New Random()

        'Posible bucle infinito si no hay mas posiciones seguras
        While Not PosicionEsSegura(fila, columna)
            fila = numeroAleatorio.Next(0, cantidadDeReinas - 1)
            columna = numeroAleatorio.Next(0, cantidadDeReinas - 1)
        End While

        solucionActual(columna) = fila
        filasNoSeguras.Add(fila)
        columnasNoSeguras.Add(columna)
        'MsgBox("Posición (" & fila & ", " & columna & ") SEGURA")
        PonerColoresAlTablero(columna, fila)
    End Sub

    ''' <summary>
    ''' Evento click del boton que inicia o termina el juego.
    ''' </summary>
    Private Sub BtnIniciarJuego_Click(sender As Object, e As EventArgs) Handles BtnIniciarJuego.Click
        If juegoIniciado Then
            BtnIniciarJuego.Text = "Iniciar"
            BtnIniciarJuego.Width = 139
            juegoIniciado = False
        Else
            BtnIniciarJuego.Text = "Terminar"
            BtnIniciarJuego.Width = 155
            juegoIniciado = True
        End If

        cantidadDeReinas = Convert.ToInt32(NudCantidadReinas.Text)

        ColocarTablero()

        For x = 0 To cantidadDeReinas - 1
            solucionActual.Add(Nothing)
        Next
    End Sub

    ''' <summary>
    ''' Boton de Cerrar el programa.
    ''' </summary>
    Private Sub BtnCerrarApp_Click(sender As Object, e As EventArgs) Handles BtnCerrarApp.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Boton de minimizado.
    ''' </summary>
    Private Sub BtnMinimizarApp_Click(sender As Object, e As EventArgs) Handles BtnMinimizarApp.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class