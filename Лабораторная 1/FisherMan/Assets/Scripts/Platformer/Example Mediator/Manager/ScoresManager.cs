using UnityEngine;

public class ScoresManager : MonoBehaviour
{
    public int Scores;

    public void Awake()
    {
        EventAggregator.UnitDied.Subscribe(OnUnitDied);
    }

    private void OnUnitDied(Unit unit)
    {
        Debug.Log("Понял - принял, не понял бы не принял");
        Scores += 1;
        Debug.Log("Вот короче + 1 вам :" + Scores);
        EventAggregator.ScoreIncrement.Publish(this);
    }
}