using UnityEngine;

public class Locator : MonoBehaviour
{
    public static Locator Instance { get; private set; }

    public W4Pigeon Player { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        var go = GameObject.FindGameObjectWithTag("Player");
        if (go != null)
            Player = go.GetComponent<W4Pigeon>();
    }
}
