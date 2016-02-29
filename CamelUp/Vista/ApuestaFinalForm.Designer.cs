namespace CamelUp
{
    partial class ApuestaFinalForm
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
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lbColor = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPerdedor = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnGanador = new System.Windows.Forms.Button();
            this.pPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.pPrincipal.Controls.Add(this.btnVolver);
            this.pPrincipal.Controls.Add(this.lbColor);
            this.pPrincipal.Controls.Add(this.listBox1);
            this.pPrincipal.Controls.Add(this.btnPerdedor);
            this.pPrincipal.Controls.Add(this.lbInfo);
            this.pPrincipal.Controls.Add(this.btnGanador);
            this.pPrincipal.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(366, 273);
            this.pPrincipal.TabIndex = 3;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(197, 222);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(154, 36);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lbColor
            // 
            this.lbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbColor.Location = new System.Drawing.Point(18, 222);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(168, 36);
            this.lbColor.TabIndex = 6;
            this.lbColor.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 33;
            this.listBox1.Location = new System.Drawing.Point(18, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 136);
            this.listBox1.TabIndex = 5;
            // 
            // btnPerdedor
            // 
            this.btnPerdedor.Location = new System.Drawing.Point(197, 144);
            this.btnPerdedor.Name = "btnPerdedor";
            this.btnPerdedor.Size = new System.Drawing.Size(154, 63);
            this.btnPerdedor.TabIndex = 4;
            this.btnPerdedor.Text = "Perdedor";
            this.btnPerdedor.UseVisualStyleBackColor = true;
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.Color.PeachPuff;
            this.lbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInfo.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(18, 17);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(333, 36);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "Apuesta para el final de la partida";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGanador
            // 
            this.btnGanador.Location = new System.Drawing.Point(197, 71);
            this.btnGanador.Name = "btnGanador";
            this.btnGanador.Size = new System.Drawing.Size(154, 63);
            this.btnGanador.TabIndex = 0;
            this.btnGanador.Text = "Ganador";
            this.btnGanador.UseVisualStyleBackColor = true;
            // 
            // ApuestaFinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(383, 293);
            this.ControlBox = false;
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApuestaFinalForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ApuestaFinalForm";
            this.Load += new System.EventHandler(this.ApuestaFinalForm_Load);
            this.pPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Button btnPerdedor;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnGanador;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnVolver;
    }
}