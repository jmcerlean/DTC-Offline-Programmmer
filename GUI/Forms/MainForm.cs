using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CSTemplate.Controls;

namespace CSTemplate.Forms
{

    public partial class MainForm : Form
    {
        public bool IsPWM { get; private set; }
        public string TestMode { get; private set; }
        public string SeqCpy { get; private set; }
        public string ProgCpy { get; private set; }
        public bool ButtonPress { get; set; }

        private const int MaxPWMProbes = 2;
        private bool[] ProbeConfig;

        public ITestStatus TestStatusControl => testStatus1;

        public Classes.RawSENT rawSENT;

        public Classes.SENTData SENTLogged;

        public Button EnableClose => CloseButton;

        public List<Label> Temperatures => new() { Temp1Txt, Temp2Txt, Temp3Txt, Temp4Txt };
        public List<Label> RISO => new() { RISO1Txt, RISO2Txt, RISO3Txt, RISO4Txt };

        public List<Label> TemperaturesLbls => new() { Temp1Lbl, Temp2Lbl, Temp3Lbl, Temp4Lbl};

        public List<Label> RISOLbls => new() { RISO1Lbl, RISO2Lbl, RISO3Lbl, RISO4Lbl};

        public Label CurrentStr => CurrentTxt;

        public Label ASICTempStr => ASICDieTxt;

        public List<Label> DbVars => new()
        {
            SensataPNTxt,
            SequenceTxt,
            ProgramTxt,
            ASICTxt,
            SWVersionTxt,
            DiagErrTxt,
            ASICFullPNTxt,
            SensorSNTxt,
            Temp1Txt,
            Temp2Txt,
            Temp3Txt,
            Temp4Txt,
            RISO1Txt,
            RISO2Txt,
            RISO3Txt,
            RISO4Txt,
            CurrentTxt,
            ASICDieTxt,
        };


        public MainForm()
        {
            InitializeComponent();
        }

        public void SetInitialParams(string PartNo, string Seq, string Prog,  string TestMde, string CoHapPort, string ASIC, bool PWMMode) 
        {
            SensataPNTxt.Text = PartNo;
            SequenceTxt.Text = Seq;
            CoHapPortTxt.Text = CoHapPort;
            ASICTxt.Text = ASIC;
            if (Seq == "Test Only") // if a test only sequence is selected
            {
                ProgramTxt.Text = TestMde;
                ProgramLbl.Text = "Mode: ";
            }
            else
            {
                ProgramTxt.Text = Prog;
                ProgramLbl.Text = "Program: ";
            }

            IsPWM = PWMMode;
            TestMode = TestMde;
            SeqCpy = Seq;
            ProgCpy = Prog;

        }

        public void SetMainFormVisibility(bool[] Probes)
        {
            ProbeConfig = Probes;

            for(int i = 0; i < ProbeConfig.Length; i++)
            {
                if (ProbeConfig[i])
                {
                    Temperatures[i].Visible = true;
                    TemperaturesLbls[i].Visible = true; 
                    RISO[i].Visible = true;
                    RISOLbls[i].Visible = true;
                }
                else
                {
                    Temperatures[i].Visible = false;
                    TemperaturesLbls[i].Visible = false;
                    RISO[i].Visible = false;
                    RISOLbls[i].Visible = false;
                }
            }

            switch (SeqCpy)
            {
                case "Program":
                    SENTDataGrpBox.Enabled = false;
                    TempGrpBox.Enabled = false;
                    break;

                case "Test Only":

                    TempGrpBox.Enabled = true;

                    if (TestMode == "SENT Mode") SENTDataGrpBox.Enabled = true;
                    else SENTDataGrpBox.Enabled = false;
                    break;

                case "Program and test":
                    if (ProgCpy == "Initial-Serial ID set" || ProgCpy == "Initial-No Serial ID set")
                    {
                        SENTDataGrpBox.Enabled = true;
                        TempGrpBox.Enabled = true;
                    }
                    else // final
                    {
                        if (IsPWM) // PWM part
                        {
                            SENTDataGrpBox.Enabled = false;
                            TempGrpBox.Enabled = true;
                        }
                        else
                        {
                            SENTDataGrpBox.Enabled = true;
                            TempGrpBox.Enabled = true;
                        }
                        
                    }
                    break;

            }
        }


