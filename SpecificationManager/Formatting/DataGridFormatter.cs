using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationManager.Formatting
{
    public class DataGridFormatter
    {
        public static int[] ColumnWitdh = new int[] { 35, 100, 350, 70, 70, 70, 100 };

        static int columnsNumber = 7;
        public static int ColumnsNumber
        {
            get => columnsNumber;
            set { columnsNumber = ColumnsNumber; }
        }

        public static int FixedColumnsWidth
        {
            get => 
                43 +
                ColumnWitdh[0] + 
                ColumnWitdh[1] + 
                ColumnWitdh[3] + 
                ColumnWitdh[4] +
                ColumnWitdh[5] +
                ColumnWitdh[6];
        }

        public static string[] HeaderText = new string[]
        {
            "Поз.",
            "Артикул",
            "Найменування",
            "Кількість",
            "Одиниці виміру",
            "Код виробника",
            "Виробник"
        };

        public static string[] ColumnName = new string[]
        {
            "positionColumn",
            "articleColumn",
            "nameColumn",
            "quantityColumn",
            "unitsColumn",
            "codeColumn",
            "produserColumn"
        };


}
}
