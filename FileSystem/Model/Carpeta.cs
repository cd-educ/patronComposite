using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystem
{
    public class Carpeta : Directorio
    {

        private List<Directorio> directoriosHijos = new List<Directorio>();

        public Carpeta(string nombre, Carpeta carpetaPadre) : base(nombre, carpetaPadre) { }

        override
        public Carpeta crearCarpeta(string nombre)
        {

            // Ref Hijo -> Padre
            Carpeta nuevaCarpeta = new Carpeta(nombre, this);

            // Ref Padre -> Hijo
            this.agregarDirectorio(nuevaCarpeta);

            return nuevaCarpeta;

        }

        override
        public Archivo crearArchivo(string nombre)
        {
            // Ref Hijo -> Padre
            Archivo nuevoArchivo = new Archivo(nombre, this);

            // Ref Padre -> Hijo
            this.agregarDirectorio(nuevoArchivo);

            return nuevoArchivo;

        }

        override
        public void verLs()
        {
            foreach (Directorio unDirectorio in this.directoriosHijos)
            {
                unDirectorio.verRuta();
            }
        }

        override
        public void verScan()
        {

            this.verRuta();
            foreach (Directorio directorio in directoriosHijos)
            {
                directorio.verScan();
            }

        }

        override
        public Directorio copiar(Carpeta destino)
        {

            // Ref Hijo -> Padre
            Carpeta carpetaCopia = new Carpeta(this.nombre, destino);

            // Ref Padre -> Hijo
            destino.agregarDirectorio(carpetaCopia);

            return carpetaCopia;

        }

        override
        public string obtenerRuta()
        {

            if (carpetaPadre == null)
            {
                return nombre + "/";
            } else
            {
                return carpetaPadre.obtenerRuta() + nombre + "/";
            }

        }

        override
        public void agregarDirectorio(Directorio unDirectorio)
        {
            directoriosHijos.Add(unDirectorio);
        }

        override
        public void quitarDirectorio(Directorio unDirectorio)
        {
            directoriosHijos.Remove(unDirectorio);
        }

    }
}
