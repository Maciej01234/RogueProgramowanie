namespace ClassesIntro;

public class Player : Character
{
    public Player(Vector2 startingPosition) : base(startingPosition)
    {
    }

    public override void ChooseAction()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        ClearAtPosition();
    
        if (keyInfo.Key == ConsoleKey.A)
        {
            // ruch w lewo
            Move(-1, 0);
        }
        else if (keyInfo.Key == ConsoleKey.D)
        {
            // ruch w prawo
            Move(1, 0);
        }
        else if (keyInfo.Key == ConsoleKey.W)
        {
            // ruch w górę
            Move(0, -1);
        }
        else if (keyInfo.Key == ConsoleKey.S)
        {
            // ruch w dół
            Move(0, 1);
        }
    }
}