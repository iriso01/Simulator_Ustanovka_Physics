using UnityEngine;

public class Scroll : MonoBehaviour
{
	[SerializeField]
	private Transform targetPos;
	[SerializeField]
	private float sensitivity = 0.1f;
	[SerializeField]
	private float scrollSpeed = 1000f;
	[SerializeField]
	private int maxDistance = 800;
	[SerializeField]
	private int minDistance = -200;
    [SerializeField]
    private float sensitivity1 = 10f;

    private void Update()
	{
		// Вращение вокруг центральной точки установки с зажатой правой кнопкой мыши
		if (Input.GetMouseButton(1))
		{
			float y = Input.GetAxis("Mouse X") * sensitivity1;
			if (y != 0)
			{
				transform.RotateAround(targetPos.position, Vector3.up, y);
			}
		}

		// Движение камеры в сторону клавишами с ограничениями по размерам помещения
		float x = Input.GetAxis("Horizontal") / sensitivity; // клавиши A, D
		float z = Input.GetAxis("Vertical") / sensitivity;   // клавиши W, S

		Vector3 moveDirection = transform.TransformDirection(new Vector3(x, 0, z));
		Vector3 newpos = transform.position + moveDirection;

		if (ControlDistance(Vector3.Distance(newpos, targetPos.position)))
		{
			transform.position = newpos;
		}

		// Приближение и удаление камеры к установке на сцене прокруткой колеса мыши
		float scroll = Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;
		if (scroll != 0)
		{
			Vector3 scrollDirection = transform.TransformDirection(Vector3.forward * scroll);
			newpos = transform.position + scrollDirection;

			if (ControlDistance(Vector3.Distance(newpos, targetPos.position)))
			{
				transform.position = newpos;
			}
		}
	}

	private bool ControlDistance(float distance)
	{
		return distance > minDistance && distance < maxDistance;
	}
}
