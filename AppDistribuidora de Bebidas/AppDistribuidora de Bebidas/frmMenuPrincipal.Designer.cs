namespace AppDistribuidora_de_Bebidas
{
    partial class frmMenuPrincipal
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
            lblTitulo = new Label();
            btnCadastrarProduto = new Button();
            btnDadosdoProduto = new Button();
            btnTarefadoProduto = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(312, 77);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(166, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Menu Principal";
            // 
            // btnCadastrarProduto
            // 
            btnCadastrarProduto.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarProduto.Location = new Point(312, 162);
            btnCadastrarProduto.Name = "btnCadastrarProduto";
            btnCadastrarProduto.Size = new Size(186, 27);
            btnCadastrarProduto.TabIndex = 1;
            btnCadastrarProduto.Text = "Cadastrar Produto";
            btnCadastrarProduto.UseVisualStyleBackColor = true;
            btnCadastrarProduto.Click += btnCadastrarProduto_Click;
            // 
            // btnDadosdoProduto
            // 
            btnDadosdoProduto.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDadosdoProduto.Location = new Point(312, 226);
            btnDadosdoProduto.Name = "btnDadosdoProduto";
            btnDadosdoProduto.Size = new Size(194, 27);
            btnDadosdoProduto.TabIndex = 2;
            btnDadosdoProduto.Text = "Dados do Produto";
            btnDadosdoProduto.UseVisualStyleBackColor = true;
            btnDadosdoProduto.Click += btnDadosdoProduto_Click;
            // 
            // btnTarefadoProduto
            // 
            btnTarefadoProduto.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTarefadoProduto.Location = new Point(312, 282);
            btnTarefadoProduto.Name = "btnTarefadoProduto";
            btnTarefadoProduto.Size = new Size(210, 29);
            btnTarefadoProduto.TabIndex = 3;
            btnTarefadoProduto.Text = "Tarefa do Produto";
            btnTarefadoProduto.UseVisualStyleBackColor = true;
            btnTarefadoProduto.Click += btnTarefadoProduto_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTarefadoProduto);
            Controls.Add(btnDadosdoProduto);
            Controls.Add(btnCadastrarProduto);
            Controls.Add(lblTitulo);
            Name = "frmMenuPrincipal";
            Text = "frmMenuPrincipal";
            FormClosed += frmMenuPrincipal_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnCadastrarProduto;
        private Button btnDadosdoProduto;
        private Button btnTarefadoProduto;
    }
}