using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

//aca voy a hacer un menu

namespace Matriz{

    class Matriz {
        //antes estaban sin en static
        private static string _path = @"C:\Users\Usuario 2021\Documents\proyectos Visual Studio 2022\Proyectos de c sharp\Proyecto 1 matrices\archivos json\archivofutbol.json"; //le añadi el archivo y la extension de archivo
        private static string [,] tabla = new string [12,10];
        private static int posiscion = 0;
        private static int club = 1;
        private static int juegos = 2;
        private static int puntos = 3;
        private static int goles = 4;
        private static int empates = 5;
        private static int jperdidos = 6;
        private static int goles_favor = 7;
        private static int goles_contra = 8;
        private static int dif_goles = 9;

        private static int nom = 0;
        private static int fila = 0;
        //private string[] nombre_Equipo;

        public static void cargar_info() {

            Console.WriteLine("Ingrese la posicion del club"+(++posiscion)+": ");
            tabla[fila,posiscion] = Console.ReadLine();

            Console.WriteLine("Ingrese nombre del club "+": ");
            tabla[fila, club] = Console.ReadLine();

            Console.WriteLine("ingrese el numero de veces jugado: ");
            tabla[fila, juegos] = Console.ReadLine();

            Console.WriteLine("Ingrese el numero de puntos: ");
            tabla [fila, puntos] = Console.ReadLine();

            Console.WriteLine("Ingrese los goles de ese club: ");
            tabla[fila, goles] = Console.ReadLine();

            Console.WriteLine("Cuantos empates ha tenido ese club: ");
            tabla[fila, empates] = Console.ReadLine();

            Console.WriteLine("Cuantas veces perdio ese club?: ");
            tabla[fila, jperdidos] = Console.ReadLine();

            Console.WriteLine("Goles a favor del club: ");
            tabla[fila, goles_favor] = Console.ReadLine();

            Console.WriteLine("Goles en contra del club: ");
            tabla[fila, goles_contra] = Console.ReadLine();

            Console.WriteLine("Cual era la diferencia de goles de ese club?: ");
            tabla[fila, dif_goles] = Console.ReadLine();

            fila++;

            MensajeOPC();

            Console.WriteLine("\n");
        }

        public static void mostrar_Matriz() {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("posicion\t\tclub\t\tjuegos\t\tpuntos\t\tganados\t\tempates\t\tperdidos\t\tgoles a favor\t\tgoles en contra\t\tdiferencia de goles");
            for (int x = 0; x< 12;x++) {//tabla.Length por 12

                Console.WriteLine(tabla[x,posiscion]+"\t"+tabla[x,club]+"\t"+tabla[x,juegos]+"\t"+tabla[x,puntos]+"\t"+tabla[x,goles]+"\t"+tabla[x,empates]+"\t"+tabla[x,jperdidos]+"\t"+tabla[x,goles_favor]+"\t"+tabla[x,goles_contra]+"\t"+tabla[x,dif_goles]); //quite un \t para ver si se alinea
                Console.WriteLine("\n");
            }

            MensajeOPC();
            Console.Clear(); //si no pues quitar este clear
            
        }

        public static void ingresar() {

            for (int i = 0; i < 12; i++) {

                Console.WriteLine("Ingrese la posicion del club" + (++posiscion) + ": ");
                tabla[i, posiscion] = Console.ReadLine();

                Console.WriteLine("Ingrese nombre del club " + ": ");
                tabla[i, club] = Console.ReadLine();

                Console.WriteLine("ingrese el numero de veces jugado: ");
                tabla[i, juegos] = Console.ReadLine();

                Console.WriteLine("Ingrese el numero de puntos: ");
                tabla[i, puntos] = Console.ReadLine();

                Console.WriteLine("Ingrese los goles de ese club: ");
                tabla[i, goles] = Console.ReadLine();

                Console.WriteLine("Cuantos empates ha tenido ese club: ");
                tabla[i, empates] = Console.ReadLine();

                Console.WriteLine("Cuantas veces perdio ese club?: ");
                tabla[i, jperdidos] = Console.ReadLine();

                Console.WriteLine("Goles a favor del club: ");
                tabla[i, goles_favor] = Console.ReadLine();

                Console.WriteLine("Goles en contra del club: ");
                tabla[i, goles_contra] = Console.ReadLine();

                Console.WriteLine("Cual era la diferencia de goles de ese club?: ");
                tabla[i, dif_goles] = Console.ReadLine();


            }

            MensajeOPC();

        }

