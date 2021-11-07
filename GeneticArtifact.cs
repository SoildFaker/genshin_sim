using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    class GeneticArtifact
    {
        public List<Gene> Group = new List<Gene>();
        public Gene BestGene { get; private set; }
        public int Generation { get; private set; }
        private Random rand = new Random();
        public GeneticArtifact(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Group.Add(new Gene());
            }
            Generation = 0;
        }

        public void Next()
        {
            this.Group = Group.OrderByDescending(x => x.Score).ToList();
            this.BestGene = Group[0];
            Group.RemoveAt(Group.Count - 1);
            Group.Append(new Gene((int[][])Group[0].Data.Clone()));

            for (int i = 1; i < Group.Count/4; i++)
            {
                Group[i].CrossNoSideEffect(BestGene);
            }
            for (int i = 1; i < Group.Count; i++)
            {
                Group[i].Cross(Group[rand.Next(1, Group.Count)]);
                Group[i].MutateSetEffect();
                Group[i].MutateMinorAffix();
                Group[i].MutateMinorAffixValue();
                Group[i].MutateAll();
            }
            Generation++;
        }

        public Artifact[] GetArtifactsByGene(Gene gene)
        {
            Artifact[] tmp = new Artifact[5];
            for (int i = 0; i < 5; i++)
            {
                List<Affix> minor_affix = new List<Affix>();
                for (int j = 0; j < 4; j++)
                {
                    minor_affix.Add(AffixFactory.minor_affixes_arr[gene.Data[i][6 + j]]);
                }
                for (int j = 4; j < gene.Data[i][5]; j++)
                {
                    minor_affix.Add(AffixFactory.minor_affixes_arr[gene.Data[i][6 + gene.Data[i][6 + j]]]);
                }
                ArtifactType type = ArtifactFactory.artifactTypes[gene.Data[i][0]];
                tmp[i] = new Artifact(type, AffixFactory.get_artifact_main_affix_array(type)[gene.Data[i][4]].Clone()
                    , minor_affix, ArtifactFactory.SetEffects[gene.Data[i][2]], gene.Data[i][1]);
            }
            return tmp;
        }

        public Artifact[] GetBestArtifacts()
        {
            return GetArtifactsByGene(BestGene);
        }
    }

    class Gene
    {
        private int[][] data_arr = new int[5][];
        private Random rand = new Random();
        public int Score { get; set; }

        public int[][] Data
        {
            get { return data_arr; }
        }

        public Gene()
        {
            for (int i = 0; i < 5; i++)
            {
                data_arr[i] = new int[15];
                set_gene(i, data_arr[i]);
            }
        }

        public Gene(int[][] arr)
        {
            this.data_arr = arr;
        }

        private void set_gene(int type, int[] tmp)
        {
            // artifact type
            tmp[0] = type;
            // artifact level
            tmp[1] = 20;
            // artifact set effect, skip unknow set effect
            tmp[2] = rand.Next(ArtifactFactory.SetEffects.Length - 1) + 1;
            // nick name, ignore
            tmp[3] = 0;
            // main affix index
            tmp[4] = pick_main_affix(tmp[0]);
            AffixAttr main_affix_attr = AffixFactory.get_artifact_main_affix_array((ArtifactType)type)[tmp[4]].Attribute;
            // minor affix count
            tmp[5] = 9;
            // pick 4 minor affix index
            List<Affix> minor_affix_list = AffixFactory.minor_affixes_max_arr.ToList();
            minor_affix_list.RemoveAll(x => x.Attribute == main_affix_attr);
            for (int i = 0; i < 4; i++)
            {
                Affix affix = minor_affix_list[rand.Next(minor_affix_list.Count)];
                minor_affix_list.Remove(affix);
                tmp[i + 6] = AffixFactory.minor_affixes_arr.ToList()
                    .IndexOf(affix);
            }
            // pick left minor affix index
            for (int i = 4; i < tmp[5]; i++)
            {
                tmp[i + 6] = rand.Next(4);
            }
        }
        
        private void mutate_minor_affix(int type, int[] tmp)
        {
            AffixAttr main_affix_attr = AffixFactory.get_artifact_main_affix_array((ArtifactType)type)[tmp[4]].Attribute;
            // minor affix count
            tmp[5] = 9;
            // pick 4 minor affix index
            List<Affix> minor_affix_list = AffixFactory.minor_affixes_max_arr.ToList();
            minor_affix_list.RemoveAll(x => x.Attribute == main_affix_attr);
            for (int i = 0; i < 4; i++)
            {
                Affix affix = minor_affix_list[rand.Next(minor_affix_list.Count)];
                minor_affix_list.Remove(affix);
                tmp[i + 6] = AffixFactory.minor_affixes_arr.ToList()
                    .IndexOf(affix);
            }
        }

        private void mutate_minor_affix_value(int type, int[] tmp)
        {
            // pick left minor affix index
            for (int i = 4; i < tmp[5]; i++)
            {
                tmp[i + 6] = rand.Next(4);
            }
        }
        private void mutate_set_effect(int type, int[] tmp)
        {
            // artifact set effect, skip unknow set effect
            tmp[2] = rand.Next(ArtifactFactory.SetEffects.Length - 1) + 1;
        }

        private int pick_main_affix(int type)
        {
            switch (type)
            {
                case 0:
                    return 0;
                case 1:
                    return 0;
                case 2:
                    return rand.Next(AffixFactory.sands_main_affix_attr_arr.Length);
                case 3:
                    return rand.Next(AffixFactory.goblet_main_affix_arr.Length);
                case 4:
                    return rand.Next(AffixFactory.circlet_main_affix_arr.Length);
                default:
                    return 0;
            }
        }
        public void CrossNoSideEffect(Gene gene)
        {
            for (int i = 0; i < 5; i++)
            {
                if (rand.Next(100) > 50)
                {
                    this.data_arr[i] = (int[])gene.Data[i].Clone();
                }
            }
        }

        public void Cross(Gene gene)
        {
            int[] tmp;
            for (int i = 0; i < 5; i++)
            {
                if (rand.Next(100) > 50)
                {
                    tmp = (int[])this.data_arr[i].Clone();
                    this.data_arr[i] = gene.Data[i];
                    gene.SetData(i, tmp);
                }
            }
        }

        public void MutateAll()
        {
            for (int i = 0; i < 5; i++)
            {
                if (rand.Next(100) > 80)
                {
                    set_gene(i, this.data_arr[i]);
                }
            }
        }

        public void MutateMinorAffixValue()
        {
            for (int i = 0; i < 5; i++)
            {
                if (rand.Next(100) > 80)
                {
                    mutate_minor_affix_value(i, this.data_arr[i]);
                }
            }
        }

        public void MutateMinorAffix()
        {
            for (int i = 0; i < 5; i++)
            {
                if (rand.Next(100) > 80)
                {
                    mutate_minor_affix(i, this.data_arr[i]);
                }
            }
        }
        public void MutateSetEffect()
        {
            for (int i = 0; i < 5; i++)
            {
                if (rand.Next(100) > 80)
                {
                    mutate_set_effect(i, this.data_arr[i]);
                }
            }
        }

        public void SetData(int type, int[] data)
        {
            this.data_arr[type] = data;
        }

        public Gene Clone()
        {
            return this.MemberwiseClone() as Gene;
        }
    }
}
