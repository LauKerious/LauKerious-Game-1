using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class BackgroundAdjustement : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera Camera;
    public SpriteRenderer SpriteRenderer;
    private void Start()
    {
        float worldSpaceHeight = Camera.orthographicSize * 2;
        float worldSpaceWidth = worldSpaceHeight * Camera.aspect;

        SpriteRenderer.size = new Vector2(worldSpaceWidth, worldSpaceHeight);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
