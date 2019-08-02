using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class AutosaveOnRun
{
	static AutosaveOnRun()
	{
		EditorApplication.playmodeStateChanged = () =>
		{
			if(EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying)
			{
				Debug.Log("Auto-Saving scene before entering Play mode: " + EditorApplication.currentScene);
                  
				EditorApplication.SaveScene();
				AssetDatabase.SaveAssets();
			}
		};
	}
}

