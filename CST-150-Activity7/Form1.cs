using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity7
{
    public partial class findingPi : Form
    {
        public findingPi()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //store number of terms in a variable
            int noTerms;
            Boolean isValidInteger = int.TryParse(terms.Text, out noTerms);

            double pi = 4.0;
            double counter = 3.0;
            //if number of terms is valid, run through calculations, otherwise show error message
            if (isValidInteger && noTerms > -1)
            {
                error.Text = " ";
                for (int i = 0; i < noTerms; i++)
                {   //if even, subtract 4/counter, if odd add
                    if (i % 2 == 0) pi -= (4.0 / (counter));
                    else pi += (4.0 / (counter));
                    //increment counter by 2
                    counter += 2.0;
                }
                answer.Text = pi.ToString();
            } else
            {
                error.Text = "ERROR: Please enter a valid integer!";
                answer.Text = "ERROR";
            }
        }
    }
}
