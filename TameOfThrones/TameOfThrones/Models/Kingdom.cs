using System;
using System.Collections.Generic;
using System.Text;

namespace TameOfThrones
{
    public class Kingdom
    {
        private Emblem emblem { get; set; }
        private string name { get; set; }
        public Kingdom(string name,Emblem emblem)
        {
            this.name = name;
            this.emblem = emblem;
        }

        public Emblem GetEmblem()
        {
            return emblem;
        }

        public string GetName()
        {
            return name;
        }


        

    }
}
