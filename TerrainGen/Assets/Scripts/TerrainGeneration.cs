using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class TerrainGeneration : MonoBehaviour {
  
  public Sprite sprite1;
  public int worldSize = 128;
  public float spriteSize = 0.4f;
  
	// generate terrain
	void Start () {
    // loop to create sprites at world coordinates
    int startPos = 0 - worldSize/2;
    int endPos = worldSize/2 - 1;
    for (int i = startPos; i < endPos; i++) {
      for (int j = startPos; j < endPos; j++) {
        CreateSprite(i, j);
      }
    }
	}
  
  // used to create a new sprite game object at the specified coordinates
  void CreateSprite (int x, int y) {
    // create and instantiate new Game Object to hold sprite
    string name = "Terrain(" + x.ToString() + "," + y.ToString() + ")";
    GameObject go = new GameObject(name);
    
    // create sprite renderer on game object, and set to render our sprite
    SpriteRenderer renderer = go.AddComponent<SpriteRenderer>();
    renderer.sprite = sprite1;
    
    // move sprite to correct x,y location
    float xpos = x * spriteSize;
    float ypos = y * spriteSize;
    go.transform.position = new Vector3(xpos, ypos, 0);
  }
}
