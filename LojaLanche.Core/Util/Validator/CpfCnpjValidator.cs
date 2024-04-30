using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LojaLanche.Core.Util.Validator
{
    public static class CpfCnpjValidator
    {
        public static bool IsValidCpf(string cpf)
        {
            // Remove caracteres não numéricos
            cpf = Regex.Replace(cpf, @"\D", "");

            // Verifica se a quantidade de dígitos é igual a 11
            if (cpf.Length != 11)
                return false;

            // Verifica se todos os dígitos são iguais
            if (new string(cpf[0], cpf.Length) == cpf)
                return false;

            // Calcula o primeiro dígito verificador
            int sum = 0;
            for (int i = 0; i < 9; i++)
                sum += (10 - i) * (cpf[i] - '0');

            int digit1 = 11 - (sum % 11);
            if (digit1 >= 10)
                digit1 = 0;

            // Calcula o segundo dígito verificador
            sum = 0;
            for (int i = 0; i < 10; i++)
                sum += (11 - i) * (cpf[i] - '0');

            int digit2 = 11 - (sum % 11);
            if (digit2 >= 10)
                digit2 = 0;

            // Verifica se os dígitos calculados são iguais aos dígitos informados
            return cpf[9] - '0' == digit1 && cpf[10] - '0' == digit2;
        }

        public static bool IsValidCnpj(string cnpj)
        {
            // Remove caracteres não numéricos
            cnpj = Regex.Replace(cnpj, @"\D", "");

            // Verifica se a quantidade de dígitos é igual a 14
            if (cnpj.Length != 14)
                return false;

            // Verifica se todos os dígitos são iguais
            if (new string(cnpj[0], cnpj.Length) == cnpj)
                return false;

            // Calcula o primeiro dígito verificador
            int sum = 0;
            int multiplier = 2;
            for (int i = 11; i >= 0; i--)
            {
                sum += (cnpj[i] - '0') * multiplier;
                multiplier = (multiplier == 9) ? 2 : multiplier + 1;
            }
            int digit1 = sum % 11;
            digit1 = (digit1 < 2) ? 0 : 11 - digit1;

            // Calcula o segundo dígito verificador
            sum = 0;
            multiplier = 2;
            for (int i = 12; i >= 0; i--)
            {
                sum += (cnpj[i] - '0') * multiplier;
                multiplier = (multiplier == 9) ? 2 : multiplier + 1;
            }
            int digit2 = sum % 11;
            digit2 = (digit2 < 2) ? 0 : 11 - digit2;

            // Verifica se os dígitos calculados são iguais aos dígitos informados
            return cnpj[12] - '0' == digit1 && cnpj[13] - '0' == digit2;
        }
    }
}
