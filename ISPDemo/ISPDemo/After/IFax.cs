using ISPDemo.Models;
using System.Collections.Generic;

namespace ISPDemo.After
{
    public interface IFax
    {
        void Fax(List<Document> documents);
    }
}
