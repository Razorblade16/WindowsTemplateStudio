﻿Imports wts.ItemName.ViewModels

Namespace Views
    ' TODO WTS: Change the icons and titles for all NavigationViewItems in ShellPage.xaml.
    Public NotInheritable Partial Class ShellPage
      Inherits Page

        Public ReadOnly Property ViewModel As New ShellViewModel

        Public Sub New()
            Me.InitializeComponent()
            DataContext = ViewModel
            ViewModel.Initialize(shellFrame, winUiNavigationView, KeyboardAccelerators)
        End Sub
    End Class
End Namespace
