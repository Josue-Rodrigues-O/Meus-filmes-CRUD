namespace MeusFilmes.InterfaceUsuario
{
    partial class CadatroFilme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            GroupTitulo = new GroupBox();
            TxtTitulo = new TextBox();
            GroupDuracao = new GroupBox();
            TxtDuracao = new TextBox();
            GroupAvaliacao = new GroupBox();
            LabelAvaliacao = new Label();
            TrackBarAvalicao = new TrackBar();
            GroupGenero = new GroupBox();
            ComboBoxGenero = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnSalvar = new Button();
            BtnCancelar = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            GroupTitulo.SuspendLayout();
            GroupDuracao.SuspendLayout();
            GroupAvaliacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrackBarAvalicao).BeginInit();
            GroupGenero.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.69164F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.3083572F));
            tableLayoutPanel1.Size = new Size(353, 341);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(GroupTitulo, 0, 0);
            tableLayoutPanel2.Controls.Add(GroupDuracao, 0, 1);
            tableLayoutPanel2.Controls.Add(GroupAvaliacao, 0, 2);
            tableLayoutPanel2.Controls.Add(GroupGenero, 0, 3);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(347, 269);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // GroupTitulo
            // 
            GroupTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupTitulo.Controls.Add(TxtTitulo);
            GroupTitulo.Location = new Point(3, 3);
            GroupTitulo.Name = "GroupTitulo";
            GroupTitulo.Size = new Size(341, 61);
            GroupTitulo.TabIndex = 0;
            GroupTitulo.TabStop = false;
            GroupTitulo.Text = "Título";
            // 
            // TxtTitulo
            // 
            TxtTitulo.Location = new Point(6, 19);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(329, 23);
            TxtTitulo.TabIndex = 0;
            // 
            // GroupDuracao
            // 
            GroupDuracao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupDuracao.Controls.Add(TxtDuracao);
            GroupDuracao.Location = new Point(3, 70);
            GroupDuracao.Name = "GroupDuracao";
            GroupDuracao.Size = new Size(341, 61);
            GroupDuracao.TabIndex = 1;
            GroupDuracao.TabStop = false;
            GroupDuracao.Text = "Duração";
            // 
            // TxtDuracao
            // 
            TxtDuracao.Location = new Point(6, 19);
            TxtDuracao.Name = "TxtDuracao";
            TxtDuracao.Size = new Size(329, 23);
            TxtDuracao.TabIndex = 1;
            // 
            // GroupAvaliacao
            // 
            GroupAvaliacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupAvaliacao.Controls.Add(LabelAvaliacao);
            GroupAvaliacao.Controls.Add(TrackBarAvalicao);
            GroupAvaliacao.Location = new Point(3, 137);
            GroupAvaliacao.Name = "GroupAvaliacao";
            GroupAvaliacao.Size = new Size(341, 61);
            GroupAvaliacao.TabIndex = 2;
            GroupAvaliacao.TabStop = false;
            GroupAvaliacao.Text = "Avaliação";
            // 
            // LabelAvaliacao
            // 
            LabelAvaliacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LabelAvaliacao.AutoSize = true;
            LabelAvaliacao.Font = new Font("Segoe UI", 15F);
            LabelAvaliacao.Location = new Point(312, 22);
            LabelAvaliacao.Name = "LabelAvaliacao";
            LabelAvaliacao.Size = new Size(23, 28);
            LabelAvaliacao.TabIndex = 1;
            LabelAvaliacao.Text = "0";
            // 
            // TrackBarAvalicao
            // 
            TrackBarAvalicao.Location = new Point(6, 22);
            TrackBarAvalicao.Maximum = 5;
            TrackBarAvalicao.Name = "TrackBarAvalicao";
            TrackBarAvalicao.Size = new Size(300, 45);
            TrackBarAvalicao.TabIndex = 0;
            TrackBarAvalicao.ValueChanged += TrackBarAvalicao_ValueChanged;
            // 
            // GroupGenero
            // 
            GroupGenero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupGenero.Controls.Add(ComboBoxGenero);
            GroupGenero.Location = new Point(3, 204);
            GroupGenero.Name = "GroupGenero";
            GroupGenero.Size = new Size(341, 62);
            GroupGenero.TabIndex = 3;
            GroupGenero.TabStop = false;
            GroupGenero.Text = "Gênero do filme";
            // 
            // ComboBoxGenero
            // 
            ComboBoxGenero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxGenero.FormattingEnabled = true;
            ComboBoxGenero.Location = new Point(6, 22);
            ComboBoxGenero.Name = "ComboBoxGenero";
            ComboBoxGenero.Size = new Size(329, 23);
            ComboBoxGenero.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.Controls.Add(BtnSalvar, 1, 0);
            tableLayoutPanel3.Controls.Add(BtnCancelar, 2, 0);
            tableLayoutPanel3.Location = new Point(3, 278);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(347, 60);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnSalvar.Location = new Point(150, 3);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(94, 54);
            BtnSalvar.TabIndex = 4;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += Ao_Clicar_Em_Salvar;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnCancelar.Location = new Point(250, 3);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 54);
            BtnCancelar.TabIndex = 5;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += Ao_Clicar_Em_Cancelar;
            // 
            // CadatroFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 365);
            Controls.Add(tableLayoutPanel1);
            Name = "CadatroFilme";
            Text = "Cadatrar";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            GroupTitulo.ResumeLayout(false);
            GroupTitulo.PerformLayout();
            GroupDuracao.ResumeLayout(false);
            GroupDuracao.PerformLayout();
            GroupAvaliacao.ResumeLayout(false);
            GroupAvaliacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrackBarAvalicao).EndInit();
            GroupGenero.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox GroupTitulo;
        private GroupBox GroupDuracao;
        private GroupBox GroupAvaliacao;
        private GroupBox GroupGenero;
        private ComboBox ComboBoxGenero;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnSalvar;
        private Button BtnCancelar;
        private TextBox TxtTitulo;
        private TextBox TxtDuracao;
        private TrackBar TrackBarAvalicao;
        private Label LabelAvaliacao;
    }
}