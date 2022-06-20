using CSTemplate.Classes;
using System.Linq;

namespace CSTemplate
{
    //***********************************************Functions to be called by teststand********************************************
    public class TSFunctions
    {
        private readonly Station _station = new();

        public TSFunctions(out bool error, out int Port)
        {
            _station.GetPortNum(out Port);

            error = Station.Error;
            Station.Error = false;
        }

        public void CloseDllWindow(Station.FormSelect form)
        {
            _station.CloseForm(form);
        }

        public void ShowDllWindow(Station.FormSelect form)
        {
            _station.ShowForm(form);
        }


        /*******InitialForm************/

        public bool NextButtonClickedStatus(out string PN, out string DUTPort)
        {
            return _station.NextButtonClickedCheck(out PN, out DUTPort);
        }

        public void ResetInitParams(string PN, string DUTPort)
        {
            _station.ResetInitialParams(PN, DUTPort);
        }


        /*******MainForm************/

        public void ShowTestState(Station.TestState state)
        {
            _station.ChangeTestStatus(state);
        }

        public void SetInitialParamsOnMain(string PartNum, string Seq, string Prog, string TestMode, string CoHapPort, string ASIC, bool PWMMode, bool[] probes, out int NumProbes, out bool error)
        { 
            NumProbes = probes.Where(p => p == true).Count();
            Station.ProbeCount = NumProbes;
            _station.LoadInitParamsOnMain (PartNum, Seq, Prog, TestMode, CoHapPort, ASIC, PWMMode);
            _station.SetMFormVisibility(probes);
            _station.GetTestLimits();

            error = Station.Error;
            Station.Error = false;
        }

        public void GetLoggedSTestResults(bool pwmLogged, SENTData SENT, PWMData PWM)
        {
            Station.PWMLogged = pwmLogged;

            _station.SetTestData(SENT, PWM);
        }

        public int CheckValueAgstLimits(Station.TestLimits testLimits, string value, int increm)
        {
            return _station.CheckValueAgstLimits(testLimits, value, increm);
        }

        public bool  ButtonPressCheck()
        {
            return _station.CheckButtonPress(); 
        }

        public void EnableButtons()
        {
            _station.EnableCloseButton();
        }

        public void GetCurrent(string current)
        {
            _station.GetCurrent(current);
        }

        public void PopulateDb(Station.TestState testState)
        {
            _station.PopulateDb(testState);
        }

        /*******SequenceForm************/

        public void GetInitSWVersion(int SWVers, int DrawingSWVers, bool PWMmode, out bool CustomerTickTime)
        {
            _station.GetInitSWVers(SWVers, DrawingSWVers, PWMmode, out CustomerTickTime);
            _station.PopulateDbFailcodes(); // placed here to as it runs all the time.
        }

        public void ResetSeqParams(string Program, string Sequence, string manuf, string SWVers, string PN)
        {
            _station.ResetSequenceParams(Program, Sequence, manuf, SWVers, PN );
        }

        public void ButtonClickedStatus(out string Seq, out string Prog, out string TestMode, out bool StartBtn, out bool CancelBtn, out string Manuf, out string SWVers, out string PN)
        {
            _station.ButtonClickedCheck(out Seq, out Prog, out TestMode, out StartBtn, out CancelBtn, out Manuf, out SWVers, out PN);
        }

        public void EnableDisableStartButton()
        {
            _station.StartButtonEnableDisable();
        }
    }
}
