
namespace TungMovie
{
	partial class ListCharater
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
			this.btnSearch = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.gridListChr = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridListChr)).BeginInit();
			this.SuspendLayout();
			// 
			// labelRegister
			// 
			this.labelRegister.AutoSize = true;
			this.labelRegister.Font = new System.Drawing.Font("VNI-Cooper", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.labelRegister.Location = new System.Drawing.Point(3, 9);
			this.labelRegister.Name = "labelRegister";
			this.labelRegister.Size = new System.Drawing.Size(169, 39);
			this.labelRegister.TabIndex = 26;
			this.labelRegister.Text = "Character";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(604, 57);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(88, 33);
			this.btnSearch.TabIndex = 30;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.ItemHeight = 13;
			this.comboBox1.Items.AddRange(new object[] {
            "find by id",
            "find by name"});
			this.comboBox1.Location = new System.Drawing.Point(480, 68);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 21);
			this.comboBox1.TabIndex = 29;
			// 
			// txtSearch
			// 
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Location = new System.Drawing.Point(65, 57);
			this.txtSearch.Multiline = true;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(392, 33);
			this.txtSearch.TabIndex = 28;
			// 
			// gridListChr
			// 
			this.gridListChr.AllowUserToAddRows = false;
			this.gridListChr.AllowUserToDeleteRows = false;
			this.gridListChr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridListChr.Location = new System.Drawing.Point(0, 116);
			this.gridListChr.Name = "gridListChr";
			this.gridListChr.ReadOnly = true;
			this.gridListChr.Size = new System.Drawing.Size(800, 330);
			this.gridListChr.TabIndex = 31;
			// 
			// ListCharater
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gridListChr);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.labelRegister);
			this.Name = "ListCharater";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ListCharater";
			((System.ComponentModel.ISupportInitialize)(this.gridListChr)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelRegister;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.DataGridView gridListChr;
	}
}