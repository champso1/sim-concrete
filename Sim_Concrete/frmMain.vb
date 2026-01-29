Imports System.Net.Sockets
Imports System.IO
Imports System.Web

Public Class frmMain

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
        Dim t As String
        t = Format(Now(), "yyyy-MM-dd HH:mm:ss")
        GetTime = t
    End Function

    Private Sub btnReq00_Status_Click(sender As Object, e As EventArgs) Handles btnReq00_Status.Click
        SendOverTCP(txtReq00_Status.Text, txtReq00_Response)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnReq01_Batch_Click(sender As Object, e As EventArgs) Handles btnReq01_Batch.Click
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

        Dim send_text As String
        send_text = txtReq01_Batch.Text

        SendOverTCP(send_text, txtReq01_Response)
    End Sub
End Class