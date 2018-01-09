using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoEMG
{
    public partial class Exame : Form
    {
        List<Double> dados = new List<Double>();

        Graphics g;
        Pen pen;

        private Cliente cliente;

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }


        public Exame(Cliente cliente)
        {
            //serve para aparecer o nome do cliente em cima 
            this.cliente = cliente;
            InitializeComponent();
            this.Text = cliente.Name;
            //DeviceSingletone.Instance.NewData += Instance_NewData;

            g = panelExame.CreateGraphics();
            pen = new Pen(Color.Black);

            //Aparecer as horas e o dia no programa
            labelDataExame.Text = DateTime.Now.ToLongDateString();

            //Pôr a parte de trás das labels transparente
            labelDataExame.BackColor = Color.Transparent;
            labelHoraExame.BackColor = Color.Transparent;
            botaoRetroceder.BackColor = Color.Transparent;
            labelNomeExame.BackColor = Color.Transparent;

            //conta o tempo
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;

        }
        //contador de tempo
        void Timer_Tick(object sender, EventArgs e)
        {
            labelHoraExame.Text = DateTime.Now.ToLongTimeString();
        }

        private void comecar_Click(object sender, EventArgs e)
        {
            DeviceSingletone dev = DeviceSingletone.Instance;
            dev.NewData += Dev_NewData;

        }

        private void Dev_NewData(Double data)
        {
            //g.DrawLines(Pen,dados.ToArray());
        }


        //botao que serve para procurar o dispositivos
        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            ServiçosDeProcurar sd = new ServiçosDeProcurar();
            sd.Show();
        }

        //botao que serve para parar de receber dados do bitalino 
        private void buttonParar_Click(object sender, EventArgs e)
        {
            DeviceSingletone.Instance.disconnect();
        }

        //botao que serve para voltar atrás e esconde a página onde estavamos 
        private void botaoRetroceder_Click(object sender, EventArgs e)
        {
            ListaExames listaexames = new ListaExames(cliente);

            this.Hide();
            listaexames.ShowDialog();

        }


        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            g = panelExame.CreateGraphics();
        }

        private void panelExame_Paint(object sender, PaintEventArgs e)
        {

            int x = 0;
            PointF[] points = new PointF[dados.Count];

            foreach (Double d in dados) //percorrer cada elemento da lista dados
            {
                PointF p = new PointF(x, (float)d);
                points[x] = p;

                x++;
            }
            if (points.Length > 2)
            {
                g.DrawLines(pen, points);
            }

        }


    }

}
