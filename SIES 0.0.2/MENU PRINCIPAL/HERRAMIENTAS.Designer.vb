<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HERRAMIENTAS
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HERRAMIENTAS))
        Me.CONTENEDOR = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AMARILLO = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.CONTENEDOR.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CONTENEDOR.TabIndex = 79
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
        Me.AMARILLO.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.AMARILLO.Location = New System.Drawing.Point(-12, 1)
        Me.AMARILLO.Name = "AMARILLO"
        Me.AMARILLO.Size = New System.Drawing.Size(265, 293)
        Me.AMARILLO.TabIndex = 76
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(249, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(825, 293)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'HERRAMIENTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1330, 743)
        Me.Controls.Add(Me.CONTENEDOR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HERRAMIENTAS"
        Me.Text = "HERRAMIENTAS"
        Me.CONTENEDOR.ResumeLayout(False)
        Me.CONTENEDOR.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CONTENEDOR As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AMARILLO As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
