using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsMeteo
{
    internal class StazioneMeteo
    {
        private string id;//numero stazione per identificarla
        private double press; //misura pressione atmosferica in hPa
        private double[] temp; //4 misurazioni di temperatura in C°
        private double pioggia; //pioggia espressa in mm
        private double umid; //umidità espressa in %
        private double vento; //velocità vento in km/h

        public StazioneMeteo()
        {
            this.id = "";
            this.press = 0;
            this.temp = new double[4];
            this.pioggia = 0;
            this.umid = 0;
            this.vento = 0;
        }

        public StazioneMeteo(string id, double press, double[] temp, double pioggia, double umid, double vento)
        {
            this.id = id;
            this.press = press;
            this.temp = temp;
            this.pioggia = pioggia;
            this.umid = umid;
            this.vento = vento;
        }

        public string ID
        {
            get { return id; }
        }

        public string Info()
        {
            return $"STAZIONE N° {this.id}  \nPRESSIONE : {this.press}" +
                $"\n  TEMPERATURA :\n   00:00 => {this.temp[0]}\n   06:00 => {this.temp[1]}\n   12:00 => {this.temp[2]}\n   18:00 => {this.temp[3]}" +
                $"\nPIOGGIA: {this.pioggia}  \nUMIDITA' (12:00) : {this.umid}\nVEL. VENTO : {this.vento}";
        }

        public string Print()
        {
            return $"{this.id},{this.press},{this.temp[0]},{this.temp[1]},{this.temp[2]},{this.temp[3]}," +
                $"{this.pioggia},{this.umid},{this.vento}";
        }

        public bool Pioggia()
        {
            return this.pioggia > 0 ? true : false;
        }

        public StazioneMeteo Reset()
        {
            return new StazioneMeteo();
        }

    }
}
