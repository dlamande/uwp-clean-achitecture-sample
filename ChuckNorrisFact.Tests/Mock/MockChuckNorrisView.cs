using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChuckNorrisFact.Tests.Mock
{
    public class MockChuckNorrisView : IChuckNorrisView
    {
        private JokesViewModel _jokeViewModel;
        private Queue<int> _queue = new Queue<int>();

        public Queue<int> GetQueue()
        {
            return _queue;
        }

        public JokesViewModel GetJokesViewModel()
        {
            return _jokeViewModel;
        }

        public void DisplayJokes(JokesViewModel jokeViewModel)
        {

            _jokeViewModel = jokeViewModel;
            _queue.Enqueue(2);
            return;
        }

        public void DisplayLoader()
        {
            _queue.Enqueue(1);
            return;
        }

        public void HideLoader()
        {
            _queue.Enqueue(3);
            return;
        }
    }
}
