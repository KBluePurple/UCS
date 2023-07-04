using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGolemAttackCCondition : CooldownTimer, ICondition {
    protected BossStoneGolem _bossStoneGolem;

    private float _attackRange = 3f;

    public StoneGolemAttackCCondition(BossStoneGolem bossStoneGolem, float cooldownDuration) : base(cooldownDuration) {
        _bossStoneGolem = bossStoneGolem;
    }

    public bool CanAttack() {
        if (IsCooldownReady()) {
            return true;
        }

        return false;
    }
}
