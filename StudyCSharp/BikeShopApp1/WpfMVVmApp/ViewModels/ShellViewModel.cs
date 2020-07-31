﻿using System;
using System.Windows;
using System.Windows.Input;
using WpfMVVmApp.Models;

namespace WpfMVVmApp.ViewModels
{
    public class ShellViewModel :ViewModelBase
    {
        #region 맴버변수 / 속성영역
        string inLastName;
        string inFirstName;
        string inEmail;
        DateTime? inDate;

        string outLastName;
        string outFirstName;
        string outEmail;
        string outDate;
        string outAdult;
        string outBirthDay;
        string outChnZodiac;
        string outZodiac;

        public string InLastName
        {
            get => inLastName;
            set
            {
                inLastName = value;
                RaisePropertyChanged("InLastName");
            }
        }
        public string InFirstName
        {
            get => inFirstName;
            set
            {
                inFirstName = value;
                RaisePropertyChanged("InFirstName");
            }
        }
        public string InEmail
        {
            get => inEmail;
            set
            {
                inEmail = value;
                RaisePropertyChanged("InEmail");
            }
        }
        public DateTime? InDate
        {
            get => inDate;
            set
            {
                inDate = value;
                RaisePropertyChanged("InDate");
            }
        }      
        public string OutLastName
        {
            get => outLastName;
            set
            {
                outLastName = value;
                RaisePropertyChanged("OutLastName");
            }
        }
        public string OutFirstName
        {
            get => outFirstName;
            set
            {
                outFirstName = value;
                RaisePropertyChanged("OutFirstName");
            }
        }
        public string OutEmail
        {
            get => outEmail;
            set
            {
                outEmail = value;
                RaisePropertyChanged("OutEmail");
            }
        }
        public string OutDate
        {
            get => outDate;
            set
            {
                outDate = value;
                RaisePropertyChanged("OutDate");
            }
        }
        public string OutAdult
        {
            get => outAdult;
            set
            {
                outAdult = value;
                RaisePropertyChanged("OutAdult");
            }
        }
        public string OutBirthDay
        {
            get => outBirthDay;
            set
            {
                outBirthDay = value;
                RaisePropertyChanged("OutBirthDay");
            }
        }
        public string OutChnZodiac
        {
            get => outChnZodiac;
            set
            {
                outChnZodiac = value;
                RaisePropertyChanged("OutChnZodiac");
            }
        }
        public string OutZodiac
        {
            get => outZodiac;
            set
            {
                outZodiac = value;
                RaisePropertyChanged("OutZodiac");
            }
        }

        #endregion

        ICommand clickCommand;
        public ICommand ClickCommand => clickCommand ?? (clickCommand = new RelayCommand<object>(o => Click(), o => IsClick() ));

        private bool IsClick()
        {
            return (!string.IsNullOrEmpty(InLastName) &&
                !string.IsNullOrEmpty(InFirstName) &&
                !string.IsNullOrEmpty(InEmail) &&
                !string.IsNullOrEmpty(InDate.ToString()));
        }

        private void Click()
        {
            try
            {
                DateTime date = InDate ?? DateTime.Now;
                Person person = new Person(InFirstName, InLastName, InEmail, date);

                OutLastName = person.LastName;
                OutFirstName = person.FirstName;
                OutEmail = person.Email;
                OutDate = person.Date.ToShortDateString();
                OutAdult = $"{person.IsAdult}";
                OutBirthDay = $"{person.IsBirthDay}";
                OutChnZodiac = person.ChnZodiac;
                OutZodiac = person.Zodiac;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : { ex.Message}");
            }
        }
    }
}
