
namespace TungMovie
{
    partial class StatiticsForm
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
            this.btn_Statitics = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.Date_date = new System.Windows.Forms.DateTimePicker();
            this.lb_date = new System.Windows.Forms.Label();
            this.box_Statitics = new System.Windows.Forms.ComboBox();
            this.lb_SumOTicket = new System.Windows.Forms.Label();
            this.txt_SumOTicket = new System.Windows.Forms.TextBox();
            this.lb_IdStatitics = new System.Windows.Forms.Label();
            this.txt_Revenue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Statitics = new System.Windows.Forms.Label();
            this.grid_statitics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_statitics)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Statitics
            // 
            this.btn_Statitics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Statitics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Statitics.FlatAppearance.BorderSize = 0;
            this.btn_Statitics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Statitics.ForeColor = System.Drawing.Color.White;
            this.btn_Statitics.Location = new System.Drawing.Point(69, 380);
            this.btn_Statitics.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Statitics.Name = "btn_Statitics";
            this.btn_Statitics.Size = new System.Drawing.Size(133, 49);
            this.btn_Statitics.TabIndex = 144;
            this.btn_Statitics.Text = "VIEW STATITICS";
            this.btn_Statitics.UseVisualStyleBackColor = false;
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Return.FlatAppearance.BorderSize = 0;
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return.ForeColor = System.Drawing.Color.White;
            this.btn_Return.Location = new System.Drawing.Point(337, 380);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(133, 49);
            this.btn_Return.TabIndex = 143;
            this.btn_Return.Text = "RETURN";
            this.btn_Return.UseVisualStyleBackColor = false;
            // 
            // Date_date
            // 
            this.Date_date.CustomFormat = "   dd / MM / yyyy";
            this.Date_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.Date_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_date.Location = new System.Drawing.Point(253, 214);
            this.Date_date.Margin = new System.Windows.Forms.Padding(4);
            this.Date_date.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.Date_date.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.Date_date.Name = "Date_date";
            this.Date_date.Size = new System.Drawing.Size(249, 26);
            this.Date_date.TabIndex = 142;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(65, 214);
            this.lb_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(45, 20);
            this.lb_date.TabIndex = 141;
            this.lb_date.Text = "Date";
            // 
            // box_Statitics
            // 
            this.box_Statitics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.box_Statitics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_Statitics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.box_Statitics.FormattingEnabled = true;
            this.box_Statitics.ItemHeight = 20;
            this.box_Statitics.Items.AddRange(new object[] {
            "find by id",
            "find by name"});
            this.box_Statitics.Location = new System.Drawing.Point(253, 108);
            this.box_Statitics.Margin = new System.Windows.Forms.Padding(4);
            this.box_Statitics.Name = "box_Statitics";
            this.box_Statitics.Size = new System.Drawing.Size(92, 28);
            this.box_Statitics.TabIndex = 140;
            // 
            // lb_SumOTicket
            // 
            this.lb_SumOTicket.AutoSize = true;
            this.lb_SumOTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SumOTicket.Location = new System.Drawing.Point(65, 263);
            this.lb_SumOTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_SumOTicket.Name = "lb_SumOTicket";
            this.lb_SumOTicket.Size = new System.Drawing.Size(107, 20);
            this.lb_SumOTicket.TabIndex = 137;
            this.lb_SumOTicket.Text = "Sum of ticket";
            // 
            // txt_SumOTicket
            // 
            this.txt_SumOTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_SumOTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SumOTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txt_SumOTicket.Location = new System.Drawing.Point(253, 263);
            this.txt_SumOTicket.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SumOTicket.Name = "txt_SumOTicket";
            this.txt_SumOTicket.Size = new System.Drawing.Size(251, 19);
            this.txt_SumOTicket.TabIndex = 136;
            // 
            // lb_IdStatitics
            // 
            this.lb_IdStatitics.AutoSize = true;
            this.lb_IdStatitics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdStatitics.Location = new System.Drawing.Point(65, 108);
            this.lb_IdStatitics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_IdStatitics.Name = "lb_IdStatitics";
            this.lb_IdStatitics.Size = new System.Drawing.Size(92, 20);
            this.lb_IdStatitics.TabIndex = 135;
            this.lb_IdStatitics.Text = "ID Statitics";
            // 
            // txt_Revenue
            // 
            this.txt_Revenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_Revenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txt_Revenue.Location = new System.Drawing.Point(253, 154);
            this.txt_Revenue.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Revenue.Multiline = true;
            this.txt_Revenue.Name = "txt_Revenue";
            this.txt_Revenue.Size = new System.Drawing.Size(251, 20);
            this.txt_Revenue.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 133;
            this.label1.Text = "Revenue";
            // 
            // lb_Statitics
            // 
            this.lb_Statitics.AutoSize = true;
            this.lb_Statitics.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Statitics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lb_Statitics.Location = new System.Drawing.Point(163, 37);
            this.lb_Statitics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Statitics.Name = "lb_Statitics";
            this.lb_Statitics.Size = new System.Drawing.Size(145, 39);
            this.lb_Statitics.TabIndex = 132;
            this.lb_Statitics.Text = "Statitics";
            // 
            // grid_statitics
            // 
            this.grid_statitics.AllowUserToAddRows = false;
            this.grid_statitics.AllowUserToDeleteRows = false;
            this.grid_statitics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_statitics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_statitics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_statitics.Location = new System.Drawing.Point(548, 37);
            this.grid_statitics.Margin = new System.Windows.Forms.Padding(4);
            this.grid_statitics.Name = "grid_statitics";
            this.grid_statitics.ReadOnly = true;
            this.grid_statitics.RowHeadersVisible = false;
            this.grid_statitics.RowHeadersWidth = 51;
            this.grid_statitics.Size = new System.Drawing.Size(667, 470);
            this.grid_statitics.TabIndex = 131;
            // 
            // StatiticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 549);
            this.Controls.Add(this.btn_Statitics);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.Date_date);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.box_Statitics);
            this.Controls.Add(this.lb_SumOTicket);
            this.Controls.Add(this.txt_SumOTicket);
            this.Controls.Add(this.lb_IdStatitics);
            this.Controls.Add(this.txt_Revenue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Statitics);
            this.Controls.Add(this.grid_statitics);
            this.Name = "StatiticsForm";
            this.Text = "StatiticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.grid_statitics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Statitics;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.DateTimePicker Date_date;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.ComboBox box_Statitics;
        private System.Windows.Forms.Label lb_SumOTicket;
        private System.Windows.Forms.TextBox txt_SumOTicket;
        private System.Windows.Forms.Label lb_IdStatitics;
        private System.Windows.Forms.TextBox txt_Revenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Statitics;
        private System.Windows.Forms.DataGridView grid_statitics;
    }
}