using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace PrevAlgoritmo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] histsplit;
        string[] histline;

        double[,] CalculaPMSR()
        {
            #region Listas
            ArrayList CorPMVermX = new ArrayList();
            ArrayList CorPMAzulX = new ArrayList();
            ArrayList CorPMVerdX = new ArrayList();
            ArrayList CorPMVermY = new ArrayList();
            ArrayList CorPMAzulY = new ArrayList();
            ArrayList CorPMVerdY = new ArrayList();
            ArrayList CorPMVermZ = new ArrayList();
            ArrayList CorPMAzulZ = new ArrayList();
            ArrayList CorPMVerdZ = new ArrayList();
            #endregion

            double[,] PontoMSaida = new double[3, 3];
            int Universo = dvDadosUniverso.Rows.Count;
            int x, y, z, i = 0;
            int PVerd = 0, PVerm = 0, PAzul = 0;
            Color c;
            while (i < Universo)
            {
                x = Convert.ToInt32(dvDadosUniverso.Rows[i].Cells[0].Value.ToString());
                y = Convert.ToInt32(dvDadosUniverso.Rows[i].Cells[1].Value.ToString());
                z = Convert.ToInt32(dvDadosUniverso.Rows[i].Cells[2].Value.ToString());

                c = dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor;

                if (c == Color.Red)
                {
                    CorPMVermX.Add(x);
                    CorPMVermY.Add(y);
                    CorPMVermZ.Add(z);
                    PVerm++;
                }
                if (c == Color.Blue)
                {
                    CorPMAzulX.Add(x);
                    CorPMAzulY.Add(y);
                    CorPMAzulZ.Add(z);
                    PAzul++;
                }
                if (c == Color.Green)
                {
                    CorPMVerdX.Add(x);
                    CorPMVerdY.Add(y);
                    CorPMVerdZ.Add(z);
                    PVerd++;
                }

                i++;
            }

            int c1 = 0;
            int somaX = 0, somaY = 0, somaZ = 0;
            while (c1 < PVerm)
            {
                somaX = somaX + Convert.ToInt32(CorPMVermX[c1].ToString());
                somaY = somaY + Convert.ToInt32(CorPMVermY[c1].ToString());
                somaZ = somaZ + Convert.ToInt32(CorPMVermZ[c1].ToString());
                c1++;
            }

            PontoMSaida[0, 0] = Convert.ToDouble(somaX) / Convert.ToDouble(PVerm);
            PontoMSaida[0, 1] = Convert.ToDouble(somaY) / Convert.ToDouble(PVerm);
            PontoMSaida[0, 2] = Convert.ToDouble(somaZ) / Convert.ToDouble(PVerm);

            c1 = 0;
            somaX = 0;
            somaY = 0;
            somaZ = 0;

            while (c1 < PAzul)
            {
                somaX = somaX + Convert.ToInt32(CorPMAzulX[c1].ToString());
                somaY = somaY + Convert.ToInt32(CorPMAzulY[c1].ToString());
                somaZ = somaZ + Convert.ToInt32(CorPMAzulZ[c1].ToString());
                c1++;
            }

            PontoMSaida[1, 0] = Convert.ToDouble(somaX) / Convert.ToDouble(PAzul);
            PontoMSaida[1, 1] = Convert.ToDouble(somaY) / Convert.ToDouble(PAzul);
            PontoMSaida[1, 2] = Convert.ToDouble(somaZ) / Convert.ToDouble(PAzul);

            c1 = 0;
            somaX = 0;
            somaY = 0;
            somaZ = 0;

            while (c1 < PVerd)
            {
                somaX = somaX + Convert.ToInt32(CorPMVerdX[c1].ToString());
                somaY = somaY + Convert.ToInt32(CorPMVerdY[c1].ToString());
                somaZ = somaZ + Convert.ToInt32(CorPMVerdZ[c1].ToString());
                c1++;
            }

            PontoMSaida[2, 0] = Convert.ToDouble(somaX) / Convert.ToDouble(PVerd);
            PontoMSaida[2, 1] = Convert.ToDouble(somaY) / Convert.ToDouble(PVerd);
            PontoMSaida[2, 2] = Convert.ToDouble(somaZ) / Convert.ToDouble(PVerd);

            c1 = 0;
            somaX = 0;
            somaY = 0;
            somaZ = 0;

            return PontoMSaida;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dvDadosUniverso.ColumnCount = 4;
            dvDadosUniverso.Columns[0].Name = "E1_X";
            dvDadosUniverso.Columns[1].Name = "E2_Y";
            dvDadosUniverso.Columns[2].Name = "E3_Z";
            dvDadosUniverso.Columns[3].Name = "Distancia";
            string[] row = new string[] { "0", "0", "0" };

            string[,,] Universo = new string[4, 4, 4];
            int x = 1, y = 1, z = 1;
            while (x <= 3)
            {
                while (y <= 3)
                {
                    while (z <= 3)
                    {
                        Universo[x, y, z] = x.ToString() + y.ToString() + z.ToString();
                        row = new string[] { x.ToString(), y.ToString(), z.ToString() };
                        dvDadosUniverso.Rows.Add(row);
                        z++;
                    }
                    z = 1;
                    y++;
                }
                z = 1;
                y = 1;
                x++;
            }
            x = 1;
            y = 1;
            z = 1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = @"C:\Documentos";
            file.RestoreDirectory = true;
            file.Title = "Localizar Arquivos";
            file.DefaultExt = "txt";
            file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            file.FilterIndex = 1;
            file.CheckFileExists = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                String FileName = file.FileName;
                histline = System.IO.File.ReadAllLines(@FileName);
                string[] auxsplit = new string[4];
                histsplit = new string[histline.Count(), 4];
                int i = 0;
                while (i < histline.Count())
                {
                    auxsplit = histline[i].Split('_');
                    histsplit[i, 0] = auxsplit[0];
                    histsplit[i, 1] = auxsplit[1];
                    histsplit[i, 2] = auxsplit[2];
                    histsplit[i, 3] = auxsplit[3];
                    i++;
                }
                int x = 0, y = 0, z = 0, i2 = 0, i3 = 0;
                while (x <= 2)
                {
                    while (y <= 2)
                    {
                        while (z <= 2)
                        {
                            while (i3 < histline.Count())
                            {
                                if ((x + 1).ToString() == histsplit[i3, 0] && (y + 1).ToString() == histsplit[i3, 1] && (z + 1).ToString() == histsplit[i3, 2])
                                {
                                    switch (histsplit[i3, 3])
                                    {
                                        case "azul":
                                            dvDadosUniverso.Rows[i2].DefaultCellStyle.BackColor = Color.Blue;
                                            break;

                                        case "verd":
                                            dvDadosUniverso.Rows[i2].DefaultCellStyle.BackColor = Color.Green;
                                            break;

                                        case "verm":
                                            dvDadosUniverso.Rows[i2].DefaultCellStyle.BackColor = Color.Red;
                                            break;
                                    }

                                }
                                i3++;
                            }
                            i3 = 0;
                            i2++;
                            z++;
                        }
                        z = 0;
                        y++;
                    }
                    z = 0;
                    y = 0;
                    x++;
                }
                i2 = 0;
                x = 0;
                y = 0;
                z = 0;

                lblFonteD.Text = FileName;
                lblDadosI.Text = histline.Count().ToString();
                btnPrevOP.Enabled = true;
                lblUniverso.Text = dvDadosUniverso.Rows.Count.ToString();
                lblPropDIU.Text = (Convert.ToDouble(histline.Count() * 100) / Convert.ToDouble(dvDadosUniverso.Rows.Count)).ToString();
            }

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            double[,] PontoMCalc = CalculaPMSR();
            double distAzul, distVerm, distVerd;
            int Universo = dvDadosUniverso.Rows.Count;
            int x, y, z, i = 0;
            while (i < Universo)
            {
                x = Convert.ToInt32(dvDadosUniverso.Rows[i].Cells[0].Value.ToString());
                y = Convert.ToInt32(dvDadosUniverso.Rows[i].Cells[1].Value.ToString());
                z = Convert.ToInt32(dvDadosUniverso.Rows[i].Cells[2].Value.ToString());

                if (dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor != Color.Red &&
                    dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor != Color.Green &&
                    dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor != Color.Blue)
                {
                    distVerm = Math.Sqrt(
                        Math.Pow((PontoMCalc[0, 0] - x), 2) +
                        Math.Pow((PontoMCalc[0, 1] - y), 2) +
                        Math.Pow((PontoMCalc[0, 2] - z), 2)
                        );
                    distAzul = Math.Sqrt(
                        Math.Pow((PontoMCalc[1, 0] - x), 2) +
                        Math.Pow((PontoMCalc[1, 1] - y), 2) +
                        Math.Pow((PontoMCalc[1, 2] - z), 2)
                        );
                    distVerd = Math.Sqrt(
                        Math.Pow((PontoMCalc[2, 0] - x), 2) +
                        Math.Pow((PontoMCalc[2, 1] - y), 2) +
                        Math.Pow((PontoMCalc[2, 2] - z), 2)
                        );

                    if (distAzul < distVerd && distAzul < distVerm)
                    {
                        dvDadosUniverso.Rows[i].Cells[3].Value = distAzul.ToString();
                        dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                    }

                    if (distVerd < distAzul && distVerd < distVerm)
                    {
                        dvDadosUniverso.Rows[i].Cells[3].Value = distVerd.ToString();
                        dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }

                    if (distVerm < distVerd && distVerm < distAzul)
                    {
                        dvDadosUniverso.Rows[i].Cells[3].Value = distVerm.ToString();
                        dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }

                }
                i++;
            }

            btnBranquearDadosI.Enabled = true;
            btnPrevOP.Enabled = false;
            ch1.Checked = true;
        }

        private void BtnBranquearDadosI_Click(object sender, EventArgs e)
        {
            int x1 = 0, y1 = 0, z1 = 0, i2 = 0, i3 = 0;
            while (x1 <= 2)
            {
                while (y1 <= 2)
                {
                    while (z1 <= 2)
                    {
                        while (i3 < histline.Count())
                        {
                            if ((x1 + 1).ToString() == histsplit[i3, 0] && (y1 + 1).ToString() == histsplit[i3, 1] && (z1 + 1).ToString() == histsplit[i3, 2])
                            {
                                dvDadosUniverso.Rows[i2].DefaultCellStyle.BackColor = Color.White;
                            }
                            i3++;
                        }
                        i3 = 0;
                        i2++;
                        z1++;
                    }
                    z1 = 0;
                    y1++;
                }
                z1 = 0;
                y1 = 0;
                x1++;

            }
            i2 = 0;
            x1 = 0;
            y1 = 0;
            z1 = 0;

            btnBackProp.Enabled = true;
            btnBranquearDadosI.Enabled = false;
            ch2.Checked = true;
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            double[,] PontoMRCalc = CalculaPMSR();

            double distAzul, distVerm, distVerd;
            int Universo = dvDadosUniverso.Rows.Count;
            int x, y, z, i = 0, i2 = 0, a = 0;
            while (i < Universo)
            {
                x = Convert.ToInt32(dvDadosUniverso.Rows[i].Cells[0].Value.ToString());
                y = Convert.ToInt32(dvDadosUniverso.Rows[i].Cells[1].Value.ToString());
                z = Convert.ToInt32(dvDadosUniverso.Rows[i].Cells[2].Value.ToString());

                if (dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor != Color.Red &&
                    dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor != Color.Green &&
                    dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor != Color.Blue)
                {
                    distVerm = Math.Sqrt(
                        Math.Pow((PontoMRCalc[0, 0] - x), 2) +
                        Math.Pow((PontoMRCalc[0, 1] - y), 2) +
                        Math.Pow((PontoMRCalc[0, 2] - z), 2)
                        );
                    distAzul = Math.Sqrt(
                        Math.Pow((PontoMRCalc[1, 0] - x), 2) +
                        Math.Pow((PontoMRCalc[1, 1] - y), 2) +
                        Math.Pow((PontoMRCalc[1, 2] - z), 2)
                        );
                    distVerd = Math.Sqrt(
                        Math.Pow((PontoMRCalc[2, 0] - x), 2) +
                        Math.Pow((PontoMRCalc[2, 1] - y), 2) +
                        Math.Pow((PontoMRCalc[2, 2] - z), 2)
                        );

                    if (distAzul < distVerd && distAzul < distVerm)
                    {
                        dvDadosUniverso.Rows[i].Cells[3].Value = distAzul.ToString();
                        dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                    }

                    if (distVerd < distAzul && distVerd < distVerm)
                    {
                        dvDadosUniverso.Rows[i].Cells[3].Value = distVerd.ToString();
                        dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }

                    if (distVerm < distVerd && distVerm < distAzul)
                    {
                        dvDadosUniverso.Rows[i].Cells[3].Value = distVerm.ToString();
                        dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }

                    while (i2 < histline.Count())
                    {
                        if (dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor == Color.Blue && histsplit[i2, 3] == "azul" &&
                            x.ToString() == histsplit[i2, 0] &&
                            y.ToString() == histsplit[i2, 1] &&
                            z.ToString() == histsplit[i2, 2])
                        {
                            dvDadosUniverso.Rows[i].Cells[3].Value = "ACERTOU";
                            a++;
                        }

                        if (dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor == Color.Green && histsplit[i2, 3] == "verd" &&
                            x.ToString() == histsplit[i2, 0] &&
                            y.ToString() == histsplit[i2, 1] &&
                            z.ToString() == histsplit[i2, 2])
                        {
                            dvDadosUniverso.Rows[i].Cells[3].Value = "ACERTOU";
                            a++;
                        }

                        if (dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor == Color.Red && histsplit[i2, 3] == "verm" &&
                            x.ToString() == histsplit[i2, 0] &&
                            y.ToString() == histsplit[i2, 1] &&
                            z.ToString() == histsplit[i2, 2])
                        {
                            dvDadosUniverso.Rows[i].Cells[3].Value = "ACERTOU";
                            a++;
                        }

                        i2++;
                    }

                    i2 = 0;
                }
                else
                {
                    dvDadosUniverso.Rows[i].Cells[3].Value = "";
                    dvDadosUniverso.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                i++;
            }

            lblTaxaDeRetornoAc.Text = (Convert.ToDouble(a * 100) / Convert.ToDouble(histline.Count())).ToString();

            btnBackProp.Enabled = false;
            ch3.Checked = true;
        }

        private void Btnreset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}