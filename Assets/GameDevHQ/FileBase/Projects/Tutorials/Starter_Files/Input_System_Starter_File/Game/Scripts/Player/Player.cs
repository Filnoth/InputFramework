using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.LiveObjects;
using Cinemachine;
using UnityEngine.InputSystem;

namespace Game.Scripts.Player
{
    [RequireComponent(typeof(CharacterController))]
    public class Player : MonoBehaviour
    {
        private CharacterController _controller;
        private Animator _anim;
        [SerializeField]
        private float _speed = 5.0f;
        private bool _playerGrounded;
        [SerializeField]
        private Detonator _detonator;
        [SerializeField]
        private bool _canMove = true;
        [SerializeField]
        private CinemachineVirtualCamera _followCam;
        [SerializeField]
        private GameObject _model;

        private PlayerInputActions _input;
        //private InteractableZone _zone;

        private void OnEnable()
        {
            InteractableZone.onZoneInteractionComplete += InteractableZone_onZoneInteractionComplete;
            Laptop.onHackComplete += ReleasePlayerControl;
            Laptop.onHackEnded += ReturnPlayerControl;
            Forklift.onDriveModeEntered += ReleasePlayerControl;
            Forklift.onDriveModeExited += ReturnPlayerControl;
            Forklift.onDriveModeEntered += HidePlayer;
            Drone.OnEnterFlightMode += ReleasePlayerControl;
            Drone.onExitFlightmode += ReturnPlayerControl;
        } 

        private void Start()
        {
            _controller = GetComponent<CharacterController>();

            if (_controller == null)
                Debug.LogError("No Character Controller Present");

            _anim = GetComponentInChildren<Animator>();

            if (_anim == null)
                Debug.Log("Failed to connect the Animator");

            _input = new PlayerInputActions();
            _input.Player.Enable();
            _input.Player.Interact.performed += Interact_performed;

        }

        private void Interact_performed(InputAction.CallbackContext context)
        {
            InteractableZone.onZoneInteractionComplete += InteractableZone_onZoneInteractionComplete;
        }

        private void Update()
        {
            if (_canMove == true)
                CalcutateMovement();
        }

        private void CalcutateMovement()
        {
            _playerGrounded = _controller.isGrounded;
            var move = _input.Player.Movement.ReadValue<Vector2>();
            var velocity = move * _speed;

            if (_playerGrounded)
                velocity.x = 0f;
            if (!_playerGrounded)
            {
                velocity.x += -20f * Time.deltaTime;
            }

            _anim.SetFloat("Speed", move.magnitude);

            var playerMove = new Vector3(0, 0, move.y);

            transform.Translate(playerMove * Time.deltaTime * _speed);
            transform.Rotate(0, move.x, 0);

            _playerGrounded = _controller.isGrounded;

            /*float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");
                     

            var direction = transform.forward * v;
            var velocity = direction * _speed;


            _anim.SetFloat("Speed", Mathf.Abs(velocity.magnitude));


            if (_playerGrounded)
                velocity.y = 0f;
            if (!_playerGrounded)
            {
                velocity.y += -20f * Time.deltaTime;
            }
            
            _controller.Move(velocity * Time.deltaTime);*/



        }

        private void InteractableZone_onZoneInteractionComplete(InteractableZone zone)
        {
            switch(zone.GetZoneID())
            {
                case 1: //place c4
                    _detonator.Show();
                    break;
                case 2: //Trigger Explosion
                    TriggerExplosive();
                    break;
            }
        }

        private void ReleasePlayerControl()
        {
            _canMove = false;
            _followCam.Priority = 9;
        }

        private void ReturnPlayerControl()
        {
            _model.SetActive(true);
            _canMove = true;
            _followCam.Priority = 10;
        }

        private void HidePlayer()
        {
            _model.SetActive(false);
        }
               
        private void TriggerExplosive()
        {
            _detonator.TriggerExplosion();
        }

        private void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= InteractableZone_onZoneInteractionComplete;
            Laptop.onHackComplete -= ReleasePlayerControl;
            Laptop.onHackEnded -= ReturnPlayerControl;
            Forklift.onDriveModeEntered -= ReleasePlayerControl;
            Forklift.onDriveModeExited -= ReturnPlayerControl;
            Forklift.onDriveModeEntered -= HidePlayer;
            Drone.OnEnterFlightMode -= ReleasePlayerControl;
            Drone.onExitFlightmode -= ReturnPlayerControl;
        }

    }
}

