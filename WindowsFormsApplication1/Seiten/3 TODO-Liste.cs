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
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class TODO_Liste : Form
    {
        /// <summary>
        /// EIGENINFO:
        /// App.config + Settings.Designer.cs
        /// Pfad für Datenbank verändert um installer schreiben zu können.
        /// </summary>
//** GLOBALS
        public string iNode;                        //Um die ausgewählte Node herauszufinden
        public string iSubnode;                     //Um Parent der ausgewählten node herauszufinden
        public int Output;                          //Output für die funktion 'Check_OneOfHigestNodes(iNode,iSubnode)'
        private bool expandallcheck = false;        //Ob die liste Ausgeklappt ist oder nicht!
        private bool WarnCheck = false;             //Bool um eine Warnung beim Löschen auszugeben
//** STATICS
            //= Environment.CurrentDirectory;
        static string tv1path = Environment.CurrentDirectory + @"\TVSave.txt";  //Wenn vorhanden die abgespeicherte TODO-Liste
//** SELBSTGESCHRIEBENE FUNKTIONEN
        private void SaveDeserializing()
        {
            ///Speicherung der TreeView durch Serialisierung eines BinaryFormatters
            using (Stream file = File.Open(tv1path, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, treeView1.Nodes.Cast<TreeNode>().ToList());
            }
        }
        private int Check_OneOfHigehstNodes(string i, string ip)    // Funktion zum überprüfen ob einer der Hauptknoten ausgewählt ist.
        {
            bool Checksum = false;
            bool OneOfHighestNodes = false;

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
                return 0;
            }
            else
            {
                return 1;
            }
        }
//** ANFANG
        public TODO_Liste()
        {
            InitializeComponent();
            ///Anlegen der ImageList
            treeView1.ImageList = new ImageList();
            ///Anlegen der einzelnen Bilder in dem Ordner 'Icons'
            treeView1.ImageList.Images.Add(new Icon(GetType(), "Icons.empty.ico"));             //ID:0
            treeView1.ImageList.Images.Add(new Icon(GetType(), "Icons.folder.ico"));            //ID:1
            treeView1.ImageList.Images.Add(new Icon(GetType(), "Icons.done.ico"));              //ID:2
            treeView1.ImageList.Images.Add(new Icon(GetType(), "Icons.not_done.ico"));          //ID:3
            treeView1.ImageList.Images.Add(new Icon(GetType(), "Icons.info.ico"));              //ID:4
            ///Überprüfung ob etwas in der Datei steht
            if (File.Exists(tv1path))
            {
                string[] checksum = File.ReadAllLines(tv1path);
                if(checksum[0]== "") File.Delete(tv1path);
            }
        }
        private void TODO_Liste_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "kundenDataSet.Kunden". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundenTableAdapter.Fill(this.kundenDataSet.Kunden);

            ///Wie viele Kontakte existieren
            kontzal.Text = Convert.ToString(kundenDataSet.Kunden.Count);

            ///Auslesung aus der Datei wenn Vorhanden
            ///Sonst Neuaufbau der TreeView-Struktur
            if(File.Exists(tv1path))
            {
                ///Auslesung durch Deserialisierung der Datei
                using (Stream file = File.OpenRead(tv1path))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    object obj = bf.Deserialize(file);

                    TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
                    treeView1.Nodes.AddRange(nodeList);
                    
                    ///Ausklappen Bestimmter Nodes
                    treeView1.Nodes[0].Expand();
                    treeView1.Nodes[0].Nodes[0].Expand();
                    treeView1.Nodes[0].Nodes[1].Expand();

                    ///Standardmäßiges auswählen der TreeNode "Privat"
                    treeView1.SelectedNode = treeView1.Nodes[0].Nodes[1];
                }
