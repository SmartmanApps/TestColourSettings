﻿using SmartmanApps;
using Xamarin.Forms;

namespace TestColourSettings {public class App :Application {

public App()
{
//MainPage=new MainPage();
MainPage=new ColourSettingsPage();
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