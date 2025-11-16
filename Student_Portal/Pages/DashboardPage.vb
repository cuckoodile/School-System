Public Class DashboardPage
    Inherits BasePage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub DashboardPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize dashboard content
        Me.BackColor = Color.LightBlue
        SetupDashboardUI()
    End Sub

    Private Sub SetupDashboardUI()
        ' Clear any existing controls
        Me.Controls.Clear()

        ' Add title
        Dim titleLabel As New Label()
        titleLabel.Text = "Dashboard"
        titleLabel.Font = New Font("Arial", 16, FontStyle.Bold)
        titleLabel.Location = New Point(20, 20)
        titleLabel.Size = New Size(200, 30)
        titleLabel.ForeColor = Color.DarkBlue
        Me.Controls.Add(titleLabel)

        ' Add welcome message
        Dim welcomeLabel As New Label()
        welcomeLabel.Text = "Welcome to the Student Portal Dashboard!"
        welcomeLabel.Font = New Font("Arial", 12, FontStyle.Regular)
        welcomeLabel.Location = New Point(20, 60)
        welcomeLabel.Size = New Size(400, 25)
        Me.Controls.Add(welcomeLabel)

        ' Add some sample dashboard content
        Dim panel As New Panel()
        panel.Location = New Point(20, 100)
        panel.Size = New Size(300, 150)
        panel.BackColor = Color.White
        panel.BorderStyle = BorderStyle.FixedSingle
        Me.Controls.Add(panel)

        Dim summaryLabel As New Label()
        summaryLabel.Text = "Dashboard Summary"
        summaryLabel.Font = New Font("Arial", 12, FontStyle.Bold)
        summaryLabel.Location = New Point(10, 10)
        panel.Controls.Add(summaryLabel)

        Dim contentTextBox As New TextBox()
        contentTextBox.Text = "Here you can view your academic progress, upcoming assignments, and important announcements."
        contentTextBox.Font = New Font("Arial", 10, FontStyle.Regular)
        contentTextBox.Location = New Point(10, 35)
        contentTextBox.Size = New Size(280, 80)
        contentTextBox.Multiline = True
        contentTextBox.ReadOnly = True
        contentTextBox.BorderStyle = BorderStyle.None
        contentTextBox.BackColor = panel.BackColor
        contentTextBox.ScrollBars = ScrollBars.None
        panel.Controls.Add(contentTextBox)
    End Sub

    Public Overrides Sub OnPageShown()
        ' Called when this page is shown
        SetupDashboardUI()
    End Sub

End Class