using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Asm2
{
    class record
    {
        private string name;
        private string add;
        private double phone;
        private string sex;
        private string date;
        private int room;
        private Image Avatar;

        public record(string name, string add, double phone, string sex, string date, int room)
        {
            this.Name = name;
            this.Add = add;
            this.Phone = phone;
            this.Sex = sex;
            this.Date = date;
            this.Room = room;
        }

        public string Name { get => name; set => name = value; }
        public string Add { get => add; set => add = value; }
        public double Phone { get => phone; set => phone = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Date { get => date; set => date = value; }
        public int Room { get => room; set => room = value; }
        public Image Avatar1 { get => Avatar; set => Avatar = value; }

        public override string ToString()
        {
            return Name;
        }
    }
}
