using MeusFilmes.Dominio;
using MeusFilmes.Infraestrutura.Repositorio;

namespace MeusFilmes.InterfaceUsuario
{
    public partial class ListaFilmes : Form
    {
        private readonly IRepositorio Repositorio;
        public ListaFilmes(IRepositorio repositorio)
        {
            Repositorio = repositorio;
            InitializeComponent();
            AtualizarDataGrid();
        }

        private void AtualizarDataGrid()
        {
            DataGridFilmes.DataSource = Repositorio.ObterTodos();
        }

        private void Ao_Clicar_Em_Adicionar(object sender, EventArgs e)
        {
            CadatroFilme telaCadastro = new(Repositorio);
            telaCadastro.ShowDialog();
            AtualizarDataGrid();
        }

        private void Ao_Clicar_Em_Editar(object sender, EventArgs e)
        {
            string? id = DataGridFilmes.CurrentRow.Cells["Id"].Value.ToString();
            CadatroFilme telaCadastro = new(Repositorio, Repositorio.ObterPorId(id));
            telaCadastro.ShowDialog();
            AtualizarDataGrid();
        }

        private void Ao_Clicar_Em_Remover(object sender, EventArgs e)
        {
            string? id = DataGridFilmes.CurrentRow.Cells["Id"].Value.ToString();
            Filme filme = Repositorio.ObterPorId(id);
            DialogResult resultado = MessageBox.Show($"Deseja realmente remover o filme {filme.Titulo}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Repositorio.Remover(id);
                MessageBox.Show("Filme removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            AtualizarDataGrid();
        }
    }
}
