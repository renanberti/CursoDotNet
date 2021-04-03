using System;

namespace digital
{
    public class Classe
    {
        string nome;
        int idade;
        string cidade;

        public override bool Equals(object obj)
        {
            return obj is Classe classe &&
                   idade == classe.idade;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(idade);
        }

        public string getNome(){
            return nome;
        }
        public void setNome(string n){

            this.nome = n;

        }



    }
}