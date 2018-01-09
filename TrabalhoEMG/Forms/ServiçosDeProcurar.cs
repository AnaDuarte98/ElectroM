using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoEMG
{
    public partial class ServiçosDeProcurar : Form
    {

        Bitalino.DevInfo[] devices;

        public Bitalino.DevInfo[] Devices
        {
            get
            {
                return devices;
            }

            set
            {
                devices = value;
            }
        }

        public ServiçosDeProcurar()
        {
            InitializeComponent();
            DeviceSingletone.Instance.EnconteredDevices += Instance_EnconteredDevices;

            //Aparecer as horas e o dia no programa
            labelDataExame.Text = DateTime.Now.ToLongDateString();

            //Pôr a parte de trás das labels transparente
            labelDataExame.BackColor = Color.Transparent;
            labelHoraExame.BackColor = Color.Transparent;
            

            //conta o tempo
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            labelHoraExame.Text = DateTime.Now.ToLongTimeString();
        }

        private async void buttonProcura_Click(object sender, EventArgs e)
        {
            listBoxProcurar.Items.Clear();
            //buttonFind.Enabled = false;
            await DeviceSingletone.Instance.SearchDevices();

        }

        private void Instance_EnconteredDevices(Bitalino.DevInfo[] devs)
        {
            devices = devs;
            foreach (Bitalino.DevInfo devices in devs)
            {
                AddTextToListBox(String.Format("{0} - {1}", devices.macAddr, devices.name));
            }
        }

        delegate void AddDeviceDelegate(string text);

        private void AddTextToListBox(string text)
        {
            if (this.listBoxProcurar.InvokeRequired)
            {
                AddDeviceDelegate d = new AddDeviceDelegate(AddTextToListBox);
                this.Invoke(d, new object[] { text });
            }
            else
            {

                listBoxProcurar.Items.Add(text);
            }
        }

        private void listBoxDevices_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int index = listBoxProcurar.SelectedIndex;
            DeviceSingletone.Instance.Device = devices[index];
            this.Close();

        }

       
    }
}

