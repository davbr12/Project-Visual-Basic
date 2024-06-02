<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CREAR
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BUSCAR = New System.Windows.Forms.TextBox()
        Me.BuscarItem = New System.Windows.Forms.Label()
        Me.VIEWCLIENTES = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.REPORTE = New System.Windows.Forms.Button()
        Me.ELIMINAR = New System.Windows.Forms.Button()
        Me.ACTUALIZAR = New System.Windows.Forms.Button()
        Me.AÑADIR = New System.Windows.Forms.Button()
        Me.LIMPIAR = New System.Windows.Forms.Button()
        Me.VER = New System.Windows.Forms.Button()
        Me.RESPUESTA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.HISTORIAL = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EMAIL = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TELEFONO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ATENCION = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ITEM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DIRECCION = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FINALDataSet = New SIES_0._0._2.FINALDataSet()
        Me.FINALDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.VIEWCLIENTES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINALDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BUSCAR)
        Me.GroupBox1.Controls.Add(Me.BuscarItem)
        Me.GroupBox1.Controls.Add(Me.VIEWCLIENTES)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.RESPUESTA)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.HISTORIAL)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.EMAIL)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TELEFONO)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ATENCION)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ITEM)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DIRECCION)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1289, 411)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Cliente"
        '
        'BUSCAR
        '
        Me.BUSCAR.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUSCAR.Location = New System.Drawing.Point(561, 26)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(334, 23)
        Me.BUSCAR.TabIndex = 176
        '
        'BuscarItem
        '
        Me.BuscarItem.AutoSize = True
        Me.BuscarItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarItem.Location = New System.Drawing.Point(419, 29)
        Me.BuscarItem.Name = "BuscarItem"
        Me.BuscarItem.Size = New System.Drawing.Size(136, 17)
        Me.BuscarItem.TabIndex = 175
        Me.BuscarItem.Text = "Buscar Item Cliente:"
        '
        'VIEWCLIENTES
        '
        Me.VIEWCLIENTES.AllowUserToAddRows = False
        Me.VIEWCLIENTES.AllowUserToDeleteRows = False
        Me.VIEWCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VIEWCLIENTES.Location = New System.Drawing.Point(7, 202)
        Me.VIEWCLIENTES.Name = "VIEWCLIENTES"
        Me.VIEWCLIENTES.ReadOnly = True
        Me.VIEWCLIENTES.Size = New System.Drawing.Size(809, 198)
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
        Me.GroupBox2.Location = New System.Drawing.Point(827, 237)
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
        Me.REPORTE.Location = New System.Drawing.Point(6, 117)
        Me.REPORTE.Name = "REPORTE"
        Me.REPORTE.Size = New System.Drawing.Size(208, 38)
        Me.REPORTE.TabIndex = 5
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
        'RESPUESTA
        '
        Me.RESPUESTA.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESPUESTA.Location = New System.Drawing.Point(750, 163)
        Me.RESPUESTA.Name = "RESPUESTA"
        Me.RESPUESTA.Size = New System.Drawing.Size(334, 23)
        Me.RESPUESTA.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(667, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Respuesta:"
        '
        'HISTORIAL
        '
        Me.HISTORIAL.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HISTORIAL.Location = New System.Drawing.Point(750, 134)
        Me.HISTORIAL.Name = "HISTORIAL"
        Me.HISTORIAL.Size = New System.Drawing.Size(334, 23)
        Me.HISTORIAL.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(682, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Historial:"
        '
        'EMAIL
        '
        Me.EMAIL.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMAIL.Location = New System.Drawing.Point(311, 134)
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.Size = New System.Drawing.Size(334, 23)
        Me.EMAIL.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(246, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "E - mail:"
        '
        'TELEFONO
        '
        Me.TELEFONO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TELEFONO.Location = New System.Drawing.Point(750, 105)
        Me.TELEFONO.Name = "TELEFONO"
        Me.TELEFONO.Size = New System.Drawing.Size(334, 23)
        Me.TELEFONO.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(678, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Telefóno:"
        '
        'ATENCION
        '
        Me.ATENCION.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATENCION.Location = New System.Drawing.Point(311, 105)
        Me.ATENCION.Name = "ATENCION"
        Me.ATENCION.Size = New System.Drawing.Size(334, 23)
        Me.ATENCION.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Atención a:"
        '
        'ITEM
        '
        Me.ITEM.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITEM.Location = New System.Drawing.Point(311, 163)
        Me.ITEM.Name = "ITEM"
        Me.ITEM.Size = New System.Drawing.Size(334, 23)
        Me.ITEM.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(214, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Item Cliente:"
        '
        'DIRECCION
        '
        Me.DIRECCION.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIRECCION.Location = New System.Drawing.Point(750, 72)
        Me.DIRECCION.Name = "DIRECCION"
        Me.DIRECCION.Size = New System.Drawing.Size(334, 23)
        Me.DIRECCION.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(671, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dirección:"
        '
        'NOMBRE
        '
        Me.NOMBRE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRE.Location = New System.Drawing.Point(311, 69)
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Size = New System.Drawing.Size(334, 23)
        Me.NOMBRE.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre completo:"
        '
        'FINALDataSet
        '
        Me.FINALDataSet.DataSetName = "FINALDataSet"
        Me.FINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FINALDataSetBindingSource
        '
        Me.FINALDataSetBindingSource.DataSource = Me.FINALDataSet
        Me.FINALDataSetBindingSource.Position = 0
        '
        'CREAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1330, 371)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CREAR"
        Me.Text = "CREAR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VIEWCLIENTES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINALDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RESPUESTA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents HISTORIAL As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents EMAIL As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TELEFONO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ATENCION As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ITEM As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DIRECCION As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NOMBRE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LIMPIAR As Button
    Friend WithEvents VER As Button
    Friend WithEvents ELIMINAR As Button
    Friend WithEvents ACTUALIZAR As Button
    Friend WithEvents AÑADIR As Button
    Friend WithEvents VIEWCLIENTES As DataGridView
    Friend WithEvents REPORTE As Button
    Friend WithEvents FINALDataSetBindingSource As BindingSource
    Friend WithEvents FINALDataSet As FINALDataSet
    Friend WithEvents BUSCAR As TextBox
    Friend WithEvents BuscarItem As Label
End Class
