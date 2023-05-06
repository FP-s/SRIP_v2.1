using System;

namespace SRPI {
	public class Model { 

		public bool VerificarLogin(string utilizador, string password) { 

			//verificar se o utilizador e a password estão corretos (futuramente podemos adicionar uma base de dados para essa verificação)
			try {

				if(utilizador == "admin" && password == "12345") {
                    
                    return true;
                }

                else {

                    MessageBox.Show("O nome e a password não coincidem.",
                                    "ERRO!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    return false;

                }
			} 
            
            catch (Exception ex) {

                MessageBox.Show(ex.Message,
                                "ERRO!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            return false;
        }
	
        public bool DadosValidados(string data)
        {
            //data não pode ser vazia nem superior à data atual
            //falta implementar
            return true;
        }
    }
}