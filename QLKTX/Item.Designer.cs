namespace QLKTX
{
    partial class Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTitle = new System.Windows.Forms.Button();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picItem, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(100, 135);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnTitle
            // 
            this.btnTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.Location = new System.Drawing.Point(2, 102);
            this.btnTitle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(96, 31);
            this.btnTitle.TabIndex = 0;
            this.btnTitle.Text = "Title";
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            this.btnTitle.Enter += new System.EventHandler(this.btnTitle_Enter);
            this.btnTitle.Leave += new System.EventHandler(this.btnTitle_Leave);
            // 
            // picItem
            // 
            this.picItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picItem.Location = new System.Drawing.Point(0, 0);
            this.picItem.Margin = new System.Windows.Forms.Padding(0);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(100, 100);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem.TabIndex = 1;
            this.picItem.TabStop = false;
            // 
            // Item
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(100, 135);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button btnTitle;
        public System.Windows.Forms.PictureBox picItem;
    }
}
