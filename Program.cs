using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public  void createdatatable()
        {
            DataTable DtAll = new DataTable();
            DataColumn dc1 = new DataColumn("ROLL_PLAN_NO", Type.GetType("System.String"));
            DataColumn dc2 = new DataColumn("MAT_NO", Type.GetType("System.String"));
            
            DtAll.Columns.Add(dc1);
            DtAll.Columns.Add(dc2);

            DataRow dr = DtAll.NewRow();
            dr["ROLL_PLAN_NO"] = covalues[0];
            dr["MAT_NO"] = covalues[1];
            DtAll.Rows.Add(dr);
        }

    }
}
