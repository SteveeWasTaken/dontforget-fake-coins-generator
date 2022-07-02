using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Don_t_Forget_Free_Coins_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logoImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        void hideUI()
        {
            usernameInput.Visible = false;
            undercoinInput.Visible = false;
            goldInput.Visible = false;
            passwordInput.Visible = false;
            goldLabel.Visible = false;
            passwordLabel.Visible = false;
            undercoinLabel.Visible = false;
            usernameLabel.Visible = false;
            adminCheckBox.Visible = false;
            noclipCheckBox.Visible = false;
            titleLabel.Visible = false;
            logoImage.Visible = false;
            banCheckBox.Visible = false;
            ssSettingsCheckBox.Visible = false;
            xtraOptionsLabel.Visible = false;
            startButton.Visible = false;
        }

        void showUI()
        {
            usernameInput.Visible = true;
            undercoinInput.Visible = true;
            goldInput.Visible = true;
            passwordInput.Visible = true;
            goldLabel.Visible = true;
            passwordLabel.Visible = true;
            undercoinLabel.Visible = true;
            usernameLabel.Visible = true;
            adminCheckBox.Visible = true;
            noclipCheckBox.Visible = true;
            titleLabel.Visible = true;
            logoImage.Visible = true;
            banCheckBox.Visible = true;
            ssSettingsCheckBox.Visible = true;
            xtraOptionsLabel.Visible = true;
            startButton.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gold = 0;
            int undercoins = 0;
            var works = true;
            try
            {
                gold = int.Parse(goldInput.Text);
            }
            catch (Exception)
            {
                works = false;
                MessageBox.Show("Please input a number as Gold.", "Error");
            }
            try
            {
                undercoins = int.Parse(undercoinInput.Text);
            }
            catch (Exception)
            {
                works = false;
                MessageBox.Show("Please input a number as UnderCoins.", "Error");
            }
            if (works == true)
            {
                hideUI();
                progressBar1.Visible = true;
                hackLog.Visible = true;
                var theuser = usernameInput.Text;
                string userpass = "";
                for (int i = 0; i < passwordInput.TextLength; i++)
                {
                    userpass += "*";
                }
                hackLog.Text = "Hacking the database...";
                progressBar1.Value = 5;
                wait(6000);
                hackLog.Text = "Hacking the database [DONE]" + Environment.NewLine + "Downloading Information...";
                progressBar1.Value = 8;
                wait(5500);
                hackLog.Text = "Hacking the database [DONE]" + Environment.NewLine + "Downloading Information [DONE]" + Environment.NewLine + "Accessing DONTFORGET CONNECTED Servers with user " + theuser + " And Password " + userpass + "...";
                progressBar1.Value = 15;
                wait(2000);
                hackLog.Text = "Hacking the database [DONE]" + Environment.NewLine + "Downloading Information [DONE]" + Environment.NewLine + "Accessing DONTFORGET CONNECTED Servers with user " + theuser + " And Password " + userpass + " [DONE]" + Environment.NewLine + "Sending pair request to DONTFORGET CONNECTED Servers...";
                progressBar1.Value = 45;
                wait(15000);
                hackLog.Text = "Hacking the database [DONE]" + Environment.NewLine + "Downloading Information [DONE]" + Environment.NewLine + "Accessing DONTFORGET CONNECTED Servers with user " + theuser + " And Password " + userpass + " [DONE]" + Environment.NewLine + "Sending pair request to DONTFORGET CONNECTED Servers [DONE]" + Environment.NewLine + "Uploading data...";
                progressBar1.Value = 70;
                wait(7000);
                hackLog.Text = "Hacking the database [DONE]" + Environment.NewLine + "Downloading Information [DONE]" + Environment.NewLine + "Accessing DONTFORGET CONNECTED Servers with user " + theuser + " And Password " + userpass + " [DONE]" + Environment.NewLine + "Sending pair request to DONTFORGET CONNECTED Servers [DONE]" + Environment.NewLine + "Uploading data [FAILED]" + Environment.NewLine + "Captcha Verification is needed. A website has opened, follow instructions to verify your account and recieve free gold hack.";
                progressBar1.Value = 95;
                System.Diagnostics.Process.Start("https://bit.ly/3bIxKjY");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void usernameInput_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void setButtonVisibility()
        {
            if ((usernameInput.Text != String.Empty) && (passwordInput.Text != String.Empty))
            {
                loginButton.Enabled = true;
            }
            else
            {
                loginButton.Enabled = false;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            bool loginCheck = true;
            if (usernameInput.TextLength == 0)
            {
                MessageBox.Show("You haven't given a Username.", "Error");
                loginCheck = false;
            }
            if (passwordInput.TextLength == 0)
            {
                MessageBox.Show("You haven't given a Password.", "Error");
                loginCheck = false;
            }
            if (usernameInput.TextLength <= 3)
            {
                MessageBox.Show("Your username is too short.", "Error");
                loginCheck = false;
            }
            if (passwordInput.TextLength <= 7)
            {
                MessageBox.Show("Your password is too short.", "Error");
                loginCheck = false;
            }
            if (loginCheck)
            {
                startButton.Visible = true;
                startButton.Enabled = true;
                goldInput.Visible = true;
                undercoinInput.Visible = true;
                goldLabel.Visible = true;
                undercoinLabel.Visible = true;
                xtraOptionsLabel.Visible = true;
                noclipCheckBox.Visible = true;
                adminCheckBox.Visible = true;
                banCheckBox.Visible = true;
                ssSettingsCheckBox.Visible = true;
                usernameInput.Visible = false;
                usernameLabel.Visible = false;
                passwordInput.Visible = false;
                passwordLabel.Visible = false;
                loginButton.Visible = false;
                MessageBox.Show("Login Successful.", "Success");
            }
        }
    }
}
