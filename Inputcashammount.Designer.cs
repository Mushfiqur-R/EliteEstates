namespace EliteEstates
{
    partial class Inputcashammount
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
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.selectammountdeposit = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.backbtninputammount = new Guna.UI.WinForms.GunaImageButton();
            this.SuspendLayout();
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Navy;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(241, 267);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 19;
            this.gunaButton1.Size = new System.Drawing.Size(132, 42);
            this.gunaButton1.TabIndex = 6;
            this.gunaButton1.Text = "Confirm";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // selectammountdeposit
            // 
            this.selectammountdeposit.BackColor = System.Drawing.Color.White;
            this.selectammountdeposit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.selectammountdeposit.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.selectammountdeposit.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectammountdeposit.ForeColor = System.Drawing.Color.Navy;
            this.selectammountdeposit.LineColor = System.Drawing.Color.IndianRed;
            this.selectammountdeposit.Location = new System.Drawing.Point(57, 188);
            this.selectammountdeposit.Name = "selectammountdeposit";
            this.selectammountdeposit.PasswordChar = '\0';
            this.selectammountdeposit.SelectedText = "";
            this.selectammountdeposit.Size = new System.Drawing.Size(257, 37);
            this.selectammountdeposit.TabIndex = 5;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Navy;
            this.gunaLabel1.Location = new System.Drawing.Point(53, 142);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(169, 21);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Enter Ammount :";
            // 
            // backbtninputammount
            // 
            this.backbtninputammount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backbtninputammount.Image = global::EliteEstates.Properties.Resources.backbutton;
            this.backbtninputammount.ImageSize = new System.Drawing.Size(64, 64);
            this.backbtninputammount.Location = new System.Drawing.Point(350, 21);
            this.backbtninputammount.Name = "backbtninputammount";
            this.backbtninputammount.OnHoverImage = null;
            this.backbtninputammount.OnHoverImageOffset = new System.Drawing.Point(5, -1);
            this.backbtninputammount.Size = new System.Drawing.Size(51, 44);
            this.backbtninputammount.TabIndex = 15;
            this.backbtninputammount.Click += new System.EventHandler(this.backbtninputammount_Click);
            // 
            // Inputcashammount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.backbtninputammount);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.selectammountdeposit);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "Inputcashammount";
            this.Text = "Inputcashammount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLineTextBox selectammountdeposit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaImageButton backbtninputammount;
    }
}