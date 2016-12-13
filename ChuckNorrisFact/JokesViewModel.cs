using ChuckNorrisFact.Repositories.Entities;
using System.Collections.Generic;

namespace ChuckNorrisFact
{
    public class JokesViewModel
    {
        public string NbJokesLabel { get; set; }
     
        public IList<ChuckNorrisJoke> Jokes { get; set; }
    }
}