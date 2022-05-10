namespace KPIVisualizador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListKPIdataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListKPIdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListKPIdataGridView1
            // 
            this.ListKPIdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListKPIdataGridView1.Location = new System.Drawing.Point(12, 45);
            this.ListKPIdataGridView1.Name = "ListKPIdataGridView1";
            this.ListKPIdataGridView1.RowHeadersWidth = 51;
            this.ListKPIdataGridView1.RowTemplate.Height = 29;
            this.ListKPIdataGridView1.Size = new System.Drawing.Size(1213, 652);
            this.ListKPIdataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 716);
            this.Controls.Add(this.ListKPIdataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListKPIdataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView ListKPIdataGridView1;
    }
}