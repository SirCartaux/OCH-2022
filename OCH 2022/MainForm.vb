Imports System.Net

Public Class MainForm
    Public SERVER_IP = "0.0.0.0"
    Public MAIN_DIRECTORY = "0"
    Public FTP_DIRECTORY = "0"
    Public SERVER_DIRECTORY = "0"
    Public ChannelPanelList As New List(Of Panel)
    Public ServerPanelList As New List(Of Panel)
    Public ChannelObjList As New List(Of ChannelButton)
    Public ServerlObjList As New List(Of Object)
    Public SCLIST As New List(Of List(Of String))

    Public CHANNEL = ""
    Public SERVER = "Future Studios"

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SetupDataFolder()
        LoadLists
        SERVER_IP = GetCurrentServerIP()
        FTP_DIRECTORY = GetCurrentFtpDirectory()
        SERVER_DIRECTORY = GetCurrentServerDirectory()
        DownloadSCList()
        LoadSCList()
        BuildChannelsFromSCList()
        StartUpOCHClient()
    End Sub

    Public Sub StartUpOCHClient()

    End Sub

    Public Sub LoadLists()
        ChannelPanelList.Add(ChannelButtonPanel1) : ChannelPanelList.Add(ChannelButtonPanel2) : ChannelPanelList.Add(ChannelButtonPanel3) : ChannelPanelList.Add(ChannelButtonPanel4) : ChannelPanelList.Add(ChannelButtonPanel5) : ChannelPanelList.Add(ChannelButtonPanel6) : ChannelPanelList.Add(ChannelButtonPanel7) : ChannelPanelList.Add(ChannelButtonPanel8) : ChannelPanelList.Add(ChannelButtonPanel9) : ChannelPanelList.Add(ChannelButtonPanel10) : ChannelPanelList.Add(ChannelButtonPanel11) : ChannelPanelList.Add(ChannelButtonPanel12) : ChannelPanelList.Add(ChannelButtonPanel13)
        ServerPanelList.Add(ServerButtonPanel1) : ServerPanelList.Add(ServerButtonPanel2) : ServerPanelList.Add(ServerButtonPanel3) : ServerPanelList.Add(ServerButtonPanel4) : ServerPanelList.Add(ServerButtonPanel5) : ServerPanelList.Add(ServerButtonPanel6) : ServerPanelList.Add(ServerButtonPanel7) : ServerPanelList.Add(ServerButtonPanel8) : ServerPanelList.Add(ServerButtonPanel9) : ServerPanelList.Add(ServerButtonPanel10)
    End Sub

    Public Sub DownloadSCList()
        DownloadFile(SERVER_DIRECTORY & "sclist.list", "sclist.list")
    End Sub

    Public Sub BuildServersFromSCList()

    End Sub

    Public Sub BuildChannelsFromSCList()
        For i As Integer = 0 To SCLIST(0).Count() - 1
            If i = 0 Then
                Dim cur_title As New TitleObject
                cur_title.ChangeButtonText(SCLIST(0)(i))
                ChannelPanelList(i).Controls.Add(cur_title)
            Else
                Dim cur_button As New ChannelButton
                cur_button.ChangeButtonText(SCLIST(0)(i))
                ChannelPanelList(i).Controls.Add(cur_button)
                cur_button.motherform = Me
                cur_button.id = i
                ChannelObjList.Add(cur_button)
            End If
        Next
    End Sub

    Public Sub switchChannel(id As Integer)
        CHANNEL = SCLIST(0)(id)
        ChatPanel.Controls.Clear()
        DownloadFile(SERVER_DIRECTORY & "server\" & SERVER & "\" & CHANNEL & "i", "di")
        Dim index As Integer = ReadFirstLine("di")
    End Sub

    Public Sub unselectAllChannels()
        For i As Integer = 0 To ChannelObjList.Count() - 1
            ChannelObjList(i).selected = False
            ChannelObjList(i).Label1.BackColor = Color.FromArgb(30, 30, 30)
            ChannelObjList(i).Label1.ForeColor = Color.FromArgb(180, 180, 180)
            ChannelObjList(i).PictureBox1.BackColor = Color.FromArgb(30, 30, 30)
        Next
    End Sub

    Public Sub LoadSCList()
        Dim scliststr = ReadFirstLine("sclist.list")
        Dim servers_sclist = scliststr.Split("?")
        For i As Integer = 0 To servers_sclist.Count() - 1
            Dim cur_sclist As New List(Of String)
            Dim cur_channels_sclist = servers_sclist(i).Split("&")
            For x As Integer = 0 To cur_channels_sclist.Count() - 1
                cur_sclist.Add(cur_channels_sclist(x))
            Next
            SCLIST.Add(cur_sclist)
        Next
    End Sub

    Public Sub SetupDataFolder()
        If My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\OCH2022") Then
            MAIN_DIRECTORY = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\OCH2022\"
        Else
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\OCH2022")
            MAIN_DIRECTORY = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\OCH2022\"
        End If
    End Sub

    Public Function GetCurrentServerDirectory() As String
        Return "http://" & SERVER_IP & "/OCH2022/"
    End Function

    Public Function GetCurrentFtpDirectory() As String
        Return "ftp://" & SERVER_IP & "/"
    End Function

    Public Function PullInformationText()
        Dim information = "test"
        Return information
    End Function

    Public Sub DownloadFile(address As String, filename As String)
        Dim WebDownloader As New WebClient
        WebDownloader.DownloadFile(address, MAIN_DIRECTORY & filename)
    End Sub

    Public Function ReadFirstLine(file As String) As String
        Dim StreamReader As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(MAIN_DIRECTORY & file)
        Return StreamReader.ReadLine()
    End Function

    Public Function GetCurrentServerIP() As String
        DownloadFile("http://www.cartaux.net/ochip.ip", "ochip.ip")
        Return ReadFirstLine("ochip.ip")
    End Function

    Private Sub MessageBox_Click(sender As Object, e As EventArgs) Handles MessageBox_Corners_Left.Click, MessageBox_Corners_Right.Click, MessageBox_Fill_Upper.Click, MessageBox_Fill_Lower.Click
        MessageBox.Focus()
    End Sub

    Public Sub Button1c()

    End Sub
    Public Sub Button2c()

    End Sub
    Public Sub Button3c()

    End Sub
    Public Sub Button4c()

    End Sub
    Public Sub Button5c()

    End Sub
    Public Sub Button6c()

    End Sub
    Public Sub Button7c()

    End Sub
    Public Sub Button8c()

    End Sub
    Public Sub Button9c()

    End Sub
    Public Sub Button10c()

    End Sub
    Public Sub Button11c()

    End Sub
    Public Sub Button12c()

    End Sub
    Public Sub Button13c()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        MessageBox_Fill_Upper.Size = New Size(MessageBox_Corners_Right.Left - MessageBox_Corners_Right.Width - 10, MessageBox_Fill_Upper.Size.Height)
        MessageBox_Fill_Lower.Size = New Size(MessageBox_Corners_Right.Left - MessageBox_Corners_Right.Width - 10, MessageBox_Fill_Upper.Size.Height)
    End Sub

    Private Sub MessageBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MessageBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class
