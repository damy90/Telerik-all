﻿namespace Computers 
{ 
    public class Ram 
    { 
        private int value; 

        public Ram(int a) 
        { 
            this.Amount = a; 
        } 

        private int Amount { get; set; } 

        public void SaveValue(int newValue) 
        { 
            this.value = newValue; 
        } 
        
        public int LoadValue() 
        { 
            return this.value; 
        } 
    } 
}