using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_SoftWare2
{
    public partial class AddEmpForm : Form
    {
        public AddEmpForm()
        {
            InitializeComponent();
        }

        int demClick = 0;
        private void ClickCalender(object sender, EventArgs e)
        {
            demClick++;
            if (demClick % 2 == 0) monthCalendar1.Visible = false;
            else monthCalendar1.Visible = true;
        }

    }
}
