
// JavaScript source code
//
//======================================================
//; Author: Michelle Nesbitt / FSW-105
//; Date:   7-21-2021
//; Modified By: Michelle Nesbitt
//; Description: Project Role Playing Game 
//;=====================================================
//*/

const readLineSync = require('readLine-sync');

var rungame = true;
var enemy, name, input, input2, damage;
var enemyEnergy, myEnergy;
//arrays
const enemies = ["Rojas", "Spetnaz", "Makarov", "Sims"];
const rewards = ["Care Package", "Attack Chopper", "Spy Plane", "RC-XD", "Counter Spy Plane"];
var inventory = [];

//game dialog
const msge = "To start game press (Enter): ";
const msgh = "... Hello and Welcome to the best RPG Game on earth!"
const msgw = "Walking...";
const msgnoEnemy = "No enemy appeared..."
const menuw = "What do you want to do? (w) Walk, (p) Print Stats, (x) Exit: ";
const menura = "\t\t\t\t(a) Attack, (r) Run, (p) Print Stats: ";
const deathmsg = "The death fairy has arrived...You died!...\n\n";
const escmsg = "You have escaped";
const youWin = "Enemy died!...You win!";
const blocksmsg = " blocks with 0x HP damage!";
const energymsg = "\tLIFE REMAINING...";
var invstring = "\tINVENTORY: ";
const invalidmsg = "Invalid entry";
const noescmsg = "You did not escape..."

function main() {
   
    input = readLineSync.question(menuw);
    enemy = enemies[rand(enemies.length)];      // choose an enemy

    switch (input) {
        case "w":
            console.log(msgw);

            if (rand(4) === 0) {                        // 1 in 4 chance of an enemy appearing            

                console.log("Enemy " + enemy + " appears!");
                enemyEnergy = 10, myEnergy = 10;

                while ((myEnergy > 0) && (enemyEnergy > 0)) {

                    input2 = readLineSync.question(menura);

                    switch (input2) {
                        case "r":
                            if (rand(2) === 1) {   //1 in 2 chance of escaping
                                console.log(escmsg);
                            } else {
                                console.log(noescmsg);
                                input2 = "a";
                            }                            
                        case "a":
                            damage = rand(3);
                            console.log(name + " attacks enemy");
                            generateDamage(name, damage, enemy);
                            enemyEnergy -= damage;

                            if (enemyEnergy > 0) {
                                damage = rand(3);
                                console.log(enemy + " attacks you!");
                                generateDamage(enemy, damage, name);
                                myEnergy -= damage;

                                if (myEnergy <= 0) {
                                    myEnergy = 0;
                                    console.log(deathmsg);
                                }
                            }
                            else {
                                console.log(youWin);
                                var reward = rewards[rand(rewards.length)];
                                inventory.push(reward);
                                printStats();
                                return true;
                            }
                            break;
                        case "p":
                            printStats();
                    }

                }
            }
            else {
                console.log(msgnoEnemy);
                return true;
            }
            break;
        case "x":
            return false;
            break;
        case "p":
            printStats();
            break;
        default:
            console.log(invalidmsg);
    }

}
function generateDamage(a, b, c) {

    if (damage > 0) {
        console.log(a + " generates " + b + "x damage...");
    }
    else {
        console.log(c + blocksmsg);
    }
}

function printStats() {

    console.log(energymsg + name + ": " + myEnergy + "/10 ... " + enemy + ": " + enemyEnergy + "/10...");
    if (inventory.length > 0) {
        for (var i = 0; i < inventory.length; i++) {
            invstring += " " + inventory[i];
        }
        console.log(invstring);
    }
}

function rand(num) {
    return Math.floor(Math.random() * num);
}

name = readLineSync.question("What is your name?: ");
name = name.toUpperCase();
console.log(name + msgh)
readLineSync.question(msge);

while (rungame) {
    rungame = main();
}
printStats();


