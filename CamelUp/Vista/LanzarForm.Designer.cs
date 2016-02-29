namespace CamelUp
{
    partial class LanzarForm
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.lbDado = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.pPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(18, 158);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(333, 47);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.pPrincipal.Controls.Add(this.lbDado);
            this.pPrincipal.Controls.Add(this.lbInfo);
            this.pPrincipal.Controls.Add(this.btnAceptar);
            this.pPrincipal.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(368, 223);
            this.pPrincipal.TabIndex = 2;
            // 
            // lbDado
            // 
            this.lbDado.AutoSize = true;
            this.lbDado.Location = new System.Drawing.Point(151, 31);
            this.lbDado.Name = "lbDado";
            this.lbDado.Size = new System.Drawing.Size(82, 33);
            this.lbDado.TabIndex = 3;
            this.lbDado.Text = "label1";
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.Color.PeachPuff;
            this.lbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInfo.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(18, 93);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(333, 62);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "label1";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LanzarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(388, 243);
            this.ControlBox = false;
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LanzarForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LanzarForm";
            this.Load += new System.EventHandler(this.LanzarForm_Load);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbDado;
    }
}