using Domain.Common;
using System;

namespace Application
{
    class ForTest : AuditableBaseEntity
    {
        public void Print()
        {
            ForTest forTest = new ForTest();
            forTest.ID = 1010;
        }
    }
}
