using System.Windows.Forms;

namespace SpecificationManager.Services
{
    public static class FileDialogService
    {
        public static string[] OpenFile(string fileExtension, bool mode)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            switch (fileExtension)
            {
                case "xls":
                    openFileDialog.Filter = "Файли Excel (*.xlsx)|*.xlsx|Файли Excel 2007 (*.xls)|*.xls";
                    break;
                case "project":
                    openFileDialog.Filter = "Файли ВіярPRO (*.project)|*.project";
                    break;
                case "xml":
                    openFileDialog.Filter = "Файли XML (*.xml)|*.xml";
                    break;
            }
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = mode;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileNames;
            }
            return default;
        }

        public static string SaveFile(string fileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файли XML (*.xml)|*.xml";
            saveFileDialog.FileName = fileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            return default;
        } 
        
        public static string OpenDirectory()
        {  
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                return folderBrowser.SelectedPath;
            }
            return default;
        }
    }
}
