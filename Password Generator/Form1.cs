using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_ParolaUzunlugu.SelectedIndex=0;
        }

        // parola uzunluğu girilmemiş ise otomatik 6 karakterli üretir.
        int parolaUzunlugu = 6;
        GelismisParolaBelirle gelismisParolaBelirle;
        string parolaMetni;

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_GelismisAyarlar.Hide();
        }

        private void button_ParolaUret_Click(object sender, EventArgs e)
        {
            if (checkBox_GelismisAyarlariGoster.Checked==false)
            {
                // Combobox boş ise otomatik olarak 6 haneli üretilsin
                if (comboBox_ParolaUzunlugu.Text != "")
                {
                    parolaUzunlugu = int.Parse(comboBox_ParolaUzunlugu.Text);
                }
                ParolaBelirle parolaBelirle = new ParolaBelirle(parolaUzunlugu);
                string parola = parolaBelirle.IstenilenKarakterdeParolaBelirle();

                textBox_ParolaMetni.Text = parola;
            }else if (checkBox_GelismisAyarlariGoster.Checked==true)
            {
                bool A_z = false, rakamlar = false, a_z = false,ozelKarakterler=false;

                A_z = checkBox_A_z.Checked;
                ozelKarakterler = checkBox_OzelKarakter.Checked;
                rakamlar = checkBox_Rakamlar.Checked;
                a_z = checkBox_aa_zz.Checked;

                if (radioButton_TumKarakterTiplerineIzinVer.Checked==true)
                {
                    // hiçbiri seçili değilse normal karışık üretsin ve okunabilir yap seçili değilse
                    if (!((A_z && ozelKarakterler && rakamlar && a_z)) && radioButton_OkunabilirYap.Checked==false)
                    {
                        // Combobox boş ise otomatik olarak 6 haneli üretilsin
                        if (comboBox_ParolaUzunlugu.Text != "")
                        {
                            parolaUzunlugu = int.Parse(comboBox_ParolaUzunlugu.Text);
                        }
                        ParolaBelirle parolaBelirle = new ParolaBelirle(parolaUzunlugu);
                        string parola = parolaBelirle.IstenilenKarakterdeParolaBelirle();

                        textBox_ParolaMetni.Text = parola;
                        return;
                    }

                    if (A_z && a_z && ozelKarakterler)
                    {
                        //BirUcDort
                        gelismisParolaBelirle = new GelismisParolaBelirle(parolaUzunlugu, Parola.ParolaTipi.BirUcDort, Parola.ParolaTipi.TumKarakterTipleri);
                        parolaMetni = gelismisParolaBelirle.IstenilenKarakterdeParolaBelirle();
                        textBox_ParolaMetni.Text = parolaMetni;
                        return;
                    }
                    else if (A_z && rakamlar && ozelKarakterler)
                    {
                        //BirIkiDort
                        gelismisParolaBelirle = new GelismisParolaBelirle(parolaUzunlugu, Parola.ParolaTipi.BirIkiDort, Parola.ParolaTipi.TumKarakterTipleri);
                        parolaMetni = gelismisParolaBelirle.IstenilenKarakterdeParolaBelirle();
                        textBox_ParolaMetni.Text = parolaMetni;
                        return;
                    }
                    else if (A_z && rakamlar && a_z)
                    {
                        //BirIkıUc
                        gelismisParolaBelirle = new GelismisParolaBelirle(parolaUzunlugu, Parola.ParolaTipi.BirIkıUc, Parola.ParolaTipi.TumKarakterTipleri);
                        parolaMetni = gelismisParolaBelirle.IstenilenKarakterdeParolaBelirle();
                        textBox_ParolaMetni.Text = parolaMetni;
                        return;
                    }
                    else if (a_z && ozelKarakterler)
                    {
                        //UcDort
                        gelismisParolaBelirle = new GelismisParolaBelirle(parolaUzunlugu, Parola.ParolaTipi.UcDort, Parola.ParolaTipi.TumKarakterTipleri);
                        parolaMetni = gelismisParolaBelirle.IstenilenKarakterdeParolaBelirle();
                        textBox_ParolaMetni.Text = parolaMetni;
                        return;
                    }
                    else if (rakamlar && ozelKarakterler)
                    {
                        //IkıDort
                        gelismisParolaBelirle = new GelismisParolaBelirle(parolaUzunlugu, Parola.ParolaTipi.IkıDort, Parola.ParolaTipi.TumKarakterTipleri);
                        parolaMetni = gelismisParolaBelirle.IstenilenKarakterdeParolaBelirle();
                        textBox_ParolaMetni.Text = parolaMetni;
                        return;
                    }
                    else if (rakamlar && a_z)
                    {
                        //IkiUc
                        gelismisParolaBelirle = new GelismisParolaBelirle(parolaUzunlugu, Parola.ParolaTipi.IkiUc, Parola.ParolaTipi.TumKarakterTipleri);
                        parolaMetni = gelismisParolaBelirle.IstenilenKarakterdeParolaBelirle();
                        textBox_ParolaMetni.Text = parolaMetni;
                        return;
                    }
                    else if (A_z && ozelKarakterler)
                    {
                        //BirDort
                        gelismisParolaBelirle = new GelismisParolaBelirle(parolaUzunlugu, Parola.ParolaTipi.BirDort, Parola.ParolaTipi.TumKarakterTipleri);
                        parolaMetni = gelismisParolaBelirle.IstenilenKarakterdeParolaBelirle();
                        textBox_ParolaMetni.Text = parolaMetni;
                        return;
                    }
                    else if (A_z && a_z)
                    {
                        //BirUc
                        gelismisParolaBelirle = new GelismisParolaBelirle(parolaUzunlugu, Parola.ParolaTipi.BirUc, Parola.ParolaTipi.TumKarakterTipleri);
                        parolaMetni = gelismisParolaBelirle.IstenilenKarakterdeParolaBelirle();
                        textBox_ParolaMetni.Text = parolaMetni;
                        return;
                    }
                    else if (A_z && rakamlar)
                    {
                        //BirIki,
                        gelismisParolaBelirle = new GelismisParolaBelirle(parolaUzunlugu, Parola.ParolaTipi.BirIki, Parola.ParolaTipi.TumKarakterTipleri);
                        parolaMetni = gelismisParolaBelirle.IstenilenKarakterdeParolaBelirle();
                        textBox_ParolaMetni.Text = parolaMetni;
                        return;
                    }
                    else if (ozelKarakterler)
                    {
                        //OzelKarakterler,
                        gelismisParolaBelirle = new GelismisParolaBelirle(parolaUzunlugu, Parola.ParolaTipi.OzelKarakterler, Parola.ParolaTipi.TumKarakterTipleri);
                        parolaMetni = gelismisParolaBelirle.IstenilenKarakterdeParolaBelirle();
                        textBox_ParolaMetni.Text = parolaMetni;
                        return;
                    }
                    else if (rakamlar)
                    {
                        //rakamlar
                        gelismisParolaBelirle = new GelismisParolaBelirle(parolaUzunlugu, Parola.ParolaTipi.SifirdanDokuza, Parola.ParolaTipi.TumKarakterTipleri);
                        parolaMetni = gelismisParolaBelirle.IstenilenKarakterdeParolaBelirle();
                        textBox_ParolaMetni.Text = parolaMetni;
                        return;
                    }
                    else if (A_z)
                    {
                        gelismisParolaBelirle = new GelismisParolaBelirle(parolaUzunlugu, Parola.ParolaTipi.A_z, Parola.ParolaTipi.TumKarakterTipleri);
                        parolaMetni = gelismisParolaBelirle.IstenilenKarakterdeParolaBelirle();
                        textBox_ParolaMetni.Text = parolaMetni;
                        return;
                    }
                    else if (a_z)
                    {
                        gelismisParolaBelirle = new GelismisParolaBelirle(parolaUzunlugu, Parola.ParolaTipi.a_z, Parola.ParolaTipi.TumKarakterTipleri);
                        parolaMetni = gelismisParolaBelirle.IstenilenKarakterdeParolaBelirle();
                        textBox_ParolaMetni.Text = parolaMetni;
                        return;
                    }
                }
                if (radioButton_OkunabilirYap.Checked==true)
                {
                    // okunabilir yap kısmı
                    gelismisParolaBelirle = new GelismisParolaBelirle(parolaUzunlugu, Parola.ParolaTipi.OkunabilirYap, Parola.ParolaTipi.OkunabilirYap);
                    parolaMetni = gelismisParolaBelirle.IstenilenKarakterdeParolaBelirle();
                    textBox_ParolaMetni.Text = parolaMetni;
                }
            }
        }

        // Okunabilir yapmak sadece A_z karakterler ile parola üretmek demektir.
        private void radioButton_OkunabilirYap_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_OkunabilirYap.Checked==true)
            {
                checkBox_aa_zz.Enabled = false;
                checkBox_A_z.Enabled = false;
                checkBox_OzelKarakter.Enabled = false;
                checkBox_Rakamlar.Enabled = false;

                checkBox_aa_zz.Checked = false;
                checkBox_A_z.Checked = false;
                checkBox_OzelKarakter.Checked = false;
                checkBox_Rakamlar.Checked = false;
            }
        }

        private void radioButton_TumKarakterTiplerineIzinVer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_TumKarakterTiplerineIzinVer.Checked == true)
            {
                checkBox_aa_zz.Enabled = true;
                checkBox_A_z.Enabled = true;
                checkBox_OzelKarakter.Enabled = true;
                checkBox_Rakamlar.Enabled = true;
            }
        }

        private void checkBox_GelismisAyarlariGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_GelismisAyarlariGoster.Checked==true)
                panel_GelismisAyarlar.Show();

            if (checkBox_GelismisAyarlariGoster.Checked == false)
                panel_GelismisAyarlar.Hide();
        }

        private string parolaMetniSakla;
        private void label3_Click(object sender, EventArgs e)
        {
            if (textBox_ParolaMetni.Text != "")
            {
                Clipboard.Clear();
                Clipboard.SetText(textBox_ParolaMetni.Text);
                parolaMetniSakla = textBox_ParolaMetni.Text;

                timer_CopyBilgi.Start();
            }
            else
                MessageBox.Show("Lütfen Bir Şifre Üretin");
           
        }

        int timerSure = 0;
        private void timer_CopyBilgi_Tick(object sender, EventArgs e)
        {
            textBox_ParolaMetni.Text = "Kopyalandı";

            timerSure +=1;
            if (timerSure%2==0)
            {
                textBox_ParolaMetni.Text = "";
                textBox_ParolaMetni.Text = parolaMetniSakla;
                timer_CopyBilgi.Stop();
            }
        }
    }
}
