using UnityEngine;

public class Tent : Equipment
{
    public override void Operate()
    {
        transform.Rotate(0, 15, 0);
    }
}
