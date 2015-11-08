<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Potenciometro
    Inherits System.Windows.Forms.UserControl

    'Potenciometro reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.Percent0 = New System.Windows.Forms.Label()
        Me.Percent10 = New System.Windows.Forms.Label()
        Me.Percent20 = New System.Windows.Forms.Label()
        Me.Percent30 = New System.Windows.Forms.Label()
        Me.Percent40 = New System.Windows.Forms.Label()
        Me.Percent50 = New System.Windows.Forms.Label()
        Me.Percent60 = New System.Windows.Forms.Label()
        Me.Percent70 = New System.Windows.Forms.Label()
        Me.Percent80 = New System.Windows.Forms.Label()
        Me.Percent90 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Percent0
        '
        Me.Percent0.BackColor = System.Drawing.Color.DarkGray
        Me.Percent0.Location = New System.Drawing.Point(5, 5)
        Me.Percent0.Name = "Percent0"
        Me.Percent0.Size = New System.Drawing.Size(30, 10)
        Me.Percent0.TabIndex = 0
        '
        'Percent10
        '
        Me.Percent10.BackColor = System.Drawing.Color.DarkGray
        Me.Percent10.Location = New System.Drawing.Point(40, 5)
        Me.Percent10.Name = "Percent10"
        Me.Percent10.Size = New System.Drawing.Size(30, 10)
        Me.Percent10.TabIndex = 1
        '
        'Percent20
        '
        Me.Percent20.BackColor = System.Drawing.Color.DarkGray
        Me.Percent20.Location = New System.Drawing.Point(75, 5)
        Me.Percent20.Name = "Percent20"
        Me.Percent20.Size = New System.Drawing.Size(30, 10)
        Me.Percent20.TabIndex = 2
        '
        'Percent30
        '
        Me.Percent30.BackColor = System.Drawing.Color.DarkGray
        Me.Percent30.Location = New System.Drawing.Point(110, 5)
        Me.Percent30.Name = "Percent30"
        Me.Percent30.Size = New System.Drawing.Size(30, 10)
        Me.Percent30.TabIndex = 3
        '
        'Percent40
        '
        Me.Percent40.BackColor = System.Drawing.Color.DarkGray
        Me.Percent40.Location = New System.Drawing.Point(145, 5)
        Me.Percent40.Name = "Percent40"
        Me.Percent40.Size = New System.Drawing.Size(30, 10)
        Me.Percent40.TabIndex = 4
        '
        'Percent50
        '
        Me.Percent50.BackColor = System.Drawing.Color.DarkGray
        Me.Percent50.Location = New System.Drawing.Point(180, 5)
        Me.Percent50.Name = "Percent50"
        Me.Percent50.Size = New System.Drawing.Size(30, 10)
        Me.Percent50.TabIndex = 5
        '
        'Percent60
        '
        Me.Percent60.BackColor = System.Drawing.Color.DarkGray
        Me.Percent60.Location = New System.Drawing.Point(215, 5)
        Me.Percent60.Name = "Percent60"
        Me.Percent60.Size = New System.Drawing.Size(30, 10)
        Me.Percent60.TabIndex = 6
        '
        'Percent70
        '
        Me.Percent70.BackColor = System.Drawing.Color.DarkGray
        Me.Percent70.Location = New System.Drawing.Point(250, 5)
        Me.Percent70.Name = "Percent70"
        Me.Percent70.Size = New System.Drawing.Size(30, 10)
        Me.Percent70.TabIndex = 7
        '
        'Percent80
        '
        Me.Percent80.BackColor = System.Drawing.Color.DarkGray
        Me.Percent80.Location = New System.Drawing.Point(285, 5)
        Me.Percent80.Name = "Percent80"
        Me.Percent80.Size = New System.Drawing.Size(30, 10)
        Me.Percent80.TabIndex = 8
        '
        'Percent90
        '
        Me.Percent90.BackColor = System.Drawing.Color.DarkGray
        Me.Percent90.Location = New System.Drawing.Point(320, 5)
        Me.Percent90.Name = "Percent90"
        Me.Percent90.Size = New System.Drawing.Size(30, 10)
        Me.Percent90.TabIndex = 9
        '
        'Potenciometro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Percent90)
        Me.Controls.Add(Me.Percent80)
        Me.Controls.Add(Me.Percent70)
        Me.Controls.Add(Me.Percent60)
        Me.Controls.Add(Me.Percent50)
        Me.Controls.Add(Me.Percent40)
        Me.Controls.Add(Me.Percent30)
        Me.Controls.Add(Me.Percent20)
        Me.Controls.Add(Me.Percent10)
        Me.Controls.Add(Me.Percent0)
        Me.Name = "Potenciometro"
        Me.Size = New System.Drawing.Size(355, 20)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Percent0 As Label
    Friend WithEvents Percent10 As Label
    Friend WithEvents Percent20 As Label
    Friend WithEvents Percent30 As Label
    Friend WithEvents Percent40 As Label
    Friend WithEvents Percent50 As Label
    Friend WithEvents Percent60 As Label
    Friend WithEvents Percent70 As Label
    Friend WithEvents Percent80 As Label
    Friend WithEvents Percent90 As Label
End Class
