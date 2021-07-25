
namespace Delphi
{
    partial class Commande_Valider
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_dpn = new System.Windows.Forms.Label();
            this.txt_dpn = new System.Windows.Forms.TextBox();
            this.btn_validate = new System.Windows.Forms.Button();
            this.lnk_menu = new System.Windows.Forms.LinkLabel();
            this.dgv_livraison = new System.Windows.Forms.DataGridView();
            this.DPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_liv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure_liv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livraison)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dpn
            // 
            this.lbl_dpn.AutoSize = true;
            this.lbl_dpn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dpn.Location = new System.Drawing.Point(321, 49);
            this.lbl_dpn.Name = "lbl_dpn";
            this.lbl_dpn.Size = new System.Drawing.Size(42, 21);
            this.lbl_dpn.TabIndex = 6;
            this.lbl_dpn.Text = "DPN";
            // 
            // txt_dpn
            // 
            this.txt_dpn.Location = new System.Drawing.Point(325, 78);
            this.txt_dpn.Name = "txt_dpn";
            this.txt_dpn.Size = new System.Drawing.Size(150, 23);
            this.txt_dpn.TabIndex = 5;
            this.txt_dpn.TextChanged += new System.EventHandler(this.txt_dpn_TextChanged);
            // 
            // btn_validate
            // 
            this.btn_validate.Location = new System.Drawing.Point(325, 281);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(150, 30);
            this.btn_validate.TabIndex = 4;
            this.btn_validate.Text = "Valider livraison";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // lnk_menu
            // 
            this.lnk_menu.AutoSize = true;
            this.lnk_menu.Location = new System.Drawing.Point(750, 55);
            this.lnk_menu.Name = "lnk_menu";
            this.lnk_menu.Size = new System.Drawing.Size(38, 15);
            this.lnk_menu.TabIndex = 8;
            this.lnk_menu.TabStop = true;
            this.lnk_menu.Text = "Menu";
            this.lnk_menu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_menu_LinkClicked);
            // 
            // dgv_livraison
            // 
            this.dgv_livraison.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_livraison.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_livraison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_livraison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DPN,
            this.date_cmd,
            this.heure_cmd,
            this.date_liv,
            this.heure_liv,
            this.type_comp,
            this.statut});
            this.dgv_livraison.Location = new System.Drawing.Point(16, 108);
            this.dgv_livraison.Name = "dgv_livraison";
            this.dgv_livraison.ReadOnly = true;
            this.dgv_livraison.RowHeadersWidth = 4;
            this.dgv_livraison.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_livraison.RowTemplate.Height = 25;
            this.dgv_livraison.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_livraison.Size = new System.Drawing.Size(768, 144);
            this.dgv_livraison.TabIndex = 9;
            // 
            // DPN
            // 
            this.DPN.DataPropertyName = "DPN";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.DPN.DefaultCellStyle = dataGridViewCellStyle15;
            this.DPN.HeaderText = "DPN";
            this.DPN.Name = "DPN";
            this.DPN.ReadOnly = true;
            // 
            // date_cmd
            // 
            this.date_cmd.DataPropertyName = "date_cmd";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.date_cmd.DefaultCellStyle = dataGridViewCellStyle16;
            this.date_cmd.HeaderText = "Date_cmd";
            this.date_cmd.Name = "date_cmd";
            this.date_cmd.ReadOnly = true;
            // 
            // heure_cmd
            // 
            this.heure_cmd.DataPropertyName = "heure_cmd";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.heure_cmd.DefaultCellStyle = dataGridViewCellStyle17;
            this.heure_cmd.HeaderText = "Heure_cmd";
            this.heure_cmd.Name = "heure_cmd";
            this.heure_cmd.ReadOnly = true;
            // 
            // date_liv
            // 
            this.date_liv.DataPropertyName = "date_liv";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.date_liv.DefaultCellStyle = dataGridViewCellStyle18;
            this.date_liv.HeaderText = "Date_liv";
            this.date_liv.Name = "date_liv";
            this.date_liv.ReadOnly = true;
            // 
            // heure_liv
            // 
            this.heure_liv.DataPropertyName = "heure_liv";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.heure_liv.DefaultCellStyle = dataGridViewCellStyle19;
            this.heure_liv.HeaderText = "Heure_liv";
            this.heure_liv.Name = "heure_liv";
            this.heure_liv.ReadOnly = true;
            // 
            // type_comp
            // 
            this.type_comp.DataPropertyName = "type_comp";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.type_comp.DefaultCellStyle = dataGridViewCellStyle20;
            this.type_comp.HeaderText = "Type_comp";
            this.type_comp.Name = "type_comp";
            this.type_comp.ReadOnly = true;
            // 
            // statut
            // 
            this.statut.DataPropertyName = "statut";
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.statut.DefaultCellStyle = dataGridViewCellStyle21;
            this.statut.HeaderText = "Statut";
            this.statut.Name = "statut";
            this.statut.ReadOnly = true;
            // 
            // Commande_Valider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.dgv_livraison);
            this.Controls.Add(this.lnk_menu);
            this.Controls.Add(this.lbl_dpn);
            this.Controls.Add(this.txt_dpn);
            this.Controls.Add(this.btn_validate);
            this.Name = "Commande_Valider";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valider livraison";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livraison)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_dpn;
        private System.Windows.Forms.TextBox txt_dpn;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.LinkLabel lnk_menu;
        private System.Windows.Forms.DataGridView dgv_livraison;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_liv;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure_liv;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
    }
}