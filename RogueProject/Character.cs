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

    public void Move(Vector2 diff, List<Vector2> walls)
    {
        Move(diff.x, diff.y, walls);
    }
    public void Move(int diffX, int diffY, List<Vector2> walls)
    {
        Vector2 targetPosition = new Vector2(position.x + diffX, position.y + diffY);

        if (targetPosition.x < 0 || targetPosition.x >= Console.BufferWidth ||
            targetPosition.y < 0 || targetPosition.y >= Console.BufferHeight)
        {
            return;
        }

        foreach (Vector2 wall in walls)
        {
            if (wall.x == targetPosition.x && wall.y == targetPosition.y)
            {
                return; //blocked by wall
            }
        }
        position =  targetPosition;
    }

    public abstract void ChooseAction(List<Vector2> walls);
}