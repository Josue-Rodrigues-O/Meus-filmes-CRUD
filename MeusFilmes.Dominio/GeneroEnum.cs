using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusFilmes.Dominio
{
    public enum GeneroEnum
    {
        [Description("Ação")]
        Acao,
        [Description("Aventura")]
        Aventura,
        [Description("Cinema de arte")]
        CinemaDeArte,
        [Description("Chanchada")]
        Chanchada,
        [Description("Comédia")]
        Comedia,
        [Description("Comedia de ação")]
        ComediaDeAcao,
        [Description("Comedia de terror")]
        ComediaDeTerror,
        [Description("Comedia dramática")]
        ComediaDramatica,
        [Description("Comedia romântica")]
        ComediaRomantica,
        [Description("Dança")]
        Danca,
        [Description("Documentário")]
        Documentario,
        [Description("Docuficção")]
        Docuficcao,
        [Description("Drama")]
        Drama,
        [Description("Espionagem")]
        Espionagem,
        [Description("Faroeste")]
        Faroeste,
        [Description("Fantasia")]
        Fantasia,
        [Description("Fantasia científica")]
        FantasiaCientifica,
        [Description("Ficção científica")]
        FiccaoCientifica,
        [Description("Filmes com truques")]
        FilmesComTruques,
        [Description("Filmes de guerra")]
        FilmesDeGuerra,
        [Description("Mistério")]
        Misterio,
        [Description("Musical")]
        Musical,
        [Description("Filme policial")]
        FilmePolicial,
        [Description("Romance")]
        Romance,
        [Description("Terror")]
        Terror,
        [Description("Thriller")]
        Thriller
    }
}
