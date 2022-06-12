
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
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.dateBookingDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.boxTicketId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelIdFilm = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTicketManagement = new System.Windows.Forms.Label();
            this.txtIdRoom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gridTicketManagement = new System.Windows.Forms.DataGridView();
            this.boxIdSchedule = new System.Windows.Forms.ComboBox();
            this.boxUsername = new System.Windows.Forms.ComboBox();
            this.boxIdSeat = new System.Windows.Forms.ComboBox();
            this.timeBookingDate = new System.Windows.Forms.DateTimePicker();
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
            this.btnViewTicket.Location = new System.Drawing.Point(126, 354);
            this.btnViewTicket.Name = "btnViewTicket";
            this.btnViewTicket.Size = new System.Drawing.Size(100, 40);
            this.btnViewTicket.TabIndex = 107;
            this.btnViewTicket.Text = "VIEW TICKET";
            this.btnViewTicket.UseVisualStyleBackColor = false;
            this.btnViewTicket.Click += new System.EventHandler(this.btnViewTicket_Click);
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUpdateTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateTicket.FlatAppearance.BorderSize = 0;
            this.btnUpdateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTicket.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTicket.Location = new System.Drawing.Point(244, 354);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(100, 40);
            this.btnUpdateTicket.TabIndex = 106;
            this.btnUpdateTicket.Text = "UPDATE TICKET";
            this.btnUpdateTicket.UseVisualStyleBackColor = false;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAddTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTicket.FlatAppearance.BorderSize = 0;
            this.btnAddTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTicket.ForeColor = System.Drawing.Color.White;
            this.btnAddTicket.Location = new System.Drawing.Point(18, 354);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(87, 40);
            this.btnAddTicket.TabIndex = 105;
            this.btnAddTicket.Text = "ADD TICKET";
            this.btnAddTicket.UseVisualStyleBackColor = false;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // dateBookingDate
            // 
            this.dateBookingDate.CustomFormat = "dd/MM/yyyy";
            this.dateBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBookingDate.Location = new System.Drawing.Point(156, 156);
            this.dateBookingDate.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateBookingDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateBookingDate.Name = "dateBookingDate";
            this.dateBookingDate.Size = new System.Drawing.Size(125, 24);
            this.dateBookingDate.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "Booking Date";
            // 
            // boxTicketId
            // 
            this.boxTicketId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxTicketId.DropDownHeight = 96;
            this.boxTicketId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxTicketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.boxTicketId.FormattingEnabled = true;
            this.boxTicketId.IntegralHeight = false;
            this.boxTicketId.ItemHeight = 18;
            this.boxTicketId.Items.AddRange(new object[] {
            "find by id",
            "find by name"});
            this.boxTicketId.Location = new System.Drawing.Point(156, 70);
            this.boxTicketId.Name = "boxTicketId";
            this.boxTicketId.Size = new System.Drawing.Size(70, 26);
            this.boxTicketId.TabIndex = 95;
            this.boxTicketId.SelectedIndexChanged += new System.EventHandler(this.boxTicketId_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 93;
            this.label4.Text = "ID Schedule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 91;
            this.label3.Text = "Username";
            // 
            // labelIdFilm
            // 
            this.labelIdFilm.AutoSize = true;
            this.labelIdFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdFilm.Location = new System.Drawing.Point(15, 70);
            this.labelIdFilm.Name = "labelIdFilm";
            this.labelIdFilm.Size = new System.Drawing.Size(61, 16);
            this.labelIdFilm.TabIndex = 89;
            this.labelIdFilm.Text = "ID Ticket";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPrice.Location = new System.Drawing.Point(156, 107);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 31);
            this.txtPrice.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 87;
            this.label1.Text = "Price";
            // 
            // labelTicketManagement
            // 
            this.labelTicketManagement.AutoSize = true;
            this.labelTicketManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelTicketManagement.Location = new System.Drawing.Point(12, 12);
            this.labelTicketManagement.Name = "labelTicketManagement";
            this.labelTicketManagement.Size = new System.Drawing.Size(269, 31);
            this.labelTicketManagement.TabIndex = 86;
            this.labelTicketManagement.Text = "Ticket Management";
            // 
            // txtIdRoom
            // 
            this.txtIdRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtIdRoom.Location = new System.Drawing.Point(156, 300);
            this.txtIdRoom.Name = "txtIdRoom";
            this.txtIdRoom.Size = new System.Drawing.Size(70, 17);
            this.txtIdRoom.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 108;
            this.label6.Text = "ID Room";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 110;
            this.label7.Text = "ID Seat";
            // 
            // gridTicketManagement
            // 
            this.gridTicketManagement.AllowUserToAddRows = false;
            this.gridTicketManagement.AllowUserToDeleteRows = false;
            this.gridTicketManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTicketManagement.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridTicketManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTicketManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTicketManagement.Location = new System.Drawing.Point(414, 12);
            this.gridTicketManagement.Name = "gridTicketManagement";
            this.gridTicketManagement.ReadOnly = true;
            this.gridTicketManagement.RowHeadersVisible = false;
            this.gridTicketManagement.RowHeadersWidth = 51;
            this.gridTicketManagement.Size = new System.Drawing.Size(628, 382);
            this.gridTicketManagement.TabIndex = 85;
            // 
            // boxIdSchedule
            // 
            this.boxIdSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxIdSchedule.DropDownHeight = 96;
            this.boxIdSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxIdSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.boxIdSchedule.FormattingEnabled = true;
            this.boxIdSchedule.IntegralHeight = false;
            this.boxIdSchedule.ItemHeight = 18;
            this.boxIdSchedule.Items.AddRange(new object[] {
            "find by id",
            "find by name"});
            this.boxIdSchedule.Location = new System.Drawing.Point(156, 192);
            this.boxIdSchedule.Name = "boxIdSchedule";
            this.boxIdSchedule.Size = new System.Drawing.Size(70, 26);
            this.boxIdSchedule.TabIndex = 111;
            // 
            // boxUsername
            // 
            this.boxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxUsername.DropDownHeight = 96;
            this.boxUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.boxUsername.FormattingEnabled = true;
            this.boxUsername.IntegralHeight = false;
            this.boxUsername.ItemHeight = 18;
            this.boxUsername.Items.AddRange(new object[] {
            "find by id",
            "find by name"});
            this.boxUsername.Location = new System.Drawing.Point(156, 226);
            this.boxUsername.Name = "boxUsername";
            this.boxUsername.Size = new System.Drawing.Size(125, 26);
            this.boxUsername.TabIndex = 112;
            // 
            // boxIdSeat
            // 
            this.boxIdSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxIdSeat.DropDownHeight = 96;
            this.boxIdSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxIdSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.boxIdSeat.FormattingEnabled = true;
            this.boxIdSeat.IntegralHeight = false;
            this.boxIdSeat.ItemHeight = 18;
            this.boxIdSeat.Items.AddRange(new object[] {
            "find by id",
            "find by name"});
            this.boxIdSeat.Location = new System.Drawing.Point(156, 261);
            this.boxIdSeat.Name = "boxIdSeat";
            this.boxIdSeat.Size = new System.Drawing.Size(70, 26);
            this.boxIdSeat.TabIndex = 113;
            // 
            // timeBookingDate
            // 
            this.timeBookingDate.CustomFormat = "HH:mm:ss";
            this.timeBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeBookingDate.Location = new System.Drawing.Point(287, 156);
            this.timeBookingDate.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.timeBookingDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.timeBookingDate.Name = "timeBookingDate";
            this.timeBookingDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeBookingDate.ShowUpDown = true;
            this.timeBookingDate.Size = new System.Drawing.Size(95, 24);
            this.timeBookingDate.TabIndex = 114;
            // 
            // TicketManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 406);
            this.Controls.Add(this.timeBookingDate);
            this.Controls.Add(this.boxIdSeat);
            this.Controls.Add(this.boxUsername);
            this.Controls.Add(this.boxIdSchedule);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdRoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnViewTicket);
            this.Controls.Add(this.btnUpdateTicket);
            this.Controls.Add(this.btnAddTicket);
            this.Controls.Add(this.dateBookingDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxTicketId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelIdFilm);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTicketManagement);
            this.Controls.Add(this.gridTicketManagement);
            this.Name = "TicketManagement";
            this.Text = "TicketManagement";
            this.Load += new System.EventHandler(this.TicketManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTicketManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewTicket;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.DateTimePicker dateBookingDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxTicketId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelIdFilm;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTicketManagement;
        private System.Windows.Forms.TextBox txtIdRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridTicketManagement;
        private System.Windows.Forms.ComboBox boxIdSchedule;
        private System.Windows.Forms.ComboBox boxUsername;
        private System.Windows.Forms.ComboBox boxIdSeat;
        private System.Windows.Forms.DateTimePicker timeBookingDate;
    }
}