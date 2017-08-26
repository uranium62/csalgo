using System.Collections.Generic;

namespace Algo.Lib.Chapter3
{
    public abstract class Animal
    {
        public int Order;
    };

    public class Dog : Animal { }
    public class Cat : Animal { }

    public class AnimalQueue
    {
        private readonly LinkedList<Dog> _dogs;
        private readonly LinkedList<Cat> _cats;

        public AnimalQueue()
        {
            _dogs = new LinkedList<Dog>();
            _cats = new LinkedList<Cat>();
        }

        public void Push(Dog dog)
        {
            LinkedListNode<Dog> cur = _dogs.First;

            while (cur != null && cur.Value.Order >= dog.Order)
            {
                cur = cur.Next;
            }

            if (cur == null)
                _dogs.AddLast(dog);
            else
                _dogs.AddBefore(cur, dog);
        }

        public void Push(Cat cat)
        {
            LinkedListNode<Cat> cur = _cats.First;

            while (cur != null && cur.Value.Order >= cat.Order)
            {
                cur = cur.Next;
            }

            if (cur == null)
                _cats.AddLast(cat);
            else
                _cats.AddBefore(cur, cat);
        }

        public Dog PopDog()
        {
            var dog = _dogs.First;

            if (dog == null)
                return null;

            _dogs.RemoveFirst();
            return dog.Value;
        }

        public Cat PopCat()
        {
            var cat = _cats.First;

            if (cat == null)
                return null;

            _cats.RemoveFirst();
            return cat.Value;
        }
    }

    public class Exercise7
    {
        public static Dog GetDog(AnimalQueue queue)
        {
            return queue.PopDog();
        }

        public static Cat GetCat(AnimalQueue queue)
        {
            return queue.PopCat();
        }
    }
}
