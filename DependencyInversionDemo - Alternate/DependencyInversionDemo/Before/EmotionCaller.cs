using System.Threading.Tasks;

namespace DependencyInversionDemo.Before
{
    public class EmotionCaller
    {
        public async Task<string> GetEmotions(string realOrFake="REAL")
        {
            var faceUrl = @"https://s-media-cache-ak0.pinimg.com/564x/48/fb/85/48fb85ef119f5cf5a986c04f44305e7f.jpg";
            string results = "";
            if (realOrFake == "REAL")
            {
                var emotionLib = new Before.OnlineEmotionLib();
                results = await emotionLib.GetEmotions(faceUrl);
            }
            else
            {
                var emotionLib = new Before.FakeEmotionLib();
                results = await emotionLib.GetEmotions(faceUrl);
            }
            return results;
        }

    }
}
