using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSTemplate.Controls
{

    public interface ITestStatus
    {
        void TestStatusChange(Station.TestState TestStatusArg);
    }


    public partial class TestStatus : UserControl, ITestStatus
    { 

        public TestStatus()
        {
            InitializeComponent();
        }

        public void TestStatusChange(Station.TestState TestStatusArg)
        {

            switch (TestStatusArg)
            {
                case Station.TestState.Starting:
                    TestStatusLbl.Text = "Starting";
                    TestStatusLbl.BackColor = Color.Orange;
                    break;


                case Station.TestState.ConnectFailed:
                    TestStatusLbl.Text = "CoHap Connection Failed";
                    TestStatusLbl.BackColor = Color.Red;
                    break;


                case Station.TestState.EEPROMReadFailure:
                    TestStatusLbl.Text = "EEPROM Read Failure";
                    TestStatusLbl.BackColor = Color.Red;
                    break;


                case Station.TestState.CurrentLow:
                    TestStatusLbl.Text = "Current Low";
                    TestStatusLbl.BackColor = Color.Red;
                    break;

                case Station.TestState.CurrentHigh:
                    TestStatusLbl.Text = "Current High";
                    TestStatusLbl.BackColor = Color.Red;
                    break;

                case Station.TestState.Programming:
                    TestStatusLbl.Text = "Programming";
                    TestStatusLbl.BackColor = Color.Yellow;
                    break;

                case Station.TestState.Programmed:
                    TestStatusLbl.Text = "Programmed";
                    TestStatusLbl.BackColor = Color.Lime;
                    break;

                case Station.TestState.ProgFailed:
                    TestStatusLbl.Text = "Prog Failed";
                    TestStatusLbl.BackColor = Color.Red;
                    break;

                case Station.TestState.Testing:
                    TestStatusLbl.Text = "Testing";
                    TestStatusLbl.BackColor = Color.Yellow;
                    break;

                case Station.TestState.TestingFailLoggingResults:
                    TestStatusLbl.Text = "Test Failed: Error Communicating with the Part";
                    TestStatusLbl.BackColor = Color.Red;
                    break;

                case Station.TestState.TestFailLimitsOutofRange:
                    TestStatusLbl.Text = "Test Failed: Limits Out of Range";
                    TestStatusLbl.BackColor = Color.Red;
                    break;

                case Station.TestState.Tested:
                    TestStatusLbl.Text = "Test Complete";
                    TestStatusLbl.BackColor = Color.Lime;
                    break;

            }
        }


        private void TestStatus_Load(object sender, EventArgs e)
        {
            TestStatusChange(Station.TestState.Starting); // set initial value to ready

        }
    }
}
