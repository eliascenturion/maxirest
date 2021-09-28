<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAbrirTurno = New System.Windows.Forms.Button()
        Me.btnCargos = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.btnAbrirTurno)
        Me.Panel1.Controls.Add(Me.btnCargos)
        Me.Panel1.Controls.Add(Me.btnStock)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 797)
        Me.Panel1.TabIndex = 5
        '
        'btnAbrirTurno
        '
        Me.btnAbrirTurno.BackColor = System.Drawing.Color.DimGray
        Me.btnAbrirTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAbrirTurno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbrirTurno.FlatAppearance.BorderSize = 0
        Me.btnAbrirTurno.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAbrirTurno.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirTurno.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAbrirTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbrirTurno.Location = New System.Drawing.Point(15, 51)
        Me.btnAbrirTurno.Name = "btnAbrirTurno"
        Me.btnAbrirTurno.Size = New System.Drawing.Size(164, 43)
        Me.btnAbrirTurno.TabIndex = 6
        Me.btnAbrirTurno.Text = "Abrir Turno"
        Me.btnAbrirTurno.UseVisualStyleBackColor = False
        '
        'btnCargos
        '
        Me.btnCargos.BackColor = System.Drawing.Color.Gold
        Me.btnCargos.BackgroundImage = CType(resources.GetObject("btnCargos.BackgroundImage"), System.Drawing.Image)
        Me.btnCargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCargos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargos.FlatAppearance.BorderSize = 0
        Me.btnCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCargos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargos.Location = New System.Drawing.Point(-50, 204)
        Me.btnCargos.Name = "btnCargos"
        Me.btnCargos.Size = New System.Drawing.Size(250, 68)
        Me.btnCargos.TabIndex = 8
        Me.btnCargos.Text = "Empleados"
        Me.btnCargos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCargos.UseVisualStyleBackColor = False
        '
        'btnStock
        '
        Me.btnStock.BackColor = System.Drawing.Color.Gold
        Me.btnStock.BackgroundImage = CType(resources.GetObject("btnStock.BackgroundImage"), System.Drawing.Image)
        Me.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStock.FlatAppearance.BorderSize = 0
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStock.Location = New System.Drawing.Point(0, 125)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(200, 59)
        Me.btnStock.TabIndex = 7
        Me.btnStock.Text = "Stock"
        Me.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStock.UseVisualStyleBackColor = False
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.SlateGray
        Me.PanelMain.Location = New System.Drawing.Point(198, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1656, 726)
        Me.PanelMain.TabIndex = 6
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
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1247, 688)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "inicio"
        Me.Text = "inicio"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCargos As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents btnAbrirTurno As Button
    Friend WithEvents PanelMain As Panel
End Class
