﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnCargos = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnAbrirTurno = New System.Windows.Forms.Button()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.btnCargos)
        Me.Panel1.Controls.Add(Me.btnStock)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 981)
        Me.Panel1.TabIndex = 5
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
        Me.btnCargos.Location = New System.Drawing.Point(-67, 251)
        Me.btnCargos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCargos.Name = "btnCargos"
        Me.btnCargos.Size = New System.Drawing.Size(333, 84)
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
        Me.btnStock.Location = New System.Drawing.Point(0, 154)
        Me.btnStock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(267, 73)
        Me.btnStock.TabIndex = 7
        Me.btnStock.Text = "Stock"
        Me.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStock.UseVisualStyleBackColor = False
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
        Me.btnAbrirTurno.Location = New System.Drawing.Point(288, 160)
        Me.btnAbrirTurno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAbrirTurno.Name = "btnAbrirTurno"
        Me.btnAbrirTurno.Size = New System.Drawing.Size(156, 37)
        Me.btnAbrirTurno.TabIndex = 6
        Me.btnAbrirTurno.Text = "Abrir Turno"
        Me.btnAbrirTurno.UseVisualStyleBackColor = False
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.SlateGray
        Me.PanelMain.Controls.Add(Me.Panel)
        Me.PanelMain.Location = New System.Drawing.Point(264, 0)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(2208, 894)
        Me.PanelMain.TabIndex = 6
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel.Controls.Add(Me.btnCancelar)
        Me.Panel.Controls.Add(Me.DateTimePicker1)
        Me.Panel.Controls.Add(Me.btnAbrirTurno)
        Me.Panel.Controls.Add(Me.Panel4)
        Me.Panel.Controls.Add(Me.LabelUsuario)
        Me.Panel.Location = New System.Drawing.Point(341, 154)
        Me.Panel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(524, 234)
        Me.Panel.TabIndex = 7
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.DimGray
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(85, 160)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(156, 37)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(175, 98)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(289, 22)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(0, 22)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(524, 39)
        Me.Panel4.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(81, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Confirme los datos para abrir un nuevo turno"
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.BackColor = System.Drawing.Color.DarkOrange
        Me.LabelUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelUsuario.Location = New System.Drawing.Point(80, 96)
        Me.LabelUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(77, 26)
        Me.LabelUsuario.TabIndex = 0
        Me.LabelUsuario.Text = "Fecha"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(16, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(89, 74)
        Me.Panel2.TabIndex = 4
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1663, 847)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "inicio"
        Me.Text = "inicio"
        Me.Panel1.ResumeLayout(False)
        Me.PanelMain.ResumeLayout(False)
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCargos As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents btnAbrirTurno As Button
    Friend WithEvents PanelMain As Panel
    Friend WithEvents Panel As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents btnCancelar As Button
End Class
