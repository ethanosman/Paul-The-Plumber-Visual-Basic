Class LoginForm

    Private WithEvents iptForm As InputForm

    ' Clear form's contents
    Private Sub btnClear_Click(sender As Object, e As RoutedEventArgs) Handles btnClear.Click

        txtUserName.Text = ""
        txtPassword.Text = ""

    End Sub

    ' Login button to main form
    Private Sub btnLogin_Click(sender As Object, e As RoutedEventArgs) Handles btnLogin.Click

        Dim userName, password As String

        userName = "testuser"
        password = "testpassword"

        If txtUserName.Text = "" Or txtPassword.Text = "" Then

            MsgBox("Please provide User Name and Password", 0, "Alert")

        End If
        Try
            If txtUserName.Text = userName And txtPassword.Text = password Then
                MsgBox("Login Successful!", 0, "Login")
                iptForm = New InputForm
                iptForm.Show()
                Me.Close()
            Else
                MsgBox("Login Failed!", 0, "Alert")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    ' Exit button to close program
    Private Sub btnExit_Click(sender As Object, e As RoutedEventArgs) Handles btnExit.Click

        Close()

    End Sub

End Class
