public class Dog {
    // Instance variables
    private String name;
    private int age;
    private boolean goodDog;

    // Static variable to track the number of Dog objects created
    private static int dogCount = 0;

    // Default constructor
    public Dog() {
        name = "None";
        age = 0;
        goodDog = true;
        dogCount++; // Increment dog count when a new dog is created
    }

    // Parameterized constructor
    public Dog(String n, int a, boolean gd) {
        name = n;
        age = a;
        goodDog = gd;
        dogCount++;
    }

    // Accessor (getter) methods
    public String getName() {
        return name;
    }

    public int getAge() {
        return age;
    }

    public boolean isGoodDog() {
        return goodDog;
    }

    // Mutator (setter) methods
    public void setName(String n) {
        name = n;
    }

    public void setAge(int a) {
        age = a;
    }

    public void setGoodDog(boolean gd) {
        goodDog = gd;
    }

    // Method for the dog to speak
    public void speak() {
        System.out.println("Woof Woof!");
    }

    // Method to increase the dog's age by 1
    public void haveBirthday() {
        age++;
    }

    // Static method to return the number of Dog objects created
    public static int getDogCount() {
        return dogCount;
    }

    // Static method to return the older of two Dog objects
    public static Dog getOlderDog(Dog d1, Dog d2) {
        if (d1.age > d2.age){
            return d1;
        }
        else{
            return d2;
        }
    }

    // toString method to return a formatted string representation of the Dog object
    //@Override
    public String toString() {
        return name + " " + age + ". Is " + name + " a good dog? " + goodDog;
    }
}
