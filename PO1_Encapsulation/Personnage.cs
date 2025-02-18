using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
        int pointDeVie;
        int attaque;
        int defense;
        int pointDeVieMaximal;


        public int PointDeVie
        {
            get => pointDeVie;
            set
            {
                if (value < 0)
                {
                    pointDeVie = 0;
                }
                else if(value > pointDeVieMaximal) 
                {
                    pointDeVie = pointDeVieMaximal;
                }
            }
        }

        public int Attaque { get => attaque; set => attaque = value; }
        public int Defense { get => defense; set => defense = value; }
        public bool EstMort
        {
            get
            {
                if (pointDeVie == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }
    }
}
