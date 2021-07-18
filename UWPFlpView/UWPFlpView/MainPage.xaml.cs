using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPFlpView
{
    public class MyItem
    {
        public string ImagePath { get; set; }

        public string ImageName { get; set; }

    }
    public sealed partial class MainPage : Page
    {
        List<MyItem> listImages = new List<MyItem>();

        public MainPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            InitImage();
            flipView.ItemsSource = listImages;
        }

        private void InitImage()
        {
            listImages.Add(new MyItem() { ImageName = "1", ImagePath = "ms-appx:///Assets/1.jpg" });
            listImages.Add(new MyItem() { ImageName = "2", ImagePath = "ms-appx:///Assets/2.jpg" });
            listImages.Add(new MyItem() { ImageName = "3", ImagePath = "ms-appx:///Assets/3.jpg" });
            listImages.Add(new MyItem() { ImageName = "4", ImagePath = "ms-appx:///Assets/4.jpg" });
            listImages.Add(new MyItem() { ImageName = "5", ImagePath = "ms-appx:///Assets/5.jpg" });
            listImages.Add(new MyItem() { ImageName = "6", ImagePath = "ms-appx:///Assets/6.jpg" });
            listImages.Add(new MyItem() { ImageName = "7", ImagePath = "ms-appx:///Assets/7.jpg" });
            listImages.Add(new MyItem() { ImageName = "8", ImagePath = "ms-appx:///Assets/8.jpg" });
            listImages.Add(new MyItem() { ImageName = "9", ImagePath = "ms-appx:///Assets/9.jpg" });
            listImages.Add(new MyItem() { ImageName = "10", ImagePath = "ms-appx:///Assets/10.jpg" });
            listImages.Add(new MyItem() { ImageName = "11", ImagePath = "ms-appx:///Assets/11.jpg" });
            listImages.Add(new MyItem() { ImageName = "12", ImagePath = "ms-appx:///Assets/12.jpg" });
            listImages.Add(new MyItem() { ImageName = "13", ImagePath = "ms-appx:///Assets/13.jpg" });
            listImages.Add(new MyItem() { ImageName = "14", ImagePath = "ms-appx:///Assets/14.jpg" });
            listImages.Add(new MyItem() { ImageName = "15", ImagePath = "ms-appx:///Assets/15.jpg" });
            listImages.Add(new MyItem() { ImageName = "16", ImagePath = "ms-appx:///Assets/16.jpg" });
            listImages.Add(new MyItem() { ImageName = "17", ImagePath = "ms-appx:///Assets/17.jpg" });
            listImages.Add(new MyItem() { ImageName = "18", ImagePath = "ms-appx:///Assets/18.jpg" });
        }
    }


}
