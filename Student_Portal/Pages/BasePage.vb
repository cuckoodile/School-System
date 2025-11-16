Public Class BasePage
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    ' This method can be overridden by child pages to handle when the page is shown
    Public Overridable Sub OnPageShown()
        ' Default implementation - can be overridden in derived classes
    End Sub

    ' This method can be overridden by child pages to handle when the page is hidden
    Public Overridable Sub OnPageHidden()
        ' Default implementation - can be overridden in derived classes
    End Sub

End Class