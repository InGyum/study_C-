﻿using System;
using System.Windows.Input;

namespace WpfMVVmApp.ViewModels
{
    public class RelayCommand<T> : ICommand
    {
        readonly Action<T> execute;
        readonly Predicate<T> canExecute;

        public event EventHandler CanExecuteChanged 
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public RelayCommand(Action<T> execute, Predicate<T> canExecute = null)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }

        public RelayCommand(Action<T> execute) : this(execute, null) { }

        public bool CanExecute(object parameter) => canExecute?.Invoke((T)parameter) ?? true;

        public void Execute(object parameter) => execute((T)parameter);
    }
}
