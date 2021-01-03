using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSII_Element
{
    public class Element
    {
        public int FromNode { get; set; }
        public int ToNode { get; set; }
        public double OD { get; set; }
        public List<double> Pressure { get; set; }
        public List<double> Temperature { get; set; }

        public double Pressure1 { get; set; }
        public double Pressure2 { get; set; }
        public double Pressure3 { get; set; }
        public double Pressure4 { get; set; }
        public double Pressure5 { get; set; }
        public double Pressure6 { get; set; }
        public double Pressure7 { get; set; }
        public double Pressure8 { get; set; }
        public double Pressure9 { get; set; }
        public double Temperature1 { get; set; }
        public double Temperature2 { get; set; }
        public double Temperature3 { get; set; }
        public double Temperature4 { get; set; }
        public double Temperature5 { get; set; }
        public double Temperature6 { get; set; }
        public double Temperature7 { get; set; }
        public double Temperature8 { get; set; }
        public double Temperature9 { get; set; }
        public override string ToString()
        {
            return FromNode + "\t" + ToNode + "\t" + OD + "\t" + Temperature1 + "\t" + Pressure1 + "\t";
        }
    }

}
