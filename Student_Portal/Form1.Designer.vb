<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Panel3 = New Panel()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.BackColor = Color.DeepSkyBlue
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 0, 2)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Left
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(200, 861)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 86)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Teal
        TableLayoutPanel1.SetColumnSpan(Panel2, 10)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 774)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 87)
        Panel2.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(RadioButton5, 0, 4)
        TableLayoutPanel2.Controls.Add(RadioButton4, 0, 3)
        TableLayoutPanel2.Controls.Add(RadioButton3, 0, 2)
        TableLayoutPanel2.Controls.Add(RadioButton2, 0, 1)
        TableLayoutPanel2.Controls.Add(RadioButton1, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Left
        TableLayoutPanel2.Location = New Point(0, 86)
        TableLayoutPanel2.Margin = New Padding(0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 6
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 55F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(200, 688)
        TableLayoutPanel2.TabIndex = 2
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.CheckAlign = ContentAlignment.MiddleCenter
        RadioButton5.Cursor = Cursors.Hand
        RadioButton5.Dock = DockStyle.Fill
        RadioButton5.ImageAlign = ContentAlignment.MiddleRight
        RadioButton5.Location = New Point(0, 175)
        RadioButton5.Margin = New Padding(0)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.RightToLeft = RightToLeft.No
        RadioButton5.Size = New Size(200, 40)
        RadioButton5.TabIndex = 4
        RadioButton5.TabStop = True
        RadioButton5.Text = "Dashboard"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.CheckAlign = ContentAlignment.MiddleCenter
        RadioButton4.Cursor = Cursors.Hand
        RadioButton4.Dock = DockStyle.Fill
        RadioButton4.ImageAlign = ContentAlignment.MiddleRight
        RadioButton4.Location = New Point(0, 135)
        RadioButton4.Margin = New Padding(0)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.RightToLeft = RightToLeft.No
        RadioButton4.Size = New Size(200, 40)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
        RadioButton4.Text = "Dashboard"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.CheckAlign = ContentAlignment.MiddleCenter
        RadioButton3.Cursor = Cursors.Hand
        RadioButton3.Dock = DockStyle.Fill
        RadioButton3.ImageAlign = ContentAlignment.MiddleRight
        RadioButton3.Location = New Point(0, 95)
        RadioButton3.Margin = New Padding(0)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.RightToLeft = RightToLeft.No
        RadioButton3.Size = New Size(200, 40)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Dashboard"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.CheckAlign = ContentAlignment.MiddleCenter
        RadioButton2.Cursor = Cursors.Hand
        RadioButton2.Dock = DockStyle.Fill
        RadioButton2.ImageAlign = ContentAlignment.MiddleRight
        RadioButton2.Location = New Point(0, 55)
        RadioButton2.Margin = New Padding(0)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.RightToLeft = RightToLeft.No
        RadioButton2.Size = New Size(200, 40)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Employees"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.CheckAlign = ContentAlignment.MiddleCenter
        RadioButton1.Cursor = Cursors.Hand
        RadioButton1.Dock = DockStyle.Fill
        RadioButton1.ImageAlign = ContentAlignment.MiddleRight
        RadioButton1.Location = New Point(0, 0)
        RadioButton1.Margin = New Padding(0)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.RightToLeft = RightToLeft.No
        RadioButton1.Size = New Size(200, 55)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Dashboard"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.AutoSize = True
        Panel3.BackColor = Color.DodgerBlue
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(200, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1084, 861)
        Panel3.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.SlateGray
        ClientSize = New Size(1284, 861)
        Controls.Add(Panel3)
        Controls.Add(TableLayoutPanel1)
        Name = "Form1"
        RightToLeft = RightToLeft.No
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Portal"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton

End Class
