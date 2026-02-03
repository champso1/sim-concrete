Imports System.Net
Imports System.Net.Sockets
Imports System.Threading.Tasks

Public Class frmMain
    Private listener As TcpListener
    Private client As TcpClient
    Private isRunning As Boolean = False

    Private Req0406ResponseTemplate As String = "<?xml version=""1.0""?><MESSAGE><ACKNOWLEDGE><TYPE>%TYPE%</TYPE><BATCHID>%BATCHID%</BATCHID></ACKNOWLEDGE></MESSAGE>"
    Private Req0406BatchID As String
    Private Req10ResponseTemplate As String = "<?xml version=""1.0""?><MESSAGE><ACKNOWLEDGE><TYPE>10</TYPE></ACKNOWLEDGE></MESSAGE>"

    Private Sub SendOverTCP(str As String, ByRef resp_txtBox As TextBox)
        Try
            Dim tcpClient As New System.Net.Sockets.TcpClient()
            tcpClient.Connect(txtIPAddress.Text, 25521)
            Dim networkStream As NetworkStream = tcpClient.GetStream()

            If networkStream.CanWrite And networkStream.CanRead Then
                networkStream.ReadTimeout = 5000

                Dim sendBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(str)

                'Send the data as bytes
                networkStream.Write(sendBytes, 0, sendBytes.Length)

                ' Read the NetworkStream into a byte buffer.
                Dim returnbytes(tcpClient.ReceiveBufferSize) As Byte
                networkStream.Read(returnbytes, 0, CInt(tcpClient.ReceiveBufferSize))

                ' Output the data received from the host to the console.
                Dim returndata As String = System.Text.Encoding.ASCII.GetString(returnbytes)

                resp_txtBox.Text = returndata
                tcpClient.Close()
            Else
                If Not networkStream.CanRead Then
                    resp_txtBox.Text = "Error: Cannot write data to PLC. Check that PLC is online and at the correct IP Address"
                    tcpClient.Close()
                Else
                    If Not networkStream.CanWrite Then
                        resp_txtBox.Text = "Error: Cannot read return data from PLC. Check that PLC is online and at the correct IP Address"
                        tcpClient.Close()
                    End If
                End If
            End If
            Exit Sub

            tcpClient.Close()
            MsgBox("PLC did not respond in time. Check that PLC is online and at the correct IP Address")
        Catch ex As Exception
            resp_txtBox.Text = "Failed to connect to PLC."
        End Try
    End Sub

    Private Function GetTime() As String
        Dim t As String = Format(Now(), "yyyy-MM-dd HH:mm:ss")
        GetTime = t
    End Function

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnReq00_Status_Click(sender As Object, e As EventArgs) Handles btnReq00_Status.Click
        txtReq00_Response.Text = "Awaiting response..."

        SendOverTCP(txtReq00_Status.Text, txtReq00_Response)
    End Sub

    Private Sub btnReq01_Batch_Click(sender As Object, e As EventArgs) Handles btnReq01_Batch.Click
        txtReq01_Response.Text = "Awaiting response..."

        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%BATCHID%", txtReq01_BatchID.Text)
        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%TIME%", GetTime())
        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%ORDER%", txtReq01_Order.Text)
        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%TICKET%", txtReq01_Ticket.Text)
        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%TRUCK%", txtReq01_Truck.Text)
        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%ALIAS%", txtReq01_Alias.Text)
        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%LOAD%", txtReq01_Load.Text)
        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%UOM%", txtReq01_UOM.Text)
        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%CONTENT%", txtReq01_Content.Text)
        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%CUSTOMER%", txtReq01_Customer.Text)
        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%NAME%", txtReq01_Name.Text)
        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%WM%", txtReq01_WM.Text)

        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%P1%", txtReq01_P1.Text)
        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%P2%", txtReq01_P2.Text)
        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%P3%", txtReq01_P3.Text)
        txtReq01_Batch.Text = txtReq01_Batch.Text.Replace("%P4%", txtReq01_P4.Text)

        SendOverTCP(txtReq01_Batch.Text, txtReq01_Response)
    End Sub

    Private Sub btnReq05_Click(sender As Object, e As EventArgs) Handles btnReq05.Click
        txtReq05_Response.Text = "Awaiting response..."

        txtReq05_Request.Text = txtReq05_Request.Text.Replace("%BATCHID%", txtReq01_BatchID.Text)
        txtReq05_Request.Text = txtReq05_Request.Text.Replace("%TIME%", GetTime())
        txtReq05_Request.Text = txtReq05_Request.Text.Replace("%ORDER%", txtReq01_Order.Text)
        txtReq05_Request.Text = txtReq05_Request.Text.Replace("%TICKET%", txtReq01_Ticket.Text)
        txtReq05_Request.Text = txtReq05_Request.Text.Replace("%TRUCK%", txtReq01_Truck.Text)
        txtReq05_Request.Text = txtReq05_Request.Text.Replace("%ALIAS%", txtReq01_Alias.Text)
        txtReq05_Request.Text = txtReq05_Request.Text.Replace("%WM%", txtReq01_WM.Text)

        SendOverTCP(txtReq05_Request.Text, txtReq05_Response)
    End Sub

    Private Sub btnReq07_Click(sender As Object, e As EventArgs) Handles btnReq07.Click
        txtReq07_Response.Text = "Awaiting response..."

        SendOverTCP(txtReq07_Request.Text, txtReq07_Response)
    End Sub

    Private Async Sub StartListening(sender As Object, e As EventArgs) Handles MyBase.Load
        If isRunning Then Return

        Dim ipaddr As IPAddress = IPAddress.Parse("192.168.175.1")
        listener = New TcpListener(ipaddr, 25522)
        Try
            listener.Start()
        Catch ex As SocketException
            Dim errorcode As Integer = ex.ErrorCode
            MessageBox.Show("Failed to create listener. Will not listen for requests. Socket error " + Str(errorcode) + ", what: " + ex.Message())
            Return
        End Try

        isRunning = True
        Me.Invoke(Sub()
                      lblTCPListenerRunning.BackColor = Color.Green
                  End Sub)

        Await Task.Run(Async Function()
                           While isRunning
                               Try
                                   client = Await listener.AcceptTcpClientAsync()
                                   ProcessClient()
                               Catch ex As ObjectDisposedException
                                   Exit While
                               Catch ex As Exception
                                   MessageBox.Show("[ERROR] StartListening(): Error accepting/dispatching tcp client: " + ex.Message())
                                   Application.Exit()
                               End Try
                           End While
                       End Function)
    End Sub

    Private Sub ProcessClient()
        Dim networkStream As NetworkStream = client.GetStream()
        If Not networkStream.CanRead Or Not networkStream.CanWrite Then
            MessageBox.Show("[ERROR] ProcessClient(): Network stream is not readable and writable")
        End If

        Dim returnbytes(client.ReceiveBufferSize) As Byte
        networkStream.Read(returnbytes, 0, CInt(client.ReceiveBufferSize))
        Dim returndata As String = System.Text.Encoding.ASCII.GetString(returnbytes)

        If String.IsNullOrEmpty(returndata) Or Not returndata.StartsWith("<?xml") Then
            MessageBox.Show("[ERROR] ProcessClient(): Received data either null/empty or doesn't start with '<?xml'")
            Return
        End If

        If returndata.IndexOf("<REQUEST>", StringComparison.CurrentCultureIgnoreCase) = -1 Then
            MessageBox.Show("[ERROR] ProcessClient(): Received something other than a request.")
            Return
        End If

        Dim idx1 As Integer = returndata.IndexOf("<TYPE>", StringComparison.CurrentCultureIgnoreCase) + 6
        Dim idx2 As Integer = returndata.IndexOf("</TYPE>", StringComparison.CurrentCultureIgnoreCase)
        Dim typestr As String = returndata.Substring(idx1, idx2 - idx1)
        Dim type As Integer = Integer.Parse(typestr)

        Select Case type
            Case 4
                idx1 = returndata.IndexOf("<BATCHID>", StringComparison.CurrentCultureIgnoreCase) + 9
                idx2 = returndata.IndexOf("</BATCHID>", StringComparison.CurrentCultureIgnoreCase)
                typestr = returndata.Substring(idx1, idx2 - idx1)
                Req0406BatchID = typestr

                Dim responsetext As String = Req0406ResponseTemplate.Replace("%TYPE%", "04")
                responsetext = responsetext.Replace("%BATCHID%", Req0406BatchID)
                Dim sendBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(responsetext)
                Dim stream As NetworkStream = client.GetStream()
                stream.Write(sendBytes, 0, sendBytes.Length)

                Me.Invoke(Sub()
                              txtReq04_Request.Text = returndata
                              txtReq04_Response.Text = responsetext
                          End Sub)
            Case 6
                idx1 = returndata.IndexOf("<BATCHID>", StringComparison.CurrentCultureIgnoreCase) + 9
                idx2 = returndata.IndexOf("</BATCHID>", StringComparison.CurrentCultureIgnoreCase)
                typestr = returndata.Substring(idx1, idx2 - idx1)
                Req0406BatchID = typestr

                Dim responsetext As String = Req0406ResponseTemplate.Replace("%TYPE%", "06")
                responsetext = responsetext.Replace("%BATCHID%", Req0406BatchID)
                Dim sendBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(responsetext)
                Dim stream As NetworkStream = client.GetStream()
                stream.Write(sendBytes, 0, sendBytes.Length)

                Me.Invoke(Sub()
                              txtReq06_Request.Text = returndata
                              txtReq06_Response.Text = responsetext
                          End Sub)
            Case 10
                Dim sendBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(Req10ResponseTemplate)
                Dim stream As NetworkStream = client.GetStream()
                stream.Write(sendBytes, 0, sendBytes.Length)

                Me.Invoke(Sub()
                              txtReq10_Request.Text = returndata
                              txtReq10_Response.Text = Req10ResponseTemplate
                          End Sub)
        End Select

        ' MessageBox.Show("Received Request [" + Str(type) + "]!")
        Dim dialogres As DialogResult = MessageBox.Show("Received Request " + Str(type) + ". Go to tab?", "Title", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        If (dialogres = DialogResult.Yes) Then
            Me.Invoke(Sub()
                          Select Case type
                              Case 4
                                  TabControl1.SelectedIndex = 2
                              Case 6
                                  TabControl1.SelectedIndex = 4
                              Case 10
                                  TabControl1.SelectedIndex = 6
                          End Select
                      End Sub)
        End If


    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        isRunning = False
        listener?.Stop()
    End Sub


End Class