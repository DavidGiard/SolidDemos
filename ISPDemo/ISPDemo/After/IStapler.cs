using ISPDemo.Models;
using System.Collections.Generic;

namespace ISPDemo.After
{
    interface IStapler
    {
        void Staple(List<Document> documents);
    }
}
