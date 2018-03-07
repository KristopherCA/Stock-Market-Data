using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class stkDlg : Form
    {
    
        public stkDlg()
        {
            InitializeComponent();
             
        }


        

         public stkDlg(StkPrce obj) //constructor that takes a stock price object and loads the fields with it
        {
            
                InitializeComponent();
                stkabrvTxtBox.Text = obj.stkabrv;
                cmpnynmeTextBox.Text = obj.cmpnyname;
                opnprceTxtBox.Text = obj.opnprce.ToString("#.00");
                hghprceTxtBox.Text = obj.hghprce.ToString("#.00");
                lwprceTxtBox.Text = obj.lwprce.ToString("#.00");
                clseprceTxtBox.Text = obj.clsprce.ToString("#.00");
                dtePicker.Value = obj.dte;
            

           

        }
          public stkDlg(String StkAbrv, String CmpnyName, Double OpnPrce, Double HghPrce, Double LwPrce, Double ClsPrce, DateTime Dte)
        {
            try
            {
                String stkabrvtxt = stkabrvTxtBox.Text;
                String cmpnynametxt = cmpnynmeTextBox.Text;
                Double opnprcetxt = Double.Parse(opnprceTxtBox.Text);
                Double hghprcetxt = Double.Parse(hghprceTxtBox.Text);
                Double lwprcetxt = Double.Parse(lwprceTxtBox.Text);
                Double clseprcetxt = Double.Parse(clseprceTxtBox.Text);
                DateTime dte = dtePicker.Value;

            }


            catch (Exception)
            {
                MessageBox.Show("Incorrect Format!", "Error");
            }

            
            
        }


   public StkPrce stckprceobj() //method that creates a stock price object then returns it to its  caller
   {
       
           StkPrce obj = new StkPrce();
           obj.stkabrv = stkabrvTxtBox.Text;
           obj.cmpnyname = cmpnynmeTextBox.Text;
           obj.opnprce = Double.Parse(opnprceTxtBox.Text);
           obj.hghprce = Double.Parse(hghprceTxtBox.Text);
           obj.lwprce = Double.Parse(lwprceTxtBox.Text);
           obj.clsprce = Double.Parse(clseprceTxtBox.Text);
           obj.dte = dtePicker.Value;

           return obj;

       }
      
  
    

        private void clsBtn_Click(object sender, EventArgs e)
        {

            
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
           
            
        }

        private void stkabrvTxtBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void stkDlg_Load(object sender, EventArgs e)
        {

        }
    }
}
