using System;
using UnityEngine;

public class PlayerAimWeapon : MonoBehaviour
{
    //I would like to shoutout my goat UnityCodeMonkey, I did not do the aiming code myself I would have ripped my hair out
    [SerializeField] public Transform aimTransform;

    public event EventHandler<ShootEventArgs> OnShoot;

    public Rigidbody2D launchBody;
    [SerializeField] float launchForce;

    [SerializeField] public int shotCount = 0;

    public GameObject bullet;

    public Rigidbody2D bulletrb;

    public float gunForce;

    public Transform gunTip;


    [Serializable]
    public class ShootEventArgs : EventArgs
    {
        public Vector3 gunEndPointPosition;
        public Vector3 shootPosition;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //ADDED
        Vector3 mousePosition = GetMouseWorldPosition();

        Vector3 aimDirection = (mousePosition - aimTransform.position).normalized;

        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

        aimTransform.eulerAngles = new Vector3(0, 0, angle);

        if (Input.GetMouseButtonDown(0) && shotCount <= 5) // Left Mouse Click
        {
            Debug.Log("Bang");
            // Trigger Shoot Event
            OnShoot?.Invoke(this, new ShootEventArgs
            {
                gunEndPointPosition = aimTransform.position,
                shootPosition = mousePosition  
            });
                    
            Vector3 mousePos = Camera.main.WorldToScreenPoint(transform.position);

            Vector3 directionToMouse = Input.mousePosition - mousePos;

            directionToMouse.Normalize();
            //flings player in opposite position of mouse
            launchBody.AddForce(-directionToMouse * launchForce, ForceMode2D.Impulse);
            shotCount++;
            //spawns bullet at guntip position
            Instantiate(bullet, gunTip.position, Quaternion.identity);
        }
    }

    public Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = 10f;
        return Camera.main.ScreenToWorldPoint(mouseScreenPosition);
    }
}
