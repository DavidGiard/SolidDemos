using System.Threading.Tasks;

namespace DependencyInversionDemo.After
{
    public interface IEmotionLib
    {
        Task<string> GetEmotions(string imageUrl);
    }
}