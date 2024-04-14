namespace BookBase.Views.Components
{
    partial class AlertBox
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
            this.passwordInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.proceedBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordInput
            // 
            this.passwordInput.AnimateReadOnly = false;
            this.passwordInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordInput.Depth = 0;
            this.passwordInput.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.HideSelection = true;
            this.passwordInput.LeadingIcon = null;
            this.passwordInput.Location = new System.Drawing.Point(6, 64);
            this.passwordInput.MaxLength = 32767;
            this.passwordInput.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '●';
            this.passwordInput.PrefixSuffixText = null;
            this.passwordInput.ReadOnly = false;
            this.passwordInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordInput.SelectedText = "";
            this.passwordInput.SelectionLength = 0;
            this.passwordInput.SelectionStart = 0;
            this.passwordInput.ShortcutsEnabled = true;
            this.passwordInput.Size = new System.Drawing.Size(388, 48);
            this.passwordInput.TabIndex = 0;
            this.passwordInput.TabStop = false;
            this.passwordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordInput.TrailingIcon = null;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // proceedBtn
            // 
            this.proceedBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.proceedBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.proceedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceedBtn.Location = new System.Drawing.Point(292, 155);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(100, 35);
            this.proceedBtn.TabIndex = 2;
            this.proceedBtn.Text = "Proceed";
            this.proceedBtn.UseVisualStyleBackColor = false;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.IndianRed;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(184, 155);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 35);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter password to continue:";
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Font = new System.Drawing.Font("Monaco", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsg.ForeColor = System.Drawing.Color.IndianRed;
            this.errorMsg.Location = new System.Drawing.Point(8, 123);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(0, 15);
            this.errorMsg.TabIndex = 5;
            // 
            // AlertBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.proceedBtn);
            this.Controls.Add(this.passwordInput);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.Name = "AlertBox";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 passwordInput;
        private System.Windows.Forms.Button proceedBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorMsg;
    }
}