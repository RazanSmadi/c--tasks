using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _30._11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int x;
        static char op;
        protected void Button1_Click(object sender, EventArgs e)
        {
            input.InnerText += 1;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            input.InnerText += 2;

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            input.InnerText += 3;

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            input.InnerText += 4;

        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            input.InnerText += 5;

        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            input.InnerText += 6;

        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            input.InnerText += 7;

        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            input.InnerText += 8;

        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            input.InnerText += 9;

        }
        protected void Button0_Click(object sender, EventArgs e)
        {
            input.InnerText += 0;

        }
        protected void ButtonAdd_Click(object sender, EventArgs e)
        {

            x = Convert.ToInt32(input.InnerHtml);
            op = '+';
            input.InnerText += "+";


        }
        protected void ButtonSub_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(input.InnerHtml);

            op = '-';
            input.InnerText += "-";

        }
        protected void ButtonMult_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(input.InnerHtml);

            op = '*';

            input.InnerText += "*";
        }
        protected void ButtonDiv_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(input.InnerHtml);

            op = '/';

            input.InnerText += "/";
        }

        protected void ButtonEqual_Click(object sender, EventArgs e)
        {
            string temp = input.InnerText;
            string[] array = new string[] { "", "" };
            int result;
            if (op == '+')
            {
                array = temp.Split('+');

                temp = array[1];
                result = Convert.ToInt32(temp);
                final.InnerText = Convert.ToString(x + result);

            }
            if (op == '-')
            {
                array = temp.Split('-');
                temp = array[1];
                result = Convert.ToInt32(temp);
                final.InnerText = Convert.ToString(x - result);
            }
            if (op == '/')
            {
                array = temp.Split('/');
                temp = array[1];
                result = Convert.ToInt32(temp);
                final.InnerText = Convert.ToString(x / result);
            }
            if (op == '*')
            {
                array = temp.Split('*');
                temp = array[1];
                result = Convert.ToInt32(temp);
                final.InnerText = Convert.ToString(x * result);
            }
        }


    }


}