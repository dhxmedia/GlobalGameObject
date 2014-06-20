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