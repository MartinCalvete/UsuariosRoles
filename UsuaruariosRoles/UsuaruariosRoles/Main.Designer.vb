<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblSaludo = New System.Windows.Forms.Label()
        Me.DgvTabla = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.gbA = New System.Windows.Forms.GroupBox()
        Me.habilitarbtn = New System.Windows.Forms.GroupBox()
        Me.BtnCamCont = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnDesactivar = New System.Windows.Forms.Button()
        Me.BtnActivar = New System.Windows.Forms.Button()
        CType(Me.DgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbA.SuspendLayout()
        Me.habilitarbtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BIENVENIDO"
        '
        'LblSaludo
        '
        Me.LblSaludo.AutoSize = True
        Me.LblSaludo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaludo.Location = New System.Drawing.Point(131, 16)
        Me.LblSaludo.Name = "LblSaludo"
        Me.LblSaludo.Size = New System.Drawing.Size(69, 18)
        Me.LblSaludo.TabIndex = 1
        Me.LblSaludo.Text = """nombre"""
        '
        'DgvTabla
        '
        Me.DgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTabla.Location = New System.Drawing.Point(28, 85)
        Me.DgvTabla.Name = "DgvTabla"
        Me.DgvTabla.Size = New System.Drawing.Size(570, 158)
        Me.DgvTabla.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Lista de usuarios "
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(6, 278)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(83, 31)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'gbA
        '
        Me.gbA.Controls.Add(Me.habilitarbtn)
        Me.gbA.Controls.Add(Me.BtnSalir)
        Me.gbA.Controls.Add(Me.Label2)
        Me.gbA.Controls.Add(Me.DgvTabla)
        Me.gbA.Controls.Add(Me.LblSaludo)
        Me.gbA.Controls.Add(Me.Label1)
        Me.gbA.Location = New System.Drawing.Point(3, 10)
        Me.gbA.Name = "gbA"
        Me.gbA.Size = New System.Drawing.Size(608, 319)
        Me.gbA.TabIndex = 8
        Me.gbA.TabStop = False
        '
        'habilitarbtn
        '
        Me.habilitarbtn.Controls.Add(Me.BtnCamCont)
        Me.habilitarbtn.Controls.Add(Me.Label3)
        Me.habilitarbtn.Controls.Add(Me.BtnActivar)
        Me.habilitarbtn.Controls.Add(Me.BtnDesactivar)
        Me.habilitarbtn.Location = New System.Drawing.Point(171, 259)
        Me.habilitarbtn.Name = "habilitarbtn"
        Me.habilitarbtn.Size = New System.Drawing.Size(427, 54)
        Me.habilitarbtn.TabIndex = 9
        Me.habilitarbtn.TabStop = False
        '
        'BtnCamCont
        '
        Me.BtnCamCont.Location = New System.Drawing.Point(6, 19)
        Me.BtnCamCont.Name = "BtnCamCont"
        Me.BtnCamCont.Size = New System.Drawing.Size(152, 31)
        Me.BtnCamCont.TabIndex = 5
        Me.BtnCamCont.Text = "Cambiar contraseña"
        Me.BtnCamCont.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Seleccione un usuario para ejecutar las siguientes funciones"
        '
        'BtnDesactivar
        '
        Me.BtnDesactivar.Location = New System.Drawing.Point(314, 19)
        Me.BtnDesactivar.Name = "BtnDesactivar"
        Me.BtnDesactivar.Size = New System.Drawing.Size(100, 31)
        Me.BtnDesactivar.TabIndex = 4
        Me.BtnDesactivar.Text = "Desactivar"
        Me.BtnDesactivar.UseVisualStyleBackColor = True
        '
        'BtnActivar
        '
        Me.BtnActivar.Location = New System.Drawing.Point(188, 19)
        Me.BtnActivar.Name = "BtnActivar"
        Me.BtnActivar.Size = New System.Drawing.Size(100, 31)
        Me.BtnActivar.TabIndex = 3
        Me.BtnActivar.Text = "Activar"
        Me.BtnActivar.UseVisualStyleBackColor = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 332)
        Me.Controls.Add(Me.gbA)
        Me.Name = "MenuPrincipal"
        Me.Text = "Menu principal"
        CType(Me.DgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbA.ResumeLayout(False)
        Me.gbA.PerformLayout()
        Me.habilitarbtn.ResumeLayout(False)
        Me.habilitarbtn.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblSaludo As Label
    Friend WithEvents DgvTabla As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents gbA As GroupBox
    Friend WithEvents habilitarbtn As GroupBox
    Friend WithEvents BtnCamCont As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnDesactivar As Button
    Friend WithEvents BtnActivar As Button
End Class
