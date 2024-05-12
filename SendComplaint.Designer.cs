namespace EliteEstates
{
    partial class SendComplaint
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
            this.complaintboxtxt = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sendcomplaintbtn = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.backbtnsendcomplaint = new Guna.UI.WinForms.GunaImageButton();
            this.SuspendLayout();
            // 
            // complaintboxtxt
            // 
            this.complaintboxtxt.BackColor = System.Drawing.Color.Transparent;
            this.complaintboxtxt.BaseColor = System.Drawing.Color.White;
            this.complaintboxtxt.BorderColor = System.Drawing.Color.Silver;
            this.complaintboxtxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.complaintboxtxt.FocusedBaseColor = System.Drawing.Color.White;
            this.complaintboxtxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.complaintboxtxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.complaintboxtxt.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintboxtxt.Location = new System.Drawing.Point(42, 84);
            this.complaintboxtxt.Multiline = true;
            this.complaintboxtxt.Name = "complaintboxtxt";
            this.complaintboxtxt.PasswordChar = '\0';
            this.complaintboxtxt.Radius = 15;
            this.complaintboxtxt.SelectedText = "";
            this.complaintboxtxt.Size = new System.Drawing.Size(340, 168);
            this.complaintboxtxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(62, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Write Your Complaint  :";
            // 
            // Sendcomplaintbtn
            // 
            this.Sendcomplaintbtn.AnimationHoverSpeed = 0.07F;
            this.Sendcomplaintbtn.AnimationSpeed = 0.03F;
            this.Sendcomplaintbtn.BackColor = System.Drawing.Color.Transparent;
            this.Sendcomplaintbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Sendcomplaintbtn.BorderColor = System.Drawing.Color.Black;
            this.Sendcomplaintbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Sendcomplaintbtn.FocusedColor = System.Drawing.Color.Empty;
            this.Sendcomplaintbtn.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sendcomplaintbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Sendcomplaintbtn.Image = null;
            this.Sendcomplaintbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.Sendcomplaintbtn.Location = new System.Drawing.Point(290, 332);
            this.Sendcomplaintbtn.Name = "Sendcomplaintbtn";
            this.Sendcomplaintbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sendcomplaintbtn.OnHoverBorderColor = System.Drawing.Color.Red;
            this.Sendcomplaintbtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sendcomplaintbtn.OnHoverImage = null;
            this.Sendcomplaintbtn.OnPressedColor = System.Drawing.Color.Black;
            this.Sendcomplaintbtn.Radius = 15;
            this.Sendcomplaintbtn.Size = new System.Drawing.Size(128, 42);
            this.Sendcomplaintbtn.TabIndex = 4;
            this.Sendcomplaintbtn.Text = "Send ";
            this.Sendcomplaintbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sendcomplaintbtn.Click += new System.EventHandler(this.Sendcomplaintbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(260, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "within 50 words";
            // 
            // backbtnsendcomplaint
            // 
            this.backbtnsendcomplaint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backbtnsendcomplaint.Image = global::EliteEstates.Properties.Resources.backbutton;
            this.backbtnsendcomplaint.ImageSize = new System.Drawing.Size(64, 64);
            this.backbtnsendcomplaint.Location = new System.Drawing.Point(367, 12);
            this.backbtnsendcomplaint.Name = "backbtnsendcomplaint";
            this.backbtnsendcomplaint.OnHoverImage = null;
            this.backbtnsendcomplaint.OnHoverImageOffset = new System.Drawing.Point(5, -1);
            this.backbtnsendcomplaint.Size = new System.Drawing.Size(36, 31);
            this.backbtnsendcomplaint.TabIndex = 15;
            this.backbtnsendcomplaint.Click += new System.EventHandler(this.backbtnsendcomplaint_Click);
            // 
            // SendComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 477);
            this.Controls.Add(this.backbtnsendcomplaint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sendcomplaintbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.complaintboxtxt);
            this.Name = "SendComplaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendComplaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox complaintboxtxt;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton Sendcomplaintbtn;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaImageButton backbtnsendcomplaint;
    }
}