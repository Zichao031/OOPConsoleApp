namespace OOPConsoleApp.ColorAndBall;

public class Color
{
    private int _red;
    private int _green;
    private int _blue;
    private int _alpha;

    public Color(int red, int green, int blue, int alpha=255)
    {
        if (!CheckValue(red) || !CheckValue(green) || !CheckValue(blue) || !CheckValue(alpha))
        {
            throw new ArgumentException("value out of bound (0-255)");
        }
        
        this._red = red;
        this._green = green;
        this._blue = blue;
        this._alpha = alpha;
        
        
    }

    public int GetRed()
    {
        return this._red;
    }
    public int GetGreen()
    {
        return this._green;
    }

    public int GetBlue()
    {
        return this._blue;
    }

    public int GetAlpha()
    {
        return this._alpha;
    }

    public void SetRed(int red)
    {
        CheckValue(red);
        this._red = red;
    }
    public void SetGreen(int green)
    {
        CheckValue(green);
        this._green = green;
    }
    public void SetBlue(int blue)
    {
        CheckValue(blue);
        this._blue = blue;
    }
    public void SetAlpha(int alpha)
    {
        this._alpha = alpha;
    }

    private bool CheckValue(int val)
    {
        if (val >= 0 && val <= 255)
        {
            return true;
        }

        throw new ArgumentException("value out of bound (0-255)");
    }

}