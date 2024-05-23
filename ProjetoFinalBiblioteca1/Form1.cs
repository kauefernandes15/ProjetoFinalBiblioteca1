using ProjetoFinalBiblioteca;

namespace ProjetoFinalBiblioteca1
{
    public partial class Form1 : Form
    {
        public List<Funcionario> funcionarios;
        public List<Leitor> leitores;
        public List<Exemplar> exemplars;


        public Form1()
        {
            InitializeComponent();

            funcionarios = new List<Funcionario>();
            leitores = new List<Leitor>();
            exemplars = new List<Exemplar>();

            CargaInicial();
            AtualizarDataGridView();

        }
        private void CargaInicial()
        {
            leitores.Add(new Leitor("David", DateTime.Today, "cpf1", "david@gmail.com", "telefone1"));
            leitores.Add(new Leitor("Kaue", DateTime.Today, "cpf1", "david@gmail.com", "telefone1"));
            funcionarios.Add(new Funcionario("funcionário 1", DateTime.Today, "Cpf1", "Funcionario@gmail.com", "telefone1", 1, 6, 12, "gerente"));
            funcionarios.Add(new Funcionario("funcionário 1", DateTime.Today, "Cpf2", "Funcionario@gmail.com", "telefone2", 2000, 6, 8, "gestor"));
            exemplars.Add(new Livro("livro 1", "subtitulo1", "escritor1", "editora1", 2021, "gen1", 1, 100, "tipoCapa1", "isbn1"));
            exemplars.Add(new Livro("livro 2", "subtitulo2", "escritor2", "editora2", 2022, "gen2", 2, 200, "tipoCapa2", "isbn2"));
            exemplars.Add(new Ebook("ebook 1", "subtitulo1", "escritor1", "editora1", 2021, "gen1", 1, 100, "tipocapa1", "isbn1", "formato1", 10, "Url1"));
            exemplars.Add(new Ebook("ebook 2", "subtitulo2", "escritor2", "editora2", 2022, "gen2", 2, 200, "tipocapa2", "isbn2", "formato2", 20, "Url2"));
            exemplars.Add(new Revista("revista 1", "subtitulo1", "escritor1", "editora1", 2021, "gen1", 1, 324, 11));
            exemplars.Add(new Revista("revista 1", "subtitulo1", "escritor1", "editora1", 2021, "gen2", 1, 324, 22));
            exemplars.Add(new Hq("hq 1", "subtitulo1", "escritor1", "editora1", 2021, "gen1", 1, 324, "ilustrador1", 11));
            exemplars.Add(new Hq("hq 2", "subtitulo2", "escritor2", "editora2", 2022, "gen2", 2, 322, "ilustrador2", 22));
            exemplars.Add(new Generico("genérico 1", "subtitulo1", "escritor1", "editora1", 2022, "gen1", 1, 1));
            exemplars.Add(new Generico("genérico 2", "subtitulo2", "escritor2", "editora2", 2024, "gen2", 2, 2));
        }

        private void buttonCadastroPessoa_Click(object sender, EventArgs e)
        {
            var formPessoa = new Form2();
            formPessoa.StartPosition = FormStartPosition.CenterParent;
            formPessoa.Show();
            this.Hide();
        }

        private void buttonCadastroExemplar_Click(object sender, EventArgs e)
        {
            var formExemplar = new Form3(exemplars);
            formExemplar.StartPosition = FormStartPosition.CenterScreen;
            formExemplar.ShowDialog();
            AtualizarDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastroPessoa_Click_1(object sender, EventArgs e)
        {
            // Form2 form2 = new Form2();
            // form2.ShowDialog();

            var aux = new Form2(funcionarios, leitores);
            aux.StartPosition = FormStartPosition.CenterParent;
            aux.ShowDialog();
            AtualizarDataGridView();
        }

        private void buttonCadastroExemplar_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(exemplars);
            form3.ShowDialog();
            AtualizarDataGridView();
        }

        private void AtualizarDataGridView()
        {
            FuncNovo.DataSource = null;
            FuncNovo.DataSource = funcionarios;

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = leitores;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = exemplars;

            /* foreach (var item in exemplars)
             {
                 //MessageBox.Show(item.Titulo);
             }*/
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridViewFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewExemplares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FuncNovo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
