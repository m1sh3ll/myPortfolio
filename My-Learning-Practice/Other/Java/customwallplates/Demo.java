/*
 * PROGRAM: Assignment 2 - Demo.java
 * Written by Michelle Nesbitt
 * This program demonstrates the creation of a new wall plate object
 */
package com.customwallplates.wallplate;

import java.util.ArrayList;
public class Demo {
    public static void main(String[] args){
        
        WallPlate myWallplate = new WallPlate();
        myWallplate.setGangs((byte)3);
        myWallplate.setColor("Black");
        myWallplate.setPorts(6);
        myWallplate.display();
        
        WallPlate yourWallplate = new WallPlate((byte)2, 12, "Ivory");
        yourWallplate.display();
        
        /*Assignment 2 */
        
        DecoraWallPlate dwpA = new DecoraWallPlate((byte)2, 8, "White", "Decora");
        dwpA.display();
        dwpA.displayStyle();
        
       DecoraWallPlate dwpB = new DecoraWallPlate();
       dwpB.setStyle("Decora");
       dwpB.display();
       
       ArrayList<DecoraWallPlate> list = new ArrayList<DecoraWallPlate>();
       list.add(dwpA);
       list.add(dwpB);
       
       for (int index = 0; index < list.size(); index++){
           DecoraWallPlate dwpC = list.get(index);
           dwpC.display();           
       }
       
       
       
        
        
        
    }
}
