namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur;
        Personnage monstre;

        public Form1()

        {
            InitializeComponent();
            joueur = new Personnage();
            joueur.PointDeVieMaximal = 10;
            joueur.PointDeVie = 10;
            joueur.Attaque = 1;
            monstre = new Personnage();
            monstre.PointDeVie = 30;
            monstre.Attaque = 3;
            actualierAffichage();


        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            monstre.PointDeVie = monstre.PointDeVie - joueur.Attaque;
            joueur.PointDeVie = joueur.PointDeVie - monstre.Attaque;
            actualierAffichage();
            if (joueur.EstMort)
            {
                MessageBox.Show("VOUS ETES MORT");

            }

        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            joueur.PointDeVie += 5;
            joueur.PointDeVie = joueur.PointDeVie - monstre.Attaque;
            actualierAffichage();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            joueur.Attaque += 4;
            joueur.PointDeVie = joueur.PointDeVie - monstre.Attaque;
            actualierAffichage();
            if (joueur.EstMort)
            {
                MessageBox.Show("VOUS ETES MORT");

            }
        }

        private void gb_joueur_Enter(object sender, EventArgs e)
        {

        }
        private void actualierAffichage()
        {
            lbl_pointsVieJoueur.Text = "point de vie : " + joueur.PointDeVie;
            lbl_pointsVieDragon.Text = "point de vie : " + monstre.PointDeVie;
            lbl_puissanceAttaqueJoueur.Text = "puissance d'attaque :" + joueur.Attaque;
            lbl_puissanceAttaqueDragon.Text =" puissance d'attaque :" + monstre.Attaque;
        }
    }
}