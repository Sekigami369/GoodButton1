using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GoodButton1
{
   
    public partial class CustomGoodButton : UserControl
    {
        public CustomGoodButton()
        {
            InitializeComponent();
        }

        private void heartButton_Click(object sender, RoutedEventArgs e)
        {
            AnimateHeart();
        }

        private void AnimateHeart()
        {
            ScaleTransform scaleTrnsform = new ScaleTransform();
            heartbutton.RenderTransform = scaleTrnsform;

            //動きのアニメーション設定
            DoubleAnimation animation = new DoubleAnimation
            {
                From = 1.0,
                To = 2.0,
                Duration = new Duration(TimeSpan.FromSeconds(0.3)),
                AutoReverse = true
            };

            //アニメーションを適用する
            scaleTrnsform.BeginAnimation(ScaleTransform.ScaleXProperty, animation);
            scaleTrnsform.BeginAnimation(ScaleTransform.ScaleYProperty, animation);


            //色のアニメーションの設定
            ColorAnimation colorAnimation = new ColorAnimation
            {
                From = Colors.Transparent,
                To = Colors.Red,
                Duration = new Duration(TimeSpan.FromSeconds(0.3)),
                AutoReverse = true
            };

            //アニメーションを適用する
            heartbutton.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);
        }
       
       
    }
}
