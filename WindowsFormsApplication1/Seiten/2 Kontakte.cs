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
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {

            //Neuer Kontakt wird angelegt
            if (AddName.Text != String.Empty && AddOrt.Text != String.Empty && AddStreet.Text != String.Empty && AddTel.Text != String.Empty && Int32.TryParse(AddTel.Text, out int int_tel))
            {
                Index += 1;

                //Werte in den TableAdapter schreiben
                kundenTableAdapter.Insert(AddName.Text, AddStreet.Text, AddOrt.Text, int_tel);
                //Werte des TableAdapters in die Datenbank übernehmen
                kundenTableAdapter.Fill(kundenDataSet.Kunden);

                this.Refresh();

                AddName.Text = String.Empty;
                AddOrt.Text = String.Empty;
                AddStreet.Text = String.Empty;
                AddTel.Text = String.Empty;
            }
            else MessageBox.Show("FEHLER! Bitte Überprüfen sie die Eingabe.");
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            //Bestehenden Kontak bearbeiten
            if (kundenDataGridView.SelectedRows.Count != 0) // PROBLEM
            {
                //Daten des Kontaktes in der Maske ausgeben
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
            //Bearbeitete Daten Übernehmen und speichern
            editBox.Visible = false;
            editBox.Location = new Point(424, 184);
            addBox.Visible = true;
            addBox.Location = new Point(424, 32);
            btndelete.Visible = true;
            editbtnSave.Visible = false;
            editbtnSave.Location = new Point(592, 190);

            //Editierte Daten in dem TableAdapter schreiben
            int seledit = EDIT_RowIndex;
            kundenTableAdapter.Update(editName.Text, editStreet.Text, editOrt.Text, Convert.ToInt32(editTel.Text), Convert.ToInt32(kundenDataGridView.Rows[seledit].Cells[0].Value.ToString()), kundenDataGridView.Rows[seledit].Cells[3].Value.ToString(), Convert.ToInt32(kundenDataGridView.Rows[seledit].Cells[4].Value.ToString()));
            //TableAdapter in die Datenbank Übernehmen
            kundenTableAdapter.Fill(kundenDataSet.Kunden);
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            //Löschen sichergehen
            DialogResult dialogResult = MessageBox.Show("Wollen Sie wirklich den Kontakt Löschen?", "Warnung", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) //Wenn 'Ja' gedrückt wurde
            {
                //Vorhandenen Kontakt Löschen
                int selDel = kundenDataGridView.SelectedCells[0].RowIndex;

                //Kontakt aus dem TableAdapter löschen
                kundenTableAdapter.Delete(Convert.ToInt32(kundenDataGridView.Rows[selDel].Cells[0].Value), kundenDataGridView.Rows[selDel].Cells[3].Value.ToString(), Convert.ToInt32(kundenDataGridView.Rows[selDel].Cells[4].Value));
                //Änderung des TableAdapters in die Dantenbank übernehmen
                kundenTableAdapter.Fill(kundenDataSet.Kunden);
            }     
        }

        private void kundenDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            //Rechtsklick auf einen Kontakt
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = kundenDataGridView.HitTest(e.X, e.Y).RowIndex;

                kundenDataGridView.Rows[currentMouseOverRow].Selected = true;
                
                //ContextMenu für Rechtsklick erstellen
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Berabeiten"));
                m.MenuItems.Add(new MenuItem("Löschen"));
                m.MenuItems.Add(new MenuItem("Google Maps"));

                //Funktionen für die ContextMenu Items
                m.MenuItems[0].Click += new EventHandler(btnedit_Click);
                m.MenuItems[1].Click += new EventHandler(btndelete_Click);
                m.MenuItems[2].Click += new EventHandler(GoogleMaps);

                //ContextMenu anzeigen
                m.Show(kundenDataGridView, new Point(e.X, e.Y));
            }
        }

        private void GoogleMaps(object sender, EventArgs e)
        {
            //Route zum Kontakt planen
            //http://maps.google.com/maps?daddr=STRAßE+HAUSNUMMER+POSTLEIZAHL+ORT

            int selected_row = kundenDataGridView.SelectedCells[0].RowIndex;
            string straße_hausnummer = kundenDataGridView.Rows[selected_row].Cells[2].Value.ToString();
            string plz_ort = kundenDataGridView.Rows[selected_row].Cells[3].Value.ToString();

            //Default browser öffen mit der URL
            System.Diagnostics.Process.Start("http://maps.google.com/maps?daddr=" + straße_hausnummer + "+" + plz_ort);
        }
    }
}
