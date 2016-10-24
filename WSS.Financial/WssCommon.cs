using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Financial
{
    public class WssCommon
    {
        public enum ListBrandCommand
        {
            ViewInfo = 1,
            ViewItemManager = 2
        }

        public static int GetIdFromText(string text)
        {
            var id = 0;
            id = Math.Abs(GABIZ.Base.Tools.getCRC32(text.Trim().ToLower()));
            return id;
        }
    }
}
