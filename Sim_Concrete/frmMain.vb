Imports System.Net.Sockets
Imports System.IO

Public Class frmMain


    Private Sub btnReq01_Stack_Click(sender As Object, e As EventArgs) Handles btnReq01_Stack.Click

        ' *** COLOR ***
        'Ensure that the entry is the right length
        txtReq01_Color.Text = FormatVLString(txtReq01_Color.Text, 12)
        'Check for appropriate entry - Should be numeric with hundredths place
        If txtReq01_Color.Text.Substring(txtReq01_Color.Text.Length - 7, 2) <> "VL" Then
            MsgBox("Color Entry must be 8 characters and in the format VLxxxxxx")
            txtReq01_Color.BackColor = Color.Yellow
            Exit Sub
        Else
            txtReq01_Color.BackColor = Color.White
        End If

        ' *** REQUEST ID ***
        'Ensure that the entry is the right length
        txtReq01_RequestID.Text = FormatString(txtReq01_RequestID.Text, 8)
        'Check for appropriate entry - Should be numeric with hundredths place
        If Not IsNumeric(txtReq01_RequestID.Text) Then
            MsgBox("Request ID Should be numeric and in the format NNNNNNNN")
            txtReq01_RequestID.BackColor = Color.Yellow
            Exit Sub
        Else
            txtReq01_RequestID.BackColor = Color.White
        End If

        ' *** TICKET CODE ***
        'Ensure that the entry is the right length
        txtReq01_TicketCode.Text = FormatString(txtReq01_TicketCode.Text, 8)
        'Check for appropriate entry - Should be numeric with hundredths place
        If Not IsNumeric(txtReq01_TicketCode.Text) Then
            MsgBox("Ticket Code should be 8 characters and in the format ABCDEFGH")
            txtReq01_TicketCode.BackColor = Color.Yellow
            Exit Sub
        Else
            txtReq01_TicketCode.BackColor = Color.White
        End If

        ' *** TRUCK ***
        'Ensure that the entry is the right length
        txtReq01_Truck.Text = FormatString(txtReq01_Truck.Text, 10)
        'Check for appropriate entry - Should be numeric with hundredths place
        If txtReq01_Truck.Text = "          " Then
            MsgBox("Truck should be 10 characters and in the format ABCDEFGHIJ")
            txtReq01_Truck.BackColor = Color.Yellow
            Exit Sub
        Else
            txtReq01_Truck.BackColor = Color.White
        End If

        ' *** LOAD ***
        'Ensure that the entry is the right length
        txtReq01_Load.Text = FormatString(txtReq01_Load.Text, 5)
        'Check for appropriate entry - Should be numeric with hundredths place
        If (Not IsNumeric(txtReq01_Load.Text)) Or (txtReq01_Load.Text.Substring(2, 1) <> ".") Then
            MsgBox("Load Entry must be numeric and in the format NN.NN")
            txtReq01_Load.BackColor = Color.Yellow
            Exit Sub
        Else
            txtReq01_Load.BackColor = Color.White
        End If

        ' *** CEMENT ***
        'Ensure that the entry is the right length
        txtReq01_Cement.Text = FormatString(txtReq01_Cement.Text, 7)
        'Check for appropriate entry - Should be numeric with hundredths place
        If (Not IsNumeric(txtReq01_Cement.Text)) Or (txtReq01_Cement.Text.Substring(4, 1) <> ".") Then
            MsgBox("Cement Entry must be numeric and in the format NNNN.NN")
            txtReq01_Cement.BackColor = Color.Yellow
            Exit Sub
        Else
            txtReq01_Cement.BackColor = Color.White
        End If

        ' *** CUSTOMER ***
        'Ensure that the entry is the right length
        txtReq01_Customer.Text = FormatString(txtReq01_Customer.Text, 10)
        'Check for appropriate entry - Should be numeric with hundredths place
        If txtReq01_Customer.Text = "          " Then
            MsgBox("Truck should be 10 characters and in the format ABCDEFGHIJ")
            txtReq01_Customer.BackColor = Color.Yellow
            Exit Sub
        Else
            txtReq01_Customer.BackColor = Color.White
        End If

        'Set Data and Time to Current Date and Time
        txtReq01_Date.Text = Format(Now(), "dd-MMM-yyyy")
        txtReq01_Time.Text = Format(Now(), "hh:mm")

        'Copy template to REQ01 text box for sending to PLC
        txtReq01_Stack.Text = txtReq01_Stack_BASE.Text

        'Replace the Placeholders in the template with actual values
        txtReq01_Stack.Text = txtReq01_Stack.Text.Replace("AAAAAAAA", txtReq01_RequestID.Text)
        txtReq01_Stack.Text = txtReq01_Stack.Text.Replace("BBBBBBBB", txtReq01_TicketCode.Text)
        txtReq01_Stack.Text = txtReq01_Stack.Text.Replace("DD-MMM-YYYY", txtReq01_Date.Text)
        txtReq01_Stack.Text = txtReq01_Stack.Text.Replace("HH:MM", txtReq01_Time.Text)
        txtReq01_Stack.Text = txtReq01_Stack.Text.Replace("CCCCCCCCCC", txtReq01_Truck.Text)
        txtReq01_Stack.Text = txtReq01_Stack.Text.Replace("DDDDDDDDDDDD", txtReq01_Color.Text)
        txtReq01_Stack.Text = txtReq01_Stack.Text.Replace("EE.EE", txtReq01_Load.Text)
        txtReq01_Stack.Text = txtReq01_Stack.Text.Replace("FFFF.FF", txtReq01_Cement.Text)
        txtReq01_Stack.Text = txtReq01_Stack.Text.Replace("GGGGGGGGGG", txtReq01_Customer.Text)

        Req01_Stack(txtReq01_Stack.Text)

        txtReq01_RequestID.Text = txtReq01_RequestID.Text + 1

    End Sub

    Private Sub btnReq02_Delete_Click(sender As Object, e As EventArgs) Handles btnReq02_Delete.Click

        ' *** REQUEST ID ***
        'Ensure that the entry is the right length
        txtReq02_RequestID.Text = FormatString(txtReq02_RequestID.Text, 8)
        'Check for appropriate entry - Should be numeric with hundredths place
        If Not IsNumeric(txtReq02_RequestID.Text) Then
            MsgBox("Request ID Should be numeric and in the format NNNNNNNN")
            txtReq02_RequestID.BackColor = Color.Yellow
            Exit Sub
        Else
            txtReq02_RequestID.BackColor = Color.White
        End If

        ' *** TICKET CODE ***
        'Ensure that the entry is the right length
        txtReq02_TicketCode.Text = FormatString(txtReq02_TicketCode.Text, 8)
        'Check for appropriate entry - Should be numeric with hundredths place
        If Not IsNumeric(txtReq02_TicketCode.Text) Then
            MsgBox("Ticket Code should be 8 characters and in the format ABCDEFGH")
            txtReq02_TicketCode.BackColor = Color.Yellow
            Exit Sub
        Else
            txtReq02_TicketCode.BackColor = Color.White
        End If

        ' *** TRUCK ***
        ' Truck is irrelevant, so we'll just hard code it later

        'Set Data and Time to Current Date and Time
        txtReq02_Date.Text = Format(Now(), "dd-MMM-yyyy")
        txtReq02_Time.Text = Format(Now(), "hh:mm")

        'Copy template to REQ01 text box for sending to PLC
        txtReq02_DeleteReq.Text = txtReq02_Delete_BASE.Text

        'Replace the Placeholders in the template with actual values
        txtReq02_DeleteReq.Text = txtReq02_DeleteReq.Text.Replace("AAAAAAAA", txtReq02_RequestID.Text)
        txtReq02_DeleteReq.Text = txtReq02_DeleteReq.Text.Replace("BBBBBBBB", txtReq02_TicketCode.Text)
        txtReq02_DeleteReq.Text = txtReq02_DeleteReq.Text.Replace("DD-MMM-YYYY", txtReq02_Date.Text)
        txtReq02_DeleteReq.Text = txtReq02_DeleteReq.Text.Replace("HH:MM", txtReq02_Time.Text)
        txtReq02_DeleteReq.Text = txtReq02_DeleteReq.Text.Replace("CCCCCCCCCC", "TRUCK")

        Req02_Delete(txtReq02_DeleteReq.Text)

        txtReq02_RequestID.Text = txtReq01_RequestID.Text + 1

    End Sub

    Private Sub btnReq03_Color_Click(sender As Object, e As EventArgs) Handles btnReq03_Color.Click

        ' *** COLOR ***
        'Ensure that the entry is the right length
        txtReq01_Color.Text = FormatVLString(txtReq01_Color.Text, 12)
        'Check for appropriate entry - Should be numeric with hundredths place
        If txtReq01_Color.Text.Substring(txtReq01_Color.Text.Length - 7, 2) <> "VL" Then
            MsgBox("Color Entry must be 8 characters and in the format VLxxxxxx")
            txtReq01_Color.BackColor = Color.Yellow
            Exit Sub
        Else
            txtReq01_Color.BackColor = Color.White
        End If

        ' *** REQUEST ID ***
        'Ensure that the entry is the right length
        txtReq03_RequestID.Text = FormatString(txtReq03_RequestID.Text, 8)
        'Check for appropriate entry - Should be numeric with hundredths place
        If Not IsNumeric(txtReq03_RequestID.Text) Then
            MsgBox("Request ID Should be numeric and in the format NNNNNNNN")
            txtReq03_RequestID.BackColor = Color.Yellow
            Exit Sub
        Else
            txtReq03_RequestID.BackColor = Color.White
        End If

        'Copy template to REQ01 text box for sending to PLC
        txtReq03_ColorReq.Text = txtReq03_Color_BASE.Text

        'Replace the Placeholders in the template with actual values
        txtReq03_ColorReq.Text = txtReq03_ColorReq.Text.Replace("AAAAAAAA", txtReq03_RequestID.Text)
        txtReq03_ColorReq.Text = txtReq03_ColorReq.Text.Replace("DDDDDDDDDDDD", txtReq03_Color.Text)


        'There is an error in the PLC code where the first pulled color code is incorrect, but is correct on the second read. For now, just read twice until we get the PLC code fixed.
        Req03_ColorReq(txtReq03_ColorReq.Text)

        Req03_ColorReq(txtReq03_ColorReq.Text)

        txtReq03_RequestID.Text = txtReq03_RequestID.Text + 1
    End Sub

    Private Sub Req01_Stack(InputString As String)
        Dim tcpClient As New System.Net.Sockets.TcpClient()
        tcpClient.Connect(txtIPAddress.Text, 25521)
        Dim networkStream As NetworkStream = tcpClient.GetStream()

        If networkStream.CanWrite And networkStream.CanRead Then
            networkStream.ReadTimeout = 5000

            Dim sendBytes As [Byte]() = System.Text.Encoding.ASCII.GetBytes(InputString)

            'Send the data as bytes
            networkStream.Write(sendBytes, 0, sendBytes.Length)

            ' Read the NetworkStream into a byte buffer.
            Dim returnbytes(tcpClient.ReceiveBufferSize) As Byte
            On Error GoTo Req01_Error
            networkStream.Read(returnbytes, 0, CInt(tcpClient.ReceiveBufferSize))

            ' Output the data received from the host to the console.
            Dim returndata As String = System.Text.Encoding.ASCII.GetString(returnbytes)

            txtReq01_Response.Text = ("Host returned: " + returndata)
            tcpClient.Close()
        Else
            If Not networkStream.CanRead Then
                txtReq01_Response.Text = "Error: Cannot write data to PLC. Check that PLC is online and at the correct IP Address"
                tcpClient.Close()
            Else
                If Not networkStream.CanWrite Then
                    txtReq01_Response.Text = "Error: Cannot read return data from PLC. Check that PLC is online and at the correct IP Address"
                    tcpClient.Close()
                End If
            End If
        End If
        Exit Sub
