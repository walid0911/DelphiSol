
namespace Delphi
{
    partial class Commande_placer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_add_order = new System.Windows.Forms.Button();
            this.txt_dpn = new System.Windows.Forms.TextBox();
            this.lbl_dpn = new System.Windows.Forms.Label();
            this.lnk_menu = new System.Windows.Forms.LinkLabel();
            this.dgv_commande = new System.Windows.Forms.DataGridView();
            this.DPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_liv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure_liv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commande)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_order
            // 
            this.btn_add_order.Location = new System.Drawing.Point(325, 272);
            this.btn_add_order.Name = "btn_add_order";
            this.btn_add_order.Size = new System.Drawing.Size(150, 30);
            this.btn_add_order.TabIndex = 0;
            this.btn_add_order.Text = "Placer commande";
            this.btn_add_order.UseVisualStyleBackColor = true;
            this.btn_add_order.Click += new System.EventHandler(this.btn_add_order_Click);
            // 
            // txt_dpn
            // 
            this.txt_dpn.Location = new System.Drawing.Point(325, 69);
            this.txt_dpn.Name = "txt_dpn";
            this.txt_dpn.Size = new System.Drawing.Size(150, 23);
            this.txt_dpn.TabIndex = 1;
            this.txt_dpn.TextChanged += new System.EventHandler(this.txt_dpn_TextChanged);
            // 
            // lbl_dpn
            // 
            this.lbl_dpn.AutoSize = true;
            this.lbl_dpn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dpn.Location = new System.Drawing.Point(321, 40);
            this.lbl_dpn.Name = "lbl_dpn";
            this.lbl_dpn.Size = new System.Drawing.Size(42, 21);
            this.lbl_dpn.TabIndex = 2;
            this.lbl_dpn.Text = "DPN";
            // 
            // lnk_menu
            // 
            this.lnk_menu.AutoSize = true;
            this.lnk_menu.Location = new System.Drawing.Point(750, 46);
            this.lnk_menu.Name = "lnk_menu";
            this.lnk_menu.Size = new System.Drawing.Size(38, 15);
            this.lnk_menu.TabIndex = 4;
            this.lnk_menu.TabStop = true;
            this.lnk_menu.Text = "Menu";
            this.lnk_menu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_menu_LinkClicked);
            // 
            // dgv_commande
            // 
            this.dgv_commande.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_commande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_commande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_commande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DPN,
            this.date_cmd,
            this.heure_cmd,
            this.date_liv,
            this.heure_liv,
            this.type_comp,
            this.statut});
            this.dgv_commande.Location = new System.Drawing.Point(16, 108);
            this.dgv_commande.Name = "dgv_commande";
            this.dgv_commande.ReadOnly = true;
            this.dgv_commande.RowHeadersWidth = 4;
            this.dgv_commande.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_commande.RowTemplate.Height = 25;
            this.dgv_commande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_commande.Size = new System.Drawing.Size(768, 144);
            this.dgv_commande.TabIndex = 5;
            // 
            // DPN
            // 
            this.DPN.DataPropertyName = "DPN";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DPN.DefaultCellStyle = dataGridViewCellStyle1;
            this.DPN.HeaderText = "DPN";
            this.DPN.Name = "DPN";
            this.DPN.ReadOnly = true;
            // 
            // date_cmd
            // 
            this.date_cmd.DataPropertyName = "date_cmd";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.date_cmd.DefaultCellStyle = dataGridViewCellStyle2;
            this.date_cmd.HeaderText = "Date_cmd";
            this.date_cmd.Name = "date_cmd";
            this.date_cmd.ReadOnly = true;
            // 
            // heure_cmd
            // 
            this.heure_cmd.DataPropertyName = "heure_cmd";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.heure_cmd.DefaultCellStyle = dataGridViewCellStyle3;
            this.heure_cmd.HeaderText = "Heure_cmd";
            this.heure_cmd.Name = "heure_cmd";
            this.heure_cmd.ReadOnly = true;
            // 
            // date_liv
            // 
            this.date_liv.DataPropertyName = "date_liv";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.date_liv.DefaultCellStyle = dataGridViewCellStyle4;
            this.date_liv.HeaderText = "Date_liv";
            this.date_liv.Name = "date_liv";
            this.date_liv.ReadOnly = true;
            // 
            // heure_liv
            // 
            this.heure_liv.DataPropertyName = "heure_liv";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.heure_liv.DefaultCellStyle = dataGridViewCellStyle5;
            this.heure_liv.HeaderText = "Heure_liv";
            this.heure_liv.Name = "heure_liv";
            this.heure_liv.ReadOnly = true;
            // 
            // type_comp
            // 
            this.type_comp.DataPropertyName = "type_comp";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.type_comp.DefaultCellStyle = dataGridViewCellStyle6;
            this.type_comp.HeaderText = "Type_comp";
            this.type_comp.Name = "type_comp";
            this.type_comp.ReadOnly = true;
            // 
            // statut
            // 
            this.statut.DataPropertyName = "statut";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.statut.DefaultCellStyle = dataGridViewCellStyle7;
            this.statut.HeaderText = "Statut";
            this.statut.Name = "statut";
            this.statut.ReadOnly = true;
            // 
            // Commande_placer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.dgv_commande);
            this.Controls.Add(this.lnk_menu);
            this.Controls.Add(this.lbl_dpn);
            this.Controls.Add(this.txt_dpn);
            this.Controls.Add(this.btn_add_order);
            this.Name = "Commande_placer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Placer commande";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_order;
        private System.Windows.Forms.TextBox txt_dpn;
        private System.Windows.Forms.Label lbl_dpn;
        private System.Windows.Forms.LinkLabel lnk_menu;
        private System.Windows.Forms.DataGridView dgv_commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_liv;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure_liv;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
    }
}