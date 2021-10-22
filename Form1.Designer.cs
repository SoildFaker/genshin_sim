
namespace genshin_sim
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstRelicMinorAffixes = new System.Windows.Forms.ListBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.labInfo = new System.Windows.Forms.Label();
            this.cmdLevelUp20 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbMainAffix = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstRelic = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArtifactTypeImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.labCharacterArtifactSetEffect = new System.Windows.Forms.Label();
            this.gpCharacterArtifactCirclet = new System.Windows.Forms.GroupBox();
            this.labCharacterArtifactCirclet = new System.Windows.Forms.Label();
            this.cmdCharacterArtifactCirclet = new System.Windows.Forms.Button();
            this.gpCharacterArtifactGoblet = new System.Windows.Forms.GroupBox();
            this.labCharacterArtifactGoblet = new System.Windows.Forms.Label();
            this.cmdCharacterArtifactGoblet = new System.Windows.Forms.Button();
            this.gpCharacterArtifactSands = new System.Windows.Forms.GroupBox();
            this.labCharacterArtifactSands = new System.Windows.Forms.Label();
            this.cmdCharacterArtifactSands = new System.Windows.Forms.Button();
            this.gpCharacterArtifactPlume = new System.Windows.Forms.GroupBox();
            this.labCharacterArtifactPlume = new System.Windows.Forms.Label();
            this.cmdCharacterArtifactPlume = new System.Windows.Forms.Button();
            this.gpCharacterArtifactFlower = new System.Windows.Forms.GroupBox();
            this.labCharacterArtifactFlowerInfo = new System.Windows.Forms.Label();
            this.cmdCharacterArtifactFlower = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.labCharacterBaseStat = new System.Windows.Forms.Label();
            this.selCharacterLevel = new System.Windows.Forms.TrackBar();
            this.labCharacterName = new System.Windows.Forms.Label();
            this.cmdCharacterAdd = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.gpCharacterArtifactCirclet.SuspendLayout();
            this.gpCharacterArtifactGoblet.SuspendLayout();
            this.gpCharacterArtifactSands.SuspendLayout();
            this.gpCharacterArtifactPlume.SuspendLayout();
            this.gpCharacterArtifactFlower.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selCharacterLevel)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRelicMinorAffixes
            // 
            this.lstRelicMinorAffixes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRelicMinorAffixes.FormattingEnabled = true;
            this.lstRelicMinorAffixes.ItemHeight = 12;
            this.lstRelicMinorAffixes.Location = new System.Drawing.Point(3, 17);
            this.lstRelicMinorAffixes.Name = "lstRelicMinorAffixes";
            this.lstRelicMinorAffixes.Size = new System.Drawing.Size(174, 116);
            this.lstRelicMinorAffixes.TabIndex = 0;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAdd.Location = new System.Drawing.Point(458, 14);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(115, 23);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = "Level Up";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labInfo.Location = new System.Drawing.Point(6, 202);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(66, 21);
            this.labInfo.TabIndex = 3;
            this.labInfo.Text = "Level: 1";
            // 
            // cmdLevelUp20
            // 
            this.cmdLevelUp20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdLevelUp20.Location = new System.Drawing.Point(458, 43);
            this.cmdLevelUp20.Name = "cmdLevelUp20";
            this.cmdLevelUp20.Size = new System.Drawing.Size(115, 23);
            this.cmdLevelUp20.TabIndex = 4;
            this.cmdLevelUp20.Text = "Level Up 20";
            this.cmdLevelUp20.UseVisualStyleBackColor = true;
            this.cmdLevelUp20.Click += new System.EventHandler(this.cmdLevelUp20_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 518);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artifact";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.labInfo);
            this.groupBox3.Controls.Add(this.cmdLevelUp20);
            this.groupBox3.Controls.Add(this.cmdAdd);
            this.groupBox3.Location = new System.Drawing.Point(283, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 489);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbMainAffix);
            this.groupBox5.Location = new System.Drawing.Point(6, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 43);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Main Affix";
            // 
            // cmbMainAffix
            // 
            this.cmbMainAffix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMainAffix.FormattingEnabled = true;
            this.cmbMainAffix.Location = new System.Drawing.Point(3, 17);
            this.cmbMainAffix.Name = "cmbMainAffix";
            this.cmbMainAffix.Size = new System.Drawing.Size(174, 20);
            this.cmbMainAffix.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstRelicMinorAffixes);
            this.groupBox4.Location = new System.Drawing.Point(6, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 136);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Minor Affixes";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.lstRelic);
            this.groupBox2.Location = new System.Drawing.Point(6, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 495);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artifact List";
            // 
            // lstRelic
            // 
            this.lstRelic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstRelic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRelic.FullRowSelect = true;
            this.lstRelic.GridLines = true;
            this.lstRelic.HideSelection = false;
            this.lstRelic.LargeImageList = this.ArtifactTypeImageList;
            this.lstRelic.Location = new System.Drawing.Point(3, 17);
            this.lstRelic.MultiSelect = false;
            this.lstRelic.Name = "lstRelic";
            this.lstRelic.Size = new System.Drawing.Size(265, 475);
            this.lstRelic.SmallImageList = this.ArtifactTypeImageList;
            this.lstRelic.TabIndex = 5;
            this.lstRelic.UseCompatibleStateImageBehavior = false;
            this.lstRelic.View = System.Windows.Forms.View.Details;
            this.lstRelic.SelectedIndexChanged += new System.EventHandler(this.lstRelic_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader1.Width = 53;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Level";
            this.columnHeader3.Width = 70;
            // 
            // ArtifactTypeImageList
            // 
            this.ArtifactTypeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ArtifactTypeImageList.ImageStream")));
            this.ArtifactTypeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ArtifactTypeImageList.Images.SetKeyName(0, "Icon_Flower_of_Life.png");
            this.ArtifactTypeImageList.Images.SetKeyName(1, "Icon_Plume_of_Death.png");
            this.ArtifactTypeImageList.Images.SetKeyName(2, "Icon_Sands_of_Eon.png");
            this.ArtifactTypeImageList.Images.SetKeyName(3, "Icon_Goblet_of_Eonothem.png");
            this.ArtifactTypeImageList.Images.SetKeyName(4, "Icon_Circlet_of_Logos.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 556);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Character";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Location = new System.Drawing.Point(289, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(278, 202);
            this.groupBox10.TabIndex = 4;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Weapon";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox9.Controls.Add(this.groupBox11);
            this.groupBox9.Controls.Add(this.gpCharacterArtifactCirclet);
            this.groupBox9.Controls.Add(this.gpCharacterArtifactGoblet);
            this.groupBox9.Controls.Add(this.gpCharacterArtifactSands);
            this.groupBox9.Controls.Add(this.gpCharacterArtifactPlume);
            this.groupBox9.Controls.Add(this.gpCharacterArtifactFlower);
            this.groupBox9.Location = new System.Drawing.Point(6, 214);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(561, 310);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Artifact";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.labCharacterArtifactSetEffect);
            this.groupBox11.Location = new System.Drawing.Point(283, 214);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(271, 91);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Artifact Set Effect";
            // 
            // labCharacterArtifactSetEffect
            // 
            this.labCharacterArtifactSetEffect.AutoSize = true;
            this.labCharacterArtifactSetEffect.Location = new System.Drawing.Point(6, 17);
            this.labCharacterArtifactSetEffect.Name = "labCharacterArtifactSetEffect";
            this.labCharacterArtifactSetEffect.Size = new System.Drawing.Size(29, 12);
            this.labCharacterArtifactSetEffect.TabIndex = 2;
            this.labCharacterArtifactSetEffect.Text = "Info";
            // 
            // gpCharacterArtifactCirclet
            // 
            this.gpCharacterArtifactCirclet.Controls.Add(this.labCharacterArtifactCirclet);
            this.gpCharacterArtifactCirclet.Controls.Add(this.cmdCharacterArtifactCirclet);
            this.gpCharacterArtifactCirclet.Location = new System.Drawing.Point(6, 214);
            this.gpCharacterArtifactCirclet.Name = "gpCharacterArtifactCirclet";
            this.gpCharacterArtifactCirclet.Size = new System.Drawing.Size(271, 91);
            this.gpCharacterArtifactCirclet.TabIndex = 5;
            this.gpCharacterArtifactCirclet.TabStop = false;
            this.gpCharacterArtifactCirclet.Text = "Circlet of Logos";
            // 
            // labCharacterArtifactCirclet
            // 
            this.labCharacterArtifactCirclet.AutoSize = true;
            this.labCharacterArtifactCirclet.Location = new System.Drawing.Point(76, 20);
            this.labCharacterArtifactCirclet.Name = "labCharacterArtifactCirclet";
            this.labCharacterArtifactCirclet.Size = new System.Drawing.Size(29, 12);
            this.labCharacterArtifactCirclet.TabIndex = 2;
            this.labCharacterArtifactCirclet.Text = "Info";
            // 
            // cmdCharacterArtifactCirclet
            // 
            this.cmdCharacterArtifactCirclet.ImageIndex = 4;
            this.cmdCharacterArtifactCirclet.ImageList = this.ArtifactTypeImageList;
            this.cmdCharacterArtifactCirclet.Location = new System.Drawing.Point(6, 20);
            this.cmdCharacterArtifactCirclet.Name = "cmdCharacterArtifactCirclet";
            this.cmdCharacterArtifactCirclet.Size = new System.Drawing.Size(64, 64);
            this.cmdCharacterArtifactCirclet.TabIndex = 0;
            this.cmdCharacterArtifactCirclet.Text = "Select";
            this.cmdCharacterArtifactCirclet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCharacterArtifactCirclet.UseVisualStyleBackColor = true;
            this.cmdCharacterArtifactCirclet.Click += new System.EventHandler(this.cmdCharacterArtifactCirclet_Click);
            // 
            // gpCharacterArtifactGoblet
            // 
            this.gpCharacterArtifactGoblet.Controls.Add(this.labCharacterArtifactGoblet);
            this.gpCharacterArtifactGoblet.Controls.Add(this.cmdCharacterArtifactGoblet);
            this.gpCharacterArtifactGoblet.Location = new System.Drawing.Point(283, 117);
            this.gpCharacterArtifactGoblet.Name = "gpCharacterArtifactGoblet";
            this.gpCharacterArtifactGoblet.Size = new System.Drawing.Size(271, 91);
            this.gpCharacterArtifactGoblet.TabIndex = 4;
            this.gpCharacterArtifactGoblet.TabStop = false;
            this.gpCharacterArtifactGoblet.Text = "Goblet of Eonothem";
            // 
            // labCharacterArtifactGoblet
            // 
            this.labCharacterArtifactGoblet.AutoSize = true;
            this.labCharacterArtifactGoblet.Location = new System.Drawing.Point(76, 20);
            this.labCharacterArtifactGoblet.Name = "labCharacterArtifactGoblet";
            this.labCharacterArtifactGoblet.Size = new System.Drawing.Size(29, 12);
            this.labCharacterArtifactGoblet.TabIndex = 2;
            this.labCharacterArtifactGoblet.Text = "Info";
            // 
            // cmdCharacterArtifactGoblet
            // 
            this.cmdCharacterArtifactGoblet.ImageIndex = 3;
            this.cmdCharacterArtifactGoblet.ImageList = this.ArtifactTypeImageList;
            this.cmdCharacterArtifactGoblet.Location = new System.Drawing.Point(6, 20);
            this.cmdCharacterArtifactGoblet.Name = "cmdCharacterArtifactGoblet";
            this.cmdCharacterArtifactGoblet.Size = new System.Drawing.Size(64, 64);
            this.cmdCharacterArtifactGoblet.TabIndex = 0;
            this.cmdCharacterArtifactGoblet.Text = "Select";
            this.cmdCharacterArtifactGoblet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCharacterArtifactGoblet.UseVisualStyleBackColor = true;
            this.cmdCharacterArtifactGoblet.Click += new System.EventHandler(this.cmdCharacterArtifactGoblet_Click);
            // 
            // gpCharacterArtifactSands
            // 
            this.gpCharacterArtifactSands.Controls.Add(this.labCharacterArtifactSands);
            this.gpCharacterArtifactSands.Controls.Add(this.cmdCharacterArtifactSands);
            this.gpCharacterArtifactSands.Location = new System.Drawing.Point(6, 117);
            this.gpCharacterArtifactSands.Name = "gpCharacterArtifactSands";
            this.gpCharacterArtifactSands.Size = new System.Drawing.Size(271, 91);
            this.gpCharacterArtifactSands.TabIndex = 3;
            this.gpCharacterArtifactSands.TabStop = false;
            this.gpCharacterArtifactSands.Text = "Sands of Eon";
            // 
            // labCharacterArtifactSands
            // 
            this.labCharacterArtifactSands.AutoSize = true;
            this.labCharacterArtifactSands.Location = new System.Drawing.Point(76, 20);
            this.labCharacterArtifactSands.Name = "labCharacterArtifactSands";
            this.labCharacterArtifactSands.Size = new System.Drawing.Size(29, 12);
            this.labCharacterArtifactSands.TabIndex = 2;
            this.labCharacterArtifactSands.Text = "Info";
            // 
            // cmdCharacterArtifactSands
            // 
            this.cmdCharacterArtifactSands.ImageIndex = 2;
            this.cmdCharacterArtifactSands.ImageList = this.ArtifactTypeImageList;
            this.cmdCharacterArtifactSands.Location = new System.Drawing.Point(6, 20);
            this.cmdCharacterArtifactSands.Name = "cmdCharacterArtifactSands";
            this.cmdCharacterArtifactSands.Size = new System.Drawing.Size(64, 64);
            this.cmdCharacterArtifactSands.TabIndex = 0;
            this.cmdCharacterArtifactSands.Text = "Select";
            this.cmdCharacterArtifactSands.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCharacterArtifactSands.UseVisualStyleBackColor = true;
            this.cmdCharacterArtifactSands.Click += new System.EventHandler(this.cmdCharacterArtifactSands_Click);
            // 
            // gpCharacterArtifactPlume
            // 
            this.gpCharacterArtifactPlume.Controls.Add(this.labCharacterArtifactPlume);
            this.gpCharacterArtifactPlume.Controls.Add(this.cmdCharacterArtifactPlume);
            this.gpCharacterArtifactPlume.Location = new System.Drawing.Point(283, 20);
            this.gpCharacterArtifactPlume.Name = "gpCharacterArtifactPlume";
            this.gpCharacterArtifactPlume.Size = new System.Drawing.Size(271, 91);
            this.gpCharacterArtifactPlume.TabIndex = 2;
            this.gpCharacterArtifactPlume.TabStop = false;
            this.gpCharacterArtifactPlume.Text = "Plume of Death";
            // 
            // labCharacterArtifactPlume
            // 
            this.labCharacterArtifactPlume.AutoSize = true;
            this.labCharacterArtifactPlume.Location = new System.Drawing.Point(76, 20);
            this.labCharacterArtifactPlume.Name = "labCharacterArtifactPlume";
            this.labCharacterArtifactPlume.Size = new System.Drawing.Size(29, 12);
            this.labCharacterArtifactPlume.TabIndex = 2;
            this.labCharacterArtifactPlume.Text = "Info";
            // 
            // cmdCharacterArtifactPlume
            // 
            this.cmdCharacterArtifactPlume.ImageIndex = 1;
            this.cmdCharacterArtifactPlume.ImageList = this.ArtifactTypeImageList;
            this.cmdCharacterArtifactPlume.Location = new System.Drawing.Point(6, 20);
            this.cmdCharacterArtifactPlume.Name = "cmdCharacterArtifactPlume";
            this.cmdCharacterArtifactPlume.Size = new System.Drawing.Size(64, 64);
            this.cmdCharacterArtifactPlume.TabIndex = 0;
            this.cmdCharacterArtifactPlume.Text = "Select";
            this.cmdCharacterArtifactPlume.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCharacterArtifactPlume.UseVisualStyleBackColor = true;
            this.cmdCharacterArtifactPlume.Click += new System.EventHandler(this.cmdCharacterArtifactPlume_Click);
            // 
            // gpCharacterArtifactFlower
            // 
            this.gpCharacterArtifactFlower.Controls.Add(this.labCharacterArtifactFlowerInfo);
            this.gpCharacterArtifactFlower.Controls.Add(this.cmdCharacterArtifactFlower);
            this.gpCharacterArtifactFlower.Location = new System.Drawing.Point(6, 20);
            this.gpCharacterArtifactFlower.Name = "gpCharacterArtifactFlower";
            this.gpCharacterArtifactFlower.Size = new System.Drawing.Size(271, 91);
            this.gpCharacterArtifactFlower.TabIndex = 1;
            this.gpCharacterArtifactFlower.TabStop = false;
            this.gpCharacterArtifactFlower.Text = "Flower of Life";
            // 
            // labCharacterArtifactFlowerInfo
            // 
            this.labCharacterArtifactFlowerInfo.AutoSize = true;
            this.labCharacterArtifactFlowerInfo.Location = new System.Drawing.Point(76, 20);
            this.labCharacterArtifactFlowerInfo.Name = "labCharacterArtifactFlowerInfo";
            this.labCharacterArtifactFlowerInfo.Size = new System.Drawing.Size(29, 12);
            this.labCharacterArtifactFlowerInfo.TabIndex = 2;
            this.labCharacterArtifactFlowerInfo.Text = "Info";
            // 
            // cmdCharacterArtifactFlower
            // 
            this.cmdCharacterArtifactFlower.ImageIndex = 0;
            this.cmdCharacterArtifactFlower.ImageList = this.ArtifactTypeImageList;
            this.cmdCharacterArtifactFlower.Location = new System.Drawing.Point(6, 20);
            this.cmdCharacterArtifactFlower.Name = "cmdCharacterArtifactFlower";
            this.cmdCharacterArtifactFlower.Size = new System.Drawing.Size(64, 64);
            this.cmdCharacterArtifactFlower.TabIndex = 0;
            this.cmdCharacterArtifactFlower.Text = "Select";
            this.cmdCharacterArtifactFlower.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCharacterArtifactFlower.UseVisualStyleBackColor = true;
            this.cmdCharacterArtifactFlower.Click += new System.EventHandler(this.cmdCharacterArtifactFlower_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Location = new System.Drawing.Point(573, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(301, 518);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Attributes";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.selCharacterLevel);
            this.groupBox6.Controls.Add(this.labCharacterName);
            this.groupBox6.Controls.Add(this.cmdCharacterAdd);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(277, 202);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Character Select";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.labCharacterBaseStat);
            this.groupBox8.Location = new System.Drawing.Point(6, 73);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(265, 123);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Base Stat";
            // 
            // labCharacterBaseStat
            // 
            this.labCharacterBaseStat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCharacterBaseStat.Location = new System.Drawing.Point(6, 17);
            this.labCharacterBaseStat.Name = "labCharacterBaseStat";
            this.labCharacterBaseStat.Size = new System.Drawing.Size(253, 103);
            this.labCharacterBaseStat.TabIndex = 0;
            this.labCharacterBaseStat.Text = "Stat";
            // 
            // selCharacterLevel
            // 
            this.selCharacterLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selCharacterLevel.BackColor = System.Drawing.Color.White;
            this.selCharacterLevel.Location = new System.Drawing.Point(59, 43);
            this.selCharacterLevel.Maximum = 90;
            this.selCharacterLevel.Minimum = 1;
            this.selCharacterLevel.Name = "selCharacterLevel";
            this.selCharacterLevel.Size = new System.Drawing.Size(212, 45);
            this.selCharacterLevel.TabIndex = 2;
            this.selCharacterLevel.TickFrequency = 10;
            this.selCharacterLevel.Value = 1;
            this.selCharacterLevel.Scroll += new System.EventHandler(this.selCharacterLevel_Scroll);
            // 
            // labCharacterName
            // 
            this.labCharacterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCharacterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labCharacterName.Location = new System.Drawing.Point(59, 17);
            this.labCharacterName.Name = "labCharacterName";
            this.labCharacterName.Size = new System.Drawing.Size(212, 23);
            this.labCharacterName.TabIndex = 1;
            this.labCharacterName.Text = "Name: ";
            this.labCharacterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdCharacterAdd
            // 
            this.cmdCharacterAdd.BackColor = System.Drawing.Color.White;
            this.cmdCharacterAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdCharacterAdd.BackgroundImage")));
            this.cmdCharacterAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCharacterAdd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdCharacterAdd.Location = new System.Drawing.Point(3, 17);
            this.cmdCharacterAdd.Name = "cmdCharacterAdd";
            this.cmdCharacterAdd.Size = new System.Drawing.Size(50, 50);
            this.cmdCharacterAdd.TabIndex = 0;
            this.cmdCharacterAdd.UseVisualStyleBackColor = false;
            this.cmdCharacterAdd.Click += new System.EventHandler(this.cmdCharacterAdd_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Artifact Sim";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 580);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Genshin Impact Damage Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.gpCharacterArtifactCirclet.ResumeLayout(false);
            this.gpCharacterArtifactCirclet.PerformLayout();
            this.gpCharacterArtifactGoblet.ResumeLayout(false);
            this.gpCharacterArtifactGoblet.PerformLayout();
            this.gpCharacterArtifactSands.ResumeLayout(false);
            this.gpCharacterArtifactSands.PerformLayout();
            this.gpCharacterArtifactPlume.ResumeLayout(false);
            this.gpCharacterArtifactPlume.PerformLayout();
            this.gpCharacterArtifactFlower.ResumeLayout(false);
            this.gpCharacterArtifactFlower.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selCharacterLevel)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstRelicMinorAffixes;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.Button cmdLevelUp20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstRelic;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbMainAffix;
        private System.Windows.Forms.ImageList ArtifactTypeImageList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button cmdCharacterAdd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labCharacterName;
        private System.Windows.Forms.TrackBar selCharacterLevel;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label labCharacterBaseStat;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox gpCharacterArtifactGoblet;
        private System.Windows.Forms.Label labCharacterArtifactGoblet;
        private System.Windows.Forms.Button cmdCharacterArtifactGoblet;
        private System.Windows.Forms.GroupBox gpCharacterArtifactSands;
        private System.Windows.Forms.Label labCharacterArtifactSands;
        private System.Windows.Forms.Button cmdCharacterArtifactSands;
        private System.Windows.Forms.GroupBox gpCharacterArtifactPlume;
        private System.Windows.Forms.Label labCharacterArtifactPlume;
        private System.Windows.Forms.Button cmdCharacterArtifactPlume;
        private System.Windows.Forms.GroupBox gpCharacterArtifactFlower;
        private System.Windows.Forms.Label labCharacterArtifactFlowerInfo;
        private System.Windows.Forms.Button cmdCharacterArtifactFlower;
        private System.Windows.Forms.GroupBox gpCharacterArtifactCirclet;
        private System.Windows.Forms.Label labCharacterArtifactCirclet;
        private System.Windows.Forms.Button cmdCharacterArtifactCirclet;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label labCharacterArtifactSetEffect;
    }
}

