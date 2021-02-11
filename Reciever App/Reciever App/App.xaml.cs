﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Reciever_App.Services;
using Reciever_App.Views;

namespace Reciever_App
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new MainPage();
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
	}
}
