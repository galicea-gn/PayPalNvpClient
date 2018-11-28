using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PayPalNvpClient.Helpers
{
    [AttributeUsage(AttributeTargets.All)]
    public class RequiredNameValuePairAttribute : Attribute
    {
    }
}
