using System;

namespace SRPI {
	public class View {
		
		public void ApresentarLogin() {
			
			//apresenta a janela de login
			Login login = new Login();
			login.ShowDialog();
        }

		public void ApresentarRelatorio() { 
            
            //apresenta a janela de relatorio
            Relatorio relatorio = new Relatorio();
            relatorio.ShowDialog();
        }

	}
}