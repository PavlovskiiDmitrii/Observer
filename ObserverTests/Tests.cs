using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Windows.Media;
using System.Windows.Shapes;
using Observer;

namespace ObserverTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void subjectCount()
        {
            ConcreteSubject subject = new ConcreteSubject();
            Ellipse testEll1 = new Ellipse();
            ConcreteObserver ob1 = new ConcreteObserver(subject, testEll1);
            Ellipse testEll2 = new Ellipse();
            ConcreteObserver ob2 = new ConcreteObserver(subject, testEll2);
            subject.Attach(ob1);
            subject.Attach(ob2);
            Assert.AreEqual(subject.observers.Count ,2);
        }
        [Test]
        public void observerColor()
        {
            ConcreteSubject subject = new ConcreteSubject();
            subject.brush = Brushes.Red;
            Ellipse testEll1 = new Ellipse();
            ConcreteObserver ob1 = new ConcreteObserver(subject, testEll1);
            subject.Attach(ob1);
            subject.Notify();
            Assert.AreEqual(testEll1.Fill,Brushes.Red);
        }
        [Test]
        public void ChangeObserverColor()
        {
            ConcreteSubject subject = new ConcreteSubject();
            subject.brush = Brushes.Red;
            Ellipse testEll1 = new Ellipse();
            ConcreteObserver ob1 = new ConcreteObserver(subject, testEll1);
            subject.Attach(ob1);
            subject.Notify();
            subject.brush = Brushes.BlueViolet;
            subject.Notify();
            Assert.AreEqual(testEll1.Fill, Brushes.BlueViolet);
        }
        [Test]
        public void RemoveObserver()
        {
            ConcreteSubject subject = new ConcreteSubject();
            subject.brush = Brushes.Red;
            Ellipse testEll1 = new Ellipse();
            ConcreteObserver ob1 = new ConcreteObserver(subject, testEll1);
            subject.Attach(ob1);
            subject.Notify();
            subject.Detach(ob1);
            subject.brush = Brushes.BlueViolet;
            subject.Notify();
            Assert.AreEqual(testEll1.Fill, Brushes.Red);
        }
    }
}
