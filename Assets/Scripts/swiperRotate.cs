using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swiperRotate : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateSwiper();
    }

    void rotateSwiper() {
        // rotate the swiper
        // transform.Rotate(0, speed, 0 * Time.deltaTime); removed
        //changed to speed * delta since 0 * any = 0
        transform.Rotate(0, speed * Time.deltaTime, 0 );
    }
}
