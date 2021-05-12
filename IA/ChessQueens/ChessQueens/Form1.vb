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

    Dim numeroDeTurnoIA As Integer = 0
    Dim cantidadDeReinasPJ As Integer
    Dim cantidadDeReinasIA As Integer
    Dim numeroDeTurnoPJ As Integer = 0

    ''' <summary>
    ''' Evento Load en el que se inicializan los colores del tablero.
    ''' </summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cantidadDeReinas = 8  'Por defecto, inicia con 8 reinas
        cantidadDeReinasPJ = cantidadDeReinas / 2
        cantidadDeReinasIA = cantidadDeReinas / 2
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
    Public Sub ColocarReina(ByRef fila As Integer, ByRef columna As Integer, ByRef user As Boolean)
        ' Dim temp As New List(Of Integer)
        If numeroDeTurnoPJ = 0 Then
            ImgReina4PJ.Visible = False
        End If

        If numeroDeTurnoPJ = 1 Then
            ImgReina3PJ.Visible = False
        End If

        If numeroDeTurnoPJ = 2 Then
            ImgReina2PJ.Visible = False
        End If

        If numeroDeTurnoPJ = 3 Then
            ImgReina1PJ.Visible = False
        End If

        numeroDeTurnoPJ += 1

        If Not PosicionEsSegura(fila, columna) Then
            MsgBox("La reina ha sido devorada")
            cantidadDeReinasPJ -= 1
            Return
        Else
            solucionActual(columna) = fila
            filasNoSeguras.Add(fila)
            columnasNoSeguras.Add(columna)
            ' MsgBox("Posición (" & fila & ", " & columna & ") SEGURA")
            PonerColoresAlTablero(columna, fila, user)
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
                Return False
            End If
        Next

        ' Verifica en vertical
        If columnasNoSeguras.Contains(columnaDePrueba) Then
            Return False
        End If

        ' Verifica en diagonal
        For columna = 0 To cantidadDeReinas - 1
            If solucionActual.Item(columna) <> -1 Then
                'si la sima de coordenadas del punto a agregar es igual a la suma de coordenadas de una posicion existente entonces no es segura la diagonal
                'igualmente con la resta
                If (Math.Abs(columna + solucionActual.Item(columna)) = Math.Abs(filaDePrueba + columnaDePrueba)) Or (columna - solucionActual.Item(columna) = columnaDePrueba - filaDePrueba) Then
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
    Private Sub PonerColoresAlTablero(filaActual As Integer, columnaActual As Integer, user As Boolean)
        If user Then
            Dgv_tablero.Item(filaActual, columnaActual).Style.BackColor = Color.FromArgb(53, 141, 219)
        Else
            Dgv_tablero.Item(filaActual, columnaActual).Style.BackColor = Color.Green
        End If

    End Sub

    ''' <summary>
    ''' Evento click de las celdas del tablero.
    ''' </summary>
    ''' <remarks>
    ''' Llama a colocar la reina por parte del usuario y la IA mediante los metodos
    ''' <c>ColocarReina</c> y <c>MovimientoIA</c>
    ''' </remarks>
    Private Sub Dgv_tablero_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_tablero.CellClick
        'Dim cantidadDeVerificaciones As Integer = 0
        If juegoIniciado Then
            Dim fila As Integer = Dgv_tablero.CurrentCell.RowIndex
            Dim columna As Integer = Dgv_tablero.CurrentCell.ColumnIndex
            Dim user As Boolean = True
            ColocarReina(fila, columna, user)
            'MsgBox("ahora viene la IA")
            MovimientoIA(fila, columna, user)

            If numeroDeTurnoIA = 0 Then
                ImgReina4IA.Visible = False
            End If

            If numeroDeTurnoIA = 1 Then
                ImgReina3IA.Visible = False
            End If

            If numeroDeTurnoIA = 2 Then
                ImgReina2IA.Visible = False
            End If

            If numeroDeTurnoIA = 3 Then
                ImgReina1IA.Visible = False
            End If
            numeroDeTurnoIA += 1
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
    Sub MovimientoIA(ByRef fila As Integer, ByRef columna As Integer, ByRef user As Boolean)
        user = False
        Dim numeroAleatorio As New Random()
        'variable para controlar el while, cambia a true si hay posiciones validas disponibles
        Dim valida As Boolean = False
        For i As Integer = 0 To cantidadDeReinas - 1 'for para recorrer todas las posiciones del tablero
            For j As Integer = 0 To cantidadDeReinas - 1
                valida = PosicionEsSegura(i, j)
                If valida Then ' si es segura la posicion se le asignan los valores a fila y columna para que se agreguen a las listas correspondientes
                    fila = i
                    columna = j
                    Exit For
                End If
            Next
            If valida Then 'si es valida = true se sale del segundo for 
                Exit For
            End If
        Next
        'End While
        'si valida llega al final de todas las posiciones sin volverse true quiere decir que no hay
        'posiciones validas en todo el tablero por lo tanto termina el juego
        If valida Then
            ' valida es true por lo tanto se agrega la posicion a la solucion actual y las filas/columnas no seguras
            solucionActual(columna) = fila
            filasNoSeguras.Add(fila)
            columnasNoSeguras.Add(columna)
            'MsgBox("Posición (" & fila & ", " & columna & ") SEGURA")
            PonerColoresAlTablero(columna, fila, user) ' user solo es para asignar el color deacuerdo por que metodo entra
        Else
            If cantidadDeReinasPJ < cantidadDeReinasIA Then
                MsgBox("Se acabo el juego, no hay mas posiciones validas disponibles" + vbNewLine +
                       "HA GANADO LA IA!")
            End If

            If cantidadDeReinasPJ = cantidadDeReinasIA Then
                MsgBox("Se acabo el juego, no hay mas posiciones validas disponibles" + vbNewLine +
                       "HA SIDO UN EMPATE!")
            End If

        End If

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
            ReiniciarTablero()
            juegoIniciado = True
        End If

        cantidadDeReinas = Convert.ToInt32(NudCantidadReinas.Text)

        ColocarTablero()

        For x = 0 To cantidadDeReinas - 1
            solucionActual.Add(-1)
        Next
    End Sub

    Private Sub ReiniciarTablero()
        numeroDeTurnoPJ = 0
        numeroDeTurnoIA = 0
        cantidadDeReinasPJ = cantidadDeReinas / 2
        cantidadDeReinasIA = cantidadDeReinas / 2

        filasNoSeguras.Clear()
        columnasNoSeguras.Clear()

        solucionActual.Clear()

        For x = 0 To cantidadDeReinas - 1
            solucionActual.Add(-1)
        Next

        ImgReina1IA.Visible = True
        ImgReina2IA.Visible = True
        ImgReina3IA.Visible = True
        ImgReina4IA.Visible = True

        ImgReina1PJ.Visible = True
        ImgReina2PJ.Visible = True
        ImgReina3PJ.Visible = True
        ImgReina4PJ.Visible = True
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