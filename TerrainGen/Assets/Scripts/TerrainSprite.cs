using UnityEngine;
using UnityEditor;
using System.Collections;

public class TerrainSprite : MonoBehaviour {

	public int x;
  public int y;
  public string path;
  //private bool drawn = false;
  //private int size = 100;
  
  public TerrainSprite(int newX, int newY, string newPath)
  {
    x = newX;
    y = newY;
    path = newPath;
    //drawn = false;
  }
  
  public void DrawSprite()
  {
    
    // draw sprite
    /*SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
    Sprite sprite = new Sprite();
    Texture2D texture = Resources.Load(path, typeof(Texture2D))
    sprite = Sprite.Create(texture, new Rect(0, 0, size, size), new Vector2(x, y), 100.0f);
    renderer.sprite = sprite;
    drawn = true;*/
  }
}