        public void LogSENT(Classes.SENTData LoggedSENT, Classes.RawSENT raw)
        {
            SENTLogged = LoggedSENT;
            rawSENT = raw;

            SensorSNTxt.Text = LoggedSENT.SerialNum;
            ASICFullPNTxt.Text = LoggedSENT.PartNum;
            SWVersionTxt.Text = LoggedSENT.SWVersion.ToString();
            DiagErrTxt.Text = raw.DiagError.ValueHex;
            ASICTempTxt.Text = raw.ASICTempRaw.ValueHex;
            ConfigTxt.Text = raw.Config.ValueHex;
            ManufTxt.Text = raw.Manuf.ValueHex;
            SENTRevTxt.Text = raw.SENTRev.ValueHex;
            SupplierData1Txt.Text = raw.SupplierData80.ValueHex;
            SupplierData2Txt.Text = raw.SupplierData81.ValueHex;
            SupplierData3Txt.Text = raw.SupplierData82.ValueHex;

            SerialID1Txt.Text = raw.SerialID29.ValueHex;
            SerialID2Txt.Text = raw.SerialID2A.ValueHex;
            SerialID3Txt.Text = raw.SerialID2B.ValueHex;
            SerialID4Txt.Text = raw.SerialID2C.ValueHex;

            SensorSNTxt.Text = LoggedSENT.SerialNum;

            ASICPN1Txt.Text = raw.ASICPN90.ValueHex;
            ASICPN2Txt.Text = raw.ASICPN91.ValueHex;
            ASICPN3Txt.Text = raw.ASICPN92.ValueHex;
            ASICPN4Txt.Text = raw.ASICPN93.ValueHex;
            ASICPN5Txt.Text = raw.ASICPN94.ValueHex;
            ASICPN6Txt.Text = raw.ASICPN95.ValueHex;
            ASICPN7Txt.Text = raw.ASICPN96.ValueHex;
            ASICPN8Txt.Text = raw.ASICPN97.ValueHex;


            for (int i = 0; i < ProbeConfig.Length; i++)
            {
                if(i < Station.ProbeCount)
                {
                    Temperatures[i].Text = LoggedSENT.ChProbeTemp[i] + "°C";
                }
                else
                {
                    Temperatures[i].Text = "n/a";
                }
                
            }


            if (RawSENTTickBox.Checked) // shows raw hex vals
            {
                for (int i = 0; i < ProbeConfig.Length; i++)
                { 
                    if(i < Station.ProbeCount)
                    {
                        RISO[i].Text = raw.RISORaw[i].ValueHex;
                    }
                    else
                    {
                        RISO[i].Text = "n/a";
                    }
                }
                ASICDieTxt.Text = raw.ASICDie.ValueHex;
            }
            else
            {
                for (int i = 0; i < ProbeConfig.Length; i++)
                {
                    if (i < Station.ProbeCount)
                    {
                        RISO[i].Text = LoggedSENT.ChProbeRISO[i] + "MΩ";
                    }
                    else
                    {
                        RISO[i].Text = "n/a";
                    }
                }
                ASICDieTxt.Text = LoggedSENT.ASICTemp + "°C";
            }

        }

        public void LogPWM(Classes.PWMData LoggedPWM)
        {
            for (int i = 0; i < MaxPWMProbes; i++)
            {
                Temperatures[i].Text = LoggedPWM.ChProbeTemp[i] + "°C";
            }
        }

        public void ShowConsole()
        {
            Show();
        }

        public void CloseConsole()
        {
            Close();
            Dispose();
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ButtonPress = true;
            Close();
            Dispose();
            
        }


        private void RawSENTTickBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!Station.PWMLogged) // only valid when dealing with SENT data
            {
                LogSENT(SENTLogged, rawSENT);
            }
        }
    }
}
