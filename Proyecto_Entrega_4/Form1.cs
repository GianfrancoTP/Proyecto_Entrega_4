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

namespace Proyecto_Entrega_4
{
    public partial class Form1 : Form
    {
        int OriginalWidth1;
        int OriginalWidth2;
        int OriginalWidthForm;
        string info_end = ""; // Aqui reescribiremos la informacion estadística
        int alto;
        int ancho;
        int cantidad_mese = 10;
        int mes = 0;
        public Mapa mapa1 = new Mapa();
        Terreno[,] opcion1;
        Label[,] labels;
        float numero_muertos = 0;
        float[] numero_creados = { 0, 0, 0, 0, 0, 0 };
        Terreno Vegetación = new Terreno("Vegetacn");
        Terreno Acuático = new Terreno("Acuatico");
        Terreno Desierto = new Terreno("Desierto");
        Terreno Nieve = new Terreno("NieveIce");
        Terreno Volcán = new Terreno("Volcanic");
        List<Bitmon> bitmons1 = new List<Bitmon>();
        List<Bitmon> bitmonsInicial = new List<Bitmon>();
        public Form1()
        {
            InitializeComponent();
            BitmonsMapButton.Enabled = false;
            ResultadosButton.Enabled = false;
            SaveButton.Enabled = false;
            RestartButton.Enabled = false;
            bunifuFlatButton1.Enabled = false;
            MapButton.Enabled = false;
            OriginalWidth1 = MenuPanel1.Width;
            OriginalWidth2 = MenuPanel2.Width;
            OriginalWidthForm = this.Width;
            InfoMonthLabel.Text = "";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            MaximizeButton.Visible = false;
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            MaximizeButton.Visible = true;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (MenuPanel2.Width == OriginalWidth2)
            {
                MenuPanel2.Visible = false;
                MenuPanel2.Width = OriginalWidth2 - 157;
                MenuPanel1.Width = OriginalWidth1 - 153;
                CloseAnimation.Show(MenuPanel2);
                this.Width = OriginalWidthForm - 153;
            }
            else
            {
                MenuPanel2.Visible = false;
                MenuPanel2.Width = OriginalWidth2;
                MenuPanel1.Width = OriginalWidth1;
                OpenAnimation.Show(MenuPanel2);
                this.Width = OriginalWidthForm;
            }
        }
        private void BunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
        private void Map1Button_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            MonthNumberBox.Visible = true;
            InfoMonthLabel.Visible = true;
            NextMonthButton.Visible = true;
            MapSizeLabel.Visible = false;
            Map1Button.Visible = false;
            Map2Button.Visible = false;
            Map3Button.Visible = false;
            MonthNumberLabel.Visible = true;
            MapPanel.Visible = true;
            MapButton.Enabled = true;
            MapButton.Textcolor = Color.LightGray;
            RestartButton.Enabled = true;
            bunifuFlatButton1.Enabled = true;
            RestartButton.Textcolor = Color.LightGray;
            bunifuFlatButton1.Textcolor = Color.LightGray;
            //button3.Visible = false;
            alto = 6;
            ancho = 6;
            opcion1 = new Terreno[6, 6];
            labels = new Label[alto, ancho];

            opcion1[0, 0] = Acuático;
            opcion1[0, 1] = Vegetación;
            opcion1[0, 2] = Vegetación;
            opcion1[0, 3] = Vegetación;
            opcion1[0, 4] = Vegetación;
            opcion1[0, 5] = Desierto;
            opcion1[1, 0] = Acuático;
            opcion1[1, 1] = Vegetación;
            opcion1[1, 2] = Volcán;
            opcion1[1, 3] = Volcán;
            opcion1[1, 4] = Volcán;
            opcion1[1, 5] = Desierto;
            opcion1[2, 0] = Acuático;
            opcion1[2, 1] = Vegetación;
            opcion1[2, 2] = Volcán;
            opcion1[2, 3] = Nieve;
            opcion1[2, 4] = Volcán;
            opcion1[2, 5] = Desierto;
            opcion1[3, 0] = Acuático;
            opcion1[3, 1] = Vegetación;
            opcion1[3, 2] = Volcán;
            opcion1[3, 3] = Volcán;
            opcion1[3, 4] = Volcán;
            opcion1[3, 5] = Desierto;
            opcion1[4, 0] = Acuático;
            opcion1[4, 1] = Vegetación;
            opcion1[4, 2] = Vegetación;
            opcion1[4, 3] = Desierto;
            opcion1[4, 4] = Desierto;
            opcion1[4, 5] = Desierto;
            opcion1[5, 0] = Acuático;
            opcion1[5, 1] = Vegetación;
            opcion1[5, 2] = Desierto;
            opcion1[5, 3] = Desierto;
            opcion1[5, 4] = Desierto;
            opcion1[5, 5] = Desierto;

            int[] pos1 = { 3, 1 };
            Taplan taplan1 = new Taplan(pos1);

            //Poblacion inicial de Ents
            int[] pos6 = { 2, 3 };
            Ent Ent1 = new Ent(pos6);

            //Poblacion inicial de Wetar
            int[] pos10 = { 2, 0 };
            Wetar Wetar1 = new Wetar(pos10);

            //Poblacion inicial de Gofue
            int[] pos13 = { 3, 3 };
            Gofue Gofue1 = new Gofue(pos13);

            //Poblacion inicial Dorvalo
            int[] pos16 = { 0, 2 };
            Dorvalo Dorvalo1 = new Dorvalo(pos16);

            //Poblacion inicial Doti
            int[] pos19 = { 1, 2 };
            Doti Doti1 = new Doti(pos19);

            bitmons1.Add(taplan1);
            bitmons1.Add(Ent1);
            bitmons1.Add(Wetar1);
            bitmons1.Add(Gofue1);
            bitmons1.Add(Dorvalo1);
            bitmons1.Add(Doti1);

