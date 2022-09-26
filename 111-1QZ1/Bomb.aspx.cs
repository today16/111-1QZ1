using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1QZ1
{
    public partial class Bomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ia_Map = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            char[,] ia_MIndex = new char[10, 10];

            int i_Row, i_Col;
            for (i_Row = 0; i_Row < 10; i_Row++)
            {
                for (i_Col = 0; i_Col < 10; i_Col++)
                {
                    Response.Write("o");
                }
                Response.Write("<br />");
            }

            ia_MIndex[] =  ia_Map / 10 

        }
    }
}