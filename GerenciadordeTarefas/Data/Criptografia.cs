using System;
using System.Security.Cryptography;
using System.Text;

public static class Criptografia
{
    public static string CriptografarSenha(string senha)
    {
        // Crie um objeto de algoritmo de hash SHA-256
        using (SHA256 sha256 = SHA256.Create())
        {
            // Converta a senha em bytes
            byte[] bytesSenha = Encoding.UTF8.GetBytes(senha);

            // Calcule o hash SHA-256 dos bytes da senha
            byte[] hashSenha = sha256.ComputeHash(bytesSenha);

            // Converta o hash em uma string hexadecimal
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashSenha)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
