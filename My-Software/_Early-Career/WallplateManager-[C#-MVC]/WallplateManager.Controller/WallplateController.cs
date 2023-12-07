using WallplateManager.Data;
using WallplateManager.Models;
using WallplateManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallplateManager.Controller
{
    public class WallplateController
    {
        //global (to this module) variables         
        private WallplateManagerView _userInterface;
        private WallplateRepository _repository;

        public WallplateController()                  //default constructor
        {
            _userInterface = new WallplateManagerView();
            _repository = new WallplateRepository();
        }


        public void Run()
        {   //The menu
            bool keepRunning = true;

            while (keepRunning)
            {
                int menuChoice = _userInterface.ShowMenuAndGetUserChoice();

                switch (menuChoice)
                {
                    case 1:
                        AddWallplate();
                        break;
                    case 2:
                        ShowAllWallplates();
                        break;
                    case 3:
                        SearchWallplate();
                        break;
                    case 4:
                        UpdateWallplate();
                        break;
                    case 5:
                        DeleteWallplate();
                        break;
                    case 6:
                        //Exit Application
                        keepRunning = false;
                        break;
                }

            }
        }

        private void AddWallplate()
        {
            Wallplate newWallplate = _userInterface.GetNewWallplateInformation();  //User interface prompts for wallplate info
            Wallplate addedWallplate = _repository.CreateWallplate(newWallplate);


            if (addedWallplate != null)
            {
                _userInterface.DisplayWallplate(addedWallplate);            //Show the new wallplate  
                _userInterface.ShowActionSuccess("Add Wallplate");
            }
            else
            {   //Failed to add to repository
                _userInterface.ShowActionFailure("Add Wallplate");
            }
        }

        private void ShowAllWallplates()
        {
            Wallplate[] allWallplates = _repository.RetrieveAllWallplates(); //Controller calls data layer to retrieve all

            if (allWallplates != null)
            {
                _userInterface.DisplayAllWallplates(allWallplates);
            }

        }

        private void SearchWallplate()
        {
            int id = _userInterface.GetWallplateId();                         //User interface prompts for wallplate ID           
            Wallplate searchWallplate = _repository.RetrieveWallplateById(id);    //Controller calls data layer to search
            _userInterface.DisplayWallplate(searchWallplate);
        }

        private void DeleteWallplate()
        {
            int id = _userInterface.GetWallplateId();             //User view prompts for wallplate ID

            if (_repository.RetrieveWallplateById(id) != null)    //check if the wallplate exists
            {
                _repository.DeleteWallplate(id);                  //delete the wallplate
                _userInterface.ShowActionSuccess("Delete Wallplate");
            }
            else
            {
                _userInterface.ShowActionFailure("Delete Wallplate");
            }
        }
        private void UpdateWallplate()
        {
            int id = _userInterface.GetWallplateId();                     //User interface prompts for wallplate ID


            Wallplate wallplateToEdit = _repository.RetrieveWallplateById(id);//Controller calls data layer to search 

            if (wallplateToEdit != null)                                  //check if the wallplate exists
            {
                Wallplate updatedWallplate = _userInterface.GetNewWallplateInformation(); //User interface prompts for wallplate info
                updatedWallplate.WallplateID = wallplateToEdit.WallplateID;
                wallplateToEdit = _repository.EditWallplate(updatedWallplate);
                _userInterface.ShowActionSuccess("Update Wallplate");
            }
            else
            {
                _userInterface.ShowActionFailure("Update Wallplate");
            }
        }




    }
}
