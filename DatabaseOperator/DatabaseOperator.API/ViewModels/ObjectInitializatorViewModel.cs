﻿using DatabaseOperator.API.Services;
using DataBaseOperator.Domain.Core;
using System.Collections.Generic;

namespace DatabaseOperator.API.ViewModels
{
    public class ObjectInitializatorViewModel : NotifyPropertyChanged
    {

        #region properties

        public string firstameOfUser;
        public string FirstNameOfUser 
        { 
            get { return firstameOfUser; } 
            set
            {
                firstameOfUser = value;
                CheckChanges();
            }
        }

        public string secondNameOfUser;
        public string SecondNameOfUser
        {
            get { return secondNameOfUser; }
            set
            {
                secondNameOfUser = value;
                CheckChanges();
            }
        }

        public string nameOfProduct;
        public string NameOfProduct
        {
            get { return nameOfProduct; }
            set
            {
                nameOfProduct = value;
                CheckChanges();
            }
        }

        public int priceOfProduct;
        public int PriceOfProduct
        {
            get { return priceOfProduct; }
            set
            {
                priceOfProduct = value;
                CheckChanges();
            }
        }

        #endregion

        public Command Add
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {
                        WindowInteractor.StaticUserList = new List<User> { new User { ID = "1", FirstName = FirstNameOfUser, SecondName = SecondNameOfUser, Balance = 0 } };
                        DialogWindowOperator.InitializerDialogWindow.Close();
                        DialogWindowOperator.InitializerDialogWindow = null;
                    }
                );
            }
        }

        public Command Close
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {
                        DialogWindowOperator.InitializerDialogWindow.Close();
                        DialogWindowOperator.InitializerDialogWindow = null;
                    }
                );
            }
        }
    }
}