using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    public class StkPrce
    {//start of get and set methods
        private String StkAbrv;

        public String stkabrv //property
        {
            get { return StkAbrv; }
            set
            {
                if (value != null)

                    StkAbrv = value;
                else

                    throw new InvalidOperationException("Stock Abreviation cannot be empty!");
            }
        }


        private String CmpnyName;

        public String cmpnyname
        {
            get { return CmpnyName; }
            set {

                if (value != null)
               
                CmpnyName = value;

                else

                throw new InvalidOperationException("Company Name cannot be empty!");
            
            }

        }
        private Double OpnPrce;

        public Double opnprce
        {
            get { return OpnPrce; }
            set
            {
                if (value >= 0)

                    OpnPrce = value;
                else

                    throw new InvalidOperationException("Opening Price cannot be negative!!"); ;
            }
        }

        private Double HghPrce;

        public Double hghprce
        {
            get { return HghPrce; }
            set
            {
                if (value >= 0)

                    HghPrce = value;
                else

                    throw new InvalidOperationException("High Price cannot be negative!!"); 
            }
        }
        private Double LwPrce;

        public Double lwprce
        {
            get { return LwPrce; }
            set
            {
                if (value >= 0)

                    LwPrce = value;
                else

                    throw new InvalidOperationException("Low Price cannot be negative!!"); 
            }
        }
        private Double ClsPrce;

        public Double clsprce
        {
            get { return ClsPrce; }
            set
            {
                if (value >= 0)

                    ClsPrce = value;
                else

                    throw new InvalidOperationException("Closing Price cannot be negative!!"); ;
            }
        }
        private DateTime Dte;
       

        public DateTime dte
        {
            get { return Dte; }
            set { Dte = value; }
        }
        //end of get and set methods

        public StkPrce(String StkAbrv, String CmpnyName, Double OpnPrce, Double HghPrce, Double LwPrce, Double ClsPrce, DateTime Date)
   {
        this.StkAbrv = StkAbrv;
        this.CmpnyName = CmpnyName;
        this.OpnPrce = OpnPrce;
        this.HghPrce = HghPrce;
        this.LwPrce = LwPrce;
        this.ClsPrce = ClsPrce;
        this.Dte = Date;

        }

        public StkPrce()
        {
            // TODO: Complete member initialization
        }

       

        public override string ToString() //custom toString method that returns 3 values
        {
            return CmpnyName + "," + " " + StkAbrv + "," + " " + Dte + ", "+hghprce;
        }
    }
}
