namespace BookBase.Views
{
    partial class UpdateBookForm
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
            this.resetBtn = new System.Windows.Forms.Button();
            this.imageInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.shelfInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.publisherInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.authorInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.yearInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.titleInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.saveBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.resetBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(42, 606);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(540, 41);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset Form";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // imageInput
            // 
            this.imageInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageInput.AnimateReadOnly = false;
            this.imageInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.imageInput.Depth = 0;
            this.imageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.imageInput.HelperText = "Image URI";
            this.imageInput.HideSelection = true;
            this.imageInput.LeadingIcon = null;
            this.imageInput.Location = new System.Drawing.Point(42, 517);
            this.imageInput.Margin = new System.Windows.Forms.Padding(10);
            this.imageInput.MaxLength = 32767;
            this.imageInput.MouseState = MaterialSkin.MouseState.OUT;
            this.imageInput.Name = "imageInput";
            this.imageInput.Padding = new System.Windows.Forms.Padding(10);
            this.imageInput.PasswordChar = '\0';
            this.imageInput.PrefixSuffixText = null;
            this.imageInput.ReadOnly = false;
            this.imageInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.imageInput.SelectedText = "";
            this.imageInput.SelectionLength = 0;
            this.imageInput.SelectionStart = 0;
            this.imageInput.ShortcutsEnabled = true;
            this.imageInput.Size = new System.Drawing.Size(540, 48);
            this.imageInput.TabIndex = 17;
            this.imageInput.TabStop = false;
            this.imageInput.Text = "Image URI";
            this.imageInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.imageInput.TrailingIcon = null;
            this.imageInput.UseSystemPasswordChar = false;
            // 
            // shelfInput
            // 
            this.shelfInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shelfInput.AnimateReadOnly = false;
            this.shelfInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.shelfInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.shelfInput.Depth = 0;
            this.shelfInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.shelfInput.HelperText = "Shelf Location";
            this.shelfInput.HideSelection = true;
            this.shelfInput.LeadingIcon = null;
            this.shelfInput.Location = new System.Drawing.Point(42, 466);
            this.shelfInput.Margin = new System.Windows.Forms.Padding(10);
            this.shelfInput.MaxLength = 32767;
            this.shelfInput.MouseState = MaterialSkin.MouseState.OUT;
            this.shelfInput.Name = "shelfInput";
            this.shelfInput.Padding = new System.Windows.Forms.Padding(10);
            this.shelfInput.PasswordChar = '\0';
            this.shelfInput.PrefixSuffixText = null;
            this.shelfInput.ReadOnly = false;
            this.shelfInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.shelfInput.SelectedText = "";
            this.shelfInput.SelectionLength = 0;
            this.shelfInput.SelectionStart = 0;
            this.shelfInput.ShortcutsEnabled = true;
            this.shelfInput.Size = new System.Drawing.Size(540, 48);
            this.shelfInput.TabIndex = 16;
            this.shelfInput.TabStop = false;
            this.shelfInput.Text = "Shelf Location";
            this.shelfInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.shelfInput.TrailingIcon = null;
            this.shelfInput.UseSystemPasswordChar = false;
            // 
            // publisherInput
            // 
            this.publisherInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publisherInput.AnimateReadOnly = false;
            this.publisherInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.publisherInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.publisherInput.Depth = 0;
            this.publisherInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.publisherInput.HelperText = "Publisher";
            this.publisherInput.HideSelection = true;
            this.publisherInput.LeadingIcon = null;
            this.publisherInput.Location = new System.Drawing.Point(42, 364);
            this.publisherInput.Margin = new System.Windows.Forms.Padding(10);
            this.publisherInput.MaxLength = 32767;
            this.publisherInput.MouseState = MaterialSkin.MouseState.OUT;
            this.publisherInput.Name = "publisherInput";
            this.publisherInput.Padding = new System.Windows.Forms.Padding(10);
            this.publisherInput.PasswordChar = '\0';
            this.publisherInput.PrefixSuffixText = null;
            this.publisherInput.ReadOnly = false;
            this.publisherInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.publisherInput.SelectedText = "";
            this.publisherInput.SelectionLength = 0;
            this.publisherInput.SelectionStart = 0;
            this.publisherInput.ShortcutsEnabled = true;
            this.publisherInput.Size = new System.Drawing.Size(540, 48);
            this.publisherInput.TabIndex = 14;
            this.publisherInput.TabStop = false;
            this.publisherInput.Text = "Publisher";
            this.publisherInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.publisherInput.TrailingIcon = null;
            this.publisherInput.UseSystemPasswordChar = false;
            // 
            // authorInput
            // 
            this.authorInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorInput.AnimateReadOnly = false;
            this.authorInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.authorInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.authorInput.Depth = 0;
            this.authorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.authorInput.HelperText = "Author";
            this.authorInput.HideSelection = true;
            this.authorInput.LeadingIcon = null;
            this.authorInput.Location = new System.Drawing.Point(42, 313);
            this.authorInput.Margin = new System.Windows.Forms.Padding(10);
            this.authorInput.MaxLength = 32767;
            this.authorInput.MouseState = MaterialSkin.MouseState.OUT;
            this.authorInput.Name = "authorInput";
            this.authorInput.Padding = new System.Windows.Forms.Padding(10);
            this.authorInput.PasswordChar = '\0';
            this.authorInput.PrefixSuffixText = null;
            this.authorInput.ReadOnly = false;
            this.authorInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.authorInput.SelectedText = "";
            this.authorInput.SelectionLength = 0;
            this.authorInput.SelectionStart = 0;
            this.authorInput.ShortcutsEnabled = true;
            this.authorInput.Size = new System.Drawing.Size(540, 48);
            this.authorInput.TabIndex = 13;
            this.authorInput.TabStop = false;
            this.authorInput.Text = "Author";
            this.authorInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.authorInput.TrailingIcon = null;
            this.authorInput.UseSystemPasswordChar = false;
            // 
            // yearInput
            // 
            this.yearInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yearInput.AnimateReadOnly = false;
            this.yearInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yearInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.yearInput.Depth = 0;
            this.yearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.yearInput.HelperText = "Year Published";
            this.yearInput.HideSelection = true;
            this.yearInput.LeadingIcon = null;
            this.yearInput.Location = new System.Drawing.Point(42, 415);
            this.yearInput.Margin = new System.Windows.Forms.Padding(10);
            this.yearInput.MaxLength = 32767;
            this.yearInput.MouseState = MaterialSkin.MouseState.OUT;
            this.yearInput.Name = "yearInput";
            this.yearInput.Padding = new System.Windows.Forms.Padding(10);
            this.yearInput.PasswordChar = '\0';
            this.yearInput.PrefixSuffixText = null;
            this.yearInput.ReadOnly = false;
            this.yearInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yearInput.SelectedText = "";
            this.yearInput.SelectionLength = 0;
            this.yearInput.SelectionStart = 0;
            this.yearInput.ShortcutsEnabled = true;
            this.yearInput.Size = new System.Drawing.Size(540, 48);
            this.yearInput.TabIndex = 15;
            this.yearInput.TabStop = false;
            this.yearInput.Text = "Year Published";
            this.yearInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.yearInput.TrailingIcon = null;
            this.yearInput.UseSystemPasswordChar = false;
            // 
            // titleInput
            // 
            this.titleInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleInput.AnimateReadOnly = false;
            this.titleInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.titleInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.titleInput.Depth = 0;
            this.titleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.titleInput.HelperText = "Title";
            this.titleInput.HideSelection = true;
            this.titleInput.LeadingIcon = null;
            this.titleInput.Location = new System.Drawing.Point(42, 262);
            this.titleInput.Margin = new System.Windows.Forms.Padding(10);
            this.titleInput.MaxLength = 32767;
            this.titleInput.MouseState = MaterialSkin.MouseState.OUT;
            this.titleInput.Name = "titleInput";
            this.titleInput.Padding = new System.Windows.Forms.Padding(10);
            this.titleInput.PasswordChar = '\0';
            this.titleInput.PrefixSuffixText = null;
            this.titleInput.ReadOnly = false;
            this.titleInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleInput.SelectedText = "";
            this.titleInput.SelectionLength = 0;
            this.titleInput.SelectionStart = 0;
            this.titleInput.ShortcutsEnabled = true;
            this.titleInput.Size = new System.Drawing.Size(540, 48);
            this.titleInput.TabIndex = 12;
            this.titleInput.TabStop = false;
            this.titleInput.Text = "Title";
            this.titleInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.titleInput.TrailingIcon = null;
            this.titleInput.UseSystemPasswordChar = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(42, 565);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(540, 41);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Save update";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BookBase.Properties.Resources.UpdateBook;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(42, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 235);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.BackgroundImage = global::BookBase.Properties.Resources.Backkk;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.Location = new System.Drawing.Point(3, 24);
            this.backBtn.Margin = new System.Windows.Forms.Padding(0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(39, 623);
            this.backBtn.TabIndex = 11;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // UpdateBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 650);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageInput);
            this.Controls.Add(this.shelfInput);
            this.Controls.Add(this.publisherInput);
            this.Controls.Add(this.authorInput);
            this.Controls.Add(this.yearInput);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.backBtn);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximumSize = new System.Drawing.Size(1085, 725);
            this.MinimumSize = new System.Drawing.Size(585, 650);
            this.Name = "UpdateBookForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateBookForm";
            this.Load += new System.EventHandler(this.UpdateBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox2 imageInput;
        private MaterialSkin.Controls.MaterialTextBox2 shelfInput;
        private MaterialSkin.Controls.MaterialTextBox2 publisherInput;
        private MaterialSkin.Controls.MaterialTextBox2 authorInput;
        private MaterialSkin.Controls.MaterialTextBox2 yearInput;
        private MaterialSkin.Controls.MaterialTextBox2 titleInput;
        private System.Windows.Forms.PictureBox backBtn;
    }
}