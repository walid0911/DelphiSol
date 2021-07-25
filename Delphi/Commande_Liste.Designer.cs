
namespace Delphi
{
    partial class Commande_Liste
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab = new System.Windows.Forms.TabControl();
            this.tab_commande = new System.Windows.Forms.TabPage();
            this.dgv_commande = new System.Windows.Forms.DataGridView();
            this.DPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_liv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure_liv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_livraison = new System.Windows.Forms.TabPage();
            this.tab_historique = new System.Windows.Forms.TabPage();
            this.lnk_menu = new System.Windows.Forms.LinkLabel();
            this.dgv_livraison = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_historique = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab.SuspendLayout();
            this.tab_commande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commande)).BeginInit();
            this.tab_livraison.SuspendLayout();
            this.tab_historique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livraison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historique)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tab_commande);
            this.tab.Controls.Add(this.tab_livraison);
            this.tab.Controls.Add(this.tab_historique);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(776, 426);
            this.tab.TabIndex = 0;
            // 
            // tab_commande
            // 
            this.tab_commande.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tab_commande.Controls.Add(this.dgv_commande);
            this.tab_commande.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tab_commande.Location = new System.Drawing.Point(4, 24);
            this.tab_commande.Name = "tab_commande";
            this.tab_commande.Padding = new System.Windows.Forms.Padding(3);
            this.tab_commande.Size = new System.Drawing.Size(768, 398);
            this.tab_commande.TabIndex = 0;
            this.tab_commande.Text = "Commandes";
            this.tab_commande.UseVisualStyleBackColor = true;
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
            this.dgv_commande.Location = new System.Drawing.Point(0, 0);
            this.dgv_commande.Name = "dgv_commande";
            this.dgv_commande.ReadOnly = true;
            this.dgv_commande.RowHeadersWidth = 4;
            this.dgv_commande.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_commande.RowTemplate.Height = 25;
            this.dgv_commande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_commande.Size = new System.Drawing.Size(768, 398);
            this.dgv_commande.TabIndex = 0;
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
            // tab_livraison
            // 
            this.tab_livraison.BackColor = System.Drawing.Color.White;
            this.tab_livraison.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tab_livraison.Controls.Add(this.dgv_livraison);
            this.tab_livraison.Location = new System.Drawing.Point(4, 24);
            this.tab_livraison.Name = "tab_livraison";
            this.tab_livraison.Padding = new System.Windows.Forms.Padding(3);
            this.tab_livraison.Size = new System.Drawing.Size(768, 398);
            this.tab_livraison.TabIndex = 1;
            this.tab_livraison.Text = "Livraisons";
            // 
            // tab_historique
            // 
            this.tab_historique.Controls.Add(this.dgv_historique);
            this.tab_historique.Location = new System.Drawing.Point(4, 24);
            this.tab_historique.Name = "tab_historique";
            this.tab_historique.Size = new System.Drawing.Size(768, 398);
            this.tab_historique.TabIndex = 2;
            this.tab_historique.Text = "Historique";
            this.tab_historique.UseVisualStyleBackColor = true;
            // 
            // lnk_menu
            // 
            this.lnk_menu.AutoSize = true;
            this.lnk_menu.Location = new System.Drawing.Point(745, 17);
            this.lnk_menu.Name = "lnk_menu";
            this.lnk_menu.Size = new System.Drawing.Size(38, 15);
            this.lnk_menu.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgv_livraison.Location = new System.Drawing.Point(0, 0);
            this.dgv_livraison.Name = "dgv_livraison";
            this.dgv_livraison.ReadOnly = true;
            this.dgv_livraison.RowHeadersWidth = 4;
            this.dgv_livraison.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_livraison.RowTemplate.Height = 25;
            this.dgv_livraison.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_livraison.Size = new System.Drawing.Size(768, 398);
            this.dgv_livraison.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DPN";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn1.HeaderText = "DPN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date_cmd";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn2.HeaderText = "Date_cmd";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "heure_cmd";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn3.HeaderText = "Heure_cmd";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "date_liv";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn4.HeaderText = "Date_liv";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "heure_liv";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn5.HeaderText = "Heure_liv";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "type_comp";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn6.HeaderText = "Type_comp";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "statut";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn7.HeaderText = "Statut";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dgv_historique
            // 
            this.dgv_historique.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_historique.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_historique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historique.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dgv_historique.Location = new System.Drawing.Point(0, 0);
            this.dgv_historique.Name = "dgv_historique";
            this.dgv_historique.ReadOnly = true;
            this.dgv_historique.RowHeadersWidth = 4;
            this.dgv_historique.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_historique.RowTemplate.Height = 25;
            this.dgv_historique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_historique.Size = new System.Drawing.Size(768, 398);
            this.dgv_historique.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DPN";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn8.HeaderText = "DPN";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "date_cmd";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn9.HeaderText = "Date_cmd";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "heure_cmd";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn10.HeaderText = "Heure_cmd";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "date_liv";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn11.HeaderText = "Date_liv";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "heure_liv";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn12.HeaderText = "Heure_liv";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "type_comp";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn13.HeaderText = "Type_comp";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "statut";
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn14.HeaderText = "Statut";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // Commande_Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnk_menu);
            this.Controls.Add(this.tab);
            this.Name = "Commande_Liste";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des commandes";
            this.Load += new System.EventHandler(this.Commande_Liste_Load);
            this.tab.ResumeLayout(false);
            this.tab_commande.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commande)).EndInit();
            this.tab_livraison.ResumeLayout(false);
            this.tab_historique.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livraison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tab_commande;
        private System.Windows.Forms.TabPage tab_livraison;
        private System.Windows.Forms.TabPage tab_historique;
        private System.Windows.Forms.DataGridView dgv_commande;
        private System.Windows.Forms.LinkLabel lnk_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_liv;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure_liv;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
        private System.Windows.Forms.DataGridView dgv_livraison;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dgv_historique;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}