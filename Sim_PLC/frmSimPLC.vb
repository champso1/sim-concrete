Imports System.Configuration
Imports System.Net
Imports System.Net.Http
Imports System.Net.Sockets
Imports System.Threading

Public Class frmSimPLC
    Private isRunning As Boolean = False
    Private listener As TcpListener
    Private client As TcpClient
    Private sendstring As String = "<? xml version=$""1.0$"" ?><MESSAGE> <ACKNOWLEDGE>  <TYPE>00</TYPE>  <MODE>A</MODE>  <CMSTATUS>IR</CMSTATUS>  <BATCHID/>  <ORDER/>  <TICKET/>  <TRUCK/>  <COLOR/>  <ALIAS/>  <TOTALH2O/>  <ALLEY/>  <ACTPIG1/>  <ACTPIG2/>  <ACTPIG3/>  <ACTPIG4/>  <ACTPIG5/>  <ACTPIG6/>  <ACTWATER/>  <TARPIG1/>  <TARPIG2/>  <TARPIG3/>  <TARPIG4/>  <TARPIG5/>  <TARPIG6/>  <WEIGHMASTER/>  <DISCHARGEID/> </ACKNOWLEDGE></MESSAGE>"
    Private sendstring2 As String = "<?xml version=$""1.0$"" ?>" & Environment.NewLine & "<MESSAGE>" & Environment.NewLine & "<REQUEST>" & Environment.NewLine & "<TYPE>10</TYPE>" & Environment.NewLine & "<MODE>A</MODE>" & Environment.NewLine & "<CMSTATUS>IR</CMSTATUS>" & Environment.NewLine & "<BATCHID/>" & Environment.NewLine & "<ORDER/>" & Environment.NewLine & "<TICKET/>" & Environment.NewLine & "<TRUCK/>" & Environment.NewLine & "<COLOR/>" & Environment.NewLine & "<ALIAS/>" & Environment.NewLine & "<TOTALH2O/>" & Environment.NewLine & "<ALLEY/>" & Environment.NewLine & "<ACTPIG1/>" & Environment.NewLine & "<ACTPIG2/>" & Environment.NewLine & "<ACTPIG3/>" & Environment.NewLine & "<ACTPIG4/>" & Environment.NewLine & "<ACTPIG5/>" & Environment.NewLine & "<ACTPIG6/>" & Environment.NewLine & "<ACTWATER/>" & Environment.NewLine & "<TARPIG1/>" & Environment.NewLine & "<TARPIG2/>" & Environment.NewLine & "<TARPIG3/>" & Environment.NewLine & "<TARPIG4/>" & Environment.NewLine & "<TARPIG5/>" & Environment.NewLine & "<TARPIG6/>" & Environment.NewLine & "<WEIGHMASTER/>" & Environment.NewLine & "<DISCHARGEID/>" & Environment.NewLine & "</REQUEST>" & Environment.NewLine & "</MESSAGE>"
    Private sendstring3 As String = "Ohiluhawoduihlkawh 2u0358y02y7x85m2853u0-c5982uy3-08ux50p9yo38n y0cnm9"
    Private sendstring4 As String = "<?xml version=$""1.0$"" ?>"
    Private sendstring5 As String = "<MESSAGE> <REQUEST>  <TYPE>10</TYPE>  <MODE>A</MODE>  <CMSTATUS>IR</CMSTATUS>  <BATCHID/>  <ORDER/>  <TICKET/>  <TRUCK/>  <COLOR/>  <ALIAS/>  <TOTALH2O/>  <ALLEY/>  <ACTPIG1/>  <ACTPIG2/>  <ACTPIG3/>  <ACTPIG4/>  <ACTPIG5/>  <ACTPIG6/>  <ACTWATER/>  <TARPIG1/>  <TARPIG2/>  <TARPIG3/>  <TARPIG4/>  <TARPIG5/>  <TARPIG6/>  <WEIGHMASTER/>  <DISCHARGEID/> </REQUEST></MESSAGE>"

    Private Sub SendOverTCP(str As String)
        Try
            Dim tcpClient As New System.Net.Sockets.TcpClient()
            tcpClient.Connect("192.168.175.4", 25522)

            Dim networkStream As NetworkStream = tcpClient.GetStream()

            If networkStream.CanWrite And networkStream.CanRead Then
                Dim sendBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(str)

                'Send the data as bytes
                networkStream.Write(sendBytes, 0, sendBytes.Length)
                Me.Invoke(Sub()
                              txtSent.Text = str
                          End Sub)


                ' This might not be necessary, I don't believe we receive anything back on the same TCP connection
                ' networkStream.ReadTimeout = 5000
                ' Dim returnbytes(tcpClient.ReceiveBufferSize) As Byte
                ' Dim bytesread As Integer = networkStream.Read(returnbytes, 0, CInt(tcpClient.ReceiveBufferSize))

                'networkStream.Close()
                'tcpClient.Close()
                Exit Sub
            Else
                MessageBox.Show("Error: Cannot read/write data to PLC (stream not readable/writable). Not sure what this means or how to fix. Good luck!")
                networkStream.Close()
                tcpClient.Close()
                Exit Sub
            End If
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Failed to send data to the IP Address: " + ex.ToString())
        End Try
    End Sub

    Private Async Sub frmSimPLC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isRunning Then Return

        Dim ipaddr As IPAddress = IPAddress.Parse("192.168.175.1")
        Dim tcpport As Integer = Integer.Parse(txtListenPort.Text)
        listener = New TcpListener(ipaddr, 25521)

        Try
            listener.Start()
        Catch ex As SocketException
            Dim errorcode As Integer = ex.ErrorCode
            MessageBox.Show("Failed to create listener: " + Str(errorcode) + ", what: " + ex.Message())
            Return
        End Try

        isRunning = True
        Await Task.Run(Async Function()
                           While isRunning
                               Try
                                   client = Await listener.AcceptTcpClientAsync()
                                   ProcessClient()
                                   ' SendOverTCP(sendstring)
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
        Dim clientNetworkStream As NetworkStream = client.GetStream()
        If Not clientNetworkStream.CanRead Or Not clientNetworkStream.CanWrite Then
            MessageBox.Show("Client's network stream is not readable or writable")
            Return
        End If

        Dim readbytes(client.ReceiveBufferSize) As Byte
        Dim readcount = clientNetworkStream.Read(readbytes, 0, CInt(client.ReceiveBufferSize))
        Dim readstring As String = System.Text.Encoding.ASCII.GetString(readbytes)

        ' This is for if we are sending responses back on the same open TCP connection
        Dim sendBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(sendstring)
        clientNetworkStream.Write(sendBytes, 0, sendBytes.Length)

        ' This is for if we are sending responses back on a new TCP connection
        'SendOverTCP(sendstring)

        Me.Invoke(Sub()
                      txtClientInfo.Text = "Doing second wait after write"
                  End Sub)
        Thread.Sleep(10000)

        Me.Invoke(Sub()
                      txtClientInfo.Text = "Finished waiting. Updating text and exiting"
                  End Sub)

        Me.Invoke(Sub()
                      txtReceived.Text = readstring
                      txtSent.Text = sendstring
                  End Sub)

        clientNetworkStream.Close(5000)
    End Sub

    Private Sub btnSendExampleStatusReq_Click(sender As Object, e As EventArgs) Handles btnSendExampleStatusReq.Click
        Select Case cmbxExampleReqChoices.SelectedIndex
            Case -1
                MessageBox.Show("No message is selected.")
                Return
            Case 0
                SendOverTCP(sendstring)
            Case 1
                SendOverTCP(sendstring2)
            Case 2
                SendOverTCP(sendstring3)
            Case 3
                SendOverTCP(sendstring4)
            Case 4
                SendOverTCP(sendstring5)
        End Select
    End Sub
End Class
