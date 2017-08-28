using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionDemo.After
{
    public class FakeEmotionLib : IEmotionLib
    {
        public async Task<string> GetEmotions(string imageUrl)
        {
            var thisFaceText = string.Format("Face {0}: Emotion={1}; Score={2:##0.00}%\n", 1, "Happiness", 95);
            return thisFaceText;

        }

    }
}
