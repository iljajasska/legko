using legko.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace legko
{
    public partial class MainPage : MasterDetailPage
    {
        string[] tachkiTitles = new string[] {
            "BMW",
            "Mercedes",
            "Audi",
            "Saab",
            "Volkswagen",
            "Opel",
            "Peugeot",
            "Skoda",
            "Toyota",
        };

        string[] tachkiDescriptions = new string[]
        {
            "BMW AG (аббревиатура от Bayerische Motoren Werke AG — «Баварские моторные заводы») — немецкий производитель автомобилей.",
            "Mercedes-Benz — торговая марка и одноимённая компания — производитель легковых автомобилей.",
            "Audi AG — автомобилестроительная компания в составе концерна Volkswagen Group.",
            "SAAB — автомобильная марка, существующая с 1937 года по конец 2011, затем с 2012, принадлежащая шведско-японско-китайской компании National Electric Vehicle Sweden.",
            "Volkswagen — немецкая автомобильная марка, одна из многих, принадлежащих концерну Volkswagen AG.",
            "Adam Opel AG — немецкий производитель автомобилей, штаб-квартира расположена в Рюссельсхайме (Германия).",
            "Peugeot — один из основных французских производителей автомобилей",
            "Škoda Auto — крупнейший производитель автомобилей в Чешской Республике, со штаб-квартирой, расположенной в городе Млада-Болеслав.",
            "Toyota Motor Corporation — крупнейшая японская автомобилестроительная корпорация",
        };

        string[] tachkiImageUrls = new string[]
        {
            "https://cdn.iconscout.com/icon/free/png-512/bmw-5-202750.png",
            "https://i.pinimg.com/originals/82/8a/68/828a68c42ed5d2fc3a63a2d3a02c09f7.png",
            "https://cdn.iconscout.com/icon/free/png-512/audi-10-555177.png",
            "https://cdn.iconscout.com/icon/free/png-512/saab-202892.png",
            "https://www.codinter.com/en/wp-content/uploads/sites/2/2018/01/logo-volkswagen-256x256.png",
            "https://cdn.iconscout.com/icon/free/png-256/opel-1-202861.png",
            "https://p1.hiclipart.com/preview/190/161/318/icons-cars-brands-2-peugeot-png-clipart.jpg",
            "https://cdn.iconscout.com/icon/free/png-256/skoda-1-202898.png",
            "https://www.codinter.com/en/wp-content/uploads/sites/2/2018/01/logo-toyota-256x256.png",
        };

        string[] tachkiWikiUrls = new string[]
        {
            "https://ru.wikipedia.org/wiki/BMW",
            "https://ru.wikipedia.org/wiki/Mercedes-Benz",
            "https://ru.wikipedia.org/wiki/Audi",
            "https://ru.wikipedia.org/wiki/SAAB",
            "https://ru.wikipedia.org/wiki/Volkswagen",
            "https://ru.wikipedia.org/wiki/Opel",
            "https://ru.wikipedia.org/wiki/Peugeot",
            "https://ru.wikipedia.org/wiki/Škoda_Auto",
            "https://ru.wikipedia.org/wiki/Toyota",
        };

        public MainPage()
        {
            InitializeComponent();
            aboutList.ItemsSource = GetMenuList();
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = e.SelectedItem as krut;
            var selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage(selectedPage);
            IsPresented = false;
        }

        private List<krut> GetMenuList()
        {
            List<krut> tachkList = new List<krut>();
            for (int i = 0; i < tachkiTitles.Length; i++)
            {
                var tachk = new krut()
                {
                    Title = tachkiTitles[i],
                    Description = tachkiDescriptions[i],
                    Image = ImageSource.FromUri(new Uri(tachkiImageUrls[i])),
                    WikiUri = tachkiWikiUrls[i],
                };
                var currentPage = new AboutPage(tachk);
                tachk.TargetPage = currentPage;
                tachkList.Add(tachk);
            }
            return tachkList;
        }

        private void LoadPicture(string uri)
        {
            throw new NotImplementedException();
        }
    }
}