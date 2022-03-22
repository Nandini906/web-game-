using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NandniWeb
{
    public partial class Test4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                err.InnerText = "Enter value in Textbox";
            }
            else
            {
                
                string hex_value = TextBox1.Text;

                int int_value = Convert.ToInt32(hex_value, 16);

                err.InnerText = "";
                myValue.InnerText = "Hexadecimal Value : " + hex_value;
                myResult.InnerText = "Decimal Value : " + int_value.ToString();


            }
        }
    }
}