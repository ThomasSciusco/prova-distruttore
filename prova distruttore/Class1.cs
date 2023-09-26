using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_distruttore
{
    internal class esempio
    {
        private string stringa;
        private int numero;

        private bool disposed = false;
            public esempio ()
        {
            stringa = ""; 
            numero = 0;
        }
        public void Dispose()

        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if(disposing) 
            { 
                
            }
            disposed= true;
        }
        ~ esempio() 
        {
            Dispose(false);
            Console.WriteLine("risorse gestite");
        }

        public string Stringa
        { 
            get {return stringa;} 
            set { stringa = value;}
        }
        public int Numero
        { 
            get { return numero;} 
            set { numero = value;} 
        }
        
    }
}

