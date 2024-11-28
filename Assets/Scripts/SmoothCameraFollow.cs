using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    public Transform target;        // Персонаж, за которым будет следить камера
    public float smoothSpeed = 0.125f;  // Скорость сглаживания
    public Vector3 offset;          // Смещение камеры относительно персонажа

    void LateUpdate()
    {
        // Желаемая позиция камеры с учетом смещения
        Vector3 desiredPosition = target.position + offset;
        // Плавное перемещение камеры между текущей и желаемой позицией
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        // Установка новой позиции камеры
        transform.position = smoothedPosition;
    }
}
