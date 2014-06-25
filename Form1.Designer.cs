namespace NiakExplorer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TW_Explorer = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // TW_Explorer
            // 
            this.TW_Explorer.Location = new System.Drawing.Point(12, 12);
            this.TW_Explorer.Name = "TW_Explorer";
            this.TW_Explorer.Size = new System.Drawing.Size(600, 418);
            this.TW_Explorer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.TW_Explorer);
            this.Name = "Form1";
            this.Text = "NiakExplorer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TW_Explorer;

    }
}

