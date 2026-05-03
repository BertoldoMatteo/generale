using System;
using System.Collections.Generic;
using System.Text;

namespace StazioneMeteoTaff
{
      public class CStazioneMeteo
        {
            private double DEFAULT_BAR = 800;
            private double[] DEFAULT_TER ={ 0.0,  // 00:00
                                            0.0,  // 06:00
                                            0.0,  // 12:00
                                            0.0   // 18:00
                                          };
            private int DEFAULT_PLU = 0;        // mm di pioggia (nessuna pioggia)
            private double DEFAULT_IGR = 0.0;   // umidità relativa (%)
            private int DEFAULT_ANE = 0;        // velocità vento (km/h)

            private int mnumeroStazione;
            private double mbarometro;

            // temperature: indice 0=00:00, 1=06:00, 2=12:00, 3=18:00
            private double[] mtemperature;

            private double mpluviometro;
            private double migrometro;
            private double manemometro;

            public CStazioneMeteo(int numeroStazione,
                                 double barometro,
                                 double[] temp,
                                 double pluviometro,
                                 double igrometro,
                                 double anemometro)
            {

            this.NumeroStazione = numeroStazione;
            this.Barometro = barometro;

            this.Temperature = temp;
            this.Pluviometro = pluviometro;
            this.Igrometro = igrometro;
            this.Anemometro = anemometro;
            }

            public int NumeroStazione
            {
                get { return mnumeroStazione; }
                set
                {
                    /* if (value > 0)
                         mnumeroStazione = value;*/

                    if (value <= 0)
                        throw new ArgumentException("Il numero della stazione deve essere maggiore di 0");

                    mnumeroStazione = value;
                }
            }

            public double Barometro
            {
                get { return mbarometro; }
                set
                {
                    /* if (value >= 800 && value <= 1200)
                         mbarometro = value;
                     else
                         mbarometro = DEFAULT_BAR;*/
                    if (value < 800 || value > 1200)
                        throw new ArgumentOutOfRangeException("Barometro", "Valore non realistico (800-1200 hPa)");

                    mbarometro = value;
                }
            }

        public double[] Temperature
        {
            get { return mtemperature; }
            set
            {
                if (value != null && value.Length == 4)
                {
                    bool valido = true;

                    for (int i = 0; i < 4; i++)
                    {
                        if (value[i] < -50 || value[i] > 60)
                        {
                            valido = false;
                            break;
                        }
                    }

                    if (valido)
                    {
                        mtemperature = new double[4];      // <-- INIZIALIZZO
                        for (int i = 0; i < 4; i++)
                            mtemperature[i] = value[i];
                    }
                    else
                    {
                        mtemperature = (double[])DEFAULT_TER.Clone();
                    }
                }
                else
                {
                    mtemperature = (double[])DEFAULT_TER.Clone();
                }
            }
        }



        public double Pluviometro
            {
                get { return mpluviometro; }
                set
                {
                    // non può essere negativo
                    if (value >= 0 && value <= 500) // limite alto realistico giornaliero
                        mpluviometro = value;
                    else
                        mpluviometro = DEFAULT_PLU;
                }
            }

            public double Igrometro
            {
                get { return migrometro; }
                set
                {
                    // percentuale 0-100
                    if (value >= 0 && value <= 100)
                        migrometro = value;
                    else
                        migrometro = DEFAULT_IGR;
                }
            }

            public double Anemometro
            {
                get { return manemometro; }
                set
                {
                    // vento >= 0 e limite realistico
                    if (value >= 0 && value <= 200)
                        manemometro = value;
                    else
                        manemometro = DEFAULT_ANE;
                }
            }
            
            // Restituisce i dati dei sensori sotto forma di stringa
            public string GetDatiSensori()
            {
              return string.Format(
                        "{0,-10} {1,-12} {2,2}/{3,2}/{4,2}/{5,2} {6,10} {7,8} {8,8}",
                        mnumeroStazione,
                        mbarometro,
                        mtemperature[0],
                        mtemperature[1],
                        mtemperature[2],
                        mtemperature[3],
                        mpluviometro,
                        migrometro,
                        manemometro
            );
        }

            
            // Restituisce un report completo formattato
            public string GetReport()
            {
                string report = "===== REPORT STAZIONE METEO =====\n";
                report += GetDatiSensori();
                report += "\nTemperatura media: " + temperaturaMediaGiornaliera().ToString("0.00") + " °C";

                if (HaPiovuto())
                    report += "\nCondizione: Giornata piovosa";
                else
                    report += "\nCondizione: Nessuna pioggia";

                report += "\n=================================";

                return report;
            }

            // Verifica se ha piovuto durante la giornata
            public bool HaPiovuto()
            {
                return mpluviometro > 0;
            }

            // Reset dei valori per il giorno successivo
            public void ResetGiornaliero()
            {
                mbarometro = DEFAULT_BAR;

                // reset temperature
                mtemperature = new double[4];
                for (int i = 0; i < 4; i++)
                {
                    mtemperature[i] = DEFAULT_TER[i];
                }

                mpluviometro = DEFAULT_PLU;
                migrometro = DEFAULT_IGR;
                manemometro = DEFAULT_ANE;
            }

            private double temperaturaMediaGiornaliera()
            {
                if (mtemperature == null || mtemperature.Length == 0)
                    return 0;

                double somma = 0;

                for (int i = 0; i < mtemperature.Length; i++)
                {
                    somma += mtemperature[i];
                }

                return somma / mtemperature.Length;
            }
        }

    }

