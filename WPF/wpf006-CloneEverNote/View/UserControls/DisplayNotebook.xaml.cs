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
using wpf006_CloneEverNote.Model;

namespace wpf006_CloneEverNote.View.UserControls
{
    /// <summary>
    /// Interação lógica para DisplayNotebook.xam
    /// </summary>
    public partial class DisplayNotebook : UserControl
    {


        public Notebook BookNote
        {
            get { return (Notebook)GetValue(BookNoteProperty); }
            set { SetValue(BookNoteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BookNoteProperty =
            DependencyProperty.Register("MyProperty", typeof(Notebook), typeof(DisplayNotebook), new PropertyMetadata(null, SetValues));

        private static void SetValues(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DisplayNotebook notebookUserControl = d as DisplayNotebook;

            if (notebookUserControl != null)
            {
                notebookUserControl.DataContext = notebookUserControl.BookNote;
            }
        }

        public DisplayNotebook()
        {
            InitializeComponent();
        }
    }
}
