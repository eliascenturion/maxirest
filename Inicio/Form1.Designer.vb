<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelContraseña = New System.Windows.Forms.Label()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.PanelMains = New System.Windows.Forms.Panel()
        Me.Panel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelMains.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel.Controls.Add(Me.btnCerrar)
        Me.Panel.Controls.Add(Me.btnAceptar)
        Me.Panel.Controls.Add(Me.Panel2)
        Me.Panel.Controls.Add(Me.Panel3)
        Me.Panel.Controls.Add(Me.TextBox2)
        Me.Panel.Controls.Add(Me.TextBox1)
        Me.Panel.Controls.Add(Me.LabelContraseña)
        Me.Panel.Controls.Add(Me.LabelUsuario)
        Me.Panel.Location = New System.Drawing.Point(469, 265)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(393, 190)
        Me.Panel.TabIndex = 2
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.DarkOrange
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(51, 134)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(56, 44)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAceptar.BackgroundImage = Global.Inicio.My.Resources.Resources.confirm_1174801_960_720
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Location = New System.Drawing.Point(308, 134)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(59, 44)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(75, 60)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(0, 14)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(393, 18)
        Me.Panel3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(188, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "INICIO DE SESIÓN"
        '
        'TextBox2
        '
        Me.TextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox2.Location = New System.Drawing.Point(166, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(201, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(166, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 20)
        Me.TextBox1.TabIndex = 1
        '
        'LabelContraseña
        '
        Me.LabelContraseña.AutoSize = True
        Me.LabelContraseña.BackColor = System.Drawing.Color.DarkOrange
        Me.LabelContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelContraseña.Location = New System.Drawing.Point(47, 93)
        Me.LabelContraseña.Name = "LabelContraseña"
        Me.LabelContraseña.Size = New System.Drawing.Size(113, 22)
        Me.LabelContraseña.TabIndex = 1
        Me.LabelContraseña.Text = "Contraseña"
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.BackColor = System.Drawing.Color.DarkOrange
        Me.LabelUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelUsuario.Location = New System.Drawing.Point(81, 54)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(79, 22)
        Me.LabelUsuario.TabIndex = 0
        Me.LabelUsuario.Text = "Usuario"
        '
        'PanelMains
        '
        Me.PanelMains.BackColor = System.Drawing.Color.Orange
        Me.PanelMains.Controls.Add(Me.Panel)
        Me.PanelMains.Location = New System.Drawing.Point(0, 0)
        Me.PanelMains.Name = "PanelMains"
        Me.PanelMains.Size = New System.Drawing.Size(1656, 726)
        Me.PanelMains.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1360, 768)
        Me.Controls.Add(Me.PanelMains)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INICIO DE SESIÓN"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PanelMains.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelContraseña As Label
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents PanelMains As Panel
    Friend WithEvents btnCerrar As Button
End Class
