﻿Public Class NQueens
    'Cantidad de reinas
    Dim _numeroDeReinas As Integer
    'Lista que contendra el valor de prueba actual
    Public solucionActual As New List(Of Integer)
    'Lista de listas de soluciones encontradas
    Public soluciones As New List(Of List(Of Integer))

    Property NumeroDeReinas As Integer
        Get
            Return _numeroDeReinas
        End Get
        Set(value As Integer)
            _numeroDeReinas = value
        End Set
    End Property
    ''ALGORITMO BACKTRAKING INICIO
    ''' <summary>
    ''' Metodo que permite saber si una posicion es segura o no.
    ''' </summary>
    ''' <param name="filaDePrueba">Fila a probar.</param>
    ''' <param name="columnaDePrueba">Columna a probar.</param>
    ''' <returns>True: es segura. | False: no es segura.</returns>
    Private Function PosicionEsSegura(filaDePrueba As Integer, columnaDePrueba As Integer) As Boolean
        If filaDePrueba = 0 Then
            Return True
        End If

        For fila = 0 To filaDePrueba - 1
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
    Public Sub ColocarReina(fila As Integer)
        Dim temp As New List(Of Integer)

        For columna = 0 To NumeroDeReinas - 1
            If Not PosicionEsSegura(fila, columna) Then
                Continue For
            Else
                solucionActual(fila) = columna

                'Si es la ultima fila agregamos una copia de la lista de soluciones
                'actuales a la lista de soluciones
                If fila = (NumeroDeReinas - 1) Then
                    For x = 0 To NumeroDeReinas - 1
                        temp.Add(Val(solucionActual.Item(x)))
                    Next
                    soluciones.Add(temp)

                Else
                    'Si no estamos en la ultima fila, seguimos la recursividad.
                    ColocarReina(fila + 1)
                End If
            End If
        Next
    End Sub
    ''FIN ALGORITMO BACKTRACKING
    Function Validar_Posicion(ByRef fila As Integer, ByRef columna As Integer) As Boolean
        ''funcion para validar que la posicion seleccionada es valida
        For Each solucion In soluciones
            MsgBox(" " & solucion.Item(columna) & " " & fila)
            If (solucion.Item(columna) = fila) Then
                ''verifica que la posicion seleccionada se encuentra en alguna de las soluciones
                Return True
            End If
        Next
        Return False
    End Function
End Class
