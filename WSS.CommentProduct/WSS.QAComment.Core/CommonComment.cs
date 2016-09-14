using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.QAComment.Core
{
   public static class CommonComment
   {
       public static string GetQueueAS()
       {
           return Config.QueueWaitAsComment;
       }
    }
}
