using Payroll.Services.DummyModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Services
{
    public class PayrollService
    {
        public List<PayrollModel> Get()
        {
            return new List<PayrollModel>();
        }

        public PayrollModel Get(int id)
        {
            return new PayrollModel();
        }

        public int Add(PayrollModel staff)
        {
            return 0;
        }

        public int Update(PayrollModel staff)
        {
            return 0;
        }

        public int Delete(PayrollModel staff)
        {
            return 0;
        }
    }
}
