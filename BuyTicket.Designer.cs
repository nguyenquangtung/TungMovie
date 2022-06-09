
namespace TungMovie
{
    partial class BuyTicket
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
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.dateBookingDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdSchedule = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTicketManagement = new System.Windows.Forms.Label();
            this.txtIdStatistic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdSeat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnViewTicket
            // 
            this.btnViewTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnViewTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewTicket.FlatAppearance.BorderSize = 0;
            this.btnViewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTicket.ForeColor = System.Drawing.Color.White;
            this.btnViewTicket.Location = new System.Drawing.Point(244, 391);
            this.btnViewTicket.Name = "btnViewTicket";
            this.btnViewTicket.Size = new System.Drawing.Size(100, 40);
            this.btnViewTicket.TabIndex = 107;
            this.btnViewTicket.Text = "Cancel";
            this.btnViewTicket.UseVisualStyleBackColor = false;
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAddTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTicket.FlatAppearance.BorderSize = 0;
            this.btnAddTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTicket.ForeColor = System.Drawing.Color.White;
            this.btnAddTicket.Location = new System.Drawing.Point(18, 391);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(100, 40);
            this.btnAddTicket.TabIndex = 105;
            this.btnAddTicket.Text = "Buy";
            this.btnAddTicket.UseVisualStyleBackColor = false;
            // 
            // dateBookingDate
            // 
            this.dateBookingDate.CustomFormat = "   dd / MM / yyyy";
            this.dateBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.dateBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBookingDate.Location = new System.Drawing.Point(156, 130);
            this.dateBookingDate.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateBookingDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateBookingDate.Name = "dateBookingDate";
            this.dateBookingDate.Size = new System.Drawing.Size(188, 22);
            this.dateBookingDate.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "Booking Date";
            // 
            // txtIdSchedule
            // 
            this.txtIdSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtIdSchedule.Location = new System.Drawing.Point(156, 175);
            this.txtIdSchedule.Name = "txtIdSchedule";
            this.txtIdSchedule.Size = new System.Drawing.Size(70, 15);
            this.txtIdSchedule.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 93;
            this.label4.Text = "ID Schedule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 280);
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
            this.labelTicketManagement.Location = new System.Drawing.Point(107, 22);
            this.labelTicketManagement.Name = "labelTicketManagement";
            this.labelTicketManagement.Size = new System.Drawing.Size(160, 31);
            this.labelTicketManagement.TabIndex = 86;
            this.labelTicketManagement.Text = " Buy Ticket";
            // 
            // txtIdStatistic
            // 
            this.txtIdStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdStatistic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtIdStatistic.Location = new System.Drawing.Point(156, 244);
            this.txtIdStatistic.Name = "txtIdStatistic";
            this.txtIdStatistic.Size = new System.Drawing.Size(70, 15);
            this.txtIdStatistic.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 108;
            this.label6.Text = "ID Statistic";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtIdSeat
            // 
            this.txtIdSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdSeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtIdSeat.Location = new System.Drawing.Point(156, 210);
            this.txtIdSeat.Name = "txtIdSeat";
            this.txtIdSeat.Size = new System.Drawing.Size(70, 15);
            this.txtIdSeat.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 110;
            this.label7.Text = "ID Seat";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(156, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 15);
            this.textBox1.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 113;
            this.label3.Text = "Movie Name";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(156, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 15);
            this.textBox2.TabIndex = 114;
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(376, 479);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtIdSeat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdStatistic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnViewTicket);
            this.Controls.Add(this.btnAddTicket);
            this.Controls.Add(this.dateBookingDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdSchedule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTicketManagement);
            this.Name = "BuyTicket";
            this.Text = "TicketManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewTicket;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.DateTimePicker dateBookingDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdSchedule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTicketManagement;
        private System.Windows.Forms.TextBox txtIdStatistic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdSeat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}