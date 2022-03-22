using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NandniWeb
{
    public partial class Test2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text.Length == 0)
            {
                err.InnerText = "Enter number in Textbox";
            }
            else
            {

                int num, binVal, decVal = 0, baseVal = 1, rem;
                num = Convert.ToInt32(TextBox1.Text);
                binVal = num;
                while (num > 0)
                {
                    rem = num % 10;
                    decVal = decVal + rem * baseVal;
                    num = num / 10;
                    baseVal = baseVal * 2;
                }

                err.InnerText = "";

                myValue.InnerText = "Binary Number : " + binVal;
                myResult.InnerText = "Decimal Value : " + decVal;

            }


        }
    }
}