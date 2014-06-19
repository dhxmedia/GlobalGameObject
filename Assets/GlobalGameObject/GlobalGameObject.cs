/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */
 
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