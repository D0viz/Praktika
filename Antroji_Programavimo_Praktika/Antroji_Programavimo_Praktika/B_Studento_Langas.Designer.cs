
namespace Antroji_Programavimo_Praktika
{
    partial class B_Studento_Langas
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
            this.dataGridViewPazimys = new System.Windows.Forms.DataGridView();
            this.textBoxPazimys55 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPazimys)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPazimys
            // 
            this.dataGridViewPazimys.AllowUserToOrderColumns = true;
            this.dataGridViewPazimys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPazimys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPazimys.Location = new System.Drawing.Point(134, 88);
            this.dataGridViewPazimys.Name = "dataGridViewPazimys";
            this.dataGridViewPazimys.Size = new System.Drawing.Size(322, 379);
            this.dataGridViewPazimys.TabIndex = 1;
            // 
            // textBoxPazimys55
            // 
            this.textBoxPazimys55.Location = new System.Drawing.Point(23, 15);
            this.textBoxPazimys55.Name = "textBoxPazimys55";
            this.textBoxPazimys55.ReadOnly = true;
            this.textBoxPazimys55.Size = new System.Drawing.Size(100, 20);
            this.textBoxPazimys55.TabIndex = 12;
            // 
            // B_Studento_Langas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 509);
            this.Controls.Add(this.textBoxPazimys55);
            this.Controls.Add(this.dataGridViewPazimys);
            this.Name = "B_Studento_Langas";
            this.Text = "MainStudento";
            this.Load += new System.EventHandler(this.MainStudento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPazimys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPazimys;
        public System.Windows.Forms.TextBox textBoxPazimys55;
    }
}