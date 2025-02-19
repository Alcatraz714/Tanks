using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public float translationSpeed;
    public float rotationSpeed;
    public TankTypes tankType;
    public Material tankColor;

    public TankModel(float _translation, float _rotation, TankTypes _tankType, Material _tankColor)
    {
        translationSpeed = _translation;
        rotationSpeed = _rotation;
        tankType = _tankType;
        tankColor = _tankColor;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
