using System;
namespace lab4ex1
{
    class Dulap
    {

        private int lungime;
        private int latime;
        private int inaltime;



        public Dulap(int lungime, int latime, int inaltime)
        {

            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
        }


        public int GetLungime()
        {
            return lungime;
        }

        public int GetLatime()
        {
            return latime;
        }

        public int GetInaltime()
        {
            return inaltime;
        }

        public int GetVolume(int lungime, int latime, int inaltime)
        {

            int volume = lungime * latime * inaltime;

            return volume;
        }



    }
}
