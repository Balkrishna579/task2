#! /usr/bin/env python

import rospy
from move.msg import Num


def control():
    while not rospy.is_shutdown():
         pub=rospy.Publisher('formove',Num,queue_size=10)
         rospy.init_node('movement')
         print"Enter the force"
         force=int(raw_input())
         print"enter the direction"
         pubint=int(raw_input())
         msg=Num()
         msg.num2=force
         msg.num=pubint
         pub.publish(force,pubint);
    
    
    
    
if __name__ =='__main__':
    try:
        control()
    except rospy.ROSInterruptException:
        pass

