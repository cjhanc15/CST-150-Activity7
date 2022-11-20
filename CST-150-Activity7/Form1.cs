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
            int noTerms;
            Boolean isValidInteger = int.TryParse(terms.Text, out noTerms);

            double pi = 4.0;
            double counter = 3.0;

            for (int i = 0; i < noTerms; i++)
            {
                if(i % 2 == 0) pi -= (4.0 / (counter));
                else pi += (4.0/ (counter));
                counter += 2.0;
            }
                answer.Text = pi.ToString();
        }
    }
}
