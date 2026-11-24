using UnityEngine;

public class andar : MonoBehaviour
{
    public float velocidade = 5f;

    void Update()
    {
        float direcao = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direcao = -1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direcao = 1f;
        }

        transform.Translate(Vector3.right * direcao * velocidade * Time.deltaTime);
    }
}
