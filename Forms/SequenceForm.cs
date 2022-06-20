using System;
using System.Windows.Forms;


namespace CSTemplate.Forms
{

    public partial class SequenceForm : Form
    {
        public string ProgramStr { get; private set; }
        public string SequenceStr { get; private set; }
        public string TestModeStr { get; private set; }
        public string ManufStr { get; private set; }
        public string SWVersStr { get; private set; }
        public string PNStr { get; private set; }
        public bool PWMOption { get; private set; }
        public bool StartButtonClicked { get; private set; }
        public bool CancelButtonClicked { get; private set; }

        public SequenceForm()
        {
            InitializeComponent();
        }

        public void DisableStart()
        {
            StartButton1.Enabled = false;
        }

        public void EnableStart()
        {
            StartButton1.Enabled = true;
        }

        public void SetSequenceVisibility(int SWVers, int DrawingSWVers, bool PWM, out bool CustomerTickTime)
        {
            PWMOption = false;
            CustomerTickTime = false;

            if(SWVers == DrawingSWVers)
            {
                ProgStateTxt.Text = "Final";
                if (PWM)
                {
                    PWMOption = true;
                }
                else
                {
                    CustomerTickTime = true;
                }
            }
            else if(SWVers == (DrawingSWVers - 64)) // 40 in Hex
            {
                ProgStateTxt.Text = "Initial";
            }
            else
            {
                ProgStateTxt.Text = "Not Programmed";
                TestOnlyradioButton.Enabled = false; // can't test only here as it hasn't been programmed before
                RadioButtonFinal.Enabled = false;
            }

        }

        public void SequenceSelect()
        {
            //reset vars after each change
            RadioButtonFinal.Checked = false;
            RadioButtonInitial.Checked = false;
            RadioButtonNoSerialID.Checked = false;
            RadioButtonSerialID.Checked = false;
            Manuf.Text = null;
            SWVers.Text = null;
            PN.Text = null;
            SequenceStr = null;
            ProgGrpBox.Enabled = false;
            TestModeStr = null;

            if (RadioButtonProgram.Checked)
            {
                SequenceStr = "Program";
                ProgGrpBox.Enabled = true;
            }
            else if (RadioButtonProgramTest.Checked)
            {
                SequenceStr = "Program and test";
                ProgGrpBox.Enabled = true;
            }
            else if (TestOnlyradioButton.Checked)
            {
                SequenceStr = "Test Only";

                if (PWMOption)
                {
                    TestModeStr = "PWM Mode";
                }
                else
                {
                    TestModeStr = "SENT Mode";
                }
            }
            
        }

        public void ProgramSelect()
        {
            IDGrpBox.Enabled = false;
            Manuf.Text = null;
            SWVers.Text = null;
            PN.Text = null;

            if (RadioButtonInitial.Checked)
            {
                SerialIDGrpBox.Enabled = true;

                if (RadioButtonSerialID.Checked)
                {
                    ProgramStr = "Initial-Serial ID set";
                    IDGrpBox.Enabled = true;
                }
                else if(RadioButtonNoSerialID.Checked)
                {
                    ProgramStr = "Initial-No Serial ID set";
                }
                else
                {
                    ProgramStr = null;
                }
            }
            else if (RadioButtonFinal.Checked)
            {
                ProgramStr = "Final";
                SerialIDGrpBox.Enabled = false;
                RadioButtonSerialID.Checked = false;
                RadioButtonNoSerialID.Checked = false;
            }
            else
            {
                ProgramStr = null;
            }

        }

        public void ResetSequenceParams(string Program, string Sequence, string manuf, string SWVersion, string Pn)
        {

            switch (Sequence)
            {
                case "Program":
                    RadioButtonProgram.Checked = true;
                    break;

                case "Program and test":
                    RadioButtonProgramTest.Checked = true;
                    break;

                case "Test Only":
                    TestOnlyradioButton.Checked = true;
                    break;
            }

            switch (Program)
            {
                case "Initial-Serial ID set":
                    RadioButtonInitial.Checked = true;
                    RadioButtonSerialID.Checked = true;
                    Manuf.Text = manuf;
                    SWVers.Text = SWVersion;
                    PN.Text = Pn;
                    break;

                case "Initial-No Serial ID set":
                    RadioButtonInitial.Checked = true;
                    RadioButtonNoSerialID.Checked = true;
                    break;

                case "Final":
                    RadioButtonFinal.Checked = true;
                    break;
            }

           
        }

        private void StartButton1_Click(object sender, EventArgs e)
        {
            StartButtonClicked = true;
        }

        private void RadioButtonInitial_CheckedChanged(object sender, EventArgs e)
        {
            ProgramSelect();
        }

        private void RadioButtonFinal_CheckedChanged(object sender, EventArgs e)
        {
            ProgramSelect();
        }

        private void RadioButtonSerial_CheckedChanged(object sender, EventArgs e)
        {
            ProgramSelect();
        }

        private void RadioButtonNoSerial_CheckedChanged(object sender, EventArgs e)
        {
            ProgramSelect();
        }

        private void RadioButtonProgram_CheckedChanged(object sender, EventArgs e)
        {
            SequenceSelect();
        }

        private void RadioButtonProgramTest_CheckedChanged(object sender, EventArgs e)
        {
            SequenceSelect();
        }

        private void TestOnlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SequenceSelect();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CancelButtonClicked = true;
        }

        private void Manuf_TextChanged(object sender, EventArgs e)
        {
            ManufStr = Manuf.Text;
        }

        private void SWVers_TextChanged(object sender, EventArgs e)
        {
            SWVersStr = SWVers.Text;
        }

        private void PN_TextChanged(object sender, EventArgs e)
        {
            PNStr = PN.Text;
        }
    }
}
