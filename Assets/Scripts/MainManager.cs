using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    private List<Vehicle> _vehicles;
    
    // Start is called before the first frame update
    void Start()
    {
        _vehicles = new List<Vehicle>();
        
        _vehicles.Add(new Car());
        _vehicles.Add(new Car());
        _vehicles.Add(new Car());
        _vehicles.Add(new Airplane());
        _vehicles.Add(new Airplane());
        _vehicles.Add(new Airplane());
        _vehicles.Add(new Airplane());
    }

    // Update is called once per frame
    void Update()
    {
        // POLYMORPHISM
        foreach (var v in _vehicles)
        {
            v.Move();  // they know what to do
            
            if (v is IFlyer)
            {
                // do something for only the flyers.
            }
        }        
    }
}
