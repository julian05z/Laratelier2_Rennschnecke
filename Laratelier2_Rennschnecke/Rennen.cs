using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laratelier2_Rennschnecke
{
    internal class Rennen
    {
        private String name;
        private int strecke = 0;
        public List<Rennschnecke> names = new List<Rennschnecke>();
       
        public Rennen(String name, int strecke)
        {
            this.name = name;
            this.strecke = strecke;

        }

        public void addRennschnecke(Rennschnecke neueSchnecke)
        {
           
            names.Add(neueSchnecke);

        }
        public Rennschnecke ermittleGewinner()
        {

            List<int> schneckenzeit = new List<int>();
            int index = 0;
            string pruefe = " ";


            foreach (Rennschnecke rennschnecke in names)
            {
                schneckenzeit.Add(rennschnecke.checkkriechedauer(strecke));
            }
            schneckenzeit.Sort();
            int abbb = schneckenzeit.Count;
            int a = schneckenzeit[abbb - 1];

            foreach (int i in schneckenzeit)
            {
                pruefe = pruefe + i + " ";
            }

            foreach(Rennschnecke sneke in names)
            {
                if(sneke.checkkriechedauer(strecke) == a)
                {
                     index = names.IndexOf(sneke);
                }
            }
         
            return names[1];
            
            
           
        }


        public String toString()
        {
            StringBuilder sb = new StringBuilder();


            Rennen rennen = this;
            sb.Append(rennen.name + "(" + rennen.names.ToString() + ") :" + strecke + "\n");


            foreach (Rennschnecke schneck in rennen.names)
            {
                sb.Append(name);

                sb.Append(" \n ");
            }


            if (rennen.ermittleGewinner() != null)
            {

                sb.Append("Gewinner:  ");
                sb.Append(rennen.ermittleGewinner());
            }
            else
            {
                sb.Append("Rennen noch nicht gestartet! ");
            }

            sb.Append(" \n ");


            return sb.ToString();
        }

        public List<Rennschnecke> getSchnecken()
        {
            return this.names;
        }

        public String getName()
        {
            return this.name;
        }



        public void lasseSchneckenKriechen()
        {
            Console.WriteLine("Die Schnecken kriechen");
        }


        public void durchfueren()
        {

            Console.WriteLine("Das Rennen " + name + " ist gerade im gange");

            while (ermittleGewinner() == null)
            {
                this.lasseSchneckenKriechen();
            }



        }

        public void getPrintString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Rennen: '");
            sb.Append(this.name);
            sb.Append("' Teilnehmer: ");
            sb.Append(names.Count());
            sb.Append(" Distanz: ");
            sb.Append(strecke);
            sb.Append("\n Schnecken: \n");
            sb.Append("Name \tRasse \tvMax \tStrecke \n");
            
            foreach (Rennschnecke snail in names)
            {
                sb.Append(snail.getname());
                sb.Append("\t");//zwischen den einzelnen Atributen der Schnecken wird ein TabStop eingefügt
                sb.Append(snail.getrasse());
                sb.Append("\t");
                sb.Append(snail.getvMax());
                sb.Append("\t"+"brauchte ");
                sb.Append(snail.checkkriechedauer(strecke) /60);
                sb.Append(" Minuten bis zum Ziel" + "\t\n");
            }// for

          
                sb.Append("Gewinner: "+ ermittleGewinner().name);
                
            

            sb.Append("\n");

           Console.WriteLine(sb.ToString());

        }


    }
}

