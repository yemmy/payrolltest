using Payroll.Services.DummyModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Services
{
    public class StaffService
    {
        public List<Staff> Get()
        {
            return new List<Staff>();
        }

        public Staff Get(int id)
        {
            return new Staff();
        }

        public int Add(Staff staff)
        {
            return 0;
        }

        public int Update(Staff staff)
        {
            return 0;
        }

        public int Delete(Staff staff)
        {
            return 0;
        }
    }
}
