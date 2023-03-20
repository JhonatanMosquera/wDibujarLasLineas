using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace wDibujarLasLineas
{
    internal class ClsLineas
    {
        //definimos variables
        private int xInicial;
        private int xFinal;
        private int yInicial;
        private int yFinal;

        private static int contador = 0;
        //contructor
        public ClsLineas() 
        {
            xInicial = 0;
            xFinal = 0;
            yInicial = 0;
            yFinal = 0;
        }
        //sobrecarga
        public ClsLineas(int xInicial, int xFinal , int yInicial , int yFInal)
        {
            this.xInicial = xInicial;
            this.xFinal = xFinal ;
            this.yInicial = yInicial ;
            this.yFinal = xFinal;
        }

        public ClsLineas(double xInicial, double xFinal, double yInicial, double yFInal)
        {
            this.xInicial = (int)xInicial;
            this.xFinal =(int)xFinal;
            this.yInicial =(int)yInicial;
            this.yFinal =(int)yFInal;

        }
        
        #region la forma que usamos para usar las variables privadas
        public int getXInicial() 
        {
            return xInicial;        
        }

        public int getYInicial() 
        {
            return yInicial;        
        }

        public int getYFinal() 
        {
            return yFinal;
        }

        public int getXFinal() 
        {
            return xFinal;
        }
        #endregion

        public void cambiarPosicionXInicial (int xInicial) 
        {
          this.xInicial = xInicial;
        
        }

        public void cambiarPosicionYInicial(int yInicial)
        {
            this.yInicial = yInicial;
        }

        public void cambiarPosicionXFinal(int xFinal)
        {

            this.xFinal = xFinal;
        }

        public void cambiarPosicionYFinal(int yFinal)
        {
            this.yFinal = yFinal;


        }

        public static int getContador ()
        {
            contador += 1;
            return contador;
        }




    }
}
