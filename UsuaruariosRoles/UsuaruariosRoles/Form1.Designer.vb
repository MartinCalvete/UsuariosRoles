<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.BtnNoUser = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.TxtUsuarioL = New System.Windows.Forms.TextBox()
        Me.TxtContraseñaL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnNoUser
        '
        Me.BtnNoUser.Location = New System.Drawing.Point(33, 133)
        Me.BtnNoUser.Name = "BtnNoUser"
        Me.BtnNoUser.Size = New System.Drawing.Size(103, 23)
        Me.BtnNoUser.TabIndex = 0
        Me.BtnNoUser.Text = "¿No eres usuario?"
        Me.BtnNoUser.UseVisualStyleBackColor = True
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(167, 133)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 1
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'TxtUsuarioL
        '
        Me.TxtUsuarioL.Location = New System.Drawing.Point(91, 25)
        Me.TxtUsuarioL.Name = "TxtUsuarioL"
        Me.TxtUsuarioL.Size = New System.Drawing.Size(170, 20)
        Me.TxtUsuarioL.TabIndex = 2
        '
        'TxtContraseñaL
        '
        Me.TxtContraseñaL.Location = New System.Drawing.Point(91, 75)
        Me.TxtContraseñaL.Name = "TxtContraseñaL"
        Me.TxtContraseñaL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseñaL.Size = New System.Drawing.Size(170, 20)
        Me.TxtContraseñaL.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 166)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnNoUser)
        Me.Controls.Add(Me.TxtUsuarioL)
        Me.Controls.Add(Me.TxtContraseñaL)
        Me.Controls.Add(Me.BtnLogin)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNoUser As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents TxtUsuarioL As TextBox
    Friend WithEvents TxtContraseñaL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
