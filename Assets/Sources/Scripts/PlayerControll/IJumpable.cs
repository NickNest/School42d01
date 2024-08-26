using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IJumpable
{
    public float JumpForce {  get; }
    public void Jump();
}
