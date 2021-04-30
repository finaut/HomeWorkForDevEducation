using System;

namespace HomeWorkForDevEducation16.Class
{
    public class Node
    {
        public Node left;
        public Node right;
        public string value;
        public bool end;

        public Node Build(string val)
        {
            val = val.Trim();
            
            // замена на 3тие значение $ дабы сохранить - который стоит перед оператором  
            if (val.Substring(0, 1) == "-")
            {
                val = "$" + val.Substring(1);
            }

            while (val.Contains("+-"))
            {
                val = val.Replace("+-", "+$");
            }

            while (val.Contains("--"))
            {
                val = val.Replace("--", "-$");
            }

            while (val.Contains("*-"))
            {
                val = val.Replace("*-", "*$");
            }

            while (val.Contains("/-"))
            {
                val = val.Replace("/-", "/$");
            }

            // поиск что какое поледнее значение передает для 
            if (val.LastIndexOf("+", StringComparison.Ordinal) > val.LastIndexOf("-", StringComparison.Ordinal))
            {
                this.value = "+";
            }
            else if (val.LastIndexOf("-", StringComparison.Ordinal) > val.LastIndexOf("+", StringComparison.Ordinal))
            {
                this.value = "-";
            } 
            else if (val.LastIndexOf("*", StringComparison.Ordinal) > val.LastIndexOf("/", StringComparison.Ordinal))
            {
                this.value = "*";
            }
            else if (val.LastIndexOf("/", StringComparison.Ordinal) > val.LastIndexOf("*", StringComparison.Ordinal))
            {
                this.value = "/";
            }
            else
            {
                end = true;
                this.value = val.Trim();
            }

            if (!end)
            {
                this.left = new Node();
                this.right = new Node();

                // записать значение которое вырезаем
                string[] split = val.Split(this.value);
                string leftString = split[0];
                
                // склеевает остальные 2 символа
                for (int i = 1; i < split.Length - 1; i++)
                    leftString += this.value + split[i];
                left.Build(leftString)
            }
        }
    }
}