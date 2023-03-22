using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace GameofThornes
{
    public class GameofThrones
    {
        public string sentence { get; set; }
        public Character character { get; set; }

    }
        public class Character
        {
            public string name { get; set; }
            public string slug { get; set; }
            public House house { get; set; }

        public override string ToString()
        {
            return name;
        }


    }

        public class House
        {
            public string name { get; set; }
            public string slug { get; set; }


        public override string ToString()
        {
            return name;
        }
    }


}
