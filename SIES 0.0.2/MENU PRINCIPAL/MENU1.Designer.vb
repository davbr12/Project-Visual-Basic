<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MENU1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENU1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MINIMIZAR = New System.Windows.Forms.PictureBox()
        Me.CERRAR = New System.Windows.Forms.PictureBox()
        Me.HORA = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SERVICIO = New System.Windows.Forms.Button()
        Me.HERRAMIENTA = New System.Windows.Forms.Button()
        Me.CLIENTE = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.REPORTE = New System.Windows.Forms.Button()
        Me.SALIR = New System.Windows.Forms.Button()
        Me.REGISTRAR = New System.Windows.Forms.Button()
        Me.INICIO = New System.Windows.Forms.Button()
        Me.CONTENEDOR = New System.Windows.Forms.Panel()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MINIMIZAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CERRAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.MINIMIZAR)
        Me.Panel1.Controls.Add(Me.CERRAR)
        Me.Panel1.Controls.Add(Me.HORA)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1363, 45)
        Me.Panel1.TabIndex = 40
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Menu")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Linen
        Me.Label4.Location = New System.Drawing.Point(172, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 19)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Aministrador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(46, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 21)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Tipo de Usuario:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(563, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(288, 38)
        Me.Label9.TabIndex = 50
        Me.Label9.Tag = "0"
        Me.Label9.Text = "B I E N V E N I D O"
        '
        'MINIMIZAR
        '
        Me.MINIMIZAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.MINIMIZAR, BunifuAnimatorNS.DecorationType.None)
        Me.MINIMIZAR.Image = CType(resources.GetObject("MINIMIZAR.Image"), System.Drawing.Image)
        Me.MINIMIZAR.Location = New System.Drawing.Point(1307, 11)
        Me.MINIMIZAR.Name = "MINIMIZAR"
        Me.MINIMIZAR.Size = New System.Drawing.Size(25, 25)
        Me.MINIMIZAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.MINIMIZAR.TabIndex = 40
        Me.MINIMIZAR.TabStop = False
        Me.ToolTip1.SetToolTip(Me.MINIMIZAR, "Minimizar")
        '
        'CERRAR
        '
        Me.CERRAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.CERRAR, BunifuAnimatorNS.DecorationType.None)
        Me.CERRAR.Image = CType(resources.GetObject("CERRAR.Image"), System.Drawing.Image)
        Me.CERRAR.Location = New System.Drawing.Point(1338, 11)
        Me.CERRAR.Name = "CERRAR"
        Me.CERRAR.Size = New System.Drawing.Size(25, 25)
        Me.CERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CERRAR.TabIndex = 39
        Me.CERRAR.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CERRAR, "Cerrar")
        '
        'HORA
        '
        Me.HORA.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.HORA, BunifuAnimatorNS.DecorationType.None)
        Me.HORA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HORA.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HORA.Location = New System.Drawing.Point(290, 16)
        Me.HORA.Name = "HORA"
        Me.HORA.Size = New System.Drawing.Size(0, 19)
        Me.HORA.TabIndex = 23
        '
        'Timer1
        '
        '
        'SERVICIO
        '
        Me.SERVICIO.BackColor = System.Drawing.Color.Gray
        Me.SERVICIO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.SERVICIO, BunifuAnimatorNS.DecorationType.None)
        Me.SERVICIO.FlatAppearance.BorderSize = 0
        Me.SERVICIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SERVICIO.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SERVICIO.ForeColor = System.Drawing.Color.Snow
        Me.SERVICIO.Image = CType(resources.GetObject("SERVICIO.Image"), System.Drawing.Image)
        Me.SERVICIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SERVICIO.Location = New System.Drawing.Point(0, 162)
        Me.SERVICIO.Name = "SERVICIO"
        Me.SERVICIO.Size = New System.Drawing.Size(198, 30)
        Me.SERVICIO.TabIndex = 77
        Me.SERVICIO.Text = "Servicios"
        Me.SERVICIO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.SERVICIO, "Servicios")
        Me.SERVICIO.UseVisualStyleBackColor = False
        '
        'HERRAMIENTA
        '
        Me.HERRAMIENTA.BackColor = System.Drawing.Color.Gray
        Me.HERRAMIENTA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.HERRAMIENTA, BunifuAnimatorNS.DecorationType.None)
        Me.HERRAMIENTA.FlatAppearance.BorderSize = 0
        Me.HERRAMIENTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HERRAMIENTA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HERRAMIENTA.ForeColor = System.Drawing.Color.Snow
        Me.HERRAMIENTA.Image = CType(resources.GetObject("HERRAMIENTA.Image"), System.Drawing.Image)
        Me.HERRAMIENTA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HERRAMIENTA.Location = New System.Drawing.Point(0, 198)
        Me.HERRAMIENTA.Name = "HERRAMIENTA"
        Me.HERRAMIENTA.Size = New System.Drawing.Size(198, 30)
        Me.HERRAMIENTA.TabIndex = 78
        Me.HERRAMIENTA.Text = "Herramientas"
        Me.HERRAMIENTA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.HERRAMIENTA, "Herramientas")
        Me.HERRAMIENTA.UseVisualStyleBackColor = False
        '
        'CLIENTE
        '
        Me.CLIENTE.BackColor = System.Drawing.Color.Gray
        Me.CLIENTE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.CLIENTE, BunifuAnimatorNS.DecorationType.None)
        Me.CLIENTE.FlatAppearance.BorderSize = 0
        Me.CLIENTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CLIENTE.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLIENTE.ForeColor = System.Drawing.Color.Snow
        Me.CLIENTE.Image = CType(resources.GetObject("CLIENTE.Image"), System.Drawing.Image)
        Me.CLIENTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CLIENTE.Location = New System.Drawing.Point(0, 126)
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.Size = New System.Drawing.Size(198, 30)
        Me.CLIENTE.TabIndex = 84
        Me.CLIENTE.Text = "Clientes"
        Me.CLIENTE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.CLIENTE, "Clientes")
        Me.CLIENTE.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.REPORTE)
        Me.Panel3.Controls.Add(Me.SALIR)
        Me.Panel3.Controls.Add(Me.REGISTRAR)
        Me.Panel3.Controls.Add(Me.INICIO)
        Me.Panel3.Controls.Add(Me.CLIENTE)
        Me.Panel3.Controls.Add(Me.HERRAMIENTA)
        Me.Panel3.Controls.Add(Me.SERVICIO)
        Me.BunifuTransition1.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(37, 743)
        Me.Panel3.TabIndex = 84
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.Button3, BunifuAnimatorNS.DecorationType.None)
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Snow
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 394)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(198, 30)
        Me.Button3.TabIndex = 90
        Me.Button3.Text = "Nuevo Correo"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button3, "Enviar un correo electronico")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.Button2, BunifuAnimatorNS.DecorationType.None)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Snow
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 650)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(198, 30)
        Me.Button2.TabIndex = 89
        Me.Button2.Text = "Acerca de"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button2, "Nuevo usuario")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'REPORTE
        '
        Me.REPORTE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.REPORTE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.REPORTE, BunifuAnimatorNS.DecorationType.None)
        Me.REPORTE.FlatAppearance.BorderSize = 0
        Me.REPORTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.REPORTE.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REPORTE.ForeColor = System.Drawing.Color.Snow
        Me.REPORTE.Image = CType(resources.GetObject("REPORTE.Image"), System.Drawing.Image)
        Me.REPORTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.REPORTE.Location = New System.Drawing.Point(0, 430)
        Me.REPORTE.Name = "REPORTE"
        Me.REPORTE.Size = New System.Drawing.Size(198, 30)
        Me.REPORTE.TabIndex = 88
        Me.REPORTE.Text = "Generar Reporte"
        Me.REPORTE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.REPORTE, "Generar un reporte")
        Me.REPORTE.UseVisualStyleBackColor = False
        '
        'SALIR
        '
        Me.SALIR.BackColor = System.Drawing.Color.Gray
        Me.SALIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.SALIR, BunifuAnimatorNS.DecorationType.None)
        Me.SALIR.FlatAppearance.BorderSize = 0
        Me.SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SALIR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALIR.ForeColor = System.Drawing.Color.Snow
        Me.SALIR.Image = CType(resources.GetObject("SALIR.Image"), System.Drawing.Image)
        Me.SALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SALIR.Location = New System.Drawing.Point(0, 686)
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(198, 30)
        Me.SALIR.TabIndex = 87
        Me.SALIR.Text = "Salir"
        Me.SALIR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.SALIR, "Cerrar sesión")
        Me.SALIR.UseVisualStyleBackColor = False
        '
        'REGISTRAR
        '
        Me.REGISTRAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.REGISTRAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.REGISTRAR, BunifuAnimatorNS.DecorationType.None)
        Me.REGISTRAR.FlatAppearance.BorderSize = 0
        Me.REGISTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.REGISTRAR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGISTRAR.ForeColor = System.Drawing.Color.Snow
        Me.REGISTRAR.Image = CType(resources.GetObject("REGISTRAR.Image"), System.Drawing.Image)
        Me.REGISTRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.REGISTRAR.Location = New System.Drawing.Point(0, 358)
        Me.REGISTRAR.Name = "REGISTRAR"
        Me.REGISTRAR.Size = New System.Drawing.Size(198, 30)
        Me.REGISTRAR.TabIndex = 86
        Me.REGISTRAR.Text = "Registrar"
        Me.REGISTRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.REGISTRAR, "Nuevo usuario")
        Me.REGISTRAR.UseVisualStyleBackColor = False
        '
        'INICIO
        '
        Me.INICIO.BackColor = System.Drawing.Color.Gray
        Me.INICIO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.INICIO, BunifuAnimatorNS.DecorationType.None)
        Me.INICIO.FlatAppearance.BorderSize = 0
        Me.INICIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.INICIO.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INICIO.ForeColor = System.Drawing.Color.Snow
        Me.INICIO.Image = CType(resources.GetObject("INICIO.Image"), System.Drawing.Image)
        Me.INICIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.INICIO.Location = New System.Drawing.Point(0, 90)
        Me.INICIO.Name = "INICIO"
        Me.INICIO.Size = New System.Drawing.Size(198, 30)
        Me.INICIO.TabIndex = 85
        Me.INICIO.Tag = ""
        Me.INICIO.Text = "Inicio"
        Me.INICIO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.INICIO, "Inicio")
        Me.INICIO.UseVisualStyleBackColor = False
        '
        'CONTENEDOR
        '
        Me.BunifuTransition1.SetDecoration(Me.CONTENEDOR, BunifuAnimatorNS.DecorationType.None)
        Me.CONTENEDOR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONTENEDOR.Location = New System.Drawing.Point(37, 45)
        Me.CONTENEDOR.Name = "CONTENEDOR"
        Me.CONTENEDOR.Size = New System.Drawing.Size(1326, 743)
        Me.CONTENEDOR.TabIndex = 85
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'MENU1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1363, 788)
        Me.Controls.Add(Me.CONTENEDOR)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MENU1"
        Me.Text = "MENU"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MINIMIZAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CERRAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MINIMIZAR As PictureBox
    Friend WithEvents CERRAR As PictureBox
    Friend WithEvents HORA As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents SERVICIO As Button
    Friend WithEvents HERRAMIENTA As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CLIENTE As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CONTENEDOR As Panel
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents INICIO As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents REGISTRAR As Button
    Friend WithEvents SALIR As Button
    Friend WithEvents REPORTE As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
