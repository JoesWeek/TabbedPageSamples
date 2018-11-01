using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TabbedPageSamples {
    public partial class App : Xamarin.Forms.Application {
        public App() {
            InitializeComponent();
            var tabbedPage = new Xamarin.Forms.TabbedPage();
            tabbedPage.On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            tabbedPage.BarBackgroundColor = Color.White;
            tabbedPage.Children.Add(new MainPage() { Title = "标题", Icon = "Icon.png" });
            tabbedPage.Children.Add(new MainPage() { Title = "标题", Icon = "Icon.png" });
            tabbedPage.Children.Add(new MainPage() { Title = "标题", Icon = "Icon.png" });
            tabbedPage.Children.Add(new MainPage() { Title = "标题", Icon = "Icon.png" });
            tabbedPage.Children.Add(new MainPage() { Title = "标题", Icon = "Icon.png" });
            MainPage = tabbedPage;
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
