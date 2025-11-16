Public Class Form1

    ' Declare page instances
    Private dashboardPage As DashboardPage
    Private employeesPage As EmployeesPage
    Private studentsPage As StudentsPage
    Private coursesPage As CoursesPage
    Private settingsPage As SettingsPage

    ' Keep track of currently displayed page
    Private currentPage As BasePage = Nothing

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize all pages
        InitializePages()

        ' Set default page (Dashboard)
        ShowPage(dashboardPage)
        RadioButton1.Checked = True
    End Sub

    Private Sub InitializePages()
        dashboardPage = New DashboardPage()
        employeesPage = New EmployeesPage()
        studentsPage = New StudentsPage()
        coursesPage = New CoursesPage()
        settingsPage = New SettingsPage()
    End Sub

    Private Sub ShowPage(pageToShow As BasePage)
        ' Hide current page if exists
        If currentPage IsNot Nothing Then
            currentPage.Visible = False
            currentPage.OnPageHidden()
        End If

        ' Set new page as current
        currentPage = pageToShow

        ' Configure and show new page
        currentPage.Dock = DockStyle.Fill
        currentPage.Visible = True

        ' Add to outlet panel (Panel3)
        If Not Panel3.Controls.Contains(currentPage) Then
            Panel3.Controls.Add(currentPage)
        End If

        currentPage.BringToFront()
        currentPage.OnPageShown()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            ShowPage(dashboardPage)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            ShowPage(employeesPage)
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            ShowPage(studentsPage)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            ShowPage(coursesPage)
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            ShowPage(settingsPage)
        End If
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint
        ' This can remain empty or be used for custom painting if needed
    End Sub
End Class
