using Prism;
using Prism.Unity;
using Prism.Ioc;
using ${Namespace}.Views;
using ${Namespace}.ViewModels;

namespace ${Namespace}
{
	public partial class App : PrismApplication
	{
        // This ctor is used by the designer preview
        public App() : this(null) { }

		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
		}

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>();
        }
	}
}

