using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectTestKana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kana> lesHiragana = new List<Kana>();
        List<Kana> lesKatakana = new List<Kana>();

        List<Kana> copieLesHiragana = new List<Kana>();
        List<Kana> copieLesKatakana = new List<Kana>();

        private Button btnInvisibleFocus;
        private Button btnHiragana;
        private Button btnKatakana;
        private Button btnScore;
        private bool btnKanaChoixFait;

        private PictureBox logoTSK;

        List<Score> lesScores = new List<Score>();
        private ListBox lstScore;
        private bool creerLstScoreFait;
        private Button btnMenuScore;
        string note;
        string dateHeure;
        bool premierScoreFait = false;

        List<Button> lesBtnNbChoix = new List<Button>();
        private Label lblNbChoix;
        private Button btnNbChoix;
        private bool nbChoixFait = false;

        private string infoKanaChoisi;
        private int nbQuestion;
        private int questionCount = 0;
        private int bonneReponse = 0;

        //private string nomFichSauv = "testScores";

        private void RemplirKana()
        {
            Hiragana hirA = new Hiragana('あ', "a");
            lesHiragana.Add(hirA);
            Hiragana hirI = new Hiragana('い', "i");
            lesHiragana.Add(hirI);
            Hiragana hirU = new Hiragana('う', "u");
            lesHiragana.Add(hirU);
            Hiragana hirE = new Hiragana('え', "e");
            lesHiragana.Add(hirE);
            Hiragana hirO = new Hiragana('お', "o");
            lesHiragana.Add(hirO);

            Hiragana hirKa = new Hiragana('か', "ka");
            lesHiragana.Add(hirKa);
            Hiragana hirKi = new Hiragana('き', "ki");
            lesHiragana.Add(hirKi);
            Hiragana hirKu = new Hiragana('く', "ku");
            lesHiragana.Add(hirKu);
            Hiragana hirKe = new Hiragana('け', "ke");
            lesHiragana.Add(hirKe);
            Hiragana hirKo = new Hiragana('こ', "ko");
            lesHiragana.Add(hirKo);

            Hiragana hirSa = new Hiragana('さ', "*");
            lesHiragana.Add(hirSa);
            Hiragana hirShi = new Hiragana('し', "shi");
            lesHiragana.Add(hirShi);
            Hiragana hirSu = new Hiragana('す', "su");
            lesHiragana.Add(hirSu);
            Hiragana hirSe = new Hiragana('せ', "se");
            lesHiragana.Add(hirSe);
            Hiragana hirSo = new Hiragana('そ', "so");
            lesHiragana.Add(hirSo);

            Hiragana hirTa = new Hiragana('た', "ta");
            lesHiragana.Add(hirTa);
            Hiragana hirChi = new Hiragana('ち', "chi");
            lesHiragana.Add(hirChi);
            Hiragana hirTsu = new Hiragana('つ', "tsu");
            lesHiragana.Add(hirTsu);
            Hiragana hirTe = new Hiragana('て', "te");
            lesHiragana.Add(hirTe);
            Hiragana hirTo = new Hiragana('と', "to");
            lesHiragana.Add(hirTo);

            Hiragana hirNa = new Hiragana('な', "na");
            lesHiragana.Add(hirNa);
            Hiragana hirNi = new Hiragana('に', "ni");
            lesHiragana.Add(hirNi);
            Hiragana hirNu = new Hiragana('ぬ', "nu");
            lesHiragana.Add(hirNu);
            Hiragana hirNe = new Hiragana('ね', "ne");
            lesHiragana.Add(hirNe);
            Hiragana hirNo = new Hiragana('の', "no");
            lesHiragana.Add(hirNo);

            Hiragana hirHa = new Hiragana('は', "ha");
            lesHiragana.Add(hirHa);
            Hiragana hirHi = new Hiragana('ひ', "hi");
            lesHiragana.Add(hirHi);
            Hiragana hirFu = new Hiragana('ふ', "fu");
            lesHiragana.Add(hirFu);
            Hiragana hirHe = new Hiragana('へ', "he");
            lesHiragana.Add(hirHe);
            Hiragana hirHo = new Hiragana('ほ', "ho");
            lesHiragana.Add(hirHo);

            Hiragana hirMa = new Hiragana('ま', "ma");
            lesHiragana.Add(hirMa);
            Hiragana hirMi = new Hiragana('み', "mi");
            lesHiragana.Add(hirMi);
            Hiragana hirMu = new Hiragana('む', "mu");
            lesHiragana.Add(hirMu);
            Hiragana hirMe = new Hiragana('め', "me");
            lesHiragana.Add(hirMe);
            Hiragana hirMo = new Hiragana('も', "mo");
            lesHiragana.Add(hirMo);

            Hiragana hirRa = new Hiragana('ら', "ra");
            lesHiragana.Add(hirRa);
            Hiragana hirRi = new Hiragana('り', "ri");
            lesHiragana.Add(hirRi);
            Hiragana hirRu = new Hiragana('る', "ru");
            lesHiragana.Add(hirRu);
            Hiragana hirRe = new Hiragana('れ', "re");
            lesHiragana.Add(hirRe);
            Hiragana hirRo = new Hiragana('ろ', "ro");
            lesHiragana.Add(hirRo);

            Hiragana hirWa = new Hiragana('わ', "wa");
            lesHiragana.Add(hirWa);
            Hiragana hirWo = new Hiragana('を', "wo");
            lesHiragana.Add(hirWo);

            Hiragana hirYa = new Hiragana('や', "ya");
            lesHiragana.Add(hirYa);
            Hiragana hirYu = new Hiragana('ゆ', "yu");
            lesHiragana.Add(hirYu);
            Hiragana hirYo = new Hiragana('よ', "yo");
            lesHiragana.Add(hirYo);

            Hiragana hirN = new Hiragana('ん', "n");
            lesHiragana.Add(hirN);

            copieLesHiragana.AddRange(lesHiragana);

            Hiragana katA = new Hiragana('ア', "a");
            lesKatakana.Add(katA);
            Hiragana katI = new Hiragana('イ', "i");
            lesKatakana.Add(katI);
            Hiragana katU = new Hiragana('ウ', "u");
            lesKatakana.Add(katU);
            Hiragana katE = new Hiragana('エ', "e");
            lesKatakana.Add(katE);
            Hiragana katO = new Hiragana('オ', "o");
            lesKatakana.Add(katO);

            Hiragana katKa = new Hiragana('カ', "ka");
            lesKatakana.Add(katKa);
            Hiragana katKi = new Hiragana('キ', "ki");
            lesKatakana.Add(katKi);
            Hiragana katKu = new Hiragana('ク', "ku");
            lesKatakana.Add(katKu);
            Hiragana katKe = new Hiragana('ケ', "ke");
            lesKatakana.Add(katKe);
            Hiragana katKo = new Hiragana('コ', "ko");
            lesKatakana.Add(katKo);

            Hiragana katSa = new Hiragana('サ', "sa");
            lesKatakana.Add(katSa);
            Hiragana katShi = new Hiragana('シ', "shi");
            lesKatakana.Add(katShi);
            Hiragana katSu = new Hiragana('ス', "su");
            lesKatakana.Add(katSu);
            Hiragana katSe = new Hiragana('セ', "se");
            lesKatakana.Add(katSe);
            Hiragana katSo = new Hiragana('ソ', "so");
            lesKatakana.Add(katSo);

            Hiragana katTa = new Hiragana('タ', "ta");
            lesKatakana.Add(katTa);
            Hiragana katChi = new Hiragana('チ', "chi");
            lesKatakana.Add(katChi);
            Hiragana katTsu = new Hiragana('ツ', "tsu");
            lesKatakana.Add(katTsu);
            Hiragana katTe = new Hiragana('テ', "te");
            lesKatakana.Add(katTe);
            Hiragana katTo = new Hiragana('ト', "to");
            lesKatakana.Add(katTo);

            Hiragana katNa = new Hiragana('ナ', "na");
            lesKatakana.Add(katNa);
            Hiragana katNi = new Hiragana('ニ', "ni");
            lesKatakana.Add(katNi);
            Hiragana katNu = new Hiragana('ヌ', "nu");
            lesKatakana.Add(katNu);
            Hiragana katNe = new Hiragana('ネ', "ne");
            lesKatakana.Add(katNe);
            Hiragana katNo = new Hiragana('ノ', "no");
            lesKatakana.Add(katNo);

            Hiragana katHa = new Hiragana('ハ', "ha");
            lesKatakana.Add(katHa);
            Hiragana katHi = new Hiragana('ヒ', "hi");
            lesKatakana.Add(katHi);
            Hiragana katFu = new Hiragana('フ', "fu");
            lesKatakana.Add(katFu);
            Hiragana katHe = new Hiragana('ヘ', "he");
            lesKatakana.Add(katHe);
            Hiragana katHo = new Hiragana('ホ', "ho");
            lesKatakana.Add(katHo);

            Hiragana katMa = new Hiragana('マ', "ma");
            lesKatakana.Add(katMa);
            Hiragana katMi = new Hiragana('ミ', "mi");
            lesKatakana.Add(katMi);
            Hiragana katMu = new Hiragana('ム', "mu");
            lesKatakana.Add(katMu);
            Hiragana katMe = new Hiragana('メ', "me");
            lesKatakana.Add(katMe);
            Hiragana katMo = new Hiragana('モ', "mo");
            lesKatakana.Add(katMo);

            Hiragana katRa = new Hiragana('ラ', "ra");
            lesKatakana.Add(katRa);
            Hiragana katRi = new Hiragana('リ', "ri");
            lesKatakana.Add(katRi);
            Hiragana katRu = new Hiragana('ル', "ru");
            lesKatakana.Add(katRu);
            Hiragana katRe = new Hiragana('レ', "re");
            lesKatakana.Add(katRe);
            Hiragana katRo = new Hiragana('ロ', "ro");
            lesKatakana.Add(katRo);

            Hiragana katWa = new Hiragana('ワ', "wa");
            lesKatakana.Add(katWa);
            Hiragana katWo = new Hiragana('ヲ', "wo");
            lesKatakana.Add(katWo);

            Hiragana katYa = new Hiragana('ヤ', "ya");
            lesKatakana.Add(katYa);
            Hiragana katYu = new Hiragana('ユ', "yu");
            lesKatakana.Add(katYu);
            Hiragana katYo = new Hiragana('ヨ', "yo");
            lesKatakana.Add(katYo);

            Hiragana katN = new Hiragana('ン', "n");
            lesKatakana.Add(katN);

            copieLesKatakana.AddRange(lesKatakana);
        }

        private void MenuApp()
        {
            CacherTest();
            if (!btnKanaChoixFait)
            {
                CreerBoutonsMenu();
            }
            else
            {
                MontrerMenu();
            }
        }

        private void MontrerMenu()
        {
            btnHiragana.Visible = true;
            btnKatakana.Visible = true;
            btnScore.Visible = true;
            logoTSK.Visible = true;
        }

        private void CacherTest()
        {
            grpTestKana.Visible = false;
        }

        private void MontrerTest()
        {
            grpTestKana.Visible = true;
            PreparationTest();
        }

        private void CacherScore()
        {
            btnMenuScore.Visible = false;
            lstScore.Visible = false;
        }

        private void MontrerScore()
        {
            btnMenuScore.Visible = true;
            lstScore.Visible = true;
        }

        private void CreerBoutonsMenu()
        {
            //focus sur btn invisble hors champ quand l'app start

            btnInvisibleFocus = new Button();
            Controls.Add(btnInvisibleFocus);
            btnInvisibleFocus.Location = new Point(-500, -500);
            btnInvisibleFocus.Focus();

            btnHiragana = new Button();
            btnKatakana = new Button();
            btnScore = new Button();

            logoTSK = new PictureBox();

            Controls.Add(btnHiragana);
            Controls.Add(btnKatakana);
            Controls.Add(btnScore);

            Controls.Add(logoTSK);

            btnHiragana.Location = new Point(28, 100);
            btnHiragana.Size = new Size(250, 75);
            btnHiragana.Text = "Hiragana Test";
            btnHiragana.TabIndex = 1;

            btnKatakana.Location = new Point(28, 180);
            btnKatakana.Size = new Size(250, 75);
            btnKatakana.Text = "Katakana Test";
            btnKatakana.TabIndex = 2;

            btnScore.Location = new Point(28, 265);
            btnScore.Size = new Size(250, 50);
            btnScore.Text = "Tableau des scores";
            btnScore.TabIndex = 3;

            logoTSK.Location = new Point(19, 20);
            logoTSK.Size = new Size(268, 62);
            logoTSK.Image = Properties.Resources.ToTsuKu_SimpleKana_img_typo;
            logoTSK.SizeMode = PictureBoxSizeMode.Zoom;

            btnHiragana.Click += new EventHandler(btnHiragana_Click);
            btnKatakana.Click += new EventHandler(btnKatakana_Click);
            btnScore.Click += new EventHandler(btnScore_Click);

            btnKanaChoixFait = true;
        }

        private void CreerTableauScore()
        {
            lstScore = new ListBox();
            btnMenuScore = new Button();

            Controls.Add(lstScore);
            Controls.Add(btnMenuScore);

            lstScore.Location = new Point(12, 47);
            lstScore.Size = new Size(283, 277);

            btnMenuScore.Location = new Point(12, 12);
            btnMenuScore.Size = new Size(90, 30);
            btnMenuScore.TabIndex = 1;
            
            btnMenuScore.Text = "Menu";

            btnMenuScore.Click += new EventHandler(btnMenuScore_Click);

            //Object objSauv = Serialise.Recup(nomFichSauv);

            /*
            if(objSauv != null)
            {
                premierScoreFait = true;
                lesScores = (List<Score>)objSauv;
                MajLstScore();
            }
            */

            creerLstScoreFait = true;

        }

        private void CacherMenu()
        {
            btnHiragana.Visible = false;
            btnKatakana.Visible = false;
            btnScore.Visible = false;
            logoTSK.Visible = false;
            btnInvisibleFocus.Visible = false;
        }

        private void CreerBoutonsNbChoix()
        {
            Font maPolice = new Font("UD Digi Kyokasho NK-B", 13, FontStyle.Bold);
            lblNbChoix = new Label();
            Controls.Add(lblNbChoix);

            lblNbChoix.Text = "Nombre de Kana à tester :";
            lblNbChoix.Location = new Point(23, 20);
            lblNbChoix.AutoSize = true;
            lblNbChoix.Font = maPolice;

            for(int k = 0; k < 3; k++)
            {
                btnNbChoix = new Button();
                Controls.Add(btnNbChoix);
                btnNbChoix.Location = new Point(28, 60 + 90 * k);
                btnNbChoix.Size = new Size(250, 70);

                switch (k)
                {
                    case 0:
                        btnNbChoix.Text = "10";
                        break;
                    case 1:
                        btnNbChoix.Text = "20";
                        break;
                    case 2:
                        btnNbChoix.Text = "46";
                        break;
                }

                lesBtnNbChoix.Add(btnNbChoix);
                btnNbChoix.Click += new EventHandler(btnNbChoix_Click);
            }

            nbChoixFait = true;
        }

        private void CacherNbChoix()
        {
            lblNbChoix.Visible = false;

            foreach (Button btn in lesBtnNbChoix)
            {
                btn.Visible = false;
            }
        }

        private void MontrerNbChoix()
        {
            lblNbChoix.Visible = true;

            foreach (Button btn in lesBtnNbChoix)
            {
                btn.Visible = true;
            }
        }

        private void QuestionChar()
        {
            char questionKana;
            string questionResult;

            questionCount++;
            txtResult.Focus();

            grpTestKana.Text = "Test " + infoKanaChoisi + " n° " + 
                questionCount + "/ " + nbQuestion;
            txtKana.Text = "";
            txtResult.Text = "";
            txtResult.BackColor = Color.White;
            lblResult.Text = "";
            lblResult.Visible = false;

            Random rnd1 = new Random();
            int rndIndexHiragana = rnd1.Next(0, lesHiragana.Count);

            Random rnd2 = new Random();
            int rndIndexKatakana = rnd2.Next(0, lesKatakana.Count);
 
            if (infoKanaChoisi.Equals("Hiragana"))
            {
                questionKana = lesHiragana[rndIndexHiragana].getKana();
                questionResult = lesHiragana[rndIndexHiragana].getRomaji();
                lesHiragana.RemoveAt(rndIndexHiragana);
            }
            else
            {
                questionKana = lesKatakana[rndIndexKatakana].getKana();
                questionResult = lesKatakana[rndIndexKatakana].getRomaji();
                lesKatakana.RemoveAt(rndIndexKatakana);
            }

            txtKana.Text = questionKana.ToString();
            lblResult.Text = questionResult;
        }

        private void QuestionReset()
        {
            questionCount = 0;
            bonneReponse = 0;
            txtNote1.Text = "";
            if (infoKanaChoisi.Equals("Hiragana"))
            {
                lesHiragana.Clear();
                lesHiragana.AddRange(copieLesHiragana);
            }
            else
            {
                lesKatakana.Clear();
                lesKatakana.AddRange(copieLesKatakana);
            }
            
        }

        private void PreparationTest()
        {
            txtResult.Enabled = true;
            txtResult.Focus();
            txtNote1.Enabled = false;
            txtNote2.Enabled = false;
            txtNote2.Text = nbQuestion.ToString();
            btnEnter.Enabled = false;
            lblOmedeto.Visible = false;
        }

        private void AjouterScore()
        {
            note = "(" + txtNote1.Text + "/" + txtNote2.Text + ")";
            DateTime dateEtHeureActuelles = DateTime.Now;
            dateHeure = dateEtHeureActuelles.ToShortDateString() + " " + dateEtHeureActuelles.ToShortTimeString();

            Score unScoreFinal = new Score(infoKanaChoisi, note, dateHeure);
            lesScores.Add(unScoreFinal);
            MajLstScore();

            //SauvTableauScore();

            premierScoreFait = true;
        }

        private void MajLstScore()
        {
            lstScore.Items.Clear();
            foreach(Score unScore in lesScores)
            {
                lstScore.Items.Insert(0, unScore.getInfos());
                if (premierScoreFait)
                {
                    TriScore();
                }
            }
        }

        private void TriScore()
        {
            for (int k = lstScore.Items.Count - 1; k >= 0; k--)
            {
                lstScore.Items.Insert(k + 1, lstScore.Items[k]);
                lstScore.Items.Remove(lstScore.Items[k]);
            }
        }

        /*
        private void SauvTableauScore()
        {
            Serialise.Sauve(nomFichSauv, lesScores);
        }
        */

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuApp();
            RemplirKana();
        }

        private void btnHiragana_Click(object sender, EventArgs e)
        {
            infoKanaChoisi = "Hiragana";
            CacherMenu();
            if (!nbChoixFait)
            {
                CreerBoutonsNbChoix();
            }
            else
            {
                MontrerNbChoix();
            }
        }

        private void btnKatakana_Click(object sender, EventArgs e)
        {
            infoKanaChoisi = "Katakana";
            CacherMenu();
            if (!nbChoixFait)
            {
                CreerBoutonsNbChoix();
            }
            else
            {
                MontrerNbChoix();
            }
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            CacherMenu();
            if (!creerLstScoreFait)
            {
                CreerTableauScore();
            }
            else
            {
                MontrerScore();
            }
            
        }

        private void btnMenuScore_Click(object sender, EventArgs e)
        {
            CacherScore();
            MontrerMenu();
        }

        private void btnNbChoix_Click(object sender, EventArgs e)
        {
            Button btnChoisi = (Button)sender;
            nbQuestion = int.Parse(btnChoisi.Text);
            MontrerTest();
            CacherNbChoix();

            QuestionChar();
        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (txtResult.Text.ToLower().Equals(lblResult.Text))
                {
                    txtResult.BackColor = Color.Green;
                    bonneReponse++;
                }
                else
                {
                    txtResult.BackColor = Color.Red;
                    lblResult.Visible = true;
                }

                btnEnter.Enabled = true;
                btnEnter.Focus();

                txtNote1.Text = bonneReponse.ToString();
                

                if (questionCount.Equals(nbQuestion))
                {
                    if (bonneReponse.Equals(nbQuestion))
                    {
                        lblOmedeto.Visible = true;
                    }

                    if (!creerLstScoreFait)
                    {
                        CreerTableauScore();
                        CacherScore();
                    }

                    AjouterScore();

                    txtResult.Enabled = false;
                    btnEnter.Enabled = false;
                    btnReset.Focus();
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            QuestionChar();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            QuestionReset();
            QuestionChar();
            PreparationTest();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            QuestionReset();
            MenuApp();
        }
    }
}
