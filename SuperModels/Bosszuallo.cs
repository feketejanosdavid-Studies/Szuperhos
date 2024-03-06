﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperModels
{
    public abstract class Bosszuallo : ISuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        public double Szuperero
        {
            get { return this.szuperero; } 
            set { if (value>=0) this.szuperero = value; } 
        }

        public bool VanEGyengesege
        {
            get { return this.vanEGyengesege; }
            set { this.vanEGyengesege = value; }
        }

        public Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            Szuperero = szuperero;
            VanEGyengesege = vanEGyengesege;
        }

        public abstract bool MegmentiAVilagot();

        public double MekkoraAzEreje()
        {
            return this.Szuperero;
        }

        bool ISuperhos.LegyoziE(ISuperhos hos)
        {
            if (hos is Bosszuallo)
            {
                var ellenfel = ((Bosszuallo)hos);
                return (((Bosszuallo)hos).MekkoraAzEreje() < this.MekkoraAzEreje() && ((Bosszuallo)hos).VanEGyengesege);

            }
            else
            {
                var bati = (Batman)hos;
                return this.MekkoraAzEreje() > bati.MekkoraAzEreje() * 2;
            }
        }

        public override string? ToString()
        {
            return this.MekkoraAzEreje()+" az erőm, és "+(this.VanEGyengesege?"van":"nincs")+" gyengeségem!";
        }
    }
}
