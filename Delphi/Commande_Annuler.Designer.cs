
namespace Delphi
{
    partial class Commande_Annuler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_remove_commande = new System.Windows.Forms.Button();
            this.lbl_dpn = new System.Windows.Forms.Label();
            this.txt_dpn = new System.Windows.Forms.TextBox();
            this.lnk_menu = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_remove_commande
            // 
            this.btn_remove_commande.Location = new System.Drawing.Point(92, 153);
            this.btn_remove_commande.Name = "btn_remove_commande";
            this.btn_remove_commande.Size = new System.Drawing.Size(150, 30);
            this.btn_remove_commande.TabIndex = 0;
            this.btn_remove_commande.Text = "Annuler commande";
            this.btn_remove_commande.UseVisualStyleBackColor = true;
            this.btn_remove_commande.Click += new System.EventHandler(this.btn_remove_commande_Click);
            // 
            // lbl_dpn
            // 
            this.lbl_dpn.AutoSize = true;
            this.lbl_dpn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dpn.Location = new System.Drawing.Point(73, 54);
            this.lbl_dpn.Name = "lbl_dpn";
            this.lbl_dpn.Size = new System.Drawing.Size(42, 21);
            this.lbl_dpn.TabIndex = 1;
            this.lbl_dpn.Text = "DPN";
            // 
            // txt_dpn
            // 
            this.txt_dpn.Location = new System.Drawing.Point(77, 82);
            this.txt_dpn.Name = "txt_dpn";
            this.txt_dpn.Size = new System.Drawing.Size(180, 23);
            this.txt_dpn.TabIndex = 2;
            // 
            // lnk_menu
            // 
            this.lnk_menu.AutoSize = true;
            this.lnk_menu.Location = new System.Drawing.Point(148, 199);
            this.lnk_menu.Name = "lnk_menu";
            this.lnk_menu.Size = new System.Drawing.Size(38, 15);
            this.lnk_menu.TabIndex = 9;
            this.lnk_menu.TabStop = true;
            this.lnk_menu.Text = "Menu";
            this.lnk_menu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_menu_LinkClicked);
            // 
            // Commande_Annuler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 236);
            this.Controls.Add(this.lnk_menu);
            this.Controls.Add(this.txt_dpn);
            this.Controls.Add(this.lbl_dpn);
            this.Controls.Add(this.btn_remove_commande);
            this.Name = "Commande_Annuler";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Annuler commande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_remove_commande;
        private System.Windows.Forms.Label lbl_dpn;
        private System.Windows.Forms.TextBox txt_dpn;
        private System.Windows.Forms.LinkLabel lnk_menu;
    }
}