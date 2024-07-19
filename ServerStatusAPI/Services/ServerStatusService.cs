using ServerStatusAPI.Models;
using System.Diagnostics;


namespace ServerStatusAPI.Services
{
    public class ServerStatusService
    {
        public ServerStatus GetServerStatus()
        {
            var status = new ServerStatus();
            var currentProcess = Process.GetCurrentProcess();
            var memoryUsage = currentProcess.WorkingSet64;

            if (memoryUsage == 0)
            {
                status.Status = "Apagado";
            }
            else
            {
                status.Status = "En Ejecución";
                status.MemoryUsage = memoryUsage;
            }

            return status;
        }
    }
}
