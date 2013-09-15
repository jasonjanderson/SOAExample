using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.DataContracts
{
    public sealed class Namespace
    {
        public const string RootNamespace = "http://directsupply.com/services";
        public const string CartNamespace = RootNamespace + "/cart";
        public const string ProductNamespace = RootNamespace + "/product";
    }
}
