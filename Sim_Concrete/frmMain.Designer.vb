<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.txtReq01_Stack = New System.Windows.Forms.TextBox()
        Me.lblIPAddress = New System.Windows.Forms.Label()
        Me.lblReq01_Color = New System.Windows.Forms.Label()
        Me.txtReq01_Color = New System.Windows.Forms.TextBox()
        Me.txtReq01_Response = New System.Windows.Forms.TextBox()
        Me.lblColorRequest = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReq01_Stack_BASE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReq01_RequestID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtReq01_Date = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtReq01_Time = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtReq01_Truck = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtReq01_Load = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtReq01_Cement = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtReq01_Customer = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtReq01_TicketCode = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnReq01_Stack = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReq02_Delete_BASE = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtReq02_TicketCode = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtReq02_Time = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtReq02_Date = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtReq02_RequestID = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btnReq02_Delete = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtReq02_DeleteReq = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtReq02_Response = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpenXRef = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.dgXRef = New System.Windows.Forms.DataGridView()
        Me.VL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIKA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtReq03_RequestID = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtReq03_Color = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtReq03_Response = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtReq03_ColorReq = New System.Windows.Forms.TextBox()
        Me.btnReq03_Color = New System.Windows.Forms.Button()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtReq03_Color_BASE = New System.Windows.Forms.TextBox()
        CType(Me.dgXRef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(516, 824)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(114, 20)
        Me.txtIPAddress.TabIndex = 0
        Me.txtIPAddress.Text = "192.168.175.3"
        Me.txtIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtReq01_Stack
        '
        Me.txtReq01_Stack.Location = New System.Drawing.Point(24, 440)
        Me.txtReq01_Stack.Multiline = True
        Me.txtReq01_Stack.Name = "txtReq01_Stack"
        Me.txtReq01_Stack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReq01_Stack.Size = New System.Drawing.Size(314, 109)
        Me.txtReq01_Stack.TabIndex = 1
        Me.txtReq01_Stack.Text = resources.GetString("txtReq01_Stack.Text")
        '
        'lblIPAddress
        '
        Me.lblIPAddress.AutoSize = True
        Me.lblIPAddress.Location = New System.Drawing.Point(535, 808)
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.Size = New System.Drawing.Size(81, 13)
        Me.lblIPAddress.TabIndex = 2
        Me.lblIPAddress.Text = "PLC IP Address"
        '
        'lblReq01_Color
        '
        Me.lblReq01_Color.AutoSize = True
        Me.lblReq01_Color.Location = New System.Drawing.Point(63, 90)
        Me.lblReq01_Color.Name = "lblReq01_Color"
        Me.lblReq01_Color.Size = New System.Drawing.Size(31, 13)
        Me.lblReq01_Color.TabIndex = 5
        Me.lblReq01_Color.Text = "Color"
        '
        'txtReq01_Color
        '
        Me.txtReq01_Color.Location = New System.Drawing.Point(109, 87)
        Me.txtReq01_Color.Name = "txtReq01_Color"
        Me.txtReq01_Color.Size = New System.Drawing.Size(114, 20)
        Me.txtReq01_Color.TabIndex = 4
        Me.txtReq01_Color.Text = "VL23201"
        Me.txtReq01_Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtReq01_Response
        '
        Me.txtReq01_Response.Location = New System.Drawing.Point(24, 576)
        Me.txtReq01_Response.Multiline = True
        Me.txtReq01_Response.Name = "txtReq01_Response"
        Me.txtReq01_Response.Size = New System.Drawing.Size(314, 122)
        Me.txtReq01_Response.TabIndex = 7
        '
        'lblColorRequest
        '
        Me.lblColorRequest.AutoSize = True
        Me.lblColorRequest.Location = New System.Drawing.Point(21, 424)
        Me.lblColorRequest.Name = "lblColorRequest"
        Me.lblColorRequest.Size = New System.Drawing.Size(118, 13)
        Me.lblColorRequest.TabIndex = 3
        Me.lblColorRequest.Text = "01 - STACK REQUEST"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 560)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "01 STACK RESPONSE"
        '
        'txtReq01_Stack_BASE
        '
        Me.txtReq01_Stack_BASE.Location = New System.Drawing.Point(24, 652)
        Me.txtReq01_Stack_BASE.Multiline = True
        Me.txtReq01_Stack_BASE.Name = "txtReq01_Stack_BASE"
        Me.txtReq01_Stack_BASE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReq01_Stack_BASE.Size = New System.Drawing.Size(314, 46)
        Me.txtReq01_Stack_BASE.TabIndex = 11
        Me.txtReq01_Stack_BASE.Text = resources.GetString("txtReq01_Stack_BASE.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Request ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtReq01_RequestID
        '
        Me.txtReq01_RequestID.Location = New System.Drawing.Point(109, 129)
        Me.txtReq01_RequestID.Name = "txtReq01_RequestID"
        Me.txtReq01_RequestID.Size = New System.Drawing.Size(114, 20)
        Me.txtReq01_RequestID.TabIndex = 12
        Me.txtReq01_RequestID.Text = "12345678"
        Me.txtReq01_RequestID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(229, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "String, 8 Characters. i.e. VL232010"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Number, 8 Characters"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(229, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Date, Auto Generated"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtReq01_Date
        '
        Me.txtReq01_Date.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtReq01_Date.Enabled = False
        Me.txtReq01_Date.Location = New System.Drawing.Point(109, 181)
        Me.txtReq01_Date.Name = "txtReq01_Date"
        Me.txtReq01_Date.Size = New System.Drawing.Size(114, 20)
        Me.txtReq01_Date.TabIndex = 16
        Me.txtReq01_Date.Text = "21-11-2023"
        Me.txtReq01_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(229, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Time, Auto Generated"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(73, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Time"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtReq01_Time
        '
        Me.txtReq01_Time.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtReq01_Time.Enabled = False
        Me.txtReq01_Time.Location = New System.Drawing.Point(109, 207)
        Me.txtReq01_Time.Name = "txtReq01_Time"
        Me.txtReq01_Time.Size = New System.Drawing.Size(114, 20)
        Me.txtReq01_Time.TabIndex = 19
        Me.txtReq01_Time.Text = "15:45"
        Me.txtReq01_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(229, 236)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "String, 10 Characters"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(73, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Truck"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtReq01_Truck
        '
        Me.txtReq01_Truck.Location = New System.Drawing.Point(109, 233)
        Me.txtReq01_Truck.Name = "txtReq01_Truck"
        Me.txtReq01_Truck.Size = New System.Drawing.Size(114, 20)
        Me.txtReq01_Truck.TabIndex = 22
        Me.txtReq01_Truck.Text = "ABCDEFGHIJKL"
        Me.txtReq01_Truck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(229, 262)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(193, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Number, 5 Characters, Yards, i.e. 12.34"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(73, 262)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Load"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtReq01_Load
        '
        Me.txtReq01_Load.Location = New System.Drawing.Point(109, 259)
        Me.txtReq01_Load.Name = "txtReq01_Load"
        Me.txtReq01_Load.Size = New System.Drawing.Size(114, 20)
        Me.txtReq01_Load.TabIndex = 25
        Me.txtReq01_Load.Text = "12.34"
        Me.txtReq01_Load.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(229, 288)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(195, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Number, 7 Characters, Lbs, i.e. 1234.56"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(61, 288)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Cement"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtReq01_Cement
        '
        Me.txtReq01_Cement.Location = New System.Drawing.Point(109, 285)
        Me.txtReq01_Cement.Name = "txtReq01_Cement"
        Me.txtReq01_Cement.Size = New System.Drawing.Size(114, 20)
        Me.txtReq01_Cement.TabIndex = 28
        Me.txtReq01_Cement.Text = "1234.56"
        Me.txtReq01_Cement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(229, 314)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(135, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "String, Up to 10 Characters"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(52, 314)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Customer"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtReq01_Customer
        '
        Me.txtReq01_Customer.Location = New System.Drawing.Point(109, 311)
        Me.txtReq01_Customer.Name = "txtReq01_Customer"
        Me.txtReq01_Customer.Size = New System.Drawing.Size(114, 20)
        Me.txtReq01_Customer.TabIndex = 31
        Me.txtReq01_Customer.Text = "CUSTOMER"
        Me.txtReq01_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(229, 158)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Number, 8 Characters"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(42, 158)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 13)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Ticket Code"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtReq01_TicketCode
        '
        Me.txtReq01_TicketCode.Location = New System.Drawing.Point(109, 155)
        Me.txtReq01_TicketCode.Name = "txtReq01_TicketCode"
        Me.txtReq01_TicketCode.Size = New System.Drawing.Size(114, 20)
        Me.txtReq01_TicketCode.TabIndex = 34
        Me.txtReq01_TicketCode.Text = "12345678"
        Me.txtReq01_TicketCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(83, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(207, 24)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "Enter Ticket Information"
        '
        'btnReq01_Stack
        '
        Me.btnReq01_Stack.Location = New System.Drawing.Point(93, 347)
        Me.btnReq01_Stack.Name = "btnReq01_Stack"
        Me.btnReq01_Stack.Size = New System.Drawing.Size(146, 41)
        Me.btnReq01_Stack.TabIndex = 38
        Me.btnReq01_Stack.Text = "Stack Ticket Request"
        Me.btnReq01_Stack.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(21, 636)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(178, 13)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "01 - STACK REQUEST TEMPLATE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(421, 636)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "02 - STACK DELETE TEMPLATE"
        '
        'txtReq02_Delete_BASE
        '
        Me.txtReq02_Delete_BASE.Location = New System.Drawing.Point(423, 652)
        Me.txtReq02_Delete_BASE.Multiline = True
        Me.txtReq02_Delete_BASE.Name = "txtReq02_Delete_BASE"
        Me.txtReq02_Delete_BASE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReq02_Delete_BASE.Size = New System.Drawing.Size(319, 46)
        Me.txtReq02_Delete_BASE.TabIndex = 40
        Me.txtReq02_Delete_BASE.Text = resources.GetString("txtReq02_Delete_BASE.Text")
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(632, 117)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(110, 13)
        Me.Label22.TabIndex = 56
        Me.Label22.Text = "Number, 8 Characters"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(445, 117)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 13)
        Me.Label23.TabIndex = 55
        Me.Label23.Text = "Ticket Code"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtReq02_TicketCode
        '
        Me.txtReq02_TicketCode.Location = New System.Drawing.Point(512, 114)
        Me.txtReq02_TicketCode.Name = "txtReq02_TicketCode"
        Me.txtReq02_TicketCode.Size = New System.Drawing.Size(114, 20)
        Me.txtReq02_TicketCode.TabIndex = 54
        Me.txtReq02_TicketCode.Text = "12345678"
        Me.txtReq02_TicketCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(632, 169)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(111, 13)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Time, Auto Generated"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(476, 169)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(30, 13)
        Me.Label27.TabIndex = 49
        Me.Label27.Text = "Time"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtReq02_Time
        '
        Me.txtReq02_Time.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtReq02_Time.Enabled = False
        Me.txtReq02_Time.Location = New System.Drawing.Point(512, 166)
        Me.txtReq02_Time.Name = "txtReq02_Time"
        Me.txtReq02_Time.Size = New System.Drawing.Size(114, 20)
        Me.txtReq02_Time.TabIndex = 48
        Me.txtReq02_Time.Text = "15:45"
        Me.txtReq02_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(632, 143)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(111, 13)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Date, Auto Generated"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(476, 143)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(30, 13)
        Me.Label29.TabIndex = 46
        Me.Label29.Text = "Date"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtReq02_Date
        '
        Me.txtReq02_Date.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtReq02_Date.Enabled = False
        Me.txtReq02_Date.Location = New System.Drawing.Point(512, 140)
        Me.txtReq02_Date.Name = "txtReq02_Date"
        Me.txtReq02_Date.Size = New System.Drawing.Size(114, 20)
        Me.txtReq02_Date.TabIndex = 45
        Me.txtReq02_Date.Text = "21-11-2023"
        Me.txtReq02_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(632, 91)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(110, 13)
        Me.Label30.TabIndex = 44
        Me.Label30.Text = "Number, 8 Characters"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(445, 91)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(61, 13)
        Me.Label31.TabIndex = 43
        Me.Label31.Text = "Request ID"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtReq02_RequestID
        '
        Me.txtReq02_RequestID.Location = New System.Drawing.Point(512, 88)
        Me.txtReq02_RequestID.Name = "txtReq02_RequestID"
        Me.txtReq02_RequestID.Size = New System.Drawing.Size(114, 20)
        Me.txtReq02_RequestID.TabIndex = 42
        Me.txtReq02_RequestID.Text = "12345678"
        Me.txtReq02_RequestID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(72, 23)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(239, 24)
        Me.Label32.TabIndex = 57
        Me.Label32.Text = "COLOR STACK REQUEST"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(444, 23)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(251, 24)
        Me.Label33.TabIndex = 59
        Me.Label33.Text = "COLOR DELETE REQUEST"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(455, 48)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(207, 24)
        Me.Label34.TabIndex = 58
        Me.Label34.Text = "Enter Ticket Information"
        '
        'btnReq02_Delete
        '
        Me.btnReq02_Delete.Location = New System.Drawing.Point(500, 348)
        Me.btnReq02_Delete.Name = "btnReq02_Delete"
        Me.btnReq02_Delete.Size = New System.Drawing.Size(146, 41)
        Me.btnReq02_Delete.TabIndex = 60
        Me.btnReq02_Delete.Text = "Delete Ticket Request"
        Me.btnReq02_Delete.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(421, 424)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(163, 13)
        Me.Label35.TabIndex = 62
        Me.Label35.Text = "02 - STACK DELETE REQUEST"
        '
        'txtReq02_DeleteReq
        '
        Me.txtReq02_DeleteReq.Location = New System.Drawing.Point(424, 440)
        Me.txtReq02_DeleteReq.Multiline = True
        Me.txtReq02_DeleteReq.Name = "txtReq02_DeleteReq"
        Me.txtReq02_DeleteReq.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReq02_DeleteReq.Size = New System.Drawing.Size(319, 109)
        Me.txtReq02_DeleteReq.TabIndex = 61
        Me.txtReq02_DeleteReq.Text = resources.GetString("txtReq02_DeleteReq.Text")
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(427, 560)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(119, 13)
        Me.Label36.TabIndex = 64
        Me.Label36.Text = "02 STACK RESPONSE"
        '
        'txtReq02_Response
        '
        Me.txtReq02_Response.Location = New System.Drawing.Point(423, 576)
        Me.txtReq02_Response.Multiline = True
        Me.txtReq02_Response.Name = "txtReq02_Response"
        Me.txtReq02_Response.Size = New System.Drawing.Size(319, 122)
        Me.txtReq02_Response.TabIndex = 63
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnOpenXRef
        '
        Me.btnOpenXRef.Location = New System.Drawing.Point(108, 725)
        Me.btnOpenXRef.Name = "btnOpenXRef"
        Me.btnOpenXRef.Size = New System.Drawing.Size(119, 35)
        Me.btnOpenXRef.TabIndex = 65
        Me.btnOpenXRef.Text = "Open Cross Reference"
        Me.btnOpenXRef.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(46, 785)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(244, 20)
        Me.txtFileName.TabIndex = 66
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(479, 899)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(187, 74)
        Me.btnQuit.TabIndex = 67
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'dgXRef
        '
        Me.dgXRef.AllowUserToAddRows = False
        Me.dgXRef.AllowUserToDeleteRows = False
        Me.dgXRef.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgXRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgXRef.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VL, Me.SIKA})
        Me.dgXRef.Location = New System.Drawing.Point(46, 808)
        Me.dgXRef.MultiSelect = False
        Me.dgXRef.Name = "dgXRef"
        Me.dgXRef.ReadOnly = True
        Me.dgXRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgXRef.Size = New System.Drawing.Size(244, 167)
        Me.dgXRef.TabIndex = 70
        '
        'VL
        '
        Me.VL.HeaderText = "VL Code"
        Me.VL.Name = "VL"
        Me.VL.ReadOnly = True
        '
        'SIKA
        '
        Me.SIKA.HeaderText = "SIKA Code"
        Me.SIKA.Name = "SIKA"
        Me.SIKA.ReadOnly = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(138, 763)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(52, 13)
        Me.Label24.TabIndex = 71
        Me.Label24.Text = "(Optional)"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(825, 23)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(231, 24)
        Me.Label37.TabIndex = 86
        Me.Label37.Text = "COLOR CODE REQUEST"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(836, 48)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(207, 24)
        Me.Label38.TabIndex = 85
        Me.Label38.Text = "Enter Ticket Information"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(1013, 116)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(110, 13)
        Me.Label45.TabIndex = 75
        Me.Label45.Text = "Number, 8 Characters"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(826, 116)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(61, 13)
        Me.Label46.TabIndex = 74
        Me.Label46.Text = "Request ID"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtReq03_RequestID
        '
        Me.txtReq03_RequestID.Location = New System.Drawing.Point(893, 113)
        Me.txtReq03_RequestID.Name = "txtReq03_RequestID"
        Me.txtReq03_RequestID.Size = New System.Drawing.Size(114, 20)
        Me.txtReq03_RequestID.TabIndex = 73
        Me.txtReq03_RequestID.Text = "12345678"
        Me.txtReq03_RequestID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(1013, 90)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(172, 13)
        Me.Label39.TabIndex = 89
        Me.Label39.Text = "String, 8 Characters. i.e. VL232010"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(847, 90)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(31, 13)
        Me.Label40.TabIndex = 88
        Me.Label40.Text = "Color"
        '
        'txtReq03_Color
        '
        Me.txtReq03_Color.Location = New System.Drawing.Point(893, 87)
        Me.txtReq03_Color.Name = "txtReq03_Color"
        Me.txtReq03_Color.Size = New System.Drawing.Size(114, 20)
        Me.txtReq03_Color.TabIndex = 87
        Me.txtReq03_Color.Text = "VL23201"
        Me.txtReq03_Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(807, 560)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(121, 13)
        Me.Label25.TabIndex = 96
        Me.Label25.Text = "03 COLOR RESPONSE"
        '
        'txtReq03_Response
        '
        Me.txtReq03_Response.Location = New System.Drawing.Point(804, 576)
        Me.txtReq03_Response.Multiline = True
        Me.txtReq03_Response.Name = "txtReq03_Response"
        Me.txtReq03_Response.Size = New System.Drawing.Size(319, 122)
        Me.txtReq03_Response.TabIndex = 95
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(801, 424)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(117, 13)
        Me.Label41.TabIndex = 94
        Me.Label41.Text = "03 -COLOR REQUEST"
        '
        'txtReq03_ColorReq
        '
        Me.txtReq03_ColorReq.Location = New System.Drawing.Point(804, 440)
        Me.txtReq03_ColorReq.Multiline = True
        Me.txtReq03_ColorReq.Name = "txtReq03_ColorReq"
        Me.txtReq03_ColorReq.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReq03_ColorReq.Size = New System.Drawing.Size(319, 109)
        Me.txtReq03_ColorReq.TabIndex = 93
        Me.txtReq03_ColorReq.Text = resources.GetString("txtReq03_ColorReq.Text")
        '
        'btnReq03_Color
        '
        Me.btnReq03_Color.Location = New System.Drawing.Point(880, 348)
        Me.btnReq03_Color.Name = "btnReq03_Color"
        Me.btnReq03_Color.Size = New System.Drawing.Size(146, 41)
        Me.btnReq03_Color.TabIndex = 92
        Me.btnReq03_Color.Text = "Color Request"
        Me.btnReq03_Color.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(801, 636)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(180, 13)
        Me.Label42.TabIndex = 91
        Me.Label42.Text = "03 - COLOR REQUEST TEMPLATE"
        '
        'txtReq03_Color_BASE
        '
        Me.txtReq03_Color_BASE.Location = New System.Drawing.Point(804, 652)
        Me.txtReq03_Color_BASE.Multiline = True
        Me.txtReq03_Color_BASE.Name = "txtReq03_Color_BASE"
        Me.txtReq03_Color_BASE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReq03_Color_BASE.Size = New System.Drawing.Size(319, 46)
        Me.txtReq03_Color_BASE.TabIndex = 90
        Me.txtReq03_Color_BASE.Text = resources.GetString("txtReq03_Color_BASE.Text")
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1228, 985)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtReq03_Response)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.txtReq03_ColorReq)
        Me.Controls.Add(Me.btnReq03_Color)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.txtReq03_Color_BASE)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.txtReq03_Color)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.txtReq03_RequestID)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.dgXRef)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnOpenXRef)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtReq02_Response)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txtReq02_DeleteReq)
        Me.Controls.Add(Me.btnReq02_Delete)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtReq02_TicketCode)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtReq02_Time)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtReq02_Date)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txtReq02_RequestID)
        Me.Controls.Add(Me.btnReq01_Stack)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtReq01_TicketCode)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtReq01_Customer)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtReq01_Cement)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtReq01_Load)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtReq01_Truck)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtReq01_Time)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtReq01_Date)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtReq01_RequestID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReq01_Response)
        Me.Controls.Add(Me.lblReq01_Color)
        Me.Controls.Add(Me.txtReq01_Color)
        Me.Controls.Add(Me.lblColorRequest)
        Me.Controls.Add(Me.lblIPAddress)
        Me.Controls.Add(Me.txtReq01_Stack)
        Me.Controls.Add(Me.txtIPAddress)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtReq01_Stack_BASE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReq02_Delete_BASE)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Cement System Simulator"
        CType(Me.dgXRef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtReq01_Stack As System.Windows.Forms.TextBox
    Friend WithEvents lblIPAddress As System.Windows.Forms.Label
    Friend WithEvents lblReq01_Color As System.Windows.Forms.Label
    Friend WithEvents txtReq01_Color As System.Windows.Forms.TextBox
    Friend WithEvents txtReq01_Response As System.Windows.Forms.TextBox
    Friend WithEvents lblColorRequest As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReq01_Stack_BASE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtReq01_RequestID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtReq01_Date As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtReq01_Time As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtReq01_Truck As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtReq01_Load As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtReq01_Cement As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtReq01_Customer As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtReq01_TicketCode As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnReq01_Stack As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReq02_Delete_BASE As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtReq02_TicketCode As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtReq02_Time As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtReq02_Date As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtReq02_RequestID As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents btnReq02_Delete As System.Windows.Forms.Button
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtReq02_DeleteReq As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtReq02_Response As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpenXRef As System.Windows.Forms.Button
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents dgXRef As System.Windows.Forms.DataGridView
    Friend WithEvents VL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SIKA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtReq03_RequestID As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtReq03_Color As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtReq03_Response As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtReq03_ColorReq As System.Windows.Forms.TextBox
    Friend WithEvents btnReq03_Color As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtReq03_Color_BASE As System.Windows.Forms.TextBox

End Class
