using System;
using System.Windows.Forms;
using CSTemplate.Forms;
using CSTemplate.Classes;
using System.Drawing;
using System.Data.Entity;
using System.Diagnostics;
using System.Collections.Generic;
using System.Xml;

namespace CSTemplate
{
    public class Station
    {

        //*********************************Class Objects****************************************************************
        private readonly MainForm _mainform = new();
        private readonly InitForm _initform = new();
        private readonly SequenceForm _sequenceform = new();

        private DTCDb db = new();



        //************************************Initialisations*************************************************************

        public enum FormSelect
        {
            initform,
            mainform,
            sequenceform
        }

        public enum TestState
        {
            Starting,
            ConnectFailed,
            EEPROMReadFailure,
            CurrentReadError =100,
            CurrentLow= 110,
            CurrentHigh= 120,
            Programming,
            Programmed,
            ProgFailed= 200,
            Testing,
            Tested, 
            TestingFailLoggingResults= 300,
            TestFailLimitsOutofRange = 310
        }

        public enum TestLimits
        {
            RISO,
            Current,
            Temp,
            ASICTemp
        }

        public static bool Error { get; set; }
        public static int ProbeCount { get; set; }
        public static bool PWMLogged { get; set; }
        public double ASICDieTempLow { get; set; }
        public double ASICDieTempHigh { get; set; }
        public double ASICTempLow { get; set; }
        public double ASICTempHigh { get; set; }
        public double CurrentLow { get; set; }
        public double CurrentHigh { get; set; }
        public double RISOLow { get; set; }
        public double RISOHigh { get; set; }



        //**********************************Window Functions*************************************************************
        public void CloseForm(FormSelect enterform)
        {
            switch (enterform)
            {
                case FormSelect.initform:
                    _initform.Close();
                    _initform.Dispose();
                    break;

                case FormSelect.mainform:
                    _mainform.Close();
                    _mainform.Dispose();
                    break;

                case FormSelect.sequenceform:
                    _sequenceform.Close();
                    _sequenceform.Dispose();
                    break;

            }
        }

        public void ShowForm(FormSelect enterform)
        {
            switch (enterform)
            {
                case FormSelect.initform:
                    _initform.Show();
                    break;

                case FormSelect.mainform:
                    _mainform.Show();
                    break;

                case FormSelect.sequenceform:
                    _sequenceform.Show();
                    break;

            }

        }
        //**********************************Test Functions***************************************************************

        public bool NextButtonClickedCheck(out string PN, out string DUTPort)
        {
            PN = _initform.PartNum;
            DUTPort = _initform.CoHapPort;

            return _initform.NextButtonClicked;
        }

        public void ResetInitialParams(string PN, string DUTPort)
        {
            _initform.ResetInitParams(PN, DUTPort);
        }

        public void ButtonClickedCheck(out string Seq, out string Prog, out string TestMde, out bool StartBtn, out bool CancelBtn, out string Manuf, out string SWVers, out string PN)
        {
            Seq = _sequenceform.SequenceStr;
            Prog = _sequenceform.ProgramStr;
            TestMde = _sequenceform.TestModeStr;
            Manuf = _sequenceform.ManufStr;
            SWVers = _sequenceform.SWVersStr;
            PN = _sequenceform.PNStr;

            StartBtn =  _sequenceform.StartButtonClicked;
            CancelBtn = _sequenceform.CancelButtonClicked;
        }

        public void ResetSequenceParams(string Program, string Sequence, string manuf, string SWVers, string PN)
        {
            _sequenceform.ResetSequenceParams(Program, Sequence, manuf,SWVers,PN );
        }

        public void StartButtonEnableDisable() // check to decide whether the start button on the initial form can be pressed or not (enabled/disabled)
        { 
             switch(_sequenceform.SequenceStr)
             {
                 case "Program":
                 case "Program and test":
                     if (_sequenceform.ProgramStr != null)
                     {
                        if(_sequenceform.ProgramStr == "Initial-Serial ID set")
                        {
                            if (_sequenceform.ManufStr != null && _sequenceform.SWVersStr != null && _sequenceform.PNStr != null)
                            {
                                _sequenceform.EnableStart();
                            }
                        }
                        else
                        {
                            _sequenceform.EnableStart();
                        }
                     }
                     else
                     {
                        _sequenceform.DisableStart();
                    }
                     break;

                 case "Test Only":
                     if(_sequenceform.TestModeStr != null)
                     {
                        _sequenceform.EnableStart();
                    }
                     else
                     {
                        _sequenceform.DisableStart();
                    }
                     break;
             }
         }


        public void ChangeTestStatus(TestState TestStateArg)
        {
            _mainform.TestStatusControl.TestStatusChange(TestStateArg);
        }

        public void LoadInitParamsOnMain(string PN, string Sequence, string Program, string TestMode, string DUTPort, string ASIC, bool PWMMode)
        {
            _mainform.SetInitialParams(PN, Sequence, Program, TestMode, DUTPort, ASIC, PWMMode);
            
        }


