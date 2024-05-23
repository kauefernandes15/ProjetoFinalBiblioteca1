namespace ProjetoFinalBiblioteca1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonCadastroPessoa = new Button();
            buttonCadastroExemplar = new Button();
            livroBindingSource = new BindingSource(components);
            funcionarioBindingSource = new BindingSource(components);
            leitorBindingSource = new BindingSource(components);
            FuncNovo = new DataGridView();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)livroBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leitorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FuncNovo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // buttonCadastroPessoa
            // 
            buttonCadastroPessoa.Location = new Point(55, 140);
            buttonCadastroPessoa.Name = "buttonCadastroPessoa";
            buttonCadastroPessoa.Size = new Size(198, 23);
            buttonCadastroPessoa.TabIndex = 0;
            buttonCadastroPessoa.Text = "Cadastro Pessoa";
            buttonCadastroPessoa.UseVisualStyleBackColor = true;
            buttonCadastroPessoa.Click += buttonCadastroPessoa_Click_1;
            // 
            // buttonCadastroExemplar
            // 
            buttonCadastroExemplar.Location = new Point(55, 214);
            buttonCadastroExemplar.Name = "buttonCadastroExemplar";
            buttonCadastroExemplar.Size = new Size(198, 23);
            buttonCadastroExemplar.TabIndex = 1;
            buttonCadastroExemplar.Text = "Cadastro Exemplar";
            buttonCadastroExemplar.UseVisualStyleBackColor = true;
            buttonCadastroExemplar.Click += buttonCadastroExemplar_Click_1;
            // 
            // FuncNovo
            // 
            FuncNovo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FuncNovo.Location = new Point(282, 12);
            FuncNovo.Name = "FuncNovo";
            FuncNovo.Size = new Size(441, 120);
            FuncNovo.TabIndex = 2;
            FuncNovo.CellContentClick += FuncNovo_CellContentClick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(282, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(441, 150);
            dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(282, 305);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(441, 142);
            dataGridView2.TabIndex = 4;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 450);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(FuncNovo);
            Controls.Add(buttonCadastroExemplar);
            Controls.Add(buttonCadastroPessoa);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)livroBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)leitorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)FuncNovo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCadastroPessoa;
        private Button buttonCadastroExemplar;
        private DataGridView dataGridViewExemplares;
        private DataGridView dataGridViewLeitores;
        private DataGridView dataGridViewFuncionarios;

        private BindingSource livroBindingSource;
        private BindingSource funcionarioBindingSource;
        private BindingSource leitorBindingSource;
        private DataGridView FuncNovo;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}
