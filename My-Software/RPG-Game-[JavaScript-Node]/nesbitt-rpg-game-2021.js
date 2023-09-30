// JavaScript source code
//
//======================================================
//; Author: Michelle Nesbitt / FSW-105
//; Date:   7-16-2021
//; Modified By: Michelle Nesbitt
//; Description: Project Role Playing Game 
//;=====================================================
//*/
var readLineSync = require('readLine-sync');
var enemy;
const enemies = ["Rojas", "Spetnaz", "Makarov", "Sims"];
const rewards = ["Care Package", "Attack Chopper", "Spy Plane", "RC-XD", "Counter Spy Plane"];
var name;
var enemyEnergy;
var myEnergy;
var attackOrNot;
var alive = true;
var enemyAlive = true;
var attackOrRunning = true;
var msg1 = "\n\n(a) Attack...\n(r) Run Away\nChoice: ";
var inventory = [];

function randomize(num) {
    //returns a random num from 0 to num - 1
    return Math.floor(Math.random() * num);
}

function line(type) {
    if (type === 0) {
        console.log("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
    else {
        console.log("-------------------------------------------------------------------")
    }

}

function mainmenu() {
    console.clear();
    line(0);
    console.log("        ...Welcome to the best RPG game on earth...")
    line(1);
    name = readLineSync.question("\t\t...What is your name? : ");
    name = name.toUpperCase();
    line(1);
    console.log("\n..." + name + "...In this game it is your job to defeat any enemies that appear...");
    console.log("\n\t...If you defeat an enemy, you win a reward...");
    var q = readLineSync.question("\n...Press (s) to start the game...");
    console.clear();

    if ((q === "s") || (q === "S")) {
        while (alive) {
            var q = readLineSync.question("\n...Press (w) to walk...");
            // console.clear();
            if ((q === "w") || (q === "W")) {
                walkAlongPath();
            }
        }
    }
    else {
        console.log("Invalid entry...Game canceled...");
    }

    console.log("\t\t...Game Ended!...");
}

function walkAlongPath() {
    console.log("\t\t...  ~ Walking ~  ...\n");
    //if an enemy appears
    if (randomize(3) === 0) {
        line(1);
        console.log("\n...Uh oh!... A Wild Enemy!...    (*)  (*)");
        console.log("\n                                    <    ");
        console.log("\n                                 ~------~ ")
        line(1);
        enemy = enemies[randomize(enemies.length)];
        console.log("\n\t\t...Looks like it is " + enemy + "!...");
        enemyEnergy = 10;                                                                   //set up start energy 
        myEnergy = 10;
        attackOrRunning = true;
        attackOrNot = readLineSync.question(msg1); //run or attack
        console.clear();

        while (attackOrRunning) {

            if (attackOrNot === "r") {
                var choice = randomize(2);
                if (choice === 1) {
                    line(0);
                    console.log("\t...You have escaped the enemy " + enemy + "...");
                    line(1);
                    attackOrRunning = false;
                }
                else if (choice === 0) {
                    console.log("\t...You did not escape...");
                    console.log("\t...Back to the fight...Your only choice is to attack... You nnow proceed to attack " + enemy);


                }
            }

            else if (attackOrNot === "a") {

                while ((alive) && (enemyAlive)) {                                               //alive between 1 and 10 //dead at 0

                    console.log("\t..." + name + " attacks enemy " + enemy + "!...");           //I attack - generate a random attack strength 0, 1, or 2 
                    var myattackDamagePower = randomize(3);   // Amount of damage to give

                    if (myattackDamagePower > 0) {
                        console.log("\t..." + name + " generates " + myattackDamagePower + "x HP damage..."); //stats
                    }
                    else {
                        console.log("\t..." + enemy + " blocks with zero damage..."); //stats                    
                        enemyEnergy -= myattackDamagePower;                                          ////decrease the energy
                        line(1);

                        if (enemyEnergy > 0) {
                            console.log("\t\t\t..." + enemy + " attacks you...");
                            var attackDamagePowerEnemy = randomize(3);  // Amount of damage to give
                            if (attackDamagePowerEnemy > 0) {
                                console.log("\t\t\t..." + enemy + " generates " + attackDamagePowerEnemy + "x HP damage..."); //stats
                            } else {
                                console.log("\t\t\t..." + name + " blocks with zero damage...");                            // stats
                            }
                            myEnergy -= attackDamagePowerEnemy;                     ////decrease the energy
                            if (myEnergy <= 0) {
                                myEnergy = 0;
                                alive = false;
                                line(0);
                                console.log("\n\t\t\t...The death fairy has arrived...You died!...KIA\n\n");
                                attackOrRunning = false;
                            }
                        }
                        else {
                            enemyAlive = false;
                            line(0);
                            console.log("\n\t\t\t...Enemy died!...You win!");
                            attackOrRunning = false;
                            var reward = rewards[randomize(rewards.length)];
                            inventory.push(reward)
                            enemyEnergy = 0; //for display purposes... don't show the negative
                        }

                        line(0);
                        console.log("LIFE REMAINING..." + name + ": " + myEnergy + "/10 ... " + enemy + ": " + enemyEnergy + "/10...");
                        line(1);



                    }
                }
            }
        }
    } else {
        console.log("...No enemy appeared...")
    }
}

mainmenu();