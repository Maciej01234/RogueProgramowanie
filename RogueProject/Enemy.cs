namespace ClassesIntro;

public class Npc : Character
{
    private List<Vector2> path;
    private int currentTarget = 0;

    public Npc(Vector2 startingPosition) : base(startingPosition)
    {
        avatar = "E";

        path = new List<Vector2>()
        {
            new Vector2(10, 5),
            new Vector2(15, 5),
            new Vector2(15, 10),
            new Vector2(10, 10)
        };
    }

    public override void ChooseAction(List<Vector2> walls)
    {
        Vector2 target = path[currentTarget];

        int moveX = 0;
        int moveY = 0;

        if (Position.x < target.x)
            moveX = 1;
        else if (Position.x > target.x)
            moveX = -1;
        else if (Position.y < target.y)
            moveY = 1;
        else if (Position.y > target.y)
            moveY = -1;

        ClearAtPosition();
        Move(moveX, moveY, walls);

        if (Position.x == target.x &&
            Position.y == target.y)
        {
            currentTarget++;

            if (currentTarget >= path.Count)
                currentTarget = 0;
        }
    }
}