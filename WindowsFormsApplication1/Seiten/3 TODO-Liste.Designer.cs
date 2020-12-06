namespace WindowsFormsApplication1
{
    partial class TODO_Liste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Priority = new System.Windows.Forms.NumericUpDown();
            this.NewTODO = new System.Windows.Forms.Button();
            this.NewEntry = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SelectContact = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.Title = new System.Windows.Forms.TextBox();
            this.kundenDataSet = new WindowsFormsApplication1.KundenDataSet();
            this.kundenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundenTableAdapter = new WindowsFormsApplication1.KundenDataSetTableAdapters.KundenTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.KundenDataSetTableAdapters.TableAdapterManager();
            this.kontzal = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.NewNameSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewName = new System.Windows.Forms.TextBox();
            this.editEintrag = new System.Windows.Forms.GroupBox();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.EditSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.newTodoBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnexpandall = new System.Windows.Forms.Button();
            this.saveAll = new System.Windows.Forms.Button();
            this.editToDo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Priority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundenBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.editEintrag.SuspendLayout();
            this.newTodoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(30, 27);
            this.treeView1.Name = "treeView1";
            this.treeView1.PathSeparator = ":";
            this.treeView1.Size = new System.Drawing.Size(344, 399);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Priority
            // 
            this.Priority.Location = new System.Drawing.Point(83, 102);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(73, 20);
            this.Priority.TabIndex = 2;
            this.Priority.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // NewTODO
            // 
            this.NewTODO.ForeColor = System.Drawing.Color.Black;
            this.NewTODO.Location = new System.Drawing.Point(30, 432);
            this.NewTODO.Name = "NewTODO";
            this.NewTODO.Size = new System.Drawing.Size(109, 25);
            this.NewTODO.TabIndex = 3;
            this.NewTODO.Text = "Neue TODO-Liste";
            this.NewTODO.UseVisualStyleBackColor = true;
            this.NewTODO.Click += new System.EventHandler(this.NewTODO_Click);
            // 
            // NewEntry
            // 
            this.NewEntry.ForeColor = System.Drawing.Color.Black;
            this.NewEntry.Location = new System.Drawing.Point(12, 237);
            this.NewEntry.Name = "NewEntry";
            this.NewEntry.Size = new System.Drawing.Size(309, 25);
            this.NewEntry.TabIndex = 4;
            this.NewEntry.Text = "Eintrag erstellen";
            this.NewEntry.UseVisualStyleBackColor = true;
            this.NewEntry.Click += new System.EventHandler(this.NewEntry_Click);
            // 
            // Delete
            // 
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(12, 114);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(144, 25);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Löschen";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SelectContact
            // 
            this.SelectContact.Cursor = System.Windows.Forms.Cursors.Default;
            this.SelectContact.ForeColor = System.Drawing.Color.Black;
            this.SelectContact.Location = new System.Drawing.Point(210, 29);
            this.SelectContact.Name = "SelectContact";
            this.SelectContact.Size = new System.Drawing.Size(115, 21);
            this.SelectContact.TabIndex = 6;
            this.SelectContact.Text = "Kontakt Auswählen";
            this.SelectContact.UseVisualStyleBackColor = true;
            this.SelectContact.Click += new System.EventHandler(this.SelectContact_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Startdatum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enddatum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(9, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Priorität";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(9, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "betroffene\r\nKontakte\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(9, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Beschreibung";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(83, 128);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(238, 93);
            this.Description.TabIndex = 13;
            // 
            // EndDate
            // 
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate.Location = new System.Drawing.Point(83, 76);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(238, 20);
            this.EndDate.TabIndex = 15;
            // 
            // StartDate
            // 
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(83, 50);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(238, 20);
            this.StartDate.TabIndex = 16;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(83, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(238, 20);
            this.Title.TabIndex = 17;
            // 
            // kundenDataSet
            // 
            this.kundenDataSet.DataSetName = "KundenDataSet";
            this.kundenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kundenBindingSource
            // 
            this.kundenBindingSource.DataMember = "Kunden";
            this.kundenBindingSource.DataSource = this.kundenDataSet;
            // 
            // kundenTableAdapter
            // 
            this.kundenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KundenTableAdapter = this.kundenTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.KundenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kontzal
            // 
            this.kontzal.AutoSize = true;
            this.kontzal.DisabledLinkColor = System.Drawing.Color.White;
            this.kontzal.Enabled = false;
            this.kontzal.LinkColor = System.Drawing.Color.Azure;
            this.kontzal.Location = new System.Drawing.Point(184, 53);
            this.kontzal.Name = "kontzal";
            this.kontzal.Size = new System.Drawing.Size(25, 13);
            this.kontzal.TabIndex = 20;
            this.kontzal.TabStop = true;
            this.kontzal.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(80, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Verfügbare Kontakte:";
            // 
            // NewNameSave
            // 
            this.NewNameSave.ForeColor = System.Drawing.Color.Black;
            this.NewNameSave.Location = new System.Drawing.Point(168, 19);
            this.NewNameSave.Name = "NewNameSave";
            this.NewNameSave.Size = new System.Drawing.Size(55, 20);
            this.NewNameSave.TabIndex = 23;
            this.NewNameSave.Text = "Erstellen";
            this.NewNameSave.UseVisualStyleBackColor = true;
            this.NewNameSave.Click += new System.EventHandler(this.NewNameSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Title);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StartDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EndDate);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Priority);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NewEntry);
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(391, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 271);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neuer Eintrag";
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(47, 19);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(115, 20);
            this.NewName.TabIndex = 22;
            // 
            // editEintrag
            // 
            this.editEintrag.Controls.Add(this.nameComboBox);
            this.editEintrag.Controls.Add(this.radioButton2);
            this.editEintrag.Controls.Add(this.radioButton1);
            this.editEintrag.Controls.Add(this.EditSave);
            this.editEintrag.Controls.Add(this.label9);
            this.editEintrag.Controls.Add(this.SelectContact);
            this.editEintrag.Controls.Add(this.Delete);
            this.editEintrag.Controls.Add(this.label5);
            this.editEintrag.Controls.Add(this.kontzal);
            this.editEintrag.Controls.Add(this.label7);
            this.editEintrag.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.editEintrag.Location = new System.Drawing.Point(391, 335);
            this.editEintrag.Name = "editEintrag";
            this.editEintrag.Size = new System.Drawing.Size(331, 153);
            this.editEintrag.TabIndex = 27;
            this.editEintrag.TabStop = false;
            this.editEintrag.Text = "Eintrag bearbeiten";
            this.editEintrag.Visible = false;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataSource = this.kundenBindingSource;
            this.nameComboBox.DisplayMember = "Name";
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(83, 29);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(121, 21);
            this.nameComboBox.TabIndex = 32;
            this.nameComboBox.ValueMember = "Name";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Azure;
            this.radioButton2.Location = new System.Drawing.Point(157, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.Text = "Nein";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Azure;
            this.radioButton1.Location = new System.Drawing.Point(83, 78);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 17);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.Text = "Ja";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // EditSave
            // 
            this.EditSave.ForeColor = System.Drawing.Color.Black;
            this.EditSave.Location = new System.Drawing.Point(177, 114);
            this.EditSave.Name = "EditSave";
            this.EditSave.Size = new System.Drawing.Size(144, 25);
            this.EditSave.TabIndex = 29;
            this.EditSave.Text = "Speichern";
            this.EditSave.UseVisualStyleBackColor = true;
            this.EditSave.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(9, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Erledigt";
            // 
            // newTodoBox
            // 
            this.newTodoBox.Controls.Add(this.label8);
            this.newTodoBox.Controls.Add(this.NewName);
            this.newTodoBox.Controls.Add(this.NewNameSave);
            this.newTodoBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.newTodoBox.Location = new System.Drawing.Point(145, 433);
            this.newTodoBox.Name = "newTodoBox";
            this.newTodoBox.Size = new System.Drawing.Size(229, 55);
            this.newTodoBox.TabIndex = 28;
            this.newTodoBox.TabStop = false;
            this.newTodoBox.Text = "Neue TODO-Liste";
            this.newTodoBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Name";
            // 
            // btnexpandall
            // 
            this.btnexpandall.ForeColor = System.Drawing.Color.Black;
            this.btnexpandall.Location = new System.Drawing.Point(323, 406);
            this.btnexpandall.Name = "btnexpandall";
            this.btnexpandall.Size = new System.Drawing.Size(33, 20);
            this.btnexpandall.TabIndex = 31;
            this.btnexpandall.Text = "E.A";
            this.btnexpandall.UseVisualStyleBackColor = true;
            this.btnexpandall.Click += new System.EventHandler(this.btnexpandall_Click);
            // 
            // saveAll
            // 
            this.saveAll.ForeColor = System.Drawing.Color.Black;
            this.saveAll.Location = new System.Drawing.Point(30, 464);
            this.saveAll.Name = "saveAll";
            this.saveAll.Size = new System.Drawing.Size(109, 23);
            this.saveAll.TabIndex = 29;
            this.saveAll.Text = "TODOs Speichern";
            this.saveAll.UseVisualStyleBackColor = true;
            this.saveAll.Click += new System.EventHandler(this.saveAll_Click);
            // 
            // editToDo
            // 
            this.editToDo.ForeColor = System.Drawing.Color.Black;
            this.editToDo.Location = new System.Drawing.Point(391, 304);
            this.editToDo.Name = "editToDo";
            this.editToDo.Size = new System.Drawing.Size(109, 25);
            this.editToDo.TabIndex = 30;
            this.editToDo.Text = "Bearbeiten";
            this.editToDo.UseVisualStyleBackColor = true;
            this.editToDo.Click += new System.EventHandler(this.editToDo_Click);
            // 
            // TODO_Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(745, 505);
            this.Controls.Add(this.btnexpandall);
            this.Controls.Add(this.editToDo);
            this.Controls.Add(this.saveAll);
            this.Controls.Add(this.newTodoBox);
            this.Controls.Add(this.editEintrag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NewTODO);
            this.Controls.Add(this.treeView1);
            this.ForeColor = System.Drawing.Color.Azure;
            this.Name = "TODO_Liste";
            this.Text = "TODO-Liste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TODO_Liste_FormClosing);
            this.Load += new System.EventHandler(this.TODO_Liste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Priority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundenBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.editEintrag.ResumeLayout(false);
            this.editEintrag.PerformLayout();
            this.newTodoBox.ResumeLayout(false);
            this.newTodoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.NumericUpDown Priority;
        private System.Windows.Forms.Button NewTODO;
        private System.Windows.Forms.Button NewEntry;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button SelectContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.TextBox Title;
        private KundenDataSet kundenDataSet;
        private System.Windows.Forms.BindingSource kundenBindingSource;
        private KundenDataSetTableAdapters.KundenTableAdapter kundenTableAdapter;
        private KundenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.LinkLabel kontzal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button NewNameSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.GroupBox editEintrag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button EditSave;
        private System.Windows.Forms.GroupBox newTodoBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button saveAll;
        private System.Windows.Forms.Button editToDo;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.Button btnexpandall;
    }
}