using UnityEngine;

public class EventAggregator : MonoBehaviour
{
    public static UnitEvents UnitDied = new UnitEvents();
    public static ScoreEvents ScoreIncrement = new ScoreEvents();
}
