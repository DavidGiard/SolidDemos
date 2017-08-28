using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionDemo.Models
{
    public class Face
    {
        public Rectangle Rectangle { get; set; }
        public Scores Scores { get; set; }

    }
}
