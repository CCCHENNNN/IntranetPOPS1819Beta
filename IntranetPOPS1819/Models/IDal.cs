using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetPOPS1819.Models
{
    public interface IDal : IDisposable
    {
        void AjoutCollaborateur(string nom, string prenom, string mail);
        List<Collaborateurs> ObtenirTousLesCollaborateur();
    }
}
