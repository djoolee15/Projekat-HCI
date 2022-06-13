using Projekat_HCi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Projekat_HCi
{
    public class Controller 
    {
        public void BrisanjeVoza(Voz v) {
            foreach (Voznja voznja in (Application.Current.MainWindow as MainWindow).voznje)
            {
                if (voznja.Voz == v)
                {
                    (Application.Current.MainWindow as MainWindow).voznje.Remove(voznja); // BRISANJE VOZNJE
                    foreach(RedVoznjePrikaz rvp in (Application.Current.MainWindow as MainWindow).red_voznje_prikaz){ 
                        if(rvp.Id == voznja.Id){
                            (Application.Current.MainWindow as MainWindow).red_voznje_prikaz.Remove(rvp); // BRISANJE PRIKAZA VOZNJE ODNOSNO REDA VOZNJE
                            break;
                        }
                    


                    foreach (Karta k in (Application.Current.MainWindow as MainWindow).karte) {
                        if (k.Voznja == voznja) {
                            (Application.Current.MainWindow as MainWindow).karte.Remove(k); // BRISANJE KARTE
                                foreach (KartaPrikaz kp in (Application.Current.MainWindow as MainWindow).karte_prikaz)
                                {
                                    if (kp.Id == k.Id)
                                    {
                                        (Application.Current.MainWindow as MainWindow).karte_prikaz.Remove(kp); // BRISANJE PRIKAZA KARTE
                                        break;

                                    }
                                    

                                }
                                break;
                            }
                           

                        }
                    }
                    break;

                }
            }
        }


        public void brisanjeVozneLinije(VoznaLinija voznaLinija) {
            foreach (Voznja voznja in (Application.Current.MainWindow as MainWindow).voznje)
            {
                if (voznja.Vl == voznaLinija)
                {
                    (Application.Current.MainWindow as MainWindow).voznje.Remove(voznja); // BRISANJE VOZNJE
                    foreach (RedVoznjePrikaz rvp in (Application.Current.MainWindow as MainWindow).red_voznje_prikaz)
                    {
                        if (rvp.Id == voznja.Id)
                        {
                            (Application.Current.MainWindow as MainWindow).red_voznje_prikaz.Remove(rvp); // BRISANJE PRIKAZA VOZNJE ODNOSNO REDA VOZNJE
                            break;
                        }



                        foreach (Karta k in (Application.Current.MainWindow as MainWindow).karte)
                        {
                            if (k.Voznja == voznja)
                            {
                                (Application.Current.MainWindow as MainWindow).karte.Remove(k); // BRISANJE KARTE
                                foreach (KartaPrikaz kp in (Application.Current.MainWindow as MainWindow).karte_prikaz)
                                {
                                    if (kp.Id == k.Id)
                                    {
                                        (Application.Current.MainWindow as MainWindow).karte_prikaz.Remove(kp); // BRISANJE PRIKAZA KARTE
                                        break;

                                    }


                                }
                                break;
                            }


                        }
                    }
                    break;

                }
            }
        }
        public void brisanjeRedaVoznje(RedVoznjePrikaz rvp)
        {
            foreach (Voznja voznja in (Application.Current.MainWindow as MainWindow).voznje)
            {
                if (voznja.Id == rvp.Id)
                {
                    (Application.Current.MainWindow as MainWindow).voznje.Remove(voznja); // BRISANJE VOZNJE   
                        foreach (Karta k in (Application.Current.MainWindow as MainWindow).karte)
                        {
                            if (k.Voznja == voznja)
                            {
                                (Application.Current.MainWindow as MainWindow).karte.Remove(k); // BRISANJE KARTE
                                foreach (KartaPrikaz kp in (Application.Current.MainWindow as MainWindow).karte_prikaz)
                                {
                                    if (kp.Id == k.Id)
                                    {
                                        (Application.Current.MainWindow as MainWindow).karte_prikaz.Remove(kp); // BRISANJE PRIKAZA KARTE
                                        break;

                                    }


                                }
                                break;
                            }


                        }
                    break;
                }
                  
            }
        }
    }
}
