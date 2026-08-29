using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AdvancedWebApiDotnet.Infra.Crypt
{
    public class CriptService
    {
        public string Criptografar(string textoPlano, string chave)
        {
            byte[] bytesChave = Encoding.UTF8.GetBytes(chave);
            byte[] bytesTexto = Encoding.UTF8.GetBytes(textoPlano);

            using (Aes aes = Aes.Create())
            {
                aes.Key = bytesChave;
                // O IV (Vetor de Inicialização) garante que o mesmo texto gere criptografias diferentes
                aes.GenerateIV();
                byte[] iv = aes.IV;

                using (MemoryStream ms = new MemoryStream())
                {
                    // Escrevemos o IV no início do stream para usá-lo na descriptografia
                    ms.Write(iv, 0, iv.Length);

                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesTexto, 0, bytesTexto.Length);
                        cs.FlushFinalBlock();
                    }

                    // Retorna o resultado como uma string Base64 legível
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public string Descriptografar(string textoCriptografado, string chave)
        {
            byte[] bytesChave = Encoding.UTF8.GetBytes(chave);
            byte[] bytesCompletos = Convert.FromBase64String(textoCriptografado);

            using (Aes aes = Aes.Create())
            {
                aes.Key = bytesChave;

                // Extrai o IV do início dos bytes criptografados
                byte[] iv = new byte[aes.BlockSize / 8];
                Array.Copy(bytesCompletos, 0, iv, 0, iv.Length);
                aes.IV = iv;

                // Extrai o conteúdo criptografado real (ignorando o IV)
                int tamanhoConteudo = bytesCompletos.Length - iv.Length;
                byte[] bytesCriptografados = new byte[tamanhoConteudo];
                Array.Copy(bytesCompletos, iv.Length, bytesCriptografados, 0, tamanhoConteudo);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesCriptografados, 0, bytesCriptografados.Length);
                        cs.FlushFinalBlock();
                    }

                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        }
    }
}

