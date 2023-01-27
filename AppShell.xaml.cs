using TestErrorApplyQueryAttributes.MVVM.Views;

namespace TestErrorApplyQueryAttributes;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(SecondLevelPageView), typeof(SecondLevelPageView));
    }
}
