using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using MetroFramework.Components;
using MetroFramework.Forms;
using System.Threading;

namespace MyParser
{
    public partial class Form1 : MetroForm
    {
        IWebDriver Browser;

        public Form1()
        {
            InitializeComponent();
            MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();    // Make a Chrome Browser
            Browser.Manage().Window.Maximize(); 
            Browser.Navigate().GoToUrl("https://www.vindecoderz.com/EN/check-lookup" + "/" + textBox1.Text); // URL
            label3.Text = textBox1.Text;
            // IWebElement SearchInput = Browser.FindElement(By.Id("vin_number")); // If your website have INPUT for searching, use this code and 
            // SearchInput.SendKeys("VIN_CODE / or Something else" + OpenQA.Selenium.Keys.Enter); // this code too, for tap enter and searching

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Browser.Quit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)    // make a placeholder
        {
            if (textBox1.Text == "ENTER VIN CODE HERE")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
