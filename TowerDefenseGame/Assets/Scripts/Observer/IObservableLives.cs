
//Created on 20/25/2023
//this is the lives Observable interface
// Modified by Qusai and Tamer
public interface IObservableLives
{
    void Notify(int aLives);
    void Subscribe(IObserverLives anLiveObserver);
    void UnSubscribe(IObserverLives anLiveObserver);
}