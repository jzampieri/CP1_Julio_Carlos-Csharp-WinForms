namespace CP1_Julio_Carlos_Csharp_WinForms
{
    partial class Form1
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
            lblTitulo = new Label();
            cmbProdutos = new ComboBox();
            label1 = new Label();
            txtQuantidade = new TextBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnVisualizar = new Button();
            btnFinalizar = new Button();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(261, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(281, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Lanchonete Virtual";
            lblTitulo.Click += label1_Click_1;
            // 
            // cmbProdutos
            // 
            cmbProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Items.AddRange(new object[] { "X-Burguer", "Refrigerante", "Sorvete" });
            cmbProdutos.Location = new Point(285, 67);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(223, 23);
            cmbProdutos.TabIndex = 1;
            cmbProdutos.SelectedIndexChanged += cmbProdutos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 139);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 2;
            label1.Text = "Quantidade";
            label1.Click += label1_Click_2;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(394, 136);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.TextChanged += textBox1_TextChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(232, 238);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(313, 238);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Location = new Point(394, 238);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(113, 23);
            btnVisualizar.TabIndex = 6;
            btnVisualizar.Text = "Visualizar Pedido";
            btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(513, 238);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 23);
            btnFinalizar.TabIndex = 7;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += button4_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(339, 369);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(110, 21);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total: R$ 0,00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(btnFinalizar);
            Controls.Add(btnVisualizar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(txtQuantidade);
            Controls.Add(label1);
            Controls.Add(cmbProdutos);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox cmbProdutos;
        private Label label1;
        private TextBox txtQuantidade;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnVisualizar;
        private Button btnFinalizar;
        private Label lblTotal;
    }
}
