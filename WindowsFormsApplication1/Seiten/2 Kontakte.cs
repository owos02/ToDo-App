using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Seiten
{
    public partial class Kontakte : Form
    {
        private int EDIT_RowIndex = 0;
        static private int Index;
        public Kontakte()
        {
            InitializeComponent();
            editBox.Visible = false;
            editbtnSave.Visible = false;
        }
        private void _2_Kontakte_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "kundenDataSet.Kunden". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundenTableAdapter.Fill(this.kundenDataSet.Kunden);
            kundenDataGridView.ClearSelection();
            Index = kundenDataSet.Kunden.Count() + 1;
            //this.reportViewer1.RefreshReport();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (AddName.Text != String.Empty && AddOrt.Text != String.Empty && AddStreet.Text != String.Empty && AddTel.Text != String.Empty)
            {
                Index += 1;

                kundenTableAdapter.Insert(AddName.Text, AddStreet.Text, AddOrt.Text, Convert.ToInt32(AddTel.Text));
                kundenTableAdapter.Fill(kundenDataSet.Kunden);

                this.Refresh();

                AddName.Text = String.Empty;
                AddOrt.Text = String.Empty;
                AddStreet.Text = String.Empty;
                AddTel.Text = String.Empty;
            }
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            if (kundenDataGridView.SelectedRows.Count != 0) // PROBLEM
            {
                EDIT_RowIndex = kundenDataGridView.SelectedCells[0].RowIndex;
                btndelete.Visible = false;
                addBox.Visible = false;
                editBox.Location = new Point(424, 184);
                editBox.Visible = true;
                editBox.Location = new Point(424, 32);
                editbtnSave.Visible = true;
                editbtnSave.Location = new Point(592, 128);

                int selrow = kundenDataGridView.SelectedCells[0].RowIndex;
                editID.Text = kundenDataGridView.Rows[selrow].Cells[0].Value.ToString();
                editName.Text = kundenDataGridView.Rows[selrow].Cells[1].Value.ToString();
                editStreet.Text = kundenDataGridView.Rows[selrow].Cells[2].Value.ToString();
                editOrt.Text = kundenDataGridView.Rows[selrow].Cells[3].Value.ToString();
                editTel.Text = kundenDataGridView.Rows[selrow].Cells[4].Value.ToString();
            }
            else MessageBox.Show("Bitte wähle ein Kontakt aus!");
        }
        private void editbtnSave_Click(object sender, EventArgs e)
        {
            editBox.Visible = false;
            editBox.Location = new Point(424, 184);
            addBox.Visible = true;
            addBox.Location = new Point(424, 32);
            btndelete.Visible = true;
            editbtnSave.Visible = false;
            editbtnSave.Location = new Point(592, 190);

            //edit in Datenbank neu rein schreiben
            int seledit = EDIT_RowIndex;
            kundenTableAdapter.Update(editName.Text, editStreet.Text, editOrt.Text, Convert.ToInt32(editTel.Text), Convert.ToInt32(kundenDataGridView.Rows[seledit].Cells[0].Value.ToString()), kundenDataGridView.Rows[seledit].Cells[3].Value.ToString(), Convert.ToInt32(kundenDataGridView.Rows[seledit].Cells[4].Value.ToString()));
            //in DGV rein schreiben
            kundenTableAdapter.Fill(kundenDataSet.Kunden);
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            int selDel = kundenDataGridView.SelectedCells[0].RowIndex;

            kundenTableAdapter.Delete(Convert.ToInt32(kundenDataGridView.Rows[selDel].Cells[0].Value), kundenDataGridView.Rows[selDel].Cells[3].Value.ToString(), Convert.ToInt32(kundenDataGridView.Rows[selDel].Cells[4].Value));
            kundenTableAdapter.Fill(kundenDataSet.Kunden);
        }
    }
}
