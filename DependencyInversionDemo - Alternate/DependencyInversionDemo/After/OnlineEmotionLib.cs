using DependencyInversionDemo.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DependencyInversionDemo.After
{
    public class OnlineEmotionLib: IEmotionLib
    {
        public async Task<string> GetEmotions(string imageUrl)
        {
            string emotionApiKey = ConfigurationManager.AppSettings["EmotionApiKey"]; 

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", emotionApiKey);
            string uri = "https://westus.api.cognitive.microsoft.com/emotion/v1.0/recognize";
            HttpResponseMessage response;
            var json = "{'url': '" + imageUrl + "'}";
            byte[] byteData = Encoding.UTF8.GetBytes(json);
            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
            }

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject(data);

                Face[] faces = JsonConvert.DeserializeObject<Face[]>(data);
                var sb1 = new StringBuilder();
                var sb2 = new StringBuilder();
                var faceNumber = 0;
                foreach (Face face in faces)
                {
                    faceNumber++;
                    var scores = face.Scores;

                    var anger = scores.Anger;
                    var contempt = scores.Contempt;
                    var disgust = scores.Disgust;
                    var fear = scores.Fear;
                    var happiness = scores.Happiness;
                    var neutral = scores.Neutral;
                    var surprise = scores.Surprise;
                    var sadness = scores.Sadness;

                    var emotionScoresList = new List<EmotionScore>();
                    emotionScoresList.Add(new EmotionScore("anger", anger));
                    emotionScoresList.Add(new EmotionScore("contempt", contempt));
                    emotionScoresList.Add(new EmotionScore("disgust", disgust));
                    emotionScoresList.Add(new EmotionScore("fear", fear));
                    emotionScoresList.Add(new EmotionScore("happiness", happiness));
                    emotionScoresList.Add(new EmotionScore("neutral", neutral));
                    emotionScoresList.Add(new EmotionScore("surprise", surprise));
                    emotionScoresList.Add(new EmotionScore("sadness", sadness));

                    var maxEmotionScore = emotionScoresList.Max(e => e.EmotionValue);
                    var likelyEmotion = emotionScoresList.First(e => e.EmotionValue == maxEmotionScore);

                    var thisFaceText = string.Format("Face {0}: Emotion={1}; Score={2:##0.00}%\n", faceNumber, likelyEmotion.EmotionName, maxEmotionScore*100);
                    sb1.Append(thisFaceText);
                }

                return sb1.ToString();
            }
            else
            {
                return "Error";
            }
        }
    }
}
