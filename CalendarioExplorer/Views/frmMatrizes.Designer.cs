namespace CalendarioExplorer.Views
{
    partial class frmMatrizes
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
            this.lstPastasMatrizes = new System.Windows.Forms.ListView();
            this.lstArquivosMatrizes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstPastasMatrizes
            // 
            this.lstPastasMatrizes.Location = new System.Drawing.Point(12, 12);
            this.lstPastasMatrizes.Name = "lstPastasMatrizes";
            this.lstPastasMatrizes.Size = new System.Drawing.Size(385, 476);
            this.lstPastasMatrizes.TabIndex = 0;
            this.lstPastasMatrizes.UseCompatibleStateImageBehavior = false;
            // 
            // lstArquivosMatrizes
            // 
            this.lstArquivosMatrizes.Location = new System.Drawing.Point(403, 12);
            this.lstArquivosMatrizes.Name = "lstArquivosMatrizes";
            this.lstArquivosMatrizes.Size = new System.Drawing.Size(385, 476);
            this.lstArquivosMatrizes.TabIndex = 1;
            this.lstArquivosMatrizes.UseCompatibleStateImageBehavior = false;
            // 
            // frmMatrizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lstArquivosMatrizes);
            this.Controls.Add(this.lstPastasMatrizes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 1);
            this.Name = "frmMatrizes";
            this.Text = "Matrizes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstPastasMatrizes;
        private System.Windows.Forms.ListView lstArquivosMatrizes;
    }
}