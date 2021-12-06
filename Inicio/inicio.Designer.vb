<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCargos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.btnStock)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnCargos)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 797)
        Me.Panel1.TabIndex = 5
        '
        'btnStock
        '
        Me.btnStock.BackColor = System.Drawing.Color.Gold
        Me.btnStock.BackgroundImage = CType(resources.GetObject("btnStock.BackgroundImage"), System.Drawing.Image)
        Me.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStock.FlatAppearance.BorderSize = 0
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStock.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnStock.Location = New System.Drawing.Point(-85, 157)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(285, 67)
        Me.btnStock.TabIndex = 7
        Me.btnStock.Text = "Stock"
        Me.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStock.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gold
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(-77, 361)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(277, 66)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Facturas"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(-12, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(212, 59)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Abrir Turno"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnCargos
        '
        Me.btnCargos.BackColor = System.Drawing.Color.Gold
        Me.btnCargos.BackgroundImage = CType(resources.GetObject("btnCargos.BackgroundImage"), System.Drawing.Image)
        Me.btnCargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCargos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargos.FlatAppearance.BorderSize = 0
        Me.btnCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCargos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargos.Location = New System.Drawing.Point(-93, 260)
        Me.btnCargos.Name = "btnCargos"
        Me.btnCargos.Size = New System.Drawing.Size(293, 61)
        Me.btnCargos.TabIndex = 10
        Me.btnCargos.Text = "Empleados"
        Me.btnCargos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCargos.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(12, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(67, 60)
        Me.Panel2.TabIndex = 4
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.SlateGray
        Me.PanelMain.Location = New System.Drawing.Point(196, 45)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1658, 710)
        Me.PanelMain.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.PictureBox1.Location = New System.Drawing.Point(196, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1360, 44)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.DarkOrange
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(1296, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(45, 39)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(532, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ELIMA GASTRONOMIC- 2021"
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1344, 749)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "inicio"
        Me.Text = "MAXIREST- 2021"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnStock As Button
    Friend WithEvents btnCargos As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PanelMain As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
End Class
