using System.Windows.Input;
using TestErrorApplyQueryAttributes.MVVM.Views;

namespace TestErrorApplyQueryAttributes.MVVM.ViewModels
{
    public class Page2ViewModel : IQueryAttributable
    {
        public ICommand GoToSecondLevelCommand => new Command(async () => await GoToSecondLevel());

        private async Task GoToSecondLevel()
        {
            await Shell.Current.GoToAsync(nameof(SecondLevelPageView), true);
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            var test = query["test"].ToString();
        }
    }
}
