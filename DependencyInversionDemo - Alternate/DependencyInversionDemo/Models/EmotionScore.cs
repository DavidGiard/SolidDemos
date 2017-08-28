using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionDemo.Models
{
    public class EmotionScore
    {
        public EmotionScore(string emotionName, float emotionValue)
        {
            EmotionName = emotionName;
            EmotionValue = emotionValue;
        }
        public string EmotionName { get; set; }
        public float EmotionValue { get; set; }

    }
}
