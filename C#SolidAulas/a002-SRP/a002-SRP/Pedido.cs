using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a002_SRP
{
    class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }
        private ILogger InfoLogger;
        private EnviarEmail EnviaEmail;

        public void InlcuirPedido()
        {
            try
            {
                InfoLogger.Info("Incluindo um pedido");
                EnviaEmail.EmailTo = "Emailto@xyz.com";
                EnviaEmail.EmailFrom = "EmailFrom@xtz.com";
                EnviaEmail.EmailBody = "sssdf UM";
                EnviaEmail.EmailSubject = "SRP";
                EnviaEmail.Enviar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ExcluirPedido()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