        public void SetTestData(SENTData SENT, PWMData PWM)
        {
            RawSENT rawSENTData;

            if (PWMLogged) // PWM data logged and incoming
            {
                _mainform.LogPWM(PWM);
            }
            else
            {
                rawSENTData = ExtractRawSENT(SENT.RawSENT);
                _mainform.LogSENT(SENT, rawSENTData);
            }
        }

        public bool CheckButtonPress()
        {
            return _mainform.ButtonPress;
        }

        public void SetMFormVisibility(bool[] probes)
        {
            _mainform.SetMainFormVisibility(probes);
        }

        public void GetTestLimits()
        {
            try
            {
                string path = @"C:\ST\Config\TestLimits.ini";

                IniFile iniFile = new(path);

                RISOLow = iniFile.GetDouble("TestLimits", "risolow");
                RISOHigh = iniFile.GetDouble("TestLimits", "risohigh");
                ASICDieTempLow = iniFile.GetDouble("TestLimits", "tempDielow");
                ASICDieTempHigh = iniFile.GetDouble("TestLimits", "tempDiehigh");
                ASICTempLow = iniFile.GetDouble("TestLimits", "templow");
                ASICTempHigh = iniFile.GetDouble("TestLimits", "tempHigh");
                CurrentLow = iniFile.GetDouble("TestLimits", "currentlow");
                CurrentHigh = iniFile.GetDouble("TestLimits", "currenthigh");
            }
            catch(Exception ex)
            {
                DialogResult Result = MessageBox.Show(new Form { TopMost = true }, ex.Message, "Error with Test Limits Config File", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (Result == DialogResult.OK)
                {
                    Station.Error = true;
                    _mainform.Close();
                    
                }
            }

        }

        public int CheckValueAgstLimits(TestLimits limits, string value, int increm)
        {
            int Passfail = 0;
            float ValueNum = 0;

            if (value != null && value != String.Empty)
            {
                ValueNum = float.Parse(value);
            }

            switch (limits)
            {
                case TestLimits.Current:
                    if(ValueNum <= CurrentLow)
                    {
                        Passfail = 1;
                        _mainform.CurrentStr.BackColor = Color.Red;
                    }
                    else if(ValueNum >= CurrentHigh)
                    {
                        Passfail = 2;
                        _mainform.CurrentStr.BackColor = Color.Red;
                    }
                    else 
                    {
                        Passfail = 0;
                    }
                    break;

                case TestLimits.ASICTemp:
                    if (ValueNum >= ASICDieTempLow && ValueNum <= ASICDieTempHigh)
                    {
                        Passfail = 0;
                        
                    }
                    else
                    {
                        Passfail = 1;
                        _mainform.ASICTempStr.BackColor = Color.Red;
                    }
                    break;

                case TestLimits.Temp:
                    if (ValueNum >= ASICTempLow && ValueNum <= ASICTempHigh)
                    {
                        Passfail = 0;
                        
                    }
                    else
                    {
                        Passfail = 1;
                        _mainform.Temperatures[increm].BackColor = Color.Red;
                    }
                    break;

                case TestLimits.RISO:
                    if (ValueNum >= RISOLow && ValueNum <= RISOHigh)
                    {
                        Passfail = 0;
                    }
                    else
                    {
                        Passfail = 1;
                        _mainform.Temperatures[increm].BackColor = Color.Red;
                    }
                    break;
            }

            return Passfail;
        }

        public string SearchString(string data, string ID)
        {
            var rDataArr = data.Split(',');


            for (int i = 0; i < rDataArr.Length; i++)
            {
                if (rDataArr[i].Contains(ID) && (i != 0) && (i % 2 != 0)) // searching the ID elements in the array and checking if the parameter 'ID' is valid.
                {
                    return rDataArr[i-1]; // return the value of the associated ID if the search is successful
                }
            }
            return "-"; // return an empty string otherwise.
        }

        public RawSENT ExtractRawSENT(string raw)
        {
            RawSENT rawData = new();

            rawData.DiagError.ValueHex = SearchString(raw, rawData.DiagError.ID);
            rawData.ASICTempRaw.ValueHex = SearchString(raw, rawData.ASICTempRaw.ID);
            rawData.Config.ValueHex = SearchString(raw, rawData.Config.ID);
            rawData.Manuf.ValueHex = SearchString(raw, rawData.Manuf.ID);
            rawData.SENTRev.ValueHex = SearchString(raw, rawData.SENTRev.ID);
            rawData.ASICDie.ValueHex = SearchString(raw, rawData.ASICDie.ID);
            rawData.SerialID29.ValueHex = SearchString(raw, rawData.SerialID29.ID);
            rawData.SerialID2A.ValueHex = SearchString(raw, rawData.SerialID2A.ID);
            rawData.SerialID2B.ValueHex = SearchString(raw, rawData.SerialID2B.ID);
            rawData.SerialID2C.ValueHex = SearchString(raw, rawData.SerialID2C.ID);
            rawData.SupplierData80.ValueHex = SearchString(raw, rawData.SupplierData80.ID);
            rawData.SupplierData81.ValueHex = SearchString(raw, rawData.SupplierData81.ID);
            rawData.SupplierData82.ValueHex = SearchString(raw, rawData.SupplierData82.ID);
            rawData.SensorSN.ValueHex = SearchString(raw, rawData.SensorSN.ID);
            rawData.RISORaw[0].ValueHex = SearchString(raw, rawData.RISORaw[0].ID);
            rawData.RISORaw[1].ValueHex = SearchString(raw, rawData.RISORaw[1].ID);
            rawData.RISORaw[2].ValueHex = SearchString(raw, rawData.RISORaw[2].ID);
            rawData.RISORaw[3].ValueHex = SearchString(raw, rawData.RISORaw[3].ID);
            rawData.ASICPN90.ValueHex = SearchString(raw, rawData.ASICPN90.ID);
            rawData.ASICPN91.ValueHex = SearchString(raw, rawData.ASICPN91.ID);
            rawData.ASICPN92.ValueHex = SearchString(raw, rawData.ASICPN92.ID);
            rawData.ASICPN93.ValueHex = SearchString(raw, rawData.ASICPN93.ID);
            rawData.ASICPN94.ValueHex = SearchString(raw, rawData.ASICPN94.ID);
            rawData.ASICPN95.ValueHex = SearchString(raw, rawData.ASICPN95.ID);
            rawData.ASICPN96.ValueHex = SearchString(raw, rawData.ASICPN96.ID);
            rawData.ASICPN97.ValueHex = SearchString(raw, rawData.ASICPN97.ID);

            return rawData;
        }


        public void GetCurrent(string current)
        {
            _mainform.CurrentStr.Text = current + "mA";
        }

        public void EnableCloseButton()
        {
            _mainform.EnableClose.Enabled = true;
        }

        public void GetInitSWVers(int SWVersion, int DrawingSWVersion, bool PWM, out bool CustomerTickTime)
        {
            _sequenceform.SetSequenceVisibility(SWVersion, DrawingSWVersion, PWM, out CustomerTickTime);
        }

        public void PopulateDbFailcodes()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DTCDb>());

