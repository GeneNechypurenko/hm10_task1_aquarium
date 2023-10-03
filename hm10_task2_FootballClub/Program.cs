using hm10_task2_FootballClub;

FootballClub fc = new FootballClub();

fc.AddNewPlayer(new Goalkeeper("John", 19));
fc.AddNewPlayer(new Goalkeeper("Albert", 31));
fc.AddNewPlayer(new Defender("Cole", 18));
fc.AddNewPlayer(new Defender("Roman", 24));
fc.AddNewPlayer(new Defender("William", 21));
fc.AddNewPlayer(new Defender("Michael", 19));
fc.AddNewPlayer(new Defender("Ron", 28));
fc.AddNewPlayer(new Halfback("Frederic", 23));
fc.AddNewPlayer(new Halfback("Wincent", 25));
fc.AddNewPlayer(new Halfback("John", 32));
fc.AddNewPlayer(new Halfback("Sam", 20));
fc.AddNewPlayer(new Halfback("William", 29));
fc.AddNewPlayer(new Halfback("George", 22));
fc.AddNewPlayer(new Forward("Alexander", 25));
fc.AddNewPlayer(new Forward("William", 19));
fc.AddNewPlayer(new Forward("Roberto", 17));
fc.AddNewPlayer(new Forward("Michael", 30));

foreach (var player in fc)
{
    player.Info();
}