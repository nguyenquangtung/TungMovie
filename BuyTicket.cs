﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TungMovie
{
    public partial class BuyTicket : Form
    {
        Schedule sche = new Schedule();
        Seat se = new Seat();
        DateTime bookingdatatime;
        string username;
        Ticket ti = new Ticket();

        int movie_id;

        public BuyTicket()
        {
            InitializeComponent();
        }

        private void boxScheduleId_load(int movie_id)
        {
            boxScheduleId.DataSource = sche.getScheduleListByMovieId(movie_id);
            boxScheduleId.ValueMember = "scheduleid";
            boxScheduleId.DisplayMember = "scheduleid";
            boxScheduleId.SelectedIndex = -1;
        }

        private void boxIdSeat_load(int room_id)
        {
            boxIdSeat.DataSource = se.getSeatListByRoomID(room_id);
            boxIdSeat.ValueMember = "seatid";
            boxIdSeat.DisplayMember = "seatid";
            boxIdSeat.SelectedIndex = -1;
        }

        public BuyTicket(int selected_movie_id)
        {
            movie_id = selected_movie_id;
        }

        private void ChooseSchedule_Load(object sender, EventArgs e)
        {
            movie_id = 1;
            username = UserStore.StoreUsername;
            txtUsername.Text = username;
            boxScheduleId_load(movie_id);
            boxPaymentType.SelectedIndex = 0;
        }

        private void boxScheduleId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int scheduleid = Convert.ToInt32(boxScheduleId.SelectedValue);
                DataTable dt = new DataTable();
                dt = sche.getScheduleById(scheduleid);
                dateStartTime.Value = DateTime.Parse(dt.Rows[0][0].ToString()).Date;
                dateEndTime.Value = DateTime.Parse(dt.Rows[0][1].ToString()).Date;
                timeStart.Value = DateTime.Parse(dt.Rows[0][0].ToString());
                timeEnd.Value = DateTime.Parse(dt.Rows[0][1].ToString());
                txtIdMovie.Text = dt.Rows[0][2].ToString();
                txtIdRoom.Text = dt.Rows[0][3].ToString();
            }
            catch
            {
                dateStartTime.Value = DateTime.Now;
                dateStartTime.Value = DateTime.Now;
                timeStart.Value = DateTime.Now;
                timeEnd.Value = DateTime.Now;
                txtIdMovie.Text = "";
                txtIdRoom.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdRoom_TextChanged(object sender, EventArgs e)
        {
            int roomid = Int32.Parse(txtIdRoom.Text);
            boxIdSeat_load(roomid);
        }

        private void boxIdSeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int seatid = Convert.ToInt32(boxIdSeat.SelectedValue);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                dt = se.getSeatKind(seatid);
                txtSeatKind.Text = dt.Rows[0][0].ToString();
                if(txtSeatKind.Text.Equals("VIP"))
                {
                    txtPrice.Text = "85000";
                }
                else if(txtSeatKind.Text.Equals("COMMON"))
                {
                    txtPrice.Text = "65000";
                }
                dt2 = ti.getAvailableTicketIdWithPrice(Int32.Parse(txtPrice.Text));
                txtIdTicket.Text = dt2.Rows[0][0].ToString();
            }
            catch
            {
                txtSeatKind.Text = "";
                txtPrice.Text = "";
                txtIdTicket.Text = "";
            }
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int scheduleid = Convert.ToInt32(boxScheduleId.SelectedValue);
                int seatid = Convert.ToInt32(boxIdSeat.SelectedValue);
                bookingdatatime = dateStartTime.Value.Date + timeStart.Value.TimeOfDay;
                int price = Int32.Parse(txtPrice.Text);
                int roomid = Int32.Parse(txtIdRoom.Text);
                int ticketid = Int32.Parse(txtIdTicket.Text);
                string type = boxPaymentType.SelectedItem.ToString();
                int usernumber = Int32.Parse(txtUserNumber.Text);
                string moviename = txtMovieName.Text;
                PaymentStrategy.PaymentContext context = new PaymentStrategy.PaymentContext();
                PaymentStrategy.MoMoPaymentStrategy momo = new PaymentStrategy.MoMoPaymentStrategy();
                PaymentStrategy.ZaloPayPaymentStrategy zalo = new PaymentStrategy.ZaloPayPaymentStrategy();

                if (type.Equals("MoMo"))
                {
                    context.SetPaymentStrategy(momo);
                }
                else
                {
                    context.SetPaymentStrategy(zalo);
                }

                if (ti.bookTicket(ticketid, price, bookingdatatime, scheduleid, username, seatid, roomid))
                {
                    context.ExecutePayment(username, moviename, bookingdatatime, usernumber, price);
                }
                else
                {
                    MessageBox.Show("Error", "Book Ticket", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No blanks allowed", "Book Ticket", MessageBoxButtons.OK);
            }
        }

        bool verif()
        {
            if ((txtIdTicket.Text.Trim() == "")
                || (txtUserNumber.Text.Trim() == "")
                || (boxIdSeat.SelectedIndex == -1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void boxPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = boxPaymentType.SelectedItem.ToString();
            if (type.Equals("MoMo"))
            {
                lb_receiver.Text = "Receiver's MoMo";
            }
            else
            {
                lb_receiver.Text = "Receiver's ZaloPay";
            }
        }
    }
}