            db.Database.ExecuteSqlCommand("TRUNCATE TABLE [Failcodes]"); 

            List<Failcodes> failcodes = new()
            {
                new Failcodes{Failcode = "0", FailDescr = "No Error Present"},
                new Failcodes{Failcode = "100", FailDescr = "Error Reading Current"},
                new Failcodes{Failcode = "110", FailDescr = "Current Low"},
                new Failcodes{Failcode = "120", FailDescr = "Current High"},
                new Failcodes{Failcode = "200", FailDescr = "Programming Error"},
                new Failcodes{Failcode = "300", FailDescr = "Testing Failed: Error Logging Test Results"},
                new Failcodes{Failcode = "310", FailDescr = "Testing Failed: Results out of range"},
            };

            foreach (var code in failcodes)
            {
                db.Failcodes.Add(code);
            }
            db.SaveChanges();

        }

        public void PopulateDb(TestState state)
        {
            int failcode;
            int passfail;

            switch (state)
            {
                case TestState.CurrentLow:
                case TestState.CurrentHigh:
                case TestState.TestFailLimitsOutofRange:
                case TestState.ProgFailed:
                case TestState.TestingFailLoggingResults:
                    failcode = (int)state;
                    passfail = 0;
                    break;

                default:
                    failcode = 0;
                    passfail = 1;
                    break;
            }

            DTCData data = new()
            {
                PartNum = _mainform.DbVars[0].Text,
                Sequence = _mainform.DbVars[1].Text,
                Program = _mainform.DbVars[2].Text,
                ASICType = _mainform.DbVars[3].Text,
                SWVersion = _mainform.DbVars[4].Text,
                DiagError = _mainform.DbVars[5].Text,
                NumProbes = Station.ProbeCount.ToString(),
                PassFail = passfail,
                FailCode = failcode,
                ASICPartNum = _mainform.DbVars[6].Text,
                SerialID = _mainform.DbVars[7].Text,
                Temperature1 = _mainform.DbVars[8].Text,
                Temperature2 = _mainform.DbVars[9].Text,
                Temperature3 = _mainform.DbVars[10].Text,
                Temperature4 = _mainform.DbVars[11].Text,
                RISO1 = _mainform.DbVars[12].Text,
                RISO2 = _mainform.DbVars[13].Text,
                RISO3 = _mainform.DbVars[14].Text,
                RISO4 = _mainform.DbVars[15].Text,
                Current = _mainform.DbVars[16].Text,
                ASICDieTemp = _mainform.DbVars[17].Text

            };

            db.Data.Add(data);
            db.SaveChanges();

        }

        public void GetPortNum(out int Port)
        {
            Port = 0;
            try
            {
                string path = @"C:\ST\Config\Setup.config";

                XmlDocument xDoc = new();
                xDoc.Load(path);
                XmlNode node = xDoc.SelectSingleNode("Station/system/Port");
                Port = int.Parse(node.InnerText);

            }
            catch (Exception ex)
            {
                DialogResult Result = MessageBox.Show(new Form { TopMost = true }, ex.Message, "Error Finding Serial Port", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (Result == DialogResult.OK)
                {
                    Station.Error = true;
                }
            }

        }
    }
}
