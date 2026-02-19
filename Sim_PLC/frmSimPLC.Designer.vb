<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSimPLC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        txtReceived = New TextBox()
        Label2 = New Label()
        txtSent = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(422, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 20)
        Label1.TabIndex = 0
        Label1.Text = "Received"
        ' 
        ' txtReceived
        ' 
        txtReceived.Location = New Point(270, 190)
        txtReceived.Multiline = True
        txtReceived.Name = "txtReceived"
        txtReceived.Size = New Size(357, 313)
        txtReceived.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(865, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 20)
        Label2.TabIndex = 0
        Label2.Text = "Received"
        ' 
        ' txtSent
        ' 
        txtSent.Location = New Point(713, 190)
        txtSent.Multiline = True
        txtSent.Name = "txtSent"
        txtSent.Size = New Size(357, 313)
        txtSent.TabIndex = 1
        ' 
        ' frmSimPLC
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1401, 805)
        Controls.Add(txtSent)
        Controls.Add(Label2)
        Controls.Add(txtReceived)
        Controls.Add(Label1)
        Name = "frmSimPLC"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtReceived As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSent As TextBox

End Class
