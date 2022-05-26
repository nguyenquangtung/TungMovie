
namespace TungMovie
{
	partial class PanelListMovie
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbTitle = new System.Windows.Forms.Label();
			this.lbGenre = new System.Windows.Forms.Label();
			this.lbRating = new System.Windows.Forms.Label();
			this.LbDuaration = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.Location = new System.Drawing.Point(273, 17);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(389, 103);
			this.lbTitle.TabIndex = 1;
			this.lbTitle.Text = "Title";
			// 
			// lbGenre
			// 
			this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGenre.Location = new System.Drawing.Point(274, 98);
			this.lbGenre.Name = "lbGenre";
			this.lbGenre.Size = new System.Drawing.Size(313, 25);
			this.lbGenre.TabIndex = 2;
			this.lbGenre.Text = "Genre";
			// 
			// lbRating
			// 
			this.lbRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbRating.Location = new System.Drawing.Point(274, 144);
			this.lbRating.Name = "lbRating";
			this.lbRating.Size = new System.Drawing.Size(316, 25);
			this.lbRating.TabIndex = 3;
			this.lbRating.Text = "Rating";
			// 
			// LbDuaration
			// 
			this.LbDuaration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbDuaration.Location = new System.Drawing.Point(274, 183);
			this.LbDuaration.Name = "LbDuaration";
			this.LbDuaration.Size = new System.Drawing.Size(347, 25);
			this.LbDuaration.TabIndex = 4;
			this.LbDuaration.Text = "Duaration";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(13, 17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(185, 204);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(211, 233);
			this.panel1.TabIndex = 5;
			// 
			// PanelListMovie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LavenderBlush;
			this.Controls.Add(this.LbDuaration);
			this.Controls.Add(this.lbRating);
			this.Controls.Add(this.lbGenre);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Name = "PanelListMovie";
			this.Size = new System.Drawing.Size(719, 244);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Label lbGenre;
		private System.Windows.Forms.Label lbRating;
		private System.Windows.Forms.Label LbDuaration;
		private System.Windows.Forms.Panel panel1;
	}
}
