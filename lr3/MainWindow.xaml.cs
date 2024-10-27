using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lr3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        public string[] arr = new string[] {

            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp80AzgJALMVFQVYFmyIdVXhqBFGZfPXINTQ&s",
            "https://howlongtobeat.com/games/152370_The_Legend_of_Zelda_Echoes_of_Wisdom.jpg",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaidWEwuDJhM_OAJYAfnXW9Pb2V4lopzzHvw&s",
            "https://image.civitai.com/xG1nkqKTMzGDvpLrqFT7WA/0928fda6-a2d2-4681-3ac2-8efe960fdd00/width=450/3978521556-471778443-botw%20style,%20princess%20zelda,%201girl,%20bangs,%20blonde%20hair,%20breasts,%20white%20dress,%20hair%20ornament,%20bare%20shoulders,%20green%20eyes,%20jewelry,.jpeg",
            "https://t3.ftcdn.net/jpg/06/24/16/90/360_F_624169025_g8SF8gci4C4JT5f6wZgJ0IcKZ6ZuKM7u.jpg",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvpkt-p-gpU_4k4srKywNpCixvuBcUHNxifw&s",
            "https://habrastorage.org/getpro/habr/upload_files/6a5/575/a5b/6a5575a5b74e9a9778e2b5a9ef862dbd.png",
            "https://aish.com/wp-content/uploads/2022/02/princess-zelda-and-queen-esther-how-the-legend-of-zelda-helped-me-understand-purim-730_x_411.jpg",
            "https://www.lego.com/cdn/cs/set/assets/blt6a8cb14aa4efef08/77092.png?fit=crop&quality=80&width=600&height=600&dpr=1",
            "https://platform.polygon.com/wp-content/uploads/sites/2/chorus/uploads/chorus_asset/file/25498916/zelda_echoes_of_wisdom_design.jpg?quality=90&strip=all&crop=7.7930174563591,0,84.413965087282,100",
            "https://m.media-amazon.com/images/M/MV5BZDI3NjRhNjgtYTdmYy00MGM0LWI1YWEtMzEwNmJlZTkwNTA3XkEyXkFqcGc@._V1_.jpg",
            "https://i.pinimg.com/originals/84/e4/a7/84e4a7fe89284c359a91ce6351ab6e32.jpg",


        };

        public MainWindow()
        {
            InitializeComponent();
            WrapPanel cont = Gallery;


            foreach (var imageSrc in arr)
            {

                Img newImageCard = new Img();
                newImageCard.image.Source = new BitmapImage(new Uri(imageSrc));
                newImageCard.imageSource.Text = imageSrc;

                cont.Children.Add(newImageCard);
            }

        }


    }
}