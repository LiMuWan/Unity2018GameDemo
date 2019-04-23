using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyTest : MonoBehaviour
{
    Rigidbody rigidbody;
    /*
     * ForceMode的类型有：
     * Force 给刚体一个持续的力，会考虑刚体的质量
     * Accleration 给刚体添加一个持续的加速度，忽略刚体的质量
     * Impulse 给刚体添加一个瞬间的力，会考虑刚体的质量
     * VelocityChange 在刚体原来的速度基础上，添加一个速度变化，忽略刚体的质量
     */
    public ForceMode forceMode;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    rigidbody.AddForce(0, 9.81f * Time.fixedDeltaTime, 0);
    //}

    private void FixedUpdate()
    {
        //rigidbody.AddForce(0, 9.81f, 0);
        rigidbody.AddForce(new Vector3(0, 9.81f, 0), forceMode);
    }
}
