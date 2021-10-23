namespace genshin_sim
{
    partial class fmSelectArtifactType
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
            this.cmdCharacterArtifactFlower = new System.Windows.Forms.Button();
            this.cmdCharacterArtifactPlume = new System.Windows.Forms.Button();
            this.cmdCharacterArtifactSands = new System.Windows.Forms.Button();
            this.cmdCharacterArtifactGoblet = new System.Windows.Forms.Button();
            this.cmdCharacterArtifactCirclet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCharacterArtifactFlower
            // 
            this.cmdCharacterArtifactFlower.ImageIndex = 0;
            this.cmdCharacterArtifactFlower.Location = new System.Drawing.Point(12, 12);
            this.cmdCharacterArtifactFlower.Name = "cmdCharacterArtifactFlower";
            this.cmdCharacterArtifactFlower.Size = new System.Drawing.Size(64, 64);
            this.cmdCharacterArtifactFlower.TabIndex = 1;
            this.cmdCharacterArtifactFlower.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCharacterArtifactFlower.UseVisualStyleBackColor = true;
            this.cmdCharacterArtifactFlower.Click += new System.EventHandler(this.cmdCharacterArtifactFlower_Click);
            // 
            // cmdCharacterArtifactPlume
            // 
            this.cmdCharacterArtifactPlume.ImageIndex = 1;
            this.cmdCharacterArtifactPlume.Location = new System.Drawing.Point(82, 12);
            this.cmdCharacterArtifactPlume.Name = "cmdCharacterArtifactPlume";
            this.cmdCharacterArtifactPlume.Size = new System.Drawing.Size(64, 64);
            this.cmdCharacterArtifactPlume.TabIndex = 2;
            this.cmdCharacterArtifactPlume.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCharacterArtifactPlume.UseVisualStyleBackColor = true;
            this.cmdCharacterArtifactPlume.Click += new System.EventHandler(this.cmdCharacterArtifactPlume_Click);
            // 
            // cmdCharacterArtifactSands
            // 
            this.cmdCharacterArtifactSands.ImageIndex = 2;
            this.cmdCharacterArtifactSands.Location = new System.Drawing.Point(152, 12);
            this.cmdCharacterArtifactSands.Name = "cmdCharacterArtifactSands";
            this.cmdCharacterArtifactSands.Size = new System.Drawing.Size(64, 64);
            this.cmdCharacterArtifactSands.TabIndex = 3;
            this.cmdCharacterArtifactSands.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCharacterArtifactSands.UseVisualStyleBackColor = true;
            this.cmdCharacterArtifactSands.Click += new System.EventHandler(this.cmdCharacterArtifactSands_Click);
            // 
            // cmdCharacterArtifactGoblet
            // 
            this.cmdCharacterArtifactGoblet.ImageIndex = 3;
            this.cmdCharacterArtifactGoblet.Location = new System.Drawing.Point(222, 12);
            this.cmdCharacterArtifactGoblet.Name = "cmdCharacterArtifactGoblet";
            this.cmdCharacterArtifactGoblet.Size = new System.Drawing.Size(64, 64);
            this.cmdCharacterArtifactGoblet.TabIndex = 4;
            this.cmdCharacterArtifactGoblet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCharacterArtifactGoblet.UseVisualStyleBackColor = true;
            this.cmdCharacterArtifactGoblet.Click += new System.EventHandler(this.cmdCharacterArtifactGoblet_Click);
            // 
            // cmdCharacterArtifactCirclet
            // 
            this.cmdCharacterArtifactCirclet.ImageIndex = 4;
            this.cmdCharacterArtifactCirclet.Location = new System.Drawing.Point(292, 12);
            this.cmdCharacterArtifactCirclet.Name = "cmdCharacterArtifactCirclet";
            this.cmdCharacterArtifactCirclet.Size = new System.Drawing.Size(64, 64);
            this.cmdCharacterArtifactCirclet.TabIndex = 5;
            this.cmdCharacterArtifactCirclet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCharacterArtifactCirclet.UseVisualStyleBackColor = true;
            this.cmdCharacterArtifactCirclet.Click += new System.EventHandler(this.cmdCharacterArtifactCirclet_Click);
            // 
            // fmSelectArtifactType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 89);
            this.Controls.Add(this.cmdCharacterArtifactCirclet);
            this.Controls.Add(this.cmdCharacterArtifactGoblet);
            this.Controls.Add(this.cmdCharacterArtifactSands);
            this.Controls.Add(this.cmdCharacterArtifactPlume);
            this.Controls.Add(this.cmdCharacterArtifactFlower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmSelectArtifactType";
            this.Text = "Select Artifact Type";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmSelectArtifactType_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCharacterArtifactFlower;
        private System.Windows.Forms.Button cmdCharacterArtifactPlume;
        private System.Windows.Forms.Button cmdCharacterArtifactSands;
        private System.Windows.Forms.Button cmdCharacterArtifactGoblet;
        private System.Windows.Forms.Button cmdCharacterArtifactCirclet;
    }
}