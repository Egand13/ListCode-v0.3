Imports System.IO

Public Class FrmMain

    Sub New()
        InitializeComponent()
        Dim Range As New List(Of ListViewItem)
        For Each ResourceFile As DictionaryEntry In My.Resources.ResourceManager.GetResourceSet(Globalization.CultureInfo.CurrentCulture, True, True).OfType(Of Object)()
            If TypeOf (ResourceFile.Value) Is String Then
                If ResourceFile.Key.ToString.Contains("FastColoredTextBox") = False Then
                    Dim NewItem As New ListViewItem
                    NewItem.SubItems.Add(FileSize(ResourceFile.Value.length))
                    NewItem.ImageIndex = 0
                    If ResourceFile.Key.ToString.StartsWith("Thema__") Then
                        NewItem.Text = ResourceFile.Key.ToString.Replace("Thema__", "").Replace("_Theme1", "").Replace("Theme1", "").Replace("_", " ").Replace("Theme", "")
                        NewItem.Group = LvCodigos.Groups("Themas")
                    Else
                        NewItem.Text = ResourceFile.Key
                        NewItem.Group = LvCodigos.Groups("Codigos")
                    End If
                    NewItem.Tag = ResourceFile.Key
                    Range.Add(NewItem)
                End If
            End If
        Next
        LvCodigos.Items.AddRange(Range.ToArray)
    End Sub

    Private Function FileSize(ByVal Tamanho As Double) As String
        Dim Tipos As String() = {"Bytes", "KB", "MB", "GB"}
        Dim TamanhoDouble As Double = Tamanho
        Dim CSA As Integer = 0
        While TamanhoDouble >= 1024 AndAlso CSA + 1 < Tipos.Length
            CSA += 1
            TamanhoDouble = TamanhoDouble / 1024
        End While
        Return [String].Format("{0:0.##} {1}", TamanhoDouble, Tipos(CSA))
    End Function

    Private Sub LvCodigos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvCodigos.SelectedIndexChanged
        For Each Y As ListViewItem In LvCodigos.SelectedItems
            txtCodigo.Text = My.Resources.ResourceManager.GetObject(Y.Tag)
        Next
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtCodigo.Text.Length < 1 Then Exit Sub
        Dim X As New SaveFileDialog
        X.Title = "SALVAR ARQUIVOS"
        X.FileName = Now.ToString("""CODIGO ""dd-MM-yyyy hh-mm-ss")
        X.Filter = "DOCUMENTO TEXTO (*.txt)|*.txt|ARQUIVO VISUAL BASIC (*.vb)|*.vb|TODOS ARQUIVOS (*.*)|*.*"
        If X.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim N As New StreamWriter(X.FileName)
            For Each LINHA In txtCodigo.Lines
                N.WriteLine(LINHA)
            Next
            N.Flush()
            N.Close()
            MsgBox("Saved Successfully", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub btnCopiar_Click(sender As Object, e As EventArgs) Handles btnCopiar.Click
        If txtCodigo.Text.Length < 1 Then Exit Sub
        Dim ResultText As String = Nothing
        For Each LINHA In txtCodigo.Lines
            ResultText &= LINHA & vbCrLf
        Next
        Clipboard.SetText(ResultText, TextDataFormat.Text)
        MsgBox("Copied Successfully", MsgBoxStyle.Information, "Information")
    End Sub

End Class
