Imports System.Net
Imports System.Net.Sockets

Public Class frmSimPLC
    Private listener As TcpListener
    Private client As TcpClient
    Private sendstring As String = "<?xml version=$""1.0$"" ?><MESSAGE> <ACKNOWLEDGE>  <TYPE>00</TYPE>  <MODE>A</MODE>  <CMSTATUS>IR</CMSTATUS>  <BATCHID/>  <ORDER/>  <TICKET/>  <TRUCK/>  <COLOR/>  <ALIAS/>  <TOTALH2O/>  <ALLEY/>  <ACTPIG1/>  <ACTPIG2/>  <ACTPIG3/>  <ACTPIG4/>  <ACTPIG5/>  <ACTPIG6/>  <ACTWATER/>  <TARPIG1/>  <TARPIG2/>  <TARPIG3/>  <TARPIG4/>  <TARPIG5/>  <TARPIG6/>  <WEIGHMASTER/>  <DISCHARGEID/> </ACKNOWLEDGE></MESSAGE>"

    Private Sub frmSimPLC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ipaddr As IPAddress = IPAddress.Parse("192.168.175.1")
        listener = New TcpListener(ipaddr, 25522)

        Try
            listener.Start()
        Catch ex As SocketException
            Dim errorcode As Integer = ex.ErrorCode
            MessageBox.Show("Failed to create listener: " + Str(errorcode) + ", what: " + ex.Message())
            Return
        End Try

        client = listener.AcceptTcpClient()
        Dim clientNetworkStream As NetworkStream = client.GetStream()
        If Not clientNetworkStream.CanRead Or Not clientNetworkStream.CanWrite Then
            MessageBox.Show("Client's network stream is not readable or writable")
            Return
        End If

        Dim readbytes(client.ReceiveBufferSize) As Byte
        Dim readcount = clientNetworkStream.Read(readbytes, 0, CInt(client.ReceiveBufferSize))
        Dim readstring As String = System.Text.Encoding.ASCII.GetString(readbytes)
        txtReceived.Text = readstring

        Dim sendBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(sendstring)
        clientNetworkStream.Write(sendBytes, 0, sendBytes.Length)
        txtSent.Text = sendstring
    End Sub
End Class
