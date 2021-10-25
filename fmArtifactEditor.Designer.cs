namespace genshin_sim
{
    partial class fmArtifactEditor
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selSlot3 = new System.Windows.Forms.RadioButton();
            this.selSlot4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labSetEffectInfo = new System.Windows.Forms.Label();
            this.cmbSetEffect = new System.Windows.Forms.ComboBox();
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.gpArtifact.Controls.Add(this.groupBox1);
            this.gpArtifact.Controls.Add(this.groupBox4);
            this.gpArtifact.Controls.Add(this.groupBox3);
            this.gpArtifact.Controls.Add(this.gpMainAffix);
            this.gpArtifact.Location = new System.Drawing.Point(12, 12);
            this.gpArtifact.Name = "gpArtifact";
            this.gpArtifact.Size = new System.Drawing.Size(450, 502);
            this.gpArtifact.TabIndex = 0;
            this.gpArtifact.TabStop = false;
            this.gpArtifact.Text = "Artifact";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selSlot3);
            this.groupBox2.Controls.Add(this.selSlot4);
            this.groupBox2.Location = new System.Drawing.Point(9, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 50);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Initial Affix Count";
            // 
            // selSlot3
            // 
            this.selSlot3.AutoSize = true;
            this.selSlot3.Location = new System.Drawing.Point(118, 20);
            this.selSlot3.Name = "selSlot3";
            this.selSlot3.Size = new System.Drawing.Size(29, 16);
            this.selSlot3.TabIndex = 1;
            this.selSlot3.Text = "3";
            this.selSlot3.UseVisualStyleBackColor = true;
            this.selSlot3.CheckedChanged += new System.EventHandler(this.selSlot3_CheckedChanged);
            // 
            // selSlot4
            // 
            this.selSlot4.AutoSize = true;
            this.selSlot4.Checked = true;
            this.selSlot4.Location = new System.Drawing.Point(39, 20);
            this.selSlot4.Name = "selSlot4";
            this.selSlot4.Size = new System.Drawing.Size(29, 16);
            this.selSlot4.TabIndex = 0;
            this.selSlot4.TabStop = true;
            this.selSlot4.Text = "4";
            this.selSlot4.UseVisualStyleBackColor = true;
            this.selSlot4.CheckedChanged += new System.EventHandler(this.selSlot4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNickName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(222, 20);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(210, 21);
            this.txtNickName.TabIndex = 1;
            this.txtNickName.Text = "NickName";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(6, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 21);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labSetEffectInfo);
            this.groupBox4.Controls.Add(this.cmbSetEffect);
            this.groupBox4.Location = new System.Drawing.Point(228, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 161);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Set Effect";
            // 
            // labSetEffectInfo
            // 
            this.labSetEffectInfo.Location = new System.Drawing.Point(6, 43);
            this.labSetEffectInfo.Name = "labSetEffectInfo";
            this.labSetEffectInfo.Size = new System.Drawing.Size(204, 112);
            this.labSetEffectInfo.TabIndex = 3;
            this.labSetEffectInfo.Text = "Info\r\n两件套 - 效果\r\n四件套 - 效果";
            // 
            // cmbSetEffect
            // 
            this.cmbSetEffect.FormattingEnabled = true;
            this.cmbSetEffect.Location = new System.Drawing.Point(6, 20);
            this.cmbSetEffect.Name = "cmbSetEffect";
            this.cmbSetEffect.Size = new System.Drawing.Size(204, 20);
            this.cmbSetEffect.TabIndex = 2;
            this.cmbSetEffect.SelectedIndexChanged += new System.EventHandler(this.cmbSetEffect_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdRemove);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.cmdAddMinorAffix);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(6, 243);
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
            this.gpMainAffix.Controls.Add(this.groupBox2);
            this.gpMainAffix.Controls.Add(this.labInfo);
            this.gpMainAffix.Controls.Add(this.selLevel);
            this.gpMainAffix.Controls.Add(this.cmbMainAffix);
            this.gpMainAffix.Location = new System.Drawing.Point(6, 76);
            this.gpMainAffix.Name = "gpMainAffix";
            this.gpMainAffix.Size = new System.Drawing.Size(216, 161);
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
            this.cmdCamcel.Location = new System.Drawing.Point(387, 520);
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
            this.cmdOK.Location = new System.Drawing.Point(306, 520);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // fmArtifactEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 555);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCamcel);
            this.Controls.Add(this.gpArtifact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmArtifactEditor";
            this.Text = "Edit Artifact";
            this.Load += new System.EventHandler(this.fmArtifact_Load);
            this.gpArtifact.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cmbSetEffect;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton selSlot3;
        private System.Windows.Forms.RadioButton selSlot4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.TextBox txtName;
    }
}