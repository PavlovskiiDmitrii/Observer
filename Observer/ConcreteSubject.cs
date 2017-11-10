using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Observer
{
    public  class ConcreteSubject : Subject
    {
        public Brush brush { get; set; }

        protected override Geometry DefiningGeometry => throw new NotImplementedException();
    }
}
