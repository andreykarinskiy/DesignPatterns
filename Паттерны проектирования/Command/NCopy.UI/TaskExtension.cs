using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCopy.UI
{
    public static class TaskExtension
    {
        public static void RunSynchronous(this Task task)
        {
            var awaiter = task.GetAwaiter();
            awaiter.GetResult();
        }
    }
}
