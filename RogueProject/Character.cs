namespace ClassesIntro;



public abstract class Character
{
    protected string avatar = "@";
    protected Vector2 position;
    
    protected int health = 100;
    
    public Vector2 Position
    {
        get { return position; }
    }
    
    public int GetHealth()
    {
        return health;
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            health = 0;
            ClearAtPosition();
            Console.SetCursorPosition(5, 0);
            Console.WriteLine("A character has died!");
        }
    }

    public bool IsDead()
    {
        return health <= 0;
    }
    
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
                TakeDamage(10);
                return; //blocked by wall
            }
        }
        if (IsDead())
            return;
        
        position =  targetPosition;
    }

    public abstract void ChooseAction(List<Vector2> walls);
}