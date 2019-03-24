using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxtController : MonoBehaviour
{
    public GameObject _parent = null;

    void Update()
    {
		if (_parent && _parent.transform.localScale.x < 0 && this.transform.localScale.x >= 0)
		{
			Flip();
		}
		else if (_parent && _parent.transform.localScale.x > 0 && this.transform.localScale.x <= 0)
		{
			Flip();
		}
    }
    // Update is called once per frame
    private void Flip()
    {
        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
