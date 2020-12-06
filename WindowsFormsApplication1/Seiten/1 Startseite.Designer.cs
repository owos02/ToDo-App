namespace WindowsFormsApplication1
{
    partial class Startseite
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startseite));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PCNAMEL = new System.Windows.Forms.Label();
            this.KontaktButton = new System.Windows.Forms.Button();
            this.TODOButton = new System.Windows.Forms.Button();
            this.ProgInf = new System.Windows.Forms.GroupBox();
            this.ProgrammerName = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.ProgInf.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PCNAMEL);
            this.groupBox2.Controls.Add(this.KontaktButton);
            this.groupBox2.Controls.Add(this.TODOButton);
            this.groupBox2.ForeColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // PCNAMEL
            // 
            resources.ApplyResources(this.PCNAMEL, "PCNAMEL");
            this.PCNAMEL.Name = "PCNAMEL";
            // 
            // KontaktButton
            // 
            this.KontaktButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.KontaktButton, "KontaktButton");
            this.KontaktButton.ForeColor = System.Drawing.Color.Azure;
            this.KontaktButton.Name = "KontaktButton";
            this.KontaktButton.UseVisualStyleBackColor = true;
            this.KontaktButton.Click += new System.EventHandler(this.KontaktButton_Click);
            // 
            // TODOButton
            // 
            resources.ApplyResources(this.TODOButton, "TODOButton");
            this.TODOButton.FlatAppearance.BorderSize = 0;
            this.TODOButton.ForeColor = System.Drawing.Color.Azure;
            this.TODOButton.Name = "TODOButton";
            this.TODOButton.UseVisualStyleBackColor = true;
            this.TODOButton.Click += new System.EventHandler(this.TODOButton_Click);
            // 
            // ProgInf
            // 
            this.ProgInf.Controls.Add(this.ProgrammerName);
            this.ProgInf.ForeColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.ProgInf, "ProgInf");
            this.ProgInf.Name = "ProgInf";
            this.ProgInf.TabStop = false;
            // 
            // ProgrammerName
            // 
            this.ProgrammerName.ForeColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.ProgrammerName, "ProgrammerName");
            this.ProgrammerName.Name = "ProgrammerName";
            this.ProgrammerName.Click += new System.EventHandler(this.Nam1_Click);
            // 
            // Startseite
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.ProgInf);
            this.Controls.Add(this.groupBox2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Azure;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Startseite";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Startseite_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ProgInf.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox ProgInf;
        private System.Windows.Forms.Label ProgrammerName;
        private System.Windows.Forms.Button KontaktButton;
        private System.Windows.Forms.Button TODOButton;
        private System.Windows.Forms.Label PCNAMEL;
    }
}

