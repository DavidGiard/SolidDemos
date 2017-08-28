using System;
using System.Collections.Generic;
using ISPDemo.Models;

namespace ISPDemo.After
{
    public interface IPrinter
    {
        void Print(List<Document> documents);
    }
}
