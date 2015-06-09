using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using net.UyghurDev.Text;
using System.Text;

public partial class Syllable_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnTranclate_Click(object sender, EventArgs e)
    {
        Syllable objSyllables = new Syllable();
        StringBuilder sb = new StringBuilder();
        if (!String.IsNullOrEmpty(txtSource.Text))
        {
            string[] straWords = txtSource.Text.Split(' ');
            foreach (string str in straWords)
            {
                foreach (string strSyllable in objSyllables.getSyllable(str))
                {
                    sb.Append(strSyllable + "/");
                }

            }
        }

        ltrlSyllables.Text = sb.ToString();
    }
}
