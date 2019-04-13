using System;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            //pruebaCreacion();
            //pruebaCopiar();
            //pruebaEliminar();
            pruebaMover();

            Console.ReadLine();
            
        }

        public static void pruebaCreacion()
        {

            // Creo carpeta raiz C: e "instalo Chrome"
            Carpeta raiz = new Carpeta("C:", null);
            Carpeta archivos = raiz.crearCarpeta("Archivos de programa");
            Carpeta chrome = archivos.crearCarpeta("Chrome");
            Archivo exe = chrome.crearArchivo("chrome.exe");

            // Muestro la ruta completa donde se instalo el archivo
            exe.verRuta();

        }

        public static void pruebaCopiar()
        {

            // Creo carpeta raiz C: e "instalo Chrome"
            Carpeta raiz = new Carpeta("C:", null);
            Carpeta archivos = raiz.crearCarpeta("Archivos de programa");
            Carpeta chrome = archivos.crearCarpeta("Chrome");
            Archivo exe = chrome.crearArchivo("chrome.exe");

            // Creo carpeta raiz D:
            Carpeta raiz2 = new Carpeta("D:", null);

            // Copio "chrome.exe" al disco D:
            exe.copiar(raiz2);

            // Cambio el nombre del archivo "chrome.exe" del disco C: al de "mozilla.exe"
            exe.cambiarNombre("mozilla.exe");

            // Scanneo los dos discos mostrando que se crearon todas 
            // las carpetas y el nombre del archivo se cambio solamente en el disco D:
            raiz.verScan();
            raiz2.verScan();

        }

        public static void pruebaEliminar()
        {

            // Creo carpeta raiz C: e "instalo Chrome"
            Carpeta raiz = new Carpeta("C:", null);

            // Creo carpeta Windows
            Carpeta windows = raiz.crearCarpeta("Windows");
            Archivo so = windows.crearArchivo("so.exe");

            // Creo carpeta Archivos de programa e "instalo Chrome"
            Carpeta archivos = raiz.crearCarpeta("Archivos de programa");
            Carpeta chrome = archivos.crearCarpeta("Chrome");
            Archivo exe = chrome.crearArchivo("chrome.exe");

            // Elimino "Archivos de programa"
            archivos.eliminar();

            // Scanneo los dos discos mostrando que se crearon todas 
            // las carpetas y el nombre del archivo se cambio solamente en el disco D:
            raiz.verScan();

        }

        public static void pruebaMover()
        {

            // Creo carpeta raiz C:
            Carpeta raiz = new Carpeta("C:", null);

            // Creo carpeta raiz D:
            Carpeta raiz2 = new Carpeta("D:", null);

            // Creo carpeta Windows
            Carpeta windows = raiz.crearCarpeta("Windows");
            Archivo so = windows.crearArchivo("so.exe");

            // Creo carpeta Archivos de programa e "instalo Chrome"
            Carpeta archivos = raiz.crearCarpeta("Archivos de programa");
            Carpeta chrome = archivos.crearCarpeta("Chrome");
            Archivo exe = chrome.crearArchivo("chrome.exe");

            // Muevo Chrome al disco D:
            chrome.mover(raiz2);
            
            // Scanneo los dos discos mostrando que se movio Chrome completamente al disco D: 
            raiz.verScan();
            raiz2.verScan();

        }

    }
}
