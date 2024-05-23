using ProjetoFinalBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalBiblioteca1
{
    public partial class Form2 : Form
    {
        List<Funcionario> funcionarios;
        List<Leitor> leitors;

        public Form2(List<Funcionario> funcionarios, List<Leitor> leitors)
        {
            InitializeComponent();

            this.funcionarios = funcionarios;
            this.leitors = leitors;
        }

        public Form2()
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // carrega os valores do Enum para o combobox/Listbox
            comboBoxCargo.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
            comboBoxCargo.SelectedIndex = 0;
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumTipoLeitor));
            listBoxTipo.SelectedIndex = 0;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Aqui você determina formulário de cadastro 
            // Form1 formCadastroPessoa = new Form1();
            // formCadastroPessoa.StartPosition = FormStartPosition.CenterScreen;
            // formCadastroPessoa.ShowDialog();
            // formCadastroPessoa.TopMost = true;
            // this.Hide();

            string auxNome = textBoxNome.Text;
            DateTime auxData = dateTimePickerNascimento.Value;
            string auxCpf = maskedTextBoxCpf.Text;
            string auxEmail = textBoxEmail.Text;
            string auxTelefone = maskedTextBoxTelefone.Text;

            if(TabControlLeitorFuncionario.SelectedIndex == 0)
            {
                var leitor = new Leitor(auxNome, auxData, auxCpf, auxEmail, auxTelefone);

                leitors.Add(leitor);
                
            }
            else
            {
                int auxCargo = (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), comboBoxCargo.Text);
                decimal auxSalario = numericUpDownSalario.Value;
                int auxCargoHoraria = Convert.ToInt32(numericUpDownCargaH.Value);
                string auxFuncao = textBoxFuncao.Text;

                funcionarios.Add(new Funcionario(auxNome, auxData, auxCpf, auxEmail, auxTelefone, auxCargo, auxSalario, auxCargoHoraria, auxFuncao));

            }

            MessageBox.Show("Pessoa cadastrada com sucesso");

            Close();
        }
    }
}
