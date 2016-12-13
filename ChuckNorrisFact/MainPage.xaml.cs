using ChuckNorrisFact.Interactors;
using ChuckNorrisFact.Repositories.ApiRepository;
using Windows.UI.Xaml.Controls;

namespace ChuckNorrisFact
{
    public sealed partial class MainPage : Page, IChuckNorrisView
    {
        private ChuckNorrisPresenter _presenter;
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
            _presenter = new ChuckNorrisPresenter(this,
                new ChuckNorrisInteractor(new ApiQuery(new HttpClientImpl())));
        }

        private void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            _presenter.Load();
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }

        public void DisplayJokes(JokesViewModel jokeViewModel)
        {
            this.DataContext = jokeViewModel;
        }

        public void DisplayLoader()
        {
            progressRing.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        public void HideLoader()
        {
            progressRing.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }
    }
}
