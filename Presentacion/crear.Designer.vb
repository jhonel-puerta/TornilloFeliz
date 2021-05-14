<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crear
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btncrear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(124, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Crear"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(185, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Descripcion"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(137, 144)
        Me.txtname.Multiline = True
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(162, 34)
        Me.txtname.TabIndex = 2
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(137, 207)
        Me.txtprecio.Multiline = True
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(162, 34)
        Me.txtprecio.TabIndex = 2
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(137, 271)
        Me.txtcantidad.Multiline = True
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(162, 34)
        Me.txtcantidad.TabIndex = 2
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(137, 336)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(162, 34)
        Me.txtdesc.TabIndex = 2
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.OrangeRed
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btncancel.Location = New System.Drawing.Point(105, 383)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(112, 39)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btncrear
        '
        Me.btncrear.BackColor = System.Drawing.Color.LimeGreen
        Me.btncrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncrear.Location = New System.Drawing.Point(223, 383)
        Me.btncrear.Name = "btncrear"
        Me.btncrear.Size = New System.Drawing.Size(121, 39)
        Me.btncrear.TabIndex = 3
        Me.btncrear.Text = "Crear"
        Me.btncrear.UseVisualStyleBackColor = False
        '
        'crear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 434)
        Me.Controls.Add(Me.btncrear)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "crear"
        Me.Text = "crear"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btncrear As Button
End Class
