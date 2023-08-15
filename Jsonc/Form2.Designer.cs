namespace Jsonc
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.tx_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_endereço = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(142, 104);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(100, 20);
            this.tx_nome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone:";
            // 
            // tx_telefone
            // 
            this.tx_telefone.Location = new System.Drawing.Point(500, 109);
            this.tx_telefone.Mask = "(00) 00000-0000";
            this.tx_telefone.Name = "tx_telefone";
            this.tx_telefone.Size = new System.Drawing.Size(100, 20);
            this.tx_telefone.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(128, 166);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(100, 20);
            this.tx_email.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data de Nascimento:";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(518, 324);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 9;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // tx_nascimento
            // 
            this.tx_nascimento.Location = new System.Drawing.Point(489, 163);
            this.tx_nascimento.Mask = "00/00/0000";
            this.tx_nascimento.Name = "tx_nascimento";
            this.tx_nascimento.Size = new System.Drawing.Size(65, 20);
            this.tx_nascimento.TabIndex = 10;
            this.tx_nascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cpf";
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(128, 204);
            this.tx_cpf.Mask = "000-000-000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(100, 20);
            this.tx_cpf.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Endereço";
            // 
            // tx_endereço
            // 
            this.tx_endereço.Location = new System.Drawing.Point(490, 203);
            this.tx_endereço.Name = "tx_endereço";
            this.tx_endereço.Size = new System.Drawing.Size(110, 20);
            this.tx_endereço.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Serializar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_endereço);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_nascimento);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_telefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tx_telefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.MaskedTextBox tx_nascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tx_endereço;
        private System.Windows.Forms.Button button1;
    }
}