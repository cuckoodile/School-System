Public Class CoursesPage
    Inherits BasePage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub CoursesPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize courses content
        Me.BackColor = Color.LightSalmon
        SetupCoursesUI()
    End Sub

    Private Sub SetupCoursesUI()
        ' Clear any existing controls
        Me.Controls.Clear()

        ' Add title
        Dim titleLabel As New Label()
        titleLabel.Text = "Course Management"
        titleLabel.Font = New Font("Arial", 16, FontStyle.Bold)
        titleLabel.Location = New Point(20, 20)
        titleLabel.Size = New Size(300, 30)
        titleLabel.ForeColor = Color.SaddleBrown
        Me.Controls.Add(titleLabel)

        ' Add description
        Dim descLabel As New Label()
        descLabel.Text = "Manage course offerings, schedules, and enrollment."
        descLabel.Font = New Font("Arial", 12, FontStyle.Regular)
        descLabel.Location = New Point(20, 60)
        descLabel.Size = New Size(400, 25)
        Me.Controls.Add(descLabel)

        ' Add a sample data grid
        Dim dataGridView As New DataGridView()
        dataGridView.Location = New Point(20, 100)
        dataGridView.Size = New Size(500, 200)
        dataGridView.ReadOnly = True
        dataGridView.AllowUserToAddRows = False
        dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Add sample columns
        dataGridView.Columns.Add("ID", "Course ID")
        dataGridView.Columns.Add("Title", "Title")
        dataGridView.Columns.Add("Credits", "Credits")
        dataGridView.Columns.Add("Schedule", "Schedule")

        ' Add sample data
        dataGridView.Rows.Add("CS101", "Introduction to Computer Science", "3", "MWF 9:00-10:00")
        dataGridView.Rows.Add("MATH201", "Calculus II", "4", "TTH 10:30-12:00")
        dataGridView.Rows.Add("PHYS101", "General Physics I", "4", "MWF 1:00-2:00")

        Me.Controls.Add(dataGridView)

        ' Add action buttons
        Dim addButton As New Button()
        addButton.Text = "Add Course"
        addButton.Location = New Point(20, 320)
        addButton.Size = New Size(100, 30)
        addButton.BackColor = Color.LightBlue
        Me.Controls.Add(addButton)

        Dim editButton As New Button()
        editButton.Text = "Edit Course"
        editButton.Location = New Point(130, 320)
        editButton.Size = New Size(100, 30)
        editButton.BackColor = Color.LightYellow
        Me.Controls.Add(editButton)

        Dim scheduleButton As New Button()
        scheduleButton.Text = "View Schedule"
        scheduleButton.Location = New Point(240, 320)
        scheduleButton.Size = New Size(120, 30)
        scheduleButton.BackColor = Color.LightGray
        Me.Controls.Add(scheduleButton)
    End Sub

    Public Overrides Sub OnPageShown()
        ' Called when this page is shown
        SetupCoursesUI()
    End Sub

End Class