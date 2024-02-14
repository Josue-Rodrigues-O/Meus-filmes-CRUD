using Raven.Client.Documents;

namespace MeusFilmes.Infraestrutura.Raven
{
    public static class DocumentstoreHolder
    {
        private static readonly Lazy<IDocumentStore> LazyStore = new Lazy<IDocumentStore>(() =>
        {
            IDocumentStore store = new DocumentStore
            {
                Urls = new [] { "http://127.0.0.1:8080/" },
                Database = "FilmesDB"
            };

            store.Initialize();

            return store;
        });

        public static IDocumentStore Store => LazyStore.Value;
    }
}
