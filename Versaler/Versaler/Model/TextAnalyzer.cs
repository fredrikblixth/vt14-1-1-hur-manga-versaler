using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Versaler.Model
{
    public static class TextAnalyzer
    {
        public static int GetNumberOfCapitals(string text)
        {
            var numberOfCapitals = 0;

            foreach (char c in text)
            {
                // 65 - 90 A-Z
                // 197 196 214 ÅÄÖ

                if(c > 64 && c < 91 || c == 197 || c == 196 || c == 214)
                {
                    numberOfCapitals++;
                }
                
            }

            return numberOfCapitals;
        }
    }
}