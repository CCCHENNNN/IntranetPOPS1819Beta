using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntranetPOPS1819.Models;
using System.Data.Entity;
using System.Collections.Generic;

namespace IntranetPOPS1819.Tests
{
    [TestClass]
    public class DalTest
    {
        [TestClass]
        public class DalTests
        {
            [TestInitialize]
            public void Init_AvantChaqueTest()
            {
                IDatabaseInitializer<BddContext> init = new DropCreateDatabaseAlways<BddContext>();
                Database.SetInitializer(init);
                init.InitializeDatabase(new BddContext());
            }

            [TestMethod]
            public void CreerCreerCollaborateur_AvecUnNouveauCreerCollaborateur_ObtientTousLesCreerCollaborateurRenvoitBienLeCreerCollaborateur()
            {
                using (IDal dal = new Dal())
                {
                    dal.AjoutCollaborateur("Minh", "Nguyen", "minh.nguyen@u-psud.fr");
                    List<Collaborateurs> collab = dal.ObtenirTousLesCollaborateur();

                    Assert.IsNotNull(collab);
                    Assert.AreEqual(1, collab.Count);
                    Assert.AreEqual("Minh", collab[0].Nom);
                    Assert.AreEqual("Nguyen", collab[0].Prenom);
                    Assert.AreEqual("minh.nguyen@u-psud.fr", collab[0].Mail);
                }
            }
        }
    }
}
