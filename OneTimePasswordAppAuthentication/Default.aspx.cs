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
        DateTime t1;
        DateTime t2;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxDateTime.Text = DateTime.Now.ToString("hh:mm");
            if (!this.IsPostBack)
            {
               // TimerTick.Text = DateTime.Now.ToString("hh:mm:ss tt");
            }
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

               
               TimerTick.Text = DateTime.Now.ToString("hh:mm:ss tt");
                t1 = DateTime.Now;

            }
            else
            {
                lblOTP.Text = "Enter user Id!";
            }
        }

        protected void ValidateOTP_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
            t2 = DateTime.Now;
            TimeSpan time = t2.Subtract(t1);
            var seconds = time.TotalSeconds;

            if (lblOTP.Text == TextBoxValidateToken.Text && seconds > 30000)
            {
                lblMsg.Text = "Logged in successfully";

                string url;
                url = "Success.aspx?name=" +
                    TextBoxUserId.Text; 
                Response.Redirect(url);         
            }
            else
            {
                lblMsg.Text = "Error. Token is invalid!";
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            TimerTick.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}