
namespace TungMovie
{
    partial class Film_management
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
            this.gridFilmManagement = new System.Windows.Forms.DataGridView();
            this.labelFilmManagement = new System.Windows.Forms.Label();
            this.textRating = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.labelIdFilm = new System.Windows.Forms.Label();
            this.textFilmName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxFilmId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.dateStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateEndTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Schedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFilmManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFilmManagement
            // 
            this.gridFilmManagement.AllowUserToAddRows = false;
            this.gridFilmManagement.AllowUserToDeleteRows = false;
            this.gridFilmManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFilmManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridFilmManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFilmManagement.Location = new System.Drawing.Point(503, 15);
            this.gridFilmManagement.Margin = new System.Windows.Forms.Padding(4);
            this.gridFilmManagement.Name = "gridFilmManagement";
            this.gridFilmManagement.ReadOnly = true;
            this.gridFilmManagement.RowHeadersVisible = false;
            this.gridFilmManagement.RowHeadersWidth = 51;
            this.gridFilmManagement.Size = new System.Drawing.Size(928, 652);
            this.gridFilmManagement.TabIndex = 1;
            this.gridFilmManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFilmManagement_CellContentClick);
            // 
            // labelFilmManagement
            // 
            this.labelFilmManagement.AutoSize = true;
            this.labelFilmManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilmManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelFilmManagement.Location = new System.Drawing.Point(16, 15);
            this.labelFilmManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilmManagement.Name = "labelFilmManagement";
            this.labelFilmManagement.Size = new System.Drawing.Size(304, 39);
            this.labelFilmManagement.TabIndex = 20;
            this.labelFilmManagement.Text = "Film Management";
            // 
            // textRating
            // 
            this.textRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.textRating.Location = new System.Drawing.Point(208, 196);
            this.textRating.Margin = new System.Windows.Forms.Padding(4);
            this.textRating.Name = "textRating";
            this.textRating.Size = new System.Drawing.Size(93, 19);
            this.textRating.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Rating";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtDescription.Location = new System.Drawing.Point(208, 287);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(251, 74);
            this.txtDescription.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtGenre.Location = new System.Drawing.Point(208, 240);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(251, 19);
            this.txtGenre.TabIndex = 62;
            // 
            // labelIdFilm
            // 
            this.labelIdFilm.AutoSize = true;
            this.labelIdFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdFilm.Location = new System.Drawing.Point(20, 86);
            this.labelIdFilm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdFilm.Name = "labelIdFilm";
            this.labelIdFilm.Size = new System.Drawing.Size(63, 20);
            this.labelIdFilm.TabIndex = 61;
            this.labelIdFilm.Text = "ID Film";
            // 
            // textFilmName
            // 
            this.textFilmName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textFilmName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.textFilmName.Location = new System.Drawing.Point(208, 132);
            this.textFilmName.Margin = new System.Windows.Forms.Padding(4);
            this.textFilmName.Multiline = true;
            this.textFilmName.Name = "textFilmName";
            this.textFilmName.Size = new System.Drawing.Size(251, 38);
            this.textFilmName.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Name";
            // 
            // boxFilmId
            // 
            this.boxFilmId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxFilmId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxFilmId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.boxFilmId.FormattingEnabled = true;
            this.boxFilmId.ItemHeight = 20;
            this.boxFilmId.Items.AddRange(new object[] {
            "find by id",
            "find by name"});
            this.boxFilmId.Location = new System.Drawing.Point(208, 86);
            this.boxFilmId.Margin = new System.Windows.Forms.Padding(4);
            this.boxFilmId.Name = "boxFilmId";
            this.boxFilmId.Size = new System.Drawing.Size(92, 28);
            this.boxFilmId.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 425);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 380);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Short decription";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtDuration.Location = new System.Drawing.Point(208, 382);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(93, 19);
            this.txtDuration.TabIndex = 76;
            // 
            // dateStartTime
            // 
            this.dateStartTime.CustomFormat = "   dd / MM / yyyy ";
            this.dateStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.dateStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStartTime.Location = new System.Drawing.Point(208, 425);
            this.dateStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.dateStartTime.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateStartTime.MinDate = new System.DateTime(2010, 2, 23, 0, 0, 0, 0);
            this.dateStartTime.Name = "dateStartTime";
            this.dateStartTime.Size = new System.Drawing.Size(249, 26);
            this.dateStartTime.TabIndex = 77;
            // 
            // dateEndTime
            // 
            this.dateEndTime.CustomFormat = "   dd / MM / yyyy";
            this.dateEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.dateEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEndTime.Location = new System.Drawing.Point(208, 480);
            this.dateEndTime.Margin = new System.Windows.Forms.Padding(4);
            this.dateEndTime.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateEndTime.MinDate = new System.DateTime(2010, 12, 24, 0, 0, 0, 0);
            this.dateEndTime.Name = "dateEndTime";
            this.dateEndTime.Size = new System.Drawing.Size(249, 26);
            this.dateEndTime.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 480);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 78;
            this.label7.Text = "End Date";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(24, 546);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 49);
            this.btn_add.TabIndex = 82;
            this.btn_add.Text = "ADD FILM";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(325, 546);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 49);
            this.btn_delete.TabIndex = 83;
            this.btn_delete.Text = "DELETE FILM";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(173, 546);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(133, 49);
            this.btn_update.TabIndex = 84;
            this.btn_update.Text = "UPDATE FILM";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Schedule
            // 
            this.btn_Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Schedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Schedule.FlatAppearance.BorderSize = 0;
            this.btn_Schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Schedule.ForeColor = System.Drawing.Color.White;
            this.btn_Schedule.Location = new System.Drawing.Point(99, 618);
            this.btn_Schedule.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Schedule.Name = "btn_Schedule";
            this.btn_Schedule.Size = new System.Drawing.Size(286, 49);
            this.btn_Schedule.TabIndex = 85;
            this.btn_Schedule.Text = "SCHEDULE MANAGEMENT";
            this.btn_Schedule.UseVisualStyleBackColor = false;
            this.btn_Schedule.Click += new System.EventHandler(this.btn_Schedule_Click);
            // 
            // Film_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1444, 690);
            this.Controls.Add(this.btn_Schedule);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dateEndTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateStartTime);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxFilmId);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.labelIdFilm);
            this.Controls.Add(this.textFilmName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFilmManagement);
            this.Controls.Add(this.gridFilmManagement);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Film_management";
            this.Text = "Film_management";
            this.Load += new System.EventHandler(this.Film_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFilmManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFilmManagement;
        private System.Windows.Forms.Label labelFilmManagement;
        private System.Windows.Forms.TextBox textRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label labelIdFilm;
        private System.Windows.Forms.TextBox textFilmName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxFilmId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.DateTimePicker dateStartTime;
        private System.Windows.Forms.DateTimePicker dateEndTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Schedule;
    }
}