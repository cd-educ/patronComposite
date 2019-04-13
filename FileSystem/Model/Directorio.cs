using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystem
{
    public abstract class Directorio
    {

        protected string nombre;
        protected Carpeta carpetaPadre;

        protected Directorio(string nombre, Carpeta carpetaPadre)
        {
            this.nombre = nombre;

            // Ref Hijo -> Padre
            this.carpetaPadre = carpetaPadre;

        }

        // FUNCIONES DE USO EXTERNO
        public abstract Carpeta crearCarpeta(string nombre); 
        public abstract Archivo crearArchivo(string nombre);
        
        public void verRuta()
        {

            string ruta = this.obtenerRuta();
            Console.WriteLine(ruta);

        } // Imprime la ruta completa del directorio
        public abstract void verLs(); // Imprime las rutas completas de los hijos del directorio
        public abstract void verScan(); // Scannea toda una carpeta imprimiendo todas las rutas validas

        public abstract Directorio copiar(Carpeta destino);
        public void eliminar()
        {

            // Ref Padre -> Hijo
            carpetaPadre.quitarDirectorio(this);

            // Ref Hijo -> Padre
            this.carpetaPadre = null;

        }
        public void mover(Carpeta destino)
        {
            this.copiar(destino);
            this.eliminar();
        }
        public void cambiarNombre(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }

        // FUNCIONES DE USO INTERNO
        public abstract string obtenerRuta();
        public abstract void agregarDirectorio(Directorio unDirectorio);
        public abstract void quitarDirectorio(Directorio unDirectorio);

    }
}
