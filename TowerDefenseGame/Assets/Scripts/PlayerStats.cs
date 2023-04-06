using UnityEngine;
using System.Collections;
using System.Collections.Generic;


// this is our observeable (subject); this is we're we display how many lives we have
public class PlayerStats : MonoBehaviour, IObservableLives
{

    public static int Money;
    public int startMoney = 400;

    // public static int Lives;
    public int startLives = 20;

    public static int Rounds;

    public List<IObserverLives> observers = new List<IObserverLives>();
    public int Lives { get; set; }

    void Start()
    {
        Money = startMoney;
        Lives = startLives;
        Rounds = 0;
    }

    public void Notify(int aLives)
    {
        foreach (var live in observers)
        {
            live.UpdateLives(Lives);
        }
    }
    public void Subscribe(IObserverLives anLiveObserver)
    {
        observers.Add(anLiveObserver);

    }
    public void UnSubscribe(IObserverLives anLiveObserver)
    {
        observers.Remove(anLiveObserver);
    }


    public string Display()
    {
        return Lives.ToString() + " LIVES";
    }
}
