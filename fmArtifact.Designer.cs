namespace genshin_sim
{
    partial class fmArtifact
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
            this.gpArtifact = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labSetEffectInfo = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstMinorAffixList = new System.Windows.Forms.ListBox();
            this.cmdAddMinorAffix = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstSelectedMinorAffix = new System.Windows.Forms.ListBox();
            this.gpMainAffix = new System.Windows.Forms.GroupBox();
            this.labInfo = new System.Windows.Forms.Label();
            this.selLevel = new System.Windows.Forms.TrackBar();
            this.cmbMainAffix = new System.Windows.Forms.ComboBox();
            this.cmdCamcel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.gpArtifact.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gpMainAffix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // gpArtifact
            // 
            this.gpArtifact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpArtifact.Controls.Add(this.groupBox4);
            this.gpArtifact.Controls.Add(this.groupBox3);
            this.gpArtifact.Controls.Add(this.gpMainAffix);
            this.gpArtifact.Location = new System.Drawing.Point(12, 12);
            this.gpArtifact.Name = "gpArtifact";
            this.gpArtifact.Size = new System.Drawing.Size(451, 397);
            this.gpArtifact.TabIndex = 0;
            this.gpArtifact.TabStop = false;
            this.gpArtifact.Text = "Artifact";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labSetEffectInfo);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Location = new System.Drawing.Point(228, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 112);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Set Effect";
            // 
            // labSetEffectInfo
            // 
            this.labSetEffectInfo.AutoSize = true;
            this.labSetEffectInfo.Location = new System.Drawing.Point(6, 43);
            this.labSetEffectInfo.Name = "labSetEffectInfo";
            this.labSetEffectInfo.Size = new System.Drawing.Size(83, 36);
            this.labSetEffectInfo.TabIndex = 3;
            this.labSetEffectInfo.Text = "Info\r\n两件套 - 效果\r\n四件套 - 效果";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(204, 20);
            this.comboBox2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdRemove);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.cmdAddMinorAffix);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(6, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 253);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Minor Affix";
            // 
            // cmdRemove
            // 
            this.cmdRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRemove.Location = new System.Drawing.Point(197, 135);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(44, 23);
            this.cmdRemove.TabIndex = 4;
            this.cmdRemove.Text = "->";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.lstMinorAffixList);
            this.groupBox6.Location = new System.Drawing.Point(247, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(185, 227);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Minor Affix List";
            // 
            // lstMinorAffixList
            // 
            this.lstMinorAffixList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMinorAffixList.FormattingEnabled = true;
            this.lstMinorAffixList.ItemHeight = 12;
            this.lstMinorAffixList.Location = new System.Drawing.Point(3, 17);
            this.lstMinorAffixList.Name = "lstMinorAffixList";
            this.lstMinorAffixList.Size = new System.Drawing.Size(179, 207);
            this.lstMinorAffixList.TabIndex = 0;
            this.lstMinorAffixList.SelectedIndexChanged += new System.EventHandler(this.lstMinorAffixList_SelectedIndexChanged);
            this.lstMinorAffixList.DoubleClick += new System.EventHandler(this.lstMinorAffixList_DoubleClick);
            // 
            // cmdAddMinorAffix
            // 
            this.cmdAddMinorAffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAddMinorAffix.Location = new System.Drawing.Point(197, 106);
            this.cmdAddMinorAffix.Name = "cmdAddMinorAffix";
            this.cmdAddMinorAffix.Size = new System.Drawing.Size(44, 23);
            this.cmdAddMinorAffix.TabIndex = 1;
            this.cmdAddMinorAffix.Text = "<-";
            this.cmdAddMinorAffix.UseVisualStyleBackColor = true;
            this.cmdAddMinorAffix.Click += new System.EventHandler(this.cmdAddMinorAffix_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.lstSelectedMinorAffix);
            this.groupBox5.Location = new System.Drawing.Point(6, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(185, 227);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Selected";
            // 
            // lstSelectedMinorAffix
            // 
            this.lstSelectedMinorAffix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSelectedMinorAffix.FormattingEnabled = true;
            this.lstSelectedMinorAffix.ItemHeight = 12;
            this.lstSelectedMinorAffix.Location = new System.Drawing.Point(3, 17);
            this.lstSelectedMinorAffix.Name = "lstSelectedMinorAffix";
            this.lstSelectedMinorAffix.Size = new System.Drawing.Size(179, 207);
            this.lstSelectedMinorAffix.TabIndex = 0;
            this.lstSelectedMinorAffix.SelectedIndexChanged += new System.EventHandler(this.lstSelectedMinorAffix_SelectedIndexChanged);
            this.lstSelectedMinorAffix.DoubleClick += new System.EventHandler(this.lstSelectedMinorAffix_DoubleClick);
            // 
            // gpMainAffix
            // 
            this.gpMainAffix.Controls.Add(this.labInfo);
            this.gpMainAffix.Controls.Add(this.selLevel);
            this.gpMainAffix.Controls.Add(this.cmbMainAffix);
            this.gpMainAffix.Location = new System.Drawing.Point(6, 20);
            this.gpMainAffix.Name = "gpMainAffix";
            this.gpMainAffix.Size = new System.Drawing.Size(216, 112);
            this.gpMainAffix.TabIndex = 0;
            this.gpMainAffix.TabStop = false;
            this.gpMainAffix.Text = "Main Affix";
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Location = new System.Drawing.Point(7, 76);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(29, 12);
            this.labInfo.TabIndex = 3;
            this.labInfo.Text = "Info";
            // 
            // selLevel
            // 
            this.selLevel.Location = new System.Drawing.Point(6, 43);
            this.selLevel.Maximum = 20;
            this.selLevel.Name = "selLevel";
            this.selLevel.Size = new System.Drawing.Size(204, 45);
            this.selLevel.TabIndex = 2;
            this.selLevel.Scroll += new System.EventHandler(this.selLevel_Scroll);
            // 
            // cmbMainAffix
            // 
            this.cmbMainAffix.FormattingEnabled = true;
            this.cmbMainAffix.Location = new System.Drawing.Point(6, 20);
            this.cmbMainAffix.Name = "cmbMainAffix";
            this.cmbMainAffix.Size = new System.Drawing.Size(204, 20);
            this.cmbMainAffix.TabIndex = 1;
            this.cmbMainAffix.SelectedIndexChanged += new System.EventHandler(this.cmbMainAffix_SelectedIndexChanged);
            // 
            // cmdCamcel
            // 
            this.cmdCamcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCamcel.Location = new System.Drawing.Point(388, 415);
            this.cmdCamcel.Name = "cmdCamcel";
            this.cmdCamcel.Size = new System.Drawing.Size(75, 23);
            this.cmdCamcel.TabIndex = 1;
            this.cmdCamcel.Text = "Cancel";
            this.cmdCamcel.UseVisualStyleBackColor = true;
            this.cmdCamcel.Click += new System.EventHandler(this.cmdCamcel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.Enabled = false;
            this.cmdOK.Location = new System.Drawing.Point(307, 415);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // fmArtifact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCamcel);
            this.Controls.Add(this.gpArtifact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmArtifact";
            this.Text = "fmArtifact";
            this.gpArtifact.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.gpMainAffix.ResumeLayout(false);
            this.gpMainAffix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpArtifact;
        private System.Windows.Forms.Button cmdCamcel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labSetEffectInfo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lstMinorAffixList;
        private System.Windows.Forms.Button cmdAddMinorAffix;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstSelectedMinorAffix;
        private System.Windows.Forms.GroupBox gpMainAffix;
        private System.Windows.Forms.ComboBox cmbMainAffix;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.TrackBar selLevel;
        private System.Windows.Forms.Label labInfo;
    }
}