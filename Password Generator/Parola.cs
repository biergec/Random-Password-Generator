using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    abstract class Parola
    {
        public enum ParolaTipi
        {
            TumKarakterTipleri,
            OkunabilirYap,
            A_z,
            a_z,
            SifirdanDokuza,
            OzelKarakterler,
            BirIki,
            BirUc,
            BirDort,
            IkiUc,
            IkıDort,
            UcDort,

            BirIkıUc,
            BirIkiDort,
            BirUcDort
        }

        public string[] Rakamlar = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

        public string[] A_z_Karakterler = { "q", "w","e", "r","t","y","u","o","i","p","a","s",
                                    "d","f","g","h","j","k","l","z","x","c","v","b","n","m",
                                    "Q", "W","E", "R","T","Y","U","O","I","P","A",
                                    "S","D","F","G","H","J","K","L","Z","X","C","V","B",
                                    "N","M"};

        public string[] a_z_Karakterler = { "q", "w","e", "r","t","y","u","o","i","p","a","s",
                                    "d","f","g","h","j","k","l","z","x","c","v","b","n","m"};

        public string[] ozelKarakterler = {"!","'","^","+","%","&","/","(",")","=","?","_","-","*","|","$"};

    }

    class ParolaBelirle : Parola
    {
        private int parolaUzunlugu;
        private string uretilenParola;

        public int ParolaUzunlugu { get => parolaUzunlugu; set => parolaUzunlugu = value; }

        public ParolaBelirle(int parolaUzunlugu)
        {
            ParolaUzunlugu = parolaUzunlugu;
            uretilenParola = "";
        }

        public string IstenilenKarakterdeParolaBelirle()
        {
            Random rd = new Random();
            while (ParolaUzunlugu != uretilenParola.Length)
            {
                int x = rd.Next(0, A_z_Karakterler.Length);
                int xx = rd.Next(0, a_z_Karakterler.Length);
                int xxx = rd.Next(0, ozelKarakterler.Length);
                int xxxx = rd.Next(0, Rakamlar.Length);
                int sayimSirasi = rd.Next(1,4);

                if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi==1)
                {
                    uretilenParola += A_z_Karakterler[x].Trim();
                }
                if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 2)
                {
                    uretilenParola += ozelKarakterler[xxx].Trim();
                }
                if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 3)
                {
                    uretilenParola += a_z_Karakterler[xx].Trim();
                }
                if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 4)
                {
                    uretilenParola += Rakamlar[xxxx].Trim();
                }
            }
            return uretilenParola;
        }

    }

    class GelismisParolaBelirle : Parola
    {
        private int parolaUzunlugu;
        private string uretilenParola;

        private ParolaTipi parolaTipiEnum;
        private ParolaTipi parolaKarmasikligiEnum;

        public int ParolaUzunlugu { get => parolaUzunlugu; set => parolaUzunlugu = value; }
        internal ParolaTipi ParolaTipiEnum { get => parolaTipiEnum; set => parolaTipiEnum = value; }
        internal ParolaTipi ParolaKarmasikligiEnum { get => parolaKarmasikligiEnum; set => parolaKarmasikligiEnum = value; }

        public GelismisParolaBelirle(int parolaUzunlugu, ParolaTipi parolaTipiEnum, ParolaTipi parolaKarmasikligiEnum)
        {
            ParolaUzunlugu = parolaUzunlugu;
            ParolaTipiEnum = parolaTipiEnum;
            ParolaKarmasikligiEnum = parolaKarmasikligiEnum;
            uretilenParola = "";
        }

        public string IstenilenKarakterdeParolaBelirle()
        {
            //ParolaBelirle parola = new ParolaBelirle(ParolaUzunlugu);
            //return parola.IstenilenKarakterdeParolaBelirle();

            // burada tekli ve arasında kombinasyonlarını belirtmek zorundayız.
            if (ParolaKarmasikligiEnum == ParolaTipi.TumKarakterTipleri)
            {
                if (ParolaTipiEnum == ParolaTipi.A_z)
                    return TekTipIstenilenKarakterdeParolaBelirle(A_z_Karakterler);

                if (ParolaTipiEnum == ParolaTipi.a_z)
                    return TekTipIstenilenKarakterdeParolaBelirle(a_z_Karakterler);

                if (ParolaTipiEnum == ParolaTipi.OzelKarakterler)
                    return TekTipIstenilenKarakterdeParolaBelirle(ozelKarakterler);

                if (ParolaTipiEnum == ParolaTipi.SifirdanDokuza)
                    return TekTipIstenilenKarakterdeParolaBelirle(Rakamlar);

                if (ParolaTipiEnum == ParolaTipi.BirIki)
                    return GelismisIstenilenKarakterdeParolaBelirle(ParolaTipi.BirIki);

                if (ParolaTipiEnum == ParolaTipi.BirUc)
                    return GelismisIstenilenKarakterdeParolaBelirle(ParolaTipi.BirUc);

                if (ParolaTipiEnum == ParolaTipi.BirDort)
                    return GelismisIstenilenKarakterdeParolaBelirle(ParolaTipi.BirDort);

                if (ParolaTipiEnum == ParolaTipi.IkiUc)
                    return GelismisIstenilenKarakterdeParolaBelirle(ParolaTipi.IkiUc);

                if (ParolaTipiEnum == ParolaTipi.IkıDort)
                    return GelismisIstenilenKarakterdeParolaBelirle(ParolaTipi.IkıDort);

                if (ParolaTipiEnum == ParolaTipi.UcDort)
                    return GelismisIstenilenKarakterdeParolaBelirle(ParolaTipi.UcDort);

                if (ParolaTipiEnum == ParolaTipi.BirIkıUc)
                    return GelismisIstenilenKarakterdeParolaBelirle(ParolaTipi.BirIkıUc);

                if (ParolaTipiEnum == ParolaTipi.BirIkiDort)
                    return GelismisIstenilenKarakterdeParolaBelirle(ParolaTipi.BirIkiDort);

                if (ParolaTipiEnum == ParolaTipi.BirUcDort)
                    return GelismisIstenilenKarakterdeParolaBelirle(ParolaTipi.BirUcDort);
            }

            // Okunabilir parolalar için 2 seçenekbulunmakta
            if (ParolaKarmasikligiEnum == ParolaTipi.OkunabilirYap)
            {
                return TekTipIstenilenKarakterdeParolaBelirle(A_z_Karakterler);
            }

            return null;
        }

        private string GelismisIstenilenKarakterdeParolaBelirle(ParolaTipi parolaTipi)
        {
            Random rd = new Random();

            if (ParolaTipiEnum == ParolaTipi.BirIki)
            {
                while (ParolaUzunlugu != uretilenParola.Length)
                {
                    int x = rd.Next(0, A_z_Karakterler.Length);
                    int xxxx = rd.Next(0, Rakamlar.Length);
                    int sayimSirasi = rd.Next(1, 3);

                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 1)
                        uretilenParola += A_z_Karakterler[x].Trim();
                  
                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 2)
                        uretilenParola += Rakamlar[xxxx].Trim();
                }
                return uretilenParola;
            }
            else if (ParolaTipiEnum == ParolaTipi.BirUc)
            {
                while (ParolaUzunlugu != uretilenParola.Length)
                {
                    int x = rd.Next(0, A_z_Karakterler.Length);
                    int xx = rd.Next(0, a_z_Karakterler.Length);
                    int sayimSirasi = rd.Next(1, 3);

                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 1)
                        uretilenParola += A_z_Karakterler[x].Trim();
                   
                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 2)
                        uretilenParola += a_z_Karakterler[xx].Trim();
                }
                return uretilenParola;
            }
            else if(ParolaTipiEnum == ParolaTipi.BirDort)
            {
                while (ParolaUzunlugu != uretilenParola.Length)
                {
                    int x = rd.Next(0, A_z_Karakterler.Length);
                    int xxx = rd.Next(0, ozelKarakterler.Length);
                    int sayimSirasi = rd.Next(1, 3);

                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 1)
                        uretilenParola += A_z_Karakterler[x].Trim();

                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 2)
                        uretilenParola += ozelKarakterler[xxx].Trim();
                }
                return uretilenParola;
            }
            else if(ParolaTipiEnum == ParolaTipi.IkiUc)
            {
                while (ParolaUzunlugu != uretilenParola.Length)
                {
                    int xx = rd.Next(0, a_z_Karakterler.Length);
                    int xxxx = rd.Next(0, Rakamlar.Length);
                    int sayimSirasi = rd.Next(1, 3);

                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 1)
                        uretilenParola += a_z_Karakterler[xx].Trim();

                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 2)
                        uretilenParola += Rakamlar[xxxx].Trim();
                }
                return uretilenParola;
            }
            else if(ParolaTipiEnum == ParolaTipi.IkıDort)
            {
                while (ParolaUzunlugu != uretilenParola.Length)
                {
                    int xxx = rd.Next(0, ozelKarakterler.Length);
                    int xxxx = rd.Next(0, Rakamlar.Length);
                    int sayimSirasi = rd.Next(1, 3);
                   
                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 1)
                        uretilenParola += ozelKarakterler[xxx].Trim();
                   
                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 2)
                        uretilenParola += Rakamlar[xxxx].Trim();
                }
                return uretilenParola;
            }
            else if (ParolaTipiEnum == ParolaTipi.BirUcDort)
            {
                while (ParolaUzunlugu != uretilenParola.Length)
                {
                    int x = rd.Next(0, A_z_Karakterler.Length);
                    int xxx = rd.Next(0, ozelKarakterler.Length);
                    int xxxx = rd.Next(0, Rakamlar.Length);
                    int sayimSirasi = rd.Next(1, 4);

                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 1)
                        uretilenParola += A_z_Karakterler[x].Trim();

                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 2)
                        uretilenParola += ozelKarakterler[xxx].Trim();
                    
                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 3)
                        uretilenParola += Rakamlar[xxxx].Trim();
                }
                return uretilenParola;
            }
            else if (ParolaTipiEnum == ParolaTipi.BirIkıUc)
            {
                while (ParolaUzunlugu != uretilenParola.Length)
                {
                    int x = rd.Next(0, A_z_Karakterler.Length);
                    int xx = rd.Next(0, a_z_Karakterler.Length);
                    int xxxx = rd.Next(0, Rakamlar.Length);
                    int sayimSirasi = rd.Next(1, 4);

                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 1)
                        uretilenParola += A_z_Karakterler[x].Trim();

                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 2)
                        uretilenParola += a_z_Karakterler[xx].Trim();

                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 3)
                        uretilenParola += Rakamlar[xxxx].Trim();
                }
                return uretilenParola;
            }
            else if (ParolaTipiEnum == ParolaTipi.BirIkiDort)
            {
                while (ParolaUzunlugu != uretilenParola.Length)
                {
                    int x = rd.Next(0, A_z_Karakterler.Length);
                    int xxx = rd.Next(0, ozelKarakterler.Length);
                    int xxxx = rd.Next(0, Rakamlar.Length);
                    int sayimSirasi = rd.Next(1, 4);

                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 1)
                        uretilenParola += A_z_Karakterler[x].Trim();

                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 2)
                        uretilenParola += ozelKarakterler[xxx].Trim();

                    if (ParolaUzunlugu != uretilenParola.Length && sayimSirasi == 3)
                        uretilenParola += Rakamlar[xxxx].Trim();
                }
                return uretilenParola;
            }
            return null;
        }

        private string TekTipIstenilenKarakterdeParolaBelirle(string[] dizi)
        {
            Random rd = new Random();

            while (ParolaUzunlugu != uretilenParola.Length)
            {
                int x = rd.Next(0, dizi.Length);

                if (ParolaUzunlugu != uretilenParola.Length)
                {
                    uretilenParola += dizi[x].Trim();
                }
            }

            return uretilenParola;
        }

    }

}
