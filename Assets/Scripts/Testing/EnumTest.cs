using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTest : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		Item item = new Item();
		item.name = "testItem";
		item.description = "A dummy item.";
		item.type = "Generic";
		item.tags = new string[] { "Junk" };
		Debug.Log("Serialize: " + JsonUtility.ToJson(item));
		string testJson = "{\"name\":\"testItem\",\"description\":\"A dummy item.\",\"type\": \"Test\",\"tags\":[\"TestTag\"]}";
		item = JsonUtility.FromJson<Item>(testJson);
		Debug.Log("item.type: " + item.type.ToString());
	}

	// Update is called once per frame
	void Update()
	{

	}
}
