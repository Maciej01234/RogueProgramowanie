using ClassesIntro;
// See https://aka.ms/new-console-template for more information
// string playerAvatar = "@";
// Console.WriteLine(playerAvatar);
Vector2 startingPosition = new Vector2(4, 2);
Player hero = new Player(startingPosition);

List<Vector2> walls = new List<Vector2>();

walls.Add(new Vector2(6, 2));
walls.Add(new Vector2(7, 2));
walls.Add(new Vector2(8, 2));

List<Character> heroClones = new List<Character>();
heroClones.Add(hero);
//heroClones.Add(new Npc(startingPosition));

foreach (Character clone in heroClones)
{
    clone.Display();
}

foreach (Vector2 wall in walls)
{
    Console.SetCursorPosition(wall.x, wall.y);
    Console.Write("#");
}

while (true)
{
    for (int i = 0; i < heroClones.Count; i++)
    {
        Character character = heroClones[i];
        character.Display();
        
        character.ChooseAction(walls);
        
        character.Display();
    }
}