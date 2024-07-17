using Assinment_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assinment_1
{
    internal class Seat
    {
        public bool availibility = true;
        public string customer = "availible";
        public Label label { get; set; }
        public string name { get; set; }
        public Seat(string name, Label label) 
        {
            this.name = name;
            this.label = label;
        }
    }
}

/*seats[0, 0] = new Seat("A1", lblA1);
seats[0, 1] = new Seat("A2", lblA2);
seats[0, 2] = new Seat("A3", lblA3);
seats[0, 3] = new Seat("A4", lblA4);
seats[1, 0] = new Seat("B1", lblB1);
seats[1, 1] = new Seat("B2", lblB2);
seats[1, 2] = new Seat("B3", lblB3);
seats[1, 3] = new Seat("B4", lblB4);
seats[2, 0] = new Seat("C1", lblC1);
seats[2, 1] = new Seat("C2", lblC2);
seats[2, 2] = new Seat("C3", lblC3);
seats[2, 3] = new Seat("C4", lblC4);*/
