using System.Collections;
using System.IO.Ports;

namespace STM32_StepMotor_Interface
{
    public partial class Form1 : Form
    {
        SerialPort serial;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serial = new SerialPort();
            String[] ports = SerialPort.GetPortNames();
            foreach (String port in ports)
            {
                portsBox.Items.Add(port);
            }
            if (portsBox.Items.Count > 0)
            {
                portsBox.SelectedIndex = 0;
            }
            resultBox.Text = "Bir turu 6400 adýmda atar.";
            disconnectBtn.Enabled = false;
            leftBtn.Enabled = false;
            rightBtn.Enabled = false;
            serial.BaudRate = 9600;
            serial.Parity = Parity.None;
            serial.StopBits = StopBits.One;
            serial.DataBits = 8;
            serial.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serial.ReadLine().Trim();
            if (data == "OK")
            {
                disconnectBtn.Enabled = true;
                leftBtn.Enabled = true;
                rightBtn.Enabled = true;
                MessageBox.Show("Baþarýlý bir þekilde döndü!", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Baþarýlý bir þekilde dönemedi!", "Baþarýsýz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            serial.PortName = portsBox.Text;
            try
            {
                serial.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Baðlanamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            connectBtn.Enabled = false;
            disconnectBtn.Enabled = true;
            leftBtn.Enabled = true;
            rightBtn.Enabled = true;
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            serial.Close();
            connectBtn.Enabled = true;
            disconnectBtn.Enabled = false;
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            int value = test_input();
            if (value != -1)
            {
                string str = value.ToString().Trim();
                if (str.Length < 4)
                {
                    int a = str.Length;
                    for (int i = 0; i < 4 - a; i++)
                    {
                        str = "0" + str;
                    }
                }
                str = "0" + str;
                serial.Write(str);
                leftBtn.Enabled = false;
                rightBtn.Enabled = false;
                disconnectBtn.Enabled = false;
            }
            
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            int value = test_input();
            if (value != -1)
            {
                string str = value.ToString().Trim();
                if (str.Length < 4)
                {
                    int a = str.Length;
                    for (int i = 0; i < 4 - a; i++)
                    {
                        str = "0" + str;
                    }
                }
                str = "1" + str;
                serial.Write(str);
                leftBtn.Enabled = false;
                rightBtn.Enabled = false;
                disconnectBtn.Enabled = false;
            }
        }

        private int test_input()
        {
            bool state = int.TryParse(inputBox.Text, out int value);
            if (state)
            {
                if (value > 0 && value < 10000)
                {
                    return value;
                }
                else
                {
                    MessageBox.Show("1 - 9999 arasý sayý gir!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return -1; 
                }
            }
            else
            {
                MessageBox.Show("Sayý gir!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }
    }
}
