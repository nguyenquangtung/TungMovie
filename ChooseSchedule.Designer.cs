
namespace TungMovie
{
    partial class ChooseSchedule
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
            ((System.ComponentModel.ISupportInitialize)(this.gridTicketManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // dateStartTime
            // 
            this.dateStartTime.CustomFormat = "   dd / MM / yyyy";
            this.dateStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.dateStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStartTime.Location = new System.Drawing.Point(232, 205);
            this.dateStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateStartTime.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateStartTime.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateStartTime.Name = "dateStartTime";
            this.dateStartTime.Size = new System.Drawing.Size(287, 26);
            this.dateStartTime.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 107;
            this.label2.Text = "Start Time";
            // 
            // boxScheduleId
            // 
            this.boxScheduleId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxScheduleId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxScheduleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.boxScheduleId.FormattingEnabled = true;
            this.boxScheduleId.ItemHeight = 20;
            this.boxScheduleId.Items.AddRange(new object[] {
            "find by id",
            "find by name"});
            this.boxScheduleId.Location = new System.Drawing.Point(232, 152);
            this.boxScheduleId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxScheduleId.Name = "boxScheduleId";
            this.boxScheduleId.Size = new System.Drawing.Size(135, 28);
            this.boxScheduleId.TabIndex = 106;
            // 
            // labelIdFilm
            // 
            this.labelIdFilm.AutoSize = true;
            this.labelIdFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdFilm.Location = new System.Drawing.Point(44, 152);
            this.labelIdFilm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdFilm.Name = "labelIdFilm";
            this.labelIdFilm.Size = new System.Drawing.Size(100, 20);
            this.labelIdFilm.TabIndex = 105;
            this.labelIdFilm.Text = "ID Schedule";
            // 
            // labelSched
            // 
            this.labelSched.AutoSize = true;
            this.labelSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSched.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelSched.Location = new System.Drawing.Point(19, 28);
            this.labelSched.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSched.Name = "labelSched";
            this.labelSched.Size = new System.Drawing.Size(302, 39);
            this.labelSched.TabIndex = 102;
            this.labelSched.Text = "Choose Schedule";
            this.labelSched.Click += new System.EventHandler(this.labelSched_Click);
            // 
            // gridTicketManagement
            // 
            this.gridTicketManagement.AllowUserToAddRows = false;
            this.gridTicketManagement.AllowUserToDeleteRows = false;
            this.gridTicketManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTicketManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTicketManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTicketManagement.Location = new System.Drawing.Point(535, 28);
            this.gridTicketManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridTicketManagement.Name = "gridTicketManagement";
            this.gridTicketManagement.ReadOnly = true;
            this.gridTicketManagement.RowHeadersVisible = false;
            this.gridTicketManagement.RowHeadersWidth = 51;
            this.gridTicketManagement.Size = new System.Drawing.Size(631, 457);
            this.gridTicketManagement.TabIndex = 101;
            // 
            // dateEndTime
            // 
            this.dateEndTime.CustomFormat = "   dd / MM / yyyy";
            this.dateEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.dateEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEndTime.Location = new System.Drawing.Point(232, 259);
            this.dateEndTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateEndTime.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateEndTime.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateEndTime.Name = "dateEndTime";
            this.dateEndTime.Size = new System.Drawing.Size(287, 26);
            this.dateEndTime.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 109;
            this.label3.Text = "End Time";
            // 
            // txtIdRoom
            // 
            this.txtIdRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtIdRoom.Location = new System.Drawing.Point(232, 355);
            this.txtIdRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdRoom.Name = "txtIdRoom";
            this.txtIdRoom.Size = new System.Drawing.Size(136, 19);
            this.txtIdRoom.TabIndex = 115;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 355);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 114;
            this.label7.Text = "ID Room";
            // 
            // txtIdMovie
            // 
            this.txtIdMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtIdMovie.Location = new System.Drawing.Point(232, 310);
            this.txtIdMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdMovie.Name = "txtIdMovie";
            this.txtIdMovie.Size = new System.Drawing.Size(136, 19);
            this.txtIdMovie.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 112;
            this.label4.Text = "ID Movie";
            // 
            // ChooseSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 506);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChooseSchedule";
            this.Text = "ScheduleManagement";
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
    }
}