<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class info_producto
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
        Me.lblnameP = New System.Windows.Forms.Label()
        Me.lblprecio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbldisponible = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnvender = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblnameP
        '
        Me.lblnameP.AutoSize = True
        Me.lblnameP.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnameP.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblnameP.Location = New System.Drawing.Point(72, 9)
        Me.lblnameP.Name = "lblnameP"
        Me.lblnameP.Size = New System.Drawing.Size(112, 33)
        Me.lblnameP.TabIndex = 0
        Me.lblnameP.Text = "product"
        '
        'lblprecio
        '
        Me.lblprecio.AutoSize = True
        Me.lblprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecio.Location = New System.Drawing.Point(189, 70)
        Me.lblprecio.Name = "lblprecio"
        Me.lblprecio.Size = New System.Drawing.Size(66, 25)
        Me.lblprecio.TabIndex = 1
        Me.lblprecio.Text = "12.30"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Disponibles"
        '
        'lbldisponible
        '
        Me.lbldisponible.AutoSize = True
        Me.lbldisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisponible.Location = New System.Drawing.Point(189, 128)
        Me.lbldisponible.Name = "lbldisponible"
        Me.lbldisponible.Size = New System.Drawing.Size(36, 25)
        Me.lbldisponible.TabIndex = 4
        Me.lbldisponible.Text = "10"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Orange
        Me.btnEditar.Location = New System.Drawing.Point(30, 69)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(139, 39)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnvender
        '
        Me.btnvender.BackColor = System.Drawing.Color.LimeGreen
        Me.btnvender.Location = New System.Drawing.Point(30, 14)
        Me.btnvender.Name = "btnvender"
        Me.btnvender.Size = New System.Drawing.Size(139, 49)
        Me.btnvender.TabIndex = 6
        Me.btnvender.Text = "Vender"
        Me.btnvender.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.btneliminar)
        Me.Panel1.Controls.Add(Me.btncerrar)
        Me.Panel1.Controls.Add(Me.btnvender)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Location = New System.Drawing.Point(261, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 282)
        Me.Panel1.TabIndex = 7
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(62, 232)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(80, 38)
        Me.btncerrar.TabIndex = 7
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Location = New System.Drawing.Point(3, 4)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(39, 13)
        Me.lbldesc.TabIndex = 8
        Me.lbldesc.Text = "Label4"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.lbldesc)
        Me.Panel2.Location = New System.Drawing.Point(17, 211)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 84)
        Me.Panel2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "descripcion"
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.OrangeRed
        Me.btneliminar.Location = New System.Drawing.Point(30, 119)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(139, 35)
        Me.btneliminar.TabIndex = 8
        Me.btneliminar.Text = "eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'info_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(478, 303)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbldisponible)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblprecio)
        Me.Controls.Add(Me.lblnameP)
        Me.Name = "info_producto"
        Me.Text = "info_producto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnameP As Label
    Friend WithEvents lblprecio As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbldisponible As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnvender As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbldesc As Label
    Friend WithEvents btncerrar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btneliminar As Button
End Class
