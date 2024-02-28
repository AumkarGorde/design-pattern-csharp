using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class HomeTheaterFacade
    {
        private DvdPlayer dvdPlayer;
        private Amplifier amplifier;
        private Projector projector;

        public HomeTheaterFacade(DvdPlayer dvdPlayer, Amplifier amplifier, Projector projector)
        {
            this.dvdPlayer = dvdPlayer;
            this.amplifier = amplifier;
            this.projector = projector;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            projector.On();
            projector.SetInput(dvdPlayer);
            amplifier.On();
            amplifier.SetDvd(dvdPlayer);
            amplifier.SetSurroundSound();
            dvdPlayer.On();
            dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the home theater...");
            dvdPlayer.Stop();
            dvdPlayer.On();
            amplifier.Off();
            projector.Off();
        }
    }
}
