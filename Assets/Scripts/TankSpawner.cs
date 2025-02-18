using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material tankColor;
    }

    public List<Tank> tankList;

    public TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(tankView.gameObject, transform.position, Quaternion.identity); // spawn at 000 and 0 angle  
        CreateTank(); 
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].tankColor);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
