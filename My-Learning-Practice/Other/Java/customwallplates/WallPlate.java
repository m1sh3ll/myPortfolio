
/*
 * Assignment 2
 * CLASS: Wallplate.java
 * Written by Michelle Nesbitt
 * This is a class representing a electrical/data/audio/video wall plate object
 */


package com.customwallplates.wallplate;

public class WallPlate {
   
    private byte numberOfGangs;
    private int numberOfPorts;
    private String plateColor;
    
    public WallPlate(){
        numberOfGangs = 1;
        numberOfPorts = 1;
        plateColor = "White";
        
    }
    public WallPlate(byte gangs, int ports, String color){
        numberOfGangs = gangs;
        numberOfPorts = ports;
        plateColor = color;
    }
   /**
    * Sets the number of gangs for the wall plate
    * @param gangs The number of gangs the plate is in size
    */
    public void setGangs (byte gangs) {
        numberOfGangs = gangs;
    }
    /**
    * Sets the number of ports for the wall plate
    * @param ports The number of ports the plate is in size
    */
    public void setPorts (int ports) {
        numberOfPorts = ports;
    }
    /**
    * Sets the color for the wall plate
    * @param color The color the plate is
    */
    public void setColor (String color) {
        plateColor = color;
    }
   /**
    * Gets the wall plate's gangs
    * @return the number of gangs for the plate
    */
    public byte getGangs(){
         return numberOfGangs;
    }
   /**
    * Gets the wall plate's number of ports
    * @return the number of ports for the plate
    */
    public int getPorts(){
        return numberOfPorts;
    }
    /**
    * Gets the wall plate's color
    * @return the color for the plate
    */
    public String getColor(){
        return plateColor;
    }
    /*
     * Displays the wall plate's gangs, ports, and color value.
     */
    public void display(){
        System.out.println("The wallplate's number of gangs is " + numberOfGangs);
        System.out.println("The wallplate's number of ports is " + numberOfPorts);
        System.out.println("The wallplate's color is " + plateColor);
    }
}
