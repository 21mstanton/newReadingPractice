using System;
using System.Collections;
using System.Collections.Generic;

//this is part of the arrayList 5.1 reading practice
ArrayList storFifty = new ArrayList(50);
Account RobsAccount = new Account("Rob");
//adding to an array list
storFifty.Add(RobsAccount);
//accessing items in an arrayList
Account a = (Account) storFifty[0]; 
a.PayInFunds(50);
//removing an item
storFifty.Remove(RobsAccount);
//finding the size of the array
if(storFifty.Count == 0)
{
    Console.WriteLine("no money here");
}
