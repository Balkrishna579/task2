using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RosSharp.RosBridgeClient
 {
   public class sub : UnitySubscriber<MessageTypes.Move.Num>

    {
    public GameObject SubscribedTransform;
    public Rigidbody rb;

        
        private long k;
        private long s;
        private bool isMessageReceived;
    // Start is called before the first frame update
      void Start()
        {
             rb=GetComponent<Rigidbody>();
            base.Start();
            Debug.Log(s+"this is");
            
        }

     protected override void ReceiveMessage(MessageTypes.Move.Num message)
        {
            k=message.num2;
            s=message.num;
            Debug.Log(s);
            isMessageReceived = true;
}

    // Update is called once per frame
    void Update()
    {
           Debug.Log(s+"this is");
        if (isMessageReceived){
                ProcessMessage();}
           
    }public void ProcessMessage()
        {
         
          if(s==8){
           Debug.Log(s);
           rb.AddForce(transform.forward*k);}

           else if(s==2){
          rb.AddForce(0,0,1*k,ForceMode.Impulse);
     }else if(s==4){
          rb.AddForce(k,0,0,ForceMode.Impulse);
     }else if(s==6){
          rb.AddForce(-1*k,0,0,ForceMode.Impulse);
     }else if(s==5){
          rb.AddForce(0,k,0,ForceMode.Impulse);
     } isMessageReceived = false;}}







}
