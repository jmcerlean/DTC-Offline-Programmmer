using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTemplate.Classes
{
    public struct SENTData
    {
        public string RawSENT;
        public string DiagCode;
        public string ASICTemp;
        public string[] ChProbeTemp;
        public string[] ChProbeRISO;
        public string EEPROM;
        public string PartNum;
        public string SerialNum;
        public string SWVersion;

        public SENTData()
        {
            RawSENT = null;
            DiagCode = null;
            ASICTemp = null;
            EEPROM = null;
            PartNum = null;
            SerialNum = null;
            SWVersion = null;
            ChProbeTemp = new string[3];
            ChProbeRISO = new string[3];
        }
        
    }

    public struct PWMData
    {
        public int Decode;
        public string Ch1Freq;
        public string Ch2Freq;
        public string[] ChProbeTemp;

        public PWMData()
        {
            Decode = 0;
            Ch1Freq = null;
            Ch2Freq = null;
            ChProbeTemp = new string[1];
        }
    }
}