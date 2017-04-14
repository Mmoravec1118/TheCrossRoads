#pragma strict
var hit : RaycastHit;

function Update () {
	if(Physics.Raycast(transform.position, transform.forward, hit, 5)) {
		if(Input.GetMouseButtonDown(0)) {
			if(hit.transform.tag == "Interact") {
				hit.transform.SendMessage("Action", 0.0f);
			}
		}
	}
}