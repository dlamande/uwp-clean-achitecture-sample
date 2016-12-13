namespace ChuckNorrisFact.Tests.Mock
{
    public class MockChuckNorrisView : IChuckNorrisView
    {
        private JokesViewModel _jokeViewModel;

        public JokesViewModel GetJokesViewModel()
        {
            return _jokeViewModel;
        }

        public void DisplayJokes(JokesViewModel jokeViewModel)
        {

            _jokeViewModel = jokeViewModel;
            return;
        }
    }
}
