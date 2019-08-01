# TestPrism
Testing Prism stuff for learning purposes.

Currently demonstrates differences in Prism PageLifecycle between calling with and without a navigationpage:

With navigationpage: `await navigationService.NavigateAsync("NavigationPage/SecondPage");`
1. Initialize
2. OnNavigatedTo
3. OnAppearing

Without navigationpage: `await navigationService.NavigateAsync("SecondPage");`
1. Initialize
2. OnAppearing
3. OnNavigatedTo
