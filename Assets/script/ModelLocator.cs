using UnityEngine;
using System.Collections;

public class ModelLocator{



	public string gameState = "ready";
	private static ModelLocator instance;
	public static ModelLocator getInstace{
		get{ 
			if (instance==null){
				instance = new ModelLocator ();
			}
			return instance;
		}
	}

}
