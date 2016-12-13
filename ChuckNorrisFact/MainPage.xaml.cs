using ChuckNorrisFact.Interactors;
using ChuckNorrisFact.Repositories.ApiRepository;
using Windows.UI.Xaml.Controls;

namespace ChuckNorrisFact
{
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
    public sealed partial class MainPage : Page, IChuckNorrisView
    {
        private ChuckNorrisInteractor _interactor;
        private bool _isOrderByAz = true;

        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;

            _interactor = new ChuckNorrisInteractor(new ChuckNorrisPresenter(this), new ApiQuery(new HttpClientImpl()));
        }

        private void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            DisplayLoader();
            _interactor.FetchJokes();
        }

        public void DisplayJokes(JokesViewModel jokeViewModel)
        {
            this.DataContext = jokeViewModel;
            HideLoader();
        }

        private void DisplayLoader()
        {
            progressRing.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void HideLoader()
        {
            progressRing.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void AppBarButtonSort_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            DisplayLoader();

            if (_isOrderByAz)
            {
                _interactor.FetchJokensOrderByZA();
            }
            else
            {
                _interactor.FetchJokes();
            }

            _isOrderByAz = !_isOrderByAz;
        }
    }
}