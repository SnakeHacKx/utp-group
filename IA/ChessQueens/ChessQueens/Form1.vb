Public Class Form1
    Dim queens As New NQueens
    Dim solucion_En_Curso As New List(Of Integer) 'guarda todas las posiciones que se ha introducido, es la solucion que se esta desarrollando
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
        queens.NumeroDeReinas = Convert.ToInt32(NudCantidadReinas.Text)

        For x = 0 To queens.NumeroDeReinas - 1
            queens.solucionActual.Add(0)
            solucion_En_Curso.Add(-1)
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
    End Sub

    Private Sub Guna2PictureBox10_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Application.Exit()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click

    End Sub

    Private Sub Dgv_tablero_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgv_tablero.CellMouseClick
        ''POSICION en que se quiere agregar la reina

        queens.NumeroDePasos += 1
        Dim Posicion_Fila As Integer = Dgv_tablero.CurrentCell.RowIndex
        Dim Posicion_Columna As Integer = Dgv_tablero.CurrentCell.ColumnIndex

        solucion_En_Curso.Item(Posicion_Columna) = Posicion_Fila
        Dgv_tablero.Item(Posicion_Columna, Posicion_Fila).Style.BackColor = Color.Red
        System.Threading.Thread.Sleep(5000)
        queens.pasoDeIA(solucion_En_Curso, Posicion_Fila, Posicion_Columna)
        queens.NumeroDePasos += 1
        Dgv_tablero.Item(Posicion_Columna, Posicion_Fila).Style.BackColor = Color.Red
        MsgBox("solucion actual ")
        For Each s In solucion_En_Curso
            MsgBox("" & s.ToString)
        Next
        'If (Not queens.Validar_Posicion(solucion_En_Curso)) Then
        '    solucion_En_Curso.Item(Posicion_Columna) = -1
        '    queens.NumeroDePasos -= 1
        '    MsgBox("Se comieron a tu reina ")
        '    MsgBox("solucion actual ")
        '    For Each s In solucion_En_Curso
        '        MsgBox("" & s.ToString)
        '    Next
        'Else
        '    Dgv_tablero.Item(Posicion_Columna, Posicion_Fila).Style.BackColor = Color.Red
        'End If
    End Sub

End Class