using MeusFilmes.Dominio;
using MeusFilmes.Infraestrutura.Repositorio;

namespace MeusFilmes.InterfaceUsuario
{
    public partial class CadatroFilme : Form
    {
        private readonly IRepositorio Repositorio;
        private readonly Filme _Filme = new();
        public CadatroFilme(IRepositorio repositorio, Filme? filme = null)
        {
            InitializeComponent();
            Repositorio = repositorio;
            ComboBoxGenero.DataSource = Enum.GetValues(typeof(GeneroEnum));
            if (filme is not null)
            {
                this.Text = "Atualização";
                _Filme = filme;
                PreencherForms();
            }
        }

        private void PreencherForms()
        {
            TxtTitulo.Text = _Filme.Titulo;
            TxtDuracao.Text = _Filme.Duracao.ToString();
            TrackBarAvalicao.Value = _Filme.Avaliacao;
            ComboBoxGenero.SelectedItem = _Filme.GeneroFilme;
            LabelAvaliacao.Text = TrackBarAvalicao.Value.ToString();
        }

        private void PreencherObjeto()
        {
            _Filme.Titulo = TxtTitulo.Text;
            _Filme.Duracao = Convert.ToDouble(TxtDuracao.Text);
            _Filme.Avaliacao = TrackBarAvalicao.Value;
            _Filme.GeneroFilme = (GeneroEnum)ComboBoxGenero.SelectedItem;
        }

        private void Ao_Clicar_Em_Salvar(object sender, EventArgs e)
        {
            if (_Filme.Id.Equals(string.Empty))
            {
                PreencherObjeto();
                Repositorio.Criar(_Filme);
                DialogResult = MessageBox.Show("Filme cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PreencherObjeto();
                Repositorio.Atualizar(_Filme);
                DialogResult = MessageBox.Show("Filme atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Ao_Clicar_Em_Cancelar(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja mesmo cancelar a operação?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void TrackBarAvalicao_ValueChanged(object sender, EventArgs e)
        {
            LabelAvaliacao.Text = TrackBarAvalicao.Value.ToString();
        }
    }
}
