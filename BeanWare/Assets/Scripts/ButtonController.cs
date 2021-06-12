using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private BoxCollider2D bx2d;


    // Start is called before the first frame update
    void Start()
    {
        bx2d = GetComponent<BoxCollider2D>();
    }
}
