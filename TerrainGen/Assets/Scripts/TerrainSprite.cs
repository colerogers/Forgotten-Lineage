using UnityEngine;
using UnityEditor;
using System.Collections;

public class TerrainSprite : MonoBehaviour {

	public int x;
  public int y;
  public Sprite sprite;
  public int spriteSize;
  
  public TerrainSprite(int newX, int newY, Sprite newSprite, int newSpriteSize)
  {
    x = newX;
    y = newY;
    sprite = newSprite;
    spriteSize = newSpriteSize;
  }
  
  public void DrawSprite()
  {
    string name = "Terrain(" + x.ToString() + "," + y.ToString() + ")";
    GameObject go = new GameObject(name);
    Instantiate(go, transform.position, Quaternion.identity);
    SpriteRenderer renderer = go.AddComponent<SpriteRenderer>();
    renderer.sprite = sprite;
    Transform t = go.GetComponent<Transform>();
    float xpos = x * spriteSize;
    float ypos = y * spriteSize;
    t.position = new Vector3(xpos, ypos, 0);
  }
}