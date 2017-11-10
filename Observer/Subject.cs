using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Observer
{
    public  abstract class Subject : Shape
    {
        public ArrayList observers = new ArrayList();

        public void Attach(NewObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(NewObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (NewObserver observer in observers)
            {
                observer.Update();
            }
        }
    }
}
