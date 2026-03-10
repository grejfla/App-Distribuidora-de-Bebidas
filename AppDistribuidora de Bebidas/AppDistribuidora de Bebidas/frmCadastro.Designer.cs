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
            lblCadastrousuario = new Label();
            lblSenhaCadastro = new Label();
            txtNomeUsuario = new TextBox();
            statusStrip1 = new StatusStrip();
            txtsenha = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblCadastrousuario
            // 
            lblCadastrousuario.AutoSize = true;
            lblCadastrousuario.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCadastrousuario.Location = new Point(398, 88);
            lblCadastrousuario.Name = "lblCadastrousuario";
            lblCadastrousuario.Size = new Size(204, 19);
            lblCadastrousuario.TabIndex = 0;
            lblCadastrousuario.Text = "Escolha o Nome de Usuário";
            // 
            // lblSenhaCadastro
            // 
            lblSenhaCadastro.AutoSize = true;
            lblSenhaCadastro.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenhaCadastro.Location = new Point(422, 163);
            lblSenhaCadastro.Name = "lblSenhaCadastro";
            lblSenhaCadastro.Size = new Size(123, 19);
            lblSenhaCadastro.TabIndex = 1;
            lblSenhaCadastro.Text = "Escolha a Senha";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(398, 118);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(210, 23);
            txtNomeUsuario.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(739, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(425, 199);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(177, 23);
            txtsenha.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(425, 249);
            button1.Name = "button1";
            button1.Size = new Size(177, 32);
            button1.TabIndex = 5;
            button1.Text = "Confirmar Cadastro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 450);
            Controls.Add(button1);
            Controls.Add(txtsenha);
            Controls.Add(statusStrip1);
            Controls.Add(txtNomeUsuario);
            Controls.Add(lblSenhaCadastro);
            Controls.Add(lblCadastrousuario);
            Name = "frmCadastro";
            Text = "frmCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastrousuario;
        private Label lblSenhaCadastro;
        private TextBox txtNomeUsuario;
        private StatusStrip statusStrip1;
        private TextBox txtsenha;
        private Button button1;
    }
}