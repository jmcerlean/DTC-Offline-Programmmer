using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTemplate.Classes
{
    public class RawSENT
    {
        public RawElems DiagError = new() { ID = "0x01" };
        public RawElems ASICTempRaw = new() { ID = "0x03" };
        public RawElems Config = new() { ID = "0x04" };
        public RawElems Manuf = new() { ID = "0x05" };
        public RawElems SENTRev = new() { ID = "0x06" };
        public RawElems ASICDie = new() { ID = "0x23" };
        public RawElems SerialID29 = new() { ID = "0x29" };
        public RawElems SerialID2A = new() { ID = "0x2a" };
        public RawElems SerialID2B = new() { ID = "0x2b" };
        public RawElems SerialID2C = new() { ID = "0x2c" };
        public RawElems SupplierData80 = new() { ID = "0x80" };
        public RawElems SupplierData81 = new() { ID = "0x81" };
        public RawElems SupplierData82 = new() { ID = "0x82" };
        public RawElems SensorSN = new() { ID = "0x83" };
        public RawElems RISO1Raw = new() { ID = "0x84" };
        public RawElems RISO2Raw = new() { ID = "0x85" };
        public RawElems RISO3Raw = new() { ID = "0x86" };
        public RawElems RISO4Raw = new() { ID = "0x87" };
        public RawElems ASICPN90 = new() { ID = "0x90" };
        public RawElems ASICPN91 = new() { ID = "0x91" };
        public RawElems ASICPN92 = new() { ID = "0x92" };
        public RawElems ASICPN93 = new() { ID = "0x93" };
        public RawElems ASICPN94 = new() { ID = "0x94" };
        public RawElems ASICPN95 = new() { ID = "0x95" };
        public RawElems ASICPN96 = new() { ID = "0x96" };
        public RawElems ASICPN97 = new() { ID = "0x97" };

        public List<RawElems> RISORaw => new() {RISO1Raw, RISO2Raw, RISO3Raw, RISO4Raw };

    }
}
