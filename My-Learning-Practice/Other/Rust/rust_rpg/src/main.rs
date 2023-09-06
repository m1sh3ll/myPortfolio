use std::io::stdin;

const wizard:&str = "Wizard";
const elf:&str = "Elf";
const human:&str = "Human";

static mut character:&str = "";

const wizard_hp:u32 = 70;
const elf_hp:u32 = 100;
const human_hp:u32 = 150;

const dragon_hp:u32 = 300;

const wizard_damage:u32 = 150;
const elf_damage:u32 = 100;
const human_damage:u32 = 20;

const dragon_damage:u32 = 50;

static mut my_hp:u32 = 0;
static mut my_damage:u32 = 0;

fn main() {
    loop {
        println!("Welcome to the Game");
        println!("1) Wizard");
        println!("2) Elf");
        println!("3) Human");
        println!("Choose Your Character: ");

        let mut input = String::new();
        match stdin().read_line(&mut input){
            Ok(_) => {
                let choice = input.trim_end().parse::<i64>();

                match(choice){
                    Ok(guess)=> unsafe {
                        if guess == 1 {
                            character = wizard;
                            my_hp = wizard_hp;
                            my_damage = wizard_damage;
                            break;
                        }
                        else if guess == 2 {
                            character = elf;
                            my_hp = elf_hp;
                            my_damage = elf_damage;
                            break;
                        }
                        else if guess == 3 {
                            character = human;
                            my_hp = human_hp;
                            my_damage = human_damage;
                            break;
                        } else {
                            println!("Unknown character!");
                            break;
                        }
                    }
                    Err(e)=>{
                        println!("Invalid character. {}",e)
                    }
                }
            }
        }

        unsafe { println!("You have chosen the character: {}", character); }
        unsafe { println!("Health: {}", my_hp); }
        unsafe { println!("Damage: {}", my_damage); }
        println!("");

    }


}
