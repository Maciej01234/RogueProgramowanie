namespace ClassesIntro;

public abstract class Character
{
    private string avatar = "@";
    private Vector2 position;

    public Character(Vector2 startingPosition)
    {
        position = startingPosition;
    }

    public void Display()
    {
        Console.SetCursorPosition(position.x, position.y);
        Console.Write(avatar);
    }

    public void ClearAtPosition()
    {
        Console.SetCursorPosition(position.x, position.y);
        Console.Write(" ");
    }

    public void Move(Vector2 diff)
    {
        Move(diff.x, diff.y);
    }

    public void Move(int diffX, int diffY)
    {
        Vector2 targetPosition = new Vector2(position.x + diffX, position.y + diffY);
        
        if (targetPosition.x >= 0 && targetPosition.x < Console.BufferWidth)
        {
            position.x = targetPosition.x;
        }

        if (targetPosition.y >= 0 && targetPosition.y < Console.BufferHeight)
        {
            position.y = targetPosition.y;
        }
    }

    public abstract void ChooseAction();
}