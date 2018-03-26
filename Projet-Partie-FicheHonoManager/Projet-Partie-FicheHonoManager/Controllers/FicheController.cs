using Projet_Partie_FicheHonoManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet_Partie_FicheHonoManager.Controllers
{
    public class FicheController : Controller
    {

        // Voir pour une injection de dépendance
        private FicheHonoManager ficheHonoManager = new FicheHonoManager();

        
        public bool CreerFicher()
        {
            return ficheHonoManager.CreerFicher();
        }


        public List<FicheHono> ConsulterFiches()
        {
            return ficheHonoManager.ConsulterFiches();
        }


        public FicheHono ModifierFiche(FicheHono fiche)
        {
            return ficheHonoManager.ModifierFiche(fiche);
        }


        public FicheHono RechercheFiche(int id)
        {
            return ficheHonoManager.RechercheFiche(id);
        }
    }
}