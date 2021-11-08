using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingADatabase.Objects
{
    public class Report
    {
        private List<string> ColumnNames;
        private List<List<string>> Rows;

        public Report(List<string> columnNames, List<List<string>> rows)
        {
            ColumnNames = columnNames;
            Rows = rows;
        }

        public List<string> ColumnNames1 { get => ColumnNames; set => ColumnNames = value; }
        public List<List<string>> Rows1 { get => Rows; set => Rows = value; }
    }
}
