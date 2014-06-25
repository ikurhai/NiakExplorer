using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiakExplorer.Utils
{
    public class Fichier
    {
        public string Nom { get; private set; }
        public string Extension { get; private set; }
        public Dossier Dossier { get; private set; }
        public string Chemin
        {
            get
            {
                return this.Dossier.Chemin + this.Nom;
            }
        }
        private bool AJour { get; set; }
        private List<string> contenu { get; set; }
        public List<string> Contenu
        {
            get
            {
                if (!this.AJour)
                {
                    this.MAJ();
                }
                return this.contenu;
            }
        }


        public Fichier(string nom, string extension, Dossier dossier)
        {
            this.Nom = nom;
            this.Extension = extension;
            this.Dossier = dossier;
            this.AJour = false;
            this.contenu = new List<string>();
        }


        private void MAJ()
        {
            try
            {
                using (StreamReader sr = new StreamReader(this.Chemin))
                {
                    string ligne;
                    while ((ligne = sr.ReadLine()) != null)
                    {
                        this.contenu.Add(ligne);
                    }
                }
            }
            catch (Exception e)
            {
                this.contenu.Add(e.Message);
            }
            finally
            {
                this.AJour = true;
            }
        }

    }
}
