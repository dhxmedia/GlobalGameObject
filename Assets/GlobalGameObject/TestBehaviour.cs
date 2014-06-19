/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using UnityEngine;
using System.Collections;
namespace GlobalGameObject
{
	public class TestBehaviour : MonoBehaviour {

		// Use this for initialization
		void Start () {
			GGO<TestGlobal>.Instance.TestFunction();
		}

		[ContextMenu("TestFunction")]
		public void TestFunction()
		{
			GGO<TestGlobal>.Instance.TestFunction();
		}
	}
}