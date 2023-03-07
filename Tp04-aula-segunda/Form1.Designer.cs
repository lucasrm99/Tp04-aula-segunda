namespace Calculo_Pagamento
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
            this.lblCPF = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.valorhora = new System.Windows.Forms.Label();
            this.horastrab = new System.Windows.Forms.Label();
            this.salarioo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCPF.Location = new System.Drawing.Point(83, 34);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 21);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nome.Location = new System.Drawing.Point(67, 92);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(53, 21);
            this.nome.TabIndex = 1;
            this.nome.Text = "Nome";
            // 
            // valorhora
            // 
            this.valorhora.AutoSize = true;
            this.valorhora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valorhora.Location = new System.Drawing.Point(36, 135);
            this.valorhora.Name = "valorhora";
            this.valorhora.Size = new System.Drawing.Size(84, 21);
            this.valorhora.TabIndex = 2;
            this.valorhora.Text = "Valor Hora";
            // 
            // horastrab
            // 
            this.horastrab.AutoSize = true;
            this.horastrab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horastrab.Location = new System.Drawing.Point(12, 177);
            this.horastrab.Name = "horastrab";
            this.horastrab.Size = new System.Drawing.Size(138, 21);
            this.horastrab.TabIndex = 3;
            this.horastrab.Text = "Horas Trabalhadas";
            // 
            // salarioo
            // 
            this.salarioo.AutoSize = true;
            this.salarioo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salarioo.Location = new System.Drawing.Point(83, 215);
            this.salarioo.Name = "salarioo";
            this.salarioo.Size = new System.Drawing.Size(58, 21);
            this.salarioo.TabIndex = 4;
            this.salarioo.Text = "Salário";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(151, 94);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(146, 23);
            this.txtNome.TabIndex = 6;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(151, 137);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(146, 23);
            this.txtValor.TabIndex = 7;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(165, 175);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(146, 23);
            this.txtHoras.TabIndex = 8;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(165, 217);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ReadOnly = true;
            this.txtSalario.Size = new System.Drawing.Size(146, 23);
            this.txtSalario.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(634, 353);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 56);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(151, 36);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(146, 23);
            this.txtCpf.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.salarioo);
            this.Controls.Add(this.horastrab);
            this.Controls.Add(this.valorhora);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.lblCPF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCPF;
        private Label nome;
        private Label valorhora;
        private Label horastrab;
        private Label salarioo;
        private TextBox txtNome;
        private TextBox txtValor;
        private TextBox txtHoras;
        private TextBox txtSalario;
        private Button btnCalcular;
        private MaskedTextBox txtCpf;
    }
}