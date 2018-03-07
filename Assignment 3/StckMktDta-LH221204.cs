using System;using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class StchMktDta : Form
    {
        Boolean svedta = false; //set to true on data change to show change
        String opndfle = null; //holds the last file opened or saved to

        public StchMktDta()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void exitMnuItm_Click(object sender, EventArgs e)
        {
            this.Close(); // close/exit the program
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            int i = stkBox.SelectedIndex;
            if (i < 0) // if nothing is selected warn the user and return, otherwise delete from list
            {
                MessageBox.Show("You must select a stock  from the list first!");
                return;
            }
            stkBox.Items.RemoveAt(i);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                stkDlg newstkDlg;
                newstkDlg = new stkDlg();
                if (newstkDlg.ShowDialog() == DialogResult.OK)// if user pressed ok, add stock object to list
                {
                    StkPrce newStk = newstkDlg.stckprceobj();
                    stkBox.Items.Add(newStk);
                }
            }

            catch
            {
                MessageBox.Show("Cannot leave fields empty!", "Error");
            }
        }

        private void updteBtn_Click(object sender, EventArgs e)
        {
            int ndx = stkBox.SelectedIndex;
            if (ndx < 0) // if no stock is selected in the list box
                
            {

                MessageBox.Show("You must select a stock  from the list first!");
                return;
            }


            try{
            StkPrce old = (StkPrce)stkBox.SelectedItem;
           

            stkDlg newstkDlg;
            newstkDlg = new stkDlg(old);


            if (newstkDlg.ShowDialog() == DialogResult.OK)
            {

                StkPrce newStk = newstkDlg.stckprceobj();


                stkBox.Items.RemoveAt(ndx);
                stkBox.Items.Insert(ndx, newStk);
            }
        }
            
            catch(InvalidCastException)
            {
                 MessageBox.Show("Unable to update", "Error");
                 return;
            }
        }
          

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (svedta == true) // if the data has changed go to the nested if statement
            {
                if(MessageBox.Show(this, "Do you want to save the current data before creating a new file?", "New", MessageBoxButtons.YesNo) == DialogResult.Yes)

                sveMnuItm_Click(sender, e); // if the user selects yes, execute the following

            }


            stkBox.Items.Clear();// clear the list box
            Text = "Stock Market Data"; // reset the title
            svedta = false; // clear needs save 
            opndfle = null; // reset the last file

        }

        private void sveMnuItm_Click(object sender, EventArgs e)
        {
            if (opndfle == null) 

            sveasMnuItm_Click(sender, e); // If file  null call the save as method


            else
            {

                System.IO.StreamWriter writer = new System.IO.StreamWriter(opndfle);
                for (int i = 0; i < stkBox.Items.Count; i++)
                {
                    writer.WriteLine(stkBox.Items[i]);
                }
                writer.Close();
                writer.Dispose();
                svedta = false; // clear needs save 
            }
        }

        private void sveasMnuItm_Click(object sender, EventArgs e)
        {

            if (sveFleDlg.ShowDialog() == DialogResult.Cancel) // 

            return; // return if cancel  is pressed


            opndfle = sveFleDlg.FileName; // save the name of the file and store it


            Text = "Stock Market Data" + opndfle;// reset the text

            svedta = false; // reset save data
        }

        private void opnMnuItm_Click(object sender, EventArgs e)
        {
           opndfle = opnFleDlg.FileName;

            if (svedta) // check if the current data in the list box needs to be saved
            {

                if (MessageBox.Show(this, "Do you want to save the current data before opening a new file?", "Open", MessageBoxButtons.YesNo) == DialogResult.Yes)

                    sveMnuItm_Click(sender, e); // if yes is clicked and the users needs to save the data, call the save method
            }

            if (opnFleDlg.ShowDialog() == DialogResult.Cancel)

            return;//if user selects cancel, return, otherwise execute the folllowing code

           
            stkBox.Items.Clear(); // clear the data from the listbox

            try
            {

                System.IO.StreamReader stkrdr = new System.IO.StreamReader(opndfle);//read the file
                String[] stkfle;//create array
                Char[] dl = { '\t' }; //delimit file by tab
                String stklne = stkrdr.ReadLine();//read the first line of  the file


                while (stklne != null) // keep reading until the line returns null(EOF)
                {
                    stkfle = stklne.Split(dl);  // seperate the delimited text
                    StkPrce stock = new StkPrce();
                    stock.cmpnyname = stkfle[0];
                    stock.stkabrv = stkfle[1];
                    stock.opnprce = Double.Parse(stkfle[2]);

                    int year = Int32.Parse(stkfle[7]);
                    int month = Int32.Parse(stkfle[8]);
                    int day = Int32.Parse(stkfle[9]);

                    stock.date = new DateTime(year, month, day);

                    stkBox.Items.Add(stock); // add delimeted text to the list box
                    stklne = stkrdr.ReadLine();
                }



                stkrdr.Close(); // close the file
                stkrdr.Dispose();  // make sure its fully released
            }
            catch (Exception ex)
            {
            }

        }

        private void opnFleDlg_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void sveFleDlg_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void sveMnuItm_Click_1(object sender, EventArgs e)
        {
        
        }
    }
}
