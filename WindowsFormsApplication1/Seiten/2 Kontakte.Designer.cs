namespace WindowsFormsApplication1.Seiten
{
    partial class Kontakte
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label straßeLabel;
            System.Windows.Forms.Label ortLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.kundenDataSet = new WindowsFormsApplication1.KundenDataSet();
            this.kundenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundenTableAdapter = new WindowsFormsApplication1.KundenDataSetTableAdapters.KundenTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.KundenDataSetTableAdapters.TableAdapterManager();
            this.kundenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBox = new System.Windows.Forms.GroupBox();
            this.AddTel = new System.Windows.Forms.TextBox();
            this.AddOrt = new System.Windows.Forms.TextBox();
            this.AddStreet = new System.Windows.Forms.TextBox();
            this.AddName = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.editBox = new System.Windows.Forms.GroupBox();
            this.editTel = new System.Windows.Forms.TextBox();
            this.editOrt = new System.Windows.Forms.TextBox();
            this.editStreet = new System.Windows.Forms.TextBox();
            this.editName = new System.Windows.Forms.TextBox();
            this.editID = new System.Windows.Forms.TextBox();
            this.editbtnSave = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            straßeLabel = new System.Windows.Forms.Label();
            ortLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kundenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundenDataGridView)).BeginInit();
            this.addBox.SuspendLayout();
            this.editBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(6, 16);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // straßeLabel
            // 
            straßeLabel.AutoSize = true;
            straßeLabel.ForeColor = System.Drawing.Color.White;
            straßeLabel.Location = new System.Drawing.Point(6, 42);
            straßeLabel.Name = "straßeLabel";
            straßeLabel.Size = new System.Drawing.Size(41, 13);
            straßeLabel.TabIndex = 6;
            straßeLabel.Text = "Straße:";
            // 
            // ortLabel
            // 
            ortLabel.AutoSize = true;
            ortLabel.ForeColor = System.Drawing.Color.White;
            ortLabel.Location = new System.Drawing.Point(6, 68);
            ortLabel.Name = "ortLabel";
            ortLabel.Size = new System.Drawing.Size(24, 13);
            ortLabel.TabIndex = 8;
            ortLabel.Text = "Ort:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.ForeColor = System.Drawing.Color.White;
            telefonLabel.Location = new System.Drawing.Point(6, 94);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 10;
            telefonLabel.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(6, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(21, 13);
            label2.TabIndex = 16;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(6, 120);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 13);
            label3.TabIndex = 20;
            label3.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(6, 42);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 13);
            label4.TabIndex = 17;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(6, 94);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(24, 13);
            label5.TabIndex = 19;
            label5.Text = "Ort:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(6, 68);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(41, 13);
            label6.TabIndex = 18;
            label6.Text = "Straße:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kontaktliste";
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
            // kundenDataGridView
            // 
            this.kundenDataGridView.AllowUserToAddRows = false;
            this.kundenDataGridView.AllowUserToDeleteRows = false;
            this.kundenDataGridView.AllowUserToResizeColumns = false;
            this.kundenDataGridView.AllowUserToResizeRows = false;
            this.kundenDataGridView.AutoGenerateColumns = false;
            this.kundenDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kundenDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kundenDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kundenDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.kundenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kundenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.kundenDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.kundenDataGridView.DataSource = this.kundenBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kundenDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.kundenDataGridView.EnableHeadersVisualStyles = false;
            this.kundenDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kundenDataGridView.Location = new System.Drawing.Point(11, 32);
            this.kundenDataGridView.MultiSelect = false;
            this.kundenDataGridView.Name = "kundenDataGridView";
            this.kundenDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kundenDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.kundenDataGridView.RowHeadersVisible = false;
            this.kundenDataGridView.RowTemplate.ReadOnly = true;
            this.kundenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kundenDataGridView.Size = new System.Drawing.Size(406, 377);
            this.kundenDataGridView.TabIndex = 1;
            this.kundenDataGridView.TabStop = false;
            this.kundenDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kundenDataGridView_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Straße";
            this.dataGridViewTextBoxColumn3.HeaderText = "Straße";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ort";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ort";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // addBox
            // 
            this.addBox.Controls.Add(this.AddTel);
            this.addBox.Controls.Add(this.AddOrt);
            this.addBox.Controls.Add(this.AddStreet);
            this.addBox.Controls.Add(this.AddName);
            this.addBox.Controls.Add(telefonLabel);
            this.addBox.Controls.Add(nameLabel);
            this.addBox.Controls.Add(ortLabel);
            this.addBox.Controls.Add(straßeLabel);
            this.addBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addBox.Location = new System.Drawing.Point(424, 32);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(162, 121);
            this.addBox.TabIndex = 12;
            this.addBox.TabStop = false;
            this.addBox.Text = "Hinzufügen";
            // 
            // AddTel
            // 
            this.AddTel.Location = new System.Drawing.Point(56, 91);
            this.AddTel.MaxLength = 32;
            this.AddTel.Name = "AddTel";
            this.AddTel.Size = new System.Drawing.Size(100, 20);
            this.AddTel.TabIndex = 15;
            // 
            // AddOrt
            // 
            this.AddOrt.Location = new System.Drawing.Point(56, 65);
            this.AddOrt.Name = "AddOrt";
            this.AddOrt.Size = new System.Drawing.Size(100, 20);
            this.AddOrt.TabIndex = 14;
            // 
            // AddStreet
            // 
            this.AddStreet.Location = new System.Drawing.Point(56, 39);
            this.AddStreet.Name = "AddStreet";
            this.AddStreet.Size = new System.Drawing.Size(100, 20);
            this.AddStreet.TabIndex = 13;
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(56, 13);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(100, 20);
            this.AddName.TabIndex = 12;
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveButton.Location = new System.Drawing.Point(592, 128);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Speichern";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(592, 100);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 14;
            this.btnedit.Text = "Bearbeiten";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(592, 73);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "Löschen";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // editBox
            // 
            this.editBox.Controls.Add(this.editTel);
            this.editBox.Controls.Add(this.editOrt);
            this.editBox.Controls.Add(this.editStreet);
            this.editBox.Controls.Add(this.editName);
            this.editBox.Controls.Add(this.editID);
            this.editBox.Controls.Add(label2);
            this.editBox.Controls.Add(label3);
            this.editBox.Controls.Add(label4);
            this.editBox.Controls.Add(label5);
            this.editBox.Controls.Add(label6);
            this.editBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.editBox.Location = new System.Drawing.Point(424, 184);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(162, 146);
            this.editBox.TabIndex = 16;
            this.editBox.TabStop = false;
            this.editBox.Text = "Bearbeiten";
            // 
            // editTel
            // 
            this.editTel.Location = new System.Drawing.Point(56, 117);
            this.editTel.Name = "editTel";
            this.editTel.Size = new System.Drawing.Size(100, 20);
            this.editTel.TabIndex = 25;
            // 
            // editOrt
            // 
            this.editOrt.Location = new System.Drawing.Point(56, 91);
            this.editOrt.Name = "editOrt";
            this.editOrt.Size = new System.Drawing.Size(100, 20);
            this.editOrt.TabIndex = 24;
            // 
            // editStreet
            // 
            this.editStreet.Location = new System.Drawing.Point(56, 65);
            this.editStreet.Name = "editStreet";
            this.editStreet.Size = new System.Drawing.Size(100, 20);
            this.editStreet.TabIndex = 23;
            // 
            // editName
            // 
            this.editName.Location = new System.Drawing.Point(56, 39);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(100, 20);
            this.editName.TabIndex = 22;
            // 
            // editID
            // 
            this.editID.Enabled = false;
            this.editID.Location = new System.Drawing.Point(56, 13);
            this.editID.Name = "editID";
            this.editID.Size = new System.Drawing.Size(100, 20);
            this.editID.TabIndex = 21;
            // 
            // editbtnSave
            // 
            this.editbtnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editbtnSave.Location = new System.Drawing.Point(592, 190);
            this.editbtnSave.Name = "editbtnSave";
            this.editbtnSave.Size = new System.Drawing.Size(75, 23);
            this.editbtnSave.TabIndex = 17;
            this.editbtnSave.Text = "Speichern";
            this.editbtnSave.UseVisualStyleBackColor = true;
            this.editbtnSave.Click += new System.EventHandler(this.editbtnSave_Click);
            // 
            // Kontakte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(680, 435);
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.editbtnSave);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.kundenDataGridView);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kontakte";
            this.Text = "2_Kontakte";
            this.TopMost = true;
            this.Load += new System.EventHandler(this._2_Kontakte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kundenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundenDataGridView)).EndInit();
            this.addBox.ResumeLayout(false);
            this.addBox.PerformLayout();
            this.editBox.ResumeLayout(false);
            this.editBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private KundenDataSet kundenDataSet;
        private System.Windows.Forms.BindingSource kundenBindingSource;
        private KundenDataSetTableAdapters.KundenTableAdapter kundenTableAdapter;
        private KundenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kundenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox addBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox AddTel;
        private System.Windows.Forms.TextBox AddOrt;
        private System.Windows.Forms.TextBox AddStreet;
        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox editBox;
        private System.Windows.Forms.TextBox editTel;
        private System.Windows.Forms.TextBox editOrt;
        private System.Windows.Forms.TextBox editStreet;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.TextBox editID;
        private System.Windows.Forms.Button editbtnSave;
    }
}