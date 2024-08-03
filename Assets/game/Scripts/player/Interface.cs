using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITakeDamage
{
    void TakeDamage(float damageToTake);
}

public interface ICollectItem
{
    void CollectItem();
}