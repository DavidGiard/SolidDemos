using Newtonsoft.Json;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace SOLID_Lab
{
    public static class Photo
    {
        public static void SavePhotoData(string firstName, string lastName)
        {
            // Use your imagination and ADO.NET
            // Save this info to a database
            string cmdString = "INSERT INTO photoInfo (First_Name, Last_Name) VALUES (@first, @last)";
            string connString = "connecitonsting";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = cmdString;
                    comm.Parameters.AddWithValue("@first", firstName);
                    comm.Parameters.AddWithValue("@last", lastName);
                    //conn.Open();
                    //comm.ExecuteNonQuery();
                }
            }
        }

        public static void RetrievePhotoData(string photoId)
        {
            // Use your imagination and ADO.NET
            // Retrieve data from a database by Photo ID
        }

        public static void CopyPhoto(string photoPath)
        {
            string folder = Path.GetDirectoryName(photoPath);
            string fileName = Path.GetFileName(photoPath);
            string extension = Path.GetExtension(photoPath);
            string newFileName = folder + @"\" + Path.GetFileNameWithoutExtension(photoPath) + "_bak" + "." + extension;
            File.Copy(photoPath, newFileName, true);
        }

        public async static Task<string> AnalyzeImage(string photoPath)
        {
            Image img = Image.FromFile(photoPath);
            byte[] byteData;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byteData = ms.ToArray();
            }

            string visionApiKey = ConfigurationManager.AppSettings["VisionApiKey"];

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", visionApiKey);
            string uri = "https://westus.api.cognitive.microsoft.com/vision/v1.0/analyze?visualFeatures=Categories&language=en";
            HttpResponseMessage response;
            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response = await client.PostAsync(uri, content);
            }

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return data;
                var results = JsonConvert.DeserializeObject(data);
            }

            return "";


        }
    }
}
