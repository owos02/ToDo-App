using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Seiten;

namespace WindowsFormsApplication1
{
    public partial class Startseite : Form
    {

        public Startseite()
        {
            InitializeComponent();
            //MessageBox.Show("Das aktuelle verzeichnis:" + Environment.CurrentDirectory);
            //test
            
        }
        private void revert_color()
        {
            ProgrammerName.ForeColor = Color.Azure;
        }
        private void KontaktButton_Click(object sender, EventArgs e)
        {
            var OpenNew = new Kontakte();
            this.Hide();
            revert_color();
            OpenNew.ShowDialog();
            this.Show();
        }
        
        private void TODOButton_Click(object sender, EventArgs e)
        {
            var OpenNew = new TODO_Liste();
            this.Hide();
            revert_color();
            OpenNew.ShowDialog();
            this.Show();
        }
        private void Startseite_Load(object sender, EventArgs e)
        {
            this.Validate();
        }
        private Random rnd = new Random();
        private void Nam1_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            ProgrammerName.ForeColor = randomColor;
        }
    }
}
