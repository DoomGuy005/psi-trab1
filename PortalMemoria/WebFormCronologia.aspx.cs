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
            InitCronologia();
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
        void LeArquivoDesc()
        {
            StreamReader sr;
            string Arquivo, Linha;

            // Cria Lista de Diretores
            Cronologia = new List<String>();
            // Nome do Arquivo Texto
            Arquivo = Request.PhysicalApplicationPath + "Cronologia\\" + Request.QueryString["ano"] + ".txt";

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
                indicecoluna = 0;
                qtdcoluna = Cronologia.Count;
                tr = new TableRow(); // Cria nova linha do componente table
                foreach (string strlinha in Cronologia)
                {
                    // Separa os dados em cada linha
                    linha = strlinha.Split(';');
                    // Cada celula da tabela tem 2 elementos: imagem do evento, periodo do evento
                    // Configuração de uma celula da tabela
                    tc = new TableCell();
                    // Configura Nome do evento
                    rotulo = new Label();
                    rotulo.Font.Name = LabelAno.Font.Name;
                    rotulo.Text = linha[0] + "<br />"; // contem o ano do evento
                    tc.Controls.Add(rotulo); // Adiciona rotulo na celula
                    // Configura Imagem do evento
                    imagem = new ImageButton();
                    imagem.ImageUrl = "~\\Cronologia\\" + linha[0] + ".jpg";
                    imagem.Width = 210;
                    imagem.Height = 110;
                    // linha[0] contem o ano do evento
                    imagem.ToolTip = linha[1];
                    imagem.PostBackUrl = "~\\WebFormCronologia.aspx?ano=" + linha[0] + "&evento=" + linha[1];
                    tc.Height = 100;
                    tc.Width = 200;
                    tc.HorizontalAlign = HorizontalAlign.Center;
                    tc.Controls.Add(imagem); // Adiciona imagem na celula
                    
                    // Configura Periodo de direção
                    // Adiciona celula na linha
                    tr.Cells.Add(tc);
                    // Contador de colunas
                    indicecoluna++;
                }
                // Adiciona linha configurada na tabela
                TableCronologia.Rows.Add(tr);
            }

        }
        void InitCronologia()
        {
            string strCronologia = "";

            LabelAno.Text = Request.QueryString["ano"];
            LeArquivoDesc();
            foreach (string strlinha in Cronologia)
            {
                strCronologia = strCronologia + "<br />" + strlinha;
            }
            LabelEvento.Text = Request.QueryString["evento"];
            LabelDesc.Text = strCronologia;
            ImageEvento.ImageUrl = "\\Cronologia\\" + Request.QueryString["ano"] +".jpg";
        }
    }
}