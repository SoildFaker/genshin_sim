
namespace genshin_sim
{
    partial class fmCharacterList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCharacterList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstCharacters = new System.Windows.Forms.ListView();
            this.imCharacters = new System.Windows.Forms.ImageList(this.components);
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstCharacters);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Characters";
            // 
            // lstCharacters
            // 
            this.lstCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCharacters.HideSelection = false;
            this.lstCharacters.LargeImageList = this.imCharacters;
            this.lstCharacters.Location = new System.Drawing.Point(3, 17);
            this.lstCharacters.Name = "lstCharacters";
            this.lstCharacters.Size = new System.Drawing.Size(590, 303);
            this.lstCharacters.TabIndex = 0;
            this.lstCharacters.UseCompatibleStateImageBehavior = false;
            this.lstCharacters.SelectedIndexChanged += new System.EventHandler(this.lstCharacters_SelectedIndexChanged);
            this.lstCharacters.DoubleClick += new System.EventHandler(this.lstCharacters_DoubleClick);
            // 
            // imCharacters
            // 
            this.imCharacters.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imCharacters.ImageStream")));
            this.imCharacters.TransparentColor = System.Drawing.Color.Transparent;
            this.imCharacters.Images.SetKeyName(0, "Character_Albedo_Thumb.png");
            this.imCharacters.Images.SetKeyName(1, "Character_Aloy_Thumb.png");
            this.imCharacters.Images.SetKeyName(2, "Character_Amber_Thumb.png");
            this.imCharacters.Images.SetKeyName(3, "Character_Barbara_Thumb.png");
            this.imCharacters.Images.SetKeyName(4, "Character_Beidou_Thumb.png");
            this.imCharacters.Images.SetKeyName(5, "Character_Bennett_Thumb.png");
            this.imCharacters.Images.SetKeyName(6, "Character_Chongyun_Thumb.png");
            this.imCharacters.Images.SetKeyName(7, "Character_Diluc_Thumb.png");
            this.imCharacters.Images.SetKeyName(8, "Character_Diona_Thumb.png");
            this.imCharacters.Images.SetKeyName(9, "Character_Eula_Thumb.png");
            this.imCharacters.Images.SetKeyName(10, "Character_Fischl_Thumb.png");
            this.imCharacters.Images.SetKeyName(11, "Character_Ganyu_Thumb.png");
            this.imCharacters.Images.SetKeyName(12, "Character_Hu_Tao_Thumb.png");
            this.imCharacters.Images.SetKeyName(13, "Character_Jean_Thumb.png");
            this.imCharacters.Images.SetKeyName(14, "Character_Kaedehara_Kazuha_Thumb.png");
            this.imCharacters.Images.SetKeyName(15, "Character_Kaeya_Thumb.png");
            this.imCharacters.Images.SetKeyName(16, "Character_Kamisato_Ayaka_Thumb.png");
            this.imCharacters.Images.SetKeyName(17, "Character_Keqing_Thumb.png");
            this.imCharacters.Images.SetKeyName(18, "Character_Klee_Thumb.png");
            this.imCharacters.Images.SetKeyName(19, "Character_Lisa_Thumb.png");
            this.imCharacters.Images.SetKeyName(20, "Character_Mona_Thumb.png");
            this.imCharacters.Images.SetKeyName(21, "Character_Ningguang_Thumb.png");
            this.imCharacters.Images.SetKeyName(22, "Character_Noelle_Thumb.png");
            this.imCharacters.Images.SetKeyName(23, "Character_Qiqi_Thumb.png");
            this.imCharacters.Images.SetKeyName(24, "Character_Raiden_Shogun_Thumb.png");
            this.imCharacters.Images.SetKeyName(25, "Character_Razor_Thumb.png");
            this.imCharacters.Images.SetKeyName(26, "Character_Rosaria_Thumb.png");
            this.imCharacters.Images.SetKeyName(27, "Character_Sangonomiya_Kokomi_Thumb.png");
            this.imCharacters.Images.SetKeyName(28, "Character_Sayu_Thumb.png");
            this.imCharacters.Images.SetKeyName(29, "Character_Sucrose_Thumb.png");
            this.imCharacters.Images.SetKeyName(30, "Character_Tartaglia_Thumb.png");
            this.imCharacters.Images.SetKeyName(31, "Character_Traveler_Thumb.png");
            this.imCharacters.Images.SetKeyName(32, "Character_Venti_Thumb.png");
            this.imCharacters.Images.SetKeyName(33, "Character_Xiangling_Thumb.png");
            this.imCharacters.Images.SetKeyName(34, "Character_Xiao_Thumb.png");
            this.imCharacters.Images.SetKeyName(35, "Character_Xingqiu_Thumb.png");
            this.imCharacters.Images.SetKeyName(36, "Character_Xinyan_Thumb.png");
            this.imCharacters.Images.SetKeyName(37, "Character_Yanfei_Thumb.png");
            this.imCharacters.Images.SetKeyName(38, "Character_Yoimiya_Thumb.png");
            this.imCharacters.Images.SetKeyName(39, "Character_Zhongli_Thumb.png");
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.Location = new System.Drawing.Point(530, 341);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.Location = new System.Drawing.Point(449, 341);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // fmCharacterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 376);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmCharacterList";
            this.Text = "Character Select";
            this.Load += new System.EventHandler(this.fmCharacterList_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstCharacters;
        private System.Windows.Forms.ImageList imCharacters;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
    }
}