using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Observer
{
    public class ConcreteObserver: NewObserver
    {
        ConcreteSubject subject;
        Shape shape;

        public ConcreteObserver(ConcreteSubject subject, Shape shape)
        {
            this.subject = subject;
            this.shape = shape;
        }
        
        public override void Update()
        {
           shape.Fill = subject.brush;
        }
    }
}
