namespace BookBase.Views
{
    partial class BookDetailsTab
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
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bookCard = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.MistyRose;
            this.backBtn.BackgroundImage = global::BookBase.Properties.Resources.Backkk1;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Margin = new System.Windows.Forms.Padding(0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(41, 600);
            this.backBtn.TabIndex = 3;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(585, 600);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // bookCard
            // 
            this.bookCard.AutoScroll = true;
            this.bookCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookCard.Depth = 0;
            this.bookCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bookCard.Location = new System.Drawing.Point(41, 0);
            this.bookCard.Margin = new System.Windows.Forms.Padding(14);
            this.bookCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookCard.Name = "bookCard";
            this.bookCard.Padding = new System.Windows.Forms.Padding(14);
            this.bookCard.Size = new System.Drawing.Size(544, 600);
            this.bookCard.TabIndex = 4;
            // 
            // BookDetailsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bookCard);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Enabled = false;
            this.Name = "BookDetailsTab";
            this.Size = new System.Drawing.Size(585, 600);
            this.EnabledChanged += new System.EventHandler(this.BookDetailsTab_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard bookCard;
    }
}
