namespace _2_Form
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
            this.lboxCategories = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lboxCategories
            // 
            this.lboxCategories.FormattingEnabled = true;
            this.lboxCategories.ItemHeight = 15;
            this.lboxCategories.Location = new System.Drawing.Point(42, 35);
            this.lboxCategories.Name = "lboxCategories";
            this.lboxCategories.Size = new System.Drawing.Size(222, 184);
            this.lboxCategories.TabIndex = 0;
            this.lboxCategories.SelectedIndexChanged += new System.EventHandler(this.lboxCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategoriler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürünler";
            // 
            // lboxProducts
            // 
            this.lboxProducts.FormattingEnabled = true;
            this.lboxProducts.ItemHeight = 15;
            this.lboxProducts.Location = new System.Drawing.Point(300, 31);
            this.lboxProducts.Name = "lboxProducts";
            this.lboxProducts.Size = new System.Drawing.Size(183, 184);
            this.lboxProducts.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 231);
            this.Controls.Add(this.lboxProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxCategories);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lboxCategories;
        private Label label1;
        private Label label2;
        private ListBox lboxProducts;
    }
}