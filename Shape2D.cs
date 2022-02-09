using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Shape2D
{
    public Vector2D Scale = null;
    public Vector2D Position = null;
    public string Tag = "";

    public Shape2D(Vector2D Scale, Vector2D Position)
    {
        this.Scale = Scale;
        this.Position = Position;
    }
}
