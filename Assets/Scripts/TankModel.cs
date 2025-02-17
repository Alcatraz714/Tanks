using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public float translationSpeed;
    public float rotationSpeed;

    public TankModel(float _translation, float _rotation)
    {
        translationSpeed = _translation;
        rotationSpeed = _rotation;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
