using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometryLibrary
{
    public class StatusManager
    {
        private static StatusManager statusManager = null;
        
        public static StatusManager Instance
        {
            get
            {
                if (statusManager == null)
                {
                    statusManager = new StatusManager();
                }
                return statusManager;
            }
        }
        /// <summary>
        /// Cherche tous les messages 
        /// </summary>
        public event EventHandler<StatusMessageEventArgs> StatusMessageChanged;

        private StatusManager()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="statusMessage"></param>
        public void SetStatus(string statusMessage)
        {
            if (statusMessage == null) return;

            if (StatusMessageChanged != null) StatusMessageChanged(this, new StatusMessageEventArgs(statusMessage));

        }
    }
}
