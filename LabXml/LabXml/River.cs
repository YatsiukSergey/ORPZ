using System;
using System.Collections.Generic;
using System.Text;

namespace LabXml
{
    class River
    {
        public int IdRiver;
        public string Name;
        public float Length;
        public float Width;
        public int AmountTributaries;
        public River()
        {

        }
        public River(int idRiver, string name, float length, float width, int amountTributaries)
        {
            IdRiver = idRiver;
            Name = name;
            Length = length;
            Width = width;
            AmountTributaries = amountTributaries;

        }

    }
}
