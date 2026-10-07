namespace AppDistribuidora_de_Bebidas
{
    partial class frmCadastroDeProdutos
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
            dataGridView1 = new DataGridView();
            lblTitulo = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lblnomedoproduto = new Label();
            lblcaracteristicadoproduto = new Label();
            lblcodigodoproduto = new Label();
            btnSalvar = new Button();
            btnatualizar = new Button();
            btnapagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(548, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 426);
            dataGridView1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(181, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(167, 19);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cadastrar Produtos";
            lblTitulo.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(181, 227);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 23);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // lblnomedoproduto
            // 
            lblnomedoproduto.AutoSize = true;
            lblnomedoproduto.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnomedoproduto.Location = new Point(187, 78);
            lblnomedoproduto.Name = "lblnomedoproduto";
            lblnomedoproduto.Size = new Size(143, 19);
            lblnomedoproduto.TabIndex = 5;
            lblnomedoproduto.Text = "Nome Do Produto:";
            // 
            // lblcaracteristicadoproduto
            // 
            lblcaracteristicadoproduto.AutoSize = true;
            lblcaracteristicadoproduto.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcaracteristicadoproduto.Location = new Point(181, 141);
            lblcaracteristicadoproduto.Name = "lblcaracteristicadoproduto";
            lblcaracteristicadoproduto.Size = new Size(199, 19);
            lblcaracteristicadoproduto.TabIndex = 6;
            lblcaracteristicadoproduto.Text = "Caracteristica do Produtos:";
            // 
            // lblcodigodoproduto
            // 
            lblcodigodoproduto.AutoSize = true;
            lblcodigodoproduto.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcodigodoproduto.Location = new Point(195, 206);
            lblcodigodoproduto.Name = "lblcodigodoproduto";
            lblcodigodoproduto.Size = new Size(151, 19);
            lblcodigodoproduto.TabIndex = 7;
            lblcodigodoproduto.Text = "Código Do Produto:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(197, 284);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // btnatualizar
            // 
            btnatualizar.Location = new Point(305, 284);
            btnatualizar.Name = "btnatualizar";
            btnatualizar.Size = new Size(75, 23);
            btnatualizar.TabIndex = 9;
            btnatualizar.Text = "Atualizar";
            btnatualizar.UseVisualStyleBackColor = true;
            // 
            // btnapagar
            // 
            btnapagar.Location = new Point(386, 284);
            btnapagar.Name = "btnapagar";
            btnapagar.Size = new Size(75, 23);
            btnapagar.TabIndex = 10;
            btnapagar.Text = "Apagar";
            btnapagar.UseVisualStyleBackColor = true;
            // 
            // frmCadastroDeProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnapagar);
            Controls.Add(btnatualizar);
            Controls.Add(btnSalvar);
            Controls.Add(lblcodigodoproduto);
            Controls.Add(lblcaracteristicadoproduto);
            Controls.Add(lblnomedoproduto);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblTitulo);
            Controls.Add(dataGridView1);
            Name = "frmCadastroDeProdutos";
            Text = "frmCadastroDeProdutos";
            Load += frmCadastroDeProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblTitulo;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lblnomedoproduto;
        private Label lblcaracteristicadoproduto;
        private Label lblcodigodoproduto;
        private Button btnSalvar;
        private Button btnatualizar;
        private Button btnapagar;
    }
}