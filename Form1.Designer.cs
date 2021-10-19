
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
            this.lstRelicSubSentence = new System.Windows.Forms.ListBox();
            this.cmdReset = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.labInfo = new System.Windows.Forms.Label();
            this.cmdLevelUp20 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstRelic = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRelicSubSentence
            // 
            this.lstRelicSubSentence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRelicSubSentence.FormattingEnabled = true;
            this.lstRelicSubSentence.ItemHeight = 12;
            this.lstRelicSubSentence.Location = new System.Drawing.Point(3, 17);
            this.lstRelicSubSentence.Name = "lstRelicSubSentence";
            this.lstRelicSubSentence.Size = new System.Drawing.Size(144, 116);
            this.lstRelicSubSentence.TabIndex = 0;
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(443, 19);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(115, 23);
            this.cmdReset.TabIndex = 1;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(443, 48);
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
            this.labInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labInfo.Location = new System.Drawing.Point(6, 202);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(66, 21);
            this.labInfo.TabIndex = 3;
            this.labInfo.Text = "Level: 1";
            // 
            // cmdLevelUp20
            // 
            this.cmdLevelUp20.Location = new System.Drawing.Point(443, 77);
            this.cmdLevelUp20.Name = "cmdLevelUp20";
            this.cmdLevelUp20.Size = new System.Drawing.Size(115, 23);
            this.cmdLevelUp20.TabIndex = 4;
            this.cmdLevelUp20.Text = "Level Up 20";
            this.cmdLevelUp20.UseVisualStyleBackColor = true;
            this.cmdLevelUp20.Click += new System.EventHandler(this.cmdLevelUp20_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artifact";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.labInfo);
            this.groupBox3.Controls.Add(this.cmdLevelUp20);
            this.groupBox3.Controls.Add(this.cmdReset);
            this.groupBox3.Controls.Add(this.cmdAdd);
            this.groupBox3.Location = new System.Drawing.Point(206, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 397);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstRelicSubSentence);
            this.groupBox4.Location = new System.Drawing.Point(6, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 136);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Minor Affixes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstRelic);
            this.groupBox2.Location = new System.Drawing.Point(6, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 403);
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
            this.lstRelic.Location = new System.Drawing.Point(3, 17);
            this.lstRelic.MultiSelect = false;
            this.lstRelic.Name = "lstRelic";
            this.lstRelic.Size = new System.Drawing.Size(188, 383);
            this.lstRelic.TabIndex = 5;
            this.lstRelic.UseCompatibleStateImageBehavior = false;
            this.lstRelic.View = System.Windows.Forms.View.Details;
            this.lstRelic.SelectedIndexChanged += new System.EventHandler(this.lstRelic_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Level";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Location = new System.Drawing.Point(6, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(150, 43);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Main Affix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstRelicSubSentence;
        private System.Windows.Forms.Button cmdReset;
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
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

