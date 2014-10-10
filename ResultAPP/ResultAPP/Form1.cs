using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultAPP
{
    public partial class ResultUI : Form
    {
        public ResultUI()
        {
            InitializeComponent();
        }

        private float physics;
        private float chemistry;
        private float mathemetics;
        private void showButton_Click(object sender, EventArgs e)
        {

            physics = Convert.ToInt16(physicsMarkTxtBox.Text);
            chemistry = Convert.ToInt16(chemMarkTxtBox.Text);
            mathemetics = Convert.ToInt16(mathMarkTxtBox.Text);

            Result aResult=new Result(physics, chemistry, mathemetics);

            avarageMarkTxtBox.Text = aResult.GetAvrageRe().ToString();
            gradeTxtBox.Text = aResult.Grade;

        }
    }
}