Req01_Error:
        On Error Resume Next
        tcpClient.Close()
        MsgBox("PLC did not respond in time. Check that PLC is online and at the correct IP Address")
    End Sub

    Private Sub Req02_Delete(InputString As String)
        Dim tcpClient As New System.Net.Sockets.TcpClient()
        tcpClient.Connect(txtIPAddress.Text, 25521)
        Dim networkStream As NetworkStream = tcpClient.GetStream()

        If networkStream.CanWrite And networkStream.CanRead Then
            networkStream.ReadTimeout = 5000

            Dim sendBytes As [Byte]() = System.Text.Encoding.ASCII.GetBytes(InputString)

            'Send the data as bytes
            networkStream.Write(sendBytes, 0, sendBytes.Length)

            ' Read the NetworkStream into a byte buffer.
            Dim returnbytes(tcpClient.ReceiveBufferSize) As Byte
            On Error GoTo Req02_Error
            networkStream.Read(returnbytes, 0, CInt(tcpClient.ReceiveBufferSize))

            ' Output the data received from the host to the console.
            Dim returndata As String = System.Text.Encoding.ASCII.GetString(returnbytes)

            txtReq02_Response.Text = ("Host returned: " + returndata)
            tcpClient.Close()
        Else
            If Not networkStream.CanRead Then
                txtReq01_Response.Text = "Error: Cannot write data to PLC. Check that PLC is online and at the correct IP Address"
                tcpClient.Close()
            Else
                If Not networkStream.CanWrite Then
                    txtReq01_Response.Text = "Error: Cannot read return data from PLC. Check that PLC is online and at the correct IP Address"
                    tcpClient.Close()
                End If
            End If
        End If
        Exit Sub
