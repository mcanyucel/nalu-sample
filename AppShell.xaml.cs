using Nalu;

namespace nalu_sample
{
    public partial class AppShell : NaluShell
    {
        public AppShell(INavigationService navigationService) : base(navigationService, typeof(MainPage))
        {
            InitializeComponent();
        }
    }
}
