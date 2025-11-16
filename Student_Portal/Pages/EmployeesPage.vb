Public Class EmployeesPage
    Inherits BasePage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub EmployeesPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize employees content
        Me.BackColor = Color.LightGreen
        SetupEmployeesUI()
    End Sub

    Private Sub SetupEmployeesUI()
        ' Clear any existing controls
        Me.Controls.Clear()

        ' Add title
        Dim titleLabel As New Label()
        titleLabel.Text = "Employees Management"
        titleLabel.Font = New Font("Arial", 16, FontStyle.Bold)
        titleLabel.Location = New Point(20, 20)
        titleLabel.Size = New Size(300, 30)
        titleLabel.ForeColor = Color.DarkGreen
        Me.Controls.Add(titleLabel)

        ' Add description
        Dim descLabel As New Label()
        descLabel.Text = "Manage employee records, roles, and assignments."
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
        dataGridView.Columns.Add("ID", "ID")
        dataGridView.Columns.Add("Name", "Name")
        dataGridView.Columns.Add("Position", "Position")
        dataGridView.Columns.Add("Department", "Department")

        ' Add sample data
        dataGridView.Rows.Add("1", "John Smith", "Professor", "Computer Science")
        dataGridView.Rows.Add("2", "Jane Doe", "Professor", "Mathematics")
        dataGridView.Rows.Add("3", "Robert Johnson", "Admin", "Administration")

        Me.Controls.Add(dataGridView)

        ' Add action buttons
        Dim addButton As New Button()
        addButton.Text = "Add Employee"
        addButton.Location = New Point(20, 320)
        addButton.Size = New Size(100, 30)
        addButton.BackColor = Color.LightBlue
        Me.Controls.Add(addButton)

        Dim editButton As New Button()
        editButton.Text = "Edit Employee"
        editButton.Location = New Point(130, 320)
        editButton.Size = New Size(100, 30)
        editButton.BackColor = Color.LightYellow
        Me.Controls.Add(editButton)

        Dim deleteButton As New Button()
        deleteButton.Text = "Delete Employee"
        deleteButton.Location = New Point(240, 320)
        deleteButton.Size = New Size(100, 30)
        deleteButton.BackColor = Color.LightCoral
        Me.Controls.Add(deleteButton)
    End Sub

    Public Overrides Sub OnPageShown()
        ' Called when this page is shown
        SetupEmployeesUI()
    End Sub

End Class