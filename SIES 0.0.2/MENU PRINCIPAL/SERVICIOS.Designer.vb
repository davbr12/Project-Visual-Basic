<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SERVICIOS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SERVICIOS))
        Me.CONTENEDOR = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AMARILLO = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VIEWCLIENTES = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.REPORTE = New System.Windows.Forms.Button()
        Me.ELIMINAR = New System.Windows.Forms.Button()
        Me.ACTUALIZAR = New System.Windows.Forms.Button()
        Me.AÑADIR = New System.Windows.Forms.Button()
        Me.LIMPIAR = New System.Windows.Forms.Button()
        Me.VER = New System.Windows.Forms.Button()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtservicio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPreciou = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CONTENEDOR.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VIEWCLIENTES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CONTENEDOR
        '
        Me.CONTENEDOR.Controls.Add(Me.Panel1)
        Me.CONTENEDOR.Controls.Add(Me.AMARILLO)
        Me.CONTENEDOR.Controls.Add(Me.PictureBox1)
        Me.CONTENEDOR.Dock = System.Windows.Forms.DockStyle.Top
        Me.CONTENEDOR.Location = New System.Drawing.Point(0, 0)
        Me.CONTENEDOR.Name = "CONTENEDOR"
        Me.CONTENEDOR.Size = New System.Drawing.Size(1313, 289)
        Me.CONTENEDOR.TabIndex = 80
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(1072, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 288)
        Me.Panel1.TabIndex = 77
        '
        'AMARILLO
        '
        Me.AMARILLO.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AMARILLO.Location = New System.Drawing.Point(-12, 1)
        Me.AMARILLO.Name = "AMARILLO"
        Me.AMARILLO.Size = New System.Drawing.Size(288, 293)
        Me.AMARILLO.TabIndex = 76
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(267, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(825, 293)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcod)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.VIEWCLIENTES)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtDescrip)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtservicio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTiempo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPreciou)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtItem)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1304, 467)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de servicios"
        '
        'txtcod
        '
        Me.txtcod.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcod.Location = New System.Drawing.Point(179, 43)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(88, 23)
        Me.txtcod.TabIndex = 174
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 17)
        Me.Label5.TabIndex = 173
        Me.Label5.Text = "Codigo de herramienta:"
        '
        'VIEWCLIENTES
        '
        Me.VIEWCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VIEWCLIENTES.Location = New System.Drawing.Point(7, 203)
        Me.VIEWCLIENTES.Name = "VIEWCLIENTES"
        Me.VIEWCLIENTES.Size = New System.Drawing.Size(819, 238)
        Me.VIEWCLIENTES.TabIndex = 172
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.REPORTE)
        Me.GroupBox2.Controls.Add(Me.ELIMINAR)
        Me.GroupBox2.Controls.Add(Me.ACTUALIZAR)
        Me.GroupBox2.Controls.Add(Me.AÑADIR)
        Me.GroupBox2.Controls.Add(Me.LIMPIAR)
        Me.GroupBox2.Controls.Add(Me.VER)
        Me.GroupBox2.Location = New System.Drawing.Point(842, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 162)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opción"
        '
        'REPORTE
        '
        Me.REPORTE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.REPORTE.FlatAppearance.BorderSize = 0
        Me.REPORTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.REPORTE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.REPORTE.Location = New System.Drawing.Point(6, 114)
        Me.REPORTE.Name = "REPORTE"
        Me.REPORTE.Size = New System.Drawing.Size(208, 38)
        Me.REPORTE.TabIndex = 6
        Me.REPORTE.Text = "Reporte"
        Me.REPORTE.UseVisualStyleBackColor = False
        '
        'ELIMINAR
        '
        Me.ELIMINAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ELIMINAR.FlatAppearance.BorderSize = 0
        Me.ELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ELIMINAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ELIMINAR.Location = New System.Drawing.Point(234, 70)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(208, 38)
        Me.ELIMINAR.TabIndex = 4
        Me.ELIMINAR.Text = "Eliminar"
        Me.ELIMINAR.UseVisualStyleBackColor = False
        '
        'ACTUALIZAR
        '
        Me.ACTUALIZAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ACTUALIZAR.FlatAppearance.BorderSize = 0
        Me.ACTUALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ACTUALIZAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ACTUALIZAR.Location = New System.Drawing.Point(6, 70)
        Me.ACTUALIZAR.Name = "ACTUALIZAR"
        Me.ACTUALIZAR.Size = New System.Drawing.Size(208, 38)
        Me.ACTUALIZAR.TabIndex = 3
        Me.ACTUALIZAR.Text = "Actualizar"
        Me.ACTUALIZAR.UseVisualStyleBackColor = False
        '
        'AÑADIR
        '
        Me.AÑADIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AÑADIR.FlatAppearance.BorderSize = 0
        Me.AÑADIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AÑADIR.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AÑADIR.Location = New System.Drawing.Point(6, 26)
        Me.AÑADIR.Name = "AÑADIR"
        Me.AÑADIR.Size = New System.Drawing.Size(208, 38)
        Me.AÑADIR.TabIndex = 2
        Me.AÑADIR.Text = "Añadir"
        Me.AÑADIR.UseVisualStyleBackColor = False
        '
        'LIMPIAR
        '
        Me.LIMPIAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.LIMPIAR.FlatAppearance.BorderSize = 0
        Me.LIMPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LIMPIAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LIMPIAR.Location = New System.Drawing.Point(234, 114)
        Me.LIMPIAR.Name = "LIMPIAR"
        Me.LIMPIAR.Size = New System.Drawing.Size(208, 38)
        Me.LIMPIAR.TabIndex = 1
        Me.LIMPIAR.Text = "Limpiar"
        Me.LIMPIAR.UseVisualStyleBackColor = False
        '
        'VER
        '
        Me.VER.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VER.FlatAppearance.BorderSize = 0
        Me.VER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VER.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VER.Location = New System.Drawing.Point(234, 26)
        Me.VER.Name = "VER"
        Me.VER.Size = New System.Drawing.Size(208, 38)
        Me.VER.TabIndex = 0
        Me.VER.Text = "Ver"
        Me.VER.UseVisualStyleBackColor = False
        '
        'txtDescrip
        '
        Me.txtDescrip.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrip.Location = New System.Drawing.Point(756, 39)
        Me.txtDescrip.Multiline = True
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(510, 125)
        Me.txtDescrip.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(668, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Decripcion:"
        '
        'txtservicio
        '
        Me.txtservicio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtservicio.Location = New System.Drawing.Point(407, 79)
        Me.txtservicio.Name = "txtservicio"
        Me.txtservicio.Size = New System.Drawing.Size(241, 23)
        Me.txtservicio.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(282, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre Servicio:"
        '
        'txtTiempo
        '
        Me.txtTiempo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTiempo.Location = New System.Drawing.Point(407, 108)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(241, 23)
        Me.txtTiempo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(283, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tiempo a Ejercer:"
        '
        'txtPreciou
        '
        Me.txtPreciou.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreciou.Location = New System.Drawing.Point(407, 144)
        Me.txtPreciou.Name = "txtPreciou"
        Me.txtPreciou.Size = New System.Drawing.Size(241, 23)
        Me.txtPreciou.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(283, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio unitaro:"
        '
        'txtItem
        '
        Me.txtItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Location = New System.Drawing.Point(407, 43)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(241, 23)
        Me.txtItem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No de Item:"
        '
        'SERVICIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1330, 743)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CONTENEDOR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SERVICIOS"
        Me.Text = "SERVICIOS"
        Me.CONTENEDOR.ResumeLayout(False)
        Me.CONTENEDOR.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VIEWCLIENTES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CONTENEDOR As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AMARILLO As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VIEWCLIENTES As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ELIMINAR As Button
    Friend WithEvents ACTUALIZAR As Button
    Friend WithEvents AÑADIR As Button
    Friend WithEvents LIMPIAR As Button
    Friend WithEvents VER As Button
    Friend WithEvents txtDescrip As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtservicio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTiempo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPreciou As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtItem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents REPORTE As Button
    Friend WithEvents txtcod As TextBox
    Friend WithEvents Label5 As Label
End Class
