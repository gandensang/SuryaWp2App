namespace BisnisJamanNow
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageVM vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

    }
}