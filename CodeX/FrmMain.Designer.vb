<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Codigos", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Themas", System.Windows.Forms.HorizontalAlignment.Left)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.LvCodigos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnCopiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCodigo = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LvCodigos
        '
        Me.LvCodigos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LvCodigos.Dock = System.Windows.Forms.DockStyle.Left
        Me.LvCodigos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvCodigos.FullRowSelect = True
        Me.LvCodigos.GridLines = True
        ListViewGroup1.Header = "Codigos"
        ListViewGroup1.Name = "Codigos"
        ListViewGroup2.Header = "Themas"
        ListViewGroup2.Name = "Themas"
        Me.LvCodigos.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.LvCodigos.HideSelection = False
        Me.LvCodigos.Location = New System.Drawing.Point(0, 0)
        Me.LvCodigos.MultiSelect = False
        Me.LvCodigos.Name = "LvCodigos"
        Me.LvCodigos.Size = New System.Drawing.Size(226, 366)
        Me.LvCodigos.SmallImageList = Me.GList
        Me.LvCodigos.TabIndex = 2
        Me.LvCodigos.UseCompatibleStateImageBehavior = False
        Me.LvCodigos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nome"
        Me.ColumnHeader1.Width = 141
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tamanho"
        Me.ColumnHeader2.Width = 62
        '
        'GList
        '
        Me.GList.ImageStream = CType(resources.GetObject("GList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.GList.TransparentColor = System.Drawing.Color.Transparent
        Me.GList.Images.SetKeyName(0, "0.png")
        '
        'btnSalvar
        '
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.Black
        Me.btnSalvar.Location = New System.Drawing.Point(0, 0)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(273, 23)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnCopiar
        '
        Me.btnCopiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCopiar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCopiar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopiar.ForeColor = System.Drawing.Color.Black
        Me.btnCopiar.Location = New System.Drawing.Point(273, 0)
        Me.btnCopiar.Name = "btnCopiar"
        Me.btnCopiar.Size = New System.Drawing.Size(153, 23)
        Me.btnCopiar.TabIndex = 4
        Me.btnCopiar.Text = "Copiar"
        Me.btnCopiar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCopiar)
        Me.Panel1.Controls.Add(Me.btnSalvar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(226, 343)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(426, 23)
        Me.Panel1.TabIndex = 5
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoScrollMinSize = New System.Drawing.Size(0, 14)
        Me.txtCodigo.BackBrush = Nothing
        Me.txtCodigo.CharHeight = 14
        Me.txtCodigo.CharWidth = 8
        Me.txtCodigo.CommentPrefix = "'"
        Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigo.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCodigo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCodigo.IsReplaceMode = False
        Me.txtCodigo.Language = FastColoredTextBoxNS.Language.VB
        Me.txtCodigo.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.txtCodigo.Location = New System.Drawing.Point(226, 0)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Paddings = New System.Windows.Forms.Padding(0)
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.txtCodigo.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.Size = New System.Drawing.Size(426, 343)
        Me.txtCodigo.TabIndex = 6
        Me.txtCodigo.WordWrap = True
        Me.txtCodigo.Zoom = 100
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(652, 366)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LvCodigos)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListCode V0.1 RC [SOOFTT.BLOGSPOT.COM]"
        Me.Panel1.ResumeLayout(False)
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LvCodigos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GList As System.Windows.Forms.ImageList
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnCopiar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCodigo As FastColoredTextBoxNS.FastColoredTextBox

End Class
