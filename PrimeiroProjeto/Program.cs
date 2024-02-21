namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            string cidade;

           

            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Olá, {0}, qual sua idade?", nome);
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Então seu nome é {0}, e você tem {1} anos, de qual cidade você é?", nome, idade);
            cidade = Console.ReadLine();
            Console.WriteLine("Entendi! \n Nome: {0} \n Idade: {1} \n Cidade: {2}", nome, idade, cidade);





        }
    }
}
