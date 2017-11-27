namespace CadernoVirtual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.BTNeditarUsuario = new System.Windows.Forms.Button();
            this.BTNexcluirUsuario = new System.Windows.Forms.Button();
            this.BTNsairUsuario = new System.Windows.Forms.Button();
            this.tituloApresentacao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNeditarUsuario
            // 
            this.BTNeditarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.BTNeditarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNeditarUsuario.FlatAppearance.BorderSize = 0;
            this.BTNeditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNeditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.BTNeditarUsuario.ForeColor = System.Drawing.SystemColors.Info;
            this.BTNeditarUsuario.Location = new System.Drawing.Point(12, 122);
            this.BTNeditarUsuario.Name = "BTNeditarUsuario";
            this.BTNeditarUsuario.Size = new System.Drawing.Size(195, 44);
            this.BTNeditarUsuario.TabIndex = 5;
            this.BTNeditarUsuario.Text = "EDITAR";
            this.BTNeditarUsuario.UseVisualStyleBackColor = false;
            // 
            // BTNexcluirUsuario
            // 
            this.BTNexcluirUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.BTNexcluirUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNexcluirUsuario.FlatAppearance.BorderSize = 0;
            this.BTNexcluirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNexcluirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.BTNexcluirUsuario.ForeColor = System.Drawing.SystemColors.Info;
            this.BTNexcluirUsuario.Location = new System.Drawing.Point(12, 172);
            this.BTNexcluirUsuario.Name = "BTNexcluirUsuario";
            this.BTNexcluirUsuario.Size = new System.Drawing.Size(195, 44);
            this.BTNexcluirUsuario.TabIndex = 6;
            this.BTNexcluirUsuario.Text = "EXCLUIR";
            this.BTNexcluirUsuario.UseVisualStyleBackColor = false;
            // 
            // BTNsairUsuario
            // 
            this.BTNsairUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.BTNsairUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNsairUsuario.FlatAppearance.BorderSize = 0;
            this.BTNsairUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNsairUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.BTNsairUsuario.ForeColor = System.Drawing.SystemColors.Info;
            this.BTNsairUsuario.Location = new System.Drawing.Point(12, 222);
            this.BTNsairUsuario.Name = "BTNsairUsuario";
            this.BTNsairUsuario.Size = new System.Drawing.Size(195, 44);
            this.BTNsairUsuario.TabIndex = 7;
            this.BTNsairUsuario.Text = "SAIR";
            this.BTNsairUsuario.UseVisualStyleBackColor = false;
            this.BTNsairUsuario.Click += new System.EventHandler(this.BTNsairusuario_Click);
            // 
            // tituloApresentacao
            // 
            this.tituloApresentacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tituloApresentacao.AutoSize = true;
            this.tituloApresentacao.BackColor = System.Drawing.Color.Transparent;
            this.tituloApresentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloApresentacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.tituloApresentacao.Location = new System.Drawing.Point(12, 34);
            this.tituloApresentacao.Name = "tituloApresentacao";
            this.tituloApresentacao.Size = new System.Drawing.Size(282, 55);
            this.tituloApresentacao.TabIndex = 8;
            this.tituloApresentacao.Text = "Bem Vindo!";
            this.tituloApresentacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(22, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 316);
            this.panel1.TabIndex = 10;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(561, 39);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(188, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.txtPesquisa);
            this.panel2.Location = new System.Drawing.Point(408, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 100);
            this.panel2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1169, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tituloApresentacao);
            this.Controls.Add(this.BTNsairUsuario);
            this.Controls.Add(this.BTNexcluirUsuario);
            this.Controls.Add(this.BTNeditarUsuario);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNeditarUsuario;
        private System.Windows.Forms.Button BTNexcluirUsuario;
        private System.Windows.Forms.Button BTNsairUsuario;
        private System.Windows.Forms.Label tituloApresentacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}