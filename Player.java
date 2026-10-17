
public class Player {

    private String playerName;
    private int health;
    private int score;
    private int level;


    private static int playerCount = 0;


    public Player() {
        playerName = "Unknown";
        health = 100;
        score = 0;
        level = 1;
        playerCount++;
    }

    // Parameterized constructor
    public Player(String playerName, int health, int score, int level) {
        this.playerName = playerName;
        this.health = health;
        this.score = score;
        this.level = level;
        playerCount++;
    }

    // Getter methods
    public String getPlayerName() {
        return playerName;
    }

    public int getHealth() {
        return health;
    }

    public int getScore() {
        return score;
    }

    public int getLevel() {
        return level;
    }

    // Setter methods
    public void setPlayerName(String playerName) {
        this.playerName = playerName;
    }

    public void setHealth(int health) {
        this.health = health;
    }

    public void setScore(int score) {
        this.score = score;
    }

    public void setLevel(int level) {
        this.level = level;
    }

    // Behavior methods
    public void takeDamage(int amount) {
        health -= amount;
    }

    public void addScore(int points) {
        score += points;
    }

    public void levelUp() {
        level++;
    }

    // Static method
    public static int getPlayerCount() {
        return playerCount;
    }

    // toString method
    @Override
    public String toString() {
        return "Player: " + playerName +
            ", Health: " + health +
            ", Score: " + score +
            ", Level: " + level;
    }
}