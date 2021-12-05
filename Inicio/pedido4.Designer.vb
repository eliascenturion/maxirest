<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pedido4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pedido4))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CbNomEpleado = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtNombreEmpleado = New System.Windows.Forms.Label()
        Me.ListViewMenu = New System.Windows.Forms.ListView()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.ListViewPedido = New System.Windows.Forms.ListView()
        Me.Menu = New System.Windows.Forms.PictureBox()
        CType(Me.Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 78)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Cerrar pedido"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CbNomEpleado
        '
        Me.CbNomEpleado.FormattingEnabled = True
        Me.CbNomEpleado.Location = New System.Drawing.Point(436, 452)
        Me.CbNomEpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.CbNomEpleado.Name = "CbNomEpleado"
        Me.CbNomEpleado.Size = New System.Drawing.Size(160, 24)
        Me.CbNomEpleado.TabIndex = 36
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregar.BackgroundImage = CType(resources.GetObject("btnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(109, 384)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(88, 79)
        Me.btnAgregar.TabIndex = 34
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Precio"
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nombre"
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Id"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.AutoSize = True
        Me.txtNombreEmpleado.Font = New System.Drawing.Font("Microsoft New Tai Lue", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(316, 452)
        Me.txtNombreEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(110, 29)
        Me.txtNombreEmpleado.TabIndex = 37
        Me.txtNombreEmpleado.Text = "Empleado"
        '
        'ListViewMenu
        '
        Me.ListViewMenu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListViewMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewMenu.Location = New System.Drawing.Point(606, 125)
        Me.ListViewMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.ListViewMenu.Name = "ListViewMenu"
        Me.ListViewMenu.Size = New System.Drawing.Size(544, 440)
        Me.ListViewMenu.TabIndex = 35
        Me.ListViewMenu.UseCompatibleStateImageBehavior = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Yellow
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(1033, 29)
        Me.Button18.Margin = New System.Windows.Forms.Padding(4)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(100, 69)
        Me.Button18.TabIndex = 32
        Me.Button18.Text = "Bebidas"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(936, 29)
        Me.Button19.Margin = New System.Windows.Forms.Padding(4)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(100, 69)
        Me.Button19.TabIndex = 31
        Me.Button19.Text = "Cervezas"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.Yellow
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(840, 29)
        Me.Button20.Margin = New System.Windows.Forms.Padding(4)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(100, 69)
        Me.Button20.TabIndex = 30
        Me.Button20.Text = "Fritas"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Location = New System.Drawing.Point(742, 29)
        Me.Button21.Margin = New System.Windows.Forms.Padding(4)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(100, 69)
        Me.Button21.TabIndex = 29
        Me.Button21.Text = "Hamb"
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.Yellow
        Me.Button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.Location = New System.Drawing.Point(645, 29)
        Me.Button22.Margin = New System.Windows.Forms.Padding(4)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(100, 69)
        Me.Button22.TabIndex = 28
        Me.Button22.Text = "Pizzas"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 395)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 33)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Total"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Producto"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(13, 384)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 79)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Borrar Item"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotal.Location = New System.Drawing.Point(436, 393)
        Me.TextBoxTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxTotal.Multiline = True
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(160, 35)
        Me.TextBoxTotal.TabIndex = 26
        '
        'ListViewPedido
        '
        Me.ListViewPedido.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListViewPedido.Location = New System.Drawing.Point(13, 13)
        Me.ListViewPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.ListViewPedido.Name = "ListViewPedido"
        Me.ListViewPedido.Size = New System.Drawing.Size(583, 363)
        Me.ListViewPedido.TabIndex = 24
        Me.ListViewPedido.UseCompatibleStateImageBehavior = False
        '
        'Menu
        '
        Me.Menu.Location = New System.Drawing.Point(606, 13)
        Me.Menu.Margin = New System.Windows.Forms.Padding(4)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(544, 105)
        Me.Menu.TabIndex = 33
        Me.Menu.TabStop = False
        '
        'pedido4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 575)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CbNomEpleado)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Controls.Add(Me.ListViewMenu)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.ListViewPedido)
        Me.Controls.Add(Me.Menu)
        Me.Name = "pedido4"
        Me.Text = "pedido4"
        CType(Me.Menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents CbNomEpleado As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents txtNombreEmpleado As Label
    Friend WithEvents ListViewMenu As ListView
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents ListViewPedido As ListView
    Friend WithEvents Menu As PictureBox
End Class
