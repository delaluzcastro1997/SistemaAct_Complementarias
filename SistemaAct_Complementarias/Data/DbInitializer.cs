using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaAct_Complementarias.Models;


namespace SistemaAct_Complementarias.Data
{
    public class DbInitializer
    {
        public static void Initialize(SistemaAct_ComplementariasContext context)
        {
            context.Database.EnsureCreated();
            if (context.actividad.Any())
            {
                return;
            }
            var actividad = new actividad[]
            {
              //new Alumno {Nombres="Leonel", ApellidoP="Gonzalez", ApellidoM ="Vidales", Edad =20, NumTelefono = "7321080568", Domicilio = "Av. Pungarabato Pte S/N", Colonia="Morelos", Ciudad ="Cd. Altamirano", CP =40660, Estado ="Guerrero"}
            };

            foreach (actividad a in actividad)
            {
                context.actividad.Add(a);

            }
            context.SaveChanges();

        }

        internal static void Initialize(object context)
        {
            throw new NotImplementedException();
        }
    }
}
