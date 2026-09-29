public class DogTest {
    public static void main(String[] args) {
        // Create Dog objects using both constructors
        Dog dog1 = new Dog();
        Dog dog2 = new Dog("Buddy", 3, true);
        Dog dog3 = new Dog("Max", 5, false);

        // Display initial information using toString()
        System.out.println(dog1);
        System.out.println(dog2);
        System.out.println(dog3);

        // Call instance methods
        dog2.speak();
        dog3.speak();

        // Increase age using haveBirthday()
        dog2.haveBirthday();
        System.out.println(dog2.getName() + " just had a birthday and is now " + dog2.getAge() + " years old!");

        // Modify instance variables using mutator methods
        dog1.setName("Charlie");
        dog1.setAge(2);
        dog1.setGoodDog(false);

        System.out.println("Updated " + dog1);

        // Call static method to get total number of Dog objects
        System.out.println("Total number of dogs created: " + Dog.getDogCount());

        // Find and display the older dog
        Dog olderDog = Dog.getOlderDog(dog2, dog3);
        System.out.println("The older dog is: " + olderDog.getName() + ", who is " + olderDog.getAge() + " years old.");
    }
}
