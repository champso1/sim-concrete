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
        txtIPAddress = New TextBox()
        Label3 = New Label()
        txtListenPort = New TextBox()
        txtSendPort = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        btnSendExampleStatusReq = New Button()
        cmbxExampleReqChoices = New ComboBox()
        txtClientInfo = New TextBox()
        Label6 = New Label()
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
        txtReceived.ReadOnly = True
        txtReceived.Size = New Size(357, 313)
        txtReceived.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(865, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 20)
        Label2.TabIndex = 0
        Label2.Text = "Sent"
        ' 
        ' txtSent
        ' 
        txtSent.Location = New Point(713, 190)
        txtSent.Multiline = True
        txtSent.Name = "txtSent"
        txtSent.ReadOnly = True
        txtSent.Size = New Size(357, 313)
        txtSent.TabIndex = 1
        ' 
        ' txtIPAddress
        ' 
        txtIPAddress.Location = New Point(621, 633)
        txtIPAddress.Name = "txtIPAddress"
        txtIPAddress.Size = New Size(197, 27)
        txtIPAddress.TabIndex = 2
        txtIPAddress.Text = "192.168.175.4"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(537, 636)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 3
        Label3.Text = "IP Address"
        ' 
        ' txtListenPort
        ' 
        txtListenPort.Location = New Point(1045, 604)
        txtListenPort.Name = "txtListenPort"
        txtListenPort.Size = New Size(125, 27)
        txtListenPort.TabIndex = 4
        txtListenPort.Text = "25521"
        ' 
        ' txtSendPort
        ' 
        txtSendPort.Location = New Point(1045, 649)
        txtSendPort.Name = "txtSendPort"
        txtSendPort.Size = New Size(125, 27)
        txtSendPort.TabIndex = 4
        txtSendPort.Text = "25522"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(962, 611)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 20)
        Label4.TabIndex = 3
        Label4.Text = "Listen Port"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(967, 652)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 3
        Label5.Text = "Send Port"
        ' 
        ' btnSendExampleStatusReq
        ' 
        btnSendExampleStatusReq.Location = New Point(131, 604)
        btnSendExampleStatusReq.Name = "btnSendExampleStatusReq"
        btnSendExampleStatusReq.Size = New Size(160, 63)
        btnSendExampleStatusReq.TabIndex = 5
        btnSendExampleStatusReq.Text = "Send Example Request"
        btnSendExampleStatusReq.UseVisualStyleBackColor = True
        ' 
        ' cmbxExampleReqChoices
        ' 
        cmbxExampleReqChoices.FormattingEnabled = True
        cmbxExampleReqChoices.Items.AddRange(New Object() {"00 Ack", "10 Req", "Garbage", "Empty XML", "10 Req (No XML Tag)"})
        cmbxExampleReqChoices.Location = New Point(297, 622)
        cmbxExampleReqChoices.Name = "cmbxExampleReqChoices"
        cmbxExampleReqChoices.Size = New Size(151, 28)
        cmbxExampleReqChoices.TabIndex = 6
        ' 
        ' txtClientInfo
        ' 
        txtClientInfo.Location = New Point(389, 45)
        txtClientInfo.Name = "txtClientInfo"
        txtClientInfo.ReadOnly = True
        txtClientInfo.Size = New Size(613, 27)
        txtClientInfo.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(305, 48)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 20)
        Label6.TabIndex = 3
        Label6.Text = "Client Info"
        ' 
        ' frmSimPLC
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1401, 805)
        Controls.Add(txtClientInfo)
        Controls.Add(cmbxExampleReqChoices)
        Controls.Add(btnSendExampleStatusReq)
        Controls.Add(txtSendPort)
        Controls.Add(txtListenPort)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(txtIPAddress)
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
    Friend WithEvents txtIPAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtListenPort As TextBox
    Friend WithEvents txtSendPort As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSendExampleStatusReq As Button
    Friend WithEvents cmbxExampleReqChoices As ComboBox
    Friend WithEvents txtClientInfo As TextBox
    Friend WithEvents Label6 As Label

End Class
