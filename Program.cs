using System;

namespace MetodoClass
{
    class Pessoa
    {
        private int idade;
        private string nome;

        public Pessoa(string nomePessoa, int idadePessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
        }

        public void setIdade (int idadePessoa)
        {
            this.idade = idadePessoa;
        }
        public int getIdade ()
        {
            return this.idade;
        }

        public void setNome (string nomePessoa)
        {
            this.nome = nomePessoa;
        }
        public string getNome()
        {
            return this.nome;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var fulano1 = new Pessoa("Bianco", 34); // criando objeto
            //fulano1.setIdade(23);       // atribuindo valor ao objeto, jogando na idade
           // fulano1.setNome("Bianco");

            //var fulano2 = new Pessoa();
           // fulano2.setIdade(54);
           // fulano2.setNome("Jose");

            Console.WriteLine("A idade do" + fulano1.getNome() + " primeira pessoa é " + fulano1.getIdade());
           // Console.WriteLine("A idade do" + fulano2.getNome() + " primeira pessoa é " + fulano2.getIdade());
        }
    }
}
