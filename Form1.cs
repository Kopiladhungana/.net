using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace calculator
{
    public partial class Form1 : Form
    {
        public string no1, constfun;
        public bool inputstatus;
        public Form1()
        {
            InitializeComponent();
            no1 = "";
            txtDisplay.ReadOnly = true;
            txtDisplay.RightToLeft = RightToLeft.Yes;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
             if (textBoxoperand1.Text == "")
            {
                textBoxoperand1.Text = textBoxoperand1.Text + btn1.Text;
            }
            else 
               textBoxoperand2.Text = textBoxoperand2.Text + btn1.Text;
             //textBoxoperand1.Text = textBoxoperand1.Text + btn1.Text;
        }
        
         
        private void btn2_Click_1(object sender, EventArgs e)
        {
            if (textBoxoperand1.Text == "")
            {
                textBoxoperand1.Text = textBoxoperand1.Text + btn2.Text;
            }
            else
                textBoxoperand2.Text = textBoxoperand2.Text + btn2.Text;
           

        }
        

        private void btn3_Click_1(object sender, EventArgs e)
        {
            if (textBoxoperand1.Text == "")
            {
                textBoxoperand1.Text = textBoxoperand1.Text + btn3.Text;
            }
            else
                textBoxoperand2.Text = textBoxoperand2.Text + btn3.Text;
            
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            if (textBoxoperand1.Text == "")
            {
                textBoxoperand1.Text = textBoxoperand1.Text + btn4.Text;
            }
            else
                textBoxoperand2.Text = textBoxoperand2.Text + btn4.Text;
           
           
            //txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            if (textBoxoperand1.Text == "")
            {
                textBoxoperand1.Text = textBoxoperand1.Text + btn5.Text;
            }
            else
                textBoxoperand2.Text = textBoxoperand2.Text + btn5.Text;
           
           
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            if (textBoxoperand1.Text == "")
            {
                textBoxoperand1.Text = textBoxoperand1.Text + btn6.Text;
            }
            else
                textBoxoperand2.Text = textBoxoperand2.Text + btn6.Text;
            
         
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            if (textBoxoperand1.Text == "")
            {
                textBoxoperand1.Text = textBoxoperand1.Text + btn7.Text;
            }
            else
                textBoxoperand2.Text = textBoxoperand2.Text + btn7.Text;
           
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            if (textBoxoperand1.Text == "")
            {
                textBoxoperand1.Text = textBoxoperand1.Text + btn8.Text;
            }
            else
                textBoxoperand2.Text = textBoxoperand2.Text + btn8.Text;
           
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            if (textBoxoperand1.Text == "")
            {
                textBoxoperand1.Text = textBoxoperand1.Text + btn9.Text;
            }
            else
                textBoxoperand2.Text = textBoxoperand2.Text + btn9.Text;
           
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            if (textBoxoperand1.Text == "")
            {
                textBoxoperand1.Text = textBoxoperand1.Text + btn0.Text;
            }
            else
                textBoxoperand2.Text = textBoxoperand2.Text + btn0.Text;
          
        }

        private void btn10_Click_1(object sender, EventArgs e)
        {
            if (textBoxoperand1.Text == "")
            {
                textBoxoperand1.Text = textBoxoperand1.Text + btn10.Text;
            }
            else
                textBoxoperand2.Text = textBoxoperand2.Text + btn10.Text;
           
           
        }

        private void btndel_Click_1(object sender, EventArgs e)
        {
            string sample = txtDisplay.Text;
            int a = sample.Length - 1;
            txtDisplay.Text = sample.Remove(a);
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            textBoxoperand1.Clear();
            textBoxoperand2.Clear();
            txtDisplay.Clear();
            // txtDisplay.Clear();
        }

        double total1 = 0;
        double total2 = 0;
       /* bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool divideButtonClicked = false;

        private void btnplus_Click_1(object sender, EventArgs e)
        {
              i++;
         switch(i)
         {
             case 1:
                 this.BackColor = Color.Red;
                 break;
             case 2:
                 btnplus.BackColor = SystemColors.Control;
                 i = 0;
                 break;
         }
        

         if (i == 0)
         {
             this.BackColor = Color.Red;
             i++;
         }
         else if (i == 1 && this.BackColor == Color.Red)
         {
             btnplus.BackColor = SystemColors.Control;
             i++;
         }


            total1 = total1 + double.Parse(total2.ToString());
            //total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            //theOperator = "+";
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(total2.ToString());
            //total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(total2.ToString());
            //total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = true;
            divideButtonClicked = false;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(total2.ToString());
            //total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = true;
        }*/

        private void btnequals_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {

                total2 = (Convert.ToDouble(textBoxoperand1.Text)) + (Convert.ToDouble(textBoxoperand2.Text));
                //total2 = double.Parse(textBoxoperand1.Text) + double.Parse(textBoxoperand2.Text);
                //txtDisplay.Text = (Convert.ToDouble(textBoxoperand1.Text)).ToString() + (Convert.ToDouble(textBoxoperand2.Text)).ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                total2 = (Convert.ToDouble(textBoxoperand1.Text)) - (Convert.ToDouble(textBoxoperand2.Text));
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                total2 = (Convert.ToDouble(textBoxoperand1.Text)) * (Convert.ToDouble(textBoxoperand2.Text));
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                total2 = (Convert.ToDouble(textBoxoperand1.Text)) / (Convert.ToDouble(textBoxoperand2.Text));
            }
   
            txtDisplay.Text = total2.ToString();
            total1 = 0;
        }

        private void radioButtonceiling_CheckedChanged(object sender, EventArgs e)
        {
        txtDisplay.Text = (Math.Ceiling(Convert.ToDouble(txtDisplay.Text))).ToString(); 
        }

        private void radioButtonfloor_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplay.Text = (Math.Floor(Convert.ToDouble(txtDisplay.Text))).ToString(); 
        }

        private void txtoperand1keypress(object sender, KeyPressEventArgs e)
        {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxoperand2_KeyPress(object sender, KeyPressEventArgs e)
        {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnsine_Click(object sender, EventArgs e)
        {
            if (radioBtnradian.Checked == true)
            {
                txtDisplay.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(textBoxoperand1.Text)));
                inputstatus = false;
            }
            else
            {
           txtDisplay.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBoxoperand1.Text))));
                inputstatus = false;
            }
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            if (radioBtnradian.Checked == true)
            {
                txtDisplay.Text = Convert.ToString(System.Math.Cos(Convert.ToDouble(textBoxoperand1.Text)));
                inputstatus = false;
            }
            else
            {
                txtDisplay.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBoxoperand1.Text))));
                inputstatus = false;
            }
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            if (radioBtnradian.Checked == true)//MUTUALLYEXCLUSIVE EVENTS
            {
                txtDisplay.Text = Convert.ToString(System.Math.Tan(Convert.ToDouble(textBoxoperand1.Text)));
                inputstatus = false;
            }
            else
            {
                txtDisplay.Text= Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBoxoperand1.Text))));
                inputstatus = false;
            }
        }

       /* private void btnmod_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Convert.ToString(Convert.ToDouble(no1) % Convert.ToDouble(txtDisplay.Text));
            inputstatus = false;
            //no1 = txtDisplay.Text;
            //txtDisplay.Text = "";
            //constfun = "mod";
        }*/

        private void btnlog_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Convert.ToString(System.Math.Log(Convert.ToDouble(textBoxoperand1.Text)));
            inputstatus = false;
            
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            txtDisplay.Text= Convert.ToString(System.Math.Sqrt(Convert.ToDouble(textBoxoperand1.Text)));
            inputstatus = false;
        }

        private void btnpi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.141592654";
        }

        private void btnoff_Click(object sender, EventArgs e)
        {
            textBoxoperand1.Enabled = false;
            textBoxoperand1.Text = "";
            textBoxoperand2.Enabled = false;
            textBoxoperand2.Text = "";
            txtDisplay.Enabled = false;
            txtDisplay.Text = "";
            inputstatus = false;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            
            textBoxoperand1.Enabled = true;
            textBoxoperand1.Text = "0";
            textBoxoperand2.Enabled = true;
            textBoxoperand2.Text = "0";
            txtDisplay.Enabled = true;
            txtDisplay.Text = "0";
        }

        private void btnplusminus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Convert.ToString(-Convert.ToInt32(textBoxoperand1.Text));
            inputstatus = false;
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            int var1 = 1;
            for (int i = 1; i <= Convert.ToInt16(textBoxoperand1.Text); i++)
            {
                var1 = var1 * i;
            }
            txtDisplay.Text = Convert.ToString(var1);
            inputstatus = false;
        }

        private void btn20_Click_1(object sender, EventArgs e)
        {
           txtDisplay.Text=Convert.ToString(Convert.ToDouble(1.0/Convert.ToDouble(textBoxoperand1.Text)));
            inputstatus=false;
        }

        private void btnsquare_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Convert.ToString(Convert.ToDouble(textBoxoperand1.Text) * Convert.ToDouble(textBoxoperand1.Text));
            inputstatus = false;
        }
        private void btncube_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Convert.ToString(Convert.ToDouble(textBoxoperand1.Text) * Convert.ToDouble(textBoxoperand1.Text) * Convert.ToDouble(textBoxoperand1.Text));
            inputstatus = false;
        }

        private void btnsininverse_Click(object sender, EventArgs e)
        {
            if(radioBtnradian.Checked==true)
            {
                txtDisplay.Text=Convert.ToString(System.Math.Asin(Convert.ToDouble(textBoxoperand1.Text)));
            inputstatus=false;
            }
            else
            {
                txtDisplay.Text = Convert.ToString(System.Math.Asin(Convert.ToDouble(textBoxoperand1.Text)) * 57.296);
                //txtDisplay.Text=Convert.ToString(System.Math.Asin((Convert.ToDouble(System.Math.PI)/180*(Convert.ToDouble(textBoxoperand1.Text)))));
                inputstatus=false;
            }
        }

        private void btncosinverse_Click(object sender, EventArgs e)
        {
            if (radioBtnradian.Checked == true)
            {
                txtDisplay.Text = Convert.ToString(System.Math.Acos(Convert.ToDouble(textBoxoperand1.Text)));
                inputstatus = false;
            }
            else
            {
                txtDisplay.Text = Convert.ToString(System.Math.Acos(Convert.ToDouble(textBoxoperand1.Text)) * 57.296);
              inputstatus = false;
            }

        }

        private void btntaninverse_Click(object sender, EventArgs e)
        {
            if (radioBtnradian.Checked == true)
            {
                txtDisplay.Text = Convert.ToString(System.Math.Atan(Convert.ToDouble(textBoxoperand1.Text)));
                inputstatus = false;
            }
            else
            {
                txtDisplay.Text = Convert.ToString(System.Math.Atan(Convert.ToDouble(textBoxoperand1.Text)) * 57.296);
                 inputstatus = false;
            }
        }

       

       
         
        
    

       

       
        
        
       

       



       
    }
}
           /* if (plusButtonClicked == true)
            {
                total2 = (Convert.ToDouble(textBoxoperand1.Text)) + (Convert.ToDouble(textBoxoperand2.Text));
                // total2 = total1 + double.Parse(txtDisplay.Text);
            }
            else if (minusButtonClicked == true)
            {
                total2 = (Convert.ToDouble(textBoxoperand1.Text)) - (Convert.ToDouble(textBoxoperand2.Text));
                // total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (multiplyButtonClicked == true)
            {
                total2 = (Convert.ToDouble(textBoxoperand1.Text)) * (Convert.ToDouble(textBoxoperand2.Text));
                //total2 = total1 * double.Parse(txtDisplay.Text);
            }
            else if (divideButtonClicked == true)
            {
                total2 = (Convert.ToDouble(textBoxoperand1.Text)) / (Convert.ToDouble(textBoxoperand2.Text));
                //total2 = total1 / double.Parse(txtDisplay.Text);
            }

            txtDisplay.Text = total2.ToString();
            total1 = 0;
        }*/

 
        //string theOperator;
        //Dim num1 As Integer
        //dim num2 As Integer
        //int i = 0;
        

        /* void btnEvent_click(object sender, EventArgs e)
         {
           
          if ((Control)sender).BackColor != Color.Red)
             (Control)sender).BackColor = Color.Red;
         else 
             (Control)sender).BackColor = Color.Green;
         }
    }*/
        
         /*private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.NumPad5))
            {
                //assuming button5 will set the value 5
                btn5.PerformClick();
            }
        
        }*/

        
    

  /* private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
             {
                 ////validating txtNumber textbox to accept only numeric digit
                 if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                 {
                     e.Handled = true;
                 }

             }*/

      
        

    


