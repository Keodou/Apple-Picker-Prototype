using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject applePrefab;
    public float speed = 10f;
    public float leftAndRightEdge = 20f;
    public float chanceToChangeDirections = 0.02f;
    public float secondsBetweenAppleDrops = 1f;

    private void Start()
    {
        Invoke("DropApple", 2f);
    }

    private void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    private void Update()
    {
        //Перемещение яблони
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //Изменение направления
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }

        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }

    private void FixedUpdate()
    {
        //Случайная смена направления
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
