using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerOwnerBehavior : EntityBehavior<Player>, IOwnerEntityBehavior {

	[SerializeField]
	private Camera Camera;

	[SerializeField]
	private CharacterController Controller;

	private float Pitch { get; set; }

	private void Start() {
		Camera.gameObject.SetActive(true);
		Controller.enabled = true;

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	private void Update() {

		Entity.MovementInput.Value = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		Entity.Position.Value = transform.position;
		Entity.Yaw.Value += Input.GetAxis("Mouse X") * 5.0f;

		Pitch -= Input.GetAxis("Mouse Y") * 5.0f;
		Pitch = Mathf.Clamp(Pitch, -89.9f, 89.9f);
		Camera.transform.localRotation = Quaternion.Euler(Pitch, 0, 0);

		Vector3 movementInput = new Vector3(Entity.MovementInput.Value.x, 0, Entity.MovementInput.Value.y) * 5.0f;
		Controller.SimpleMove(transform.rotation * movementInput);
	}

}