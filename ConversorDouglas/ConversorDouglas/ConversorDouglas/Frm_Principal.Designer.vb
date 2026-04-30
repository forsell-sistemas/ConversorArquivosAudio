<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.ts_botoes_topo = New System.Windows.Forms.ToolStrip()
        Me.cmd_converter = New System.Windows.Forms.ToolStripSplitButton()
        Me.cmd_converter_selecionado = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmd_fechar = New System.Windows.Forms.ToolStripButton()
        Me.lbl_info = New System.Windows.Forms.ToolStripLabel()
        Me.grpbox_topo = New System.Windows.Forms.GroupBox()
        Me.cbo_formato_origem = New System.Windows.Forms.ComboBox()
        Me.cmd_abrir_pasta_arquivos_originais = New System.Windows.Forms.Button()
        Me.cmd_abrir_pasta_destino = New System.Windows.Forms.Button()
        Me.cmd_baixar_ffmpeg = New System.Windows.Forms.Button()
        Me.cbo_formato_saida = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_pasta_destino = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_arquivos_audio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_arquivo_imagem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ffmpeg_local = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ts_botoes_arquivos = New System.Windows.Forms.ToolStrip()
        Me.cmd_carregar_arquivos = New System.Windows.Forms.ToolStripButton()
        Me.dg_arquivos = New System.Windows.Forms.DataGridView()
        Me.c_arquivo_caminho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_arquivo_nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pbar = New System.Windows.Forms.ProgressBar()
        Me.cmd_limpar_lista = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ts_botoes_topo.SuspendLayout()
        Me.grpbox_topo.SuspendLayout()
        Me.ts_botoes_arquivos.SuspendLayout()
        CType(Me.dg_arquivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ts_botoes_topo
        '
        Me.ts_botoes_topo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_converter, Me.ToolStripSeparator1, Me.cmd_fechar, Me.lbl_info})
        Me.ts_botoes_topo.Location = New System.Drawing.Point(0, 0)
        Me.ts_botoes_topo.Name = "ts_botoes_topo"
        Me.ts_botoes_topo.Size = New System.Drawing.Size(978, 25)
        Me.ts_botoes_topo.TabIndex = 0
        Me.ts_botoes_topo.Text = "ToolStrip1"
        '
        'cmd_converter
        '
        Me.cmd_converter.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_converter_selecionado})
        Me.cmd_converter.Image = CType(resources.GetObject("cmd_converter.Image"), System.Drawing.Image)
        Me.cmd_converter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmd_converter.Name = "cmd_converter"
        Me.cmd_converter.Size = New System.Drawing.Size(126, 22)
        Me.cmd_converter.Text = "Converter Todos"
        '
        'cmd_converter_selecionado
        '
        Me.cmd_converter_selecionado.Name = "cmd_converter_selecionado"
        Me.cmd_converter_selecionado.Size = New System.Drawing.Size(285, 22)
        Me.cmd_converter_selecionado.Text = "Converter apenas o arquivo selecionado"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmd_fechar
        '
        Me.cmd_fechar.Image = CType(resources.GetObject("cmd_fechar.Image"), System.Drawing.Image)
        Me.cmd_fechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmd_fechar.Name = "cmd_fechar"
        Me.cmd_fechar.Size = New System.Drawing.Size(62, 22)
        Me.cmd_fechar.Text = "Fechar"
        '
        'lbl_info
        '
        Me.lbl_info.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbl_info.ForeColor = System.Drawing.Color.Red
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(157, 22)
        Me.lbl_info.Text = "Nenhum arquivo convertido"
        '
        'grpbox_topo
        '
        Me.grpbox_topo.Controls.Add(Me.cbo_formato_origem)
        Me.grpbox_topo.Controls.Add(Me.cmd_abrir_pasta_arquivos_originais)
        Me.grpbox_topo.Controls.Add(Me.cmd_abrir_pasta_destino)
        Me.grpbox_topo.Controls.Add(Me.cmd_baixar_ffmpeg)
        Me.grpbox_topo.Controls.Add(Me.cbo_formato_saida)
        Me.grpbox_topo.Controls.Add(Me.Label6)
        Me.grpbox_topo.Controls.Add(Me.Label5)
        Me.grpbox_topo.Controls.Add(Me.txt_pasta_destino)
        Me.grpbox_topo.Controls.Add(Me.Label3)
        Me.grpbox_topo.Controls.Add(Me.txt_arquivos_audio)
        Me.grpbox_topo.Controls.Add(Me.Label4)
        Me.grpbox_topo.Controls.Add(Me.txt_arquivo_imagem)
        Me.grpbox_topo.Controls.Add(Me.Label2)
        Me.grpbox_topo.Controls.Add(Me.txt_ffmpeg_local)
        Me.grpbox_topo.Controls.Add(Me.Label1)
        Me.grpbox_topo.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpbox_topo.Location = New System.Drawing.Point(0, 25)
        Me.grpbox_topo.Name = "grpbox_topo"
        Me.grpbox_topo.Size = New System.Drawing.Size(978, 105)
        Me.grpbox_topo.TabIndex = 1
        Me.grpbox_topo.TabStop = False
        '
        'cbo_formato_origem
        '
        Me.cbo_formato_origem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_formato_origem.FormattingEnabled = True
        Me.cbo_formato_origem.Location = New System.Drawing.Point(815, 32)
        Me.cbo_formato_origem.Name = "cbo_formato_origem"
        Me.cbo_formato_origem.Size = New System.Drawing.Size(63, 21)
        Me.cbo_formato_origem.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.cbo_formato_origem, "Formato dos arquivos de origem")
        '
        'cmd_abrir_pasta_arquivos_originais
        '
        Me.cmd_abrir_pasta_arquivos_originais.Location = New System.Drawing.Point(761, 31)
        Me.cmd_abrir_pasta_arquivos_originais.Name = "cmd_abrir_pasta_arquivos_originais"
        Me.cmd_abrir_pasta_arquivos_originais.Size = New System.Drawing.Size(48, 23)
        Me.cmd_abrir_pasta_arquivos_originais.TabIndex = 15
        Me.cmd_abrir_pasta_arquivos_originais.Text = "Abrir"
        Me.cmd_abrir_pasta_arquivos_originais.UseVisualStyleBackColor = True
        '
        'cmd_abrir_pasta_destino
        '
        Me.cmd_abrir_pasta_destino.Location = New System.Drawing.Point(761, 72)
        Me.cmd_abrir_pasta_destino.Name = "cmd_abrir_pasta_destino"
        Me.cmd_abrir_pasta_destino.Size = New System.Drawing.Size(48, 23)
        Me.cmd_abrir_pasta_destino.TabIndex = 14
        Me.cmd_abrir_pasta_destino.Text = "Abrir"
        Me.cmd_abrir_pasta_destino.UseVisualStyleBackColor = True
        '
        'cmd_baixar_ffmpeg
        '
        Me.cmd_baixar_ffmpeg.Location = New System.Drawing.Point(386, 31)
        Me.cmd_baixar_ffmpeg.Name = "cmd_baixar_ffmpeg"
        Me.cmd_baixar_ffmpeg.Size = New System.Drawing.Size(48, 23)
        Me.cmd_baixar_ffmpeg.TabIndex = 13
        Me.cmd_baixar_ffmpeg.Text = "Baixar"
        Me.cmd_baixar_ffmpeg.UseVisualStyleBackColor = True
        '
        'cbo_formato_saida
        '
        Me.cbo_formato_saida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_formato_saida.FormattingEnabled = True
        Me.cbo_formato_saida.Location = New System.Drawing.Point(815, 73)
        Me.cbo_formato_saida.Name = "cbo_formato_saida"
        Me.cbo_formato_saida.Size = New System.Drawing.Size(63, 21)
        Me.cbo_formato_saida.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.cbo_formato_saida, "Formato dos arquivos resultantes da conversão")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(812, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Formato"
        Me.ToolTip1.SetToolTip(Me.Label6, "Formato dos arquivos resultantes da conversão")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(812, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Formato"
        Me.ToolTip1.SetToolTip(Me.Label5, "Formato dos arquivos de origem")
        '
        'txt_pasta_destino
        '
        Me.txt_pasta_destino.Location = New System.Drawing.Point(443, 73)
        Me.txt_pasta_destino.Name = "txt_pasta_destino"
        Me.txt_pasta_destino.Size = New System.Drawing.Size(312, 20)
        Me.txt_pasta_destino.TabIndex = 7
        Me.txt_pasta_destino.Text = "C:\Douglas\Banda\Videos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pasta de saída"
        '
        'txt_arquivos_audio
        '
        Me.txt_arquivos_audio.Location = New System.Drawing.Point(443, 32)
        Me.txt_arquivos_audio.Name = "txt_arquivos_audio"
        Me.txt_arquivos_audio.Size = New System.Drawing.Size(312, 20)
        Me.txt_arquivos_audio.TabIndex = 5
        Me.txt_arquivos_audio.Text = "C:\Douglas\Banda\TapeTees"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(440, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Caminho com os arquivos de áudio"
        '
        'txt_arquivo_imagem
        '
        Me.txt_arquivo_imagem.Location = New System.Drawing.Point(15, 73)
        Me.txt_arquivo_imagem.Name = "txt_arquivo_imagem"
        Me.txt_arquivo_imagem.Size = New System.Drawing.Size(419, 20)
        Me.txt_arquivo_imagem.TabIndex = 3
        Me.txt_arquivo_imagem.Text = "C:\Douglas\Banda\Separados\Outro\tapetees.png"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Arquivo com a imagem"
        '
        'txt_ffmpeg_local
        '
        Me.txt_ffmpeg_local.Location = New System.Drawing.Point(15, 32)
        Me.txt_ffmpeg_local.Name = "txt_ffmpeg_local"
        Me.txt_ffmpeg_local.Size = New System.Drawing.Size(365, 20)
        Me.txt_ffmpeg_local.TabIndex = 1
        Me.txt_ffmpeg_local.Text = "C:\Douglas\ffmpeg\bin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caminho do .exe do conversor FFMpeg"
        '
        'ts_botoes_arquivos
        '
        Me.ts_botoes_arquivos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_carregar_arquivos, Me.ToolStripSeparator2, Me.cmd_limpar_lista})
        Me.ts_botoes_arquivos.Location = New System.Drawing.Point(0, 153)
        Me.ts_botoes_arquivos.Name = "ts_botoes_arquivos"
        Me.ts_botoes_arquivos.Size = New System.Drawing.Size(978, 25)
        Me.ts_botoes_arquivos.TabIndex = 2
        Me.ts_botoes_arquivos.Text = "ToolStrip1"
        '
        'cmd_carregar_arquivos
        '
        Me.cmd_carregar_arquivos.Image = CType(resources.GetObject("cmd_carregar_arquivos.Image"), System.Drawing.Image)
        Me.cmd_carregar_arquivos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmd_carregar_arquivos.Name = "cmd_carregar_arquivos"
        Me.cmd_carregar_arquivos.Size = New System.Drawing.Size(169, 22)
        Me.cmd_carregar_arquivos.Text = "Carregar arquivos de áudio"
        '
        'dg_arquivos
        '
        Me.dg_arquivos.AllowUserToAddRows = False
        Me.dg_arquivos.AllowUserToDeleteRows = False
        Me.dg_arquivos.AllowUserToResizeRows = False
        Me.dg_arquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_arquivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_arquivo_caminho, Me.c_arquivo_nome})
        Me.dg_arquivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_arquivos.Location = New System.Drawing.Point(0, 178)
        Me.dg_arquivos.Name = "dg_arquivos"
        Me.dg_arquivos.ReadOnly = True
        Me.dg_arquivos.RowHeadersWidth = 30
        Me.dg_arquivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_arquivos.Size = New System.Drawing.Size(978, 240)
        Me.dg_arquivos.TabIndex = 3
        '
        'c_arquivo_caminho
        '
        Me.c_arquivo_caminho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.c_arquivo_caminho.HeaderText = "Caminho"
        Me.c_arquivo_caminho.MinimumWidth = 150
        Me.c_arquivo_caminho.Name = "c_arquivo_caminho"
        Me.c_arquivo_caminho.ReadOnly = True
        '
        'c_arquivo_nome
        '
        Me.c_arquivo_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.c_arquivo_nome.HeaderText = "Nome"
        Me.c_arquivo_nome.MinimumWidth = 150
        Me.c_arquivo_nome.Name = "c_arquivo_nome"
        Me.c_arquivo_nome.ReadOnly = True
        Me.c_arquivo_nome.Width = 150
        '
        'pbar
        '
        Me.pbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbar.Location = New System.Drawing.Point(0, 130)
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(978, 23)
        Me.pbar.TabIndex = 4
        '
        'cmd_limpar_lista
        '
        Me.cmd_limpar_lista.Image = CType(resources.GetObject("cmd_limpar_lista.Image"), System.Drawing.Image)
        Me.cmd_limpar_lista.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmd_limpar_lista.Name = "cmd_limpar_lista"
        Me.cmd_limpar_lista.Size = New System.Drawing.Size(100, 22)
        Me.cmd_limpar_lista.Text = "Limpar a Lista"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 418)
        Me.Controls.Add(Me.dg_arquivos)
        Me.Controls.Add(Me.ts_botoes_arquivos)
        Me.Controls.Add(Me.pbar)
        Me.Controls.Add(Me.grpbox_topo)
        Me.Controls.Add(Me.ts_botoes_topo)
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversor de Áudio"
        Me.ts_botoes_topo.ResumeLayout(False)
        Me.ts_botoes_topo.PerformLayout()
        Me.grpbox_topo.ResumeLayout(False)
        Me.grpbox_topo.PerformLayout()
        Me.ts_botoes_arquivos.ResumeLayout(False)
        Me.ts_botoes_arquivos.PerformLayout()
        CType(Me.dg_arquivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ts_botoes_topo As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmd_fechar As ToolStripButton
    Friend WithEvents grpbox_topo As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_pasta_destino As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_arquivos_audio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_arquivo_imagem As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ffmpeg_local As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ts_botoes_arquivos As ToolStrip
    Friend WithEvents cmd_carregar_arquivos As ToolStripButton
    Friend WithEvents dg_arquivos As DataGridView
    Friend WithEvents c_arquivo_caminho As DataGridViewTextBoxColumn
    Friend WithEvents c_arquivo_nome As DataGridViewTextBoxColumn
    Friend WithEvents pbar As ProgressBar
    Friend WithEvents cbo_formato_saida As ComboBox
    Friend WithEvents lbl_info As ToolStripLabel
    Friend WithEvents cmd_converter As ToolStripSplitButton
    Friend WithEvents cmd_converter_selecionado As ToolStripMenuItem
    Friend WithEvents cmd_baixar_ffmpeg As Button
    Friend WithEvents cmd_abrir_pasta_destino As Button
    Friend WithEvents cmd_abrir_pasta_arquivos_originais As Button
    Friend WithEvents cbo_formato_origem As ComboBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmd_limpar_lista As ToolStripButton
    Friend WithEvents ToolTip1 As ToolTip
End Class
