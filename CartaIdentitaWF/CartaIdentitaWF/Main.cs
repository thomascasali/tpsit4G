using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartaIdentitaWF
{
    public partial class Main : Form
    {
        List<Comune> comuni;
        List<CartaIdentita> carte;
        List<Persona> persone;
        public Main()
        {
            InitializeComponent();
            comuni = new List<Comune>();
            carte = new List<CartaIdentita>();
            persone = new List<Persona>();
            
        }

        private void btnAddComune_Click(object sender, EventArgs e)
        {
            comuni.Add(new CartaIdentitaWF.Comune(txComune.Text , txCap.Text));
            cbComuneID.DataSource = null;
            cbComuneID.DataSource = comuni;
            cbComuneID.DisplayMember = "Nome";
            cbComuneID.ValueMember = "Self";
            cbComuneNascita.DataSource = null;
            cbComuneNascita.DataSource = comuni;
            cbComuneNascita.DisplayMember = "Nome";
            cbComuneNascita.ValueMember = "Self";
        }

        private void btnAddCarta_Click(object sender, EventArgs e)
        {

            carte.Add(new CartaIdentitaWF.CartaIdentita(txNumeroID.Text, (Comune)cbComuneID.SelectedValue, dtCarta.Text));
            cbCarteId.DataSource = null;
            cbCarteId.DataSource = carte;
            cbCarteId.DisplayMember = "Numero";
            cbCarteId.ValueMember = "Self";
        }

        private void btnAddPersona_Click(object sender, EventArgs e)
        {
            persone.Add(new Persona(txCognome.Text, txNome.Text, dtNascita.Text,(CartaIdentita)cbCarteId.SelectedValue,(Comune)cbComuneNascita.SelectedValue ));
          
        }
    }
}
