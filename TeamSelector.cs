/* Program Name: TeamSelector
 Created by: J. DuBois
 Created on: 13-Apr-2014
 Exercise 13 problem 3 */
/************************/

/* This program creates
 allows a user to select
 his/her favorite local
 sports team and them provides
 an individual ticket price
 for one game */
/************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeamSelector
{
    public partial class frmTicketPrices : Form
    {
        public frmTicketPrices()
        {
            InitializeComponent();
        }

        private void lstSportsTeams_MouseEnter(object sender, EventArgs e)
        {
            lblMouseOver.Visible = true;
        }

        private void lstSportsTeams_MouseLeave(object sender, EventArgs e)
        {
            lblMouseOver.Visible = false;
        }

        private void lstSportsTeams_MouseClick(object sender, MouseEventArgs e)
        {
            // Declare variables
            int intIndex;
            intIndex = lstSportsTeams.SelectedIndex;

            // Get ticket price base on user selection
            switch (intIndex)
            {
                case 0: // San Jose Sharks
                    lblClickPrice.Text = "Ticket price is $50";
                    this.BackColor = Color.Teal;
                    break;
                case 1: // San Francisco 49ers
                    lblClickPrice.Text = "Ticket price is $75";
                    this.BackColor = Color.Red;
                    break;
                case 2: // San Francisco Giants
                    lblClickPrice.Text = "Ticket price is $45";
                    this.BackColor = Color.OrangeRed;
                    break;
                case 3: // Oakland Raiders
                    lblClickPrice.Text = "Ticket price is $55";
                    this.BackColor = Color.Silver;
                    break;
                case 4: // Oakland A's
                    lblClickPrice.Text = "Ticket price is $12";
                    this.BackColor = Color.Green;
                    break;
                case 5: // Golden State Warriors
                    lblClickPrice.Text = "Ticket price is $65";
                    this.BackColor = Color.Blue;
                    break;
            }
        }
    }
}
