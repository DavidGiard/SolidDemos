using System.Threading.Tasks;

namespace DependencyInversionDemo.After
{
    public class EmotionCaller
    {
        private IEmotionLib _emotionLib = null;
        public EmotionCaller(IEmotionLib emotionLib)
        {
            _emotionLib = emotionLib;
        }
        public async Task<string> GetEmotions()
        {
            var faceUrl = @"https://s-media-cache-ak0.pinimg.com/564x/48/fb/85/48fb85ef119f5cf5a986c04f44305e7f.jpg";
            string results = "";
            var emotionLib = new Before.OnlineEmotionLib();
            results = await _emotionLib.GetEmotions(faceUrl);
            return results;
        }
    }
}
