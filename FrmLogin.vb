Imports System.Data.SqlClient ' Initialiserer db motoren
Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class FrmLogin

    Dim strUsername As String ' variabel for brukernavn
    Dim strPassword As String ' variabel for passord

    Dim con As String ' dimmer variabel for SQL connection



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBrukernavn.Focus()
    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        strUsername = TxtBrukernavn.Text ' Fyller inn variabel for brukernavn
        strPassword = TxtPassord.Text ' Fyller inn variabel for passord

        SqlConTest() ' Kjører sub rutine for å sjekke connection
    End Sub


    Private Sub SqlConTest()

        Using con As New SqlConnection
            con.ConnectionString = "Server=win2012.norwegianhost.com;Database=Mailinglist;User Id=" & strUsername & ";Password=" & strPassword & ";"

            MsgBox(strUsername)
            MsgBox(strPassword)
            con.Open()

            If con.State = ConnectionState.Open Then

                Console.WriteLine("SqlConnection Information:")
                Console.WriteLine("  Connection State = " & con.State)
                Console.WriteLine("  Connection String = " & con.ConnectionString)
                Console.WriteLine("  Database Source = " & con.DataSource)
                Console.WriteLine("  Database = " & con.Database)
                Console.WriteLine("  Server Version = " & con.ServerVersion)
                Console.WriteLine("  Workstation Id = " & con.WorkstationId)
                Console.WriteLine("  Timeout = " & con.ConnectionTimeout)
                Console.WriteLine("  Packet Size = " & con.PacketSize)
            Else
                Console.WriteLine("SqlConenction failed to open.")
                Console.WriteLine("  Connection State = " & con.State)
            End If
            con.Close()
        End Using
    End Sub



End Class
