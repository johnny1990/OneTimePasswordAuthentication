using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OneTimePasswordAppAuthentication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxDateTime.Text = DateTime.Now.ToString();

        }

        protected void GenerateOTP(object sender, EventArgs e)
        {
            if (TextBoxUserId.Text != "")
            {
                string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string small_alphabets = "abcdefghijklmnopqrstuvwxyz";
                string numbers = "1234567890";

                string characters = numbers;
                if (rbType.SelectedItem.Value == "1")
                {
                    characters += alphabets + small_alphabets + numbers;
                }
                int length = 24;
                string otp = string.Empty;
                for (int i = 0; i < length; i++)
                {
                    string character = string.Empty;
                    do
                    {
                        int index = new Random().Next(0, characters.Length);
                        character = characters.ToCharArray()[index].ToString();
                    } while (otp.IndexOf(character) != -1);
                    otp += character;
                }
                lblOTP.Text = otp;
                LBl30Seconds.Text = "Token is available for 30 seconds only!";
                Timer1.Enabled = true;

            }
            else
            {
                lblOTP.Text = "Enter user Id!";
            }
        }

        protected void ValidateOTP_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
            if (lblOTP.Text == TextBoxValidateToken.Text) // timer seconds 30!!!!!!!!
            {
                lblMsg.Text = "Logged in successfully";
                Response.Redirect("Success.aspx");
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            //int lbl = Convert.ToInt32(TimerTick.Text);
           // TimerTick.Text = (lbl + 1).ToString();
        }
    }
}