        public static void editarClub() {

            Console.WriteLine("Ingrese el nombre del club a editar");
            //string nombreC = Console.ReadLine();
            string nombrenuevo = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo nombre del club");
            string nuevo_nombre = Console.ReadLine();

            for (int i=0; i < 12; i++) {

                string buscarC = tabla[i, club];
                if (nombrenuevo.Equals(buscarC)) {//nombrenuevo.Contains(buscarC) adentro del if
                    tabla[i, club] = nuevo_nombre;

                }

            }

            Console.WriteLine("Cuantos juegos habia tenido ese equipo?");
            string juegox = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva cantidad de juegos");
            string golesnuevos = Console.ReadLine();
            for (int i2 = 0; i2 < 12; i2++) {

                string buscarj = tabla[i2, juegos];
                if (juegox.Equals(buscarj)) {//Cambiar lo de contains por equals
                    tabla[i2, juegos] = golesnuevos;
                }
            }

            Console.WriteLine("Cuantos puntos tenia ese equipo?");
            string puntosN = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva cantidad de puntos");
            string ptsnuevos = Console.ReadLine();
            for (int i3 = 0; i3 < 12; i3++)
            {

                string buscarpts = tabla[i3, puntos];
                if (puntosN.Equals(buscarpts))
                {
                    tabla[i3, puntos] = ptsnuevos;
                }
            }


            Console.WriteLine("Cuantos partidos ganados habia tenido ese equipo?");
            string jgana = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva cantidad de juegos");
            string jgnuevos = Console.ReadLine();
            for (int i4 = 0; i4 < 12; i4++)
            {

                string buscarG = tabla[i4, goles];
                if (jgana.Equals(buscarG))
                {
                    tabla[i4, goles] = jgnuevos;
                }
            }


            Console.WriteLine("Cuantos empates tenia ese equipo?");
            string empates1 = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva cantidad de empates");
            string empatenuevos = Console.ReadLine();
            for (int i5 = 0; i5 < 12; i5++)
            {

                string buscarE = tabla[i5, empates];
                if (empates1.Equals(buscarE))
                {
                    tabla[i5, empates] = empatenuevos;
                }
            }

            Console.WriteLine("Cuantos juegos perdidos habia tenido ese equipo?");
            string perdio = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva cantidad de juegos");
            string pernuevos = Console.ReadLine();
            for (int i6 = 0; i6 < 12; i6++)
            {

                string buscarP = tabla[i6, jperdidos];
                if (perdio.Equals(buscarP))
                {
                    tabla[i6, jperdidos] = pernuevos;
                }
            }

            Console.WriteLine("Cuantos goles a favor tenia ese equipo?");
            string Gf1 = Console.ReadLine();
            Console.WriteLine("Cuantos goles a favor son enrealidad?");
            string gfnuevos = Console.ReadLine();
            for (int i7 = 0; i7 < 12; i7++)
            {

                string buscargf = tabla[i7, goles_favor];
                if (Gf1.Equals(buscargf))
                {
                    tabla[i7, goles_favor] = gfnuevos;
                }
            }

            Console.WriteLine("Cuantos goles en contra tenia ese equipo?");
            string Gc1 = Console.ReadLine();
            Console.WriteLine("Cuantos goles en contra son enrealidad?");
            string gcnuevos = Console.ReadLine();
            for (int i8 = 0; i8 < 12; i8++)
            {

                string buscargc = tabla[i8, goles_contra];
                if (Gc1.Equals(buscargc))
                {
                    tabla[i8, goles_contra] = gcnuevos;
                }
            }

            Console.WriteLine("Cual era la diferencia de goles que tenia ese equipo?");
            string Dg1 = Console.ReadLine();
            Console.WriteLine("Cuanta es la diferencia enrealidad?");
            string dgnuevos = Console.ReadLine();
            for (int i9 = 0; i9 < 12; i9++)
            {

                string buscardg = tabla[i9, dif_goles];
                if (gfnuevos.Equals(buscardg))
                {
                    tabla[i9, dif_goles] = dgnuevos;
                }
            }

            Console.WriteLine("--------Datos actualizados--------");
        }

        public static void MensajeOPC() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Desea regresar al menu de opciones?");
            Console.WriteLine("Si es asi escriba la palabra 'si', si no cierre esta ventana");
            string palabraClave = Console.ReadLine();

            if (palabraClave.Contains("si")) { 
                Menu();
                Console.Clear();
            }
        }

        public static void Menu() {

            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.ForegroundColor= ConsoleColor.Cyan;
                    Console.WriteLine("--Bienvenido al registro de futbol--");
                    Console.WriteLine("Opcion 1 Ver datos");
                    Console.WriteLine("Opcion 2 ingresar datos datos");
                    Console.WriteLine("Opcion 3 actualizar datos");
                    Console.WriteLine("Opcion 4 cerrar");
                    Console.WriteLine("Opcion 5 crear y leer .Json");
                    Console.WriteLine("Elije una opcion: ");
                    int opcionUser = Convert.ToInt32(Console.ReadLine());

                    switch (opcionUser)
                    {
                        case 1:
                            Console.WriteLine("Has elegido la opción 1");
                            mostrar_Matriz();
                            break;

                        case 2:
                            Console.WriteLine("Acá ingresaras los datos de los clubs de futbol");
                            
                            cargar_info(); 
                            
                            break;

                        case 3:
                            Console.WriteLine("Se van a actualizar los datos");

                            editarClub();

                            break;
                        case 4:
                            Console.WriteLine("Cerrando el programa...");

                            salir = true;

                            break;
                        case 5:
                            Console.WriteLine("Este es el contenido de tu json: "+"\n");
                            //MensajeOPC();
                            archivitoJ();

                            break;
                        default:
                            Console.WriteLine("Elige una opcion valida porfavor");
                            Console.Clear();
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }

        public static void archivitoJ() {

            string crearJ = JsonConvert.SerializeObject(tabla);
            //File.saveAs(path.combine(_path,crearJ)); // me esta dando error de path aca
            File.WriteAllText(_path, crearJ); //asi estaba primero 

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(File.ReadAllText(_path));

            MensajeOPC();
        }

        //public static string leerArchivoJ() {

        //    string jasonfila;
        //    using (var lector = new StreamReader(_path)) {

        //        jasonfila = lector.ReadToEnd();
            
        //    }
        //    return jasonfila;
        //    //var crearj o jasonfila = leerArchivoJ(); algo asi en ese menu o donde se llama la funcion
        //}



        static void Main(string[] args) {

            Menu();
            Console.ReadLine();
        }
    }

}
