using UnityEngine;

namespace Betty
{
    public class key : MonoBehaviour, IInteraction
    {
        private Rigidbody rig;
        private Collider col;
        private bool isPickUp;

        private void Awake()
        {
            rig = GetComponent<Rigidbody>();
            col = GetComponent<Collider>();
        }
        public void Interaction()
        {
            print($"<color=#3f3>互動: {name}</color>");
        }

        public void PickUp()
        {
            print($"<color=#37f>撿取: {name}</color>");
            // 設為已經撿取，剛體設定為運動學(不會動)，關閉碰撞，設定座標
            isPickUp = true;
            rig.isKinematic = true;
            col.enabled = false;
            transform.position = new Vector3(0, 0, 200);
        }
    }
}
