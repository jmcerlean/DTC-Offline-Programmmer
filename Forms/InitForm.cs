using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace CSTemplate.Forms
{

    public partial class InitForm : Form
    {
        public string CoHapPort { get; private set; }
        public string PartNum { get; private set; }
        public bool NextButtonClicked { get; private set; }

        public InitForm()
        {
            InitializeComponent();
            ListPNs();
            ListDUTPorts();
        }

        public void ResetInitParams(string PN, string DUTPort)
        {

            var DUTPortFind = DUTPortCmbBox.FindString(DUTPort);

            if (DUTPortFind != -1)
            {
                DUTPortCmbBox.SelectedIndex = DUTPortFind;
            }
            else // no match
            {
                DUTPortCmbBox.SelectedIndex = 0;
            }

            var PNFind = PartNumCmbBox.FindString(PN);

            if (PNFind != -1)
            {
                PartNumCmbBox.SelectedIndex = PNFind;
            }
            else // no match
            {
                PartNumCmbBox.SelectedIndex = 0;
            }

        }

        private void NextButton1_Click(object sender, EventArgs e)
        {
            NextButtonClicked = true;
        }


        private void ListPNs()
        {
            string path = @"C:\ST\Config\DTCData - PNs.txt";
            try
            {
                var PartsList = File.ReadAllLines(path).Skip(1).Where(Line => Line.Length > 0).OrderBy(line => line).ToArray();
                PartNumCmbBox.DataSource = PartsList;
            }
            catch(Exception ex)
            {
                DialogResult Result = MessageBox.Show(new Form { TopMost = true }, ex.Message, "Error reading Part Number File", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (Result == DialogResult.OK)
                {
                    Close();
                    Station.Error = true;
                }
            }
            
        }

        private void ListDUTPorts()
        {
            string[] DUTPortList = { "1", "2", "3", "4", "5", "6", "7", "8", "9"};
            DUTPortCmbBox.DataSource = DUTPortList;
        }

        private void PartNumCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PartNum = PartNumCmbBox.SelectedItem.ToString();
        }

        private void DUTPortCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CoHapPort = DUTPortCmbBox.SelectedItem.ToString();
        }
    }
}
