using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Tools.Word;

namespace WordAddIn_Project
{
    public partial class WordAddinPLM_Ribbon
    {
        private void WordAddinPLM_Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void Btn_NewDocument_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void Btn_SaveDocument_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void Btn_CloseDocument_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void Btn_CheckIn_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void Btn_CheckOut_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void Btn_Freeze_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void Btn_Release_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void Btn_Obsolete_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void Btn_NewRevision_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void DocumentSelectionChange()
        {
            var App = Globals.ThisAddIn.Application;

            Document vstoDoc = Globals.Factory.GetVstoObject(App.ActiveDocument);
            vstoDoc.SelectionChange += new Microsoft.Office.Tools.Word.SelectionEventHandler(ThisDocument_SelectionChange);
        }

        void ThisDocument_SelectionChange(object sender, Microsoft.Office.Tools.Word.SelectionEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("The selection in the document has changed.");
        }

    }
}
