
namespace TungMovie
{
    partial class Chat
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
			this.labelRegister = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.gridListMV = new System.Windows.Forms.DataGridView();
			this.btnSend = new TungMovie.RButton();
			((System.ComponentModel.ISupportInitialize)(this.gridListMV)).BeginInit();
			this.SuspendLayout();
			// 
			// labelRegister
			// 
			this.labelRegister.AutoSize = true;
			this.labelRegister.Font = new System.Drawing.Font("VNI-Cooper", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.labelRegister.Location = new System.Drawing.Point(34, 12);
			this.labelRegister.Name = "labelRegister";
			this.labelRegister.Size = new System.Drawing.Size(89, 39);
			this.labelRegister.TabIndex = 30;
			this.labelRegister.Text = "Chat";
			// 
			// txtSearch
			// 
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Location = new System.Drawing.Point(92, 422);
			this.txtSearch.Multiline = true;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(669, 33);
			this.txtSearch.TabIndex = 27;
			// 
			// gridListMV
			// 
			this.gridListMV.AllowUserToAddRows = false;
			this.gridListMV.AllowUserToDeleteRows = false;
			this.gridListMV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridListMV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridListMV.Location = new System.Drawing.Point(92, 54);
			this.gridListMV.Name = "gridListMV";
			this.gridListMV.ReadOnly = true;
			this.gridListMV.RowHeadersVisible = false;
			this.gridListMV.RowHeadersWidth = 51;
			this.gridListMV.Size = new System.Drawing.Size(776, 341);
			this.gridListMV.TabIndex = 26;
			// 
			// btnSend
			// 
			this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.btnSend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.btnSend.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.btnSend.BorderRadius = 10;
			this.btnSend.BorderSize = 0;
			this.btnSend.FlatAppearance.BorderSize = 0;
			this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSend.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSend.ForeColor = System.Drawing.Color.White;
			this.btnSend.Location = new System.Drawing.Point(768, 418);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(111, 40);
			this.btnSend.TabIndex = 150;
			this.btnSend.Text = "Send";
			this.btnSend.TextColor = System.Drawing.Color.White;
			this.btnSend.UseVisualStyleBackColor = false;
			// 
			// Chat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(956, 479);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.labelRegister);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.gridListMV);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Chat";
			this.Text = "Chat";
			((System.ComponentModel.ISupportInitialize)(this.gridListMV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView gridListMV;
		private RButton btnSend;
	}
}