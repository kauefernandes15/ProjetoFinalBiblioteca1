using ProjetoFinalBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalBiblioteca1;

public partial class Form3 : Form
{
    public List<Exemplar> exemplars;
    public Form3(List<Exemplar> exemplars)
    {
        InitializeComponent();
        this.exemplars = exemplars;
    }

    private void Form3_Load(object sender, EventArgs e)
    {
        listBoxTipoGenerico.DataSource = Enum.GetValues(typeof(EnumGenericoTipo));
        comboBoxTipoCapa.DataSource = Enum.GetValues(typeof(EnumExemplarTipoCapa));
        comboBoxGenero.DataSource = Enum.GetValues(typeof(EnumExemplarGeneroTipo));
        comboBoxStatus.DataSource = Enum.GetValues(typeof(EnumExemplarStatus));
        comboBoxFormato.DataSource = Enum.GetValues(typeof(EnumEbookFormato));
    }



    private void buttonSalvar_Click(object sender, EventArgs e)
    {
    
    }

    private void buttonSalvar_Click_1(object sender, EventArgs e)
    {
        string auxTitulo = textBoxTitulo.Text;
        string auxSubTitulo = textBoxSubtitulo.Text;
        string auxEscritor = textBoxEscritor.Text;
        string auxEditora = textBoxEditora.Text;
        int auxAnoPublicacao = Convert.ToInt32(numericUpDownAnoPub.Value);
        string auxGenero = comboBoxGenero.Text;
        int auxStatus = (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), comboBoxStatus.Text);
        if (TabControlExemplar.SelectedIndex == 0)
        {
            // Livro ou Ebook
            int auxPaginas = Convert.ToInt32(numericUpDownPaginas.Value);
            string auxTipoCapa = comboBoxTipoCapa.Text;
            string auxIsbn = textBoxISBN.Text;

            if (!checkBoxEbook.Checked)
            {
                exemplars.Add(new Livro(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxPaginas, auxTipoCapa, auxIsbn));
            }
            else
            {
                string auxFormato = comboBoxFormato.Text;
                decimal auxTamanho = numericUpDownTamanhoEbook.Value;
                string auxUrl = textBoxUrl.Text;

                exemplars.Add(new Ebook(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxPaginas, auxTipoCapa, auxIsbn, auxFormato, auxTamanho, auxUrl));
            }
        }
        else if (TabControlExemplar.SelectedIndex == 1)
        {
            // Revista
            int auxEdicaoRevista = Convert.ToInt32(numericUpDownEdicaoRevista.Value);
            int auxPaginasRevista = Convert.ToInt32(numericUpDownPaginas.Value);

            exemplars.Add(new Revista(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxEdicaoRevista, auxPaginasRevista));
        }
        else if (TabControlExemplar.SelectedIndex == 2)
        {
            // HQ
            int auxEdicaoHq = Convert.ToInt32(numericUpDownEdi.Value);
            string auxIlustrador = textBoxIlustrador.Text;
            int auxPaginas = Convert.ToInt32(numericUpDownPaginas);

            exemplars.Add(new Hq(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxEdicaoHq, auxIlustrador, auxPaginas));
        }
        else if (TabControlExemplar.SelectedIndex == 3)
        {
            // Generico
            int auxTipo = (int)(EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), listBoxTipoGenerico.Text);

            exemplars.Add(new Generico(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxTipo));
        }

        MessageBox.Show("Exemplar salvo com sucesso!");
        Close();
    }
}