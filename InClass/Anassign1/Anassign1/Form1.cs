/* anassign1.cs
* This program shows ITID instructor information
*
* Revision 1
* Anton Nepsha, 2013.09.05: Created
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anassign1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowPR_InstructorInfo_Click(object sender, EventArgs e)
        {
            InstructorName.Text = "Shawn Morgan";
            InstructorEmail.Text = "smorgan@conestogac.on.ca";
        }

        private void ShowET_InstructorInfo_Click(object sender, EventArgs e)
        {
            InstructorName.Text = "Teresa MacVicar";
            InstructorEmail.Text = "tmacvicar@conestogac.on.ca";
        }

        private void ShowTI_InstructorInfo_Click(object sender, EventArgs e)
        {
            InstructorName.Text = "Pawel Czarny";
            InstructorEmail.Text = "pczarny@conestogac.on.ca";
        }

        private void ShowIG_InstructorInfo_Click(object sender, EventArgs e)
        {
            InstructorName.Text = "Peter Marshall";
            InstructorEmail.Text = "pmarshall@conestogac.on.ca";
        }

        private void ShowMath_InstructorInfo_Click(object sender, EventArgs e)
        {
            InstructorName.Text = "John Akinyemi";
            InstructorEmail.Text = "jakinyemi@conestogac.on.ca";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
