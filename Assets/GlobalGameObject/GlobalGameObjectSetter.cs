/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using UnityEngine;
using System.Collections;
namespace GlobalGameObject
{
	public class GlobalGameObjectSetter : MonoBehaviour {

		public MonoBehaviour GlobalComponent;
		// Use this for initialization
		void Awake () {

			var d1 = typeof(GGO<>);
			System.Type[] typeArgs = { GlobalComponent.GetType() };
			var makeme = d1.MakeGenericType(typeArgs);
			System.Reflection.PropertyInfo pi = makeme.GetProperty("Instance");
			pi.SetValue(null, GlobalComponent, null);
		}

	}
}