namespace EliteEstates
{
    partial class Buyitem
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.selectitemforbuy = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.backbtneditinfo = new Guna.UI.WinForms.GunaImageButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Navy;
            this.gunaLabel1.Location = new System.Drawing.Point(52, 96);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(306, 21);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Select Itens ID Number for buy :";
            // 
            // selectitemforbuy
            // 
            this.selectitemforbuy.BackColor = System.Drawing.Color.White;
            this.selectitemforbuy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.selectitemforbuy.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.selectitemforbuy.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectitemforbuy.ForeColor = System.Drawing.Color.Navy;
            this.selectitemforbuy.LineColor = System.Drawing.Color.Gainsboro;
            this.selectitemforbuy.Location = new System.Drawing.Point(56, 142);
            this.selectitemforbuy.Name = "selectitemforbuy";
            this.selectitemforbuy.PasswordChar = '\0';
            this.selectitemforbuy.SelectedText = "";
            this.selectitemforbuy.Size = new System.Drawing.Size(257, 37);
            this.selectitemforbuy.TabIndex = 2;
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
            this.gunaButton1.Location = new System.Drawing.Point(240, 221);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 19;
            this.gunaButton1.Size = new System.Drawing.Size(132, 42);
            this.gunaButton1.TabIndex = 3;
            this.gunaButton1.Text = "Confirm";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // backbtneditinfo
            // 
            this.backbtneditinfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backbtneditinfo.Image = global::EliteEstates.Properties.Resources.backbutton;
            this.backbtneditinfo.ImageSize = new System.Drawing.Size(64, 64);
            this.backbtneditinfo.Location = new System.Drawing.Point(365, 22);
            this.backbtneditinfo.Name = "backbtneditinfo";
            this.backbtneditinfo.OnHoverImage = null;
            this.backbtneditinfo.OnHoverImageOffset = new System.Drawing.Point(5, -1);
            this.backbtneditinfo.Size = new System.Drawing.Size(36, 31);
            this.backbtneditinfo.TabIndex = 15;
            this.backbtneditinfo.Click += new System.EventHandler(this.backbtneditinfo_Click);
            // 
            // Buyitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 317);
            this.Controls.Add(this.backbtneditinfo);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.selectitemforbuy);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "Buyitem";
            this.Text = "Buyitem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox selectitemforbuy;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaImageButton backbtneditinfo;
    }
}