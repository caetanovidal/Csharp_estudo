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
    /// Interação lógica para DisplayNote.xam
    /// </summary>
    public partial class DisplayNote : UserControl
    {
        public Notes Note
        {
            get { return (Notes)GetValue(NoteProperty); }
            set { SetValue(NoteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NoteProperty =
            DependencyProperty.Register("Note", typeof(Notes), typeof(DisplayNote), new PropertyMetadata(null, SetValues));

        private static void SetValues(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DisplayNote noteUserControl = d as DisplayNote;

            if (noteUserControl != null)
            {
                noteUserControl.DataContext = noteUserControl.Note;
            }
        }

        public DisplayNote()
        {
            InitializeComponent();
        }
    }
}
