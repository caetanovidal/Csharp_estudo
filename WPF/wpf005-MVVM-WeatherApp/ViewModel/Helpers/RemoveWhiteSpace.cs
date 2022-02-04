using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf005_MVVM.ViewModel.Helpers
{
    public static class RemoveWhiteSpace
    {
        public static string Remove(this string input)
        {
            return input.Normalize();
        }
    }
}
