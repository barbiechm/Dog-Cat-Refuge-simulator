using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Perros perritos = new Perros();
            Gatos gatitos = new Gatos();

            Console.WriteLine("-------------ALBERGUE DE MASCOTAS-------------");
            Console.WriteLine("¡Hola! Es un placer que estés acá, tenemos muchas mascotas a las que puedes darle una segunda oportunidad." +
                       "\n\n Tenemos perritos y gatitos ¿Qué prefieres?(p/g)");
            char decision = Convert.ToChar(Console.ReadLine());

            if (decision == 'p') perritos.DecisionPerro();
            else if (decision == 'g') gatitos.DecisionGato();
        }
    }   
    //-----------------------------------------------
    class Mascotas
    { 
    
          public Mascotas(){ nombreMascota = "firulais"; }
        
          public string hambre() => "Debes alimentarlo como minimo dos veces al dia";
          public string amor() => "Tambien debes darle mucho amor siempre";

          public string getNombre() => "Estoy segura que " + this.nombreMascota + " te adorará";
    
          public void setNombre(string nombre){ this.nombreMascota = nombre;}
        
          public void Requerimientos()
          {
            hambre();
            amor();
            
            Console.WriteLine("Ingrese el nombre nuevo para su nueva mascota: ");
            setNombre(Console.ReadLine());
            getNombre();
          }
   
        string nombreMascota;
    }
    //-----------------------------------------------
    class Perros : Mascotas
    {
      
        public void catalogo_canino()
        {
            string[] perritos_ = { "1-Pastor aleman", "2-rabo e' cabuya", "3-salchicha", "4-pug" };
            Console.WriteLine("Estos son los perritos que tenemos disponibles: \n");
            foreach (string i in perritos_)
            {
                Console.WriteLine(i);
            }
        }
                  
        public void saludoAmo()
        {
            Random ram = new Random();

            string[] accionesPerros = { "*Guau* *guau*", "*saca la lengua*", "*sonríe*", "*se echa un pedo*" };

            int random = ram.Next(accionesPerros.Length);

            Console.WriteLine("Tu cachorrito: " + accionesPerros[random]);
        }   

        public void DecisionPerro()
        {
            catalogo_canino();
            int respuesta_1 = int.Parse(Console.ReadLine());
            switch (respuesta_1)
            {
               case 1:
                    Requerimientos();
                     saludoAmo();
                        break;
                    case 2:
                        Requerimientos();
                     saludoAmo();
                        break;
                    case 3:
                        Requerimientos();
                     saludoAmo();
                        break;
                    case 4:
                        Requerimientos();
                     saludoAmo();
                        break;
                    default:
                        Console.WriteLine("Ya veo, quieres gatitos");
                        break;
            }
        }     
    }
}
    
  