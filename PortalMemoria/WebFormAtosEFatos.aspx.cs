using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalMemoria
{
    public partial class WebFormAtosEFatos : System.Web.UI.Page
    {
        List<String> AtosEFatos;
        protected void Page_Load(object sender, EventArgs e)
        {
            LeArquivoTexto();
            InitMenu();
        }
        void LeArquivoTexto()
        {
            StreamReader sr;
            string Arquivo, Linha;

            // Cria Lista de Diretores
            AtosEFatos = new List<String>();
            // Nome do Arquivo Texto
            Arquivo = Request.PhysicalApplicationPath + "AtosEFatos\\MenuAtosEFatos.csv";

            // Le arquivo com nome de imagens
            if (System.IO.File.Exists(Arquivo))
            {
                sr = new StreamReader(System.IO.File.OpenRead(Arquivo));
                try
                {
                    while (sr.Peek() > -1)
                    {
                        Linha = sr.ReadLine(); // Le uma Linha
                        AtosEFatos.Add(Linha);
                    }
                }
                finally
                {
                    sr.Close();
                }
            }
        }
        void InitMenu()
        {
            MenuItem mi;
            string[] linha;
            // Le arquivo com nome de imagens
            if (AtosEFatos.Count > 0)
            { 
                foreach (string strlinha in AtosEFatos)
                {
                    mi = new MenuItem(); // Cria nova linha do componente Menu
                    // Separa os dados em cada linha
                    linha = strlinha.Split(';');
                    // Cada item do menu tem um elemento, que é o seu texto 
                    // Configura Item do Menu
                    mi.ToolTip = linha[0];
                    mi.Text = linha[0];
                    mi.NavigateUrl = "~\\WebFormAtosEFatosDestaque.aspx?fato="+linha[0]+"&destaque="+linha[1];
                    MenuAtoseFatos.Items.Add(mi);
                } // fim do foreach
            }
        }
    }
}