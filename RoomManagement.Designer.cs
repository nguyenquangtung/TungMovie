
namespace TungMovie
{
    partial class RoomManagement
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
            this.txtSeatsAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxRoomID = new System.Windows.Forms.ComboBox();
            this.labelIdRoom = new System.Windows.Forms.Label();
            this.labelRoomManagement = new System.Windows.Forms.Label();
            this.gridRoomManagement = new System.Windows.Forms.DataGridView();
            this.btnUpdateRoom = new TungMovie.RButton();
            this.btnViewRoomMgt = new TungMovie.RButton();
            this.btnDeleteRoom = new TungMovie.RButton();
            this.btnAddRoom = new TungMovie.RButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoomManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSeatsAmount
            // 
            this.txtSeatsAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtSeatsAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeatsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtSeatsAmount.Location = new System.Drawing.Point(161, 156);
            this.txtSeatsAmount.Name = "txtSeatsAmount";
            this.txtSeatsAmount.Size = new System.Drawing.Size(70, 15);
            this.txtSeatsAmount.TabIndex = 132;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 131;
            this.label7.Text = "Seats Amount";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(161, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 15);
            this.txtName.TabIndex = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 129;
            this.label4.Text = "Name";
            // 
            // boxRoomID
            // 
            this.boxRoomID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxRoomID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.boxRoomID.FormattingEnabled = true;
            this.boxRoomID.ItemHeight = 16;
            this.boxRoomID.Location = new System.Drawing.Point(161, 79);
            this.boxRoomID.Name = "boxRoomID";
            this.boxRoomID.Size = new System.Drawing.Size(70, 24);
            this.boxRoomID.TabIndex = 124;
            this.boxRoomID.SelectedIndexChanged += new System.EventHandler(this.boxRoomID_SelectedIndexChanged);
            // 
            // labelIdRoom
            // 
            this.labelIdRoom.AutoSize = true;
            this.labelIdRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdRoom.Location = new System.Drawing.Point(20, 79);
            this.labelIdRoom.Name = "labelIdRoom";
            this.labelIdRoom.Size = new System.Drawing.Size(61, 16);
            this.labelIdRoom.TabIndex = 123;
            this.labelIdRoom.Text = "ID Room";
            // 
            // labelRoomManagement
            // 
            this.labelRoomManagement.AutoSize = true;
            this.labelRoomManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelRoomManagement.Location = new System.Drawing.Point(17, 21);
            this.labelRoomManagement.Name = "labelRoomManagement";
            this.labelRoomManagement.Size = new System.Drawing.Size(265, 31);
            this.labelRoomManagement.TabIndex = 122;
            this.labelRoomManagement.Text = "Room Management";
            // 
            // gridRoomManagement
            // 
            this.gridRoomManagement.AllowUserToAddRows = false;
            this.gridRoomManagement.AllowUserToDeleteRows = false;
            this.gridRoomManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRoomManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridRoomManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRoomManagement.Location = new System.Drawing.Point(313, 21);
            this.gridRoomManagement.Name = "gridRoomManagement";
            this.gridRoomManagement.ReadOnly = true;
            this.gridRoomManagement.RowHeadersVisible = false;
            this.gridRoomManagement.RowHeadersWidth = 51;
            this.gridRoomManagement.Size = new System.Drawing.Size(473, 285);
            this.gridRoomManagement.TabIndex = 121;
            this.gridRoomManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRoomManagement_CellClick);
            this.gridRoomManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTicketManagement_CellContentClick);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUpdateRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUpdateRoom.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdateRoom.BorderRadius = 10;
            this.btnUpdateRoom.BorderSize = 0;
            this.btnUpdateRoom.FlatAppearance.BorderSize = 0;
            this.btnUpdateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRoom.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRoom.Location = new System.Drawing.Point(165, 257);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(121, 48);
            this.btnUpdateRoom.TabIndex = 199;
            this.btnUpdateRoom.Text = "UPDATE ROOM";
            this.btnUpdateRoom.TextColor = System.Drawing.Color.White;
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnViewRoomMgt
            // 
            this.btnViewRoomMgt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnViewRoomMgt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnViewRoomMgt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnViewRoomMgt.BorderRadius = 10;
            this.btnViewRoomMgt.BorderSize = 0;
            this.btnViewRoomMgt.FlatAppearance.BorderSize = 0;
            this.btnViewRoomMgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRoomMgt.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRoomMgt.ForeColor = System.Drawing.Color.White;
            this.btnViewRoomMgt.Location = new System.Drawing.Point(25, 257);
            this.btnViewRoomMgt.Name = "btnViewRoomMgt";
            this.btnViewRoomMgt.Size = new System.Drawing.Size(121, 48);
            this.btnViewRoomMgt.TabIndex = 198;
            this.btnViewRoomMgt.Text = "VIEW ROOM";
            this.btnViewRoomMgt.TextColor = System.Drawing.Color.White;
            this.btnViewRoomMgt.UseVisualStyleBackColor = false;
            this.btnViewRoomMgt.Click += new System.EventHandler(this.btnViewRoomMgt_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDeleteRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDeleteRoom.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDeleteRoom.BorderRadius = 10;
            this.btnDeleteRoom.BorderSize = 0;
            this.btnDeleteRoom.FlatAppearance.BorderSize = 0;
            this.btnDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoom.Location = new System.Drawing.Point(165, 192);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(121, 48);
            this.btnDeleteRoom.TabIndex = 197;
            this.btnDeleteRoom.Text = "DELETE ROOM";
            this.btnDeleteRoom.TextColor = System.Drawing.Color.White;
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAddRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAddRoom.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddRoom.BorderRadius = 10;
            this.btnAddRoom.BorderSize = 0;
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(25, 192);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(121, 48);
            this.btnAddRoom.TabIndex = 196;
            this.btnAddRoom.Text = "ADD ROOM";
            this.btnAddRoom.TextColor = System.Drawing.Color.White;
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // RoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 321);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.btnViewRoomMgt);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.txtSeatsAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxRoomID);
            this.Controls.Add(this.labelIdRoom);
            this.Controls.Add(this.labelRoomManagement);
            this.Controls.Add(this.gridRoomManagement);
            this.Name = "RoomManagement";
            this.Text = "RoomManagement";
            this.Load += new System.EventHandler(this.RoomManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRoomManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSeatsAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxRoomID;
        private System.Windows.Forms.Label labelIdRoom;
        private System.Windows.Forms.Label labelRoomManagement;
        private System.Windows.Forms.DataGridView gridRoomManagement;
		private RButton btnAddRoom;
		private RButton btnDeleteRoom;
		private RButton btnViewRoomMgt;
		private RButton btnUpdateRoom;
	}
}