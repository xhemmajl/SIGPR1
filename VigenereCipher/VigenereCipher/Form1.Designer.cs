namespace VigenereCipher
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.btnEnkripto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCelesi = new System.Windows.Forms.TextBox();
            this.txtPlaintexti = new System.Windows.Forms.TextBox();
            this.lblrezultati = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(90, -30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 30);
            this.label3.TabIndex = 25;
            this.label3.Text = "Enkriptimi Dhe Dekriptimi Sipas Vigenere";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDekripto
            // 
            this.btnDekripto.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDekripto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDekripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDekripto.ForeColor = System.Drawing.Color.Lime;
            this.btnDekripto.Location = new System.Drawing.Point(136, 439);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(103, 41);
            this.btnDekripto.TabIndex = 24;
            this.btnDekripto.Text = "Dekripto";
            this.btnDekripto.UseVisualStyleBackColor = false;
            // 
            // btnEnkripto
            // 
            this.btnEnkripto.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEnkripto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEnkripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnkripto.ForeColor = System.Drawing.Color.Lime;
            this.btnEnkripto.Location = new System.Drawing.Point(12, 439);
            this.btnEnkripto.Name = "btnEnkripto";
            this.btnEnkripto.Size = new System.Drawing.Size(103, 41);
            this.btnEnkripto.TabIndex = 23;
            this.btnEnkripto.Text = "Enkripto";
            this.btnEnkripto.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "Rezultati            : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Plaintext            : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Çelësi                : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCelesi
            // 
            this.txtCelesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelesi.Location = new System.Drawing.Point(159, 157);
            this.txtCelesi.Multiline = true;
            this.txtCelesi.Name = "txtCelesi";
            this.txtCelesi.Size = new System.Drawing.Size(474, 32);
            this.txtCelesi.TabIndex = 19;
            // 
            // txtPlaintexti
            // 
            this.txtPlaintexti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaintexti.Location = new System.Drawing.Point(159, 96);
            this.txtPlaintexti.Multiline = true;
            this.txtPlaintexti.Name = "txtPlaintexti";
            this.txtPlaintexti.Size = new System.Drawing.Size(474, 32);
            this.txtPlaintexti.TabIndex = 18;
            // 
            // lblrezultati
            // 
            this.lblrezultati.BackColor = System.Drawing.Color.Black;
            this.lblrezultati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrezultati.ForeColor = System.Drawing.Color.Lime;
            this.lblrezultati.Location = new System.Drawing.Point(12, 276);
            this.lblrezultati.Name = "lblrezultati";
            this.lblrezultati.Size = new System.Drawing.Size(621, 139);
            this.lblrezultati.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(415, 30);
            this.label5.TabIndex = 27;
            this.label5.Text = "Enkriptimi Dhe Dekriptimi Sipas Vigenere";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 484);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblrezultati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.btnEnkripto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCelesi);
            this.Controls.Add(this.txtPlaintexti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.Button btnEnkripto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCelesi;
        private System.Windows.Forms.TextBox txtPlaintexti;
        private System.Windows.Forms.Label lblrezultati;
        private System.Windows.Forms.Label label5;
    }
}

