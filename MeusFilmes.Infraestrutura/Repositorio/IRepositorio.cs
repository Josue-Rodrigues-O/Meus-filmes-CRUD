using MeusFilmes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusFilmes.Infraestrutura.Repositorio
{
    public interface IRepositorio
    {
        public void Criar(Filme filme);
        public List<Filme> ObterTodos();
        public Filme ObterPorId(string id);
        public void Atualizar(Filme filme);
        public void Remover(string id);
    }
}
