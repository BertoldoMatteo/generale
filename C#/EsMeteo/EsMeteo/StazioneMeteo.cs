using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsMeteo
{
    internal class StazioneMeteo
    {
        private int id { get; set;} //numero stazione per identificarla
        private int press { get; set; } //misura pressione atmosferica in hPa
        private double[] temp { get; set; } //4 misurazioni di temperatura in C°
        private double pioggia { get; set; } //pioggia espressa in mm
        private double umid { get; set; } //umidità espressa in %
        private double vento { get; set; } //velocità vento in km/h

        public StazioneMeteo()
        {
            this.id = 0;
            this.press = 0;
            this.temp = new double[4];
            this.pioggia = 0;
            this.umid = 0;
            this.vento = 0;
        }

        public string Info()
        {
            return $"STAZIONE N° {this.id}\nPRESSIONE : {this.press}" +
                $"\nTEMPERATURA :\n   00:00 => {this.temp[0]}\n   06:00 => {this.temp[1]}\n   12:00 => {this.temp[2]}\n   18:00 => {this.temp[3]}" +
                $"\nPIOGGIA: {this.pioggia}\nUMIDITA' (12:00) : {this.umid}\nVEL. VENTO : {this.vento}";
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
