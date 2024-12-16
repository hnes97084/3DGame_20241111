using UnityEngine;

namespace Betty
{
    /// <summary>
    /// 手電筒
    /// </summary>
    public class Flashlight : MonoBehaviour, IInteraction
    {
        public void Interaction()
        {
            print($"<color=#37f>互動 : {name}</color>");
        }

        public void PickUp()
        {
            print($"<color=#37f>撿取 : {name}</color>");
        }
    }
}

