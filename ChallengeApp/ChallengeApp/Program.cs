using ChallengeApp;

User user1 = new User("Artur", "32455");
User user2 = new User("Nati", "009845");
User user3 = new User("Marta", "676845");
User user4 = new User("Gosia", "673576");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
