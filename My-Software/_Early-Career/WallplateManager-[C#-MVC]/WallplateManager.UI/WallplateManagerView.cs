using WallplateManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallplateManager.View
{
    public class WallplateManagerView
    {
        private UserIO _userIO;

        public WallplateManagerView()
        {
            _userIO = new UserIO();
        }

        public int ShowMenuAndGetUserChoice()
        {
            Console.WriteLine("\nEnter a choice from the menu below:");
            Console.WriteLine("1.Create New Wallplate");
            Console.WriteLine("2.List All Wallplates");
            Console.WriteLine("3.Find Wallplate By ID");
            Console.WriteLine("4.Edit Wallplate");
            Console.WriteLine("5.Remove Wallplate");
            Console.WriteLine("6.Exit Program");
            int userChoice = _userIO.ReadInt("Enter your choice: ", 1, 6);

            return userChoice;
        }
        public Wallplate GetNewWallplateInformation()
        {
            Wallplate wallplate = new Wallplate();

            wallplate.Title = _userIO.ReadString("\nEnter the wallplate’s title: ");
            wallplate.Color = _userIO.ReadString("Enter the wallplate’s color: ");
            wallplate.NumberPorts = _userIO.ReadInt("Enter the wallplate’s # ports: ", 1, 24);
            wallplate.Type = _userIO.ReadString("Enter the wallplate’s type: (decora or flat): ");
            if (wallplate.Type == "decora")
            {
                wallplate.DecoraIsTrue = true;
            }
            else 
            {
                wallplate.DecoraIsTrue = false;
            }
            return wallplate;
        }

        public int GetWallplateId()
        {

            int id = _userIO.ReadInt("Enter wallplate ID to search: ", 0, 1000000);

            return id;
        }



        public void DisplayWallplate(Wallplate wallplate)
        {
            Console.WriteLine("\nWallplate ID:   {0}", wallplate.WallplateID);
            Console.WriteLine("Title:   {0}", wallplate.Title);
            Console.WriteLine("Type:    {0}", wallplate.Type);
            Console.WriteLine("# Ports:        {0}", wallplate.NumberPorts);
            Console.WriteLine("Decora: {0}", wallplate.DecoraIsTrue);
        }

        public void ShowActionSuccess(string actionName)
        {
            Console.WriteLine("\n{0} executed successfully!", actionName);
        }

        public void ShowActionFailure(string actionName)
        {
            Console.WriteLine("\n{0} failed to execute properly!", actionName);
        }

        public void DisplayAllWallplates(Wallplate[] wallplate)
        {

            for (int i = 0; i < wallplate.Length; i++)
            {
                if (wallplate[i] != null)
                {
                    Console.WriteLine("Wallplate ID: {0}\tTitle: {1}\tType: {2}\tIs Decora: {3}\tColor: {4}\t#Ports: {5}"
                       , wallplate[i].WallplateID, wallplate[i].Title, wallplate[i].Type, wallplate[i].DecoraIsTrue, wallplate[i].Color, wallplate[i].NumberPorts);


                }
            }


        }
    }
}
