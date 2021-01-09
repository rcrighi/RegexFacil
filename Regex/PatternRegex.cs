using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    public static class PatternRegex
    {
        public static string CPF = @"\d{3}\.\d{3}\.\d{3}\-\d{2}";
        public static string CNPJ = @"[0-9]{2}\.?[0-9]{3}\.?[0-9]{3}\/?[0-9]{4}\-?[0-9]{2}";
        public static string TELEFONE = @"[(]?\d{2}[)]?\s*[1-9]?\d{4}-?\d{4}";
        public static string EMAIL = @"^([\w\-]+\.)*[\w\- ]+@([\w\- ]+\.)+([\w\-]{2,3})$";
        public static string URL = @"^((http)|(https)|(ftp)):\/\/([\- \w]+\.)+\w{2,3}(\/ [%\-\w]+(\.\w{2,})?)*$";
        public static string IP = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";
        public static string DATA = @"^((0[1-9]|[12]\d)\/(0[1-9]|1[0-2])|30\/(0[13-9]|1[0-2])|31\/(0[13578]|1[02])) \/\d{4}$";


    }
}
