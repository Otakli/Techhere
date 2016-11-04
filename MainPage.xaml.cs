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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Techhere
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            slider();
        }
       
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

       

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void gridView_menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void slider()
        {
           
            DispatcherTimer dpt = new DispatcherTimer();
            dpt.Interval = new TimeSpan(0, 0, 2);
            dpt.Tick += Dpt_Tick;
            dpt.Start();
           
        }

        private void Dpt_Tick(object sender, object e)
        {
            /*int saniye;
            saniye = DateTime.Now.Second;
            if (saniye % 2 == 0) { slider_pivot.SelectedIndex = 1; }
            else { slider_pivot.SelectedIndex = 0; }*/
            if (slider_pivot.SelectedIndex == 4) { slider_pivot.SelectedIndex = 0; }
            else { slider_pivot.SelectedIndex = slider_pivot.SelectedIndex + 1; }

        }

        private void button_menu_Click(object sender, RoutedEventArgs e)
        {
            pivot_page.SelectedIndex = 0;
            
        }
        

        private void pivot_page_PivotItemLoaded(Pivot sender, PivotItemEventArgs args)
        {
            if (pivot_page.SelectedIndex==1) {

                alti_menu_buton.Opacity = 0;
                alti_kullanici_buton.Opacity = 0;
                alti_sepet_buton.Opacity = 0;
              
            }
            if (pivot_page.SelectedIndex == 0)
            {

                alti_menu_buton.Opacity = 100;
                alti_kullanici_buton.Opacity = 0;
                alti_sepet_buton.Opacity = 0;

            }
            if (pivot_page.SelectedIndex == 2)
            {

                alti_menu_buton.Opacity = 0;
                alti_kullanici_buton.Opacity = 100;
                alti_sepet_buton.Opacity = 0;

            }

        }

        private void button_kullanici_Click(object sender, RoutedEventArgs e)
        {
            pivot_page.SelectedIndex = 2;
        }

        private void image_logo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            pivot_page.SelectedIndex = 1;
        }
    }
    
    
    
}
