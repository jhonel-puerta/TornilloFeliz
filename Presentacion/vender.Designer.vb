<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vender
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblcant = New System.Windows.Forms.Label()
        Me.bntVender = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblnameP
        '
        Me.lblnameP.AutoSize = True
        Me.lblnameP.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnameP.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblnameP.Location = New System.Drawing.Point(53, 9)
        Me.lblnameP.Name = "lblnameP"
        Me.lblnameP.Size = New System.Drawing.Size(131, 42)
        Me.lblnameP.TabIndex = 0
        Me.lblnameP.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.BackColor = System.Drawing.Color.DarkOrange
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(167, 85)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(66, 24)
        Me.lblPrecio.TabIndex = 1
        Me.lblPrecio.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "cantidad"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(3, 5)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(63, 13)
        Me.lblDesc.TabIndex = 0
        Me.lblDesc.Text = "Descripcion"
        '
        'lblcant
        '
        Me.lblcant.AutoSize = True
        Me.lblcant.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcant.Location = New System.Drawing.Point(167, 129)
        Me.lblcant.Name = "lblcant"
        Me.lblcant.Size = New System.Drawing.Size(66, 24)
        Me.lblcant.TabIndex = 1
        Me.lblcant.Text = "Label2"
        '
        'bntVender
        '
        Me.bntVender.BackColor = System.Drawing.Color.LimeGreen
        Me.bntVender.Location = New System.Drawing.Point(138, 185)
        Me.bntVender.Name = "bntVender"
        Me.bntVender.Size = New System.Drawing.Size(95, 46)
        Me.bntVender.TabIndex = 2
        Me.bntVender.Text = "Vender"
        Me.bntVender.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAgregar.Location = New System.Drawing.Point(27, 185)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(95, 46)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar +"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.lblDesc)
        Me.Panel1.Location = New System.Drawing.Point(282, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(175, 122)
        Me.Panel1.TabIndex = 3
        '
        'vender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 256)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.bntVender)
        Me.Controls.Add(Me.lblcant)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblnameP)
        Me.Name = "vender"
        Me.Text = "vender"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnameP As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblcant As Label
    Friend WithEvents bntVender As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
