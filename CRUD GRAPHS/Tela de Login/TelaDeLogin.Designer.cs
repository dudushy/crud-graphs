﻿namespace CRUD_GRAPHS {
    partial class TelaDeLogin {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeLogin));
            this.botaoAcesso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.botaoFecharAcesso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoAcesso
            // 
            this.botaoAcesso.BackColor = System.Drawing.Color.Transparent;
            this.botaoAcesso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAcesso.BackgroundImage")));
            this.botaoAcesso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoAcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAcesso.Location = new System.Drawing.Point(36, 90);
            this.botaoAcesso.Name = "botaoAcesso";
            this.botaoAcesso.Size = new System.Drawing.Size(216, 210);
            this.botaoAcesso.TabIndex = 0;
            this.botaoAcesso.UseVisualStyleBackColor = false;
            this.botaoAcesso.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(383, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(298, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(309, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(383, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(165, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // botaoFecharAcesso
            // 
            this.botaoFecharAcesso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoFecharAcesso.BackgroundImage")));
            this.botaoFecharAcesso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoFecharAcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoFecharAcesso.Location = new System.Drawing.Point(411, 265);
            this.botaoFecharAcesso.Name = "botaoFecharAcesso";
            this.botaoFecharAcesso.Size = new System.Drawing.Size(74, 73);
            this.botaoFecharAcesso.TabIndex = 4;
            this.botaoFecharAcesso.UseVisualStyleBackColor = true;
            this.botaoFecharAcesso.Click += new System.EventHandler(this.botaoFecharAcesso_Click);
            // 
            // TelaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(823, 435);
            this.Controls.Add(this.botaoFecharAcesso);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoAcesso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaDeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button botaoAcesso;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button botaoFecharAcesso;
    }
}