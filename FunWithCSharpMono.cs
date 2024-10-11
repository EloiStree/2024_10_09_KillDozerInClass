using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunWithCSharpMono : MonoBehaviour
{
    public int m_life = 100;
    public Goblin m_goblin;
    public List<Goblin> m_goblins;
    
}

[System.Serializable]
public class Goblin {

    public string m_name;

    [TextArea(2,10)]
    public string m_helloWorldText;
    public int m_life;
    public float m_size;

    public HatDimension m_hat;

}

[System.Serializable]
public class HatDimension {

    public float m_height;
    [Range(0,1)]
    public float m_radius;
}


