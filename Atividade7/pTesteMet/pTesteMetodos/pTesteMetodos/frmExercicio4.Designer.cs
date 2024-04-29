namespace pTesteMetodos
{
    partial class frmExercicio4
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnQtdNumero = new System.Windows.Forms.Button();
            this.btnPrimeroBranco = new System.Windows.Forms.Button();
            this.btnQtdLetra = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtTexto.Location = new System.Drawing.Point(291, 75);
            this.rchtxtTexto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(551, 126);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnQtdNumero
            // 
            this.btnQtdNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQtdNumero.Location = new System.Drawing.Point(95, 337);
            this.btnQtdNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQtdNumero.Name = "btnQtdNumero";
            this.btnQtdNumero.Size = new System.Drawing.Size(250, 120);
            this.btnQtdNumero.TabIndex = 1;
            this.btnQtdNumero.Text = "Quantidade Números";
            this.btnQtdNumero.UseVisualStyleBackColor = true;
            this.btnQtdNumero.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrimeroBranco
            // 
            this.btnPrimeroBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroBranco.Location = new System.Drawing.Point(396, 337);
            this.btnPrimeroBranco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimeroBranco.Name = "btnPrimeroBranco";
            this.btnPrimeroBranco.Size = new System.Drawing.Size(250, 120);
            this.btnPrimeroBranco.TabIndex = 2;
            this.btnPrimeroBranco.Text = "Primeiro caracter branco";
            this.btnPrimeroBranco.UseVisualStyleBackColor = true;
            this.btnPrimeroBranco.Click += new System.EventHandler(this.btnPrimeroBranco_Click);
            // 
            // btnQtdLetra
            // 
            this.btnQtdLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQtdLetra.Location = new System.Drawing.Point(693, 337);
            this.btnQtdLetra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQtdLetra.Name = "btnQtdLetra";
            this.btnQtdLetra.Size = new System.Drawing.Size(250, 120);
            this.btnQtdLetra.TabIndex = 3;
            this.btnQtdLetra.Text = "Quantidade Letras";
            this.btnQtdLetra.UseVisualStyleBackColor = true;
            this.btnQtdLetra.Click += new System.EventHandler(this.btnQtdLetra_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(89, 122);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(82, 31);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "Texto";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnQtdLetra);
            this.Controls.Add(this.btnPrimeroBranco);
            this.Controls.Add(this.btnQtdNumero);
            this.Controls.Add(this.rchtxtTexto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnQtdNumero;
        private System.Windows.Forms.Button btnPrimeroBranco;
        private System.Windows.Forms.Button btnQtdLetra;
        private System.Windows.Forms.Label lblTexto;
    }
}