Public Class SettingsPage
    Inherits BasePage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub SettingsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize settings content
        Me.BackColor = Color.LightSteelBlue
        SetupSettingsUI()
    End Sub

    Private Sub SetupSettingsUI()
        ' Clear any existing controls
        Me.Controls.Clear()

        ' Add title
        Dim titleLabel As New Label()
        titleLabel.Text = "System Settings"
        titleLabel.Font = New Font("Arial", 16, FontStyle.Bold)
        titleLabel.Location = New Point(20, 20)
        titleLabel.Size = New Size(300, 30)
        titleLabel.ForeColor = Color.Navy
        Me.Controls.Add(titleLabel)

        ' Add description
        Dim descLabel As New Label()
        descLabel.Text = "Configure system preferences and application settings."
        descLabel.Font = New Font("Arial", 12, FontStyle.Regular)
        descLabel.Location = New Point(20, 60)
        descLabel.Size = New Size(400, 25)
        Me.Controls.Add(descLabel)

        ' Add settings panel
        Dim settingsPanel As New Panel()
        settingsPanel.Location = New Point(20, 100)
        settingsPanel.Size = New Size(400, 250)
        settingsPanel.BackColor = Color.White
        settingsPanel.BorderStyle = BorderStyle.FixedSingle
        Me.Controls.Add(settingsPanel)

        ' Add some sample settings controls
        Dim themeLabel As New Label()
        themeLabel.Text = "Theme:"
        themeLabel.Location = New Point(10, 10)
        themeLabel.Size = New Size(80, 20)
        settingsPanel.Controls.Add(themeLabel)

        Dim themeComboBox As New ComboBox()
        themeComboBox.Location = New Point(100, 10)
        themeComboBox.Size = New Size(120, 23)
        themeComboBox.Items.Add("Light")
        themeComboBox.Items.Add("Dark")
        themeComboBox.Items.Add("Blue")
        themeComboBox.SelectedIndex = 0
        settingsPanel.Controls.Add(themeComboBox)

        Dim notificationsLabel As New Label()
        notificationsLabel.Text = "Notifications:"
        notificationsLabel.Location = New Point(10, 45)
        notificationsLabel.Size = New Size(80, 20)
        settingsPanel.Controls.Add(notificationsLabel)

        Dim notificationsCheckBox As New CheckBox()
        notificationsCheckBox.Text = "Enable notifications"
        notificationsCheckBox.Location = New Point(100, 45)
        notificationsCheckBox.Size = New Size(150, 20)
        notificationsCheckBox.Checked = True
        settingsPanel.Controls.Add(notificationsCheckBox)

        Dim languageLabel As New Label()
        languageLabel.Text = "Language:"
        languageLabel.Location = New Point(10, 80)
        languageLabel.Size = New Size(80, 20)
        settingsPanel.Controls.Add(languageLabel)

        Dim languageComboBox As New ComboBox()
        languageComboBox.Location = New Point(100, 80)
        languageComboBox.Size = New Size(120, 23)
        languageComboBox.Items.Add("English")
        languageComboBox.Items.Add("Spanish")
        languageComboBox.Items.Add("French")
        languageComboBox.SelectedIndex = 0
        settingsPanel.Controls.Add(languageComboBox)

        Dim saveButton As New Button()
        saveButton.Text = "Save Settings"
        saveButton.Location = New Point(10, 120)
        saveButton.Size = New Size(100, 30)
        saveButton.BackColor = Color.LightGreen
        settingsPanel.Controls.Add(saveButton)

        Dim resetButton As New Button()
        resetButton.Text = "Reset to Default"
        resetButton.Location = New Point(120, 120)
        resetButton.Size = New Size(120, 30)
        resetButton.BackColor = Color.LightYellow
        settingsPanel.Controls.Add(resetButton)
    End Sub

    Public Overrides Sub OnPageShown()
        ' Called when this page is shown
        SetupSettingsUI()
    End Sub

End Class