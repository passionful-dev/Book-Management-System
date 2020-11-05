Module Module2
    Sub main()
        'Calling "Login" form
        Dim f As New frmLogin()
        f.ShowDialog()
        If f.cok = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim f1 As New frmBookDetails()
        f1.ShowDialog()
    End Sub
End Module
