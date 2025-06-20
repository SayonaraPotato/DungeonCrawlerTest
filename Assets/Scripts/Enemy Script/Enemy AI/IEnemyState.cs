using UnityEngine;

public interface IEnemyState
{
    public void EnterState(EnemyAI _enemy);
    public void UpdateState();
    public void ExitState();

}
