Public Class Frm_Principal

    Private Sub cmd_fechar_Click(sender As Object, e As EventArgs) Handles cmd_fechar.Click
        Me.Dispose()
    End Sub

    Private Function FormatoTipoAudio(ByVal formato As String) As Boolean
        Dim audio As Boolean = False
        Select Case formato
            Case "mp3", "wav"
                audio = True
            Case Else
                audio = False
        End Select
        Return audio
    End Function

    Private Function Converter(ByVal arquivo_caminho_completo As String, ByVal arquivo_nome As String) As Boolean
        Dim ok As Boolean = False
        If Not System.IO.File.Exists(txt_ffmpeg_local.Text & "\ffmpeg.exe") Then
            Cursor = Cursors.Default
            MsgBox("O executável do FFmpeg não foi encontrado no local informado.", vbOKOnly + vbInformation, "Atenção")
            txt_ffmpeg_local.Focus()
        Else
            If FormatoTipoAudio(cbo_formato_saida.Text) Then
                If Not System.IO.File.Exists(txt_arquivo_imagem.Text) Then
                    Cursor = Cursors.Default
                    MsgBox("Imagem não encontrada.", vbOKOnly + vbInformation, "Atenção")
                    txt_arquivo_imagem.Focus()
                    ok = False
                    Return False
                    Exit Function
                End If
            End If
            Dim arquivo_destino As String = txt_pasta_destino.Text & arquivo_nome & "." & cbo_formato_saida.Text
            If Not System.IO.File.Exists(arquivo_destino) Then
                Dim myprocess As New Process
                Dim StartInfo As New System.Diagnostics.ProcessStartInfo
                StartInfo.FileName = "cmd"
                StartInfo.RedirectStandardInput = True
                StartInfo.RedirectStandardOutput = True
                StartInfo.RedirectStandardError = True
                StartInfo.UseShellExecute = False
                StartInfo.CreateNoWindow = True
                myprocess.StartInfo = StartInfo
                myprocess.Start()
                Dim SR As System.IO.StreamReader = myprocess.StandardOutput
                Dim SE As System.IO.StreamReader = myprocess.StandardError
                Dim SW As System.IO.StreamWriter = myprocess.StandardInput
                '--------
                SW.WriteLine("cd " & txt_ffmpeg_local.Text)
                Dim comando As String = String.Empty
                If FormatoTipoAudio(cbo_formato_saida.Text) Then
                    comando = $"ffmpeg -i ""{arquivo_caminho_completo}"" -vn -ar 44100 -ac 2 -b:a 320k ""{arquivo_destino}"" & exit /b"
                Else
                    comando = $"ffmpeg -loop 1 -i ""{txt_arquivo_imagem.Text}"" -i ""{arquivo_caminho_completo}"" -c:v libx264 -tune stillimage -c:a aac -b:a 192k -pix_fmt yuv420p -shortest ""{arquivo_destino}"" & exit /b"
                End If
                SW.WriteLine(comando)
                SW.WriteLine("shutdown /p")
                SW.WriteLine("exit")
                If (SE.Equals(System.IO.StreamReader.Null) <> True) Then
                    Dim StreamWriterLog As New System.IO.StreamWriter(Application.StartupPath & "\LogConversao.txt")
                    StreamWriterLog.WriteLine(SE.ReadToEnd())
                    StreamWriterLog.Close()
                End If
                SW.Close()
                SR.Close()
                SE.Close()
                ok = True
                Threading.Thread.Sleep(1000)
            Else
                'Arquivo já existe
                ok = True
            End If
        End If
        Return ok
    End Function

    Private Sub HDbotoes(ByVal tof As Boolean)
        ts_botoes_topo.Enabled = tof
        grpbox_topo.Enabled = tof
        ts_botoes_arquivos.Enabled = tof
    End Sub

    Private Sub cmd_carregar_arquivos_Click(sender As Object, e As EventArgs) Handles cmd_carregar_arquivos.Click
        If txt_arquivos_audio.Text.Trim = String.Empty Then
            MsgBox("Iforme a pasta com os arquivos.", vbOKOnly + vbInformation, "Atenção")
            txt_arquivos_audio.Focus()
        Else
            Dim diretorio As New System.IO.DirectoryInfo(txt_arquivos_audio.Text)
            If diretorio.Exists Then
                Dim arquivos_dados = diretorio.GetFiles("*." & cbo_formato_origem.Text)
                Array.Sort(arquivos_dados, New ComparadorArquivos)
                Dim linhas_novas As New List(Of DataGridViewRow)
                Dim linha_nova As DataGridViewRow
                For Each arquivo In arquivos_dados
                    linha_nova = New DataGridViewRow
                    linha_nova.CreateCells(dg_arquivos)
                    linha_nova.Cells(c_arquivo_caminho.Index).Value = arquivo.FullName
                    Dim extensao As String = arquivo.Extension
                    Dim nome_sem_extensao As String = arquivo.Name.Replace(extensao, String.Empty).Trim
                    linha_nova.Cells(c_arquivo_nome.Index).Value = nome_sem_extensao
                    linhas_novas.Add(linha_nova)
                Next
                dg_arquivos.Rows.AddRange(linhas_novas.ToArray)
            Else
                MsgBox("Diretório com os arquivos de áudio não encontrado.", vbOKOnly + vbInformation, "Atenção")
                txt_arquivos_audio.Focus()
            End If
        End If
    End Sub

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_info.Text = String.Empty
        CarregaFormatosOrigem()
        CarregarFormatosSaida()
    End Sub

    Private Sub CarregaFormatosOrigem()
        With cbo_formato_origem
            With .Items
                .Clear()
                .Add("mp3")
                .Add("wav")
            End With
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub CarregarFormatosSaida()
        With cbo_formato_saida
            With .Items
                .Clear()
                .Add("avi")
                .Add("mp3")
            End With
            .SelectedIndex = 0
        End With
    End Sub

    Public Class ComparadorArquivos
        Implements IComparer

        Public Function CompararArquivos(x As Object, y As Object) As Integer Implements IComparer.Compare
            Dim a1 = DirectCast(x, IO.FileInfo)
            Dim a2 = DirectCast(y, IO.FileInfo)
            Dim nr1 As String = RetornaNumero(a1.Name)
            Dim nr2 As String = RetornaNumero(a2.Name)
            If IsNumeric(nr1) AndAlso IsNumeric(nr2) Then
                If CLng(nr1) > CLng(nr2) Then Return 1
                If CLng(nr1) < CLng(nr2) Then Return -1
            Else
                If a1.Name > a2.Name Then Return 1
                If a1.Name < a2.Name Then Return -1
            End If
            Return 0
        End Function

        Private Function RetornaNumero(ByVal texto As String) As String
            Dim nr As String = String.Empty
            For i = 0 To texto.Length - 1
                Dim conteudo As String = texto.Substring(i, 1)
                If IsNumeric(conteudo) Then
                    nr += conteudo
                Else
                    If Not nr.Trim = String.Empty Then
                        Exit For
                    End If
                End If
            Next
            If Not IsNumeric(nr) Then
                nr = System.Text.RegularExpressions.Regex.Replace(texto, "\D", "")
            End If
            Return nr
        End Function

    End Class

    Private Sub cmd_converter_ButtonClick(sender As Object, e As EventArgs) Handles cmd_converter.ButtonClick
        pbar.Value = 0
        lbl_info.Text = String.Empty
        If Not txt_pasta_destino.Text.EndsWith("\") Then
            txt_pasta_destino.Text += "\"
        End If
        If dg_arquivos.RowCount > 0 Then
            Cursor = Cursors.WaitCursor
            HDbotoes(False)
            pbar.Maximum = dg_arquivos.RowCount
            pbar.Step = 1
            Dim i As Long = 1
            For Each linha As DataGridViewRow In dg_arquivos.Rows
                lbl_info.Text = "Convertendo " & i & " de " & dg_arquivos.RowCount
                If Converter(linha.Cells(c_arquivo_caminho.Index).Value, linha.Cells(c_arquivo_nome.Index).Value) Then
                    pbar.PerformStep()
                End If
                i += 1
                Application.DoEvents()
            Next
            Cursor = Cursors.Default
            MsgBox("Os arquivos foram convertidos com sucesso.", vbOKOnly + vbInformation, "Concluído")
            HDbotoes(True)
            pbar.Value = 0
        Else
            MsgBox("Nenhum arquivo listado.", vbOKOnly + vbInformation, "Atenção")
            ts_botoes_arquivos.Focus()
            cmd_carregar_arquivos.Select()
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub cmd_converter_selecionado_Click(sender As Object, e As EventArgs) Handles cmd_converter_selecionado.Click
        pbar.Value = 0
        lbl_info.Text = String.Empty
        If Not txt_pasta_destino.Text.EndsWith("\") Then
            txt_pasta_destino.Text += "\"
        End If
        If dg_arquivos.RowCount > 0 Then
            If Not dg_arquivos.CurrentRow Is Nothing Then
                Cursor = Cursors.WaitCursor
                HDbotoes(False)
                lbl_info.Text = "Convertendo " & dg_arquivos.CurrentRow.Cells(c_arquivo_nome.Index).Value.ToString
                If Converter(dg_arquivos.CurrentRow.Cells(c_arquivo_caminho.Index).Value, dg_arquivos.CurrentRow.Cells(c_arquivo_nome.Index).Value) Then
                    MsgBox("Arquivo convertido.", vbOKOnly + vbInformation, "Atenção")
                End If
                HDbotoes(True)
                Cursor = Cursors.Default
            Else
                MsgBox("Nenhum arquivo selecionado.", vbOKOnly + vbInformation, "Atenção")
                ts_botoes_arquivos.Focus()
                cmd_carregar_arquivos.Select()
            End If
        Else
            MsgBox("Nenhum arquivo listado.", vbOKOnly + vbInformation, "Atenção")
            ts_botoes_arquivos.Focus()
            cmd_carregar_arquivos.Select()
        End If
    End Sub

    Private Sub cmd_baixar_ffmpeg_Click(sender As Object, e As EventArgs) Handles cmd_baixar_ffmpeg.Click
        cmd_baixar_ffmpeg.Enabled = False
        Cursor = Cursors.WaitCursor
        Dim webAddress As String = "https://ffmpeg.org/"
        Process.Start(webAddress)
        System.Threading.Thread.Sleep(2000)
        cmd_baixar_ffmpeg.Enabled = True
        Cursor = Cursors.Default
    End Sub

    Private Sub cmd_abrir_pasta_destino_Click(sender As Object, e As EventArgs) Handles cmd_abrir_pasta_destino.Click
        cmd_abrir_pasta_destino.Enabled = False
        If Not txt_pasta_destino.Text.Trim = String.Empty AndAlso System.IO.Directory.Exists(txt_pasta_destino.Text) Then
            Cursor = Cursors.WaitCursor
            Dim c As String = String.Empty
            If txt_pasta_destino.Text.Trim = String.Empty Then
                c = My.Application.Info.DirectoryPath.ToString
            Else
                c = txt_pasta_destino.Text.Trim
            End If
            If My.Computer.FileSystem.DirectoryExists(c) Then
                Process.Start("explorer.exe", c)
                System.Threading.Thread.Sleep(2000)
            Else
                MsgBox("Diretório " & c & " não encontrado.", vbOKOnly + vbInformation, "Atenção")
            End If
            Cursor = Cursors.Default
        Else
            Dim folder As New FolderBrowserDialog
            folder.Description = "Selecione o diretório para os arquivos convertidos"
            folder.SelectedPath = My.Application.Info.DirectoryPath.ToString
            Dim Result As DialogResult = folder.ShowDialog
            If Result = DialogResult.OK Then
                txt_pasta_destino.Text = folder.SelectedPath
            End If
        End If
        cmd_abrir_pasta_destino.Enabled = True
    End Sub

    Private Sub cmd_abrir_pasta_arquivos_originais_Click(sender As Object, e As EventArgs) Handles cmd_abrir_pasta_arquivos_originais.Click
        cmd_abrir_pasta_arquivos_originais.Enabled = False
        If Not txt_arquivos_audio.Text.Trim = String.Empty AndAlso System.IO.Directory.Exists(txt_arquivos_audio.Text) Then
            Cursor = Cursors.WaitCursor
            Dim c As String = String.Empty
            If txt_arquivos_audio.Text.Trim = String.Empty Then
                c = My.Application.Info.DirectoryPath.ToString
            Else
                c = txt_arquivos_audio.Text.Trim
            End If
            If My.Computer.FileSystem.DirectoryExists(c) Then
                Process.Start("explorer.exe", c)
                System.Threading.Thread.Sleep(2000)
            Else
                MsgBox("Diretório " & c & " não encontrado.", vbOKOnly + vbInformation, "Atenção")
            End If
            Cursor = Cursors.Default
        Else
            Dim folder As New FolderBrowserDialog
            folder.Description = "Selecione o diretório para os arquivos de áudio a serem convertidos"
            folder.SelectedPath = My.Application.Info.DirectoryPath.ToString
            Dim Result As DialogResult = folder.ShowDialog
            If Result = DialogResult.OK Then
                txt_arquivos_audio.Text = folder.SelectedPath
            End If
        End If
        cmd_abrir_pasta_arquivos_originais.Enabled = True
    End Sub

    Private Sub cbo_formato_saida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_formato_saida.SelectedIndexChanged
        With txt_arquivo_imagem
            If FormatoTipoAudio(cbo_formato_saida.Text) Then
                .PasswordChar = "*"
                .Enabled = False
                .ReadOnly = True
            Else
                .PasswordChar = String.Empty
                .Enabled = True
                .ReadOnly = False
            End If
        End With
    End Sub

    Private Sub dg_arquivos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dg_arquivos.RowsAdded
        HDBotoes()
    End Sub

    Private Sub dg_arquivos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dg_arquivos.RowsRemoved
        HDBotoes()
    End Sub

    Private Sub HDBotoes()
        If dg_arquivos.RowCount > 0 Then
            cmd_converter.Enabled = True
            cmd_converter_selecionado.Enabled = True
        Else
            cmd_converter.Enabled = False
            cmd_converter_selecionado.Enabled = False
        End If
    End Sub

    Private Sub Frm_Principal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        HDBotoes()
    End Sub

    Private Sub cmd_limpar_lista_Click(sender As Object, e As EventArgs) Handles cmd_limpar_lista.Click
        If dg_arquivos.RowCount > 0 Then
            If MsgBox("Deseja realmente limpar a lista de arquivos a serem convertidos?", vbYesNo + vbQuestion, "Atenção") = vbYes Then
                dg_arquivos.Rows.Clear()
            End If
        Else
            MsgBox("Nenhum arquivo listado.", vbOKOnly + vbInformation, "Atenção")
        End If
        ts_botoes_arquivos.Focus()
        cmd_carregar_arquivos.Select()
    End Sub

End Class
