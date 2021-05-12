<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnIniciarJuego = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.NudCantidadReinas = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnCerrarApp = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BtnMinimizarApp = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Dgv_tablero = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LbResultados = New System.Windows.Forms.ListBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnPosiblesSoluciones = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.NudCantidadReinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_tablero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnIniciarJuego
        '
        Me.BtnIniciarJuego.AutoRoundedCorners = True
        Me.BtnIniciarJuego.BorderRadius = 25
        Me.BtnIniciarJuego.CheckedState.Parent = Me.BtnIniciarJuego
        Me.BtnIniciarJuego.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIniciarJuego.CustomImages.Parent = Me.BtnIniciarJuego
        Me.BtnIniciarJuego.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciarJuego.ForeColor = System.Drawing.Color.White
        Me.BtnIniciarJuego.HoverState.Parent = Me.BtnIniciarJuego
        Me.BtnIniciarJuego.Location = New System.Drawing.Point(141, 50)
        Me.BtnIniciarJuego.Name = "BtnIniciarJuego"
        Me.BtnIniciarJuego.ShadowDecoration.BorderRadius = 16
        Me.BtnIniciarJuego.ShadowDecoration.Parent = Me.BtnIniciarJuego
        Me.BtnIniciarJuego.Size = New System.Drawing.Size(139, 52)
        Me.BtnIniciarJuego.TabIndex = 6
        Me.BtnIniciarJuego.Text = "Iniciar"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'NudCantidadReinas
        '
        Me.NudCantidadReinas.BackColor = System.Drawing.Color.Transparent
        Me.NudCantidadReinas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NudCantidadReinas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NudCantidadReinas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NudCantidadReinas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NudCantidadReinas.DisabledState.Parent = Me.NudCantidadReinas
        Me.NudCantidadReinas.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.NudCantidadReinas.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.NudCantidadReinas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NudCantidadReinas.FocusedState.Parent = Me.NudCantidadReinas
        Me.NudCantidadReinas.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudCantidadReinas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NudCantidadReinas.Location = New System.Drawing.Point(10, 61)
        Me.NudCantidadReinas.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.NudCantidadReinas.Name = "NudCantidadReinas"
        Me.NudCantidadReinas.ShadowDecoration.Parent = Me.NudCantidadReinas
        Me.NudCantidadReinas.Size = New System.Drawing.Size(58, 36)
        Me.NudCantidadReinas.TabIndex = 11
        Me.NudCantidadReinas.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(10, 31)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(77, 23)
        Me.Guna2HtmlLabel1.TabIndex = 13
        Me.Guna2HtmlLabel1.Text = "Jugar con:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(74, 65)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(50, 23)
        Me.Guna2HtmlLabel2.TabIndex = 14
        Me.Guna2HtmlLabel2.Text = "Reinas"
        '
        'BtnCerrarApp
        '
        Me.BtnCerrarApp.BackColor = System.Drawing.Color.Transparent
        Me.BtnCerrarApp.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BtnCerrarApp.CheckedState.Parent = Me.BtnCerrarApp
        Me.BtnCerrarApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarApp.HoverState.ImageSize = New System.Drawing.Size(37, 37)
        Me.BtnCerrarApp.HoverState.Parent = Me.BtnCerrarApp
        Me.BtnCerrarApp.Image = Global.ChessQueens.My.Resources.Resources.cancel
        Me.BtnCerrarApp.ImageRotate = 0!
        Me.BtnCerrarApp.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnCerrarApp.Location = New System.Drawing.Point(1256, -1)
        Me.BtnCerrarApp.Name = "BtnCerrarApp"
        Me.BtnCerrarApp.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BtnCerrarApp.PressedState.Parent = Me.BtnCerrarApp
        Me.BtnCerrarApp.Size = New System.Drawing.Size(47, 45)
        Me.BtnCerrarApp.TabIndex = 15
        Me.BtnCerrarApp.UseTransparentBackground = True
        '
        'BtnMinimizarApp
        '
        Me.BtnMinimizarApp.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizarApp.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BtnMinimizarApp.CheckedState.Parent = Me.BtnMinimizarApp
        Me.BtnMinimizarApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizarApp.HoverState.ImageSize = New System.Drawing.Size(37, 37)
        Me.BtnMinimizarApp.HoverState.Parent = Me.BtnMinimizarApp
        Me.BtnMinimizarApp.Image = Global.ChessQueens.My.Resources.Resources.minimize
        Me.BtnMinimizarApp.ImageRotate = 0!
        Me.BtnMinimizarApp.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnMinimizarApp.Location = New System.Drawing.Point(1207, -1)
        Me.BtnMinimizarApp.Name = "BtnMinimizarApp"
        Me.BtnMinimizarApp.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BtnMinimizarApp.PressedState.Parent = Me.BtnMinimizarApp
        Me.BtnMinimizarApp.Size = New System.Drawing.Size(47, 45)
        Me.BtnMinimizarApp.TabIndex = 16
        Me.BtnMinimizarApp.UseTransparentBackground = True
        '
        'Dgv_tablero
        '
        Me.Dgv_tablero.AllowUserToAddRows = False
        Me.Dgv_tablero.AllowUserToDeleteRows = False
        Me.Dgv_tablero.AllowUserToResizeColumns = False
        Me.Dgv_tablero.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Dgv_tablero.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_tablero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_tablero.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_tablero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_tablero.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Dgv_tablero.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_tablero.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_tablero.ColumnHeadersHeight = 21
        Me.Dgv_tablero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_tablero.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_tablero.EnableHeadersVisualStyles = False
        Me.Dgv_tablero.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_tablero.Location = New System.Drawing.Point(193, 138)
        Me.Dgv_tablero.Name = "Dgv_tablero"
        Me.Dgv_tablero.ReadOnly = True
        Me.Dgv_tablero.RowHeadersVisible = False
        Me.Dgv_tablero.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Dgv_tablero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.Dgv_tablero.Size = New System.Drawing.Size(935, 620)
        Me.Dgv_tablero.TabIndex = 17
        Me.Dgv_tablero.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Dgv_tablero.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Dgv_tablero.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Dgv_tablero.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Dgv_tablero.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Dgv_tablero.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Dgv_tablero.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Dgv_tablero.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_tablero.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_tablero.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgv_tablero.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Dgv_tablero.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Dgv_tablero.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Dgv_tablero.ThemeStyle.HeaderStyle.Height = 21
        Me.Dgv_tablero.ThemeStyle.ReadOnly = True
        Me.Dgv_tablero.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Dgv_tablero.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Dgv_tablero.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Dgv_tablero.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Dgv_tablero.ThemeStyle.RowsStyle.Height = 22
        Me.Dgv_tablero.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_tablero.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column9
        '
        Me.Column9.HeaderText = "1"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "2"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "3"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "4"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "5"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "6"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "7"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column16
        '
        Me.Column16.HeaderText = "8"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(358, 21)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(587, 81)
        Me.Guna2HtmlLabel3.TabIndex = 18
        Me.Guna2HtmlLabel3.Text = "El Juego de Las N Reinas"
        '
        'LbResultados
        '
        Me.LbResultados.FormattingEnabled = True
        Me.LbResultados.Location = New System.Drawing.Point(1135, 657)
        Me.LbResultados.Name = "LbResultados"
        Me.LbResultados.Size = New System.Drawing.Size(156, 69)
        Me.LbResultados.TabIndex = 1
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(85, 6)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(37, 41)
        Me.Guna2HtmlLabel5.TabIndex = 20
        Me.Guna2HtmlLabel5.Text = "IA"
        '
        'BtnPosiblesSoluciones
        '
        Me.BtnPosiblesSoluciones.AutoRoundedCorners = True
        Me.BtnPosiblesSoluciones.BorderRadius = 40
        Me.BtnPosiblesSoluciones.CheckedState.Parent = Me.BtnPosiblesSoluciones
        Me.BtnPosiblesSoluciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPosiblesSoluciones.CustomImages.Parent = Me.BtnPosiblesSoluciones
        Me.BtnPosiblesSoluciones.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPosiblesSoluciones.ForeColor = System.Drawing.Color.White
        Me.BtnPosiblesSoluciones.HoverState.Parent = Me.BtnPosiblesSoluciones
        Me.BtnPosiblesSoluciones.Location = New System.Drawing.Point(1103, 49)
        Me.BtnPosiblesSoluciones.Name = "BtnPosiblesSoluciones"
        Me.BtnPosiblesSoluciones.ShadowDecoration.BorderRadius = 16
        Me.BtnPosiblesSoluciones.ShadowDecoration.Parent = Me.BtnPosiblesSoluciones
        Me.BtnPosiblesSoluciones.Size = New System.Drawing.Size(178, 83)
        Me.BtnPosiblesSoluciones.TabIndex = 21
        Me.BtnPosiblesSoluciones.Text = "Posibles Soluciones"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(1303, 788)
        Me.Controls.Add(Me.BtnPosiblesSoluciones)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Dgv_tablero)
        Me.Controls.Add(Me.BtnMinimizarApp)
        Me.Controls.Add(Me.LbResultados)
        Me.Controls.Add(Me.BtnCerrarApp)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.NudCantidadReinas)
        Me.Controls.Add(Me.BtnIniciarJuego)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1303, 813)
        Me.MinimumSize = New System.Drawing.Size(1303, 766)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reinas de Ajedrez"
        CType(Me.NudCantidadReinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_tablero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnIniciarJuego As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents NudCantidadReinas As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnCerrarApp As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnMinimizarApp As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Dgv_tablero As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LbResultados As ListBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnPosiblesSoluciones As Guna.UI2.WinForms.Guna2GradientButton
End Class
