namespace StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DFG    ";

            string S1 = original.ToUpper();
            string S2 = original.ToLower();
            string S3 = original.Trim(); //apaga os espaços em branco antes e depois da string.
            
            int n1 = original.IndexOf("bc"); //mostra a primeira posição do elemento na string
            int n2 = original.LastIndexOf("bc"); //mostra a última posição do elemento na string

            string s4 = original.Substring(3); //corta um pedaço da string a partir do indice informado.
            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a', 'x'); //substitui um string por outro.
            string s7 = original.Replace("abc", "xy");

            bool b1 = string.IsNullOrEmpty(original); //Testa para saber se o campo está vazio ou não.
            bool b2 = string.IsNullOrWhiteSpace(S2);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + S1 + "-");
            Console.WriteLine("ToLower: -" + S2 + "-");
            Console.WriteLine("Trim: -" + S3 + "-");
            Console.WriteLine("Indexof('bc'): " + n1 + "-");
            Console.WriteLine("LastIndexof('bc'): " + n2 + "-");
            Console.WriteLine("SubString(3): " + s4 + "-");
            Console.WriteLine("SubString(3,5): " + s5 + "-");
            Console.WriteLine("Replace('a' , 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): - " + s7);
            Console.WriteLine("IsNullOrEmpty: - " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: -" + b2);


        }
    }
}

