using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    private float Translation;
    private float Rotation;
    [SerializeField] private Rigidbody rb; // public if not accessible
    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(this.transform);
        cam.transform.position = new Vector3(0f, 4f, -7f);
        cam.transform.rotation = Quaternion.Euler(30f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if(Translation != 0)
        {
            tankController.Move(Translation, tankController.GetTankModel().translationSpeed);
        }
        if(Rotation != 0)
        {
            tankController.Rotate(Rotation, tankController.GetTankModel().rotationSpeed);
        }
    }

    private void Movement()
    {
        Translation = Input.GetAxis("Vertical");
        Rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
