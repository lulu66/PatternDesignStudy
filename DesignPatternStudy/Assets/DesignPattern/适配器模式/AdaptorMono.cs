using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdaptorMono : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Turkey turkey = new RedTurkey();
        TurkeyAdaptor adaptor = new TurkeyAdaptor(turkey);
        TestDuck2(adaptor);
    }

    void TestDuck2(Duck2 duck)
	{
        duck.Quak();
        duck.Fly();
	}

}
