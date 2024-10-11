using UnityEngine;

public class CreatePrefabHereMono : MonoBehaviour
{
    public Transform m_whereToPlaySound;
    public GameObject m_prefab;
    public float timeToBeKilled = 10f;
    

    [ContextMenu("Create the prefab")]
    public void CreateThePrefab()
    {
        GameObject createdGameObject = GameObject.Instantiate(m_prefab);
        createdGameObject.name = "Created:" + m_prefab.name;
        createdGameObject.transform.position = m_whereToPlaySound.position;
        Destroy(createdGameObject, timeToBeKilled);
    }

}

