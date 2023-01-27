using System.Windows.Input;

namespace TestErrorApplyQueryAttributes.MVVM.ViewModels
{
    public class SecondLevelPageViewModel
    {
        public ICommand GoBackCommand => new Command(async () => await GoBack());

        private async Task GoBack()
        {
            await Shell.Current.GoToAsync($"..?test=hello");
        }
    }
}
