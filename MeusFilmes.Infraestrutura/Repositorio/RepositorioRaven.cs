using MeusFilmes.Dominio;
using MeusFilmes.Infraestrutura.Raven;

namespace MeusFilmes.Infraestrutura.Repositorio
{
    public class RepositorioRaven : IRepositorio
    {
        public void Criar(Filme filme)
        {
            using var session = DocumentstoreHolder.Store.OpenSession();
            session.Store(filme);
            session.SaveChanges();
        }

        public Filme ObterPorId(string id)
        {
            using var session = DocumentstoreHolder.Store.OpenSession();
            return session.Load<Filme>(id);
        }

        public List<Filme> ObterTodos()
        {
            using var session = DocumentstoreHolder.Store.OpenSession();
            return [.. session.Query<Filme>()];
        }

        public void Atualizar(Filme filme)
        {
            using var session = DocumentstoreHolder.Store.OpenSession();
            Filme _filme = session.Load<Filme>(filme.Id);
            _filme.Titulo = filme.Titulo;
            _filme.Duracao = filme.Duracao;
            _filme.Avaliacao = filme.Avaliacao;
            _filme.GeneroFilme = filme.GeneroFilme;
            session.SaveChanges();
        }

        public void Remover(string id)
        {
            using var session = DocumentstoreHolder.Store.OpenSession();
            session.Delete(id);
            session.SaveChanges();
        }
    }
}
