using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable
{
    public float Speed { get; }

    public void Move(float horizontalSpeed);
}
