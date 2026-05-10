using ClassesIntro;
// See https://aka.ms/new-console-template for more information
// string playerAvatar = "@";
// Console.WriteLine(playerAvatar);
Vector2 startingPosition = new Vector2(4, 2);
Player hero = new Player(startingPosition);

List<Character> heroClones = new List<Character>();
heroClones.Add(hero);
//heroClones.Add(new Npc(startingPosition));

foreach (Character clone in heroClones)
{
    clone.Display();
}

while (true)
{
    for (int i = 0; i < heroClones.Count; i++)
    {
        Character character = heroClones[i];
        character.Display();
        
        character.ChooseAction();
        
        character.Display();
    }
}