using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace AdvertisementLogisticCompany
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DoubleAnimation WA = new DoubleAnimation();
            WA.From = 300;
            WA.To = 320;
            WA.Duration = TimeSpan.FromSeconds(2);
            WA.RepeatBehavior = RepeatBehavior.Forever;
            WA.AutoReverse = true;
            adButton.BeginAnimation(WidthProperty, WA);
            adImage.BeginAnimation(WidthProperty, WA);

            DoubleAnimation HA = new DoubleAnimation();
            HA.From = 50;
            HA.To = 70;
            HA.Duration = TimeSpan.FromSeconds(2);
            HA.RepeatBehavior = RepeatBehavior.Forever;
            HA.AutoReverse = true;
            adButton.BeginAnimation(HeightProperty, HA);

            DoubleAnimation HAImage = new DoubleAnimation();
            HAImage.From = 150;
            HAImage.To = 170;
            HAImage.Duration = TimeSpan.FromSeconds(2);
            HAImage.RepeatBehavior = RepeatBehavior.Forever;
            HAImage.AutoReverse = true;
            adImage.BeginAnimation(HeightProperty, HAImage);

            ThicknessAnimation MA = new ThicknessAnimation(); // анимация границ
            MA.From = new Thickness(0, 0, 0, 0);
            MA.To = new Thickness(25, 25, 25, 25);
            MA.Duration = TimeSpan.FromSeconds(2);
            MA.RepeatBehavior = RepeatBehavior.Forever;
            MA.AutoReverse = true;
            adButton.BeginAnimation(MarginProperty, MA);

            ColorAnimation BA = new ColorAnimation();
            ColorConverter CC = new ColorConverter();
            Color Cstart = (Color)CC.ConvertFrom("#C7C9C7");
            adButton.Background = new SolidColorBrush(Cstart);
            BA.From = Cstart;
            BA.To = (Color)CC.ConvertFrom("#FF6F97EE");
            BA.Duration = TimeSpan.FromSeconds(2);
            BA.RepeatBehavior = RepeatBehavior.Forever;
            BA.AutoReverse = true;
            adButton.Background.BeginAnimation(SolidColorBrush.ColorProperty, BA);

            DoubleAnimation FSA = new DoubleAnimation();
            FSA.From = 20;
            FSA.To = 30;
            FSA.Duration = TimeSpan.FromSeconds(2);
            FSA.RepeatBehavior = RepeatBehavior.Forever;
            FSA.AutoReverse = true;
            adText.BeginAnimation(FontSizeProperty, FSA);

            DoubleAnimation WAText = new DoubleAnimation();
            WAText.From = 200;
            WAText.To = 300;
            WAText.Duration = TimeSpan.FromSeconds(2);
            WAText.RepeatBehavior = RepeatBehavior.Forever;
            WAText.AutoReverse = true;
            adText.BeginAnimation(WidthProperty, WAText);

        }
    }
}
