using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using WebApplication1.Controllers;

namespace WebApplication1.Hubs
{
    public class ValuesHub : Hub
    {
        private readonly ValuesController values;

        public ValuesHub(ValuesController values)
        {
            this.values = values;
        }

        public override Task OnConnectedAsync()
        {
            return Clients.Caller.SendAsync("values", values.Get());
        }
    }
}
