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
        private Random rnd = new Random();

        public Startseite()
        {
            InitializeComponent();
        }
        private void Nam1_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            ProgrammerName.ForeColor = randomColor;
        }
        private void revert_color()
        {
            ProgrammerName.ForeColor = Color.Azure;
        }
/// Öffnen einer neuen Form
        private void KontaktButton_Click(object sender, EventArgs e)
        {
            var OpenNew = new Kontakte();
            this.Hide();
            revert_color();
            OpenNew.ShowDialog();
            ///Wenn neue Form geschlossen wird, wird die Startseite wieder angezeigt
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
    }
}
