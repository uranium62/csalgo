using Algo.Lib.Chapter3;
using Xunit;

namespace Algo.Lib.Test.Chapter3
{
    public class Exercise7Test
    {
        [Fact]
        public void Get_the_most_oldest_cat_and_dog()
        {
            AnimalQueue queue = new AnimalQueue();
            queue.Push(new Dog { Order = 5 });
            queue.Push(new Dog { Order = 9 });
            queue.Push(new Dog { Order = 7 });
            queue.Push(new Cat { Order = 5 });
            queue.Push(new Cat { Order = 3 });
            queue.Push(new Cat { Order = 1 });

            var cat1 = queue.PopCat();
            var cat2 = queue.PopCat();
            var cat3 = queue.PopCat();
            var dog1 = queue.PopDog();
            var dog2 = queue.PopDog();
            var dog3 = queue.PopDog();

            Assert.Equal(cat1.Order, 5);
            Assert.Equal(cat2.Order, 3);
            Assert.Equal(cat3.Order, 1);
            Assert.Equal(dog1.Order, 9);
            Assert.Equal(dog2.Order, 7);
            Assert.Equal(dog3.Order, 5);

        }
    }
}
