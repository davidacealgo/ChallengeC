using System;
using System.Collections.Generic;

namespace ChallengeC.Models
{
    public partial class Municipality
    {
        public int Idmunicipality { get; set; }
        public string Names { get; set; }
        public double Latitude { get; set; }
        public double Longitud { get; set; }
    }
}
