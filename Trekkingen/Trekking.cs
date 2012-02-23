using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trekkingen
{
    class Trekking
    {
        private int[] getrokkenGetallen;
        private bool[] komtAlVoor;
        private Random random;
        
        /// <summary>
        /// Maakt een trekking-object aan met de opgegeven parameters.
        /// </summary>
        /// <param name="maximaleWaarde"></param>
        /// <param name="aantalTrekkingen"></param>
        public Trekking(int maximaleWaarde, int aantalTrekkingen)
        {
            this.MaximaleWaarde = maximaleWaarde;
            this.AantalGewenst = aantalTrekkingen;
            this.getrokkenGetallen = new int[aantalTrekkingen];
            this.komtAlVoor = new bool[MaximaleWaarde + 1];
            this.random = new Random();
        }

        /// <summary>
        /// Geeft de maximale waarde van de te trekken getallen aan.
        /// </summary>
        public int MaximaleWaarde
        {
            get;
            private set;
        }

        /// <summary>
        /// Geeft het aantal getrokken getallen aan.
        /// </summary>
        public int AantalGetrokken
        {
            get;
            private set;
        }

        /// <summary>
        /// Geeft het gewenst aantal te trekken getallen aan.
        /// </summary>
        public int AantalGewenst
        {
            get;
            private set;
        }

        /// <summary>
        /// Geeft aan of het maximaal aantal te trekken getallen is bereikt.
        /// </summary>
        public bool IsTenEinde
        {
            get { return AantalGewenst == AantalGetrokken; }            
        }

        /// <summary>
        /// Trekt een getal binnen de range 1 t/m de maximale waarde.
        /// </summary>
        public void TrekGetal()
        {
            if (AantalGetrokken >= AantalGewenst) throw new Exception("Het maximaal aantal te trekken getallen is al bereikt!");

            int waarde;

            while (true)
            {
                waarde = random.Next(MaximaleWaarde) + 1; 

                if (!komtAlVoor[waarde])
                {
                    komtAlVoor[waarde] = true;
                    getrokkenGetallen[AantalGetrokken++] = waarde;
                    break;
                }                
            }            
        }

        /// <summary>
        /// Geeft het getal dat zich op de aangegeven index bevindt.
        /// </summary>
        /// <param name="index">De index van het getrokken getal binnen het array</param>
        /// <returns>Het getal dat zich op de aangegeven index binnen de array bevindt</returns>     
        /// <exception cref="IndexOutOfRangeException">De opgegeven index valt buiten het bereik van de array</exception>
        public int GeefGetal(int index)
        {
            try
            {
                return getrokkenGetallen[index];
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new ArgumentException("De opgegeven index valt buiten het bereik van de array!", "index", ex);
            }            
        }

        /// <summary>
        /// Sorteert alle getrokken getallen van klein naar groot.
        /// </summary>
        public void Sorteer()
        {
            for (int i = 0; i < getrokkenGetallen.Length; i++)
            {
                for (int j = getrokkenGetallen.Length - 1; j > i; j--)
                {
                    if (getrokkenGetallen[i] > getrokkenGetallen[j])
                    {                        
                        // xor swap algoritme:
                        getrokkenGetallen[i] ^= getrokkenGetallen[j];
                        getrokkenGetallen[j] ^= getrokkenGetallen[i];
                        getrokkenGetallen[i] ^= getrokkenGetallen[j];
                    }
                }
            }
        }
    }
}
