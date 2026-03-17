using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsAllenBM
{
    public partial class Form1 : Form
    {
        //inizializzo variabili
        public string str; 
        public List<Training> lstTrain;
        public int min, count, swim, weights, run;
        public bool Valid;
        public List<string> place;
        public Training train;
        public string[] camp;
        public char separator;

        public enum Type
        {
            run,
            weights, 
            swim
        }

        public struct Training
        {
            public int duration, id;
            public Type type;
            public string place;

            public Training(int durata, Type tipo, string posto, int id1)
            {
                duration = durata;
                type = tipo;
                place = posto;
                id = id1;
            }

            public string description()
            {
                return $"TRAINING N° {this.id} - DURATION: {this.duration} - TYPE: {this.type} - PLACE: {this.place};";
            }

        }

        public Form1()
        {
            InitializeComponent();
            lstTrain = new List<Training>();
            count = 0;
            pnlOption2.Visible = false;
            place = new List<string>();
            separator = ';';
            Download();
            cmbType.DataSource = Enum.GetValues(typeof(Type));

        }

        public void Download()
        {
            count = 0;
            using (StreamReader sr = new StreamReader(@"C:\Users\ASUS\Desktop\INFORMATICA_TERZA\C#\EsAllenBM\EsAllenBM\bin\Debug\allenamenti_input.txt"))
            {
                if(sr.ReadLine() != null)
                {
                    while (!sr.EndOfStream)
                    {
                        train = ConvertiIN(sr.ReadLine());
                        lstAllenamenti.Items.Add(train.description());
                        lstTrain.Add(train);
                    }
                }
            }
        }

        public Training ConvertiIN(string riga)
        {
            train = new Training();
            camp = riga.Split(separator);
            train.id = int.Parse(camp[0]);
            train.duration = int.Parse(camp[1]);
            Enum.TryParse<Type>(camp[2], out Type tipo);
            train.type = tipo;
            train.place = camp[3];
            count = int.Parse(camp[0]);
            return train;
        }

        public void Upload()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\ASUS\Desktop\INFORMATICA_TERZA\C#\EsAllenBM\EsAllenBM\bin\Debug\allenamenti_input.txt"))
            {
                foreach(Training t in lstTrain)
                {
                    sw.WriteLine(ConvertiOUT(t));
                }
            }
        }

        public string ConvertiOUT(Training t)
        {
            str = "";
            str += t.id + ";";
            str += t.duration + ";";
            str += t.type + ";";
            str += t.place;
            return str;
        }


        private void txtMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Clear && e.KeyChar != '-')
            {
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Training all = new Training();
            Valid = Control(ref all);
            if (Valid  &&  count < 10 && txtMinute.Text != "-1")
            {
                count++;
                lstTrain.Add(all);
                lstAllenamenti.Items.Clear();
                foreach (Training al in lstTrain)
                {
                    lstAllenamenti.Items.Add(al.description());
                }
            }else if(count>=10 || txtMinute.Text == "-1")
            {
                btnAdd.Enabled = false;
                pnlOption2.Visible = true;
            }

        }

        private void btnSequenza_Click(object sender, EventArgs e)
        {
            count = 0;
            run = 0; swim = 0; weights = 0;

            for (int i = 0; i < lstTrain.Count - 3; i++)
            {
                if (lstTrain[i].type == lstTrain[i+1].type && lstTrain[i+1].type == lstTrain[i + 2].type)
                {
                    if (lstTrain[i++].duration == (lstTrain[i].duration + lstTrain[i + 2].duration) / 2)
                    {
                        MessageBox.Show("SEQUENCE : "+ Environment.NewLine + lstTrain[i].description() + Environment.NewLine + lstTrain[i+1].description() + Environment.NewLine + lstTrain[i + 2].description());
                    }
                }
            }
            count++;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Upload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstTrain.Count == 0) return;

            if (lstAllenamenti.SelectedIndex == -1)
            {
                MessageBox.Show("Select a training to delete it");
                return;
            }
            else
            {
                lstTrain.RemoveAt(lstAllenamenti.SelectedIndex);
                lstAllenamenti.Items.RemoveAt(lstAllenamenti.SelectedIndex);
                count--;
                for(int i=0; i < lstTrain.Count; i++)
                {
                    Training t = lstTrain[i];
                    t.id = i;
                    lstTrain[i] = t;
                }

                lstAllenamenti.Items.Clear();
                foreach(Training t in lstTrain)
                {
                    lstAllenamenti.Items.Add(t.description());
                }
            }
            if (lstTrain.Count < 5)
            {
                pnlOption2.Visible = false;
                btnAdd.Enabled = true;
            }
        }

        private void btnStampa1_Click(object sender, EventArgs e)
        {
            run = 0; weights = 0; swim = 0;
            foreach (Training all in lstTrain)
            {
                if(all.type == (Type)0)
                {
                    run++;
                }else if(all.type == (Type)1)
                {
                    weights++;
                }
                else
                {
                    swim++;
                }
            }
            MessageBox.Show($"N° OF TRAINING\nRUN : {run}\nWEIGHTS : {weights}\nSWIM: {swim}");
        }

        private void btnMaxType_Click(object sender, EventArgs e)
        {
            run = 0; weights = 0; swim = 0;
            foreach (Training all in lstTrain)
            {
                if (all.type == (Type)0 && all.duration > run) run = all.duration;
                else if (all.type == (Type)1 && all.duration > weights) weights = all.duration;
                else if(all.type == (Type)2 && all.duration > swim) swim = all.duration;
            }
            MessageBox.Show($"DURATION MAX\n Run : {run}\nWeights : {weights}\nSWIM: {swim}");
        }

        private void btnPlace40_Click(object sender, EventArgs e)
        {
            str = "LONG TRAINING: \n";
            foreach(Training all in lstTrain)
            {
                if(all.duration>40 && !str.Contains(all.place))
                {
                    str += all.place + "\n";
                }
            }
            MessageBox.Show(str);
        }

        public bool Control(ref Training all)
        {
            all.id = count;
            if (!int.TryParse(txtMinute.Text, out min))
            {
                MessageBox.Show("Insert the duration");
                return false;
            }else if (min < 0)
            {
                MessageBox.Show("Insert a valid duration");
                return false;
            }
            all.duration = min;
            if (cmbType.SelectedIndex < 0)
            {
                MessageBox.Show("Select a type of training");
                return false;
            }
            all.type = (Type)cmbType.SelectedIndex;
            if (string.IsNullOrWhiteSpace(txtPlace.Text))
            {
                MessageBox.Show("Insert the place");
                return false;
            }
            all.place = txtPlace.Text;
            return true;
        }
    }
}
