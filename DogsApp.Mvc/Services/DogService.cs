
using DogsApp.Mvc.Models;

namespace DogsApp.Mvc.Services
{
    public class DogService
    {
        private List<Dog> dogs = [
            new Dog { Id= 1, Name = "Fido", Age = 1},
            new Dog { Id= 52, Name = "Brutus", Age = 2},
        ];

        public void AddDog(Dog dog)
        {
            dog.Id = dogs.Max(d => d.Id) + 1;
            dogs.Add(dog);
        }
        public Dog[] GetAllDogs()
        {
            return dogs.ToArray();
        }

        public Dog GetDogById(int id)
        {
            return dogs.Single(d => d.Id == id);
        }
        public void EditDog(Dog dog)
        {
            var targetDog = GetDogById(dog.Id);
            targetDog.Name = dog.Name;
            targetDog.Age = dog.Age;
            
        }

        public void DeleteDog(int id)
        {
            var targetDog = GetDogById(id);
            dogs.Remove(targetDog); 
            targetDog = null;
        }

    }
}
