﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumeroBis
{
    public class Scribe
    {

        private int ValeurChiffre(char c)
        {
            switch(c)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
            }
            throw new ArgumentOutOfRangeException("c", c, "Chiffre non reconnu");
        }

        private string Reste(string nombreRomain)
        {
            return nombreRomain.Length > 1 ? nombreRomain.Substring(1): string.Empty;
        }

        public int CombienVaut(string nombreRomain)
        {
            if (string.IsNullOrWhiteSpace(nombreRomain))
                return 0;
            var reste = Reste(nombreRomain);
            var chiffre = ValeurChiffre(nombreRomain[0]);
            if (string.IsNullOrWhiteSpace(reste))
                return chiffre;
            var prochainChiffre = ValeurChiffre(reste[0]);
            if(prochainChiffre > chiffre)
            {
                // valable uniquement si 10x supérieur et chiffre actuel unitaire (I, X, C, M...)
                if (prochainChiffre > 10 * chiffre)
                    throw new ArgumentException("Ceci n'est pas un nombre Romain correct");
                return CombienVaut(reste) - chiffre;
            } 
            return CombienVaut(reste) + chiffre;             
        }
    }
}
