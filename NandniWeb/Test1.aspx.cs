using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NandniWeb
{
    public partial class Test1 : System.Web.UI.Page
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
            else {
                int decVal;
                int val;
                string a = "";
                decVal = Convert.ToInt32(TextBox1.Text);

                while (decVal >= 1)
                {
                    val = decVal / 2;
                    a += (decVal % 2).ToString();
                    decVal = val;
                }
                string binValue = "";
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    binValue = binValue + a[i];
                }
                err.InnerText = "";

                myValue.InnerText = "Original Value : "+TextBox1.Text;
                myResult.InnerText = "Binary Value : "+ binValue;
            }
            


        }
    }
}