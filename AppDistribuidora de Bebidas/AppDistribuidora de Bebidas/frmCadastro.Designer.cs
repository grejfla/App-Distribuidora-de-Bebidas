namespace AppDistribuidora_de_Bebidas
{
    partial class frmCadastro
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
            lbltitulo = new Label();
            lblEmailusuario = new Label();
            txtNomeUsuario = new TextBox();
            statusStrip1 = new StatusStrip();
            lblNomeUsuario = new Label();
            lblSenhausuario = new Label();
            txtsenhausuario = new TextBox();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(249, 0);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(203, 25);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Cadastrar Usuário";
            // 
            // lblEmailusuario
            // 
            lblEmailusuario.AutoSize = true;
            lblEmailusuario.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailusuario.Location = new Point(-5, 44);
            lblEmailusuario.Name = "lblEmailusuario";
            lblEmailusuario.Size = new Size(0, 19);
            lblEmailusuario.TabIndex = 1;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(-66, 17);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(210, 23);
            txtNomeUsuario.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 470);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(739, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeUsuario.Location = new Point(0, -3);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(127, 19);
            lblNomeUsuario.TabIndex = 6;
            lblNomeUsuario.Text = "Nome usuário:";
            // 
            // lblSenhausuario
            // 
            lblSenhausuario.AutoSize = true;
            lblSenhausuario.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenhausuario.Location = new Point(3, 43);
            lblSenhausuario.Name = "lblSenhausuario";
            lblSenhausuario.Size = new Size(130, 19);
            lblSenhausuario.TabIndex = 7;
            lblSenhausuario.Text = "Senha usuário:";
            // 
            // txtsenhausuario
            // 
            txtsenhausuario.Location = new Point(0, 65);
            txtsenhausuario.Name = "txtsenhausuario";
            txtsenhausuario.Size = new Size(214, 23);
            txtsenhausuario.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(249, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 111);
            dataGridView1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(lbltitulo, 1, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 2);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(739, 470);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblNomeUsuario);
            panel1.Controls.Add(txtNomeUsuario);
            panel1.Controls.Add(txtsenhausuario);
            panel1.Controls.Add(lblEmailusuario);
            panel1.Controls.Add(lblSenhausuario);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(249, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 111);
            panel1.TabIndex = 1;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 492);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            Name = "frmCadastro";
            Text = "frmCadastro";
            Load += frmCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label lblEmailusuario;
        private TextBox txtNomeUsuario;
        private StatusStrip statusStrip1;
        private Label lblNomeUsuario;
        private Label lblSenhausuario;
        private TextBox txtsenhausuario;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}