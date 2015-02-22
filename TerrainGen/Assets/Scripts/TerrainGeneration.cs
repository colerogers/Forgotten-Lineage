using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class TerrainGeneration : MonoBehaviour {
  
  public Sprite sprite1;
  public int worldSize = 64;
  public float spriteSize = 2.52f;
  
	// generate terrain
	void Start () {
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
    string name = "Terrain(" + x.ToString() + "," + y.ToString() + ")";
    GameObject go = new GameObject(name);
    Instantiate(go, transform.position, Quaternion.identity);
    SpriteRenderer renderer = go.AddComponent<SpriteRenderer>();
    renderer.sprite = sprite1;
    Transform t = go.GetComponent<Transform>();
    float xpos = x * spriteSize;
    float ypos = y * spriteSize;
    t.position = new Vector3(xpos, ypos, 0);
  }
}
