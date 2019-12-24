using SmartmanApps;
using Xamarin.Forms;

namespace TestColourSettings {public class App :Application {

public App()
{
//MainPage=new MainPage();             This works
//MainPage=new ColourSettingsPage();   This works
MainPage=new TestCSPPage();          //this works with no inheritance, not with
}

protected override void OnStart()
{
}

protected override void OnSleep()
{
}

protected override void OnResume()
{
}

}}