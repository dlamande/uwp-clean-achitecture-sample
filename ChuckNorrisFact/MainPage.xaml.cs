using ChuckNorrisFact.Interactors;
using ChuckNorrisFact.Repositories.ApiRepository;
using Windows.UI.Xaml.Controls;

namespace ChuckNorrisFact
{
    public sealed partial class MainPage : Page, IChuckNorrisView
    {
        private ChuckNorrisInteractor _interactor;

        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
            
             _interactor = new ChuckNorrisInteractor(new ChuckNorrisPresenter(this), new ApiQuery(new HttpClientImpl()));
        }

        private void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            DisplayLoader();
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            _interactor.FetchJokes();
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
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
    }
}
