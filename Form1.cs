using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthCalculator
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textCM_KeyUp(object sender, KeyEventArgs e)
        {   
            double douCM; //宣告一個double變數，變數名稱叫douCM
            if(double.TryParse(txtCM.Text, out douCM)) 
            {
                textInfo.Text = "";
                txtM.Text = string.Format("{0:0.##########}", douCM / 100);
                txtKM.Text = string.Format("{0:0.##########}", douCM / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);
            }
            else
            {
                Clear();
                textInfo.Text = "請輸入數字";
            }


        }


        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM;
            if(double.TryParse(txtM.Text, out douM)) 
            {
                textInfo.Text = "";
                txtCM.Text = string.Format( "{0:0.##########}", douM * 100);
                txtKM.Text = string.Format("{0:0.##########}", douM / 1000);
                txtIn.Text = string.Format("{0:0.##########}", douM * 39.3700787);
                txtFt.Text = string.Format("{0:0.##########}", douM * 3.2808399);
                txtYard.Text = string.Format("{0:0.##########}", douM * 1.0936133); 
            }
            else
            {
                Clear();
                textInfo.Text = "請輸入數字";
            }

        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM;
            if (double.TryParse(txtKM.Text, out douKM))
            {
                textInfo.Text = "";
                txtCM.Text = string.Format("{0:0.##########}", douKM * 100000);
                txtM.Text = string.Format("{0:0.##########}", douKM * 1000);
                txtIn.Text = string.Format("{0:0.##########}", douKM * 39370.0787);
                txtFt.Text = string.Format("{0:0.##########}", douKM * 3280.8399);
                txtYard.Text = string.Format("{0:0.##########}", douKM * 1093.6133);
            }
            else 
            {
                Clear();
                textInfo.Text = "請輸入數字";
            }
            

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
            textInfo.Text = "This is a length calculator.";
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            double douIn;
            if(double.TryParse(txtIn.Text, out douIn))
            {
                textInfo.Text = "";
                txtCM.Text = string.Format("{0:0.##########}", douIn * 2.54);
                txtM.Text = string.Format("{0:0.##########}", douIn * 0.0254);
                txtKM.Text = string.Format("{0:0.##########}", douIn * 0.0000254);
                txtFt.Text = string.Format("{0:0.##########}", douIn / 12);
                txtYard.Text = string.Format("{0:0.##########}", douIn / 36);
            }
            else
            {
                Clear();
                textInfo.Text = "請輸入數字";
            }

        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            double douFt;
            if(double.TryParse(txtFt.Text, out douFt))
            {
                textInfo.Text = "";
                txtCM.Text = string.Format("{0:0.##########}", douFt * 30.48);
                txtM.Text = string.Format("{0:0.##########}", douFt * 0.3048);
                txtKM.Text = string.Format("{0:0.##########}", douFt * 0.0003048);
                txtIn.Text = string.Format("{0:0.##########}", douFt * 12);
                txtYard.Text = string.Format("{0:0.##########}", douFt / 3);
            }
            else
            {
                Clear();
                textInfo.Text = "請輸入數字";
            }


        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard;
            if(double.TryParse(txtYard.Text, out douYard))
            {
                textInfo.Text = "";
                txtCM.Text = string.Format("{0:0.##########}", douYard * 91.44);
                txtM.Text = string.Format("{0:0.##########}", douYard * 0.9144);
                txtKM.Text = string.Format("{0:0.##########}", douYard * 0.0009144);
                txtIn.Text = string.Format("{0:0.##########}", douYard * 36);
                txtFt.Text = string.Format("{0:0.##########}", douYard * 3);
            }
            else
            {
                Clear();
                textInfo.Text = "請輸入數字";
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            Clear();
            textInfo.Text = "";
        }
        private void Clear()
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtFt.Text = "";
            txtIn.Text = "";
            txtYard.Text = "";
        }
    }
}
