using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SignalRProblem.Controllers;

namespace SignalRProblem.Hubs
{
    public class ValuesHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            return Clients.Caller.SendAsync("values", Values.Get());
        }
    }
}
