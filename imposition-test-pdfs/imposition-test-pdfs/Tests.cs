using System;
using System.IO;

namespace imposition_test_pdfs
{
    public static class Tests
    {
        public static string File(string fileName)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        }
    }
}
