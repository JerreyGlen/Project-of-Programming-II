using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometryLibrary
{
    public class StatusMessageEventArgs
    {
        public string Message { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public StatusMessageEventArgs(string message)
        {
            Message = message;
        }
    }
}
