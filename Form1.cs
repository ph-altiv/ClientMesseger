using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientMesseger.Classes;

namespace ClientMesseger
{
    public partial class fMainWindow : Form
    {
        public fMainWindow()
        {
            InitializeComponent();
        }

        private void bAuthorization_Click(object sender, EventArgs e)
        {
            Client client = new Client("127.0.0.1", 6487);
        }
    }
}
