/*
 * Assignment 2
 * CLASS: DecoraWallPlate.java
 * Written by Michelle Nesbitt
 * This is a class representing a Decora electrical/data/audio/video wall plate object
 */

package com.customwallplates.wallplate;

public class DecoraWallPlate extends WallPlate implements Decora  {
    
    private String style;
    
    public DecoraWallPlate(){
        super((byte)1, 1, "White");
        style = "Decora";
    }
    public DecoraWallPlate(byte gangs, int ports, String color, String sStyle){
        super(gangs, ports, color);
        style = sStyle;
    }
    
     /**
    * Sets the style for the wall plate
    * @param sStyle The style of wall plate
    */
    public void setStyle(String sStyle){
        style = sStyle;
    }
    
    /**
    * Gets the wall plate's style
    * @return the style type for the wall plate (usually solid or Decora)
    */
    public String getStyle() {
        return style;
    }
    
     @Override
    public void display(){
        super.display();
        System.out.println("The wallplate's style is " + style);
    }
   
     public void displayStyle(){
        System.out.println("I am a Decora wallplate");
     }
}
