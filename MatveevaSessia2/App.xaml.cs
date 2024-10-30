using MatveevaSessia2.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MatveevaSessia2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static MatveevaSessia2Entities _context;
        public static MatveevaSessia2Entities GetContext()
        {
            if (_context == null)
            {
                _context = new MatveevaSessia2Entities();
            }
            return _context;
        }
    }
}
