using System;
using System.Collections.Generic;
using System.Text;

namespace minhabibliotecap2.Models
{
    public class Livro
    {
        private int id;
        private string nome;
        private string autor;
        private int ano;
        private string descricao;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Ano { get => ano; set => ano = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        
        public string addLivro()
        {
            return "Livro adicionado com sucesso!";
        }
        public string deleteLivro()
        {
            return "Livro deletado com sucesso!";
        }
        public string updateLivro()
        {
            return "Livro atualizado com sucesso!";
        }
        public string getLivroAll()
        {
            return "Livro encontrado com sucesso!";
        }
        public string getLivroById()
        {
            return "Livro encontrado com sucesso!";
        }
    }
}
