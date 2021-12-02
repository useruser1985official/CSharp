/*
* Uso:
* CriptSenha.encripta("String de senha", "MD5");
* Ele retorna uma string com o hash da string passada no primeiro parâmetro.
* No segundo parâmetro, pode ser MD5, SHA-1 ou SHA-256.
*/

using System;
using System.Text;
using System.Security.Cryptography;

namespace Utilitarios {
    class CriptSenha {
        // Inclua System.Text e System.Security.Cryptography
        public static string encripta(string valor, string tipo) {
            string hash;

            if(tipo.Equals("SHA-1")) {
                SHA1 dados = new SHA1CryptoServiceProvider();
    
                hash = BitConverter.ToString(dados.ComputeHash(Encoding.UTF8.GetBytes(valor))).Replace("-", string.Empty).ToLower();
            }
            else if(tipo.Equals("SHA-256")) {
	        SHA256 dados = new SHA256CryptoServiceProvider();

	        hash = BitConverter.ToString(dados.ComputeHash(Encoding.UTF8.GetBytes(valor))).Replace("-", string.Empty).ToLower();    
	    }
	    else {
	        MD5 dados = new MD5CryptoServiceProvider();

	        hash = BitConverter.ToString(dados.ComputeHash(Encoding.UTF8.GetBytes(valor))).Replace("-", string.Empty).ToLower();
	    } 
	    
            return hash;
        }
    }
}