using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EJE.HELPER.IP
{
    public class IPHelper
    {
        public static string GetLocalIPAddress()
        {
            string localIP = "No se pudo obtener la IP";
            try
            {
                // Obtener el nombre del host (nombre de la máquina local)
                string hostName = Dns.GetHostName();
                // Obtener las direcciones IP asociadas al nombre del host
                IPAddress[] ipAddresses = Dns.GetHostAddresses(hostName);

                foreach (IPAddress ip in ipAddresses)
                {
                    // Verificar si la IP es del tipo IPv4
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                localIP = "Error al obtener IP: " + ex.Message;
            }

            return localIP;
        }
    }
}
