using System;

namespace SRPI {
    internal static class SRPI {

        //Ponto de entrada principal para o aplicativo.

        [STAThread]

        static void Main() {

            //iniciar componenete Controller
            Controller controller = new Controller();
            controller.IniciarPrograma();

        }
    }
}