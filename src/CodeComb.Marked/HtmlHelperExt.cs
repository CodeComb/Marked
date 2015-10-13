using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeComb.Marked;

namespace Microsoft.AspNet.Mvc.Rendering
{
    public static class HtmlHelperExt
    {
        public static HtmlString Marked(this IHtmlHelper self, string MarkdownContent)
        {
            var marked = new CodeComb.Marked._Marked();
            return new HtmlString(marked.Parse(MarkdownContent));
        }
    }
}
