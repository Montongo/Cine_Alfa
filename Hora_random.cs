using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Alfa
{
    internal class Hora_random
    {
        public DateTime GenerarHoraAleatoria()
        {
            Random random = new Random();
            int hora = random.Next(11, 19);
            int minutos = random.Next(0, 60);


            return DateTime.Today.AddHours(hora).AddMinutes(minutos);
        }

        public static char Sala()
        {
            Random random = new Random();
            char letraAleatoria;
            letraAleatoria = (char)random.Next('a', 'e');
            
            return letraAleatoria;
        }
    }
}
