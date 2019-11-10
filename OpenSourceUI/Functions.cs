using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib.Specialized;

namespace OpenSourceUI
{
    class Functions
    {
        public static SxLibWinForms Lib;

        public static readonly Random Rnd = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Rnd.Next(s.Length)]).ToArray());
        }

        public static OpenFileDialog OpenFile = new OpenFileDialog
        {
            Filter = "Text Files (*.txt)|*.txt|Lua Files (*lua*)|*.lua",
            FilterIndex = 1,
            RestoreDirectory = true,
            Title = "Open File"
        };

        public static OpenFileDialog ExecuteDialog = new OpenFileDialog
        {
            Filter = "Text Files (*.txt)|*.txt|Lua Files (*lua*)|*.lua",
            FilterIndex = 1,
            RestoreDirectory = true,
            Title = "Execute Script"
        };
    }
}
