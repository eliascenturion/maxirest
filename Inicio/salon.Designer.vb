<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class salon
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
        Me.btnBarra = New System.Windows.Forms.Button()
        Me.btnMesa1 = New System.Windows.Forms.Button()
        Me.btnMesa2 = New System.Windows.Forms.Button()
        Me.btnMesa3 = New System.Windows.Forms.Button()
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
        'btnMesa2
        '
        Me.btnMesa2.BackColor = System.Drawing.Color.Orange
        Me.btnMesa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMesa2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMesa2.Location = New System.Drawing.Point(243, 166)
        Me.btnMesa2.Name = "btnMesa2"
        Me.btnMesa2.Size = New System.Drawing.Size(90, 78)
        Me.btnMesa2.TabIndex = 2
        Me.btnMesa2.Text = "Mesa2"
        Me.btnMesa2.UseVisualStyleBackColor = False
        '
        'btnMesa3
        '
        Me.btnMesa3.BackColor = System.Drawing.Color.Orange
        Me.btnMesa3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMesa3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMesa3.Location = New System.Drawing.Point(427, 166)
        Me.btnMesa3.Name = "btnMesa3"
        Me.btnMesa3.Size = New System.Drawing.Size(90, 78)
        Me.btnMesa3.TabIndex = 3
        Me.btnMesa3.Text = "Mesa3"
        Me.btnMesa3.UseVisualStyleBackColor = False
        '
        'salon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(760, 524)
        Me.Controls.Add(Me.btnMesa3)
        Me.Controls.Add(Me.btnMesa2)
        Me.Controls.Add(Me.btnMesa1)
        Me.Controls.Add(Me.btnBarra)
        Me.Name = "salon"
        Me.Text = "salon"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBarra As Button
    Friend WithEvents btnMesa1 As Button
    Friend WithEvents btnMesa2 As Button
    Friend WithEvents btnMesa3 As Button
End Class
