using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTemplate.Classes
{
    public class DTCData
    {
        public DTCData(int passFail = 0,
                       int failCode = 0,
                       string partNum = "",
                       string temperature1 = "",
                       string temperature2 = "",
                       string temperature3 = "",
                       string temperature4 = "",
                       string rISO1 = "",
                       string rISO2 = "",
                       string rISO3 = "",
                       string rISO4 = "",
                       string aSICDieTemp = "",
                       string aSICType = "",
                       string current = "",
                       string sequence = "",
                       string program = "",
                       string sWVersion = "",
                       string diagError = "",
                       string serialID = "",
                       string aSICPartNum = "")
        {
            PassFail = passFail;
            FailCode = failCode;
            PartNum = partNum;
            Temperature1 = temperature1;
            Temperature2 = temperature2;
            Temperature3 = temperature3;
            Temperature4 = temperature4;
            RISO1 = rISO1;
            RISO2 = rISO2;
            RISO3 = rISO3;
            RISO4 = rISO4;
            ASICDieTemp = aSICDieTemp;
            ASICType = aSICType;
            Current = current;
            Sequence = sequence;
            Program = program;
            SWVersion = sWVersion;
            DiagError = diagError;
            SerialID = serialID;
            ASICPartNum = aSICPartNum;
        }

        public int Id { get; set; }
        public string PartNum { get; set; }
        public string Sequence { get; set; }
        public string Program { get; set; }
        public string ASICType { get; set; }
        public string NumProbes { get; set; }
        public int PassFail { get; set; }
        public int FailCode { get; set; }
        public string Current { get; set; }
        public string Temperature1 { get; set; }
        public string Temperature2 { get; set; }
        public string Temperature3 { get; set; }
        public string Temperature4 { get; set; }
        public string RISO1 { get; set; }
        public string RISO2 { get; set; }
        public string RISO3 { get; set; }
        public string RISO4 { get; set; }
        public string ASICDieTemp { get; set; }
        public string SerialID { get; set; }
        public string ASICPartNum { get; set; }
        public string SWVersion { get; set; }
        public string DiagError { get; set; }

    }
}
