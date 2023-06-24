using Microsoft.Win32;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Text;

namespace MauiApp4;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Tourist> TouristCollection; 

	public MainPage()
	{
		InitializeComponent();
        TouristCollection = new ObservableCollection<Tourist>();
        GetTouristInfo(); 
	}

    private void GetTouristInfo()
    {
        var tourist = new Tourist
        {
            tourist_name = "Ali",
            tourist_email = "ali@hotmail.com",
            tourist_location = "KSA"
        };

        TouristCollection.Add(tourist);

        touristCollectionList.ItemsSource = TouristCollection;
    }

    public class Tourist
    {
        public string tourist_name { get; set; }
        public string tourist_email { get; set; }
        public string tourist_location { get; set; }
    }

   
}

