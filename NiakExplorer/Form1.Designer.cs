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
            this.LB_Preview = new System.Windows.Forms.ListBox();
            this.L_NbLigne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TW_Explorer
            // 
            this.TW_Explorer.Location = new System.Drawing.Point(12, 12);
            this.TW_Explorer.Name = "TW_Explorer";
            this.TW_Explorer.Size = new System.Drawing.Size(295, 538);
            this.TW_Explorer.TabIndex = 0;
            // 
            // LB_Preview
            // 
            this.LB_Preview.FormattingEnabled = true;
            this.LB_Preview.HorizontalScrollbar = true;
            this.LB_Preview.Location = new System.Drawing.Point(313, 12);
            this.LB_Preview.Name = "LB_Preview";
            this.LB_Preview.Size = new System.Drawing.Size(537, 524);
            this.LB_Preview.TabIndex = 1;
            // 
            // L_NbLigne
            // 
            this.L_NbLigne.AutoSize = true;
            this.L_NbLigne.Location = new System.Drawing.Point(313, 539);
            this.L_NbLigne.Name = "L_NbLigne";
            this.L_NbLigne.Size = new System.Drawing.Size(0, 13);
            this.L_NbLigne.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 562);
            this.Controls.Add(this.L_NbLigne);
            this.Controls.Add(this.LB_Preview);
            this.Controls.Add(this.TW_Explorer);
            this.Name = "Form1";
            this.Text = "NiakExplorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TW_Explorer;
        private System.Windows.Forms.ListBox LB_Preview;
        private System.Windows.Forms.Label L_NbLigne;

    }
}