            mapa1.Alto = 6;
            mapa1.Ancho = 6;

            mapa1.Terrenos = opcion1;
            mapa1.Bitmons = bitmons1;
            bitmonsInicial = bitmons1;
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Dock = DockStyle.Fill;
                    label.Location = new Point(3, 0);
                    label.Name = "label";
                    label.Size = new Size(51, 32);
                    label.TabIndex = 0;
                    label.Font = new Font("Trebuchet MS", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    string str = "";
                    var bitmons = mapa1.Bitmons.Where(x => (x.Posicion[0] == i) && (x.Posicion[1] == j)).ToList();
                    foreach (var bitmon in bitmons)
                    {
                        if (bitmon.Tipo == "Dorvalo")
                        {
                            str += "🦅";
                        }
                        else if (bitmon.Tipo == "Doti")
                        {
                            str += "🐇";
                        }
                        else if (bitmon.Tipo == "Ent")
                        {
                            str += "🌵";
                        }
                        else if (bitmon.Tipo == "Gofue")
                        {
                            str += "🐉";
                        }
                        else if (bitmon.Tipo == "Taplan")
                        {
                            str += "🦎";
                        }
                        else if (bitmon.Tipo == "Wetar")
                        {
                            str += "🐟";
                        }
                    }
                    label.Text = str;
                    if (opcion1[i, j].tipo == "Vegetacn")
                    {
                        label.BackColor = Color.Green;
                    }
                    else if (opcion1[i, j].tipo == "Acuatico")
                    {
                        label.BackColor = Color.Blue;
                    }
                    else if (opcion1[i, j].tipo == "Desierto")
                    {
                        label.BackColor = Color.SandyBrown;
                    }
                    else if (opcion1[i, j].tipo == "NieveIce")
                    {
                        label.BackColor = Color.Snow;
                    }
                    else
                    {
                        label.BackColor = Color.DarkRed;
                    }
                    MapPanel.Controls.Add(label, j, i);
                    labels[i, j] = label;
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void Map2Button_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            MonthNumberBox.Visible = true;
            InfoMonthLabel.Visible = true;
            MonthNumberLabel.Visible = true;
            NextMonthButton.Visible = true;
            MapSizeLabel.Visible = false;
            Map1Button.Visible = false;
            Map2Button.Visible = false;
            Map3Button.Visible = false;
            MapPanel.Visible = true;
            RestartButton.Enabled = true;
            bunifuFlatButton1.Enabled = true;
            MapButton.Enabled = true;
            MapButton.Textcolor = Color.LightGray;
            RestartButton.Textcolor = Color.LightGray;
            bunifuFlatButton1.Textcolor = Color.LightGray;
            //button3.Visible = false;
            alto = 7;
            ancho = 7;
            opcion1 = new Terreno[alto, ancho];
            labels = new Label[alto, ancho];

            opcion1[0, 0] = Nieve;
            opcion1[0, 1] = Acuático;
            opcion1[0, 2] = Desierto;
            opcion1[0, 3] = Desierto;
            opcion1[0, 4] = Desierto;
            opcion1[0, 5] = Acuático;
            opcion1[0, 6] = Nieve;
            opcion1[1, 0] = Acuático;
            opcion1[1, 1] = Acuático;
            opcion1[1, 2] = Vegetación;
            opcion1[1, 3] = Vegetación;
            opcion1[1, 4] = Vegetación;
            opcion1[1, 5] = Acuático;
            opcion1[1, 6] = Acuático;
            opcion1[2, 0] = Desierto;
            opcion1[2, 1] = Vegetación;
            opcion1[2, 2] = Vegetación;
            opcion1[2, 3] = Volcán;
            opcion1[2, 4] = Vegetación;
            opcion1[2, 5] = Vegetación;
            opcion1[2, 6] = Desierto;
            opcion1[3, 0] = Desierto;
            opcion1[3, 1] = Vegetación;
            opcion1[3, 2] = Volcán;
            opcion1[3, 3] = Volcán;
            opcion1[3, 4] = Volcán;
            opcion1[3, 5] = Vegetación;
            opcion1[3, 6] = Desierto;
            opcion1[4, 0] = Desierto;
            opcion1[4, 1] = Vegetación;
            opcion1[4, 2] = Vegetación;
            opcion1[4, 3] = Volcán;
            opcion1[4, 4] = Vegetación;
            opcion1[4, 5] = Vegetación;
            opcion1[4, 6] = Desierto;
            opcion1[5, 0] = Acuático;
            opcion1[5, 1] = Acuático;
            opcion1[5, 2] = Vegetación;
            opcion1[5, 3] = Vegetación;
            opcion1[5, 4] = Vegetación;
            opcion1[5, 5] = Acuático;
            opcion1[5, 6] = Acuático;
            opcion1[6, 0] = Nieve;
            opcion1[6, 1] = Acuático;
            opcion1[6, 2] = Desierto;
            opcion1[6, 3] = Desierto;
            opcion1[6, 4] = Desierto;
            opcion1[6, 5] = Acuático;
            opcion1[6, 6] = Nieve;

            int[] pos1 = { 2, 1 };
            Taplan taplan1 = new Taplan(pos1);
            int[] pos2 = { 4, 2 };
            Taplan taplan2 = new Taplan(pos2);

            //Poblacion inicial de Ents
            int[] pos6 = { 2, 4 };
            Ent Ent1 = new Ent(pos6);
            int[] pos7 = { 4, 6 };
            Ent Ent2 = new Ent(pos7);

            //Poblacion inicial de Wetar
            int[] pos10 = { 1, 0 };
            Wetar Wetar1 = new Wetar(pos10);
            int[] pos11 = { 0, 1 };
            Wetar Wetar2 = new Wetar(pos11);

            //Poblacion inicial de Gofue
            int[] pos13 = { 3, 3 };
            Gofue Gofue1 = new Gofue(pos13);
            int[] pos14 = { 3, 6 };
            Gofue Gofue2 = new Gofue(pos14);

            //Poblacion inicial Dorvalo
            int[] pos16 = { 5, 4 };
            Dorvalo Dorvalo1 = new Dorvalo(pos16);
            int[] pos17 = { 1, 3 };
            Dorvalo Dorvalo2 = new Dorvalo(pos17);

            //Poblacion inicial Doti
            int[] pos19 = { 3, 5 };
            Doti Doti1 = new Doti(pos19);
            int[] pos20 = { 5, 2 };
            Doti Doti2 = new Doti(pos20);

            bitmons1.Add(taplan1);
            bitmons1.Add(taplan2);
            bitmons1.Add(Ent1);
            bitmons1.Add(Ent2);
            bitmons1.Add(Wetar1);
            bitmons1.Add(Wetar2);
            bitmons1.Add(Gofue1);
            bitmons1.Add(Gofue2);
            bitmons1.Add(Dorvalo1);
            bitmons1.Add(Dorvalo2);
            bitmons1.Add(Doti1);
            bitmons1.Add(Doti2);

            mapa1.Alto = 7;
            mapa1.Ancho = 7;

            mapa1.Terrenos = opcion1;
            mapa1.Bitmons = bitmons1;
            bitmonsInicial = bitmons1;

            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Dock = DockStyle.Fill;
                    label.Location = new Point(3, 0);
                    label.Name = "label";
                    label.Size = new Size(51, 32);
                    label.TabIndex = 0;
                    label.Font = new Font("Trebuchet MS", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    string str = "";
                    var bitmons = mapa1.Bitmons.Where(x => (x.Posicion[0] == i) && (x.Posicion[1] == j)).ToList();
                    foreach (var bitmon in bitmons)
                    {
                        if (bitmon.Tipo == "Dorvalo")
                        {
                            str += "🦅";
                        }
                        else if (bitmon.Tipo == "Doti")
                        {
                            str += "🐇";
                        }
                        else if (bitmon.Tipo == "Ent")
                        {
                            str += "🌵";
                        }
                        else if (bitmon.Tipo == "Gofue")
                        {
                            str += "🐉";
                        }
                        else if (bitmon.Tipo == "Taplan")
                        {
                            str += "🦎";
                        }
                        else if (bitmon.Tipo == "Wetar")
                        {
                            str += "🐟";
                        }
                    }
                    label.Text = str;
                    if (opcion1[i, j].tipo == "Vegetacn")
                    {
                        label.BackColor = Color.Green;
                    }
                    else if (opcion1[i, j].tipo == "Acuatico")
                    {
                        label.BackColor = Color.Blue;
                    }
                    else if (opcion1[i, j].tipo == "Desierto")
                    {
                        label.BackColor = Color.SandyBrown;
                    }
                    else if (opcion1[i, j].tipo == "NieveIce")
                    {
                        label.BackColor = Color.Snow;
                    }
                    else
                    {
                        label.BackColor = Color.DarkRed;
                    }
                    MapPanel.Controls.Add(label, j, i);
                    labels[i, j] = label;
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void Map3Button_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            InfoMonthLabel.Visible = true;
            MonthNumberBox.Visible = true;
            MonthNumberLabel.Visible = true;
            NextMonthButton.Visible = true;
            MapSizeLabel.Visible = false;
            Map1Button.Visible = false;
            Map2Button.Visible = false;
            Map3Button.Visible = false;
            MapPanel.Visible = true;
            RestartButton.Enabled = true;
            bunifuFlatButton1.Enabled = true;
            MapButton.Enabled = true;
            MapButton.Textcolor = Color.LightGray;
            RestartButton.Textcolor = Color.LightGray;
            bunifuFlatButton1.Textcolor = Color.LightGray;

            alto = 10;
            ancho = 10;
            labels = new Label[alto, ancho];
            opcion1 = new Terreno[alto, ancho];
            opcion1[0, 0] = Desierto;
            opcion1[1, 0] = Desierto;
            opcion1[1, 1] = Desierto;
            opcion1[1, 2] = Desierto;
            opcion1[1, 3] = Desierto;
            opcion1[1, 4] = Desierto;
            opcion1[1, 5] = Desierto;
            opcion1[1, 6] = Desierto;
            opcion1[2, 3] = Desierto;
            opcion1[2, 4] = Desierto;
            opcion1[2, 5] = Desierto;
            opcion1[2, 6] = Desierto;
            opcion1[2, 7] = Desierto;
            opcion1[3, 6] = Desierto;
            opcion1[3, 7] = Desierto;
            opcion1[3, 8] = Desierto;
            opcion1[3, 9] = Desierto;
            opcion1[4, 5] = Desierto;
            opcion1[4, 6] = Desierto;
            opcion1[4, 7] = Desierto;
            opcion1[4, 8] = Desierto;
            opcion1[4, 9] = Desierto;
            opcion1[5, 6] = Desierto;
            opcion1[5, 8] = Desierto;
            opcion1[0, 1] = Acuático;
            opcion1[0, 1] = Acuático;
            opcion1[0, 2] = Acuático;
            opcion1[0, 3] = Acuático;
            opcion1[0, 4] = Acuático;
            opcion1[0, 5] = Acuático;
            opcion1[5, 7] = Acuático;
            opcion1[5, 9] = Acuático;
            opcion1[6, 5] = Acuático;
            opcion1[6, 6] = Acuático;
            opcion1[6, 7] = Acuático;
            opcion1[6, 8] = Acuático;
            opcion1[6, 9] = Acuático;
            opcion1[7, 1] = Acuático;
            opcion1[7, 4] = Acuático;
            opcion1[7, 5] = Acuático;
            opcion1[7, 9] = Acuático;
            opcion1[8, 0] = Acuático;
            opcion1[8, 1] = Acuático;
            opcion1[8, 2] = Acuático;
            opcion1[8, 3] = Acuático;
            opcion1[8, 4] = Acuático;
            opcion1[9, 0] = Acuático;
            opcion1[9, 1] = Acuático;
            opcion1[9, 2] = Acuático;
            opcion1[9, 3] = Acuático;
            opcion1[0, 6] = Nieve;
            opcion1[0, 7] = Nieve;
            opcion1[0, 8] = Nieve;
            opcion1[0, 9] = Nieve;
            opcion1[1, 7] = Nieve;
            opcion1[1, 8] = Nieve;
            opcion1[1, 9] = Nieve;
            opcion1[2, 8] = Nieve;
            opcion1[2, 9] = Nieve;
            opcion1[2, 0] = Vegetación;
            opcion1[2, 1] = Vegetación;
            opcion1[2, 2] = Vegetación;
            opcion1[3, 0] = Vegetación;
            opcion1[3, 1] = Vegetación;
            opcion1[3, 2] = Vegetación;
            opcion1[3, 3] = Vegetación;
            opcion1[3, 4] = Vegetación;
            opcion1[3, 5] = Vegetación;
            opcion1[4, 0] = Vegetación;
            opcion1[4, 1] = Vegetación;
            opcion1[4, 2] = Vegetación;
            opcion1[4, 3] = Vegetación;
            opcion1[4, 4] = Vegetación;
            opcion1[5, 0] = Vegetación;
            opcion1[5, 1] = Vegetación;
            opcion1[5, 2] = Vegetación;
            opcion1[5, 3] = Vegetación;
            opcion1[5, 4] = Vegetación;
            opcion1[5, 5] = Vegetación;
            opcion1[6, 0] = Vegetación;
            opcion1[6, 1] = Vegetación;
            opcion1[6, 2] = Vegetación;
            opcion1[6, 3] = Vegetación;
            opcion1[6, 4] = Vegetación;
            opcion1[7, 0] = Vegetación;
            opcion1[7, 2] = Vegetación;
            opcion1[7, 3] = Vegetación;
            opcion1[7, 6] = Volcán;
            opcion1[7, 7] = Volcán;
            opcion1[7, 8] = Volcán;
            opcion1[8, 5] = Volcán;
            opcion1[8, 6] = Volcán;
            opcion1[8, 7] = Volcán;
            opcion1[8, 8] = Volcán;
            opcion1[8, 9] = Volcán;
            opcion1[9, 4] = Volcán;
            opcion1[9, 5] = Volcán;
            opcion1[9, 6] = Volcán;
            opcion1[9, 7] = Volcán;
            opcion1[9, 8] = Volcán;
            opcion1[9, 9] = Volcán;

            //Creamos la poblacion inicial de Bitmon

            //Poblacion inicial de Taplan
            int[] pos1 = { 2, 2 };
            Taplan taplan1 = new Taplan(pos1);
            int[] pos2 = { 4, 1 };
            Taplan taplan2 = new Taplan(pos2);
            int[] pos3 = { 4, 2 };
            Taplan taplan3 = new Taplan(pos3);
            int[] pos4 = { 5, 3 };
            Taplan taplan4 = new Taplan(pos4);
            int[] pos5 = { 6, 0 };
            Taplan taplan5 = new Taplan(pos5);

            //Poblacion inicial de Ents
            int[] pos6 = { 2, 4 };
            Ent Ent1 = new Ent(pos6);
            int[] pos7 = { 0, 9 };
            Ent Ent2 = new Ent(pos7);
            int[] pos8 = { 3, 9 };
            Ent Ent3 = new Ent(pos8);
            int[] pos9 = { 4, 4 };
            Ent Ent4 = new Ent(pos9);

            //Poblacion inicial de Wetar
            int[] pos10 = { 0, 5 };
            Wetar Wetar1 = new Wetar(pos10);
            int[] pos11 = { 0, 1 };
            Wetar Wetar2 = new Wetar(pos11);
            int[] pos12 = { 9, 0 };
            Wetar Wetar3 = new Wetar(pos12);

            //Poblacion inicial de Gofue
            int[] pos13 = { 1, 7 };
            Gofue Gofue1 = new Gofue(pos13);
            int[] pos14 = { 7, 7 };
            Gofue Gofue2 = new Gofue(pos14);
            int[] pos15 = { 9, 5 };
            Gofue Gofue3 = new Gofue(pos15);

            //Poblacion inicial Dorvalo
            int[] pos16 = { 1, 7 };
            Dorvalo Dorvalo1 = new Dorvalo(pos16);
            int[] pos17 = { 3, 7 };
            Dorvalo Dorvalo2 = new Dorvalo(pos17);
            int[] pos18 = { 2, 7 };
            Dorvalo Dorvalo3 = new Dorvalo(pos18);

            //Poblacion inicial Doti
            int[] pos19 = { 1, 5 };
            Doti Doti1 = new Doti(pos19);
            int[] pos20 = { 9, 7 };
            Doti Doti2 = new Doti(pos20);
            int[] pos21 = { 0, 0 };
            Doti Doti3 = new Doti(pos21);
            int[] pos22 = { 4, 7 };
            Doti Doti4 = new Doti(pos22);

            bitmons1.Add(taplan1);
            bitmons1.Add(taplan2);
            bitmons1.Add(taplan3);
            bitmons1.Add(taplan4);
            bitmons1.Add(taplan5);
            bitmons1.Add(Ent1);
            bitmons1.Add(Ent2);
            bitmons1.Add(Ent3);
            bitmons1.Add(Ent4);
            bitmons1.Add(Wetar1);
            bitmons1.Add(Wetar2);
            bitmons1.Add(Wetar3);
            bitmons1.Add(Gofue1);
            bitmons1.Add(Gofue2);
            bitmons1.Add(Gofue3);
            bitmons1.Add(Dorvalo1);
            bitmons1.Add(Dorvalo2);
            bitmons1.Add(Dorvalo3);
            bitmons1.Add(Doti1);
            bitmons1.Add(Doti2);
            bitmons1.Add(Doti3);
            bitmons1.Add(Doti4);

            mapa1.Alto = alto;
            mapa1.Ancho = ancho;

            mapa1.Terrenos = opcion1;
            mapa1.Bitmons = bitmons1;
            bitmonsInicial = bitmons1;

            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Dock = DockStyle.Fill;
                    label.Location = new Point(3, 0);
                    label.Name = "label";
                    label.Size = new Size(51, 32);
                    label.TabIndex = 0;
                    label.Font = new Font("Trebuchet MS", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    string str = "";
                    var bitmons = mapa1.Bitmons.Where(x => (x.Posicion[0] == i) && (x.Posicion[1] == j)).ToList();
                    foreach (var bitmon in bitmons)
                    {
                        if (bitmon.Tipo == "Dorvalo")
                        {
                            str += "🦅";
                        }
                        else if (bitmon.Tipo == "Doti")
                        {
                            str += "🐇";
                        }
                        else if (bitmon.Tipo == "Ent")
                        {
                            str += "🌵";
                        }
                        else if (bitmon.Tipo == "Gofue")
                        {
                            str += "🐉";
                        }
                        else if (bitmon.Tipo == "Taplan")
                        {
                            str += "🦎";
                        }
                        else if (bitmon.Tipo == "Wetar")
                        {
                            str += "🐟";
                        }
                    }
                    label.Text = str;
                    if (opcion1[i, j].tipo == "Vegetacn")
                    {
                        label.BackColor = Color.Green;
                    }
                    else if (opcion1[i, j].tipo == "Acuatico")
                    {
                        label.BackColor = Color.Blue;
                    }
                    else if (opcion1[i, j].tipo == "Desierto")
                    {
                        label.BackColor = Color.SandyBrown;
                    }
                    else if (opcion1[i, j].tipo == "NieveIce")
                    {
                        label.BackColor = Color.Snow;
                    }
                    else
                    {
                        label.BackColor = Color.DarkRed;
                    }
                    MapPanel.Controls.Add(label, j, i);
                    labels[i, j] = label;
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string infoMes = "";
            mapa1.bitmons_creado_mes.Clear();
            
            if (NextMonthButton.Text == "Empezar  simulacion")
            {
                try
                {
                    cantidad_mese = Convert.ToInt32(MonthNumberBox.Text);
                    MonthNumberBox.Visible = false;
                    NextMonthButton.Text = "Siguiente mes";
                    TitleMonthInfoLabel.Visible = true;
                    BitmonsMapButton.Enabled = true;
                    BitmonsMapButton.Textcolor = Color.LightGray;
                }
                catch (Exception)
                {
                    MessageBox.Show("Este numero no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MonthNumberBox.Text = "";
                }
                
            }
            if (NextMonthButton.Text == "Empezar de nuevo")
            {
                mes = 1;
                ResultadosButton.Enabled = false;
                ResultadosButton.Textcolor = Color.Gray;
                SaveButton.Enabled = false;
                SaveButton.Textcolor = Color.Gray;
                InfoMonthLabel.Text = "";
                NextMonthButton.Text = "Siguiente mes";
                mapa1.Terrenos = opcion1;
                bitmons1.Clear();
                if (mapa1.Ancho == 6)
                {
                    int[] pos1 = { 3, 1 };
                    Taplan taplan1 = new Taplan(pos1);

                    //Poblacion inicial de Ents
                    int[] pos6 = { 2, 3 };
                    Ent Ent1 = new Ent(pos6);

                    //Poblacion inicial de Wetar
                    int[] pos10 = { 2, 0 };
                    Wetar Wetar1 = new Wetar(pos10);

                    //Poblacion inicial de Gofue
                    int[] pos13 = { 3, 3 };
                    Gofue Gofue1 = new Gofue(pos13);

                    //Poblacion inicial Dorvalo
                    int[] pos16 = { 0, 2 };
                    Dorvalo Dorvalo1 = new Dorvalo(pos16);

                    //Poblacion inicial Doti
                    int[] pos19 = { 1, 2 };
                    Doti Doti1 = new Doti(pos19);
                    bitmons1.Add(taplan1);
                    bitmons1.Add(Ent1);
                    bitmons1.Add(Wetar1);
                    bitmons1.Add(Gofue1);
                    bitmons1.Add(Dorvalo1);
                    bitmons1.Add(Doti1);
                }
                if (mapa1.Ancho == 7)
                {
                    int[] pos1 = { 2, 1 };
                    Taplan taplan1 = new Taplan(pos1);
                    int[] pos2 = { 4, 2 };
                    Taplan taplan2 = new Taplan(pos2);

                    //Poblacion inicial de Ents
                    int[] pos6 = { 2, 4 };
                    Ent Ent1 = new Ent(pos6);
                    int[] pos7 = { 4, 6 };
                    Ent Ent2 = new Ent(pos7);

                    //Poblacion inicial de Wetar
                    int[] pos10 = { 1, 0 };
                    Wetar Wetar1 = new Wetar(pos10);
                    int[] pos11 = { 0, 1 };
                    Wetar Wetar2 = new Wetar(pos11);

                    //Poblacion inicial de Gofue
                    int[] pos13 = { 3, 3 };
                    Gofue Gofue1 = new Gofue(pos13);
                    int[] pos14 = { 3, 6 };
                    Gofue Gofue2 = new Gofue(pos14);

                    //Poblacion inicial Dorvalo
                    int[] pos16 = { 5, 4 };
                    Dorvalo Dorvalo1 = new Dorvalo(pos16);
                    int[] pos17 = { 1, 3 };
                    Dorvalo Dorvalo2 = new Dorvalo(pos17);

                    //Poblacion inicial Doti
                    int[] pos19 = { 3, 5 };
                    Doti Doti1 = new Doti(pos19);
                    int[] pos20 = { 5, 2 };
                    Doti Doti2 = new Doti(pos20);

                    bitmons1.Add(taplan1);
                    bitmons1.Add(taplan2);
                    bitmons1.Add(Ent1);
                    bitmons1.Add(Ent2);
                    bitmons1.Add(Wetar1);
                    bitmons1.Add(Wetar2);
                    bitmons1.Add(Gofue1);
                    bitmons1.Add(Gofue2);
                    bitmons1.Add(Dorvalo1);
                    bitmons1.Add(Dorvalo2);
                    bitmons1.Add(Doti1);
                    bitmons1.Add(Doti2);
                }
                if (mapa1.Ancho == 10)
                {
                    int[] pos1 = { 2, 2 };
                    Taplan taplan1 = new Taplan(pos1);
                    int[] pos2 = { 4, 1 };
                    Taplan taplan2 = new Taplan(pos2);
                    int[] pos3 = { 4, 2 };
                    Taplan taplan3 = new Taplan(pos3);
                    int[] pos4 = { 5, 3 };
                    Taplan taplan4 = new Taplan(pos4);
                    int[] pos5 = { 6, 0 };
                    Taplan taplan5 = new Taplan(pos5);

                    //Poblacion inicial de Ents
                    int[] pos6 = { 2, 4 };
                    Ent Ent1 = new Ent(pos6);
                    int[] pos7 = { 0, 9 };
                    Ent Ent2 = new Ent(pos7);
                    int[] pos8 = { 3, 9 };
                    Ent Ent3 = new Ent(pos8);
                    int[] pos9 = { 4, 4 };
                    Ent Ent4 = new Ent(pos9);

                    //Poblacion inicial de Wetar
                    int[] pos10 = { 0, 5 };
                    Wetar Wetar1 = new Wetar(pos10);
                    int[] pos11 = { 0, 1 };
                    Wetar Wetar2 = new Wetar(pos11);
                    int[] pos12 = { 9, 0 };
                    Wetar Wetar3 = new Wetar(pos12);

                    //Poblacion inicial de Gofue
                    int[] pos13 = { 1, 7 };
                    Gofue Gofue1 = new Gofue(pos13);
                    int[] pos14 = { 7, 7 };
                    Gofue Gofue2 = new Gofue(pos14);
                    int[] pos15 = { 9, 5 };
                    Gofue Gofue3 = new Gofue(pos15);

                    //Poblacion inicial Dorvalo
                    int[] pos16 = { 1, 7 };
                    Dorvalo Dorvalo1 = new Dorvalo(pos16);
                    int[] pos17 = { 3, 7 };
                    Dorvalo Dorvalo2 = new Dorvalo(pos17);
                    int[] pos18 = { 2, 7 };
                    Dorvalo Dorvalo3 = new Dorvalo(pos18);

                    //Poblacion inicial Doti
                    int[] pos19 = { 1, 5 };
                    Doti Doti1 = new Doti(pos19);
                    int[] pos20 = { 9, 7 };
                    Doti Doti2 = new Doti(pos20);
                    int[] pos21 = { 0, 0 };
                    Doti Doti3 = new Doti(pos21);
                    int[] pos22 = { 4, 7 };
                    Doti Doti4 = new Doti(pos22);

                    bitmons1.Add(taplan1);
                    bitmons1.Add(taplan2);
                    bitmons1.Add(taplan3);
                    bitmons1.Add(taplan4);
                    bitmons1.Add(taplan5);
                    bitmons1.Add(Ent1);
                    bitmons1.Add(Ent2);
                    bitmons1.Add(Ent3);
                    bitmons1.Add(Ent4);
                    bitmons1.Add(Wetar1);
                    bitmons1.Add(Wetar2);
                    bitmons1.Add(Wetar3);
                    bitmons1.Add(Gofue1);
                    bitmons1.Add(Gofue2);
                    bitmons1.Add(Gofue3);
                    bitmons1.Add(Dorvalo1);
                    bitmons1.Add(Dorvalo2);
                    bitmons1.Add(Dorvalo3);
                    bitmons1.Add(Doti1);
                    bitmons1.Add(Doti2);
                    bitmons1.Add(Doti3);
                    bitmons1.Add(Doti4);
                }
                mapa1.Bitmons = bitmons1;
                mapa1.sobrepoblacion = false;
                mapa1.Bitmons_creados.Clear();
                mapa1.bitmons_creado_mes.Clear();
                mapa1.Bitmons_muertos.Clear();
                mapa1.bitmons_muertos_mes.Clear();
                mapa1.Actualizar_espacios();

                for (int i = 0; i < alto; i++)
                {
                    for (int j = 0; j < ancho; j++)
                    {
                        string str = "";
                        var bitmons = mapa1.Bitmons.Where(x => (x.Posicion[0] == i) && (x.Posicion[1] == j)).ToList();
                        foreach (var bitmon in bitmons)
                        {
                            if (bitmon.Tipo == "Dorvalo")
                            {
                                str += "🦅";
                            }
                            else if (bitmon.Tipo == "Doti")
                            {
                                str += "🐇";
                            }
                            else if (bitmon.Tipo == "Ent")
                            {
                                str += "🌵";
                            }
                            else if (bitmon.Tipo == "Gofue")
                            {
                                str += "🐉";
                            }
                            else if (bitmon.Tipo == "Taplan")
                            {
                                str += "🦎";
                            }
                            else if (bitmon.Tipo == "Wetar")
                            {
                                str += "🐟";
                            }
                        }
                        labels[i, j].Text = str;
                        if (opcion1[i, j].tipo == "Vegetacn")
                        {
                            labels[i, j].BackColor = Color.Green;
                        }
                        else if (opcion1[i, j].tipo == "Acuatico")
                        {
                            labels[i, j].BackColor = Color.Blue;
                        }
                        else if (opcion1[i, j].tipo == "Desierto")
                        {
                            labels[i, j].BackColor = Color.SandyBrown;
                        }
                        else if (opcion1[i, j].tipo == "NieveIce")
                        {
                            labels[i, j].BackColor = Color.Snow;
                        }
                        else
                        {
                            labels[i, j].BackColor = Color.DarkRed;
                        }
                    }
                }
            }
            List<string> tipo_bitmons = new List<string>();
            if (NextMonthButton.Text == "Siguiente mes")
            {
                mes++;
                string info = "    Bitmons en el mapa:\n";
                int[] posENT = { 0, 0 };
                Ent papa = new Ent(posENT);
                Ent mama = new Ent(posENT);

                if (mes % 3 == 0 && mes != 0)
                {
                    mapa1.CrearBitmon(papa, mama);
                }
                foreach (var bitmon in mapa1.Bitmons)
                {
                    bitmon.Mover(mapa1);
                }
                mapa1.Relaciones();
                for (int i = 0; i < mapa1.Bitmons.Count; i++)
                {
                    mapa1.Bitmons[i].Envejecer();
                    if (mapa1.Bitmons[i].Tipo == "Taplan" && (mapa1.Terrenos[mapa1.Bitmons[i].Posicion[0], mapa1.Bitmons[i].Posicion[1]].tipo != "Vegetacn"))
                    {
                        mapa1.Bitmons[i].Envejecer();
                    }
                    else if (mapa1.Bitmons[i].Tipo == "Gofue" && (mapa1.Terrenos[mapa1.Bitmons[i].Posicion[0], mapa1.Bitmons[i].Posicion[1]].tipo != "Volcanic"))
                    {
                        mapa1.Bitmons[i].Envejecer();
                    }
                    else if (mapa1.Bitmons[i].Tipo == "Ent" && (mapa1.Terrenos[mapa1.Bitmons[i].Posicion[0], mapa1.Bitmons[i].Posicion[1]].tipo != "Vegetacn"))
                    {
                        mapa1.Bitmons[i].Envejecer();
                    }
                    else if (mapa1.Bitmons[i].Tipo == "Doti" && (mapa1.Terrenos[mapa1.Bitmons[i].Posicion[0], mapa1.Bitmons[i].Posicion[1]].tipo == "Volcanic"))
                    {
                        mapa1.Bitmons[i].Envejecer();
                    }
                    if (!mapa1.Bitmons[i].vivo)
                    {
                        mapa1.Bitmons.Remove(mapa1.Bitmons[i]);
                        mapa1.Bitmons_muertos.Add(mapa1.Bitmons[i]);
                        mapa1.bitmons_muertos_mes.Add(mapa1.Bitmons[i]);
                    }
                }
                for (int i = 0; i < alto; i++)
                {
                    for (int j = 0; j < ancho; j++)
                    {
                        string str = "";
                        var bitmons = mapa1.Bitmons.Where(x => (x.Posicion[0] == i) && (x.Posicion[1] == j)).ToList();
                        foreach (var bitmon in bitmons)
                        {
                            if (bitmon.Tipo == "Dorvalo")
                            {
                                str += "🦅";
                            }
                            else if (bitmon.Tipo == "Doti")
                            {
                                str += "🐇";
                            }
                            else if (bitmon.Tipo == "Ent")
                            {
                                str += "🌵";
                            }
                            else if (bitmon.Tipo == "Gofue")
                            {
                                str += "🐉";
                            }
                            else if (bitmon.Tipo == "Taplan")
                            {
                                str += "🦎";
                            }
                            else if (bitmon.Tipo == "Wetar")
                            {
                                str += "🐟";
                            }
                        }
                        labels[i, j].Text = str;
                        if (opcion1[i, j].tipo == "Vegetacn")
                        {
                            labels[i, j].BackColor = Color.Green;
                        }
                        else if (opcion1[i, j].tipo == "Acuatico")
                        {
                            labels[i, j].BackColor = Color.Blue;
                        }
                        else if (opcion1[i, j].tipo == "Desierto")
                        {
                            labels[i, j].BackColor = Color.SandyBrown;
                        }
                        else if (opcion1[i, j].tipo == "NieveIce")
                        {
                            labels[i, j].BackColor = Color.Snow;
                        }
                        else
                        {
                            labels[i, j].BackColor = Color.DarkRed;
                        }
                    }
                }
                for (int k = 0; k < mapa1.Bitmons.Count; k++)
                {
                    info += $"\n{mapa1.Bitmons[k].Tipo}, [{mapa1.Bitmons[k].Posicion[0]},{mapa1.Bitmons[k].Posicion[1]}], puntos de Vida: {mapa1.Bitmons[k].PuntosdeVida}";
                }

                foreach (var bitmon in mapa1.bitmons_creado_mes)
                {
                    infoMes += $"\nse creo un {bitmon.Tipo} en la posicion [{bitmon.Posicion[0]},{bitmon.Posicion[1]}]";

                }

                foreach (var bitmon in mapa1.bitmons_muertos_mes)
                {
                    infoMes += $"\nse murio un {bitmon.Tipo} en la posicion [{bitmon.Posicion[0]},{bitmon.Posicion[1]}]";
                }
                if (mapa1.sobrepoblacion)
                {
                    infoMes += $"\n\nsobrepoblacion en el mes {mes}, se detuvo la simulación\n";
                }
                numero_muertos += mapa1.bitmons_muertos_mes.Count * 1000 / mapa1.Bitmons.Count;
                tipo_bitmons.Add("Taplan");
                tipo_bitmons.Add("Doti");
                tipo_bitmons.Add("Wetar");
                tipo_bitmons.Add("Dorvalo");
                tipo_bitmons.Add("Gofue");
                tipo_bitmons.Add("Ent");
                int count = 0;
                foreach (var tipo in tipo_bitmons)
                {
                    var bitmons = mapa1.Bitmons.Where(x => x.Tipo == tipo).ToList();
                    var bitmons_nuevo = mapa1.bitmons_creado_mes.Where(x => x.Tipo == tipo).ToList();
                    try
                    {
                        numero_creados[count] += (float)bitmons_nuevo.Count * 1000 / bitmons.Count;
                    }
                    catch (Exception)
                    {
                        numero_creados[count] += 0;
                    }
                    count++;
                }

                info += "\n\n\n";
                BitmonsMapLabel.Text = info;
                infoMes += "\n\n\n";
                InfoMonthLabel.Text = infoMes;
                MonthNumberLabel.Text = "Mes: " + Convert.ToString(mes);
            }
            if (mes == cantidad_mese | mapa1.sobrepoblacion)
            {
                ResultadosButton.Enabled = true;
                ResultadosButton.Textcolor = Color.LightGray;
                SaveButton.Enabled = true;
                SaveButton.Textcolor = Color.LightGray;
                info_end = "";
                NextMonthButton.Text = "Empezar de nuevo";

                float promedio_vida = 0;
                foreach (var bitmon in mapa1.Bitmons_muertos)
                {
                    promedio_vida += bitmon.TiempoVivido;
                }
                foreach (var bitmon in mapa1.Bitmons)
                {
                    promedio_vida += bitmon.TiempoVivido;
                }
                promedio_vida = promedio_vida * 10 / (mapa1.Bitmons_muertos.Count + mapa1.Bitmons.Count);
                info_end += $"El promedio de vida de los bitmons fue de {(float)((int)promedio_vida) / 10} meses.\n";

                foreach (var tipo in tipo_bitmons)
                {
                    promedio_vida = 0;
                    var bitmons = mapa1.Bitmons.Where(x => x.Tipo == tipo).ToList();
                    var bitmons_m = mapa1.Bitmons_muertos.Where(x => x.Tipo == tipo).ToList();
                    foreach (var bit in bitmons)
                    {
                        promedio_vida += bit.TiempoVivido;
                    }
                    foreach (var bit in bitmons_m)
                    {
                        promedio_vida += bit.TiempoVivido;
                    }
                    promedio_vida = promedio_vida * 10 / (bitmons.Count + bitmons_m.Count);
                    info_end += $"\nEl promedio de vida de los {tipo} fue de {(float)((int)promedio_vida) / 10} meses";
                }
                info_end += '\n';
                numero_muertos = numero_muertos / mes;
                for (int i = 0; i < 6; i++)
                {
                    numero_creados[i] = numero_creados[i] / mes;
                }
                int k = 0;
                foreach (var tipo1 in tipo_bitmons)
                {
                    info_end += $"\nLa tasa bruta de natalidad de los {tipo1} fue de {Math.Round(numero_creados[k], 1)} º /ºº";
                    k++;
                }
                info_end += $"\nLa tasa bruta de mortalidad de los Bitmons fue de {numero_muertos} º/ºº";
                info_end += "\n";
                foreach (var tipo in tipo_bitmons)
                {
                    var bitmons = mapa1.Bitmons_creados.Where(x => x.Tipo == tipo).ToList();
                    info_end += $"\nLa cantidad de hijos en promedio de los {tipo} fue de {Math.Round((float)bitmons.Count / mes, 1)} hijos por mes";
                }
                info_end += "\n";
                foreach (var tipo in tipo_bitmons)
                {
                    var bitmons = mapa1.Bitmons.Where(x => x.Tipo == tipo).ToList();
                    if (bitmons.Count == 0)
                    {
                        info_end += $"\nLa especie {tipo} se extinguio";
                    }
                }
                info_end += "\n";
                foreach (var tipo in tipo_bitmons)
                {
                    if (mapa1.Bitmons_muertos.Count != 0)
                    {
                        var bitmons = mapa1.Bitmons_muertos.Where(x => x.Tipo == tipo).ToList();
                        info_end += $"\nHay {bitmons.Count} {tipo} en el Bithalla. Corresponden al {Math.Round((float)(bitmons.Count * 100) / mapa1.Bitmons_muertos.Count, 1)} % ";
                    }
                    else
                    {
                        info_end += $"\nNo hay ningun bitmon muerto.";
                        break;
                    }
                }
               
                ResultadosLabel.Text = info_end;
                ResultadosLabel.Text += "\n\n\n";
            }
            this.Cursor = Cursors.Default;
        }

        private void BitmonsMapButton_Click(object sender, EventArgs e)
        {
            InfoMonthPanel.Visible = false;
            MapPanel.Visible = false;
            MonthNumberLabel.Visible = false;
            NextMonthButton.Visible = false;
            ResultadosLabel.Visible = false;
            BitmonsMapLabel.Visible = true;
            CenterPanel2.Height = 691;
        }

        private void MapButton_Click(object sender, EventArgs e)
        {
            InfoMonthPanel.Visible = true;
            MapPanel.Visible = true;
            MonthNumberLabel.Visible = true;
            NextMonthButton.Visible = true;
            ResultadosLabel.Visible = false;
            BitmonsMapLabel.Visible = false;
            CenterPanel2.Height = 537;
        }

        private void ResultadosButton_Click(object sender, EventArgs e)
        {
            InfoMonthPanel.Visible = false;
            MapPanel.Visible = false;
            MonthNumberLabel.Visible = false;
            NextMonthButton.Visible = false;
            BitmonsMapLabel.Visible = false;
            ResultadosLabel.Visible = true;
            CenterPanel2.Height = 691;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.FileName = ".txt";
            sfd.DefaultExt = ".txt";
            sfd.Filter = "txt files (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(fileStream);

                sw.Write(info_end);

                sw.Close();
                fileStream.Close();

            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
