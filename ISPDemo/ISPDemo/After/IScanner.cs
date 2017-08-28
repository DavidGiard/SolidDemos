using ISPDemo.Models;
using System.Collections.Generic;

namespace ISPDemo.After
{
    interface IScanner
    {
        void Scan(List<Document> documents);
    }
}
