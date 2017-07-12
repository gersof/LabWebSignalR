using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabWebSignalR.Hubs
{
    public class NotifyHub : Hub
    {
        public void NotifyDateTime(string dtstring)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<NotifyHub>();
            context.Clients.All.ClientUpdateDateTime( dtstring);
        }
    }
}