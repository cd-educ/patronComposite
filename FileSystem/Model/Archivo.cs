using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystem
{
    public class Archivo : Directorio
    {

        public Archivo(string nombre, Carpeta carpetaPadre) : base(nombre, carpetaPadre) { }

        override
        public Carpeta crearCarpeta(string nombre){ return null; }

        override
        public Archivo crearArchivo(string nombre){ return null; }

        override
        public void verLs(){ }

        override
        public void verScan()
        {
            this.verRuta();
        }

        override
        public Directorio copiar(Carpeta destino)
        {

            // Ref Hijo -> Padre
            Archivo archivoCopia = new Archivo(this.nombre, destino);

            // Ref Padre -> Hijo
            destino.agregarDirectorio(archivoCopia);

            return archivoCopia;

        }

        override
        public string obtenerRuta()
        {

            if (carpetaPadre == null)
            {
                return nombre;
            }
            else
            {
                return carpetaPadre.obtenerRuta() + nombre;
            }

        }

        override
        public void agregarDirectorio(Directorio unDirectorio)
        { }

        override
        public void quitarDirectorio(Directorio unDirectorio)
        { }

    }
}
