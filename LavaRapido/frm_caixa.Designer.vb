﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_caixa
    Inherits MetroFramework.Forms.MetroForm

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.Button5 = New MetroFramework.Controls.MetroButton()
        Me.btn_adicionar = New MetroFramework.Controls.MetroButton()
        Me.cmb_servico = New MetroFramework.Controls.MetroComboBox()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_total = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.dgv_caixa = New MetroFramework.Controls.MetroGrid()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Button2 = New MetroFramework.Controls.MetroButton()
        Me.TabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.txt_parametros = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.dgv_dados = New MetroFramework.Controls.MetroGrid()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_caixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Column2
        '
        Me.Column2.HeaderText = "Preço"
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Descrição"
        Me.Column1.Name = "Column1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.btn_adicionar)
        Me.TabPage2.Controls.Add(Me.cmb_servico)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.lbl_total)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.dgv_caixa)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.HorizontalScrollbarBarColor = True
        Me.TabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage2.HorizontalScrollbarSize = 10
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(711, 430)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Caixa"
        Me.TabPage2.UseVisualStyleBackColor = True
        Me.TabPage2.VerticalScrollbarBarColor = True
        Me.TabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage2.VerticalScrollbarSize = 10
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(598, 355)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Cancelar"
        Me.Button5.UseSelectable = True
        '
        'btn_adicionar
        '
        Me.btn_adicionar.Location = New System.Drawing.Point(520, 83)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(75, 23)
        Me.btn_adicionar.TabIndex = 11
        Me.btn_adicionar.Text = "Adicionar"
        Me.btn_adicionar.UseSelectable = True
        '
        'cmb_servico
        '
        Me.cmb_servico.FormattingEnabled = True
        Me.cmb_servico.ItemHeight = 23
        Me.cmb_servico.Location = New System.Drawing.Point(350, 83)
        Me.cmb_servico.Name = "cmb_servico"
        Me.cmb_servico.Size = New System.Drawing.Size(154, 29)
        Me.cmb_servico.TabIndex = 10
        Me.cmb_servico.UseSelectable = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(346, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Adicionar Serviço"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(447, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "R$ 00,00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(447, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "R$ 00,00"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(447, 328)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(59, 19)
        Me.lbl_total.TabIndex = 5
        Me.lbl_total.Text = "R$ 00,00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(346, 377)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Preço final:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(358, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Desconto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(385, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total:"
        '
        'dgv_caixa
        '
        Me.dgv_caixa.AllowUserToAddRows = False
        Me.dgv_caixa.AllowUserToDeleteRows = False
        Me.dgv_caixa.AllowUserToResizeRows = False
        Me.dgv_caixa.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_caixa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_caixa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_caixa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_caixa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_caixa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_caixa.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_caixa.EnableHeadersVisualStyles = False
        Me.dgv_caixa.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_caixa.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_caixa.Location = New System.Drawing.Point(6, 44)
        Me.dgv_caixa.Name = "dgv_caixa"
        Me.dgv_caixa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_caixa.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_caixa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_caixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_caixa.Size = New System.Drawing.Size(319, 363)
        Me.dgv_caixa.TabIndex = 1
        '
        'Column3
        '
        Me.Column3.HeaderText = "Serviço"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 140
        '
        'Column4
        '
        Me.Column4.HeaderText = "Preço"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 60
        '
        'Column5
        '
        Me.Column5.HeaderText = "Excluir"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 60
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(598, 384)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Finalizar "
        Me.Button2.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.txt_parametros)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.dgv_dados)
        Me.TabPage1.HorizontalScrollbarBarColor = True
        Me.TabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage1.HorizontalScrollbarSize = 10
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(711, 430)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inicio"
        Me.TabPage1.UseVisualStyleBackColor = True
        Me.TabPage1.VerticalScrollbarBarColor = True
        Me.TabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage1.VerticalScrollbarSize = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(491, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 31)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Iniciar Caixa"
        Me.Button1.UseSelectable = True
        '
        'txt_parametros
        '
        '
        '
        '
        Me.txt_parametros.CustomButton.Image = Nothing
        Me.txt_parametros.CustomButton.Location = New System.Drawing.Point(257, 2)
        Me.txt_parametros.CustomButton.Name = ""
        Me.txt_parametros.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txt_parametros.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_parametros.CustomButton.TabIndex = 1
        Me.txt_parametros.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_parametros.CustomButton.UseSelectable = True
        Me.txt_parametros.CustomButton.Visible = False
        Me.txt_parametros.Lines = New String(-1) {}
        Me.txt_parametros.Location = New System.Drawing.Point(32, 48)
        Me.txt_parametros.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_parametros.MaxLength = 32767
        Me.txt_parametros.Name = "txt_parametros"
        Me.txt_parametros.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_parametros.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_parametros.SelectedText = ""
        Me.txt_parametros.SelectionLength = 0
        Me.txt_parametros.SelectionStart = 0
        Me.txt_parametros.ShortcutsEnabled = True
        Me.txt_parametros.Size = New System.Drawing.Size(275, 20)
        Me.txt_parametros.TabIndex = 22
        Me.txt_parametros.UseSelectable = True
        Me.txt_parametros.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_parametros.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Digite o RG do Cliente"
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AllowUserToResizeColumns = False
        Me.dgv_dados.AllowUserToResizeRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_dados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_dados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_dados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_dados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.usuario})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_dados.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_dados.EnableHeadersVisualStyles = False
        Me.dgv_dados.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_dados.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_dados.Location = New System.Drawing.Point(32, 84)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_dados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_dados.Size = New System.Drawing.Size(444, 324)
        Me.dgv_dados.TabIndex = 20
        '
        'numero
        '
        Me.numero.HeaderText = "RG"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        '
        'usuario
        '
        Me.usuario.HeaderText = "Nome"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 63)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 1
        Me.TabControl1.Size = New System.Drawing.Size(719, 472)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.UseSelectable = True
        '
        'frm_caixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 537)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_caixa"
        Me.Text = "Caixa"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_caixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_caixa.CellContentClick
    End Sub

    Friend WithEvents TabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Button5 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_adicionar As MetroFramework.Controls.MetroButton
    Friend WithEvents cmb_servico As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_total As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgv_caixa As MetroFramework.Controls.MetroGrid
    Friend WithEvents Button2 As MetroFramework.Controls.MetroButton
    Friend WithEvents TabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Button1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_parametros As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgv_dados As MetroFramework.Controls.MetroGrid
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
End Class
