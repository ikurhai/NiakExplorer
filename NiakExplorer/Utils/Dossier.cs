using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiakExplorer.Utils
{

    public class Dossier
    {

        public string Nom { get; private set; }
        public Dossier Parent { get; private set; }
        private bool AJour;
        private List<Dossier> dossiers { get; set; }
        private List<Fichier> fichiers { get; set; }
        public List<Dossier> Dossiers
        {
            get
            {
                if (!this.AJour)
                {
                    this.MAJ();
                }
                return this.dossiers;
            }
            private set
            {
                this.dossiers = value;
            }
        }
        public List<Fichier> Fichiers
        {
            get
            {
                if (!this.AJour)
                {
                    this.MAJ();
                }
                return this.fichiers;
            }
            private set
            {
                this.fichiers = value;
            }
        }
        public string Chemin
        {
            get
            {
                if (Parent != null)
                {
                    return Parent.Chemin + Nom + "\\";
                }
                else
                {
                    return Nom;
                }
            }
        }


        public Dossier(string nom)
        {
            this.Nom = nom;
            this.Parent = null;
            this.AJour = false;
            this.Dossiers = new List<Dossier>();
            this.Fichiers = new List<Fichier>();
        }

        public Dossier(string nom, Dossier parent)
        {
            this.Nom = nom;
            this.Parent = parent;
            this.AJour = false;
            this.Dossiers = new List<Dossier>();
            this.Fichiers = new List<Fichier>();
        }


        private void MAJ()
        {
            try
            {
                DirectoryInfo dossier = new DirectoryInfo(this.Chemin);
                foreach (DirectoryInfo enfant in dossier.GetDirectories())
                {
                    this.dossiers.Add(new Dossier(enfant.Name, this));
                }
                foreach (FileInfo fichier in dossier.GetFiles())
                {
                    this.fichiers.Add(new Fichier(fichier.Name, fichier.Extension, this));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.AJour = true;
            }
        }

    }

}
