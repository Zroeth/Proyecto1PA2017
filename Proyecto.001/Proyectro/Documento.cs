﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectro
{
    class Documento
    {
        private int ley;
        private string titulo;
        private int fechaCreacion;
        private string contenido;
        private int numCopias;
        private int copiasDisponibles;
        List<int>colaCopias;

        

        public int Ley
        {
            get
            {
                return ley;
            }
            set
            {
                ley = value;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }


        public int FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }
            set
            {
                fechaCreacion = value;
            }
        }

        public string Contenido
        {
            get
            {
                return contenido;
            }
            set
            {
                contenido = value;
            }
        }


        public int NumCopias
        {
            get
            {
                return numCopias;
            }
            set
            {
                numCopias = value;
            }
        }

        public int CopiasDisponibles
        {
            get
            {
                return copiasDisponibles;
            }
            set
            {
                copiasDisponibles = value;
            }
            
        }

        public List<int> ColaCopias { get => colaCopias; set => colaCopias = value; }
    }
}