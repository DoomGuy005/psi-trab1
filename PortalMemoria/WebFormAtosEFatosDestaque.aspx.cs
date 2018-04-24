using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalMemoria
{
	public partial class WebFormAtosEFatosDestaque : System.Web.UI.Page
	{
        List<String> AtosEFatos;

        protected void Page_Load(object sender, EventArgs e)
        {
            LeArquivoTexto();
            InitFato();
        }

        void LeArquivoTexto()
        {
            StreamReader sr;
            string Arquivo, Linha;

            // Cria Lista de Diretores
            AtosEFatos = new List<String>();
            // Nome do Arquivo Texto
            Arquivo = Request.PhysicalApplicationPath + "AtosEFatos\\" + Request.QueryString["destaque"]+ ".txt";
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

        void InitFato()
        {
            string strAtosEFatos = "";

            LabelFato.Text = Request.QueryString["fato"];
            LeArquivoTexto();
            foreach (string strlinha in AtosEFatos)
            {
                strAtosEFatos = strAtosEFatos + "<br />" + strlinha;
            }
            LabelDestaqueFato.Text = strAtosEFatos;
            ImageDestaqueFato.ImageUrl = Request.QueryString["destaque"] + "Destaque.jpg";
        }
    }
}