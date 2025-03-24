using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LengthCalculator
{
    enum LengthUnit // 定義單位的枚舉
    {
        CM = 0,
        M,
        KM,
        Inch,
        Ft,
        Yard
    }
    

    public partial class Form1: Form
    {

        /// <summary>
        /// 自動轉換為單位，_kind為單位，_value為公分數值
        /// </summary>
        /// <param name="_kind"></param>
        /// <param name="_value"></param>
        private void caculateAnswer(LengthUnit _kind,double _value)
        {
            byte _j = (byte)_kind; //用括號強轉
            if (_j != 0)
                txtCM.Text = string.Format("{0:0.##########}", _value);
            if (_j != 1)
                txtM.Text = string.Format("{0:0.##########}", _value / 100);
            if (_j != 2)
                txtKM.Text = string.Format("{0:0.##########}", _value / 100000);
            if (_j != 3)
                txtIn.Text = string.Format("{0:0.##########}", _value / 2.54);
            if (_j != 4)
                txtFt.Text = string.Format("{0:0.##########}", _value / 30.48);
            if (_j != 5)
                txtYard.Text = string.Format("{0:0.##########}", _value / 91.44);
        }

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
                caculateAnswer(LengthUnit.CM , douCM);
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
                caculateAnswer(LengthUnit.M, douM * 100);
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
                caculateAnswer(LengthUnit.KM, douKM * 100000);
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
                caculateAnswer(LengthUnit.Inch, douIn * 2.54);
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
                caculateAnswer(LengthUnit.Ft, douFt * 30.48);
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
                caculateAnswer(LengthUnit.Yard, douYard * 91.44);
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
