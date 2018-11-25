using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntranetPOPS1819.Models
{
    public class Collaborateurs
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public String Mail { get; set; }
        public Service Service { get; set; }
        public List<Mission> Missions { get; set; }

        public int JoursRestants { get; set; }

        //Garder ? TODO
        public bool Admin { get; set; }

    }
}