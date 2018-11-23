namespace facture
{
    partial class CrudFacture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
			this.num = new DevExpress.XtraEditors.TextEdit();
			this.NomC = new DevExpress.XtraEditors.TextEdit();
			this.Date = new DevExpress.XtraEditors.DateEdit();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.Numero = new DevExpress.XtraEditors.LabelControl();
			this.NomClient = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			((System.ComponentModel.ISupportInitialize)(this.num.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NomC.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Date.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Date.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// num
			// 
			this.num.Location = new System.Drawing.Point(189, 179);
			this.num.Name = "num";
			this.num.Size = new System.Drawing.Size(164, 20);
			this.num.TabIndex = 1;
			// 
			// NomC
			// 
			this.NomC.Location = new System.Drawing.Point(189, 210);
			this.NomC.Name = "NomC";
			this.NomC.Size = new System.Drawing.Size(164, 20);
			this.NomC.TabIndex = 2;
			// 
			// Date
			// 
			this.Date.EditValue = new System.DateTime(2018, 11, 23, 0, 0, 0, 0);
			this.Date.Location = new System.Drawing.Point(189, 236);
			this.Date.Name = "Date";
			this.Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Date.Size = new System.Drawing.Size(164, 20);
			this.Date.TabIndex = 3;
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(12, 306);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(496, 151);
			this.gridControl1.TabIndex = 4;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(507, 306);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(32, 23);
			this.simpleButton1.TabIndex = 5;
			this.simpleButton1.Text = "+";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// Numero
			// 
			this.Numero.Location = new System.Drawing.Point(97, 182);
			this.Numero.Name = "Numero";
			this.Numero.Size = new System.Drawing.Size(37, 13);
			this.Numero.TabIndex = 6;
			this.Numero.Text = "Numero";
			// 
			// NomClient
			// 
			this.NomClient.Location = new System.Drawing.Point(97, 213);
			this.NomClient.Name = "NomClient";
			this.NomClient.Size = new System.Drawing.Size(48, 13);
			this.NomClient.TabIndex = 7;
			this.NomClient.Text = "NomClient";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(97, 243);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(23, 13);
			this.labelControl3.TabIndex = 8;
			this.labelControl3.Text = "Date";
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(507, 329);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(32, 23);
			this.simpleButton2.TabIndex = 10;
			this.simpleButton2.Text = "-";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 10;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
			this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
			this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl1.Size = new System.Drawing.Size(539, 130);
			this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "Ajouter";
			this.barButtonItem2.Id = 2;
			this.barButtonItem2.ImageOptions.ImageUri.Uri = "Add";
			this.barButtonItem2.Name = "barButtonItem2";
			this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
			// 
			// barButtonItem3
			// 
			this.barButtonItem3.Caption = "Save And Close";
			this.barButtonItem3.Id = 3;
			this.barButtonItem3.ImageOptions.ImageUri.Uri = "SaveAndClose";
			this.barButtonItem3.Name = "barButtonItem3";
			// 
			// barButtonItem4
			// 
			this.barButtonItem4.Caption = "Save And New";
			this.barButtonItem4.Id = 4;
			this.barButtonItem4.ImageOptions.ImageUri.Uri = "SaveAndNew";
			this.barButtonItem4.Name = "barButtonItem4";
			// 
			// barButtonItem5
			// 
			this.barButtonItem5.Caption = "Reset Changes";
			this.barButtonItem5.Id = 5;
			this.barButtonItem5.ImageOptions.ImageUri.Uri = "Reset";
			this.barButtonItem5.Name = "barButtonItem5";
			this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			// 
			// barButtonItem6
			// 
			this.barButtonItem6.Caption = "Delete";
			this.barButtonItem6.Id = 6;
			this.barButtonItem6.ImageOptions.ImageUri.Uri = "Delete";
			this.barButtonItem6.Name = "barButtonItem6";
			// 
			// barButtonItem7
			// 
			this.barButtonItem7.Caption = "Close";
			this.barButtonItem7.Id = 7;
			this.barButtonItem7.ImageOptions.ImageUri.Uri = "Close";
			this.barButtonItem7.Name = "barButtonItem7";
			// 
			// ribbonPage2
			// 
			this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
			this.ribbonPage2.MergeOrder = 0;
			this.ribbonPage2.Name = "ribbonPage2";
			this.ribbonPage2.Text = "Home";
			// 
			// ribbonPageGroup6
			// 
			this.ribbonPageGroup6.AllowTextClipping = false;
			this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem2);
			this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem7);
			this.ribbonPageGroup6.Name = "ribbonPageGroup6";
			this.ribbonPageGroup6.ShowCaptionButton = false;
			this.ribbonPageGroup6.Text = "Tasks";
			// 
			// CrudFacture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(539, 461);
			this.Controls.Add(this.simpleButton2);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.NomClient);
			this.Controls.Add(this.Numero);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.Date);
			this.Controls.Add(this.NomC);
			this.Controls.Add(this.num);
			this.Controls.Add(this.ribbonControl1);
			this.Name = "CrudFacture";
			this.Ribbon = this.ribbonControl1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.num.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NomC.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Date.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Date.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.LabelControl NomClient;
        public DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        public DevExpress.XtraEditors.TextEdit num;
        public DevExpress.XtraEditors.TextEdit NomC;
        public DevExpress.XtraEditors.DateEdit Date;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraEditors.LabelControl Numero;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraBars.BarButtonItem barButtonItem3;
		private DevExpress.XtraBars.BarButtonItem barButtonItem4;
		private DevExpress.XtraBars.BarButtonItem barButtonItem5;
		private DevExpress.XtraBars.BarButtonItem barButtonItem6;
		private DevExpress.XtraBars.BarButtonItem barButtonItem7;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
	}
}