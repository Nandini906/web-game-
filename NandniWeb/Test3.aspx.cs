using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NandniWeb
{
    public partial class Test3 : System.Web.UI.Page
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
                int decimalNumber, quotient;
                int i = 1, j, temp = 0;
                char[] hexadecimalNumber = new char[100];
                char temp1;
                string hexNum = "";

                decimalNumber = int.Parse(TextBox1.Text);
                quotient = decimalNumber;
                while (quotient != 0)
                {
                    temp = quotient % 16;
                    if (temp < 10)
                        temp = temp + 48;
                    else
                        temp = temp + 55;
                    temp1 = Convert.ToChar(temp);
                    hexadecimalNumber[i++] = temp1;
                    quotient = quotient / 16;
                }


                for (j = i - 1; j > 0; j--)
                {
                    hexNum = hexNum + hexadecimalNumber[j];

                }

                err.InnerText = "";
                myValue.InnerText = "Decimal Value : " + decimalNumber.ToString();
                myResult.InnerText = "Hexadecimal Value : " + hexNum;

            }

        }
    }
}