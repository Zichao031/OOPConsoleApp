namespace OOPConsoleApp.ColorAndBall;

public class Ball
{
    private int _size;
    private Color _color;
    private int _throwCount;

    public Ball(int size, Color color)
    {
        this._size = size;
        this._color = color;
        this._throwCount = 0;
    }

    public void Pop()
    {
        this._size = 0;
    }

    public void Throw()
    {
        if (this._size == 0)
        {
            Console.WriteLine("This ball has been popped");
        }
        else
        {
            this._throwCount++;
        }
    }

    public int ThrowTimes()
    {
        if (this._size == 0)
        {
            return 0;
        }
        return this._throwCount;
    }
}