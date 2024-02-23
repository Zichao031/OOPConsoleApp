namespace OOPConsoleApp.ColorAndBall;

public class Ball
{
    private int _size;
    private Color _color;

    public Ball(int size, Color color)
    {
        this._size = _size;
        this._color = color;
    }

    public void Pop()
    {
        this._size = 0;
    }
}