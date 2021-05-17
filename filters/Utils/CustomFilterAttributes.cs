using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Net;

namespace filters.Utils
{
    public class CustomFilterAttributes : ResultFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var result = context.Result;
            if (result is PageResult)
            {
                var page = ((PageResult)result);
                IPAddress remoteIpAddress = context.HttpContext.Connection.RemoteIpAddress;
                string ipv4adress = "";
                if (remoteIpAddress != null)
                {
                    if (remoteIpAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                    {
                        remoteIpAddress = Dns.GetHostEntry(remoteIpAddress).AddressList
                .First(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                    }
                    ipv4adress = remoteIpAddress.ToString();
                }
                page.ViewData["filterMessage"] = ipv4adress;
            }

        }

    }
}