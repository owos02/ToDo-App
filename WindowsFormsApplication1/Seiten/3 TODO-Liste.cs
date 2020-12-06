using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class TODO_Liste : Form
    {
        bool expandallcheck = false;
        bool WarnCheck =false;
        static string tv1path = Environment.CurrentDirectory + @"\TVSave.txt";
        private void SaveDeserializing()
        {
            using (Stream file = File.Open(tv1path, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, treeView1.Nodes.Cast<TreeNode>().ToList());
            }
        }
        public TODO_Liste()
        {
            InitializeComponent();
            treeView1.ImageList = new ImageList();
            treeView1.ImageList.Images.Add(new Icon(GetType(), "empty.ico"));
            treeView1.ImageList.Images.Add(new Icon(GetType(), "erledigt.ico"));
            treeView1.ImageList.Images.Add(new Icon(GetType(), "nicht_erledigt.ico"));
            //Überprüfung ob etwas in der Datei steht
            if(File.Exists(tv1path))
            {
                string[] checksum = File.ReadAllLines(tv1path);
                if(checksum[0]== "")   
                {
                    File.Delete(tv1path);
                }
            }
        }
        private void TODO_Liste_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "kundenDataSet.Kunden". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundenTableAdapter.Fill(this.kundenDataSet.Kunden);

            //Wie viele Kontakte existieren
            kontzal.Text = Convert.ToString(kundenDataSet.Kunden.Count);

            //Auslesung aus der Datei wenn Vorhanden
            ///Sonst Neuaufbau der TreeView-Struktur
            if(File.Exists(tv1path))
            {
                //Auslesung durch Deserialisierung der Datei
                using (Stream file = File.OpenRead(tv1path))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    object obj = bf.Deserialize(file);

                    TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
                    treeView1.Nodes.AddRange(nodeList);
                    //Expanden Bestimmter Nodes
                    treeView1.Nodes[0].Expand();
                    treeView1.Nodes[0].Nodes[0].Expand();
                    treeView1.Nodes[0].Nodes[1].Expand();
                    //treeView1.ExpandAll();
                    //Standardmäßiges auswählen der TreeNode "Privat"
                    treeView1.SelectedNode = treeView1.Nodes[0].Nodes[1];
                }
                foreach(TreeNode node in treeView1.Nodes[0].Nodes)
                {
                    foreach(TreeNode subnodes in node.Nodes)
                    {
                        if(subnodes.Nodes[5].Nodes[0].Text == "Ja")
                        {
                            subnodes.ImageIndex = 1;
                            subnodes.SelectedImageIndex = 1;
                        }
                        else
                        {
                            subnodes.ImageIndex = 2;
                            subnodes.SelectedImageIndex = 2;
                        }

                    }
                }
                treeView1.Refresh();
            }
            else
            {
                TreeNode Basis = new TreeNode("TODO-Listen");
                treeView1.Nodes.Add(Basis);
                TreeNode SubBasis1 = new TreeNode("Schule");
                treeView1.Nodes[0].Nodes.Add(SubBasis1);
                TreeNode SubBasis2 = new TreeNode("Privat");
                treeView1.Nodes[0].Nodes.Add(SubBasis2);
                treeView1.SelectedNode = SubBasis2;
                treeView1.ExpandAll();
            }
        }
        private void NewTODO_Click(object sender, EventArgs e)
        {
            if (newTodoBox.Visible == true)
            {
                newTodoBox.Visible = false;
                NewTODO.Text = "Neue TODO-Liste";
            }
            else {
                newTodoBox.Visible = true;
                NewTODO.Text = "Abbrechen";
            }
        }
        private void NewNameSave_Click(object sender, EventArgs e)
        {
            if (!(NewName.Text.Trim() == ""))
            {
                TreeNode NewTodo = new TreeNode(NewName.Text);
                treeView1.Nodes[0].Nodes.Add(NewTodo);
                newTodoBox.Visible = false;
                NewTODO.Text = "Neue TODO-Liste";
                NewName.Text = "";
            }
            else MessageBox.Show("Die Liste braucht einen Namen!");
        }        
        private void NewEntry_Click(object sender, EventArgs e)
        {
            //Aufbau der Struktur die für das Speichern essenziell ist!
            ///Standard Generierung der ChildNodes
            ///und anfügung der Werte die eingefügt wurden unter den ChildNodes
            if(!(Title.Text.Trim() == ""))
            {
                TreeNode NewTodo = new TreeNode(Title.Text,2,2);

                TreeNode PRIO = new TreeNode("Priorität");
                TreeNode SDate = new TreeNode("Start Datum");
                TreeNode EDate = new TreeNode("End Datum");
                TreeNode GenTeiln = new TreeNode("Teilnehmer");
                TreeNode Desc = new TreeNode("Beschreibung");
                TreeNode Done = new TreeNode("Erledigt");

                TreeNode S_PRIO = new TreeNode(Convert.ToString(Priority.Value));
                TreeNode S_SDate = new TreeNode(StartDate.Text);
                TreeNode S_EDate = new TreeNode(EndDate.Text);
                TreeNode S_Desc = new TreeNode(Description.Text);
                TreeNode S_Done = new TreeNode("Ja");
                TreeNode S_NotDone = new TreeNode("Nein");

                //PRIO.ForeColor = Color.Red;
                //TreeNode S_GenTeiln = new TreeNode('Teilnehmer');
                treeView1.Nodes[treeView1.SelectedNode.Parent.Index].Nodes[treeView1.SelectedNode.Index].Nodes.Add(NewTodo);

                NewTodo.Nodes.Add(PRIO);
                NewTodo.Nodes.Add(SDate);
                NewTodo.Nodes.Add(EDate);
                NewTodo.Nodes.Add(GenTeiln);
                NewTodo.Nodes.Add(Desc);
                NewTodo.Nodes.Add(Done);
                
                PRIO.Nodes.Add(S_PRIO);
                SDate.Nodes.Add(S_SDate);
                EDate.Nodes.Add(S_EDate);
                if (!(Description.Text.Trim() == "")) Desc.Nodes.Add(S_Desc);
                else Desc.Nodes.Add("Keine Beschreibung");

                if (radioButton1.Checked) Done.Nodes.Add(S_Done.Text);
                else Done.Nodes.Add(S_NotDone.Text);
            }
            else
            {
                MessageBox.Show("Es muss ein Titel angegeben werden!");
            }

        }
        private void Delete_Click(object sender, EventArgs e)
        {
            //Bool zum Überprüfen ob ganze Liste gelöscht werden soll
            bool WarnCheck = false;
            //Löschüberprüfung
            string tv1 = treeView1.SelectedNode.Text;
            if (!(tv1 == "TODO-Listen" || tv1 == "Schule" || tv1 == "Privat" || tv1 == "Teilnehmer" || tv1 == "Priorität" || tv1 == "Start Datum" || tv1 == "End Datum" || tv1 == "Beschreibung" || tv1 == "Erledigt"))
            {

                foreach (TreeNode Node in treeView1.Nodes[0].Nodes)
                {
                    if (tv1 == Node.Text) WarnCheck = true;
                }
                if(WarnCheck == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Wollen Sie wirklich die ganze Liste Löschen ?", "Warnung", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        treeView1.SelectedNode.Remove();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //Nichts wird Gemacht
                    }
                }
                else treeView1.SelectedNode.Remove();
            }
            else MessageBox.Show("Du darfst diesen Punkt nicht löschen!");

            WarnCheck = false;
        }
        private void SelectContact_Click(object sender, EventArgs e)
        {
            bool OneOfHighestNodes = false;
            bool Checksum = false;
            string i = treeView1.SelectedNode.Text;
            string ip = treeView1.SelectedNode.Parent.Text;
            if (i == "Teilnehmer" || i == "Priorität" || i == "Start Datum" || i == "End Datum" || i == "Beschreibung" || i == "Erledigt") treeView1.SelectedNode = treeView1.SelectedNode.Parent;
            else if (ip == "Teilnehmer" || ip == "Priorität" || ip == "Start Datum" || ip == "End Datum" || ip == "Beschreibung" || ip == "Erledigt") treeView1.SelectedNode = treeView1.SelectedNode.Parent.Parent;
            else
            { 
                foreach (TreeNode Node in treeView1.Nodes)
                {
                    if (treeView1.SelectedNode.Text == Node.Text)
                    {
                        OneOfHighestNodes = true;
                    }
                }
                foreach (TreeNode Node in treeView1.Nodes[0].Nodes)
                {
                    if (treeView1.SelectedNode.Text == Node.Text)
                    {
                        Checksum = true;
                    }
                }
            }
            if (Checksum == true || OneOfHighestNodes == true)
            {
                MessageBox.Show("Wählen Sie bitte ein Termin zuerst aus!");
            }
            else
            {
                bool checksum = false;
                if(treeView1.SelectedNode.Nodes[3].Nodes.Count != 0 )
                {
                    foreach(TreeNode Node in treeView1.SelectedNode.Nodes[3].Nodes)
                    {
                        if (Node.Text == nameComboBox.Text)
                        {
                           MessageBox.Show("Dieser Kontakt ist bei dem Termin schon vorhanden!");
                           checksum = true;
                           break;
                        }
                    }
                    if (checksum != true)
                        {
                            treeView1.SelectedNode.Nodes[3].Nodes.Add(nameComboBox.Text);
                            checksum = false;
                        }

                }
                else treeView1.SelectedNode.Nodes[3].Nodes.Add(nameComboBox.Text);
            }
            OneOfHighestNodes = false;
            Checksum = false;
            //nameComboBox.Text;
            
        }
        private void saveAll_Click(object sender, EventArgs e)
        {
            //Speicherung der TreeView durch Serialisierung eines BinaryFormatters
            SaveDeserializing();
        }
        private void editToDo_Click(object sender, EventArgs e)
        {
            string tv1 = treeView1.SelectedNode.Text;

            foreach (TreeNode Node in treeView1.Nodes[0].Nodes)
            {
                if (tv1 == Node.Text) WarnCheck = true;
            }
            foreach (TreeNode Node in treeView1.Nodes)
            {
                if (tv1 == Node.Text) WarnCheck = true;
            }
            if (WarnCheck == false)
            {

                if (editEintrag.Visible == false)
                {
                    editToDo.Text = "Abbrechen";
                    editEintrag.Visible = true;
                }
                else
                {
                    editEintrag.Visible = false;
                    editToDo.Text = "Bearbeiten";
                }
            }
            else
            {
                MessageBox.Show("Wählen Sie bitte ein Termin zuerst aus!");
                WarnCheck = false;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Reinschreibung ob erledigt ins TreeView.
            ///Ja ist selektiert
            
            if(radioButton1.Checked == true)
            {
                bool Checksum = false;
                bool OneOfHighestNodes = false;

                string i = treeView1.SelectedNode.Text;
                string ip = treeView1.SelectedNode.Parent.Text;

                if (i == "Teilnehmer" || i == "Priorität" || i == "Start Datum" || i == "End Datum" || i == "Beschreibung" || i == "Erledigt") treeView1.SelectedNode = treeView1.SelectedNode.Parent;
                else if (ip == "Teilnehmer" || ip == "Priorität" || ip == "Start Datum" || ip == "End Datum" || ip == "Beschreibung" || ip == "Erledigt") treeView1.SelectedNode = treeView1.SelectedNode.Parent.Parent;
                else
                {
                    foreach (TreeNode Node in treeView1.Nodes)
                    {
                        if (treeView1.SelectedNode.Text == Node.Text)
                        {
                            OneOfHighestNodes = true;
                        }
                    }
                    foreach (TreeNode Node in treeView1.Nodes[0].Nodes)
                    {
                        if (treeView1.SelectedNode.Text == Node.Text)
                        {
                            Checksum = true;
                        }
                    }
                }
                if (Checksum == true || OneOfHighestNodes == true)
                {
                    MessageBox.Show("Wählen Sie bitte ein Termin zuerst aus!");
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                }
                else
                {
                    treeView1.SelectedNode.ImageIndex = 1;
                    treeView1.SelectedNode.SelectedImageIndex = 1;
                    treeView1.SelectedNode.Nodes[5].Nodes.RemoveAt(0);
                    treeView1.SelectedNode.Nodes[5].Nodes.Add("Ja");
                }
                Checksum = false;
                OneOfHighestNodes = false;
            }
            ///Nein ist selektiert
            else if (radioButton2.Checked == true)
            {
                bool Checksum = false;
                bool OneOfHighestNodes = false;

                string i = treeView1.SelectedNode.Text;
                string ip = treeView1.SelectedNode.Parent.Text;

                if (i == "Teilnehmer" || i == "Priorität" || i == "Start Datum" || i == "End Datum" || i == "Beschreibung" || i == "Erledigt") treeView1.SelectedNode = treeView1.SelectedNode.Parent;
                else if (ip == "Teilnehmer" || ip == "Priorität" || ip == "Start Datum" || ip == "End Datum" || ip == "Beschreibung" || ip == "Erledigt") treeView1.SelectedNode = treeView1.SelectedNode.Parent.Parent;
                else
                {
                    foreach (TreeNode Node in treeView1.Nodes)
                    {
                        if (treeView1.SelectedNode.Text == Node.Text)
                        {
                            OneOfHighestNodes = true;
                        }
                    }
                    foreach (TreeNode Node in treeView1.Nodes[0].Nodes)
                    {
                        if (treeView1.SelectedNode.Text == Node.Text)
                        {
                            Checksum = true;
                        }
                    }
                }
                if (Checksum == true || OneOfHighestNodes == true)
                {
                    MessageBox.Show("Wählen Sie bitte ein Termin zuerst aus!");
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                }
                else
                {
                    treeView1.SelectedNode.ImageIndex = 2;
                    treeView1.SelectedNode.SelectedImageIndex = 2;
                    treeView1.SelectedNode.Nodes[5].Nodes.RemoveAt(0);
                    treeView1.SelectedNode.Nodes[5].Nodes.Add("Nein");
                }
                Checksum = false;
                OneOfHighestNodes = false;
            } 
        }
        private void btnexpandall_Click(object sender, EventArgs e)
        {
            if(expandallcheck == false)
            {
                btnexpandall.Text = "H.A";
                treeView1.ExpandAll();
                expandallcheck = true;
            }
            else
            {
                btnexpandall.Text = "E.A";
                treeView1.CollapseAll();
                treeView1.Nodes[0].Expand();
                treeView1.Nodes[0].Nodes[0].Expand();
                treeView1.Nodes[0].Nodes[1].Expand();
                expandallcheck = false;
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        { }
        private void EditSaveClick(object sender, EventArgs e)
        {
            //Gruppenfenster Versteckten und dann Erledigt einträgt und bildchen ändert
            editEintrag.Visible = false;
            editToDo.Text = "Bearbeiten";


        }
        private void TODO_Liste_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sollen Ihre Änderungen an der ToDo-Liste gespeichert werden?", "Hinweis", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveDeserializing();
            }
            else if (dialogResult == DialogResult.No)
            {
                //Nichts wird Gemacht
            }
        }
    }
}
