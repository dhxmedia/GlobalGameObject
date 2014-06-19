using UnityEngine;
using System.Collections;
namespace GlobalGameObject
{
	public static class GGO<T> where T: MonoBehaviour {

		public static T Instance
		{
			get
			{
				if(_Instance == null)
				{
					_Instance = Create();
				}
				return _Instance;
			}

		}

		static T _Instance;

		static T Create()
		{
			GameObject gObj = new GameObject();
			gObj.name = typeof(T).Name;
			UnityEngine.Object.DontDestroyOnLoad(gObj);
			return gObj.AddComponent<T>();
		}
	}
}