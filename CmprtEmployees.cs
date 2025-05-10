using System;
using System.Collections.Generic;

namespace CurseWork
{
    internal class CmprtEmployeesByName : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            if (x == null || y == null) return 0;
            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }
    }
    internal class CmprtEmployeesById : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            if (x == null || y == null) return 0;
            return string.Compare(x.Id, y.Id, StringComparison.Ordinal);
        }
    }
}
