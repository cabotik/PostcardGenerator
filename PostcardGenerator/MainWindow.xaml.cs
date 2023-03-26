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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PostcardGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Generation()//метод генирируюзий изображение
        {
            Random random = new Random();
            //рвндомный выбор фона
            var background = new List<string> { "background_images/gold_bg.jpeg", "background_images/heart_bg.jpg", "background_images/pink_bg.jpg", "background_images/pretty_bg.jpg", "background_images/rainbow_bg.jpg", };
            int indexB = random.Next(background.Count);
            var bg = background[indexB];//background_images/
            background.RemoveAt(indexB);

            //рандомный выбор глупой картиночки
            var staff = new List<string> { "staff_images/coco_pic.png", "staff_images/flowers_pic.png", "staff_images/heart_pic.png", "staff_images/mouth_pic.png", "staff_images/podro_pic.png", "staff_images/rose_pic.png", "staff_images/strawberry_pic.png", "staff_images/terriblecat_pic.png" };
            int indexS = random.Next(staff.Count);
            var ff = staff[indexS];
            staff.RemoveAt(indexS);//staff_images/

            //рандомный выбор текста
            var text = new List<string> { "text_images/bye.png", "text_images/friday.png", "text_images/day_of_day.png", "text_images/new_day.png", "text_images/saturday.png", "text_images/weekend.png", "text_images/wensday.png" };
            int indexT = random.Next(text.Count);
            var tx = text[indexT];
            text.RemoveAt(indexT);//text_images/

            //группируем картинки и выводим в имедж
            var group = new DrawingGroup();
            group.Children.Add(new ImageDrawing(new BitmapImage(new Uri($@"pack://application:,,,/{bg}", UriKind.Absolute)), new Rect(0, 0, 400, 400)));
            group.Children.Add(new ImageDrawing(new BitmapImage(new Uri($@"pack://application:,,,/{ff}", UriKind.Absolute)), new Rect(100, 200, 200, 200)));
            group.Children.Add(new ImageDrawing(new BitmapImage(new Uri($@"pack://application:,,,/{tx}", UriKind.Absolute)), new Rect(0, 0, 300, 200)));

            PostCard.Source = new DrawingImage(group);
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFave_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnReload_Click(object sender, RoutedEventArgs e)
        {
            Generation();
        }

        private void btnGeneration_Click(object sender, RoutedEventArgs e)
        {
            Generation();
        }
    }
}
