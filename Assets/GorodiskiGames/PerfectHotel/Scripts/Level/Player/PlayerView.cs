using System;
using Game.Level.Unit;
using UnityEngine;

namespace Game.Level.Player
{
    public sealed class PlayerView : UnitStaffView
    {
        [SerializeField] private Transform _aimTransform;
        [SerializeField] private SkinnedMeshRenderer _body;
        [SerializeField] private string _currentState;

        public static Action<bool> OnPlayerWalkState;

        public Vector3 AimPosition => _aimTransform.position;

        public Type CurrentState
        {
            set => _currentState = value?.Name;
            
        }

        protected override void OnModelChanged(PlayerModel model)
        {
            _body.sharedMesh = model.BodyMesh;
        }

        public void InvokingPlayerWalkingEvent(bool iswalking)
        {
            OnPlayerWalkState?.Invoke(iswalking);
        }
    }
}

 