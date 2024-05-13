namespace EliteEstates
{
    partial class SeeComplain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Complaingrid = new Guna.UI.WinForms.GunaDataGridView();
            this.idColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderidColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backbtncomplain = new Guna.UI.WinForms.GunaImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.Complaingrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.gunaLabel1.Location = new System.Drawing.Point(27, 41);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(221, 32);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "ComplainBox :";
            // 
            // Complaingrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Complaingrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Complaingrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Complaingrid.BackgroundColor = System.Drawing.Color.White;
            this.Complaingrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Complaingrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Complaingrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Complaingrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Complaingrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Complaingrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn1,
            this.complainColumn1,
            this.senderidColumn1,
            this.datecolumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Complaingrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Complaingrid.EnableHeadersVisualStyles = false;
            this.Complaingrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Complaingrid.Location = new System.Drawing.Point(58, 157);
            this.Complaingrid.Name = "Complaingrid";
            this.Complaingrid.RowHeadersVisible = false;
            this.Complaingrid.RowHeadersWidth = 51;
            this.Complaingrid.RowTemplate.Height = 24;
            this.Complaingrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Complaingrid.Size = new System.Drawing.Size(617, 285);
            this.Complaingrid.TabIndex = 1;
            this.Complaingrid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.Complaingrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Complaingrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Complaingrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Complaingrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Complaingrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Complaingrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Complaingrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Complaingrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Complaingrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Complaingrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Complaingrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Complaingrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Complaingrid.ThemeStyle.HeaderStyle.Height = 27;
            this.Complaingrid.ThemeStyle.ReadOnly = false;
            this.Complaingrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Complaingrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Complaingrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Complaingrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Complaingrid.ThemeStyle.RowsStyle.Height = 24;
            this.Complaingrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Complaingrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idColumn1
            // 
            this.idColumn1.HeaderText = "ComplainID";
            this.idColumn1.MinimumWidth = 6;
            this.idColumn1.Name = "idColumn1";
            // 
            // complainColumn1
            // 
            this.complainColumn1.HeaderText = "Complain";
            this.complainColumn1.MinimumWidth = 6;
            this.complainColumn1.Name = "complainColumn1";
            // 
            // senderidColumn1
            // 
            this.senderidColumn1.HeaderText = "SenderID";
            this.senderidColumn1.MinimumWidth = 6;
            this.senderidColumn1.Name = "senderidColumn1";
            // 
            // datecolumn
            // 
            this.datecolumn.HeaderText = "Date";
            this.datecolumn.MinimumWidth = 6;
            this.datecolumn.Name = "datecolumn";
            // 
            // backbtncomplain
            // 
            this.backbtncomplain.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backbtncomplain.Image = global::EliteEstates.Properties.Resources.backbutton;
            this.backbtncomplain.ImageSize = new System.Drawing.Size(64, 64);
            this.backbtncomplain.Location = new System.Drawing.Point(683, 24);
            this.backbtncomplain.Name = "backbtncomplain";
            this.backbtncomplain.OnHoverImage = null;
            this.backbtncomplain.OnHoverImageOffset = new System.Drawing.Point(5, -1);
            this.backbtncomplain.Size = new System.Drawing.Size(41, 32);
            this.backbtncomplain.TabIndex = 17;
            this.backbtncomplain.Click += new System.EventHandler(this.backbtncomplain_Click);
            // 
            // SeeComplain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(755, 488);
            this.Controls.Add(this.backbtncomplain);
            this.Controls.Add(this.Complaingrid);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "SeeComplain";
            this.Text = "SeeComplain";
            ((System.ComponentModel.ISupportInitialize)(this.Complaingrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView Complaingrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderidColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecolumn;
        private Guna.UI.WinForms.GunaImageButton backbtncomplain;
    }
}