namespace SysComercio
{
    partial class FrmCategoria
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            txtBuscar = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            chkExcluir = new CheckBox();
            dataLista = new DataGridView();
            Excluir = new DataGridViewCheckBoxColumn();
            lblTotal = new Label();
            btnImprimir = new Button();
            btnExcluir = new Button();
            btnBuscar = new Button();
            lblBuscar = new Label();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnNovo = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            txtDescricao = new TextBox();
            label4 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtIdCategoria = new TextBox();
            label2 = new Label();
            errorIcone = new ErrorProvider(components);
            ttMensagem = new ToolTip(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) dataLista).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) errorIcone).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(761, 32);
            label1.TabIndex = 0;
            label1.Text = "Categorias";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(89, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(174, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.Text = " ";
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 65);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 340);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(chkExcluir);
            tabPage1.Controls.Add(dataLista);
            tabPage1.Controls.Add(lblTotal);
            tabPage1.Controls.Add(btnImprimir);
            tabPage1.Controls.Add(btnExcluir);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(lblBuscar);
            tabPage1.Controls.Add(txtBuscar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 312);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkExcluir
            // 
            chkExcluir.AutoSize = true;
            chkExcluir.Location = new Point(8, 46);
            chkExcluir.Name = "chkExcluir";
            chkExcluir.Size = new Size(61, 19);
            chkExcluir.TabIndex = 7;
            chkExcluir.Text = "Excluir";
            chkExcluir.UseVisualStyleBackColor = true;
            chkExcluir.CheckedChanged += chkExcluir_CheckedChanged;
            // 
            // dataLista
            // 
            dataLista.AllowUserToAddRows = false;
            dataLista.AllowUserToDeleteRows = false;
            dataLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLista.Columns.AddRange(new DataGridViewColumn [] { Excluir });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataLista.DefaultCellStyle = dataGridViewCellStyle1;
            dataLista.Location = new Point(6, 68);
            dataLista.MultiSelect = false;
            dataLista.Name = "dataLista";
            dataLista.ReadOnly = true;
            dataLista.RowTemplate.Height = 25;
            dataLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataLista.Size = new Size(751, 238);
            dataLista.TabIndex = 6;
            dataLista.CellContentClick += dataLista_CellContentClick;
            dataLista.DoubleClick += dataLista_DoubleClick;
            // 
            // Excluir
            // 
            Excluir.HeaderText = "Excluir";
            Excluir.Name = "Excluir";
            Excluir.ReadOnly = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(575, 25);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "label2";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(442, 16);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(361, 16);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(280, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(6, 25);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(43, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Nome:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 312);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Configurações";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnNovo);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIdCategoria);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(725, 201);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categorias";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(254, 161);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(11, 161);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 8;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(173, 161);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(92, 161);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(92, 78);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            txtDescricao.Size = new Size(243, 77);
            txtDescricao.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 81);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 4;
            label4.Text = "Descrição:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(92, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(243, 23);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 52);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(235, 18);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(100, 23);
            txtIdCategoria.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 26);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 0;
            label2.Text = "Código:";
            // 
            // errorIcone
            // 
            errorIcone.ContainerControl = this;
            // 
            // ttMensagem
            // 
            ttMensagem.IsBalloon = true;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 417);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "FrmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Categoria";
            Load += FrmCategoria_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) dataLista).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) errorIcone).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtBuscar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private CheckBox chkExcluir;
        private DataGridView dataLista;
        private Label lblTotal;
        private Button btnImprimir;
        private Button btnExcluir;
        private Button btnBuscar;
        private Label lblBuscar;
        private TabPage tabPage2;
        private DataGridViewCheckBoxColumn Excluir;
        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private TextBox txtDescricao;
        private Label label4;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtIdCategoria;
        private Label label2;
        private ErrorProvider errorIcone;
        private ToolTip ttMensagem;
    }
}