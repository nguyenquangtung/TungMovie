
namespace TungMovie
{
	partial class ListMovie2
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panelListMovie1 = new TungMovie.PanelListMovie();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.panelListMovie1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 82);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(832, 503);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// panelListMovie1
			// 
			this.panelListMovie1.BackColor = System.Drawing.Color.LavenderBlush;
			this.panelListMovie1.Duaration = null;
			this.panelListMovie1.Genre = null;
			this.panelListMovie1.Icon = null;
			this.panelListMovie1.Location = new System.Drawing.Point(5, 4);
			this.panelListMovie1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.panelListMovie1.Name = "panelListMovie1";
			this.panelListMovie1.Rating = null;
			this.panelListMovie1.Size = new System.Drawing.Size(672, 395);
			this.panelListMovie1.TabIndex = 0;
			this.panelListMovie1.Title = null;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(131, 32);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(337, 26);
			this.txtSearch.TabIndex = 1;
			// 
			// btnFind
			// 
			this.btnFind.Font = new System.Drawing.Font("VNI-Cooper", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.Location = new System.Drawing.Point(626, 32);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(88, 26);
			this.btnFind.TabIndex = 2;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Search:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(484, 31);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 27);
			this.comboBox1.TabIndex = 4;
			// 
			// ListMovie2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(832, 507);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Font = new System.Drawing.Font("VNI-Cooper", 9.749999F, System.Drawing.FontStyle.Bold);
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "ListMovie2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ListMovie2";
			this.Load += new System.EventHandler(this.ListMovie_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private PanelListMovie panelListMovie1;
	}
}