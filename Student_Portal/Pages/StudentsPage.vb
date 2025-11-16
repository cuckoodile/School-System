Public Class StudentsPage
    Inherits BasePage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub StudentsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize students content
        Me.BackColor = Color.LightCoral
        SetupStudentsUI()
    End Sub

    Private Sub SetupStudentsUI()
        ' Clear any existing controls
        Me.Controls.Clear()

        ' Add title
        Dim titleLabel As New Label()
        titleLabel.Text = "Student Management"
        titleLabel.Font = New Font("Arial", 16, FontStyle.Bold)
        titleLabel.Location = New Point(20, 20)
        titleLabel.Size = New Size(300, 30)
        titleLabel.ForeColor = Color.DarkRed
        Me.Controls.Add(titleLabel)

        ' Add description
        Dim descLabel As New Label()
        descLabel.Text = "Manage student records, enrollment, and academic information."
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
        dataGridView.Columns.Add("ID", "Student ID")
        dataGridView.Columns.Add("Name", "Name")
        dataGridView.Columns.Add("Major", "Major")
        dataGridView.Columns.Add("Year", "Year")

        ' Add sample data
        dataGridView.Rows.Add("1001", "Alice Johnson", "Computer Science", "Junior")
        dataGridView.Rows.Add("1002", "Bob Williams", "Mathematics", "Senior")
        dataGridView.Rows.Add("1003", "Carol Brown", "Physics", "Sophomore")

        Me.Controls.Add(dataGridView)

        ' Add action buttons
        Dim addButton As New Button()
        addButton.Text = "Add Student"
        addButton.Location = New Point(20, 320)
        addButton.Size = New Size(100, 30)
        addButton.BackColor = Color.LightBlue
        Me.Controls.Add(addButton)

        Dim editButton As New Button()
        editButton.Text = "Edit Student"
        editButton.Location = New Point(130, 320)
        editButton.Size = New Size(100, 30)
        editButton.BackColor = Color.LightYellow
        Me.Controls.Add(editButton)

        Dim viewButton As New Button()
        viewButton.Text = "View Details"
        viewButton.Location = New Point(240, 320)
        viewButton.Size = New Size(100, 30)
        viewButton.BackColor = Color.LightGray
        Me.Controls.Add(viewButton)
    End Sub

    Public Overrides Sub OnPageShown()
        ' Called when this page is shown
        SetupStudentsUI()
    End Sub

End Class