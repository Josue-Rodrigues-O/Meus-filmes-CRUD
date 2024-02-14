namespace MeusFilmes.InterfaceUsuario
{
    partial class ListaFilmes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            DataGridFilmes = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnAdicionar = new Button();
            BtnEditar = new Button();
            BtnRemover = new Button();
            filmeBindingSource = new BindingSource(components);
            Id = new DataGridViewTextBoxColumn();
            tituloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            generoFilmeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            duracaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            avaliacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridFilmes).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(DataGridFilmes, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.26291F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7370892F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // DataGridFilmes
            // 
            DataGridFilmes.AllowUserToAddRows = false;
            DataGridFilmes.AllowUserToResizeColumns = false;
            DataGridFilmes.AllowUserToResizeRows = false;
            DataGridFilmes.AutoGenerateColumns = false;
            DataGridFilmes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridFilmes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridFilmes.Columns.AddRange(new DataGridViewColumn[] { Id, tituloDataGridViewTextBoxColumn, generoFilmeDataGridViewTextBoxColumn, duracaoDataGridViewTextBoxColumn, avaliacaoDataGridViewTextBoxColumn });
            DataGridFilmes.DataSource = filmeBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridFilmes.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridFilmes.Dock = DockStyle.Fill;
            DataGridFilmes.Location = new Point(3, 3);
            DataGridFilmes.MultiSelect = false;
            DataGridFilmes.Name = "DataGridFilmes";
            DataGridFilmes.ReadOnly = true;
            DataGridFilmes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridFilmes.Size = new Size(770, 370);
            DataGridFilmes.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 369F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(BtnAdicionar, 1, 0);
            tableLayoutPanel2.Controls.Add(BtnEditar, 2, 0);
            tableLayoutPanel2.Controls.Add(BtnRemover, 3, 0);
            tableLayoutPanel2.Location = new Point(3, 379);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(770, 44);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnAdicionar.Location = new Point(372, 3);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(127, 38);
            BtnAdicionar.TabIndex = 0;
            BtnAdicionar.Text = "Adicionar";
            BtnAdicionar.UseVisualStyleBackColor = true;
            BtnAdicionar.Click += Ao_Clicar_Em_Adicionar;
            // 
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnEditar.Location = new Point(505, 3);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(127, 38);
            BtnEditar.TabIndex = 1;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += Ao_Clicar_Em_Editar;
            // 
            // BtnRemover
            // 
            BtnRemover.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnRemover.Location = new Point(638, 3);
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(129, 38);
            BtnRemover.TabIndex = 2;
            BtnRemover.Text = "Remover";
            BtnRemover.UseVisualStyleBackColor = true;
            BtnRemover.Click += Ao_Clicar_Em_Remover;
            // 
            // filmeBindingSource
            // 
            filmeBindingSource.DataSource = typeof(Dominio.Filme);
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            tituloDataGridViewTextBoxColumn.HeaderText = "Título";
            tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generoFilmeDataGridViewTextBoxColumn
            // 
            generoFilmeDataGridViewTextBoxColumn.DataPropertyName = "GeneroFilme";
            generoFilmeDataGridViewTextBoxColumn.HeaderText = "Genero do filme";
            generoFilmeDataGridViewTextBoxColumn.Name = "generoFilmeDataGridViewTextBoxColumn";
            generoFilmeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duracaoDataGridViewTextBoxColumn
            // 
            duracaoDataGridViewTextBoxColumn.DataPropertyName = "Duracao";
            duracaoDataGridViewTextBoxColumn.HeaderText = "Duração";
            duracaoDataGridViewTextBoxColumn.Name = "duracaoDataGridViewTextBoxColumn";
            duracaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avaliacaoDataGridViewTextBoxColumn
            // 
            avaliacaoDataGridViewTextBoxColumn.DataPropertyName = "Avaliacao";
            avaliacaoDataGridViewTextBoxColumn.HeaderText = "Avaliação";
            avaliacaoDataGridViewTextBoxColumn.Name = "avaliacaoDataGridViewTextBoxColumn";
            avaliacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListaFilmes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "ListaFilmes";
            Text = "Lista de filmes";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridFilmes).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView DataGridFilmes;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnAdicionar;
        private Button BtnEditar;
        private Button BtnRemover;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn generoFilmeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duracaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn avaliacaoDataGridViewTextBoxColumn;
        private BindingSource filmeBindingSource;
    }
}
