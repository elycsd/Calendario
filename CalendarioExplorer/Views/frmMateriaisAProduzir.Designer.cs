namespace CalendarioExplorer.Views
{
    partial class frmMateriaisAProduzir
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
            this.lstArquivosMateriais = new System.Windows.Forms.ListView();
            this.lstPastasMateriais = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstArquivosMateriais
            // 
            this.lstArquivosMateriais.Location = new System.Drawing.Point(403, 12);
            this.lstArquivosMateriais.Name = "lstArquivosMateriais";
            this.lstArquivosMateriais.Size = new System.Drawing.Size(385, 476);
            this.lstArquivosMateriais.TabIndex = 3;
            this.lstArquivosMateriais.UseCompatibleStateImageBehavior = false;
            // 
            // lstPastasMateriais
            // 
            this.lstPastasMateriais.Location = new System.Drawing.Point(12, 12);
            this.lstPastasMateriais.Name = "lstPastasMateriais";
            this.lstPastasMateriais.Size = new System.Drawing.Size(385, 476);
            this.lstPastasMateriais.TabIndex = 2;
            this.lstPastasMateriais.UseCompatibleStateImageBehavior = false;
            // 
            // frmMateriaisAProduzir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lstArquivosMateriais);
            this.Controls.Add(this.lstPastasMateriais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMateriaisAProduzir";
            this.Text = "frmMateriaisAProduzir";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstArquivosMateriais;
        private System.Windows.Forms.ListView lstPastasMateriais;
    }
}