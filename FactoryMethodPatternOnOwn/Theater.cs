using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternOnOwn
{
    internal class Theater
    {
        protected internal virtual MovieBase LoadMovie()
        {
            return new AntMan();
        }

        public void ShowMovie()
        {
            DimLights();
            ShowCommercials();
            var movie = LoadMovie();
            movie.Play();
            BrightenLights();
        }

        private void DimLights()
        {
            Console.WriteLine("Theater dimming lights");
        }

        private void ShowCommercials()
        {
            Console.WriteLine("Theater showing stupid commercials");
        }

        private void BrightenLights()
        {
            Console.WriteLine("Theater brightening lights");
        }
    }
}