//** IMAGELIST CONSTRUCT
                ///Loopen durch die komplette Todo-Liste um Icons passend zu verteilen
                foreach (TreeNode node1 in treeView1.Nodes)
                {
                    ///'TODO-Listen'
                    node1.ImageIndex = 1;
                    node1.SelectedImageIndex = 1;
                    foreach (TreeNode node2 in node1.Nodes)
                    {
                        ///'Schule', 'Privat'...
                        node2.ImageIndex = 1;
                        node2.SelectedImageIndex = 1;
                        foreach (TreeNode node3 in node2.Nodes)
                        {
                            ///'Termin1', 'Termin2'...
                            if (node3.Nodes[5].Nodes[0].Text == "Ja")
                            {
                                node3.ImageIndex = 2;
                                node3.SelectedImageIndex = 2;
                            }
                            else
                            {
                                node3.ImageIndex = 3;
                                node3.SelectedImageIndex = 3;
                            }
                            foreach (TreeNode node4 in node3.Nodes)
                            {
                                ///'InfoPunkt1', 'InfoPunkt2'...
                                node4.ImageIndex = 4;
                                node4.SelectedImageIndex = 4;
                                foreach (TreeNode node5 in node4.Nodes)
                                {
                                    node5.ImageIndex = 0;
                                    node5.SelectedImageIndex = 0;
                                }
                            }
                        }
                    }
                }
                ///Um die Änderungen anzeigen zu lassen
                treeView1.Refresh();
            }
            else
            {
                ///Wenn nichts vorhanden ist wird diese Struktur standardmäßig aufgebaut
                TreeNode Basis = new TreeNode("TODO-Listen", 1, 1);
                treeView1.Nodes.Add(Basis);
                TreeNode SubBasis1 = new TreeNode("Schule", 1, 1);
                treeView1.Nodes[0].Nodes.Add(SubBasis1);
                TreeNode SubBasis2 = new TreeNode("Privat", 1, 1);
                treeView1.Nodes[0].Nodes.Add(SubBasis2);
                treeView1.SelectedNode = SubBasis2;
                treeView1.ExpandAll();
            }
        }
        private void NewTODO_Click(object sender, EventArgs e)
        {
            //Button umbenennung und verstecken von Elementen abwechselnd
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
            ///Neue Ordner erstellen. Können nur unter dem oberordner Erstellt werden(So haben wir es zumindest verstanden!)
            if (!(NewName.Text.Trim() == ""))
            {
                TreeNode NewTodo = new TreeNode(NewName.Text, 1, 1);
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
            ///Standard Generierung der SubNodes
            ///und anfügung der Werte die eingefügt wurden unter den SubNodes
            if (!(Title.Text.Trim() == ""))
            {
                TreeNode NewTodo = new TreeNode(Title.Text, 3, 3);

                TreeNode PRIO = new TreeNode("Priorität", 4, 4);
                TreeNode SDate = new TreeNode("Start Datum", 4, 4);
                TreeNode EDate = new TreeNode("End Datum", 4, 4);
                TreeNode GenTeiln = new TreeNode("Teilnehmer", 4, 4);
                TreeNode Desc = new TreeNode("Beschreibung", 4, 4);
                TreeNode Done = new TreeNode("Erledigt", 4, 4);

                /// Enthalten keine Img-List info, da 'empty' = 0
                TreeNode S_PRIO = new TreeNode(Convert.ToString(Priority.Value)); 
                TreeNode S_SDate = new TreeNode(StartDate.Text);
                TreeNode S_EDate = new TreeNode(EndDate.Text);
                TreeNode S_Desc = new TreeNode(Description.Text);
                TreeNode S_Done = new TreeNode("Ja");
                TreeNode S_NotDone = new TreeNode("Nein");

                iNode = treeView1.SelectedNode.Text;
                if (iNode != "TODO-Listen")
                {
                    iSubnode = treeView1.SelectedNode.Parent.Text;

                    Output = Check_OneOfHigehstNodes(iNode, iSubnode);

                    switch (Output)
                    {
                        case 0:     // Ja
                            treeView1.SelectedNode.Nodes.Add(NewTodo);
                            break;
                        case 1:     // Nein
                            treeView1.SelectedNode.Parent.Nodes.Add(NewTodo);
                            break;
                    }
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
                    MessageBox.Show("Bitte wählen sie zuerst eine Liste aus!");
                }
            }
            else MessageBox.Show("Es muss ein Titel angegeben werden!");  ///Wenn kein Titel angegeben ist.
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            WarnCheck = false;
            iNode = treeView1.SelectedNode.Text;
            //Löschüberprüfung
            if (!(iNode == "TODO-Listen" || iNode == "Teilnehmer" || iNode == "Priorität" || iNode == "Start Datum" || iNode == "End Datum" || iNode == "Beschreibung" || iNode == "Erledigt"))
            {
                foreach (TreeNode Node in treeView1.Nodes[0].Nodes)     ///Überprüfung ob 'Schule', 'Privat'... ausgewählt ist
                    if (iNode == Node.Text) WarnCheck = true;
                if(WarnCheck == true)
                {
                    ///Warnung das ein ganzer Ordner ausgewählt ist
                    DialogResult dialogResult = MessageBox.Show("Wollen Sie wirklich die ganze Liste Löschen ?", "Warnung", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) treeView1.SelectedNode.Remove();      ///Wenn 'Ja' gedrückt wurde
                }
                else treeView1.SelectedNode.Remove();
            }
            else MessageBox.Show("Du darfst diesen Punkt nicht löschen!");
            WarnCheck = false;
        }
        private void SelectContact_Click(object sender, EventArgs e)
        {
            iNode = treeView1.SelectedNode.Text;
            iSubnode = treeView1.SelectedNode.Parent.Text;
            Output = Check_OneOfHigehstNodes(iNode, iSubnode);      ///Überprüfung ob einer der höhsten nodes ausgewählt ist
            switch (Output)
            {
                case 0:     // Ja
                    MessageBox.Show("Wählen Sie bitte ein Termin zuerst aus!");
                    break;
                case 1:     // Nein
                    bool checksum = false;
                    if(treeView1.SelectedNode.Nodes[3].Nodes.Count != 0 )
                    {
                        foreach(TreeNode Node in treeView1.SelectedNode.Nodes[3].Nodes)     ///Loop durch jeden Kontakt
                        {
                            if (Node.Text == nameComboBox.Text)     ///Ob vorhanden oder nicht
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
                    break;
            }
        }
        private void saveAll_Click(object sender, EventArgs e)
        {
            SaveDeserializing(); // <--- Wurde oben schon erklärt
        }
        private void editToDo_Click(object sender, EventArgs e)
        {
            iNode = treeView1.SelectedNode.Text;
            ///Überprüfung ob Einer der Höchsten nodes ausgewählt ist in Simpel.(Keine Extra funktion, da dies in einer anderen Situation verwendet wird und nicht so streng überprüft werden muss.)
            foreach (TreeNode Node in treeView1.Nodes[0].Nodes) if(iNode == Node.Text) WarnCheck = true;
            foreach (TreeNode Node in treeView1.Nodes) if(iNode == Node.Text) WarnCheck = true;
            ///Ob wirklich ein termin ausgewählt ist
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
            iNode = treeView1.SelectedNode.Text;
            if (iNode != "TODO-Listen") iSubnode = treeView1.SelectedNode.Parent.Text;
            Output = Check_OneOfHigehstNodes(iNode, iSubnode);

            //Statuswechselung. Termin fertig: 'Ja', 'Nein'
            ///Ja ist selektiert
            if (radioButton1.Checked == true)
            {
                switch (Output)
                {
                    case 0:
                        ///Kein Termin wurde ausgewählt
                        MessageBox.Show("Wählen Sie bitte ein Termin zuerst aus!");
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        break;
                    case 1:
                        ///Img-List und SubNode von 'Erledigt' werden angepasst
                        treeView1.SelectedNode.ImageIndex = 2;
                        treeView1.SelectedNode.SelectedImageIndex = 2;
                        treeView1.SelectedNode.Nodes[5].Nodes.RemoveAt(0);
                        treeView1.SelectedNode.Nodes[5].Nodes.Add("Ja");
                        break;
                }
            }
            ///Nein ist selektiert
            else if (radioButton2.Checked == true)
            {
                ///Die selbe Dokumentation wie bei 'Ja ist selektiert'
                switch (Output)
                {
                    case 0:
                        MessageBox.Show("Wählen Sie bitte ein Termin zuerst aus!");
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        break;
                    case 1:
                        treeView1.SelectedNode.ImageIndex = 3;
                        treeView1.SelectedNode.SelectedImageIndex = 3;
                        treeView1.SelectedNode.Nodes[5].Nodes.RemoveAt(0);
                        treeView1.SelectedNode.Nodes[5].Nodes.Add("Nein");
                        break;
                }
            } 
        }
        private void btnexpandall_Click(object sender, EventArgs e)
        {
///         Ausklappen/Einklappen aller Nodes
            if(expandallcheck == false)
            {
                ///Expandiert alle Nodes
                btnexpandall.Text = "H.A";  //H.A = Hide All
                treeView1.ExpandAll();         
                expandallcheck = true;
            }
            else
            {
                ///Einklappen aller nodes außer: 1['TODO-Listen'], 2['Privat', 'Schule']
                btnexpandall.Text = "E.A";  //E.A = Expand All
                treeView1.CollapseAll();
                treeView1.Nodes[0].Expand();
                treeView1.Nodes[0].Nodes[0].Expand();
                treeView1.Nodes[0].Nodes[1].Expand();
                expandallcheck = false;
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ///Wenn einer der Höchsten nodes ausgewählt wird, wird die ['Bearbeiten' GroupBox] versteckt da diese nicht editiert werden sollen
            iNode = treeView1.SelectedNode.Text;
            if (iNode != "TODO-Listen") iSubnode = treeView1.SelectedNode.Parent.Text;
            Output = Check_OneOfHigehstNodes(iNode, iSubnode);

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            switch (Output)
            {
                case 0:
                    editToDo.Text = "Bearbeiten";
                    editEintrag.Visible = false;
                    break;
            }
        }
        private void EditSaveClick(object sender, EventArgs e)
        {
            //Versteckt das Gruppenfenster
            editEintrag.Visible = false;
            editToDo.Text = "Bearbeiten";
        }
        private void TODO_Liste_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Abfangen wenn Form geschlossen wird, ob man die Änderungen speichern will oder nicht
            DialogResult dialogResult = MessageBox.Show("Sollen Ihre Änderungen an der ToDo-Liste gespeichert werden?", "Hinweis", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) SaveDeserializing();
        }
    }
}
