<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CLIENTES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CLIENTES))
        Me.CONTENEDOR = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AMARILLO = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AÑADIR = New System.Windows.Forms.Button()
        Me.LISTA = New System.Windows.Forms.Button()
        Me.CONTENEDOR2 = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.CONTENEDOR.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
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
        Me.CONTENEDOR.Size = New System.Drawing.Size(1330, 289)
        Me.CONTENEDOR.TabIndex = 78
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(1070, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 288)
        Me.Panel1.TabIndex = 77
        '
        'AMARILLO
        '
        Me.AMARILLO.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AMARILLO.Location = New System.Drawing.Point(-12, 1)
        Me.AMARILLO.Name = "AMARILLO"
        Me.AMARILLO.Size = New System.Drawing.Size(290, 293)
        Me.AMARILLO.TabIndex = 76
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(273, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(825, 293)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel3.Controls.Add(Me.AÑADIR)
        Me.Panel3.Controls.Add(Me.LISTA)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 289)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1330, 48)
        Me.Panel3.TabIndex = 80
        '
        'AÑADIR
        '
        Me.AÑADIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.AÑADIR.FlatAppearance.BorderSize = 0
        Me.AÑADIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AÑADIR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AÑADIR.ForeColor = System.Drawing.Color.Snow
        Me.AÑADIR.Image = CType(resources.GetObject("AÑADIR.Image"), System.Drawing.Image)
        Me.AÑADIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AÑADIR.Location = New System.Drawing.Point(1180, 9)
        Me.AÑADIR.Name = "AÑADIR"
        Me.AÑADIR.Size = New System.Drawing.Size(150, 30)
        Me.AÑADIR.TabIndex = 86
        Me.AÑADIR.Text = "Añadir"
        Me.AÑADIR.UseVisualStyleBackColor = False
        '
        'LISTA
        '
        Me.LISTA.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LISTA.FlatAppearance.BorderSize = 0
        Me.LISTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LISTA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LISTA.ForeColor = System.Drawing.Color.Snow
        Me.LISTA.Image = CType(resources.GetObject("LISTA.Image"), System.Drawing.Image)
        Me.LISTA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LISTA.Location = New System.Drawing.Point(1024, 9)
        Me.LISTA.Name = "LISTA"
        Me.LISTA.Size = New System.Drawing.Size(150, 30)
        Me.LISTA.TabIndex = 85
        Me.LISTA.Text = "Listado"
        Me.LISTA.UseVisualStyleBackColor = False
        '
        'CONTENEDOR2
        '
        Me.CONTENEDOR2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONTENEDOR2.Location = New System.Drawing.Point(0, 337)
        Me.CONTENEDOR2.Name = "CONTENEDOR2"
        Me.CONTENEDOR2.Size = New System.Drawing.Size(1330, 406)
        Me.CONTENEDOR2.TabIndex = 81
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'CLIENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1330, 743)
        Me.Controls.Add(Me.CONTENEDOR2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.CONTENEDOR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CLIENTES"
        Me.Text = "CLIENTES"
        Me.CONTENEDOR.ResumeLayout(False)
        Me.CONTENEDOR.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CONTENEDOR As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AMARILLO As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LISTA As Button
    Friend WithEvents AÑADIR As Button
    Friend WithEvents CONTENEDOR2 As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
