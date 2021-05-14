<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editar
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
        Me.lblNameHeader = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNameHeader
        '
        Me.lblNameHeader.AutoSize = True
        Me.lblNameHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblNameHeader.Location = New System.Drawing.Point(146, 20)
        Me.lblNameHeader.Name = "lblNameHeader"
        Me.lblNameHeader.Size = New System.Drawing.Size(169, 55)
        Me.lblNameHeader.TabIndex = 0
        Me.lblNameHeader.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "descripcion"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(156, 123)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(159, 20)
        Me.txtname.TabIndex = 1
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(156, 172)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(159, 20)
        Me.txtprecio.TabIndex = 1
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(156, 223)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(159, 20)
        Me.txtcantidad.TabIndex = 1
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(156, 272)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(159, 20)
        Me.txtdesc.TabIndex = 1
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.OrangeRed
        Me.btncancel.Location = New System.Drawing.Point(156, 355)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(159, 37)
        Me.btncancel.TabIndex = 2
        Me.btncancel.Text = "cancelar"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnactualizar
        '
        Me.btnactualizar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnactualizar.Location = New System.Drawing.Point(156, 307)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(159, 42)
        Me.btnactualizar.TabIndex = 2
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 395)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNameHeader)
        Me.Name = "editar"
        Me.Text = "editar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNameHeader As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btnactualizar As Button
End Class
