using System.Windows.Input;

namespace MarkupExtensionsExamples
{
    public partial class MainPage : ContentPage
    {
       public ICommand CrearComando { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            CrearComando = new Command<Type>((Type TipoVista) =>
            {
                View vista = (View)Activator.CreateInstance(TipoVista);
                vista.VerticalOptions = LayoutOptions.Center;
                stack.Add(vista);
            });

            BindingContext = this;
        }

        
    }

}
