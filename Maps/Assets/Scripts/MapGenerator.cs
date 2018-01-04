using UnityEngine;
using UnityEngine.UI;
public class MapGenerator : MonoBehaviour
{
	public Text gameText;

	void Start()
	{
		Debug.Log(string.Format("Location enabled? {0}", Input.location.isEnabledByUser));
	}
	
	void Update()
	{
	}
}
