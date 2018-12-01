using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntranetPOPS1819.Models
{
    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public List<Collaborateurs> ObtenirTousLesCollaborateur()
        {
            return bdd.Collaborateurs.ToList();
        }

        public List<Mission> ObtenirToutesLesMissions()
        {
            return bdd.Missions.ToList();
        }

        public List<Service> ObtenirTousLesServices()
        {
            return bdd.Services.ToList();
        }
        public void AjoutCollaborateur(string nom, string prenom, string mail)
        {
            bdd.Collaborateurs.Add(new Collaborateurs { Nom = nom, Prenom = prenom, Mail = mail });
            bdd.SaveChanges();
        }

        
    }
}