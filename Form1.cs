using NiakExplorer.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiakExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Initialisation des "dossiers" racines
            List<Dossier> racines = new List<Dossier>();
            foreach (string lecteur in Environment.GetLogicalDrives())
            {
                racines.Add(new Dossier(lecteur));
            }


            // Initialisation du treeview

            TreeView treeView = TW_Explorer;

            ImageList imageList = new ImageList();
            imageList.Images.Add(new Icon("..\\..\\img\\iconeDossier.ico", new Size(16, 16)));
            imageList.Images.Add(Image.FromFile("..\\..\\img\\iconeFichier.png"));
            treeView.ImageList = imageList;

            TreeNode treeNode;
            foreach (Dossier r in racines)
            {
                treeNode = new TreeNode();
                treeNode.Text = r.Nom;
                treeNode.Tag = r;
                treeNode.ImageIndex = 0;
                treeNode.SelectedImageIndex = 0;
                treeNode.Nodes.Add(new TreeNode() { Text = "DUMMY", Tag = "DUMMY"});

                treeView.Nodes.Add(treeNode);
            }

            // Ajout de l'événement BeforeExpand
            treeView.BeforeExpand += tw_BeforeExpand;
        }


        void tw_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode treeNode = e.Node;

            if (treeNode.FirstNode.Tag.Equals("DUMMY"))
            {
                treeNode.Nodes.Clear();

                Dossier parent = (Dossier)treeNode.Tag;
                TreeNode newTreeNode;
                foreach (Dossier d in parent.Dossiers)
                {
                    newTreeNode = new TreeNode();
                    newTreeNode.Text = d.Nom;
                    newTreeNode.Tag = d;
                    newTreeNode.ImageIndex = 0;
                    newTreeNode.SelectedImageIndex = 0;
                    newTreeNode.Nodes.Add(new TreeNode() { Text = "DUMMY", Tag = "DUMMY" });

                    treeNode.Nodes.Add(newTreeNode);
                }
                foreach (string f in parent.Fichiers)
                {
                    newTreeNode = new TreeNode();
                    newTreeNode.Text = f;
                    newTreeNode.Tag = f;
                    newTreeNode.ImageIndex = 1;
                    newTreeNode.SelectedImageIndex = 1;

                    treeNode.Nodes.Add(newTreeNode);
                }
            }
        }
    }
}
