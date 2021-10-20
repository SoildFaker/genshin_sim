using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genshin_sim
{
    public partial class fmCharacterList : Form
    {
        public fmCharacterList()
        {
            InitializeComponent();
        }

        public Waifu Waifu { get; private set; }
        public Image WaifuImage { get; private set; }
        private string[] raw_lines = Properties.Resources.characters.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        private List<Waifu> waifus = new List<Waifu>();

        private void fmCharacterList_Load(object sender, EventArgs e)
        {
            add_waifus();
            for (int i = 0; i < waifus.Count; i++)
            {
                this.lstCharacters.Items.Add(new ListViewItem(waifus[i].Name, waifus[i].ImageIndex));
            }

        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            fmReturn();
        }

        private void fmReturn()
        {
            this.DialogResult = DialogResult.OK;
            int index = lstCharacters.SelectedItems[0].Index;
            this.Waifu = waifus[index];
            this.WaifuImage = imCharacters.Images[index];
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void add_waifus()
        {
            int total = Convert.ToInt32(get_value("Characters", "total"));
            for (int i = 0; i < total; i++)
            {
                string[] items = get_value("Characters", i.ToString()).Split(',');
                waifus.Add(new Waifu(items[0], cvt_str2element(items[1]), new List<Talent>(), Convert.ToInt32(items[2])));
            }
        }

        private ElementType cvt_str2element(string raw)
        {
            switch (raw)
            {
                case "Hydro":
                    return ElementType.Hydro;
                case "Cryo":
                    return ElementType.Cryo;
                case "Electro":
                    return ElementType.Electro;
                case "Anemo":
                    return ElementType.Anemo;
                case "Geo":
                default:
                    return ElementType.Geo;
            }
        }

        private string get_value(string section, string key)
        {
            for (int i = 0; i < raw_lines.Length; i++)
            {
                if (raw_lines[i] == $"[{section}]")
                {
                    for (int j = i; j < raw_lines.Length; j++)
                    {
                        if (raw_lines[j].StartsWith($"{key}="))
                        {
                            return raw_lines[j].Substring(key.Length + 1);
                        }
                    }
                    return "";
                }
            }
            return "";

        }

        private void lstCharacters_DoubleClick(object sender, EventArgs e)
        {
            if (lstCharacters.SelectedItems.Count > 0)
            {
                fmReturn();
            }
        }
    }
}
