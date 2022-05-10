using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using SpecificationManager.Configuration;

namespace SpecificationManager.Services
{
    public static class FileDialogService
    {
        public static string OpenFile(string fileExtension)
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
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return default;
        }

        public static string SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файли XML (*.xml)|*.xml";
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
