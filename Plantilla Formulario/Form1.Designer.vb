<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButtonCambiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton10x7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8x6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6x4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonCambiar
        '
        Me.ButtonCambiar.AutoSize = True
        Me.ButtonCambiar.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonCambiar.Location = New System.Drawing.Point(0, 0)
        Me.ButtonCambiar.Name = "ButtonCambiar"
        Me.ButtonCambiar.Size = New System.Drawing.Size(140, 98)
        Me.ButtonCambiar.TabIndex = 3
        Me.ButtonCambiar.Text = "Cambiar Resolución"
        Me.ButtonCambiar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(235, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 98)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.RadioButton10x7)
        Me.GroupBox1.Controls.Add(Me.RadioButton8x6)
        Me.GroupBox1.Controls.Add(Me.RadioButton6x4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(140, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(95, 98)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resolución"
        '
        'RadioButton10x7
        '
        Me.RadioButton10x7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButton10x7.AutoSize = True
        Me.RadioButton10x7.Location = New System.Drawing.Point(6, 74)
        Me.RadioButton10x7.Name = "RadioButton10x7"
        Me.RadioButton10x7.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton10x7.TabIndex = 5
        Me.RadioButton10x7.TabStop = True
        Me.RadioButton10x7.Text = "1024 x 768"
        Me.RadioButton10x7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton10x7.UseVisualStyleBackColor = True
        '
        'RadioButton8x6
        '
        Me.RadioButton8x6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButton8x6.AutoSize = True
        Me.RadioButton8x6.Location = New System.Drawing.Point(6, 51)
        Me.RadioButton8x6.Name = "RadioButton8x6"
        Me.RadioButton8x6.Size = New System.Drawing.Size(72, 17)
        Me.RadioButton8x6.TabIndex = 4
        Me.RadioButton8x6.TabStop = True
        Me.RadioButton8x6.Text = "800 x 600"
        Me.RadioButton8x6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton8x6.UseVisualStyleBackColor = True
        '
        'RadioButton6x4
        '
        Me.RadioButton6x4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButton6x4.AutoSize = True
        Me.RadioButton6x4.Location = New System.Drawing.Point(6, 28)
        Me.RadioButton6x4.Name = "RadioButton6x4"
        Me.RadioButton6x4.Size = New System.Drawing.Size(72, 17)
        Me.RadioButton6x4.TabIndex = 3
        Me.RadioButton6x4.TabStop = True
        Me.RadioButton6x4.Text = "640 x 480"
        Me.RadioButton6x4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton6x4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 98)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonCambiar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resolución"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonCambiar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton10x7 As RadioButton
    Friend WithEvents RadioButton8x6 As RadioButton
    Friend WithEvents RadioButton6x4 As RadioButton
End Class
