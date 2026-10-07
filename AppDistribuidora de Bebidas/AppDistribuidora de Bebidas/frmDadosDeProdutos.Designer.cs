namespace AppDistribuidora_de_Bebidas
{
    partial class frmDadosDeProdutos
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
            lbltitulo = new Label();
            imageList1 = new ImageList(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            lblcodigodoproduto = new Label();
            lblquantidadedeproduto = new Label();
            lblfornecedor = new Label();
            btnsalvar = new Button();
            btnatualizar = new Button();
            btnapagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(111, 36);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(181, 23);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Dados do Produto";
            lbltitulo.Click += lbltitulo_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(111, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 23);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(524, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(264, 435);
            dataGridView1.TabIndex = 4;
            // 
            // lblcodigodoproduto
            // 
            lblcodigodoproduto.AutoSize = true;
            lblcodigodoproduto.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcodigodoproduto.Location = new Point(111, 85);
            lblcodigodoproduto.Name = "lblcodigodoproduto";
            lblcodigodoproduto.Size = new Size(149, 19);
            lblcodigodoproduto.TabIndex = 5;
            lblcodigodoproduto.Text = "Código do produto:";
            lblcodigodoproduto.Click += label1_Click;
            // 
            // lblquantidadedeproduto
            // 
            lblquantidadedeproduto.AutoSize = true;
            lblquantidadedeproduto.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblquantidadedeproduto.Location = new Point(111, 157);
            lblquantidadedeproduto.Name = "lblquantidadedeproduto";
            lblquantidadedeproduto.Size = new Size(179, 19);
            lblquantidadedeproduto.TabIndex = 6;
            lblquantidadedeproduto.Text = "Quantidade de produto:";
            lblquantidadedeproduto.Click += lblquantidadedeproduto_Click;
            // 
            // lblfornecedor
            // 
            lblfornecedor.AutoSize = true;
            lblfornecedor.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfornecedor.Location = new Point(111, 231);
            lblfornecedor.Name = "lblfornecedor";
            lblfornecedor.Size = new Size(94, 19);
            lblfornecedor.TabIndex = 7;
            lblfornecedor.Text = "Fornecedor:";
            // 
            // btnsalvar
            // 
            btnsalvar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalvar.Location = new Point(53, 322);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(75, 39);
            btnsalvar.TabIndex = 8;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = true;
            // 
            // btnatualizar
            // 
            btnatualizar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnatualizar.Location = new Point(150, 322);
            btnatualizar.Name = "btnatualizar";
            btnatualizar.Size = new Size(108, 39);
            btnatualizar.TabIndex = 9;
            btnatualizar.Text = "Atualizar";
            btnatualizar.UseVisualStyleBackColor = true;
            // 
            // btnapagar
            // 
            btnapagar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnapagar.Location = new Point(264, 322);
            btnapagar.Name = "btnapagar";
            btnapagar.Size = new Size(101, 39);
            btnapagar.TabIndex = 10;
            btnapagar.Text = "Apagar";
            btnapagar.UseVisualStyleBackColor = true;
            btnapagar.Click += button3_Click;
            // 
            // frmDadosDeProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnapagar);
            Controls.Add(btnatualizar);
            Controls.Add(btnsalvar);
            Controls.Add(lblfornecedor);
            Controls.Add(lblquantidadedeproduto);
            Controls.Add(lblcodigodoproduto);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbltitulo);
            Name = "frmDadosDeProdutos";
            Text = "frmDadosDeProdutos";
            Load += frmDadosDeProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private ImageList imageList1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Label lblcodigodoproduto;
        private Label lblquantidadedeproduto;
        private Label lblfornecedor;
        private Button btnsalvar;
        private Button btnatualizar;
        private Button btnapagar;
    }
}