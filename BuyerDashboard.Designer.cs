namespace EliteEstates
{
    partial class BuyerDashboard
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
            this.deletebtn = new Guna.UI.WinForms.GunaButton();
            this.buybtn = new Guna.UI.WinForms.GunaButton();
            this.Buyerbalance = new Guna.UI.WinForms.GunaElipsePanel();
            this.Currentbalancebuyer = new System.Windows.Forms.Label();
            this.currentbalancebuyerlbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchbarlblb = new System.Windows.Forms.Label();
            this.buyersearchbartxt = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Addcash = new Guna.UI.WinForms.GunaButton();
            this.sendcomplaintbtnbuyer = new Guna.UI.WinForms.GunaButton();
            this.Transectionbtnbuyer = new Guna.UI.WinForms.GunaButton();
            this.editbtnbuyer = new Guna.UI.WinForms.GunaButton();
            this.bnamelbl = new System.Windows.Forms.Label();
            this.searchbtnbuyer = new Guna.UI.WinForms.GunaImageButton();
            this.logoutbtnbuyer = new Guna.UI.WinForms.GunaImageButton();
            this.buyerpicture = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.Buyerbalance.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // deletebtn
            // 
            this.deletebtn.AnimationHoverSpeed = 0.07F;
            this.deletebtn.AnimationSpeed = 0.03F;
            this.deletebtn.BackColor = System.Drawing.Color.Transparent;
            this.deletebtn.BaseColor = System.Drawing.Color.Red;
            this.deletebtn.BorderColor = System.Drawing.Color.Black;
            this.deletebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deletebtn.FocusedColor = System.Drawing.Color.Empty;
            this.deletebtn.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deletebtn.Image = null;
            this.deletebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deletebtn.Location = new System.Drawing.Point(737, 71);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deletebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deletebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deletebtn.OnHoverImage = null;
            this.deletebtn.OnPressedColor = System.Drawing.Color.Black;
            this.deletebtn.Radius = 15;
            this.deletebtn.Size = new System.Drawing.Size(160, 42);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "Delete";
            this.deletebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buybtn
            // 
            this.buybtn.AnimationHoverSpeed = 0.07F;
            this.buybtn.AnimationSpeed = 0.03F;
            this.buybtn.BackColor = System.Drawing.Color.Transparent;
            this.buybtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buybtn.BorderColor = System.Drawing.Color.Black;
            this.buybtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buybtn.FocusedColor = System.Drawing.Color.Empty;
            this.buybtn.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buybtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buybtn.Image = null;
            this.buybtn.ImageSize = new System.Drawing.Size(20, 20);
            this.buybtn.Location = new System.Drawing.Point(535, 71);
            this.buybtn.Name = "buybtn";
            this.buybtn.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.buybtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buybtn.OnHoverForeColor = System.Drawing.Color.White;
            this.buybtn.OnHoverImage = null;
            this.buybtn.OnPressedColor = System.Drawing.Color.Black;
            this.buybtn.Radius = 15;
            this.buybtn.Size = new System.Drawing.Size(160, 42);
            this.buybtn.TabIndex = 10;
            this.buybtn.Text = "Buy";
            this.buybtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Buyerbalance
            // 
            this.Buyerbalance.BackColor = System.Drawing.Color.Transparent;
            this.Buyerbalance.BaseColor = System.Drawing.Color.SkyBlue;
            this.Buyerbalance.Controls.Add(this.Currentbalancebuyer);
            this.Buyerbalance.Controls.Add(this.currentbalancebuyerlbl);
            this.Buyerbalance.Location = new System.Drawing.Point(281, 73);
            this.Buyerbalance.Name = "Buyerbalance";
            this.Buyerbalance.Radius = 15;
            this.Buyerbalance.Size = new System.Drawing.Size(215, 133);
            this.Buyerbalance.TabIndex = 7;
            // 
            // Currentbalancebuyer
            // 
            this.Currentbalancebuyer.AutoSize = true;
            this.Currentbalancebuyer.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currentbalancebuyer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Currentbalancebuyer.Location = new System.Drawing.Point(63, 60);
            this.Currentbalancebuyer.Name = "Currentbalancebuyer";
            this.Currentbalancebuyer.Size = new System.Drawing.Size(51, 35);
            this.Currentbalancebuyer.TabIndex = 5;
            this.Currentbalancebuyer.Text = "00";
            // 
            // currentbalancebuyerlbl
            // 
            this.currentbalancebuyerlbl.AutoSize = true;
            this.currentbalancebuyerlbl.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentbalancebuyerlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.currentbalancebuyerlbl.Location = new System.Drawing.Point(12, 20);
            this.currentbalancebuyerlbl.Name = "currentbalancebuyerlbl";
            this.currentbalancebuyerlbl.Size = new System.Drawing.Size(159, 20);
            this.currentbalancebuyerlbl.TabIndex = 4;
            this.currentbalancebuyerlbl.Text = "Current Balance :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.searchbtnbuyer);
            this.panel2.Controls.Add(this.searchbarlblb);
            this.panel2.Controls.Add(this.logoutbtnbuyer);
            this.panel2.Controls.Add(this.buyersearchbartxt);
            this.panel2.Location = new System.Drawing.Point(250, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 50);
            this.panel2.TabIndex = 9;
            // 
            // searchbarlblb
            // 
            this.searchbarlblb.AutoSize = true;
            this.searchbarlblb.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbarlblb.ForeColor = System.Drawing.Color.White;
            this.searchbarlblb.Location = new System.Drawing.Point(152, 15);
            this.searchbarlblb.Name = "searchbarlblb";
            this.searchbarlblb.Size = new System.Drawing.Size(78, 20);
            this.searchbarlblb.TabIndex = 6;
            this.searchbarlblb.Text = "Search :";
            // 
            // buyersearchbartxt
            // 
            this.buyersearchbartxt.BackColor = System.Drawing.Color.LightGray;
            this.buyersearchbartxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buyersearchbartxt.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.buyersearchbartxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buyersearchbartxt.LineColor = System.Drawing.Color.Gainsboro;
            this.buyersearchbartxt.Location = new System.Drawing.Point(249, 5);
            this.buyersearchbartxt.Name = "buyersearchbartxt";
            this.buyersearchbartxt.PasswordChar = '\0';
            this.buyersearchbartxt.SelectedText = "";
            this.buyersearchbartxt.Size = new System.Drawing.Size(282, 30);
            this.buyersearchbartxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(982, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Log out";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.Addcash);
            this.panel1.Controls.Add(this.sendcomplaintbtnbuyer);
            this.panel1.Controls.Add(this.Transectionbtnbuyer);
            this.panel1.Controls.Add(this.editbtnbuyer);
            this.panel1.Controls.Add(this.bnamelbl);
            this.panel1.Controls.Add(this.buyerpicture);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 543);
            this.panel1.TabIndex = 6;
            // 
            // Addcash
            // 
            this.Addcash.AnimationHoverSpeed = 0.07F;
            this.Addcash.AnimationSpeed = 0.03F;
            this.Addcash.BackColor = System.Drawing.Color.Transparent;
            this.Addcash.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Addcash.BorderColor = System.Drawing.Color.Black;
            this.Addcash.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Addcash.FocusedColor = System.Drawing.Color.Empty;
            this.Addcash.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addcash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Addcash.Image = null;
            this.Addcash.ImageSize = new System.Drawing.Size(20, 20);
            this.Addcash.Location = new System.Drawing.Point(33, 396);
            this.Addcash.Name = "Addcash";
            this.Addcash.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Addcash.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Addcash.OnHoverForeColor = System.Drawing.Color.White;
            this.Addcash.OnHoverImage = null;
            this.Addcash.OnPressedColor = System.Drawing.Color.Black;
            this.Addcash.Radius = 15;
            this.Addcash.Size = new System.Drawing.Size(160, 51);
            this.Addcash.TabIndex = 6;
            this.Addcash.Text = "Cash Deposit";
            this.Addcash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sendcomplaintbtnbuyer
            // 
            this.sendcomplaintbtnbuyer.AnimationHoverSpeed = 0.07F;
            this.sendcomplaintbtnbuyer.AnimationSpeed = 0.03F;
            this.sendcomplaintbtnbuyer.BackColor = System.Drawing.Color.Transparent;
            this.sendcomplaintbtnbuyer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.sendcomplaintbtnbuyer.BorderColor = System.Drawing.Color.Black;
            this.sendcomplaintbtnbuyer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sendcomplaintbtnbuyer.FocusedColor = System.Drawing.Color.Empty;
            this.sendcomplaintbtnbuyer.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendcomplaintbtnbuyer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sendcomplaintbtnbuyer.Image = null;
            this.sendcomplaintbtnbuyer.ImageSize = new System.Drawing.Size(20, 20);
            this.sendcomplaintbtnbuyer.Location = new System.Drawing.Point(33, 313);
            this.sendcomplaintbtnbuyer.Name = "sendcomplaintbtnbuyer";
            this.sendcomplaintbtnbuyer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sendcomplaintbtnbuyer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.sendcomplaintbtnbuyer.OnHoverForeColor = System.Drawing.Color.White;
            this.sendcomplaintbtnbuyer.OnHoverImage = null;
            this.sendcomplaintbtnbuyer.OnPressedColor = System.Drawing.Color.Black;
            this.sendcomplaintbtnbuyer.Radius = 15;
            this.sendcomplaintbtnbuyer.Size = new System.Drawing.Size(160, 51);
            this.sendcomplaintbtnbuyer.TabIndex = 5;
            this.sendcomplaintbtnbuyer.Text = "Send complaint";
            this.sendcomplaintbtnbuyer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Transectionbtnbuyer
            // 
            this.Transectionbtnbuyer.AnimationHoverSpeed = 0.07F;
            this.Transectionbtnbuyer.AnimationSpeed = 0.03F;
            this.Transectionbtnbuyer.BackColor = System.Drawing.Color.Transparent;
            this.Transectionbtnbuyer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Transectionbtnbuyer.BorderColor = System.Drawing.Color.Black;
            this.Transectionbtnbuyer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Transectionbtnbuyer.FocusedColor = System.Drawing.Color.Empty;
            this.Transectionbtnbuyer.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transectionbtnbuyer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Transectionbtnbuyer.Image = null;
            this.Transectionbtnbuyer.ImageSize = new System.Drawing.Size(20, 20);
            this.Transectionbtnbuyer.Location = new System.Drawing.Point(33, 224);
            this.Transectionbtnbuyer.Name = "Transectionbtnbuyer";
            this.Transectionbtnbuyer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Transectionbtnbuyer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Transectionbtnbuyer.OnHoverForeColor = System.Drawing.Color.White;
            this.Transectionbtnbuyer.OnHoverImage = null;
            this.Transectionbtnbuyer.OnPressedColor = System.Drawing.Color.Black;
            this.Transectionbtnbuyer.Radius = 15;
            this.Transectionbtnbuyer.Size = new System.Drawing.Size(160, 51);
            this.Transectionbtnbuyer.TabIndex = 4;
            this.Transectionbtnbuyer.Text = "Transections";
            this.Transectionbtnbuyer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editbtnbuyer
            // 
            this.editbtnbuyer.AnimationHoverSpeed = 0.07F;
            this.editbtnbuyer.AnimationSpeed = 0.03F;
            this.editbtnbuyer.BackColor = System.Drawing.Color.Transparent;
            this.editbtnbuyer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.editbtnbuyer.BorderColor = System.Drawing.Color.Black;
            this.editbtnbuyer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.editbtnbuyer.FocusedColor = System.Drawing.Color.Empty;
            this.editbtnbuyer.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtnbuyer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.editbtnbuyer.Image = null;
            this.editbtnbuyer.ImageSize = new System.Drawing.Size(20, 20);
            this.editbtnbuyer.Location = new System.Drawing.Point(33, 145);
            this.editbtnbuyer.Name = "editbtnbuyer";
            this.editbtnbuyer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.editbtnbuyer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.editbtnbuyer.OnHoverForeColor = System.Drawing.Color.White;
            this.editbtnbuyer.OnHoverImage = null;
            this.editbtnbuyer.OnPressedColor = System.Drawing.Color.Black;
            this.editbtnbuyer.Radius = 15;
            this.editbtnbuyer.Size = new System.Drawing.Size(160, 42);
            this.editbtnbuyer.TabIndex = 3;
            this.editbtnbuyer.Text = "Edit Info";
            this.editbtnbuyer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bnamelbl
            // 
            this.bnamelbl.AutoSize = true;
            this.bnamelbl.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnamelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnamelbl.Location = new System.Drawing.Point(44, 110);
            this.bnamelbl.Name = "bnamelbl";
            this.bnamelbl.Size = new System.Drawing.Size(115, 20);
            this.bnamelbl.TabIndex = 3;
            this.bnamelbl.Text = "Buyer Name";
            // 
            // searchbtnbuyer
            // 
            this.searchbtnbuyer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchbtnbuyer.Image = global::EliteEstates.Properties.Resources.searchlogo;
            this.searchbtnbuyer.ImageSize = new System.Drawing.Size(64, 64);
            this.searchbtnbuyer.Location = new System.Drawing.Point(537, 3);
            this.searchbtnbuyer.Name = "searchbtnbuyer";
            this.searchbtnbuyer.OnHoverImage = null;
            this.searchbtnbuyer.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.searchbtnbuyer.Size = new System.Drawing.Size(44, 40);
            this.searchbtnbuyer.TabIndex = 4;
            // 
            // logoutbtnbuyer
            // 
            this.logoutbtnbuyer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logoutbtnbuyer.Image = global::EliteEstates.Properties.Resources.Signoutupdate;
            this.logoutbtnbuyer.ImageSize = new System.Drawing.Size(64, 64);
            this.logoutbtnbuyer.Location = new System.Drawing.Point(731, 3);
            this.logoutbtnbuyer.Name = "logoutbtnbuyer";
            this.logoutbtnbuyer.OnHoverImage = null;
            this.logoutbtnbuyer.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.logoutbtnbuyer.Size = new System.Drawing.Size(38, 42);
            this.logoutbtnbuyer.TabIndex = 1;
            // 
            // buyerpicture
            // 
            this.buyerpicture.BaseColor = System.Drawing.Color.White;
            this.buyerpicture.Image = global::EliteEstates.Properties.Resources._10426713;
            this.buyerpicture.Location = new System.Drawing.Point(61, 24);
            this.buyerpicture.Name = "buyerpicture";
            this.buyerpicture.Size = new System.Drawing.Size(95, 74);
            this.buyerpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buyerpicture.TabIndex = 0;
            this.buyerpicture.TabStop = false;
            this.buyerpicture.UseTransfarantBackground = false;
            // 
            // BuyerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 547);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.buybtn);
            this.Controls.Add(this.Buyerbalance);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "BuyerDashboard";
            this.Text = "BuyerDashboard";
            this.Buyerbalance.ResumeLayout(false);
            this.Buyerbalance.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton deletebtn;
        private Guna.UI.WinForms.GunaButton buybtn;
        private Guna.UI.WinForms.GunaElipsePanel Buyerbalance;
        private System.Windows.Forms.Label Currentbalancebuyer;
        private System.Windows.Forms.Label currentbalancebuyerlbl;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaImageButton searchbtnbuyer;
        private System.Windows.Forms.Label searchbarlblb;
        private Guna.UI.WinForms.GunaImageButton logoutbtnbuyer;
        private Guna.UI.WinForms.GunaLineTextBox buyersearchbartxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton Addcash;
        private Guna.UI.WinForms.GunaButton sendcomplaintbtnbuyer;
        private Guna.UI.WinForms.GunaButton Transectionbtnbuyer;
        private Guna.UI.WinForms.GunaButton editbtnbuyer;
        private System.Windows.Forms.Label bnamelbl;
        private Guna.UI.WinForms.GunaCirclePictureBox buyerpicture;
    }
}