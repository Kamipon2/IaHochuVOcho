using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.IO;
using System;

public class StrimerWriter : MonoBehaviour
{
    // Start is called before the first frame update
    public string path;
    public string text;
    public void Start()
    {
        Stats();
    }
    public async Task Stats()
    {
        using (StreamWriter writer = new StreamWriter(path, false))
        {
           await writer.WriteLineAsync(text);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
