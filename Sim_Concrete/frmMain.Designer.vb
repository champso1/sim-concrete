<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.lblIPAddress = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtStatusRequest = New System.Windows.Forms.Label()
        Me.btnReq00_Status = New System.Windows.Forms.Button()
        Me.lblStatusResponse = New System.Windows.Forms.Label()
        Me.txtReq00_Response = New System.Windows.Forms.TextBox()
        Me.lblStatusRequest = New System.Windows.Forms.Label()
        Me.txtReq00_Status = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtReq01_P4 = New System.Windows.Forms.TextBox()
        Me.txtReq01_P3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReq01_P2 = New System.Windows.Forms.TextBox()
        Me.txtReq01_P1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReq01_Batch = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtReq01_Response = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtReq01_Batch = New System.Windows.Forms.TextBox()
        Me.lblWM = New System.Windows.Forms.Label()
        Me.txtReq01_WM = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtReq01_Name = New System.Windows.Forms.TextBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.txtReq01_Customer = New System.Windows.Forms.TextBox()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.txtReq01_Content = New System.Windows.Forms.TextBox()
        Me.lblOrderNum = New System.Windows.Forms.Label()
        Me.txtReq01_Order = New System.Windows.Forms.TextBox()
        Me.lblUOM = New System.Windows.Forms.Label()
        Me.txtReq01_UOM = New System.Windows.Forms.TextBox()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.txtReq01_Load = New System.Windows.Forms.TextBox()
        Me.lblTruck = New System.Windows.Forms.Label()
        Me.txtReq01_Truck = New System.Windows.Forms.TextBox()
        Me.lblTicket = New System.Windows.Forms.Label()
        Me.txtReq01_Ticket = New System.Windows.Forms.TextBox()
        Me.lblBatchID = New System.Windows.Forms.Label()
        Me.txtReq01_BatchID = New System.Windows.Forms.TextBox()
        Me.lblReq01_Alias = New System.Windows.Forms.Label()
        Me.txtReq01_Alias = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(32, 815)
        Me.txtIPAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(151, 22)
        Me.txtIPAddress.TabIndex = 0
        Me.txtIPAddress.Text = "192.168.175.3"
        Me.txtIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIPAddress
        '
        Me.lblIPAddress.AutoSize = True
        Me.lblIPAddress.Location = New System.Drawing.Point(57, 795)
        Me.lblIPAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.Size = New System.Drawing.Size(101, 16)
        Me.lblIPAddress.TabIndex = 2
        Me.lblIPAddress.Text = "PLC IP Address"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(1375, 795)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(249, 91)
        Me.btnQuit.TabIndex = 67
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1635, 780)
        Me.TabControl1.TabIndex = 88
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtStatusRequest)
        Me.TabPage1.Controls.Add(Me.btnReq00_Status)
        Me.TabPage1.Controls.Add(Me.lblStatusResponse)
        Me.TabPage1.Controls.Add(Me.txtReq00_Response)
        Me.TabPage1.Controls.Add(Me.lblStatusRequest)
        Me.TabPage1.Controls.Add(Me.txtReq00_Status)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1627, 751)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "00 - Status"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtStatusRequest
        '
        Me.txtStatusRequest.AutoSize = True
        Me.txtStatusRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatusRequest.Location = New System.Drawing.Point(629, 3)
        Me.txtStatusRequest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtStatusRequest.Name = "txtStatusRequest"
        Me.txtStatusRequest.Size = New System.Drawing.Size(232, 29)
        Me.txtStatusRequest.TabIndex = 65
        Me.txtStatusRequest.Text = "STATUS REQUEST"
        '
        'btnReq00_Status
        '
        Me.btnReq00_Status.Location = New System.Drawing.Point(709, 197)
        Me.btnReq00_Status.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReq00_Status.Name = "btnReq00_Status"
        Me.btnReq00_Status.Size = New System.Drawing.Size(195, 75)
        Me.btnReq00_Status.TabIndex = 63
        Me.btnReq00_Status.Text = "Send Status Request"
        Me.btnReq00_Status.UseVisualStyleBackColor = True
        '
        'lblStatusResponse
        '
        Me.lblStatusResponse.AutoSize = True
        Me.lblStatusResponse.Location = New System.Drawing.Point(966, 177)
        Me.lblStatusResponse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatusResponse.Name = "lblStatusResponse"
        Me.lblStatusResponse.Size = New System.Drawing.Size(127, 16)
        Me.lblStatusResponse.TabIndex = 61
        Me.lblStatusResponse.Text = "00 Status Response"
        '
        'txtReq00_Response
        '
        Me.txtReq00_Response.Location = New System.Drawing.Point(962, 197)
        Me.txtReq00_Response.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq00_Response.Multiline = True
        Me.txtReq00_Response.Name = "txtReq00_Response"
        Me.txtReq00_Response.Size = New System.Drawing.Size(527, 469)
        Me.txtReq00_Response.TabIndex = 60
        '
        'lblStatusRequest
        '
        Me.lblStatusRequest.AutoSize = True
        Me.lblStatusRequest.Location = New System.Drawing.Point(90, 177)
        Me.lblStatusRequest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatusRequest.Name = "lblStatusRequest"
        Me.lblStatusRequest.Size = New System.Drawing.Size(155, 16)
        Me.lblStatusRequest.TabIndex = 59
        Me.lblStatusRequest.Text = "00 - STATUS REQUEST"
        '
        'txtReq00_Status
        '
        Me.txtReq00_Status.Location = New System.Drawing.Point(94, 197)
        Me.txtReq00_Status.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq00_Status.Multiline = True
        Me.txtReq00_Status.Name = "txtReq00_Status"
        Me.txtReq00_Status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReq00_Status.Size = New System.Drawing.Size(527, 469)
        Me.txtReq00_Status.TabIndex = 58
        Me.txtReq00_Status.Text = "<?xml version=""1.0""?>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<MESSAGE>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  <REQUEST>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    <TYPE>00</TYPE>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  </REQUEST>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</MESSAGE>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtReq01_P4)
        Me.TabPage2.Controls.Add(Me.txtReq01_P3)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtReq01_P2)
        Me.TabPage2.Controls.Add(Me.txtReq01_P1)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.btnReq01_Batch)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtReq01_Response)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txtReq01_Batch)
        Me.TabPage2.Controls.Add(Me.lblWM)
        Me.TabPage2.Controls.Add(Me.txtReq01_WM)
        Me.TabPage2.Controls.Add(Me.lblName)
        Me.TabPage2.Controls.Add(Me.txtReq01_Name)
        Me.TabPage2.Controls.Add(Me.lblCustomer)
        Me.TabPage2.Controls.Add(Me.txtReq01_Customer)
        Me.TabPage2.Controls.Add(Me.lblContent)
        Me.TabPage2.Controls.Add(Me.txtReq01_Content)
        Me.TabPage2.Controls.Add(Me.lblOrderNum)
        Me.TabPage2.Controls.Add(Me.txtReq01_Order)
        Me.TabPage2.Controls.Add(Me.lblUOM)
        Me.TabPage2.Controls.Add(Me.txtReq01_UOM)
        Me.TabPage2.Controls.Add(Me.lblLoad)
        Me.TabPage2.Controls.Add(Me.txtReq01_Load)
        Me.TabPage2.Controls.Add(Me.lblTruck)
        Me.TabPage2.Controls.Add(Me.txtReq01_Truck)
        Me.TabPage2.Controls.Add(Me.lblTicket)
        Me.TabPage2.Controls.Add(Me.txtReq01_Ticket)
        Me.TabPage2.Controls.Add(Me.lblBatchID)
        Me.TabPage2.Controls.Add(Me.txtReq01_BatchID)
        Me.TabPage2.Controls.Add(Me.lblReq01_Alias)
        Me.TabPage2.Controls.Add(Me.txtReq01_Alias)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1627, 751)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "01 - Batch"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtReq01_P4
        '
        Me.txtReq01_P4.Location = New System.Drawing.Point(1343, 159)
        Me.txtReq01_P4.Name = "txtReq01_P4"
        Me.txtReq01_P4.Size = New System.Drawing.Size(137, 22)
        Me.txtReq01_P4.TabIndex = 126
        Me.txtReq01_P4.Text = "0"
        Me.txtReq01_P4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtReq01_P3
        '
        Me.txtReq01_P3.Location = New System.Drawing.Point(1343, 133)
        Me.txtReq01_P3.Name = "txtReq01_P3"
        Me.txtReq01_P3.Size = New System.Drawing.Size(137, 22)
        Me.txtReq01_P3.TabIndex = 125
        Me.txtReq01_P3.Text = "0"
        Me.txtReq01_P3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1305, 162)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 16)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "G30"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1305, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 16)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "G25"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReq01_P2
        '
        Me.txtReq01_P2.Location = New System.Drawing.Point(1343, 106)
        Me.txtReq01_P2.Name = "txtReq01_P2"
        Me.txtReq01_P2.Size = New System.Drawing.Size(137, 22)
        Me.txtReq01_P2.TabIndex = 122
        Me.txtReq01_P2.Text = "0"
        Me.txtReq01_P2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtReq01_P1
        '
        Me.txtReq01_P1.Location = New System.Drawing.Point(1343, 80)
        Me.txtReq01_P1.Name = "txtReq01_P1"
        Me.txtReq01_P1.Size = New System.Drawing.Size(137, 22)
        Me.txtReq01_P1.TabIndex = 121
        Me.txtReq01_P1.Text = "0"
        Me.txtReq01_P1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1305, 109)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "G20"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1305, 83)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "G10"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1354, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Pigments:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(672, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 29)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Batch REQUEST"
        '
        'btnReq01_Batch
        '
        Me.btnReq01_Batch.Location = New System.Drawing.Point(736, 208)
        Me.btnReq01_Batch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReq01_Batch.Name = "btnReq01_Batch"
        Me.btnReq01_Batch.Size = New System.Drawing.Size(195, 66)
        Me.btnReq01_Batch.TabIndex = 114
        Me.btnReq01_Batch.Text = "Send Batch Request"
        Me.btnReq01_Batch.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1003, 273)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 16)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "01 - Batch Response"
        '
        'txtReq01_Response
        '
        Me.txtReq01_Response.Location = New System.Drawing.Point(999, 293)
        Me.txtReq01_Response.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq01_Response.Multiline = True
        Me.txtReq01_Response.Name = "txtReq01_Response"
        Me.txtReq01_Response.Size = New System.Drawing.Size(565, 422)
        Me.txtReq01_Response.TabIndex = 112
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(76, 273)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 16)
        Me.Label15.TabIndex = 111
        Me.Label15.Text = "01 - Batch Request"
        '
        'txtReq01_Batch
        '
        Me.txtReq01_Batch.Location = New System.Drawing.Point(76, 293)
        Me.txtReq01_Batch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq01_Batch.Multiline = True
        Me.txtReq01_Batch.Name = "txtReq01_Batch"
        Me.txtReq01_Batch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReq01_Batch.Size = New System.Drawing.Size(565, 422)
        Me.txtReq01_Batch.TabIndex = 110
        Me.txtReq01_Batch.Text = resources.GetString("txtReq01_Batch.Text")
        '
        'lblWM
        '
        Me.lblWM.AutoSize = True
        Me.lblWM.Location = New System.Drawing.Point(844, 92)
        Me.lblWM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWM.Name = "lblWM"
        Me.lblWM.Size = New System.Drawing.Size(87, 16)
        Me.lblWM.TabIndex = 109
        Me.lblWM.Text = "Weighmaster"
        Me.lblWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReq01_WM
        '
        Me.txtReq01_WM.Location = New System.Drawing.Point(950, 89)
        Me.txtReq01_WM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq01_WM.Name = "txtReq01_WM"
        Me.txtReq01_WM.Size = New System.Drawing.Size(151, 22)
        Me.txtReq01_WM.TabIndex = 108
        Me.txtReq01_WM.Text = "user"
        Me.txtReq01_WM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(887, 62)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 107
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReq01_Name
        '
        Me.txtReq01_Name.Location = New System.Drawing.Point(950, 59)
        Me.txtReq01_Name.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq01_Name.Name = "txtReq01_Name"
        Me.txtReq01_Name.Size = New System.Drawing.Size(151, 22)
        Me.txtReq01_Name.TabIndex = 106
        Me.txtReq01_Name.Text = "KARLA ODELL CONST"
        Me.txtReq01_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(594, 125)
        Me.lblCustomer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(64, 16)
        Me.lblCustomer.TabIndex = 105
        Me.lblCustomer.Text = "Customer"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReq01_Customer
        '
        Me.txtReq01_Customer.Location = New System.Drawing.Point(677, 122)
        Me.txtReq01_Customer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq01_Customer.Name = "txtReq01_Customer"
        Me.txtReq01_Customer.Size = New System.Drawing.Size(151, 22)
        Me.txtReq01_Customer.TabIndex = 104
        Me.txtReq01_Customer.Text = "78783"
        Me.txtReq01_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblContent
        '
        Me.lblContent.AutoSize = True
        Me.lblContent.Location = New System.Drawing.Point(606, 95)
        Me.lblContent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(52, 16)
        Me.lblContent.TabIndex = 103
        Me.lblContent.Text = "Content"
        Me.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReq01_Content
        '
        Me.txtReq01_Content.Location = New System.Drawing.Point(677, 92)
        Me.txtReq01_Content.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq01_Content.Name = "txtReq01_Content"
        Me.txtReq01_Content.Size = New System.Drawing.Size(151, 22)
        Me.txtReq01_Content.TabIndex = 102
        Me.txtReq01_Content.Text = "564"
        Me.txtReq01_Content.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblOrderNum
        '
        Me.lblOrderNum.AutoSize = True
        Me.lblOrderNum.Location = New System.Drawing.Point(63, 94)
        Me.lblOrderNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderNum.Name = "lblOrderNum"
        Me.lblOrderNum.Size = New System.Drawing.Size(92, 16)
        Me.lblOrderNum.TabIndex = 101
        Me.lblOrderNum.Text = "Order Number"
        Me.lblOrderNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReq01_Order
        '
        Me.txtReq01_Order.Location = New System.Drawing.Point(174, 91)
        Me.txtReq01_Order.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq01_Order.Name = "txtReq01_Order"
        Me.txtReq01_Order.Size = New System.Drawing.Size(151, 22)
        Me.txtReq01_Order.TabIndex = 100
        Me.txtReq01_Order.Text = "113"
        Me.txtReq01_Order.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUOM
        '
        Me.lblUOM.AutoSize = True
        Me.lblUOM.Location = New System.Drawing.Point(620, 65)
        Me.lblUOM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(38, 16)
        Me.lblUOM.TabIndex = 99
        Me.lblUOM.Text = "UOM"
        Me.lblUOM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReq01_UOM
        '
        Me.txtReq01_UOM.Location = New System.Drawing.Point(677, 62)
        Me.txtReq01_UOM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq01_UOM.Name = "txtReq01_UOM"
        Me.txtReq01_UOM.Size = New System.Drawing.Size(151, 22)
        Me.txtReq01_UOM.TabIndex = 98
        Me.txtReq01_UOM.Text = "CY"
        Me.txtReq01_UOM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLoad
        '
        Me.lblLoad.AutoSize = True
        Me.lblLoad.Location = New System.Drawing.Point(357, 125)
        Me.lblLoad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(38, 16)
        Me.lblLoad.TabIndex = 97
        Me.lblLoad.Text = "Load"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReq01_Load
        '
        Me.txtReq01_Load.Location = New System.Drawing.Point(414, 122)
        Me.txtReq01_Load.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq01_Load.Name = "txtReq01_Load"
        Me.txtReq01_Load.Size = New System.Drawing.Size(151, 22)
        Me.txtReq01_Load.TabIndex = 96
        Me.txtReq01_Load.Text = "6.0000"
        Me.txtReq01_Load.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTruck
        '
        Me.lblTruck.AutoSize = True
        Me.lblTruck.Location = New System.Drawing.Point(354, 65)
        Me.lblTruck.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTruck.Name = "lblTruck"
        Me.lblTruck.Size = New System.Drawing.Size(41, 16)
        Me.lblTruck.TabIndex = 95
        Me.lblTruck.Text = "Truck"
        Me.lblTruck.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReq01_Truck
        '
        Me.txtReq01_Truck.Location = New System.Drawing.Point(414, 62)
        Me.txtReq01_Truck.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq01_Truck.Name = "txtReq01_Truck"
        Me.txtReq01_Truck.Size = New System.Drawing.Size(151, 22)
        Me.txtReq01_Truck.TabIndex = 94
        Me.txtReq01_Truck.Text = "0421"
        Me.txtReq01_Truck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTicket
        '
        Me.lblTicket.AutoSize = True
        Me.lblTicket.Location = New System.Drawing.Point(111, 124)
        Me.lblTicket.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTicket.Name = "lblTicket"
        Me.lblTicket.Size = New System.Drawing.Size(44, 16)
        Me.lblTicket.TabIndex = 93
        Me.lblTicket.Text = "Ticket"
        Me.lblTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReq01_Ticket
        '
        Me.txtReq01_Ticket.Location = New System.Drawing.Point(174, 121)
        Me.txtReq01_Ticket.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq01_Ticket.Name = "txtReq01_Ticket"
        Me.txtReq01_Ticket.Size = New System.Drawing.Size(151, 22)
        Me.txtReq01_Ticket.TabIndex = 92
        Me.txtReq01_Ticket.Text = "442942"
        Me.txtReq01_Ticket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBatchID
        '
        Me.lblBatchID.AutoSize = True
        Me.lblBatchID.Location = New System.Drawing.Point(98, 62)
        Me.lblBatchID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBatchID.Name = "lblBatchID"
        Me.lblBatchID.Size = New System.Drawing.Size(57, 16)
        Me.lblBatchID.TabIndex = 91
        Me.lblBatchID.Text = "Batch ID"
        Me.lblBatchID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReq01_BatchID
        '
        Me.txtReq01_BatchID.Location = New System.Drawing.Point(174, 59)
        Me.txtReq01_BatchID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq01_BatchID.Name = "txtReq01_BatchID"
        Me.txtReq01_BatchID.Size = New System.Drawing.Size(151, 22)
        Me.txtReq01_BatchID.TabIndex = 90
        Me.txtReq01_BatchID.Text = "121028"
        Me.txtReq01_BatchID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblReq01_Alias
        '
        Me.lblReq01_Alias.AutoSize = True
        Me.lblReq01_Alias.Location = New System.Drawing.Point(358, 96)
        Me.lblReq01_Alias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReq01_Alias.Name = "lblReq01_Alias"
        Me.lblReq01_Alias.Size = New System.Drawing.Size(37, 16)
        Me.lblReq01_Alias.TabIndex = 89
        Me.lblReq01_Alias.Text = "Alias"
        Me.lblReq01_Alias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReq01_Alias
        '
        Me.txtReq01_Alias.Location = New System.Drawing.Point(414, 92)
        Me.txtReq01_Alias.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReq01_Alias.Name = "txtReq01_Alias"
        Me.txtReq01_Alias.Size = New System.Drawing.Size(151, 22)
        Me.txtReq01_Alias.TabIndex = 88
        Me.txtReq01_Alias.Text = "DVS25"
        Me.txtReq01_Alias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1637, 898)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblIPAddress)
        Me.Controls.Add(Me.txtIPAddress)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "Cement System Simulator"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblIPAddress As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtStatusRequest As Label
    Friend WithEvents btnReq00_Status As Button
    Friend WithEvents lblStatusResponse As Label
    Friend WithEvents txtReq00_Response As TextBox
    Friend WithEvents lblStatusRequest As Label
    Friend WithEvents txtReq00_Status As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReq01_Batch As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtReq01_Response As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtReq01_Batch As TextBox
    Friend WithEvents lblWM As Label
    Friend WithEvents txtReq01_WM As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtReq01_Name As TextBox
    Friend WithEvents lblCustomer As Label
    Friend WithEvents txtReq01_Customer As TextBox
    Friend WithEvents lblContent As Label
    Friend WithEvents txtReq01_Content As TextBox
    Friend WithEvents lblOrderNum As Label
    Friend WithEvents txtReq01_Order As TextBox
    Friend WithEvents lblUOM As Label
    Friend WithEvents txtReq01_UOM As TextBox
    Friend WithEvents lblLoad As Label
    Friend WithEvents txtReq01_Load As TextBox
    Friend WithEvents lblTruck As Label
    Friend WithEvents txtReq01_Truck As TextBox
    Friend WithEvents lblTicket As Label
    Friend WithEvents txtReq01_Ticket As TextBox
    Friend WithEvents lblBatchID As Label
    Friend WithEvents txtReq01_BatchID As TextBox
    Friend WithEvents lblReq01_Alias As Label
    Friend WithEvents txtReq01_Alias As TextBox
    Friend WithEvents txtReq01_P4 As TextBox
    Friend WithEvents txtReq01_P3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtReq01_P2 As TextBox
    Friend WithEvents txtReq01_P1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
End Class
