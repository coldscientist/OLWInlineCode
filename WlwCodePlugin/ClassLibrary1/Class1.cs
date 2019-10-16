using System.Windows.Forms;
using Schroeter.PhotoTagStudio.Gui;
using OpenLiveWriter.Api;

namespace ClassLibrary1
{
    [WriterPlugin("{52D29C0E-49E6-4353-B58C-458F86CA1E2B}", "Inline Code Plugin")]
    [InsertableContentSource("Inline Code")]
    public class WlwInlineCodePlugin : ContentSource
    {
        public override DialogResult CreateContent(IWin32Window dialogOwner, ref string newContent)
        {
            InputBox box = new InputBox("Insert inline code", "Insert the following in a <code> block:","");
            DialogResult result = box.ShowDialog(dialogOwner);

            if (result == DialogResult.OK)
                newContent = "<code>" + box.Input + "</code> ";
            
            return result;
        }
    }
}
