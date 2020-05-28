using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STO_Test.Model;

namespace STO_Test.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCars_Click(object sender, EventArgs e)
        {
            var dbHandler = new DbHandler();

            dbHandler.GetCarsByType("SportCar");
        }
    }
}
