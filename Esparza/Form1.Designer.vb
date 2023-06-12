<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.insertText = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.displayText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'insertText
        '
        Me.insertText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.insertText.Location = New System.Drawing.Point(123, 77)
        Me.insertText.Name = "insertText"
        Me.insertText.Size = New System.Drawing.Size(119, 38)
        Me.insertText.TabIndex = 3
        Me.insertText.Text = "CLICK ME"
        Me.insertText.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Esparza, Mark Jude"
        '
        'displayText
        '
        Me.displayText.Location = New System.Drawing.Point(93, 41)
        Me.displayText.Name = "displayText"
        Me.displayText.Size = New System.Drawing.Size(189, 23)
        Me.displayText.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 138)
        Me.Controls.Add(Me.displayText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.insertText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Esparza, Mark Jude - QR GENERATOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents insertText As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents displayText As TextBox
End Class
