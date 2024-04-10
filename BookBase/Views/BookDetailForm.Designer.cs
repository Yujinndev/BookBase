namespace BookBase.Views
{
    partial class BookDetailForm
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
            this.bookCard = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backBtn.BackgroundImage = global::BookBase.Properties.Resources.Backkk1;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(52, 600);
            this.backBtn.TabIndex = 0;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // bookCard
            // 
            this.bookCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookCard.Depth = 0;
            this.bookCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bookCard.Location = new System.Drawing.Point(52, 0);
            this.bookCard.Margin = new System.Windows.Forms.Padding(14);
            this.bookCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookCard.Name = "bookCard";
            this.bookCard.Padding = new System.Windows.Forms.Padding(14);
            this.bookCard.Size = new System.Drawing.Size(533, 600);
            this.bookCard.TabIndex = 1;
            // 
            // BookDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bookCard);
            this.Controls.Add(this.backBtn);
            this.Enabled = false;
            this.Name = "BookDetailForm";
            this.Size = new System.Drawing.Size(585, 600);
            this.EnabledChanged += new System.EventHandler(this.BookDetailForm_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backBtn;
        private MaterialSkin.Controls.MaterialCard bookCard;
    }
}
