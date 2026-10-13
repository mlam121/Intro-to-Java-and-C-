    // DO NOT MAKE EDITS TO THIS FILE!

public class PlayerTest {
    public static void main(String[] args) {

        // Create players using both constructors
        Player player1 = new Player();
        Player player2 = new Player("PixelMaster", 100, 500, 2);

        // Display starting information
        System.out.println(player1);
        System.out.println(player2);

        // Test setter methods
        player1.setPlayerName("Rookie");
        player1.setHealth(100);
        player1.setScore(100);
        player1.setLevel(1);

        // Test behavior methods
        player1.takeDamage(25);
        player1.addScore(250);
        player1.levelUp();

        player2.takeDamage(40);
        player2.addScore(500);

        // Test getter methods
        System.out.println("Rookie's health: " + player1.getHealth());
        System.out.println("Rookie's score: " + player1.getScore());
        System.out.println("Rookie's level: " + player1.getLevel());

        System.out.println("PixelMaster's health: " + player2.getHealth());
        System.out.println("PixelMaster's score: " + player2.getScore());

        // Display updated player information
        System.out.println(player1);
        System.out.println(player2);

        // Test static method
        System.out.println("Total players created: " + Player.getPlayerCount());
    }
}
