using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : WeakAnimal
{
    protected override void ReSet()
    {
        base.ReSet();
        RandomAction();

    }
    private void RandomAction()
    {
        RandomSound();

        isAction = true;


        int _random = Random.Range(0, 4); // 대기 , 풀 뜯기, 둘러보기, 걷기

        if (_random == 0)
        {
            Wait();
        }
        else if (_random == 1)
        {
            Eat();
        }
        else if (_random == 2)
        {
            Peek();
        }
        else if (_random == 3)
        {
            TryWalk();
        }
    }

    private void Wait()
    {
        currentTime = waitTime;
        Debug.Log("대기");

    }
    private void Eat()
    {
        currentTime = waitTime;
        anim.SetTrigger("Eat");
        Debug.Log("풀 뜯기");

    }
    private void Peek()
    {
        currentTime = waitTime;
        anim.SetTrigger("Peek");

        Debug.Log("둘러보기");

    }


}
