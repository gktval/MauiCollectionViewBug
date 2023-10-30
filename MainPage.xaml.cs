using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiApp6
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Layer> _layers;
        public ObservableCollection<Layer> Layers
        {
            get { return _layers; }
            set { _layers = value; OnPropertyChanged(nameof(Layers)); }
        }

        public MainPage()
        {
            InitializeComponent();

            Layers = [new Layer("Item 1", "ABC"), new Layer("Item 2", "DEF"), new Layer("Item 3", "GHI"), new Layer("Item 4", "sdf")];
            BindingContext = this;
        }

    }

    public class Layer
    {
        public Layer(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }

}
