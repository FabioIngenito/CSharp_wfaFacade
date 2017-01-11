using System;
using System.Windows.Forms;
using clsFacade;

/// <summary>
/// Based in original explanation in (Brazilian Portuguese only): 
/// Design Pattern : Facade
/// http://matheuscalache.blogspot.com.br/2009/06/design-pattern-facade.html
/// Referências Bibliográficas (Bibliographic References):
/// O'Relly Head First – Design Patterns
/// Postado por Matheus de Lara Calache 1 de jun de 2009 às 12:36      
/// Marcadores: C#, Desenvolvimento, Design Pattern, Facade Pattern 
/// 
/// Radios:
/// http://www.radios.com.br/radio/regiao/capital-sao-paulo/47/am-fm
/// </summary>
namespace CSharp_wfaFacade
{
    public partial class frmSampleFacade : Form
    {
        String[] strLinhas;

        public frmSampleFacade()
        {
            InitializeComponent();

            lstVision.Clear();
            lstVision.View = View.Details;
            lstVision.FullRowSelect = true;
            lstVision.GridLines = false;
            lstVision.Columns.Add("Message - Mensagem:", 120).Width = 400;
        }

        private void btnDrive_Click(object sender, System.EventArgs e)
        {
            strLinhas = Car.Drive(TuneRadio()).Split(new Char[] { '\n' });

            WriteListView(strLinhas);
        }

        private void btnPark_Click(object sender, System.EventArgs e)
        {
            strLinhas = Car.Park().Split(new Char[] { '\n' });

            WriteListView(strLinhas);
        }

        /// <summary>
        /// Search the chosen radio - Procura a rádio escolhida
        /// </summary>
        /// <returns>The frequence - A frequência</returns>
        private String TuneRadio()
        {
            String strTuneRadio = "";

            foreach (Control ctrObj in this.Controls)
            {
                if (ctrObj is RadioButton)
                    if (((RadioButton)ctrObj).Checked == true)
                        strTuneRadio = ctrObj.Tag.ToString();
            }

            return strTuneRadio;
        }

        /// <summary>
        /// Write in ListView - Escreve na ListView
        /// </summary>
        /// <param name="strLinhas">Array Lines - Array de Linhas</param>
        private void WriteListView(String[] strLinhas)
        {
            lstVision.Items.Clear();

            for (int i = 0; i < strLinhas.Length; i++)
            {
                lstVision.Items.Add(strLinhas[i]);
            }
        }
    }
}