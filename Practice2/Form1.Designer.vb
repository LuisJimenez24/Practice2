<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.clearBttn = New System.Windows.Forms.Button()
        Me.delBttn = New System.Windows.Forms.Button()
        Me.modBttn = New System.Windows.Forms.Button()
        Me.addBttn = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dbpathBttn = New System.Windows.Forms.Button()
        Me.connBttn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.clearBttn)
        Me.GroupBox1.Controls.Add(Me.delBttn)
        Me.GroupBox1.Controls.Add(Me.modBttn)
        Me.GroupBox1.Controls.Add(Me.addBttn)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.txtBox2)
        Me.GroupBox1.Controls.Add(Me.txtBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PERSONS"
        '
        'clearBttn
        '
        Me.clearBttn.Location = New System.Drawing.Point(388, 127)
        Me.clearBttn.Name = "clearBttn"
        Me.clearBttn.Size = New System.Drawing.Size(75, 23)
        Me.clearBttn.TabIndex = 8
        Me.clearBttn.Text = "Clear"
        Me.clearBttn.UseVisualStyleBackColor = True
        '
        'delBttn
        '
        Me.delBttn.Location = New System.Drawing.Point(307, 127)
        Me.delBttn.Name = "delBttn"
        Me.delBttn.Size = New System.Drawing.Size(75, 23)
        Me.delBttn.TabIndex = 7
        Me.delBttn.Text = "Delete"
        Me.delBttn.UseVisualStyleBackColor = True
        '
        'modBttn
        '
        Me.modBttn.Location = New System.Drawing.Point(226, 127)
        Me.modBttn.Name = "modBttn"
        Me.modBttn.Size = New System.Drawing.Size(75, 23)
        Me.modBttn.TabIndex = 6
        Me.modBttn.Text = "Modify"
        Me.modBttn.UseVisualStyleBackColor = True
        '
        'addBttn
        '
        Me.addBttn.Location = New System.Drawing.Point(145, 127)
        Me.addBttn.Name = "addBttn"
        Me.addBttn.Size = New System.Drawing.Size(75, 23)
        Me.addBttn.TabIndex = 5
        Me.addBttn.Text = "Add"
        Me.addBttn.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(20, 23)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(106, 127)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(268, 72)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(155, 20)
        Me.txtBox2.TabIndex = 3
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(268, 39)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(155, 20)
        Me.txtBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Person ID"
        '
        'dbpathBttn
        '
        Me.dbpathBttn.Location = New System.Drawing.Point(43, 223)
        Me.dbpathBttn.Name = "dbpathBttn"
        Me.dbpathBttn.Size = New System.Drawing.Size(75, 23)
        Me.dbpathBttn.TabIndex = 1
        Me.dbpathBttn.Text = "DB Path"
        Me.dbpathBttn.UseVisualStyleBackColor = True
        '
        'connBttn
        '
        Me.connBttn.Location = New System.Drawing.Point(43, 281)
        Me.connBttn.Name = "connBttn"
        Me.connBttn.Size = New System.Drawing.Size(75, 23)
        Me.connBttn.TabIndex = 2
        Me.connBttn.Text = "Connect"
        Me.connBttn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 325)
        Me.Controls.Add(Me.connBttn)
        Me.Controls.Add(Me.dbpathBttn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtBox2 As TextBox
    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dbpathBttn As Button
    Friend WithEvents connBttn As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents clearBttn As Button
    Friend WithEvents delBttn As Button
    Friend WithEvents modBttn As Button
    Friend WithEvents addBttn As Button
End Class