Req02_Error:
        On Error Resume Next
        tcpClient.Close()
        MsgBox("PLC did not respond in time. Check that PLC is online and at the correct IP Address")
    End Sub

    Private Sub Req03_ColorReq(InputString As String)
        Dim tcpClient As New System.Net.Sockets.TcpClient()
        tcpClient.Connect(txtIPAddress.Text, 25521)
        Dim networkStream As NetworkStream = tcpClient.GetStream()

        If networkStream.CanWrite And networkStream.CanRead Then
            networkStream.ReadTimeout = 5000

            Dim sendBytes As [Byte]() = System.Text.Encoding.ASCII.GetBytes(InputString)

            'Send the data as bytes
            networkStream.Write(sendBytes, 0, sendBytes.Length)

            ' Read the NetworkStream into a byte buffer.
            Dim returnbytes(tcpClient.ReceiveBufferSize) As Byte
            On Error GoTo Req03_Error
            networkStream.Read(returnbytes, 0, CInt(tcpClient.ReceiveBufferSize))

            ' Output the data received from the host to the console.
            Dim returndata As String = System.Text.Encoding.ASCII.GetString(returnbytes)

            txtReq03_Response.Text = ("Host returned: " + returndata)
            tcpClient.Close()
        Else
            If Not networkStream.CanRead Then
                txtReq03_Response.Text = "Error: Cannot write data to PLC. Check that PLC is online and at the correct IP Address"
                tcpClient.Close()
            Else
                If Not networkStream.CanWrite Then
                    txtReq03_Response.Text = "Error: Cannot read return data from PLC. Check that PLC is online and at the correct IP Address"
                    tcpClient.Close()
                End If
            End If
        End If
        Exit Sub
