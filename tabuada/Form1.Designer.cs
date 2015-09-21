namespace tabuada
{
    partial class frmTabu
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.lblInicial = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(82, 260);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(74, 33);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(185, 260);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(74, 33);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbResult
            // 
            this.tbResult.Enabled = false;
            this.tbResult.Location = new System.Drawing.Point(82, 76);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(177, 168);
            this.tbResult.TabIndex = 3;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbValor
            // 
            this.mtbValor.Location = new System.Drawing.Point(268, 12);
            this.mtbValor.Mask = "00000";
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.PromptChar = ' ';
            this.mtbValor.Size = new System.Drawing.Size(61, 22);
            this.mtbValor.TabIndex = 0;
            this.mtbValor.ValidatingType = typeof(int);
            this.mtbValor.Click += new System.EventHandler(this.mtbValor_Click);
            this.mtbValor.Enter += new System.EventHandler(this.mtbValor_Enter);
            this.mtbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbValor_KeyPress);
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Location = new System.Drawing.Point(9, 15);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(250, 17);
            this.lblInicial.TabIndex = 5;
            this.lblInicial.Text = "Digite o número da tabuada desejada:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(84, 56);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 17);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Visible = false;
            // 
            // frmTabu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 309);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInicial);
            this.Controls.Add(this.mtbValor);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Name = "frmTabu";
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.MaskedTextBox mtbValor;
        private System.Windows.Forms.Label lblTitle;
    }
}

