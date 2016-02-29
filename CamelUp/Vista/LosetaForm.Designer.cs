namespace CamelUp
{
    partial class LosetaForm
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
            this.lbError = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.trackBar1Casilla = new System.Windows.Forms.TrackBar();
            this.lbCasilla = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1Casilla)).BeginInit();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.pPrincipal.Controls.Add(this.lbError);
            this.pPrincipal.Controls.Add(this.btnCancelar);
            this.pPrincipal.Controls.Add(this.trackBar1Casilla);
            this.pPrincipal.Controls.Add(this.lbCasilla);
            this.pPrincipal.Controls.Add(this.lbInfo);
            this.pPrincipal.Controls.Add(this.btnAceptar);
            this.pPrincipal.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(467, 242);
            this.pPrincipal.TabIndex = 3;
            // 
            // lbError
            // 
            this.lbError.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.Location = new System.Drawing.Point(71, 118);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(321, 33);
            this.lbError.TabIndex = 6;
            this.lbError.Text = "label1";
            this.lbError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(247, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(199, 47);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // trackBar1Casilla
            // 
            this.trackBar1Casilla.Location = new System.Drawing.Point(112, 85);
            this.trackBar1Casilla.Maximum = 16;
            this.trackBar1Casilla.Minimum = 2;
            this.trackBar1Casilla.Name = "trackBar1Casilla";
            this.trackBar1Casilla.Size = new System.Drawing.Size(334, 45);
            this.trackBar1Casilla.TabIndex = 4;
            this.trackBar1Casilla.Value = 2;
            // 
            // lbCasilla
            // 
            this.lbCasilla.AutoSize = true;
            this.lbCasilla.Location = new System.Drawing.Point(24, 85);
            this.lbCasilla.Name = "lbCasilla";
            this.lbCasilla.Size = new System.Drawing.Size(82, 33);
            this.lbCasilla.TabIndex = 3;
            this.lbCasilla.Text = "label1";
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.Color.PeachPuff;
            this.lbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInfo.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(17, 17);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(429, 45);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "Colocar la loseta en la posición:";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(17, 175);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(199, 47);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // LosetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(487, 262);
            this.ControlBox = false;
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LosetaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LosetaForm";
            this.Load += new System.EventHandler(this.LosetaForm_Load);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1Casilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TrackBar trackBar1Casilla;
        private System.Windows.Forms.Label lbCasilla;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbError;
    }
}