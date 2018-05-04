using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalMemoria
{
    public partial class WebFormCronologia : System.Web.UI.Page
    {
        List<String> Cronologia;
        protected void Page_Load(object sender, EventArgs e)
        {
            LeArquivoTexto();
            InitTable();
        }
        void LeArquivoTexto()
        {
            StreamReader sr;
            string Arquivo, Linha;

            // Cria Lista de Diretores
            Cronologia = new List<String>();
            // Nome do Arquivo Texto
            Arquivo = Request.PhysicalApplicationPath + "Cronologia\\Cronologia.csv";

            // Le arquivo com nome de imagens
            if (System.IO.File.Exists(Arquivo))
            {
                sr = new StreamReader(System.IO.File.OpenRead(Arquivo));
                try
                {
                    while (sr.Peek() > -1)
                    {
                        Linha = sr.ReadLine(); // Le uma Linha
                        Cronologia.Add(Linha);
                    }
                }
                finally
                {
                    sr.Close();
                }
            }
        }
        void InitTable()
        {
            TableRow tr;
            TableCell tc;
            ImageButton imagem;
            Label rotulo;
            string[] linha;
            int indicecoluna, qtdcoluna;

            // Le arquivo com nome de imagens
            if (Cronologia.Count > 0)
            {
                indicecoluna = 0; qtdcoluna = 4;
                tr = new TableRow(); // Cria nova linha do componente table
                foreach (string strlinha in Cronologia)
                {
                    // Separa os dados em cada linha
                    linha = strlinha.Split(';');
                    // Configuração de uma celula da tabela
                    // Cada celula da tabela tem 3 elementos: imagem do diretor, 
                    //    nome do diretor e periodo de direção
                    tc = new TableCell();
                    // Configura Imagem do Diretor
                    imagem = new ImageButton();
                    imagem.ImageUrl = "~\\Cronologia\\" + linha[0] + ".jpg";
                    // linha[0] contem o ano inicial do diretor
                    imagem.ToolTip = linha[1];
                    imagem.PostBackUrl = "~\\WebFormCronologia.aspx?ano=" + linha[0] + "&evento=" + linha[1];
                    tc.Controls.Add(imagem); // Adiciona imagem na celula
                    tc.Height = 100;
                    tc.Width = 400;
                    tc.HorizontalAlign = HorizontalAlign.Center;
                    // Configura Nome do diretor
                    rotulo = new Label();
                    rotulo.Text = "<br />" + linha[0]; // contem o ano do evento
                    tc.Controls.Add(rotulo); // Adiciona rotulo na celula
                    // Configura Periodo de direção
                    // Adiciona celula na linha
                    tr.Cells.Add(tc);
                    // Contador de colunas
                    indicecoluna++;
                    // Adiciona linha configurada na tabela
                    TableCronologia.Rows.Add(tr);
                }

            }
        }
    }
}