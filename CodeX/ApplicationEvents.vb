Namespace My
    Partial Friend Class MyApplication
        Private WithEvents MyEvents As AppDomain = AppDomain.CurrentDomain
        Private Function MyFunc(ByVal sender As Object, ByVal e As System.ResolveEventArgs) As System.Reflection.Assembly Handles MyEvents.AssemblyResolve
            If e.Name.Contains("FastColoredTextBox") Then
                Return System.Reflection.Assembly.Load(My.Resources.FastColoredTextBox)
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace

