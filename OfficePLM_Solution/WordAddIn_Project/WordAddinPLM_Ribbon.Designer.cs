
namespace WordAddIn_Project
{
    partial class WordAddinPLM_Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public WordAddinPLM_Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.PLM = this.Factory.CreateRibbonGroup();
            this.menu1 = this.Factory.CreateRibbonMenu();
            this.Btn_NewDocument = this.Factory.CreateRibbonButton();
            this.menu2 = this.Factory.CreateRibbonMenu();
            this.Btn_CheckIn = this.Factory.CreateRibbonButton();
            this.Btn_CheckOut = this.Factory.CreateRibbonButton();
            this.menu3 = this.Factory.CreateRibbonMenu();
            this.Btn_Freeze = this.Factory.CreateRibbonButton();
            this.Btn_Release = this.Factory.CreateRibbonButton();
            this.Btn_Obsolete = this.Factory.CreateRibbonButton();
            this.Btn_NewRevision = this.Factory.CreateRibbonButton();
            this.Btn_SaveDocument = this.Factory.CreateRibbonButton();
            this.Btn_CloseDocument = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.PLM.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.PLM);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // PLM
            // 
            this.PLM.Items.Add(this.menu1);
            this.PLM.Label = "group1";
            this.PLM.Name = "PLM";
            // 
            // menu1
            // 
            this.menu1.Items.Add(this.Btn_NewDocument);
            this.menu1.Items.Add(this.menu2);
            this.menu1.Items.Add(this.menu3);
            this.menu1.Items.Add(this.Btn_SaveDocument);
            this.menu1.Items.Add(this.Btn_CloseDocument);
            this.menu1.Label = "PLM Lifecycle";
            this.menu1.Name = "menu1";
            // 
            // Btn_NewDocument
            // 
            this.Btn_NewDocument.Image = global::WordAddIn_Project.Properties.Resources.NewDocument;
            this.Btn_NewDocument.Label = "New Document";
            this.Btn_NewDocument.Name = "Btn_NewDocument";
            this.Btn_NewDocument.ShowImage = true;
            this.Btn_NewDocument.SuperTip = "New Document";
            this.Btn_NewDocument.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_NewDocument_Click);
            // 
            // menu2
            // 
            this.menu2.Image = global::WordAddIn_Project.Properties.Resources.LifeCycle;
            this.menu2.Items.Add(this.Btn_CheckIn);
            this.menu2.Items.Add(this.Btn_CheckOut);
            this.menu2.Label = "Lifecycle";
            this.menu2.Name = "menu2";
            this.menu2.ShowImage = true;
            // 
            // Btn_CheckIn
            // 
            this.Btn_CheckIn.Image = global::WordAddIn_Project.Properties.Resources.CheckIn;
            this.Btn_CheckIn.Label = "Check-In";
            this.Btn_CheckIn.Name = "Btn_CheckIn";
            this.Btn_CheckIn.ShowImage = true;
            this.Btn_CheckIn.SuperTip = "Check-In";
            this.Btn_CheckIn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_CheckIn_Click);
            // 
            // Btn_CheckOut
            // 
            this.Btn_CheckOut.Image = global::WordAddIn_Project.Properties.Resources.CheckOut;
            this.Btn_CheckOut.Label = "Check-Out";
            this.Btn_CheckOut.Name = "Btn_CheckOut";
            this.Btn_CheckOut.ShowImage = true;
            this.Btn_CheckOut.SuperTip = "Check-Out";
            this.Btn_CheckOut.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_CheckOut_Click);
            // 
            // menu3
            // 
            this.menu3.Image = global::WordAddIn_Project.Properties.Resources.Status;
            this.menu3.Items.Add(this.Btn_Freeze);
            this.menu3.Items.Add(this.Btn_Release);
            this.menu3.Items.Add(this.Btn_Obsolete);
            this.menu3.Items.Add(this.Btn_NewRevision);
            this.menu3.Label = "Status";
            this.menu3.Name = "menu3";
            this.menu3.ShowImage = true;
            // 
            // Btn_Freeze
            // 
            this.Btn_Freeze.Image = global::WordAddIn_Project.Properties.Resources.Freeze;
            this.Btn_Freeze.Label = "Freeze";
            this.Btn_Freeze.Name = "Btn_Freeze";
            this.Btn_Freeze.ShowImage = true;
            this.Btn_Freeze.SuperTip = "Freeze";
            this.Btn_Freeze.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_Freeze_Click);
            // 
            // Btn_Release
            // 
            this.Btn_Release.Image = global::WordAddIn_Project.Properties.Resources.Release;
            this.Btn_Release.Label = "Release";
            this.Btn_Release.Name = "Btn_Release";
            this.Btn_Release.ShowImage = true;
            this.Btn_Release.SuperTip = "Release";
            this.Btn_Release.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_Release_Click);
            // 
            // Btn_Obsolete
            // 
            this.Btn_Obsolete.Image = global::WordAddIn_Project.Properties.Resources.obsolete;
            this.Btn_Obsolete.Label = "Obsolete";
            this.Btn_Obsolete.Name = "Btn_Obsolete";
            this.Btn_Obsolete.ShowImage = true;
            this.Btn_Obsolete.SuperTip = "Obsolete";
            this.Btn_Obsolete.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_Obsolete_Click);
            // 
            // Btn_NewRevision
            // 
            this.Btn_NewRevision.Image = global::WordAddIn_Project.Properties.Resources.NewrRevision;
            this.Btn_NewRevision.Label = "New Revision";
            this.Btn_NewRevision.Name = "Btn_NewRevision";
            this.Btn_NewRevision.ShowImage = true;
            this.Btn_NewRevision.SuperTip = "New Revision";
            this.Btn_NewRevision.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_NewRevision_Click);
            // 
            // Btn_SaveDocument
            // 
            this.Btn_SaveDocument.Image = global::WordAddIn_Project.Properties.Resources.SaveDocument;
            this.Btn_SaveDocument.Label = "Save Document";
            this.Btn_SaveDocument.Name = "Btn_SaveDocument";
            this.Btn_SaveDocument.ShowImage = true;
            this.Btn_SaveDocument.SuperTip = "Save Document";
            this.Btn_SaveDocument.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_SaveDocument_Click);
            // 
            // Btn_CloseDocument
            // 
            this.Btn_CloseDocument.Image = global::WordAddIn_Project.Properties.Resources.CloseDocument;
            this.Btn_CloseDocument.Label = "Close Document";
            this.Btn_CloseDocument.Name = "Btn_CloseDocument";
            this.Btn_CloseDocument.ShowImage = true;
            this.Btn_CloseDocument.SuperTip = "Close Document";
            this.Btn_CloseDocument.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_CloseDocument_Click);
            // 
            // WordAddinPLM_Ribbon
            // 
            this.Name = "WordAddinPLM_Ribbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.WordAddinPLM_Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.PLM.ResumeLayout(false);
            this.PLM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup PLM;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Btn_NewDocument;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Btn_CheckIn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Btn_CheckOut;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Btn_Freeze;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Btn_Release;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Btn_Obsolete;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Btn_NewRevision;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Btn_SaveDocument;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Btn_CloseDocument;
    }

    partial class ThisRibbonCollection
    {
        internal WordAddinPLM_Ribbon WordAddinPLM_Ribbon
        {
            get { return this.GetRibbon<WordAddinPLM_Ribbon>(); }
        }
    }
}
