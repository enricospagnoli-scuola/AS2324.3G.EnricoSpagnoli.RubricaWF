namespace AS2324._3G.Prof.RubricaWF
{
    public partial class Form1 : Form
    {
        const int nMaxContatti = 100;
        int nRecordInseriti = 0;

        // definizione array paralleli
        string[] cognome = new string[nMaxContatti];
        string[] nome = new string[nMaxContatti];
        string[] email = new string[nMaxContatti];
        string[] nickname = new string[nMaxContatti];
        int[] simpatia = new int[nMaxContatti];
        int[] annoNascita = new int[nMaxContatti];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            lstElenco.Items.Clear();
            if (cmbRicerca.Text == "" || txtRicerca.Text == "")
                MessageBox.Show("E' necessario definire il campo di ricerca.");
            string elenco;
            for (int i = 0; i < nRecordInseriti; i++)
            {
                switch (cmbRicerca.Text)
                {
                    case "Nome":
                        switch (cmbOpzioni.Text)
                        {
                            case "":
                                if (txtRicerca.Text == nome[i])
                                {
                                    elenco = ($"Nome: {nome[i]}, Cognome: {cognome[i]} Email: {email[i]}, Simpatia: {simpatia[i]}, Anno di nascita: {annoNascita[i]}, Nickname: {nickname[i]}");
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Inizia per":
                                if (nome[i].StartsWith(txtRicerca.Text))
                                {
                                    elenco = ($"Nome: {nome[i]}, Cognome: {cognome[i]} Email: {email[i]}, Simpatia: {simpatia[i]}, Anno di nascita: {annoNascita[i]}, Nickname: {nickname[i]}");
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Finisce per":
                                if (nome[i].EndsWith(txtRicerca.Text))
                                {
                                    elenco = ($"Nome: {nome[i]}, Cognome: {cognome[i]} Email: {email[i]}, Simpatia: {simpatia[i]}, Anno di nascita: {annoNascita[i]}, Nickname: {nickname[i]}");
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Contiene":
                                if (nome[i].Contains(txtRicerca.Text))
                                {
                                    elenco = ($"Nome: {nome[i]}, Cognome: {cognome[i]} Email: {email[i]}, Simpatia: {simpatia[i]}, Anno di nascita: {annoNascita[i]}, Nickname: {nickname[i]}");
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Cognome":
                        switch (cmbOpzioni.Text)
                        {
                            case "":
                                if (txtRicerca.Text == cognome[i])
                                {
                                    elenco = ($"Nome: {nome[i]}, Cognome: {cognome[i]} Email: {email[i]}, Simpatia: {simpatia[i]}, Anno di nascita: {annoNascita[i]}, Nickname: {nickname[i]}");
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Inizia per":
                                if (cognome[i].StartsWith(txtRicerca.Text))
                                {
                                    elenco = ($"Nome: {nome[i]}, Cognome: {cognome[i]} Email: {email[i]}, Simpatia: {simpatia[i]}, Anno di nascita: {annoNascita[i]}, Nickname: {nickname[i]}");
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Finisce per":
                                if (cognome[i].EndsWith(txtRicerca.Text))
                                {
                                    elenco = ($"Nome: {nome[i]}, Cognome: {cognome[i]} Email: {email[i]}, Simpatia: {simpatia[i]}, Anno di nascita: {annoNascita[i]}, Nickname: {nickname[i]}");
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Contiene":
                                if (cognome[i].Contains(txtRicerca.Text))
                                {
                                    elenco = ($"Nome: {nome[i]}, Cognome: {cognome[i]} Email: {email[i]}, Simpatia: {simpatia[i]}, Anno di nascita: {annoNascita[i]}, Nickname: {nickname[i]}");
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Nickname":
                        switch (cmbOpzioni.Text)
                        {
                            case "":
                                if (txtRicerca.Text == nickname[i])
                                {
                                    elenco = ($"Nome: {nome[i]}, Cognome: {cognome[i]} Email: {email[i]}, Simpatia: {simpatia[i]}, Anno di nascita: {annoNascita[i]}, Nickname: {nickname[i]}");
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Inizia per":
                                if (nickname[i].StartsWith(txtRicerca.Text))
                                {
                                    elenco = ($"Nome: {nome[i]}, Cognome: {cognome[i]} Email: {email[i]}, Simpatia: {simpatia[i]}, Anno di nascita: {annoNascita[i]}, Nickname: {nickname[i]}");
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Finisce per":
                                if (nickname[i].EndsWith(txtRicerca.Text))
                                {
                                    elenco = ($"Nome: {nome[i]}, Cognome: {cognome[i]} Email: {email[i]}, Simpatia: {simpatia[i]}, Anno di nascita: {annoNascita[i]}, Nickname: {nickname[i]}");
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Contiene":
                                if (nickname[i].Contains(txtRicerca.Text))
                                {
                                    elenco = ($"Nome: {nome[i]}, Cognome: {cognome[i]} Email: {email[i]}, Simpatia: {simpatia[i]}, Anno di nascita: {annoNascita[i]}, Nickname: {nickname[i]}");
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            cognome[nRecordInseriti] = txtCognome.Text;
            nome[nRecordInseriti] = txtNome.Text;
            email[nRecordInseriti] = txtEmail.Text;
            nickname[nRecordInseriti] = txtNickName.Text;
            simpatia[nRecordInseriti] = Convert.ToInt32(cmbSimpatia.Text);
            annoNascita[nRecordInseriti] = Convert.ToInt32(txtAnnoNascita.Text);
            nRecordInseriti++;
            lblNRecord.Text = "N. record inseriti: " + nRecordInseriti;
            txtCognome.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtNickName.Text = "";
            cmbSimpatia.Text = "";
            txtAnnoNascita.Text = "";
        }

        private void btnElenca_Click(object sender, EventArgs e)
        {
            lstElenco.Items.Clear();
            for (int i = 0; i < nRecordInseriti; i++)
            {
                lstElenco.Items.Add($"Nome: {nome[i]}, Cognome: {cognome[i]} Email: {email[i]}, Simpatia: {simpatia[i]}, Anno di nascita: {annoNascita[i]}, Nickname: {nickname[i]}");
            }
        }
    }
}