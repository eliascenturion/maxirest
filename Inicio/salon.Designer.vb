﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salon
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
        Me.btnBarra = New System.Windows.Forms.Button()
        Me.btnMesa1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBarra
        '
        Me.btnBarra.BackColor = System.Drawing.Color.Orange
        Me.btnBarra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBarra.Location = New System.Drawing.Point(207, 37)
        Me.btnBarra.Name = "btnBarra"
        Me.btnBarra.Size = New System.Drawing.Size(320, 44)
        Me.btnBarra.TabIndex = 0
        Me.btnBarra.Text = "Barra"
        Me.btnBarra.UseVisualStyleBackColor = False
        '
        'btnMesa1
        '
        Me.btnMesa1.BackColor = System.Drawing.Color.Orange
        Me.btnMesa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMesa1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMesa1.Location = New System.Drawing.Point(43, 166)
        Me.btnMesa1.Name = "btnMesa1"
        Me.btnMesa1.Size = New System.Drawing.Size(90, 78)
        Me.btnMesa1.TabIndex = 1
        Me.btnMesa1.Text = "Mesa1"
        Me.btnMesa1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Orange
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(243, 166)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 78)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Mesa2"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Orange
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(427, 166)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 78)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Mesa3"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Orange
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(588, 166)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 78)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Mesa4"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'salon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(760, 524)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnMesa1)
        Me.Controls.Add(Me.btnBarra)
        Me.Name = "salon"
        Me.Text = "salon"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBarra As Button
    Friend WithEvents btnMesa1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
