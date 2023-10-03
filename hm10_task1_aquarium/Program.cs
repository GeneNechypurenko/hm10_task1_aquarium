using hm10_task1_aquarium;

Aquarium aquarium = new Aquarium();

aquarium.AddNewCreature(new Dolphin());
aquarium.AddNewCreature(new AngelFish());
aquarium.AddNewCreature(new Crab());
aquarium.AddNewCreature(new HammerheadShark());
aquarium.AddNewCreature(new Lobster());
aquarium.AddNewCreature(new MandarinDragonet());
aquarium.AddNewCreature(new Orca());
aquarium.AddNewCreature(new SeaTurtle());
aquarium.AddNewCreature(new Squid());
aquarium.AddNewCreature(new TigerShark());

foreach (var creature in aquarium)
{
    creature.Info();
}