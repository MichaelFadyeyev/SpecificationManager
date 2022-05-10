using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationManager.Formatting
{
    public class WorksheetFormatter
    {
        public static int[] ColumnWitdh = new int[]  { 5, 20, 70, 10, 10 };

        public static string[] HeaderText = new string[]
        {
        "Поз.",
        "Артикул",
        "Найменування",
        "Кількість",
        "Одиниці виміру"
        };

        static int startRow = 12;
        public static int StartRow 
        {
            get => startRow;
            set { startRow = value; }
        }

        static int startColumn = 1;
        public static int StartColumn
        {
            get => startColumn;
            set { startColumn = StartColumn; }
        }

        static int columnsRead = 5;
        public static int ColumnsRead
        {
            get => columnsRead;
            set { columnsRead = ColumnsRead; }
        }

        static int headerRowHeight = 29;
        public static int HeaderRowHeight
        {
            get => headerRowHeight;
            set { headerRowHeight = HeaderRowHeight; }
        }

        static int normalRowHeight = 29;
        public static int NormalRowHeight
        {
            get => normalRowHeight;
            set { normalRowHeight = NormalRowHeight; }
        }

    }
}