Req03_Error:
        On Error Resume Next
        tcpClient.Close()
        MsgBox("PLC did not respond in time. Check that PLC is online and at the correct IP Address")
    End Sub

    Private Sub btnOpenXRef_Click(sender As Object, e As EventArgs) Handles btnOpenXRef.Click

        Dim ofd As OpenFileDialog = New OpenFileDialog
        ofd.Filter = "Comma Delimited Files (*.csv)|*.csv"
        ofd.FilterIndex = 1

        If ofd.ShowDialog() Then
            txtFileName.Text = ofd.FileName
        Else
            Exit Sub
        End If

        Dim irow As Integer
        irow = 0

        'Open up the text file, and read each line, sticking the line in a new row on the datagrid
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(txtFileName.Text)
            While Not MyReader.EndOfData
                MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                MyReader.Delimiters = New String() {","}
                Try
                    Dim fields = MyReader.ReadFields()
                    'txtXRef.Text = txtXRef.Text & fields(0) & "     =     SIKA:" & fields(1) & Chr(13) & Chr(13)
                    '                    lbXRef.Items.Add({fields(0)} {fields(1)})
                    dgXRef.Rows.Add()
                    dgXRef.Item(0, irow).Value = fields(1)
                    dgXRef.Item(1, irow).Value = fields(0)
                    irow = irow + 1
                Catch
                    MsgBox("Error reading the XREF file.")
                End Try
            End While
        End Using

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Function FormatString(InputString As String, numCharacters As Integer) As String
        Dim UpdatedString As String
        UpdatedString = InputString
        'If string is too long, then shorten it by taking the left hand x characters
        If InputString.Length > numCharacters Then
            UpdatedString = UpdatedString.Substring(0, numCharacters)
            GoTo SkipRest
        End If
        'If string is too short, then lengthen it by adding leading spaces
        Do While UpdatedString.Length < numCharacters
            UpdatedString = UpdatedString & " "
        Loop
SkipRest:
        FormatString = UpdatedString
    End Function

    Private Function FormatVLString(InputString As String, numCharacters As Integer) As String
        Dim UpdatedString As String
        UpdatedString = InputString
        'If string is too long, then shorten it by taking the left hand x characters
        If InputString.Length > numCharacters Then
            UpdatedString = UpdatedString.Substring(0, numCharacters)
            GoTo SkipRest
        End If
        'If string is too short, then lengthen it by adding leading spaces
        Do While UpdatedString.Length < numCharacters
            UpdatedString = " " & UpdatedString
        Loop
SkipRest:
        FormatVLString = UpdatedString
    End Function

    Private Sub dgXRef_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgXRef.CurrentCellChanged
        'Populate the COLOR in the REQ01 STACK to the cell selected, if a VL code is selected
        If dgXRef.CurrentCell.ColumnIndex = 0 And dgXRef.CurrentCell.Value <> "" Then
            txtReq01_Color.Text = dgXRef.CurrentCell.Value
            txtReq01_Color.Text = txtReq01_Color.Text.Substring(0, 7)
            txtReq03_Color.Text = txtReq01_Color.Text
        End If
    End Sub
End Class
