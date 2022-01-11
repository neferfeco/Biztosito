using System;

namespace Biztosito
{
    class Szerzodes
    {
        public string szerzodesSzam;
        public string ugyfelNev;
        public bool ugyfelNeme;
        //nő: true, férfi: false
        public string rendszam;
        public bool dijBefizetesTipusa;
        //false: féléves díj, true: éves díj
        public int biztositasFelevesDija;



        public Szerzodes() {}

        public Szerzodes(string szerzodes, string nev, bool nem, string rendszam, bool tipus, int dij) {

            szerzodesSzam = szerzodes;
            ugyfelNev = nev;
            ugyfelNeme = nem;
            this.rendszam = rendszam;
            dijBefizetesTipusa = tipus;
            biztositasFelevesDija = dij;
        }



        public string getSzerzodesSzam() { return szerzodesSzam; }
        public string getUgyfelNev() { return ugyfelNev; } 
        public bool getUgyfelNeme() { return ugyfelNeme; }
        public string getRendszam() { return rendszam; }
        public bool getDijBefizetesTipusa() { return dijBefizetesTipusa; }
        public int getBiztositasFelevesDija() { return biztositasFelevesDija; }



        public void setSzerzodesSzam(string szerzodes) { szerzodesSzam = szerzodes; }
        public void setUgyfelNev(string nev) { ugyfelNev = nev; } 
        public void setUgyfelNeme(bool nem) { ugyfelNeme = nem; }
        public void setRendszam(string rendszam) { this.rendszam = rendszam; }
        public void setDijBefizetesTipusa(bool tipus ) { dijBefizetesTipusa = tipus; }
        public void setBiztositasFelevesDija(int dij) { biztositasFelevesDija = dij; }










    }
}


