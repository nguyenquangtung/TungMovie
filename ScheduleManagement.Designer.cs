
namespace TungMovie
{
    partial class ScheduleManagement
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
			this.dateStartTime = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.boxScheduleId = new System.Windows.Forms.ComboBox();
			this.labelIdFilm = new System.Windows.Forms.Label();
			this.labelSched = new System.Windows.Forms.Label();
			this.gridTicketManagement = new System.Windows.Forms.DataGridView();
			this.dateEndTime = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIdRoom = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtIdMovie = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAddSchedule = new TungMovie.RButton();
			this.btnDeleteSchedule = new TungMovie.RButton();
			this.btnUpdateSchedule = new TungMovie.RButton();
			this.btnViewSchedule = new TungMovie.RButton();
			((System.ComponentModel.ISupportInitialize)(this.gridTicketManagement)).BeginInit();
			this.SuspendLayout();
			// 
			// dateStartTime
			// 
			this.dateStartTime.CustomFormat = "dd / MM / yyyy HH:mm:ss";
			this.dateStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
			this.dateStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateStartTime.Location = new System.Drawing.Point(158, 124);
			this.dateStartTime.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
			this.dateStartTime.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
			this.dateStartTime.Name = "dateStartTime";
			this.dateStartTime.Size = new System.Drawing.Size(191, 22);
			this.dateStartTime.TabIndex = 108;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 16);
			this.label2.TabIndex = 107;
			this.label2.Text = "Start Time";
			// 
			// boxScheduleId
			// 
			this.boxScheduleId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
			this.boxScheduleId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.boxScheduleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
			this.boxScheduleId.FormattingEnabled = true;
			this.boxScheduleId.ItemHeight = 16;
			this.boxScheduleId.Items.AddRange(new object[] {
            "find by id",
            "find by name"});
			this.boxScheduleId.Location = new System.Drawing.Point(158, 81);
			this.boxScheduleId.Name = "boxScheduleId";
			this.boxScheduleId.Size = new System.Drawing.Size(70, 24);
			this.boxScheduleId.TabIndex = 106;
			this.boxScheduleId.SelectedIndexChanged += new System.EventHandler(this.boxScheduleId_SelectedIndexChanged);
			// 
			// labelIdFilm
			// 
			this.labelIdFilm.AutoSize = true;
			this.labelIdFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIdFilm.Location = new System.Drawing.Point(17, 81);
			this.labelIdFilm.Name = "labelIdFilm";
			this.labelIdFilm.Size = new System.Drawing.Size(81, 16);
			this.labelIdFilm.TabIndex = 105;
			this.labelIdFilm.Text = "ID Schedule";
			// 
			// labelSched
			// 
			this.labelSched.AutoSize = true;
			this.labelSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSched.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.labelSched.Location = new System.Drawing.Point(14, 23);
			this.labelSched.Name = "labelSched";
			this.labelSched.Size = new System.Drawing.Size(310, 31);
			this.labelSched.TabIndex = 102;
			this.labelSched.Text = "Schedule Management";
			// 
			// gridTicketManagement
			// 
			this.gridTicketManagement.AllowUserToAddRows = false;
			this.gridTicketManagement.AllowUserToDeleteRows = false;
			this.gridTicketManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridTicketManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridTicketManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridTicketManagement.Location = new System.Drawing.Point(401, 23);
			this.gridTicketManagement.Name = "gridTicketManagement";
			this.gridTicketManagement.ReadOnly = true;
			this.gridTicketManagement.RowHeadersVisible = false;
			this.gridTicketManagement.RowHeadersWidth = 51;
			this.gridTicketManagement.Size = new System.Drawing.Size(473, 371);
			this.gridTicketManagement.TabIndex = 101;
			// 
			// dateEndTime
			// 
			this.dateEndTime.CustomFormat = "dd / MM / yyyy HH:mm:ss";
			this.dateEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
			this.dateEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateEndTime.Location = new System.Drawing.Point(158, 168);
			this.dateEndTime.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
			this.dateEndTime.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
			this.dateEndTime.Name = "dateEndTime";
			this.dateEndTime.Size = new System.Drawing.Size(191, 22);
			this.dateEndTime.TabIndex = 110;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 16);
			this.label3.TabIndex = 109;
			this.label3.Text = "End Time";
			// 
			// txtIdRoom
			// 
			this.txtIdRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
			this.txtIdRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtIdRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
			this.txtIdRoom.Location = new System.Drawing.Point(158, 246);
			this.txtIdRoom.Name = "txtIdRoom";
			this.txtIdRoom.Size = new System.Drawing.Size(70, 15);
			this.txtIdRoom.TabIndex = 115;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(17, 246);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 16);
			this.label7.TabIndex = 114;
			this.label7.Text = "ID Room";
			// 
			// txtIdMovie
			// 
			this.txtIdMovie.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.txtIdMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
			this.txtIdMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtIdMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
			this.txtIdMovie.Location = new System.Drawing.Point(158, 210);
			this.txtIdMovie.Name = "txtIdMovie";
			this.txtIdMovie.Size = new System.Drawing.Size(70, 15);
			this.txtIdMovie.TabIndex = 113;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(17, 210);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 16);
			this.label4.TabIndex = 112;
			this.label4.Text = "ID Movie";
			// 
			// btnAddSchedule
			// 
			this.btnAddSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.btnAddSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.btnAddSchedule.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.btnAddSchedule.BorderRadius = 10;
			this.btnAddSchedule.BorderSize = 0;
			this.btnAddSchedule.FlatAppearance.BorderSize = 0;
			this.btnAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddSchedule.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddSchedule.ForeColor = System.Drawing.Color.White;
			this.btnAddSchedule.Location = new System.Drawing.Point(37, 286);
			this.btnAddSchedule.Name = "btnAddSchedule";
			this.btnAddSchedule.Size = new System.Drawing.Size(121, 48);
			this.btnAddSchedule.TabIndex = 197;
			this.btnAddSchedule.Text = "ADD ROOM";
			this.btnAddSchedule.TextColor = System.Drawing.Color.White;
			this.btnAddSchedule.UseVisualStyleBackColor = false;
			this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
			// 
			// btnDeleteSchedule
			// 
			this.btnDeleteSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.btnDeleteSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.btnDeleteSchedule.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.btnDeleteSchedule.BorderRadius = 10;
			this.btnDeleteSchedule.BorderSize = 0;
			this.btnDeleteSchedule.FlatAppearance.BorderSize = 0;
			this.btnDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteSchedule.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteSchedule.ForeColor = System.Drawing.Color.White;
			this.btnDeleteSchedule.Location = new System.Drawing.Point(214, 286);
			this.btnDeleteSchedule.Name = "btnDeleteSchedule";
			this.btnDeleteSchedule.Size = new System.Drawing.Size(135, 48);
			this.btnDeleteSchedule.TabIndex = 198;
			this.btnDeleteSchedule.Text = "DELETE SCHEDULE";
			this.btnDeleteSchedule.TextColor = System.Drawing.Color.White;
			this.btnDeleteSchedule.UseVisualStyleBackColor = false;
			this.btnDeleteSchedule.Click += new System.EventHandler(this.btnDeleteSchedule_Click);
			// 
			// btnUpdateSchedule
			// 
			this.btnUpdateSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.btnUpdateSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.btnUpdateSchedule.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.btnUpdateSchedule.BorderRadius = 10;
			this.btnUpdateSchedule.BorderSize = 0;
			this.btnUpdateSchedule.FlatAppearance.BorderSize = 0;
			this.btnUpdateSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateSchedule.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateSchedule.ForeColor = System.Drawing.Color.White;
			this.btnUpdateSchedule.Location = new System.Drawing.Point(214, 340);
			this.btnUpdateSchedule.Name = "btnUpdateSchedule";
			this.btnUpdateSchedule.Size = new System.Drawing.Size(135, 48);
			this.btnUpdateSchedule.TabIndex = 199;
			this.btnUpdateSchedule.Text = "UPDATE SCHEDULE";
			this.btnUpdateSchedule.TextColor = System.Drawing.Color.White;
			this.btnUpdateSchedule.UseVisualStyleBackColor = false;
			this.btnUpdateSchedule.Click += new System.EventHandler(this.btnUpdateSchedule_Click);
			// 
			// btnViewSchedule
			// 
			this.btnViewSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.btnViewSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.btnViewSchedule.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.btnViewSchedule.BorderRadius = 10;
			this.btnViewSchedule.BorderSize = 0;
			this.btnViewSchedule.FlatAppearance.BorderSize = 0;
			this.btnViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnViewSchedule.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewSchedule.ForeColor = System.Drawing.Color.White;
			this.btnViewSchedule.Location = new System.Drawing.Point(37, 340);
			this.btnViewSchedule.Name = "btnViewSchedule";
			this.btnViewSchedule.Size = new System.Drawing.Size(121, 48);
			this.btnViewSchedule.TabIndex = 200;
			this.btnViewSchedule.Text = "VIEW SCHEDULE";
			this.btnViewSchedule.TextColor = System.Drawing.Color.White;
			this.btnViewSchedule.UseVisualStyleBackColor = false;
			this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
			// 
			// ScheduleManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(886, 411);
			this.Controls.Add(this.btnViewSchedule);
			this.Controls.Add(this.btnUpdateSchedule);
			this.Controls.Add(this.btnDeleteSchedule);
			this.Controls.Add(this.btnAddSchedule);
			this.Controls.Add(this.txtIdRoom);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtIdMovie);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dateEndTime);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dateStartTime);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.boxScheduleId);
			this.Controls.Add(this.labelIdFilm);
			this.Controls.Add(this.labelSched);
			this.Controls.Add(this.gridTicketManagement);
			this.Name = "ScheduleManagement";
			this.Text = "ScheduleManagement";
			this.Load += new System.EventHandler(this.ScheduleManagement_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridTicketManagement)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxScheduleId;
        private System.Windows.Forms.Label labelIdFilm;
        private System.Windows.Forms.Label labelSched;
        private System.Windows.Forms.DataGridView gridTicketManagement;
        private System.Windows.Forms.DateTimePicker dateEndTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdMovie;
        private System.Windows.Forms.Label label4;
		private RButton btnAddSchedule;
		private RButton btnDeleteSchedule;
		private RButton btnUpdateSchedule;
		private RButton btnViewSchedule;
	}
}