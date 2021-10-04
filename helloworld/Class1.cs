using System;

namespace helloworld
{
    class Gatos : Mascotas
    {
        public void catalogo_gatuno()
        {
           string[] gatitos_ = { "1-Azul ruso", "2-Savannah", "3-Abisinio", "4-Gato amarillo que te dará mucho amor" };

           Console.WriteLine("Estos son los gatitos que tenemos disponibles: \n");
            foreach (string i in gatitos_)
            {
                Console.WriteLine(i);
            }
        }

        public void saludoAmo_2()
        {
            Random ram_2 = new Random();

            string[] accionesGatos = { "Miau", "*c lame el pelaje*", "*ve con cara de odio*", "*ronronea*" };

            int random_2 = ram_2.Next(accionesGatos.Length);

             Console.WriteLine("Tu gatito está muy feliz: " + accionesGatos[random_2]);

        }

         public void DecisionGato()
         {
             catalogo_gatuno();
             int respuesta_2 = int.Parse(Console.ReadLine());
             switch (respuesta_2)
             {
             case 1:
              Requerimientos();
                 saludoAmo_2();
             break;
             case 2:
               Requerimientos();
                 saludoAmo_2();
             break;
             case 3:
               Requerimientos();
                 saludoAmo_2();
             break;
             case 4:
               Requerimientos();
                 saludoAmo_2();
              break;
                    default:
                        Console.WriteLine("Ya veo, quieres gatitos");
                        break;
                }
              

            }
    }     
}     
