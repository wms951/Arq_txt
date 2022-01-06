using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Arq_txt
{
    public partial class Form1 : Form
    {

        String path = @"C:\\file\\dados.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bCriarArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(path))
                {

                    using (FileStream fs = File.Create(path))
                    {
                        fs.Close();
                    }
                    MessageBox.Show("Arquivo criado com sucesso!");

                }else
                {
                    MessageBox.Show("O arquivo ja existe!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado! \n\n" + ex.Message);
            }
        }

        private void bAppend_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(path))
                {
                    
                    using(StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(tBAppend.Text);
                    }

                    tBAppend.Text = "";
                }
                else
                {
                    MessageBox.Show("O arquivo não foi localizado!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado! \n\n" + ex.Message);
            }
        }

        private void bLerArquivo_Click(object sender, EventArgs e)
        {


            try
            {
                if (File.Exists(path))
                {

                    using(StreamReader sr = File.OpenText(path))
                    {
                        tBArquivo.Text = sr.ReadToEnd();
                    }

                   
                }
                else
                {
                    MessageBox.Show("O arquivo não foi localizado!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado! \n\n" + ex.Message);
            }

        }

        private void bAtualizarArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(path))
                {


                    using(FileStream fs = File.Open(path, FileMode.Truncate))
                    {

                        StreamWriter sw = new StreamWriter(fs);

                        foreach(String linha in tBArquivo.Lines)
                        {
                            sw.WriteLine(linha);
                        }

                        sw.Close();
                        fs.Close();

                    }


                    MessageBox.Show("Arquivo atualizado com sucesso!");

                }
                else
                {
                    MessageBox.Show("O arquivo não foi localizado!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado! \n\n" + ex.Message);
            }
        }

        private void bExcluirArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(path))
                {


                    File.Delete(path);


                    MessageBox.Show("Arquivo removido!");

                }
                else
                {
                    MessageBox.Show("O arquivo não foi localizado!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado! \n\n" + ex.Message);
            }
        }
    }
}
