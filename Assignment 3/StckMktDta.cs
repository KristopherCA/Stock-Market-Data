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
    public partial class StkMktDta : Form
    {
        Boolean svedta = false; //set to true on data change to show change
        String opndfle = null; //holds the last file opened or saved to
        SolidBrush sb = new SolidBrush(Color.Black); // set the initial brush color to black

        public StkMktDta()
        {
            InitializeComponent();
        }

        private void stkBox_SelectedIndexChanged(object sender, EventArgs e)
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
                    stkBox.Items.Add(newStk); //add new stock to the list
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Bad data, cannot add to the list!", "Error");
            }
        }

        private void updteBtn_Click(object sender, EventArgs e)
        {
            int ndx = stkBox.SelectedIndex;
            if (ndx < 0) // if no stock is selected in the list box
            {

                MessageBox.Show("You must select a stock  from the list first!", "Attention");
                return;
            }


            try
            {
                StkPrce old = (StkPrce)stkBox.SelectedItem; //get selected item and covert it to StkPrce and store it


                stkDlg newstkDlg;
                newstkDlg = new stkDlg(old);// construct a StkDlg that takes the selected item as parameters


                if (newstkDlg.ShowDialog() == DialogResult.OK)
                {

                    StkPrce newStk = newstkDlg.stckprceobj();


                    stkBox.Items.RemoveAt(ndx);// remove the selected stock
                    stkBox.Items.Insert(ndx, newStk); // insert updated stock information at same location in the list
                }
            }

            catch (InvalidCastException)
            {
                MessageBox.Show("Unable to update", "Error");
                return;
            }
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (svedta) // if the data has changed go to the nested if statement
            {
                if (MessageBox.Show(this, "Do you want to save the current data before creating a new file?", "New", MessageBoxButtons.YesNo) == DialogResult.Yes)

                    sveMnuItm_Click(sender, e); // if the user selects yes, execute the following

            }


            stkBox.Items.Clear();// clear the list box
            Text = "Stock Market Data"; // reset the title
            svedta = false; // clear needs save 
            opndfle = null; // reset the last file

        }

        private void sveMnuItm_Click(object sender, EventArgs e)
        {
            if (opndfle == null) // if thte file hasn't changed

                sveasMnuItm_Click(sender, e); // If file  null call the save as method


            else
            {
                try
                {

                    System.IO.StreamWriter stkwrtr = new System.IO.StreamWriter(opndfle);// write to the file



                    for (int i = 0; i < stkBox.Items.Count; i++)//set i to 0, if i is less than the number of items in the list box, increment by 1
                    {

                        stkwrtr.WriteLine(stkBox.Items[i]);
                    }
                    stkwrtr.Close(); // close writer
                    stkwrtr.Dispose(); // fully release
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Cant write to file!", "Error");
                    return;
                }
                svedta = false; // clear save data 
            }
        }

        private void sveasMnuItm_Click(object sender, EventArgs e)
        {

            if (sveFleDlg.ShowDialog() == DialogResult.Cancel) // 

                return; // return if cancel  is pressed


            opndfle = sveFleDlg.FileName; // save the name of the file and store it



            try
            {


                System.IO.StreamWriter stkwrtr = new System.IO.StreamWriter(opndfle);// write to the file


                for (int i = 0; i < stkBox.Items.Count; i++)//set i to 0, if i is less than the number of items in the list box, increment by 1
                {

                    StkPrce stk = (StkPrce)stkBox.Items[i]; //get the 1st stock price object


                    stkwrtr.Write(stk.cmpnyname);
                    stkwrtr.Write("\t");
                    stkwrtr.Write(stk.stkabrv);
                    stkwrtr.Write("\t");
                    stkwrtr.Write(stk.opnprce);
                    stkwrtr.Write("\t");
                    stkwrtr.Write(stk.hghprce);
                    stkwrtr.Write("\t");
                    stkwrtr.Write(stk.lwprce);
                    stkwrtr.Write("\t");
                    stkwrtr.Write(stk.clsprce);
                    stkwrtr.Write("\t");
                    stkwrtr.Write(stk.dte);

                }

                stkwrtr.Close();// close the writer 
                stkwrtr.Dispose();  // make sure the reader is fully released

            }
            catch (Exception)
            {
                MessageBox.Show(this, "Cant write to file!", "Error");
                return;
            }

            Text = "Stock Market Data";// reset the text

            svedta = false; // reset save data
        }

        private void opnMnuItm_Click(object sender, EventArgs e)
        {


            if (svedta) // check if the current data in the list box needs to be saved
            {

                if (MessageBox.Show(this, "Do you want to save the current data before opening a new file?", "Open", MessageBoxButtons.YesNo) == DialogResult.Yes)

                    sveMnuItm_Click(sender, e); // if yes is clicked and the users needs to save the data, call the save method
            }

            if (opnFleDlg.ShowDialog() == DialogResult.Cancel)
            {
                return;//if user selects cancel, return, otherwise execute the folllowing code

            }

            stkBox.Items.Clear();

            opndfle = opnFleDlg.FileName; //get and save the file name

            try
            {

                System.IO.StreamReader stkrdr = new System.IO.StreamReader(opndfle);//read the file
                String[] stkfle;//create array
                Char[] dl = { '\t' }; //delimit file by tab
                String stklne = stkrdr.ReadLine();//read the first line of  the file


                while (stklne != null) // keep reading until the line returns null(EOF)
                {
                    stkfle = stklne.Split(dl);  // seperate the delimited text

                    StkPrce stock = new StkPrce(); //create object 
                    stock.cmpnyname = stkfle[0];
                    stock.stkabrv = stkfle[1];
                    stock.opnprce = Double.Parse(stkfle[2]);
                    stock.hghprce = Double.Parse(stkfle[3]);

                    stock.lwprce = Double.Parse(stkfle[4]);
                    stock.clsprce = Double.Parse(stkfle[5]);



                    String stringdate = stkfle[6];
                    DateTimeConverter dat = new DateTimeConverter();

                    //      stock.dte = new DateTime(year, month, day);
                    stock.dte = (DateTime)dat.ConvertFromString(stringdate);


                    stkBox.Items.Add(stock); // add delimited text to the list box
                    stklne = stkrdr.ReadLine();
                }

                stkrdr.Close(); // close the file
                stkrdr.Dispose();  // make sure the reader is fully released
                Text = "Stock Market Data";// reset the text

            }

            catch (Exception)
            {
                MessageBox.Show(this, "Unable to read file", "Error");
                return;
            }

        }


        private void opnFleDlg_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void sveFleDlg_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void addMnuItm_Click(object sender, EventArgs e)
        {
            addBtn_Click(sender, e);
        }

        private void updteMnuItm_Click(object sender, EventArgs e)
        {
            updteBtn_Click(sender, e);

        }

        private void dltMnuItm_Click(object sender, EventArgs e)
        {
            dltBtn_Click(sender, e);
        }

        private void abtMnuItm_Click(object sender, EventArgs e)
        {


            MessageBox.Show(this, "Stock Market Data\nKris Andrews\nVersion 1.0\nCreated on February 1st, 2013", "About");
        }

        private void hlpMnuItm_Click(object sender, EventArgs e)
        {
            stkHlp newstkHlp;
            newstkHlp = new stkHlp(); // create ne stock help

            if (newstkHlp.ShowDialog() == DialogResult.Cancel)// if user hits cancel return
            {
                return;
            }
        }

        private void clrpkBtn_Click(object sender, EventArgs e)
        {
            ColorDialog clrDlg = new ColorDialog();//create new color dialog

            if (clrDlg.ShowDialog() == DialogResult.OK)//make dialog visible
            {

                sb = new SolidBrush(clrDlg.Color);//create a solidbrush that's the color chosen in the color dialog
            }

            return;  // retutn if user pressed cancel
        }

        private void pltBtn_Click(object sender, EventArgs e)
        {
            if (stkBox.Items.Count == 0)// if there are no items in the list box
            {
                MessageBox.Show("There are no stocks in the list to plot", "Error");
                return;
            }


            Graphics gfx = stkdtaPanl.CreateGraphics(); //create graphics object

            try
            {
                int wth = stkdtaPanl.Width;// set width based on number of stocks in the list
                int hght = stkdtaPanl.Height;

                double mxvlue = Convert.ToDouble(mxvlu()); // use a double to force floating point arithemetic
                double yscle = hght / mxvlue; //set the y scale to height divided by max value

                int brspce = wth / stkBox.Items.Count; //set the space between bars as width divided by number of items in the list
                int brwth = brspce / 2; // set bar width to bar space divided by 2

                int xcrd = brwth; //set x coordinate to bar width
                int ycrd = 0; // set y coordinate to 0

                for (int i = 0; i < stkBox.Items.Count; i++)//set i to 0, if i is less than the number of items in the list box, increment by 1
                {
                    StkPrce stk = (StkPrce)(stkBox.Items[i]);
                    Double yprse = (Double)(stk.clsprce);
                    ycrd = (int)(yprse * yscle);
                    String clsePrceStr = yprse.ToString("0.00");


                    gfx.FillRectangle(sb, xcrd, hght + 30 - ycrd, brwth, ycrd ); // draw solid rectangle with brush at specified coordinates
                    gfx.DrawString("$" + clsePrceStr, SystemFonts.DefaultFont, sb, xcrd, hght + 10 - ycrd); // draw text above bars using default font
                   ;
                    xcrd += brspce; // move x over to next bar 

                }

                gfx.Dispose(); // fully dispose of gfx
                gfx = null;  //set graphics to null

            }
            catch (Exception)
            {
                MessageBox.Show("Unable to plot stock(s)", "Error");

            }
        }


        public double mxvlu() //method that returns the max value of the list
        {


            double mxvlu = ((StkPrce)stkBox.Items[0]).hghprce; //set max value to the first item in the listbox


            for (int i = 0; i < stkBox.Items.Count; i++) //set i to 0, if i is less than the number of items in the list box, increment by 1
            {

                if (((StkPrce)stkBox.Items[i]).hghprce > mxvlu)
                    mxvlu = ((StkPrce)stkBox.Items[i]).hghprce; //  cast to int and set mxvlu to the current value of the listbox

            }

            return mxvlu; // return value to its calling method



        }

        private void clrBtn_Click(object sender, EventArgs e)
        {

            Graphics gfx = stkdtaPanl.CreateGraphics(); //create graphics object
            gfx.Clear(stkdtaPanl.BackColor); //clear the panel of any graphics the set panel to the same color as program

            gfx.Dispose(); // dispose of graphics object
            gfx = null; // set graphics object to null

        }
    }
}
