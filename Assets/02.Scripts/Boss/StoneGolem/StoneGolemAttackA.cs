using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGolemAttackA : MonoBehaviour {
    private BossStoneGolem _bossStoneGolem;
    private Collider2D _collider;

    private List<Entity> _playerList = new List<Entity>();

    [SerializeField] private float _attackDamage;

    public void Init(BossStoneGolem bossStoneGolem) {
        _bossStoneGolem = bossStoneGolem;
        _collider = GetComponent<Collider2D>();
        _collider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // Player로 수정 필요
        Test player = other.GetComponent<Test>();
        if (player != null) {
            _playerList.Add(player);
        }
    }

    public void Attack() {
        _collider.enabled = true;
    }

    public void EndAttack() {
        _collider.enabled = false;

        foreach (Entity player in _playerList) {
            // 공격 
            player.HealthSystem.TakeDamage(_attackDamage);
            // Todo: 넉백효과 필요

        }

        _playerList.Clear();
    }
}
