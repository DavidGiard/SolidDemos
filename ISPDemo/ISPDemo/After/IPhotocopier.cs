using ISPDemo.Models;
using System.Collections.Generic;

namespace ISPDemo.After
{
    interface IPhotocopier
    {
        void PhotoCopy(List<Document> documents);
    }
}
