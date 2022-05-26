
namespace TungMovie
{
    partial class TicketManagement
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
            this.btnViewTicket = new System.Windows.Forms.Button();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.dateBookingDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.boxTicketId = new System.Windows.Forms.ComboBox();
            this.txtIdSchedule = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelIdFilm = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTicketManagement = new System.Windows.Forms.Label();
            this.txtIdStatistic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdSeat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gridTicketManagement = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridTicketManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewTicket
            // 
            this.btnViewTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnViewTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewTicket.FlatAppearance.BorderSize = 0;
            this.btnViewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTicket.ForeColor = System.Drawing.Color.White;
            this.btnViewTicket.Location = new System.Drawing.Point(173, 436);
            this.btnViewTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewTicket.Name = "btnViewTicket";
            this.btnViewTicket.Size = new System.Drawing.Size(133, 49);
            this.btnViewTicket.TabIndex = 107;
            this.btnViewTicket.Text = "VIEW TICKET";
            this.btnViewTicket.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUpdatePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePrice.FlatAppearance.BorderSize = 0;
            this.btnUpdatePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePrice.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePrice.Location = new System.Drawing.Point(325, 436);
            this.btnUpdatePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(133, 49);
            this.btnUpdatePrice.TabIndex = 106;
            this.btnUpdatePrice.Text = "UPDATE PRICE";
            this.btnUpdatePrice.UseVisualStyleBackColor = false;
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAddTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTicket.FlatAppearance.BorderSize = 0;
            this.btnAddTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTicket.ForeColor = System.Drawing.Color.White;
            this.btnAddTicket.Location = new System.Drawing.Point(24, 436);
            this.btnAddTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(133, 49);
            this.btnAddTicket.TabIndex = 105;
            this.btnAddTicket.Text = "ADD TICKET";
            this.btnAddTicket.UseVisualStyleBackColor = false;
            // 
            // dateBookingDate
            // 
            this.dateBookingDate.CustomFormat = "   dd / MM / yyyy";
            this.dateBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.dateBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBookingDate.Location = new System.Drawing.Point(208, 192);
            this.dateBookingDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateBookingDate.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateBookingDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateBookingDate.Name = "dateBookingDate";
            this.dateBookingDate.Size = new System.Drawing.Size(249, 26);
            this.dateBookingDate.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 96;
            this.label2.Text = "Booking Date";
            // 
            // boxTicketId
            // 
            this.boxTicketId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxTicketId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxTicketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.boxTicketId.FormattingEnabled = true;
            this.boxTicketId.ItemHeight = 20;
            this.boxTicketId.Items.AddRange(new object[] {
            "find by id",
            "find by name"});
            this.boxTicketId.Location = new System.Drawing.Point(208, 86);
            this.boxTicketId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxTicketId.Name = "boxTicketId";
            this.boxTicketId.Size = new System.Drawing.Size(92, 28);
            this.boxTicketId.TabIndex = 95;
            // 
            // txtIdSchedule
            // 
            this.txtIdSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtIdSchedule.Location = new System.Drawing.Point(208, 284);
            this.txtIdSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdSchedule.Name = "txtIdSchedule";
            this.txtIdSchedule.Size = new System.Drawing.Size(93, 19);
            this.txtIdSchedule.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "ID Schedule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 91;
            this.label3.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtUsername.Location = new System.Drawing.Point(208, 241);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(251, 19);
            this.txtUsername.TabIndex = 90;
            // 
            // labelIdFilm
            // 
            this.labelIdFilm.AutoSize = true;
            this.labelIdFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdFilm.Location = new System.Drawing.Point(20, 86);
            this.labelIdFilm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdFilm.Name = "labelIdFilm";
            this.labelIdFilm.Size = new System.Drawing.Size(76, 20);
            this.labelIdFilm.TabIndex = 89;
            this.labelIdFilm.Text = "ID Ticket";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtPrice.Location = new System.Drawing.Point(208, 132);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(251, 38);
            this.txtPrice.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Price";
            // 
            // labelTicketManagement
            // 
            this.labelTicketManagement.AutoSize = true;
            this.labelTicketManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelTicketManagement.Location = new System.Drawing.Point(16, 15);
            this.labelTicketManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTicketManagement.Name = "labelTicketManagement";
            this.labelTicketManagement.Size = new System.Drawing.Size(332, 39);
            this.labelTicketManagement.TabIndex = 86;
            this.labelTicketManagement.Text = "Ticket Management";
            // 
            // txtIdStatistic
            // 
            this.txtIdStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdStatistic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtIdStatistic.Location = new System.Drawing.Point(208, 369);
            this.txtIdStatistic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdStatistic.Name = "txtIdStatistic";
            this.txtIdStatistic.Size = new System.Drawing.Size(93, 19);
            this.txtIdStatistic.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 369);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 108;
            this.label6.Text = "ID Statistic";
            // 
            // txtIdSeat
            // 
            this.txtIdSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdSeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtIdSeat.Location = new System.Drawing.Point(208, 327);
            this.txtIdSeat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdSeat.Name = "txtIdSeat";
            this.txtIdSeat.Size = new System.Drawing.Size(93, 19);
            this.txtIdSeat.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 327);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 110;
            this.label7.Text = "ID Seat";
            // 
            // gridTicketManagement
            // 
            this.gridTicketManagement.AllowUserToAddRows = false;
            this.gridTicketManagement.AllowUserToDeleteRows = false;
            this.gridTicketManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTicketManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTicketManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTicketManagement.Location = new System.Drawing.Point(503, 15);
            this.gridTicketManagement.Margin = new System.Windows.Forms.Padding(4);
            this.gridTicketManagement.Name = "gridTicketManagement";
            this.gridTicketManagement.ReadOnly = true;
            this.gridTicketManagement.RowHeadersVisible = false;
            this.gridTicketManagement.RowHeadersWidth = 51;
            this.gridTicketManagement.Size = new System.Drawing.Size(667, 470);
            this.gridTicketManagement.TabIndex = 85;
            // 
            // TicketManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 502);
            this.Controls.Add(this.txtIdSeat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdStatistic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnViewTicket);
            this.Controls.Add(this.btnUpdatePrice);
            this.Controls.Add(this.btnAddTicket);
            this.Controls.Add(this.dateBookingDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxTicketId);
            this.Controls.Add(this.txtIdSchedule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelIdFilm);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTicketManagement);
            this.Controls.Add(this.gridTicketManagement);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TicketManagement";
            this.Text = "TicketManagement";
            ((System.ComponentModel.ISupportInitialize)(this.gridTicketManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewTicket;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.DateTimePicker dateBookingDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxTicketId;
        private System.Windows.Forms.TextBox txtIdSchedule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labelIdFilm;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTicketManagement;
        private System.Windows.Forms.TextBox txtIdStatistic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdSeat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridTicketManagement;
    }
}