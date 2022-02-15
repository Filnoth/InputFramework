using System;
using UnityEngine;
using Cinemachine;
using System.Collections;

namespace Game.Scripts.LiveObjects
{
    public class Forklift : MonoBehaviour
    {
        [SerializeField]
        private GameObject _lift, _steeringWheel, _leftWheel, _rightWheel, _rearWheels;
        [SerializeField]
        private Vector3 _liftLowerLimit, _liftUpperLimit;
        [SerializeField]
        private float _speed = 5f, _liftSpeed = 1f;
        [SerializeField]
        private CinemachineVirtualCamera _forkliftCam;
        [SerializeField]
        private GameObject _driverModel;
        private bool _inDriveMode = false;
        [SerializeField]
        private InteractableZone _interactableZone;
        private PlayerInputActions _input;
        private int _liftState = 0;

        public static event Action onDriveModeEntered;
        public static event Action onDriveModeExited;

        private void OnEnable()
        {
            InteractableZone.onZoneInteractionComplete += EnterDriveMode;
            _input = new PlayerInputActions();
            _input.ForkLift.Enable();
            _input.ForkLift.Lift.started += Lift_started;
            _input.ForkLift.Lift.canceled += Lift_canceled;
            _input.ForkLift.Lower.started += Lower_started;
            _input.ForkLift.Lower.canceled += Lower_canceled;
        }

        private void Lower_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _liftState = 2;
            StartCoroutine(ForkliftRoutine());
        }

        private void Lift_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _liftState = 1;
            StartCoroutine(ForkliftRoutine());
        }

        private void Lower_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _liftState = 0;
        }

        private void Lift_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _liftState = 0;
        }


        private void EnterDriveMode(InteractableZone zone)
        {
            if (_inDriveMode !=true && zone.GetZoneID() == 5) //Enter ForkLift
            {
                _inDriveMode = true;
                _forkliftCam.Priority = 11;
                onDriveModeEntered?.Invoke();
                _driverModel.SetActive(true);
                _interactableZone.CompleteTask(5);
            }
        }

        private void ExitDriveMode()
        {
            _inDriveMode = false;
            _forkliftCam.Priority = 9;            
            _driverModel.SetActive(false);
            onDriveModeExited?.Invoke();
            _input.ForkLift.Disable();
            
        }

        private void Update()
        {
            if (_inDriveMode == true)
            {
                //LiftControls();
                CalcutateMovement();
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    ExitDriveMode();
                    Debug.Log("exit forklift");
                }
            }

           
        }

        private void CalcutateMovement()
        {
            var move = _input.ForkLift.Movement.ReadValue<Vector2>();

            var forkliftMove = new Vector3(0, 0, move.y);

            transform.Translate(forkliftMove * Time.deltaTime * _speed);
            transform.Rotate(0, move.x, 0);

            /*float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");
            var direction = new Vector3(0, 0, v);
            var velocity = direction * _speed;

            transform.Translate(velocity * Time.deltaTime);

            if (Mathf.Abs(v) > 0)
            {
                var tempRot = transform.rotation.eulerAngles;
                tempRot.y += h * _speed / 2;
                transform.rotation = Quaternion.Euler(tempRot);
            }*/
        }

        /*private void LiftControls()
        {
            if (Input.GetKey(KeyCode.R))
                LiftUpRoutine();
            else if (Input.GetKey(KeyCode.T))
                LiftDownRoutine();
        }

        private void LiftUpRoutine()
        {
            if (_lift.transform.localPosition.y < _liftUpperLimit.y)
            {
                Vector3 tempPos = _lift.transform.localPosition;
                tempPos.y += Time.deltaTime * _liftSpeed;
                _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
            }
            else if (_lift.transform.localPosition.y >= _liftUpperLimit.y)
                _lift.transform.localPosition = _liftUpperLimit;
        }

        private void LiftDownRoutine()
        {
            if (_lift.transform.localPosition.y > _liftLowerLimit.y)
            {
                Vector3 tempPos = _lift.transform.localPosition;
                tempPos.y -= Time.deltaTime * _liftSpeed;
                _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
            }
            else if (_lift.transform.localPosition.y <= _liftUpperLimit.y)
                _lift.transform.localPosition = _liftLowerLimit;
        }*/

        private void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= EnterDriveMode;
        }

        IEnumerator ForkliftRoutine()
        {
            

            while (_liftState == 1)
            {
                if (_lift.transform.localPosition.y < _liftUpperLimit.y)
                {
                    Vector3 tempPos = _lift.transform.localPosition;
                    tempPos.y += Time.deltaTime * _liftSpeed;
                    _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
                }
                else if (_lift.transform.localPosition.y >= _liftUpperLimit.y)
                    _lift.transform.localPosition = _liftUpperLimit;
                yield return null;
            }

            while (_liftState == 2)
            {
                if (_lift.transform.localPosition.y > _liftLowerLimit.y)
                {
                    Vector3 tempPos = _lift.transform.localPosition;
                    tempPos.y -= Time.deltaTime * _liftSpeed;
                    _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
                }
                else if (_lift.transform.localPosition.y <= _liftUpperLimit.y)
                    _lift.transform.localPosition = _liftLowerLimit;
                yield return null;
            }

            while (_liftState == 0)
            {
                if (_lift.transform.localPosition.y > _liftLowerLimit.y)
                {
                    Vector3 tempPos = _lift.transform.localPosition;
                    _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
                }
                else if (_lift.transform.localPosition.y <= _liftUpperLimit.y)
                    _lift.transform.localPosition = _liftLowerLimit;

                yield return null;
            }
        }
        
    }
}