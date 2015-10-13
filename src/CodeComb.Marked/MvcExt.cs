using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNet.Mvc
{
    public static class Marked
    {
        private static CodeComb.Marked._Marked marked = new CodeComb.Marked._Marked();
        public static string Parse(string MarkdownContent)
        {
            return marked.Parse(MarkdownContent);
        }
    }
}
