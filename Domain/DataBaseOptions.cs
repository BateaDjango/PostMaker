using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class DataBaseOptions
    {
#if DEBUG
        public const string DatabaseConnectionString = @"Data Source=DESKTOP-OSPCKIR;Initial Catalog=PostMaker;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
#endif
#if RELEASE
        public const string DatabaseConnectionString = @"";
#endif
    }
}
